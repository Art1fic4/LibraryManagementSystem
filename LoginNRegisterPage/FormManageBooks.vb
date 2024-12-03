Imports System.Diagnostics.Eventing.Reader
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Transactions
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports Mysqlx.XDevAPI.Relational
Imports Org.BouncyCastle.Asn1.Cmp

Public Class FormManageBooks
    Dim dt As New DataTable()

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
        imagelist1.Images.Add(Image.FromFile("C:\Users\padil\Pictures\book.png"))
        imagelist1.Images.Add(Image.FromFile("C:\Users\padil\Downloads\book (2).png"))
        imagelist1.Images.Add(Image.FromFile("C:\Users\padil\Pictures\journal.png"))
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
            If String.IsNullOrWhiteSpace(title.Text) OrElse
                String.IsNullOrWhiteSpace(author.Text) OrElse
                String.IsNullOrWhiteSpace(genre.Text) OrElse
                Not IsDate(pubyear.Text) OrElse
                Not Integer.TryParse(quantity.Text, Nothing) OrElse
                String.IsNullOrWhiteSpace(descbox.Text) Then
                MessageBox.Show("Please fill in all fields with valid information.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            con.Open()
            Dim query As String = "UPDATE books SET Title = @Title, Author = @Author, Genre = @Genre, " &
                "PublicationYear = @PublicationYear, Quantity = @Quantity," &
                "Description = @Description WHERE BookId = @BookId"
            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@BookId", bookid.Text)
                cmd.Parameters.AddWithValue("@Title", title.Text)
                cmd.Parameters.AddWithValue("@Author", author.Text)
                cmd.Parameters.AddWithValue("@Genre", genre.Text)
                cmd.Parameters.AddWithValue("@PublicationYear", pubyear.Value)
                cmd.Parameters.AddWithValue("@Quantity", Integer.Parse(quantity.Text))
                cmd.Parameters.AddWithValue("@Description", descbox.Text)
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Book details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("MySQL error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Function BindBooksData(Optional Title As String = "") As DataTable
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
        If dt.Rows.Count = 0 Then
            MessageBox.Show("No books found with the given title.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        booksgrid.DataSource = dt
        Return dt
    End Function



    Private Sub refreshbut_Click(sender As Object, e As EventArgs) Handles refreshbut.Click
        BindBooksData()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If String.IsNullOrWhiteSpace(title.Text) OrElse
                String.IsNullOrWhiteSpace(author.Text) OrElse
                String.IsNullOrWhiteSpace(genre.Text) OrElse
                Not IsDate(pubyear.Text) OrElse
                Not Integer.TryParse(quantity.Text, Nothing) OrElse
                String.IsNullOrWhiteSpace(descbox.Text) Then
                MessageBox.Show("Please fill in all fields with valid information.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            con.Open()
            Dim query As String = "UPDATE books SET Title = @Title, Author = @Author, Genre = @Genre, " &
                "PublicationYear = @PublicationYear, Quantity = @Quantity," &
                "Description = @Description WHERE BookId = @BookId"
            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@BookId", bookid.Text)
                cmd.Parameters.AddWithValue("@Title", title.Text)
                cmd.Parameters.AddWithValue("@Author", author.Text)
                cmd.Parameters.AddWithValue("@Genre", genre.Text)
                cmd.Parameters.AddWithValue("@PublicationYear", pubyear.Value)
                cmd.Parameters.AddWithValue("@Quantity", Integer.Parse(quantity.Text))
                cmd.Parameters.AddWithValue("@Description", descbox.Text)
                cmd.ExecuteNonQuery()
            End Using
            If coverimg.Image IsNot Nothing Then
                query = "UPDATE books SET CoverImage = @CoverImage Where BookId = BookId"
                Using cmd As New MySqlCommand(query, con)
                    Dim MS As New MemoryStream()
                    coverimg.Image.Save(MS, coverimg.Image.RawFormat)
                    Dim cover As Byte() = MS.ToArray()
                    cmd.Parameters.AddWithValue("@CoverImage", cover)
                    cmd.ExecuteNonQuery()
                End Using
            End If
            MessageBox.Show("Book details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("MySQL error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub searchbuttontitle_Click(sender As Object, e As EventArgs) Handles searchbuttontitle.Click
        Dim searchValue As String = titlebox.Text.Trim()
        If String.IsNullOrWhiteSpace(searchValue) Then
            MessageBox.Show("Please enter a title to search for.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        BindBooksData(searchValue)
    End Sub

    Private Sub removebutton_Click(sender As Object, e As EventArgs) Handles removebutton.Click
        Try
            If booksgrid.SelectedRows.Count > 0 Then
                Dim bookID As String = booksgrid.SelectedRows(0).Cells("BookId").Value.ToString()
                con.Open()
                Dim query As String = "DELETE FROM books WHERE BookId = @BookId"
                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@BookID", bookID)
                    cmd.ExecuteNonQuery()
                End Using
                MessageBox.Show("Book removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Please select a book to remove.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("MySQL error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub srchbookid_Click(sender As Object, e As EventArgs) Handles srchbookid.Click
        Dim id As Integer = NumericUpDown1bookid.Value
        Dim table As DataTable = BindBooksData()

        Dim foundRows() As DataRow = table.Select("BookId = " & id)
        If foundRows.Length > 0 Then
            booktitle.Text = foundRows(0)("Title").ToString()
            booktitle.ForeColor = Color.Black
        Else
            booktitle.Text = "This ID doesn't exist"
            booktitle.ForeColor = Color.Red
        End If
    End Sub

    Private Sub srchuserid_Click(sender As Object, e As EventArgs) Handles srchuserid.Click
        Dim id As Integer = NumericUpDown2userid.Value
        Dim table As DataTable = SearchUsers()

        Dim foundRows() As DataRow = table.Select("UserID = " & id)
        If foundRows.Length > 0 Then
            userfullname.Text = foundRows(0)("Name").ToString()
            userfullname.ForeColor = Color.Black
        Else
            userfullname.Text = "This ID doesn't exist"
            userfullname.ForeColor = Color.Red
        End If
    End Sub

    Private Function SearchUsers() As DataTable
        Dim dt As New DataTable()
        Try
            con.Open()
            Dim query As String = "SELECT UserID, Name FROM user"
            Using cmd As New MySqlCommand(query, con)
                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            con.Close()
        End Try
        Return dt
    End Function
    Public Sub LoadIssuedBooks()
        Try
            con.Open()
            Dim query As String = "SELECT * FROM circulationofbooks"
            Using da As New MySqlDataAdapter(query, con)
                Dim dt As New DataTable()
                da.Fill(dt)
                Issuelist.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub issuebutton_Click(sender As Object, e As EventArgs) Handles issuebutton.Click
        Dim circulation As New circulation
        Dim bookId As Integer = NumericUpDown1bookid.Value
        Dim userId As Integer = NumericUpDown2userid.Value
        Dim issueDate As DateTime = DateTimePicker1.Value
        Dim returnDate As DateTime = DateTimePicker2.Value
        If circulation.IssueBook(bookId, userId, issueDate, returnDate) Then
            MessageBox.Show("Book Issue Successfully")
        End If



        LoadIssuedBooks()
    End Sub

    Public Class circulation
        Public Function IssueBook(bookId As Integer, userId As Integer, issueDate As DateTime, returnDate As DateTime) As Boolean
            Dim success As Boolean = False
            Try
                con.Open()
                Dim query4 As String = "SELECT Quantity FROM books WHERE BookId = @BookId"
                Dim query0 As String = "SELECT COUNT(*) FROM circulationofbooks WHERE BookId = @BookId AND UserId = @UserId"
                Dim query1 As String = "UPDATE books SET Quantity = Quantity - 1 WHERE BookId = @BookId AND Quantity > 0"
                Dim query2 As String = "INSERT INTO circulationofbooks (BookId, UserId, IssueDate, ReturnDate) VALUES (@BookId, @UserId, @IssueDate, @ReturnDate)"
                Dim query3 As String = "UPDATE books SET Quantity = 0 WHERE BookId = @BookId AND Quantity = 0"

                Using cmdcheck As New MySqlCommand(query0, con)
                    cmdcheck.Parameters.AddWithValue("@BookId", bookId)
                    cmdcheck.Parameters.AddWithValue("@UserId", userId)
                    Dim count As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())
                    If count > 0 Then
                        MessageBox.Show("You have Already Issued this book")
                        con.Close()
                        Return False
                    End If
                End Using

                Dim checkQuery As String = "SELECT Quantity FROM books WHERE BookId = @BookId"
                Using cmdCheckAvailability As New MySqlCommand(checkQuery, con)
                    cmdCheckAvailability.Parameters.AddWithValue("@BookId", bookId)
                    Dim availableQuantity As Integer = Convert.ToInt32(cmdCheckAvailability.ExecuteScalar())
                    If availableQuantity = 0 Then
                        MessageBox.Show("Not Available")

                        con.Close()
                    Return False
                    End If
                End Using




                Using transaction = con.BeginTransaction()
                    Using cmd1 As New MySqlCommand(query1, con)
                        cmd1.Parameters.AddWithValue("@BookId", bookId)
                        cmd1.Transaction = transaction
                        If cmd1.ExecuteNonQuery() > 0 Then
                            Using cmd2 As New MySqlCommand(query2, con)
                                cmd2.Parameters.AddWithValue("@BookId", bookId)
                                cmd2.Parameters.AddWithValue("@UserId", userId)
                                cmd2.Parameters.AddWithValue("@IssueDate", issueDate)
                                cmd2.Parameters.AddWithValue("@ReturnDate", returnDate)
                                cmd2.Transaction = transaction
                                If cmd2.ExecuteNonQuery() > 0 Then
                                    Using cmd3 As New MySqlCommand(query3, con)
                                        cmd3.Parameters.AddWithValue("@BookId", bookId)
                                        cmd3.Transaction = transaction
                                        cmd3.ExecuteNonQuery() ' Ensure availability is updated if needed


                                    End Using

                                    transaction.Commit()
                                    success = True
                                Else
                                    transaction.Rollback()
                                End If
                            End Using
                        Else
                            transaction.Rollback()
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            Finally
                con.Close()
            End Try
            Return success
        End Function

    End Class
End Class