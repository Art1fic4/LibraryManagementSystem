Imports System.Diagnostics.Eventing.Reader
Imports System.Reflection.Emit
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient

Public Class FormManageUsers
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

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Remove the default title bar
        ' Me.FormBorderStyle = FormBorderStyle.None

        ' Set a clean, rounded corner radius
        Dim radius As Integer = 20  ' Use a smaller value for crisper edges
        Me.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Me.Width, Me.Height, radius, radius))

        ' Optional: Set background color to highlight edges better
        Me.BackColor = Color.White

        ' Add click event handlers
        AddHandler CloseWindow3.Click, AddressOf CloseWindow1_Click
        AddHandler MinimizedWindow3.Click, AddressOf MinimizedWindow1_Click

        ' Add hover effect event handlers
        AddHandler CloseWindow3.MouseEnter, AddressOf CloseWindow1_MouseEnter
        AddHandler CloseWindow3.MouseLeave, AddressOf CloseWindow1_MouseLeave
        AddHandler MinimizedWindow3.MouseEnter, AddressOf MinimizedWindow1_MouseEnter
        AddHandler MinimizedWindow3.MouseLeave, AddressOf MinimizedWindow1_MouseLeave
        AddHandler MaximizeWindow3.MouseEnter, AddressOf MaximizeWindow1_MouseEnter
        AddHandler MaximizeWindow3.MouseLeave, AddressOf MaximizeWindow1_MouseLeave

        ' Add dragging events to the Panel
        AddHandler Panel1.MouseDown, AddressOf Panel_MouseDown
        AddHandler Panel1.MouseMove, AddressOf Panel_MouseMove
        AddHandler Panel1.MouseUp, AddressOf Panel_MouseUp

        AddHandler Panel2.MouseDown, AddressOf Panel_MouseDown
        AddHandler Panel2.MouseMove, AddressOf Panel_MouseMove
        AddHandler Panel2.MouseUp, AddressOf Panel_MouseUp
    End Sub

    Private Sub CloseWindow1_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    ' Event handlers for CloseWindow1 hover effects
    Private Sub CloseWindow1_MouseEnter(sender As Object, e As EventArgs)
        CType(sender, PictureBox).Cursor = Cursors.Hand  ' Change cursor to hand on hover
    End Sub

    Private Sub CloseWindow1_MouseLeave(sender As Object, e As EventArgs)
        CType(sender, PictureBox).Cursor = Cursors.Default  ' Revert cursor to default
    End Sub

    ' Event handler for minimize button click
    Private Sub MinimizedWindow1_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    ' Event handlers for MinimizedWindow1 hover effects
    Private Sub MinimizedWindow1_MouseEnter(sender As Object, e As EventArgs)
        CType(sender, PictureBox).Cursor = Cursors.Hand  ' Change cursor to hand on hover
    End Sub

    Private Sub MinimizedWindow1_MouseLeave(sender As Object, e As EventArgs)
        CType(sender, PictureBox).Cursor = Cursors.Default  ' Revert cursor to default
    End Sub

    Private Sub MaximizeWindow1_MouseEnter(sender As Object, e As EventArgs)
        CType(sender, PictureBox).Cursor = Cursors.Hand  ' Change cursor to hand on hover
    End Sub

    Private Sub MaximizeWindow1_MouseLeave(sender As Object, e As EventArgs)
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

    Private Sub MaximizeWindow1_Click(sender As Object, e As EventArgs) Handles MaximizeWindow3.Click
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

    Private Sub BackWindow1_Click(sender As Object, e As EventArgs) Handles BackWindow1.Click
        AdminDashboard.Show()
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

    End Sub

    Private Sub searchbut_Click(sender As Object, e As EventArgs) Handles searchbut.Click
        Dim query As String = txtSearch.Text
        Dim dt As DataTable = SearchUsers(query)

        If dt.Rows.Count > 0 Then
            DataGridView1.DataSource = dt
            DataGridView1.Visible = True
        Else
            MessageBox.Show("No results found for your query.")
        End If
    End Sub
    Private Function SearchUsers(query As String) As DataTable
        Dim dt As New DataTable()
        Dim cmd As MySqlCommand
        Try
            con.Open()


            Dim sqlQuery As String = "SELECT * FROM user WHERE Name LIKE @query"
            cmd = New MySqlCommand(sqlQuery, con)
            cmd.Parameters.AddWithValue("@query", "%" & query & "%")


            Dim da As New MySqlDataAdapter(cmd)
            da.Fill(dt)

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally

            If con IsNot Nothing AndAlso con.State = ConnectionState.Open Then
                con.Close()
            End If


            If cmd IsNot Nothing Then
                cmd.Dispose()
            End If
        End Try

        Return dt
    End Function
End Class