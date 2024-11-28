<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormManageUsers
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MinimizedWindow3 = New System.Windows.Forms.PictureBox()
        Me.MaximizeWindow3 = New System.Windows.Forms.PictureBox()
        Me.CloseWindow3 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.searchbut = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BackWindow1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.MinimizedWindow3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaximizeWindow3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CloseWindow3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BackWindow1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel1.Controls.Add(Me.MinimizedWindow3)
        Me.Panel1.Controls.Add(Me.MaximizeWindow3)
        Me.Panel1.Controls.Add(Me.CloseWindow3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1000, 47)
        Me.Panel1.TabIndex = 0
        '
        'MinimizedWindow3
        '
        Me.MinimizedWindow3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MinimizedWindow3.Image = Global.LoginNRegisterPage.My.Resources.Resources.MinimizedWindow
        Me.MinimizedWindow3.Location = New System.Drawing.Point(903, 14)
        Me.MinimizedWindow3.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimizedWindow3.Name = "MinimizedWindow3"
        Me.MinimizedWindow3.Size = New System.Drawing.Size(21, 21)
        Me.MinimizedWindow3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MinimizedWindow3.TabIndex = 7
        Me.MinimizedWindow3.TabStop = False
        '
        'MaximizeWindow3
        '
        Me.MaximizeWindow3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaximizeWindow3.Image = Global.LoginNRegisterPage.My.Resources.Resources.MaximizeWindow
        Me.MaximizeWindow3.Location = New System.Drawing.Point(937, 14)
        Me.MaximizeWindow3.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeWindow3.Name = "MaximizeWindow3"
        Me.MaximizeWindow3.Size = New System.Drawing.Size(21, 21)
        Me.MaximizeWindow3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MaximizeWindow3.TabIndex = 6
        Me.MaximizeWindow3.TabStop = False
        '
        'CloseWindow3
        '
        Me.CloseWindow3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseWindow3.Image = Global.LoginNRegisterPage.My.Resources.Resources.CloseWindow
        Me.CloseWindow3.Location = New System.Drawing.Point(969, 14)
        Me.CloseWindow3.Margin = New System.Windows.Forms.Padding(2)
        Me.CloseWindow3.Name = "CloseWindow3"
        Me.CloseWindow3.Size = New System.Drawing.Size(21, 21)
        Me.CloseWindow3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CloseWindow3.TabIndex = 5
        Me.CloseWindow3.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.BackWindow1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 47)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1000, 553)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.DataGridView1)
        Me.Panel3.Controls.Add(Me.TextBox5)
        Me.Panel3.Controls.Add(Me.TextBox4)
        Me.Panel3.Controls.Add(Me.TextBox3)
        Me.Panel3.Controls.Add(Me.TextBox2)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.searchbut)
        Me.Panel3.Controls.Add(Me.txtSearch)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(88, 32)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(881, 488)
        Me.Panel3.TabIndex = 16
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(628, 401)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(159, 30)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Delete" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(419, 401)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(159, 30)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Display"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(360, 18)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 22)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "User's List"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(360, 59)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(489, 318)
        Me.DataGridView1.TabIndex = 12
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(40, 361)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox5.Size = New System.Drawing.Size(200, 20)
        Me.TextBox5.TabIndex = 11
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(40, 312)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox4.Size = New System.Drawing.Size(200, 20)
        Me.TextBox4.TabIndex = 10
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(40, 265)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox3.Size = New System.Drawing.Size(200, 20)
        Me.TextBox3.TabIndex = 9
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(39, 219)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox2.Size = New System.Drawing.Size(200, 20)
        Me.TextBox2.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(40, 345)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(73, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Book Title:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(40, 297)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(159, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "No# of Books Borrowed:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 249)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(151, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Borrowed Book Status:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 204)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(75, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Username:"
        '
        'searchbut
        '
        Me.searchbut.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchbut.Location = New System.Drawing.Point(38, 124)
        Me.searchbut.Margin = New System.Windows.Forms.Padding(2)
        Me.searchbut.Name = "searchbut"
        Me.searchbut.Size = New System.Drawing.Size(79, 28)
        Me.searchbut.TabIndex = 3
        Me.searchbut.Text = "Search"
        Me.searchbut.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(38, 89)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSearch.Size = New System.Drawing.Size(200, 20)
        Me.txtSearch.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 61)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(59, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name:"
        '
        'BackWindow1
        '
        Me.BackWindow1.Image = Global.LoginNRegisterPage.My.Resources.Resources.BackWindow
        Me.BackWindow1.Location = New System.Drawing.Point(4, 4)
        Me.BackWindow1.Margin = New System.Windows.Forms.Padding(2)
        Me.BackWindow1.Name = "BackWindow1"
        Me.BackWindow1.Size = New System.Drawing.Size(50, 50)
        Me.BackWindow1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BackWindow1.TabIndex = 0
        Me.BackWindow1.TabStop = False
        '
        'FormManageUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 600)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormManageUsers"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormManageUsers"
        Me.Panel1.ResumeLayout(False)
        CType(Me.MinimizedWindow3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaximizeWindow3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CloseWindow3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BackWindow1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MinimizedWindow3 As PictureBox
    Friend WithEvents MaximizeWindow3 As PictureBox
    Friend WithEvents CloseWindow3 As PictureBox
    Friend WithEvents BackWindow1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents searchbut As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel3 As Panel
End Class
