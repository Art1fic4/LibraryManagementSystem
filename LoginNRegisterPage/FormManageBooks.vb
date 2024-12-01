Imports System.Diagnostics.Eventing.Reader
Imports System.IO
Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports Org.BouncyCastle.Asn1.Cmp

Public Class FormManageBooks
    ' Import the CreateRoundRectRgn function from the Windows API
    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function CreateRoundRectRgn(
            ByVal nLeftRect As Integer,
            ByVal nTopRect As Integer,
            ByVal nRightRect As Integer,
            ByVal nBottomRect As Integer,
            ByVal nWidthEllipse As Integer,
            ByVal nHeightEllipse As Integer) As IntPtr
    End Function

    ' Variables for dragging the form
    Private drag As Boolean
    Private mouseX As Integer
    Private mouseY As Integer

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim imagelist1 As New ImageList

        imagelist1.Images.Add(Image.FromFile("C:\Users\padil\Pictures\book (1).png"))
        imagelist1.Images.Add(Image.FromFile("C:\Users\padil\Pictures\journal.png"))
        imagelist1.Images.Add(Image.FromFile("C:\Users\padil\Pictures\book.png"))
        TABS.ImageList = imagelist1


        ' Remove the default title bar
        ' Me.FormBorderStyle = FormBorderStyle.None

        ' Set a clean, rounded corner radius
        Dim radius As Integer = 20  ' Use a smaller value for crisper edges
        Me.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Me.Width, Me.Height, radius, radius))

        ' Optional: Set background color to highlight edges better
        Me.BackColor = Color.White

        ' Add click event handlers
        AddHandler CloseWindow3.Click, AddressOf CloseWindow3_Click
        AddHandler MinimizedWindow3.Click, AddressOf MinimizedWindow3_Click

        ' Add hover effect event handlers
        AddHandler CloseWindow3.MouseEnter, AddressOf CloseWindow3_MouseEnter
        AddHandler CloseWindow3.MouseLeave, AddressOf CloseWindow3_MouseLeave
        AddHandler MinimizedWindow3.MouseEnter, AddressOf MinimizedWindow3_MouseEnter
        AddHandler MinimizedWindow3.MouseLeave, AddressOf MinimizedWindow3_MouseLeave
        AddHandler MaximizeWindow3.MouseEnter, AddressOf MaximizeWindow3_MouseEnter
        AddHandler MaximizeWindow3.MouseLeave, AddressOf MaximizeWindow3_MouseLeave

        ' Add dragging events to the Panel
        AddHandler Panel1.MouseDown, AddressOf Panel_MouseDown
        AddHandler Panel1.MouseMove, AddressOf Panel_MouseMove
        AddHandler Panel1.MouseUp, AddressOf Panel_MouseUp

        AddHandler Panel2.MouseDown, AddressOf Panel_MouseDown
        AddHandler Panel2.MouseMove, AddressOf Panel_MouseMove
        AddHandler Panel2.MouseUp, AddressOf Panel_MouseUp
    End Sub

    Private Sub BackWindow1_Click(sender As Object, e As EventArgs) Handles BackWindow1.Click
        AdminDashboard.Show()
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CloseWindow3_Click(sender As Object, e As EventArgs) Handles CloseWindow3.Click
        Me.Close()
    End Sub

    Private Sub MaximizeWindow3_Click(sender As Object, e As EventArgs) Handles MaximizeWindow3.Click
        If Me.WindowState = FormWindowState.Normal Then
            ' Maximize the form
            Me.WindowState = FormWindowState.Maximized
            ' Manually set the form size to fill the screen
            Me.Bounds = Screen.PrimaryScreen.Bounds
            ' Recalculate region for rounded corners after maximizing
            Dim radius As Integer = 20  ' Adjust for rounded corners
            Me.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Me.Width, Me.Height, radius, radius))
        Else
            ' Restore the form to its normal size
            Me.WindowState = FormWindowState.Normal
            ' Recalculate region for rounded corners when restored
            Dim radius As Integer = 20
            Me.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Me.Width, Me.Height, radius, radius))
        End If
    End Sub
    ' Event handlers for CloseWindow1 hover effects
    Private Sub CloseWindow3_MouseEnter(sender As Object, e As EventArgs)
        CType(sender, PictureBox).Cursor = Cursors.Hand  ' Change cursor to hand on hover
    End Sub

    Private Sub CloseWindow3_MouseLeave(sender As Object, e As EventArgs)
        CType(sender, PictureBox).Cursor = Cursors.Default  ' Revert cursor to default
    End Sub

    ' Event handler for minimize button click
    Private Sub MinimizedWindow3_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    ' Event handlers for MinimizedWindow1 hover effects
    Private Sub MinimizedWindow3_MouseEnter(sender As Object, e As EventArgs)
        CType(sender, PictureBox).Cursor = Cursors.Hand  ' Change cursor to hand on hover
    End Sub

    Private Sub MinimizedWindow3_MouseLeave(sender As Object, e As EventArgs)
        CType(sender, PictureBox).Cursor = Cursors.Default  ' Revert cursor to default
    End Sub

    Private Sub MaximizeWindow3_MouseEnter(sender As Object, e As EventArgs)
        CType(sender, PictureBox).Cursor = Cursors.Hand  ' Change cursor to hand on hover
    End Sub

    Private Sub MaximizeWindow3_MouseLeave(sender As Object, e As EventArgs)
        CType(sender, PictureBox).Cursor = Cursors.Default  ' Revert cursor to default
    End Sub

    ' Mouse Down event to start dragging
    Private Sub Panel_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        drag = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub

    ' Mouse Move event to drag the form
    Private Sub Panel_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub

    ' Mouse Up event to stop dragging
    Private Sub Panel_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        drag = False
    End Sub



    Private Sub addbook_Click(sender As Object, e As EventArgs) Handles addbook.Click
        If String.IsNullOrWhiteSpace(title.Text) OrElse String.IsNullOrWhiteSpace(author.Text) OrElse String.IsNullOrWhiteSpace(genre.Text) OrElse Not IsDate(pubyear.Text) OrElse Not Integer.TryParse(quantity.Text, Nothing) OrElse String.IsNullOrWhiteSpace(descbox.Text) OrElse coverimg.Image Is Nothing Then
            MessageBox.Show("Please fill in all fields with valid information.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Try
            con.Open()
            Dim query As String = "INSERT INTO books(`Title`, `Author`, `Genre`, `PublicationYear`, `Quantity`, `Description`, `CoverImage`) " & "VALUES (@Title, @Author, @Genre, @PublicationYear, @Quantity, @Description, @CoverImage)"
            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@Title", title.Text)
                cmd.Parameters.AddWithValue("@Author", author.Text)
                cmd.Parameters.AddWithValue("@Genre", genre.Text)
                cmd.Parameters.AddWithValue("@PublicationYear", pubyear.Value)
                cmd.Parameters.AddWithValue("@Quantity", CInt(quantity.Text))
                cmd.Parameters.AddWithValue("@Description", descbox.Text)
                Dim ms As New MemoryStream()
                coverimg.Image.Save(ms, coverimg.Image.RawFormat)
                Dim cover As Byte() = ms.ToArray()
                cmd.Parameters.AddWithValue("@CoverImage", cover)
                cmd.ExecuteNonQuery()
            End Using
            MessageBox.Show("Book added succesfully!")
        Catch ex As Exception
            MessageBox.Show("Mysql error: " & ex.Message)
        Finally
            con.Close()

        End Try
    End Sub

    Private Sub clearbut_Click(sender As Object, e As EventArgs) Handles clearbut.Click
        bookid.Text = ""
        title.Text = ""
        author.Text = ""
        genre.Text = ""
        pubyear.Value = Date.Now
        quantity.Value = 0
        descbox.Text = ""
        coverimg.Image = Image.FromFile("C:\Users\padil\Downloads\open-book.png")

    End Sub

    Private Sub selectbut_Click(sender As Object, e As EventArgs) Handles selectbut.Click
        Dim opf As New OpenFileDialog()
        opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif"


        If opf.ShowDialog() = DialogResult.OK Then
            coverimg.Image = Image.FromFile(opf.FileName)
        End If

    End Sub

    Private Sub searchbookid_Click(sender As Object, e As EventArgs) Handles searchbookid.Click
        Try
            If String.IsNullOrWhiteSpace(bookid.Text) Then
                MessageBox.Show("Please enter a BookID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            con.Open()
            Dim query As String = "SELECT * FROM books WHERE BookId = @BookId"
            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@BookId", bookid.Text)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        title.Text = reader("Title").ToString()
                        author.Text = reader("Author").ToString()
                        genre.Text = reader("Genre").ToString()
                        pubyear.Value = DateTime.Parse(reader("PublicationYear").ToString())
                        quantity.Text = reader("Quantity").ToString()
                        descbox.Text = reader("Description").ToString()

                        Dim imgData As Byte() = CType(reader("CoverImage"), Byte())
                        If imgData IsNot Nothing AndAlso imgData.Length > 0 Then
                            Using ms As New MemoryStream(imgData)
                                coverimg.Image = Image.FromStream(ms)
                            End Using
                        Else
                            coverimg.Image = Nothing
                        End If

                    Else
                        MessageBox.Show("Book not found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("MySQL error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub editbook_Click(sender As Object, e As EventArgs) Handles editbook.Click
        Try
            If String.IsNullOrWhiteSpace(title.Text) OrElse String.IsNullOrWhiteSpace(author.Text) OrElse String.IsNullOrWhiteSpace(genre.Text) OrElse Not IsDate(pubyear.Text) OrElse Not Integer.TryParse(quantity.Text, Nothing) OrElse String.IsNullOrWhiteSpace(descbox.Text) OrElse coverimg.Image Is Nothing Then
                MessageBox.Show("Please fill in all fields with valid information.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            con.Open()
            Dim query As String = "UPDATE books SET Title = @Title, Author = @Author, Genre = @Genre, " & "PublicationYear = @PublicationYear, Quantity = @Quantity, " & "Description = @Description, CoverImage = @CoverImage WHERE BookID = @BookID"
            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@BookID", bookid.Text)
                cmd.Parameters.AddWithValue("@Title", title.Text)
                cmd.Parameters.AddWithValue("@Author", author.Text)
                cmd.Parameters.AddWithValue("@Genre", genre.Text)
                cmd.Parameters.AddWithValue("@PublicationYear", DateTime.Parse(pubyear.Text))
                cmd.Parameters.AddWithValue("@Quantity", Integer.Parse(quantity.Text))
                cmd.Parameters.AddWithValue("@Description", descbox.Text)
                Dim MS As New MemoryStream()
                coverimg.Image.Save(MS, coverimg.Image.RawFormat)
                Dim cover As Byte() = MS.ToArray()
                cmd.Parameters.AddWithValue("@CoverImage", cover)
                cmd.ExecuteNonQuery()
            End Using
            MessageBox.Show("Book details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("MySQL error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub BindBooksData(Optional Title As String = "")
        Dim dt As New DataTable()
        Try
            con.Open()
            Dim query As String
            If String.IsNullOrWhiteSpace(Title) Then
                query = "SELECT BookId, Title, Author, Genre, PublicationYear, Quantity, Description FROM books"
            Else
                query = "SELECT BookId, Title, Author, Genre, PublicationYear, Quantity, Description FROM books WHERE Title LIKE @Title"
            End If
            Using cmd = New MySqlCommand(query, con)
                If Not String.IsNullOrWhiteSpace(Title) Then
                    cmd.Parameters.AddWithValue("@Title", "%" & Title & "%")
                End If
                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            con.Close()
        End Try
        booksgrid.DataSource = dt
    End Sub



    Private Sub refreshbut_Click(sender As Object, e As EventArgs) Handles refreshbut.Click
        BindBooksData()
    End Sub
End Class