Imports System.Runtime.InteropServices
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
End Class
