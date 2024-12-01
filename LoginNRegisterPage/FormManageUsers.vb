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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles userlist.CellContentClick
        If e.RowIndex >= 0 Then
            Dim selectedrow As DataGridViewRow = userlist.Rows(e.RowIndex)
            emailbox.Text = selectedrow.Cells("Email").Value.ToString()
            passbox.Text = selectedrow.Cells("Password").Value.ToString()
            namebox.Text = selectedrow.Cells("Name").Value.ToString()
            cbxUser1.SelectedItem = selectedrow.Cells("TypeOfAccount").Value.ToString()
        End If
    End Sub

    Private Sub searchbut_Click(sender As Object, e As EventArgs) Handles searchbut.Click
        Dim searchQuery As String = txtSearch.Text
        Dim dt As DataTable = SearchUsers(searchQuery)
        If dt.Rows.Count > 0 Then
            userlist.DataSource = dt
            MessageBox.Show("User Found")
            userlist.Visible = True
        Else
            MessageBox.Show("No results with that name.")
        End If
    End Sub
    Private Function SearchUsers(Name As String) As DataTable
        Dim dt As New DataTable()
        Try
            con.Open()
            Dim query As String = "SELECT * FROM user WHERE Name LIKE @Name"
            Using cmd = New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@Name", "%" & Name & "%")
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

    Private Sub Addbut_Click(sender As Object, e As EventArgs) Handles addbut.Click
        If String.IsNullOrEmpty(emailbox.Text) OrElse String.IsNullOrEmpty(passbox.Text) OrElse String.IsNullOrEmpty(namebox.Text) OrElse cbxUser1.SelectedItem Is Nothing Then
            MessageBox.Show("Please input all required information.")
            Return
        End If
        Try
            con.Open()
            Dim query As String = "INSERT INTO user(`Email`,`Password`,`Name`,`TypeOfAccount`) VALUES ('" & emailbox.Text & "','" & passbox.Text & "','" & namebox.Text & "','" & cbxUser1.SelectedItem & "')"
            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@Email", emailbox.Text)
                cmd.Parameters.AddWithValue("@Password", passbox.Text)
                cmd.Parameters.AddWithValue("@Name", namebox.Text)
                cmd.Parameters.AddWithValue("@TypeOfAccount", namebox.Text)
                cmd.ExecuteNonQuery()
            End Using
            MessageBox.Show("User added succesfully!")
        Catch ex As Exception
            MessageBox.Show("Mysql error: " & ex.Message)
        Finally
            con.Close()

        End Try
    End Sub

    Private Sub delbut_Click(sender As Object, e As EventArgs) Handles delbut.Click
        If userlist.SelectedCells.Count = 0 Then
            MessageBox.Show("Please select a user to delete from the list.")
            Return
        End If

        Try
            con.Open()
            Dim query As String = "DELETE from user where email = @Email"
            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@Email", emailbox.Text)
                cmd.ExecuteNonQuery()
            End Using
            MessageBox.Show("User Deleted succesfully!")
        Catch ex As Exception
            MessageBox.Show("Mysql error: " & ex.Message)
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub editbut_Click(sender As Object, e As EventArgs) Handles editbut.Click
        If userlist.SelectedCells.Count = 0 Then
            MessageBox.Show("Please select a user to edit from the list.")
            Return
        End If
        Try
            Dim selectedRow As DataGridViewRow = userlist.Rows(userlist.SelectedCells(0).RowIndex)
            Dim selecteduserid As String = selectedRow.Cells("UserID").Value.ToString()

            con.Open()
            Dim query As String = "UPDATE user SET Name = @Name, TypeOfAccount = @TypeOfAccount, Password = @Password, Email = @Email Where UserID = @UserID "
            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@Email", emailbox.Text)
                cmd.Parameters.AddWithValue("@Password", passbox.Text)
                cmd.Parameters.AddWithValue("@Name", namebox.Text)
                cmd.Parameters.AddWithValue("@TypeOfAccount", cbxUser1.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@UserID", selecteduserid)
                cmd.ExecuteNonQuery()

            End Using
            selectedRow.Cells("Name").Value = namebox.Text
            selectedRow.Cells("TypeOfAccount").Value = cbxUser1.SelectedItem.ToString()
            selectedRow.Cells("Password").Value = passbox.Text
            selectedRow.Cells("Email").Value = emailbox.Text

            MessageBox.Show("User edited successfully!")
        Catch ex As Exception
            MessageBox.Show("MySQL error: " & ex.Message)
        Finally
            con.Close()

        End Try
    End Sub

    Private Sub clrbut_Click(sender As Object, e As EventArgs) Handles clrbut.Click
        emailbox.Clear()
        passbox.Clear()
        namebox.Clear()

        userlist.DataSource = Nothing
        userlist.Rows.Clear()
    End Sub
End Class