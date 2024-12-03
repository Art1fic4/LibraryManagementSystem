<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormManageBooks
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormManageBooks))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TABS = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.editbook = New System.Windows.Forms.Button()
        Me.searchbookid = New System.Windows.Forms.Button()
        Me.coverimg = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.descbox = New System.Windows.Forms.RichTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.quantity = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pubyear = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.addbook = New System.Windows.Forms.Button()
        Me.clearbut = New System.Windows.Forms.Button()
        Me.genre = New System.Windows.Forms.TextBox()
        Me.author = New System.Windows.Forms.TextBox()
        Me.title = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.selectbut = New System.Windows.Forms.Button()
        Me.bookid = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.removebutton = New System.Windows.Forms.Button()
        Me.searchbuttontitle = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.titlebox = New System.Windows.Forms.TextBox()
        Me.refreshbut = New System.Windows.Forms.Button()
        Me.booksgrid = New System.Windows.Forms.DataGridView()
        Me.issuebooks = New System.Windows.Forms.TabPage()
        Me.issuebutton = New System.Windows.Forms.Button()
        Me.srchuserid = New System.Windows.Forms.Button()
        Me.srchbookid = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.yesno = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.userfullname = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.NumericUpDown2userid = New System.Windows.Forms.NumericUpDown()
        Me.booktitle = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.NumericUpDown1bookid = New System.Windows.Forms.NumericUpDown()
        Me.returnbooks = New System.Windows.Forms.TabPage()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.refreshdataissuelist = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.label20 = New System.Windows.Forms.Label()
        Me.returnbookbut = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Issuelist = New System.Windows.Forms.DataGridView()
        Me.returndatebox = New System.Windows.Forms.TextBox()
        Me.issuedatebox = New System.Windows.Forms.TextBox()
        Me.useridbox = New System.Windows.Forms.TextBox()
        Me.bookidbox = New System.Windows.Forms.TextBox()
        Me.label19 = New System.Windows.Forms.Label()
        Me.BackWindow1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MinimizedWindow3 = New System.Windows.Forms.PictureBox()
        Me.MaximizeWindow3 = New System.Windows.Forms.PictureBox()
        Me.CloseWindow3 = New System.Windows.Forms.PictureBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TABS.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.coverimg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.quantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.booksgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.issuebooks.SuspendLayout()
        CType(Me.NumericUpDown2userid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1bookid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.returnbooks.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.Issuelist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BackWindow1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.MinimizedWindow3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaximizeWindow3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CloseWindow3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 47)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(966, 511)
        Me.Panel2.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel3.Controls.Add(Me.TABS)
        Me.Panel3.Controls.Add(Me.BackWindow1)
        Me.Panel3.Location = New System.Drawing.Point(11, -59)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(941, 558)
        Me.Panel3.TabIndex = 16
        '
        'TABS
        '
        Me.TABS.Controls.Add(Me.TabPage1)
        Me.TABS.Controls.Add(Me.TabPage3)
        Me.TABS.Controls.Add(Me.issuebooks)
        Me.TABS.Controls.Add(Me.returnbooks)
        Me.TABS.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TABS.Location = New System.Drawing.Point(0, 64)
        Me.TABS.Name = "TABS"
        Me.TABS.SelectedIndex = 0
        Me.TABS.Size = New System.Drawing.Size(887, 491)
        Me.TABS.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.LightCoral
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage1.Controls.Add(Me.Panel4)
        Me.TabPage1.ForeColor = System.Drawing.Color.Black
        Me.TabPage1.ImageIndex = 0
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TabPage1.Size = New System.Drawing.Size(879, 458)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Add New Book"
        '
        'Panel4
        '
        Me.Panel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel4.Controls.Add(Me.Button1)
        Me.Panel4.Controls.Add(Me.editbook)
        Me.Panel4.Controls.Add(Me.searchbookid)
        Me.Panel4.Controls.Add(Me.coverimg)
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.descbox)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.quantity)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.pubyear)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.addbook)
        Me.Panel4.Controls.Add(Me.clearbut)
        Me.Panel4.Controls.Add(Me.genre)
        Me.Panel4.Controls.Add(Me.author)
        Me.Panel4.Controls.Add(Me.title)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.selectbut)
        Me.Panel4.Controls.Add(Me.bookid)
        Me.Panel4.Location = New System.Drawing.Point(-3, -17)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(881, 488)
        Me.Panel4.TabIndex = 17
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SeaGreen
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(376, 362)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 52)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "Update Cover"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'editbook
        '
        Me.editbook.BackColor = System.Drawing.Color.Lime
        Me.editbook.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editbook.Location = New System.Drawing.Point(168, 362)
        Me.editbook.Margin = New System.Windows.Forms.Padding(2)
        Me.editbook.Name = "editbook"
        Me.editbook.Size = New System.Drawing.Size(84, 52)
        Me.editbook.TabIndex = 30
        Me.editbook.Text = "Edit"
        Me.editbook.UseVisualStyleBackColor = False
        '
        'searchbookid
        '
        Me.searchbookid.BackColor = System.Drawing.Color.DarkKhaki
        Me.searchbookid.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchbookid.Location = New System.Drawing.Point(281, 66)
        Me.searchbookid.Margin = New System.Windows.Forms.Padding(2)
        Me.searchbookid.Name = "searchbookid"
        Me.searchbookid.Size = New System.Drawing.Size(79, 28)
        Me.searchbookid.TabIndex = 29
        Me.searchbookid.Text = "Search"
        Me.searchbookid.UseVisualStyleBackColor = False
        '
        'coverimg
        '
        Me.coverimg.BackColor = System.Drawing.Color.Transparent
        Me.coverimg.BackgroundImage = Global.LoginNRegisterPage.My.Resources.Resources.open_book
        Me.coverimg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.coverimg.Location = New System.Drawing.Point(598, 240)
        Me.coverimg.Name = "coverimg"
        Me.coverimg.Size = New System.Drawing.Size(140, 174)
        Me.coverimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.coverimg.TabIndex = 28
        Me.coverimg.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(442, 257)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(115, 22)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Book Cover:"
        '
        'descbox
        '
        Me.descbox.Location = New System.Drawing.Point(446, 65)
        Me.descbox.Name = "descbox"
        Me.descbox.Size = New System.Drawing.Size(361, 169)
        Me.descbox.TabIndex = 25
        Me.descbox.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(442, 40)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(111, 22)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Description:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(107, 308)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(83, 22)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Quantity:"
        '
        'quantity
        '
        Me.quantity.Location = New System.Drawing.Point(195, 303)
        Me.quantity.Name = "quantity"
        Me.quantity.Size = New System.Drawing.Size(163, 27)
        Me.quantity.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(41, 260)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(149, 22)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Publication Year:"
        '
        'pubyear
        '
        Me.pubyear.CalendarFont = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pubyear.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pubyear.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.pubyear.Location = New System.Drawing.Point(195, 257)
        Me.pubyear.Name = "pubyear"
        Me.pubyear.Size = New System.Drawing.Size(164, 27)
        Me.pubyear.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(111, 71)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(79, 22)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "BookID:"
        '
        'addbook
        '
        Me.addbook.BackColor = System.Drawing.Color.LightSeaGreen
        Me.addbook.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addbook.Location = New System.Drawing.Point(60, 362)
        Me.addbook.Margin = New System.Windows.Forms.Padding(2)
        Me.addbook.Name = "addbook"
        Me.addbook.Size = New System.Drawing.Size(84, 52)
        Me.addbook.TabIndex = 16
        Me.addbook.Text = "Add"
        Me.addbook.UseVisualStyleBackColor = False
        '
        'clearbut
        '
        Me.clearbut.BackColor = System.Drawing.Color.Red
        Me.clearbut.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearbut.Location = New System.Drawing.Point(274, 362)
        Me.clearbut.Margin = New System.Windows.Forms.Padding(2)
        Me.clearbut.Name = "clearbut"
        Me.clearbut.Size = New System.Drawing.Size(84, 52)
        Me.clearbut.TabIndex = 14
        Me.clearbut.Text = "Clear"
        Me.clearbut.UseVisualStyleBackColor = False
        '
        'genre
        '
        Me.genre.Location = New System.Drawing.Point(195, 207)
        Me.genre.Margin = New System.Windows.Forms.Padding(2)
        Me.genre.Name = "genre"
        Me.genre.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.genre.Size = New System.Drawing.Size(164, 27)
        Me.genre.TabIndex = 10
        '
        'author
        '
        Me.author.Location = New System.Drawing.Point(195, 156)
        Me.author.Margin = New System.Windows.Forms.Padding(2)
        Me.author.Name = "author"
        Me.author.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.author.Size = New System.Drawing.Size(163, 27)
        Me.author.TabIndex = 9
        '
        'title
        '
        Me.title.Location = New System.Drawing.Point(195, 115)
        Me.title.Margin = New System.Windows.Forms.Padding(2)
        Me.title.Name = "title"
        Me.title.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.title.Size = New System.Drawing.Size(163, 27)
        Me.title.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(122, 212)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(68, 22)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Genre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(120, 161)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(70, 22)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Author:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(140, 116)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(50, 22)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Title:"
        '
        'selectbut
        '
        Me.selectbut.BackColor = System.Drawing.Color.DarkKhaki
        Me.selectbut.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectbut.Location = New System.Drawing.Point(628, 419)
        Me.selectbut.Margin = New System.Windows.Forms.Padding(2)
        Me.selectbut.Name = "selectbut"
        Me.selectbut.Size = New System.Drawing.Size(79, 28)
        Me.selectbut.TabIndex = 3
        Me.selectbut.Text = "Select"
        Me.selectbut.UseVisualStyleBackColor = False
        '
        'bookid
        '
        Me.bookid.Location = New System.Drawing.Point(195, 66)
        Me.bookid.Margin = New System.Windows.Forms.Padding(2)
        Me.bookid.Name = "bookid"
        Me.bookid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bookid.Size = New System.Drawing.Size(82, 27)
        Me.bookid.TabIndex = 2
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.Chocolate
        Me.TabPage3.Controls.Add(Me.removebutton)
        Me.TabPage3.Controls.Add(Me.searchbuttontitle)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.titlebox)
        Me.TabPage3.Controls.Add(Me.refreshbut)
        Me.TabPage3.Controls.Add(Me.booksgrid)
        Me.TabPage3.ImageIndex = 1
        Me.TabPage3.Location = New System.Drawing.Point(4, 29)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(879, 458)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Book List"
        '
        'removebutton
        '
        Me.removebutton.BackColor = System.Drawing.Color.Gold
        Me.removebutton.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.removebutton.Location = New System.Drawing.Point(136, 418)
        Me.removebutton.Margin = New System.Windows.Forms.Padding(2)
        Me.removebutton.Name = "removebutton"
        Me.removebutton.Size = New System.Drawing.Size(88, 35)
        Me.removebutton.TabIndex = 33
        Me.removebutton.Text = "Remove"
        Me.removebutton.UseVisualStyleBackColor = False
        '
        'searchbuttontitle
        '
        Me.searchbuttontitle.BackColor = System.Drawing.Color.DarkKhaki
        Me.searchbuttontitle.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchbuttontitle.Location = New System.Drawing.Point(551, 420)
        Me.searchbuttontitle.Margin = New System.Windows.Forms.Padding(2)
        Me.searchbuttontitle.Name = "searchbuttontitle"
        Me.searchbuttontitle.Size = New System.Drawing.Size(79, 28)
        Me.searchbuttontitle.TabIndex = 32
        Me.searchbuttontitle.Text = "Search"
        Me.searchbuttontitle.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(294, 422)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(50, 22)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Title:"
        '
        'titlebox
        '
        Me.titlebox.Location = New System.Drawing.Point(348, 421)
        Me.titlebox.Margin = New System.Windows.Forms.Padding(2)
        Me.titlebox.Name = "titlebox"
        Me.titlebox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.titlebox.Size = New System.Drawing.Size(199, 27)
        Me.titlebox.TabIndex = 30
        '
        'refreshbut
        '
        Me.refreshbut.BackColor = System.Drawing.Color.LightSeaGreen
        Me.refreshbut.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refreshbut.Location = New System.Drawing.Point(25, 418)
        Me.refreshbut.Margin = New System.Windows.Forms.Padding(2)
        Me.refreshbut.Name = "refreshbut"
        Me.refreshbut.Size = New System.Drawing.Size(88, 35)
        Me.refreshbut.TabIndex = 17
        Me.refreshbut.Text = "Refresh"
        Me.refreshbut.UseVisualStyleBackColor = False
        '
        'booksgrid
        '
        Me.booksgrid.AllowUserToAddRows = False
        Me.booksgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.booksgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.booksgrid.Location = New System.Drawing.Point(25, 22)
        Me.booksgrid.Name = "booksgrid"
        Me.booksgrid.Size = New System.Drawing.Size(832, 391)
        Me.booksgrid.TabIndex = 0
        '
        'issuebooks
        '
        Me.issuebooks.BackColor = System.Drawing.Color.DarkKhaki
        Me.issuebooks.Controls.Add(Me.issuebutton)
        Me.issuebooks.Controls.Add(Me.srchuserid)
        Me.issuebooks.Controls.Add(Me.srchbookid)
        Me.issuebooks.Controls.Add(Me.Label17)
        Me.issuebooks.Controls.Add(Me.Label16)
        Me.issuebooks.Controls.Add(Me.DateTimePicker2)
        Me.issuebooks.Controls.Add(Me.DateTimePicker1)
        Me.issuebooks.Controls.Add(Me.yesno)
        Me.issuebooks.Controls.Add(Me.Label14)
        Me.issuebooks.Controls.Add(Me.userfullname)
        Me.issuebooks.Controls.Add(Me.Label13)
        Me.issuebooks.Controls.Add(Me.NumericUpDown2userid)
        Me.issuebooks.Controls.Add(Me.booktitle)
        Me.issuebooks.Controls.Add(Me.Label10)
        Me.issuebooks.Controls.Add(Me.NumericUpDown1bookid)
        Me.issuebooks.ImageIndex = 2
        Me.issuebooks.Location = New System.Drawing.Point(4, 29)
        Me.issuebooks.Name = "issuebooks"
        Me.issuebooks.Padding = New System.Windows.Forms.Padding(3)
        Me.issuebooks.Size = New System.Drawing.Size(879, 458)
        Me.issuebooks.TabIndex = 3
        Me.issuebooks.Text = "Issue"
        '
        'issuebutton
        '
        Me.issuebutton.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.issuebutton.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.issuebutton.Location = New System.Drawing.Point(401, 377)
        Me.issuebutton.Margin = New System.Windows.Forms.Padding(2)
        Me.issuebutton.Name = "issuebutton"
        Me.issuebutton.Size = New System.Drawing.Size(164, 46)
        Me.issuebutton.TabIndex = 38
        Me.issuebutton.Text = "Issue"
        Me.issuebutton.UseVisualStyleBackColor = False
        '
        'srchuserid
        '
        Me.srchuserid.BackColor = System.Drawing.Color.DarkTurquoise
        Me.srchuserid.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.srchuserid.Location = New System.Drawing.Point(584, 134)
        Me.srchuserid.Margin = New System.Windows.Forms.Padding(2)
        Me.srchuserid.Name = "srchuserid"
        Me.srchuserid.Size = New System.Drawing.Size(79, 28)
        Me.srchuserid.TabIndex = 37
        Me.srchuserid.Text = "Search"
        Me.srchuserid.UseVisualStyleBackColor = False
        '
        'srchbookid
        '
        Me.srchbookid.BackColor = System.Drawing.Color.DarkTurquoise
        Me.srchbookid.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.srchbookid.Location = New System.Drawing.Point(584, 49)
        Me.srchbookid.Margin = New System.Windows.Forms.Padding(2)
        Me.srchbookid.Name = "srchbookid"
        Me.srchbookid.Size = New System.Drawing.Size(79, 28)
        Me.srchbookid.TabIndex = 36
        Me.srchbookid.Text = "Search"
        Me.srchbookid.UseVisualStyleBackColor = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 15.25!)
        Me.Label17.Location = New System.Drawing.Point(268, 329)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label17.Size = New System.Drawing.Size(129, 24)
        Me.Label17.TabIndex = 35
        Me.Label17.Text = "Return Date:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 15.25!)
        Me.Label16.Location = New System.Drawing.Point(278, 266)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(118, 24)
        Me.Label16.TabIndex = 34
        Me.Label16.Text = "Issue Date:"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CalendarFont = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(402, 326)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(164, 27)
        Me.DateTimePicker2.TabIndex = 33
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(401, 263)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(164, 27)
        Me.DateTimePicker1.TabIndex = 32
        '
        'yesno
        '
        Me.yesno.AutoSize = True
        Me.yesno.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yesno.Location = New System.Drawing.Point(445, 211)
        Me.yesno.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.yesno.Name = "yesno"
        Me.yesno.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.yesno.Size = New System.Drawing.Size(76, 24)
        Me.yesno.TabIndex = 31
        Me.yesno.Text = "Yes/No"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 15.25!)
        Me.Label14.Location = New System.Drawing.Point(285, 211)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(112, 24)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "Available?:"
        '
        'userfullname
        '
        Me.userfullname.AutoSize = True
        Me.userfullname.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userfullname.ForeColor = System.Drawing.Color.Black
        Me.userfullname.Location = New System.Drawing.Point(399, 161)
        Me.userfullname.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.userfullname.Name = "userfullname"
        Me.userfullname.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.userfullname.Size = New System.Drawing.Size(133, 18)
        Me.userfullname.TabIndex = 29
        Me.userfullname.Text = ">User Full Name<"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 15.25!)
        Me.Label13.Location = New System.Drawing.Point(264, 134)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(132, 24)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Input UserID:"
        '
        'NumericUpDown2userid
        '
        Me.NumericUpDown2userid.Location = New System.Drawing.Point(402, 131)
        Me.NumericUpDown2userid.Name = "NumericUpDown2userid"
        Me.NumericUpDown2userid.Size = New System.Drawing.Size(163, 27)
        Me.NumericUpDown2userid.TabIndex = 27
        '
        'booktitle
        '
        Me.booktitle.AutoSize = True
        Me.booktitle.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.booktitle.ForeColor = System.Drawing.Color.Black
        Me.booktitle.Location = New System.Drawing.Point(399, 80)
        Me.booktitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.booktitle.Name = "booktitle"
        Me.booktitle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.booktitle.Size = New System.Drawing.Size(95, 18)
        Me.booktitle.TabIndex = 26
        Me.booktitle.Text = ">Book Title<"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 15.25!)
        Me.Label10.Location = New System.Drawing.Point(254, 53)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(142, 24)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Input Book ID:"
        '
        'NumericUpDown1bookid
        '
        Me.NumericUpDown1bookid.Location = New System.Drawing.Point(402, 50)
        Me.NumericUpDown1bookid.Name = "NumericUpDown1bookid"
        Me.NumericUpDown1bookid.Size = New System.Drawing.Size(163, 27)
        Me.NumericUpDown1bookid.TabIndex = 24
        '
        'returnbooks
        '
        Me.returnbooks.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.returnbooks.Controls.Add(Me.Panel5)
        Me.returnbooks.ImageIndex = 3
        Me.returnbooks.Location = New System.Drawing.Point(4, 29)
        Me.returnbooks.Name = "returnbooks"
        Me.returnbooks.Padding = New System.Windows.Forms.Padding(3)
        Me.returnbooks.Size = New System.Drawing.Size(879, 458)
        Me.returnbooks.TabIndex = 4
        Me.returnbooks.Text = "Return"
        '
        'Panel5
        '
        Me.Panel5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel5.Controls.Add(Me.refreshdataissuelist)
        Me.Panel5.Controls.Add(Me.Label18)
        Me.Panel5.Controls.Add(Me.Label15)
        Me.Panel5.Controls.Add(Me.label20)
        Me.Panel5.Controls.Add(Me.returnbookbut)
        Me.Panel5.Controls.Add(Me.Label11)
        Me.Panel5.Controls.Add(Me.Issuelist)
        Me.Panel5.Controls.Add(Me.returndatebox)
        Me.Panel5.Controls.Add(Me.issuedatebox)
        Me.Panel5.Controls.Add(Me.useridbox)
        Me.Panel5.Controls.Add(Me.bookidbox)
        Me.Panel5.Controls.Add(Me.label19)
        Me.Panel5.Location = New System.Drawing.Point(-1, -15)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(881, 488)
        Me.Panel5.TabIndex = 17
        '
        'refreshdataissuelist
        '
        Me.refreshdataissuelist.BackColor = System.Drawing.Color.OrangeRed
        Me.refreshdataissuelist.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refreshdataissuelist.Location = New System.Drawing.Point(57, 390)
        Me.refreshdataissuelist.Margin = New System.Windows.Forms.Padding(2)
        Me.refreshdataissuelist.Name = "refreshdataissuelist"
        Me.refreshdataissuelist.Size = New System.Drawing.Size(159, 30)
        Me.refreshdataissuelist.TabIndex = 21
        Me.refreshdataissuelist.Text = "Refresh Data"
        Me.refreshdataissuelist.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(38, 278)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label18.Size = New System.Drawing.Size(102, 19)
        Me.Label18.TabIndex = 20
        Me.Label18.Text = "ReturnDate:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(38, 215)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(91, 19)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "IssueDate:"
        '
        'label20
        '
        Me.label20.AutoSize = True
        Me.label20.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label20.Location = New System.Drawing.Point(38, 159)
        Me.label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label20.Name = "label20"
        Me.label20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.label20.Size = New System.Drawing.Size(67, 19)
        Me.label20.TabIndex = 18
        Me.label20.Text = "UserID:"
        '
        'returnbookbut
        '
        Me.returnbookbut.BackColor = System.Drawing.Color.DarkSalmon
        Me.returnbookbut.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.returnbookbut.Location = New System.Drawing.Point(57, 347)
        Me.returnbookbut.Margin = New System.Windows.Forms.Padding(2)
        Me.returnbookbut.Name = "returnbookbut"
        Me.returnbookbut.Size = New System.Drawing.Size(159, 30)
        Me.returnbookbut.TabIndex = 14
        Me.returnbookbut.Text = "Return Book"
        Me.returnbookbut.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(356, 35)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(137, 22)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Issued Books"
        '
        'Issuelist
        '
        Me.Issuelist.AllowUserToAddRows = False
        Me.Issuelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Issuelist.Location = New System.Drawing.Point(360, 59)
        Me.Issuelist.Margin = New System.Windows.Forms.Padding(2)
        Me.Issuelist.Name = "Issuelist"
        Me.Issuelist.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Issuelist.RowHeadersWidth = 51
        Me.Issuelist.RowTemplate.Height = 24
        Me.Issuelist.Size = New System.Drawing.Size(457, 377)
        Me.Issuelist.TabIndex = 12
        '
        'returndatebox
        '
        Me.returndatebox.Enabled = False
        Me.returndatebox.Location = New System.Drawing.Point(39, 299)
        Me.returndatebox.Margin = New System.Windows.Forms.Padding(2)
        Me.returndatebox.Name = "returndatebox"
        Me.returndatebox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.returndatebox.Size = New System.Drawing.Size(200, 27)
        Me.returndatebox.TabIndex = 10
        '
        'issuedatebox
        '
        Me.issuedatebox.Enabled = False
        Me.issuedatebox.Location = New System.Drawing.Point(39, 236)
        Me.issuedatebox.Margin = New System.Windows.Forms.Padding(2)
        Me.issuedatebox.Name = "issuedatebox"
        Me.issuedatebox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.issuedatebox.Size = New System.Drawing.Size(200, 27)
        Me.issuedatebox.TabIndex = 9
        '
        'useridbox
        '
        Me.useridbox.Enabled = False
        Me.useridbox.Location = New System.Drawing.Point(38, 180)
        Me.useridbox.Margin = New System.Windows.Forms.Padding(2)
        Me.useridbox.Name = "useridbox"
        Me.useridbox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.useridbox.Size = New System.Drawing.Size(200, 27)
        Me.useridbox.TabIndex = 8
        '
        'bookidbox
        '
        Me.bookidbox.Enabled = False
        Me.bookidbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.bookidbox.Location = New System.Drawing.Point(38, 119)
        Me.bookidbox.Margin = New System.Windows.Forms.Padding(2)
        Me.bookidbox.Name = "bookidbox"
        Me.bookidbox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bookidbox.Size = New System.Drawing.Size(200, 27)
        Me.bookidbox.TabIndex = 2
        '
        'label19
        '
        Me.label19.AutoSize = True
        Me.label19.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label19.Location = New System.Drawing.Point(38, 98)
        Me.label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label19.Name = "label19"
        Me.label19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.label19.Size = New System.Drawing.Size(70, 19)
        Me.label19.TabIndex = 1
        Me.label19.Text = "BookId:"
        '
        'BackWindow1
        '
        Me.BackWindow1.Image = Global.LoginNRegisterPage.My.Resources.Resources.BackWindow
        Me.BackWindow1.Location = New System.Drawing.Point(892, 63)
        Me.BackWindow1.Margin = New System.Windows.Forms.Padding(2)
        Me.BackWindow1.Name = "BackWindow1"
        Me.BackWindow1.Size = New System.Drawing.Size(37, 35)
        Me.BackWindow1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BackWindow1.TabIndex = 0
        Me.BackWindow1.TabStop = False
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
        Me.Panel1.Size = New System.Drawing.Size(966, 47)
        Me.Panel1.TabIndex = 2
        '
        'MinimizedWindow3
        '
        Me.MinimizedWindow3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MinimizedWindow3.Image = Global.LoginNRegisterPage.My.Resources.Resources.MinimizedWindow
        Me.MinimizedWindow3.Location = New System.Drawing.Point(869, 14)
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
        Me.MaximizeWindow3.Location = New System.Drawing.Point(903, 14)
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
        Me.CloseWindow3.Location = New System.Drawing.Point(935, 14)
        Me.CloseWindow3.Margin = New System.Windows.Forms.Padding(2)
        Me.CloseWindow3.Name = "CloseWindow3"
        Me.CloseWindow3.Size = New System.Drawing.Size(21, 21)
        Me.CloseWindow3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CloseWindow3.TabIndex = 5
        Me.CloseWindow3.TabStop = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "book (1).png")
        Me.ImageList1.Images.SetKeyName(1, "book.png")
        Me.ImageList1.Images.SetKeyName(2, "book (2).png")
        Me.ImageList1.Images.SetKeyName(3, "journal.png")
        '
        'FormManageBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(966, 558)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormManageBooks"
        Me.Text = "FormManageBooks"
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.TABS.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.coverimg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.quantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.booksgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.issuebooks.ResumeLayout(False)
        Me.issuebooks.PerformLayout()
        CType(Me.NumericUpDown2userid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1bookid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.returnbooks.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.Issuelist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BackWindow1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.MinimizedWindow3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaximizeWindow3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CloseWindow3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BackWindow1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MinimizedWindow3 As PictureBox
    Friend WithEvents MaximizeWindow3 As PictureBox
    Friend WithEvents CloseWindow3 As PictureBox
    Friend WithEvents TABS As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Panel4 As Panel
    Friend WithEvents pubyear As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents addbook As Button
    Friend WithEvents author As TextBox
    Friend WithEvents title As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents selectbut As Button
    Friend WithEvents bookid As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents clearbut As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents quantity As NumericUpDown
    Friend WithEvents descbox As RichTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents coverimg As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents genre As TextBox
    Friend WithEvents searchbookid As Button
    Friend WithEvents booksgrid As DataGridView
    Friend WithEvents refreshbut As Button
    Friend WithEvents editbook As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents searchbuttontitle As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents titlebox As TextBox
    Friend WithEvents removebutton As Button
    Friend WithEvents issuebooks As TabPage
    Friend WithEvents returnbooks As TabPage
    Friend WithEvents userfullname As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents NumericUpDown2userid As NumericUpDown
    Friend WithEvents booktitle As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents NumericUpDown1bookid As NumericUpDown
    Friend WithEvents yesno As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents srchuserid As Button
    Friend WithEvents srchbookid As Button
    Friend WithEvents issuebutton As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents label20 As Label
    Friend WithEvents returnbookbut As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Issuelist As DataGridView
    Friend WithEvents returndatebox As TextBox
    Friend WithEvents issuedatebox As TextBox
    Friend WithEvents useridbox As TextBox
    Friend WithEvents bookidbox As TextBox
    Friend WithEvents label19 As Label
    Friend WithEvents refreshdataissuelist As Button
End Class
