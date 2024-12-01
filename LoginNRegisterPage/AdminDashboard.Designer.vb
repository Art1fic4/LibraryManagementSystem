<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnLogout1 = New Guna.UI2.WinForms.Guna2Button()
        Me.btnLMSDashboard1 = New Guna.UI2.WinForms.Guna2Button()
        Me.btnViewRecords1 = New Guna.UI2.WinForms.Guna2Button()
        Me.btnManageBooks1 = New Guna.UI2.WinForms.Guna2Button()
        Me.btnManageUsers1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MinimizedWindow2 = New System.Windows.Forms.PictureBox()
        Me.MaximizeWindow2 = New System.Windows.Forms.PictureBox()
        Me.CloseWindow2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.MinimizedWindow2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaximizeWindow2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CloseWindow2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel1.Controls.Add(Me.MinimizedWindow2)
        Me.Panel1.Controls.Add(Me.MaximizeWindow2)
        Me.Panel1.Controls.Add(Me.CloseWindow2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(372, 47)
        Me.Panel1.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnLogout1)
        Me.Panel2.Controls.Add(Me.btnLMSDashboard1)
        Me.Panel2.Controls.Add(Me.btnViewRecords1)
        Me.Panel2.Controls.Add(Me.btnManageBooks1)
        Me.Panel2.Controls.Add(Me.btnManageUsers1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 47)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(372, 482)
        Me.Panel2.TabIndex = 3
        '
        'btnLogout1
        '
        Me.btnLogout1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnLogout1.BorderRadius = 15
        Me.btnLogout1.FillColor = System.Drawing.Color.Black
        Me.btnLogout1.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout1.ForeColor = System.Drawing.Color.White
        Me.btnLogout1.Location = New System.Drawing.Point(62, 385)
        Me.btnLogout1.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLogout1.Name = "btnLogout1"
        Me.btnLogout1.Size = New System.Drawing.Size(252, 44)
        Me.btnLogout1.TabIndex = 5
        Me.btnLogout1.Text = "Logout"
        '
        'btnLMSDashboard1
        '
        Me.btnLMSDashboard1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnLMSDashboard1.BorderRadius = 15
        Me.btnLMSDashboard1.FillColor = System.Drawing.Color.Black
        Me.btnLMSDashboard1.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLMSDashboard1.ForeColor = System.Drawing.Color.White
        Me.btnLMSDashboard1.Location = New System.Drawing.Point(62, 315)
        Me.btnLMSDashboard1.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLMSDashboard1.Name = "btnLMSDashboard1"
        Me.btnLMSDashboard1.Size = New System.Drawing.Size(252, 44)
        Me.btnLMSDashboard1.TabIndex = 4
        Me.btnLMSDashboard1.Text = "LMS Dashboard"
        '
        'btnViewRecords1
        '
        Me.btnViewRecords1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnViewRecords1.BorderRadius = 15
        Me.btnViewRecords1.FillColor = System.Drawing.Color.Black
        Me.btnViewRecords1.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewRecords1.ForeColor = System.Drawing.Color.White
        Me.btnViewRecords1.Location = New System.Drawing.Point(62, 245)
        Me.btnViewRecords1.Margin = New System.Windows.Forms.Padding(2)
        Me.btnViewRecords1.Name = "btnViewRecords1"
        Me.btnViewRecords1.Size = New System.Drawing.Size(252, 44)
        Me.btnViewRecords1.TabIndex = 3
        Me.btnViewRecords1.Text = "ViewRecords"
        '
        'btnManageBooks1
        '
        Me.btnManageBooks1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnManageBooks1.BorderRadius = 15
        Me.btnManageBooks1.FillColor = System.Drawing.Color.Black
        Me.btnManageBooks1.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageBooks1.ForeColor = System.Drawing.Color.White
        Me.btnManageBooks1.Location = New System.Drawing.Point(62, 176)
        Me.btnManageBooks1.Margin = New System.Windows.Forms.Padding(2)
        Me.btnManageBooks1.Name = "btnManageBooks1"
        Me.btnManageBooks1.Size = New System.Drawing.Size(252, 44)
        Me.btnManageBooks1.TabIndex = 2
        Me.btnManageBooks1.Text = "Manage Books"
        '
        'btnManageUsers1
        '
        Me.btnManageUsers1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnManageUsers1.BorderRadius = 15
        Me.btnManageUsers1.FillColor = System.Drawing.Color.Black
        Me.btnManageUsers1.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageUsers1.ForeColor = System.Drawing.Color.White
        Me.btnManageUsers1.Location = New System.Drawing.Point(62, 106)
        Me.btnManageUsers1.Margin = New System.Windows.Forms.Padding(2)
        Me.btnManageUsers1.Name = "btnManageUsers1"
        Me.btnManageUsers1.Size = New System.Drawing.Size(252, 44)
        Me.btnManageUsers1.TabIndex = 1
        Me.btnManageUsers1.Text = "Manage Users"
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(372, 68)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Admin Dashboard"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MinimizedWindow2
        '
        Me.MinimizedWindow2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MinimizedWindow2.Image = Global.LoginNRegisterPage.My.Resources.Resources.MinimizedWindow
        Me.MinimizedWindow2.Location = New System.Drawing.Point(276, 11)
        Me.MinimizedWindow2.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimizedWindow2.Name = "MinimizedWindow2"
        Me.MinimizedWindow2.Size = New System.Drawing.Size(21, 21)
        Me.MinimizedWindow2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MinimizedWindow2.TabIndex = 4
        Me.MinimizedWindow2.TabStop = False
        '
        'MaximizeWindow2
        '
        Me.MaximizeWindow2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaximizeWindow2.Image = Global.LoginNRegisterPage.My.Resources.Resources.MaximizeWindow
        Me.MaximizeWindow2.Location = New System.Drawing.Point(310, 11)
        Me.MaximizeWindow2.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeWindow2.Name = "MaximizeWindow2"
        Me.MaximizeWindow2.Size = New System.Drawing.Size(21, 21)
        Me.MaximizeWindow2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MaximizeWindow2.TabIndex = 3
        Me.MaximizeWindow2.TabStop = False
        '
        'CloseWindow2
        '
        Me.CloseWindow2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseWindow2.Image = Global.LoginNRegisterPage.My.Resources.Resources.CloseWindow
        Me.CloseWindow2.Location = New System.Drawing.Point(342, 11)
        Me.CloseWindow2.Margin = New System.Windows.Forms.Padding(2)
        Me.CloseWindow2.Name = "CloseWindow2"
        Me.CloseWindow2.Size = New System.Drawing.Size(21, 21)
        Me.CloseWindow2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CloseWindow2.TabIndex = 1
        Me.CloseWindow2.TabStop = False
        '
        'AdminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 529)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "AdminDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.MinimizedWindow2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaximizeWindow2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CloseWindow2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MinimizedWindow2 As PictureBox
    Friend WithEvents MaximizeWindow2 As PictureBox
    Friend WithEvents CloseWindow2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnManageUsers1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnLogout1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnLMSDashboard1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnViewRecords1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnManageBooks1 As Guna.UI2.WinForms.Guna2Button
End Class
