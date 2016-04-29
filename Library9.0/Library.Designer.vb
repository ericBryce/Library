<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            'added by me to close excel sheets
            Me.user.SaveUserDatabase()
            Me.media.SaveMediaDatabase()
            Me.user.CloseUserDatabase()
            Me.media.CloseUserDatabase()
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.SignIn = New System.Windows.Forms.TabPage()
        Me.SignOutButton = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.UserInfo = New System.Windows.Forms.TextBox()
        Me.Rentals = New System.Windows.Forms.TextBox()
        Me.SignInButton = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PassWordText = New System.Windows.Forms.TextBox()
        Me.UserNameText = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.FinePaidText = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.FinePaidButton = New System.Windows.Forms.Button()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.UserLookUpInfoBox = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.AddUserInformation = New System.Windows.Forms.Button()
        Me.CheckIn = New System.Windows.Forms.Button()
        Me.AddNameText = New System.Windows.Forms.TextBox()
        Me.CheckInMediaID = New System.Windows.Forms.TextBox()
        Me.AddPasswordText = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.AddAddressText = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.AddEmailText = New System.Windows.Forms.TextBox()
        Me.CheckOut = New System.Windows.Forms.Button()
        Me.AddPhoneText = New System.Windows.Forms.TextBox()
        Me.CheckOutUserID = New System.Windows.Forms.TextBox()
        Me.AddFirstNameText = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.AddLastNameText = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.DeleteUserFromSystem = New System.Windows.Forms.Button()
        Me.CheckOutMediaID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.UserLookUpSearchButton = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LookUpUserLastNameText = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.IsUserAdmin = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.SearchReturnText = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SearchMediaSubmitButton = New System.Windows.Forms.Button()
        Me.SearchText = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SearchTypeDrop = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Search = New System.Windows.Forms.TabControl()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.SignIn.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Search.SuspendLayout()
        Me.SuspendLayout()
        '
        'SignIn
        '
        Me.SignIn.BackColor = System.Drawing.Color.DarkCyan
        Me.SignIn.Controls.Add(Me.SignOutButton)
        Me.SignIn.Controls.Add(Me.PictureBox2)
        Me.SignIn.Controls.Add(Me.TextBox3)
        Me.SignIn.Controls.Add(Me.TextBox2)
        Me.SignIn.Controls.Add(Me.TextBox1)
        Me.SignIn.Controls.Add(Me.Button1)
        Me.SignIn.Controls.Add(Me.UserInfo)
        Me.SignIn.Controls.Add(Me.Rentals)
        Me.SignIn.Controls.Add(Me.SignInButton)
        Me.SignIn.Controls.Add(Me.Label7)
        Me.SignIn.Controls.Add(Me.Label6)
        Me.SignIn.Controls.Add(Me.PassWordText)
        Me.SignIn.Controls.Add(Me.UserNameText)
        Me.SignIn.Controls.Add(Me.Label5)
        Me.SignIn.Controls.Add(Me.Label4)
        Me.SignIn.Controls.Add(Me.Label29)
        Me.SignIn.Controls.Add(Me.PictureBox8)
        Me.SignIn.Location = New System.Drawing.Point(4, 22)
        Me.SignIn.Name = "SignIn"
        Me.SignIn.Padding = New System.Windows.Forms.Padding(3)
        Me.SignIn.Size = New System.Drawing.Size(1260, 667)
        Me.SignIn.TabIndex = 2
        Me.SignIn.Text = "Sign In                            "
        '
        'SignOutButton
        '
        Me.SignOutButton.Location = New System.Drawing.Point(306, 84)
        Me.SignOutButton.Name = "SignOutButton"
        Me.SignOutButton.Size = New System.Drawing.Size(75, 32)
        Me.SignOutButton.TabIndex = 19
        Me.SignOutButton.Text = "Sign Out"
        Me.SignOutButton.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(8, 35)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(70, 73)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(421, 667)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 14
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(297, 666)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 13
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(152, 667)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(58, 667)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'UserInfo
        '
        Me.UserInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserInfo.Location = New System.Drawing.Point(30, 202)
        Me.UserInfo.Multiline = True
        Me.UserInfo.Name = "UserInfo"
        Me.UserInfo.ReadOnly = True
        Me.UserInfo.Size = New System.Drawing.Size(438, 361)
        Me.UserInfo.TabIndex = 10
        '
        'Rentals
        '
        Me.Rentals.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rentals.Location = New System.Drawing.Point(577, 202)
        Me.Rentals.Multiline = True
        Me.Rentals.Name = "Rentals"
        Me.Rentals.ReadOnly = True
        Me.Rentals.Size = New System.Drawing.Size(641, 361)
        Me.Rentals.TabIndex = 9
        '
        'SignInButton
        '
        Me.SignInButton.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SignInButton.Location = New System.Drawing.Point(306, 38)
        Me.SignInButton.Name = "SignInButton"
        Me.SignInButton.Size = New System.Drawing.Size(75, 34)
        Me.SignInButton.TabIndex = 8
        Me.SignInButton.Text = "Sign In"
        Me.SignInButton.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(573, 156)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(666, 46)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Rentals"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(27, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 19)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "User Information"
        '
        'PassWordText
        '
        Me.PassWordText.HideSelection = False
        Me.PassWordText.Location = New System.Drawing.Point(185, 88)
        Me.PassWordText.MaxLength = 10
        Me.PassWordText.Name = "PassWordText"
        Me.PassWordText.Size = New System.Drawing.Size(100, 20)
        Me.PassWordText.TabIndex = 3
        Me.PassWordText.UseSystemPasswordChar = True
        '
        'UserNameText
        '
        Me.UserNameText.Location = New System.Drawing.Point(185, 46)
        Me.UserNameText.Name = "UserNameText"
        Me.UserNameText.Size = New System.Drawing.Size(100, 20)
        Me.UserNameText.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(94, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 16)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(94, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "User Name"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Elephant", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(403, 35)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(857, 45)
        Me.Label29.TabIndex = 17
        Me.Label29.Text = "Welcome to LMS Library Management System!"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(576, 35)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(642, 158)
        Me.PictureBox8.TabIndex = 18
        Me.PictureBox8.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.DarkCyan
        Me.TabPage2.Controls.Add(Me.Panel1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1260, 667)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Admin                       "
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel1.Controls.Add(Me.Label28)
        Me.Panel1.Controls.Add(Me.Label27)
        Me.Panel1.Controls.Add(Me.FinePaidText)
        Me.Panel1.Controls.Add(Me.Label25)
        Me.Panel1.Controls.Add(Me.FinePaidButton)
        Me.Panel1.Controls.Add(Me.PictureBox6)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.UserLookUpInfoBox)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.AddUserInformation)
        Me.Panel1.Controls.Add(Me.CheckIn)
        Me.Panel1.Controls.Add(Me.AddNameText)
        Me.Panel1.Controls.Add(Me.CheckInMediaID)
        Me.Panel1.Controls.Add(Me.AddPasswordText)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.AddAddressText)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.AddEmailText)
        Me.Panel1.Controls.Add(Me.CheckOut)
        Me.Panel1.Controls.Add(Me.AddPhoneText)
        Me.Panel1.Controls.Add(Me.CheckOutUserID)
        Me.Panel1.Controls.Add(Me.AddFirstNameText)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.AddLastNameText)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.DeleteUserFromSystem)
        Me.Panel1.Controls.Add(Me.CheckOutMediaID)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.UserLookUpSearchButton)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.LookUpUserLastNameText)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.IsUserAdmin)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label30)
        Me.Panel1.Location = New System.Drawing.Point(0, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1263, 658)
        Me.Panel1.TabIndex = 20
        Me.Panel1.Visible = False
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.Black
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 2.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(775, -1)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(2, 660)
        Me.Label28.TabIndex = 28
        Me.Label28.Text = "i"
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.Black
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 2.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(290, 1)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(2, 660)
        Me.Label27.TabIndex = 27
        Me.Label27.Text = "i"
        '
        'FinePaidText
        '
        Me.FinePaidText.Location = New System.Drawing.Point(839, 483)
        Me.FinePaidText.Name = "FinePaidText"
        Me.FinePaidText.Size = New System.Drawing.Size(100, 20)
        Me.FinePaidText.TabIndex = 26
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(804, 458)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(173, 16)
        Me.Label25.TabIndex = 25
        Me.Label25.Text = "Fine paid for media ID #"
        '
        'FinePaidButton
        '
        Me.FinePaidButton.Location = New System.Drawing.Point(854, 513)
        Me.FinePaidButton.Name = "FinePaidButton"
        Me.FinePaidButton.Size = New System.Drawing.Size(75, 23)
        Me.FinePaidButton.TabIndex = 24
        Me.FinePaidButton.Text = "Fine Paid"
        Me.FinePaidButton.UseVisualStyleBackColor = True
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(1030, 366)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(160, 160)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox6.TabIndex = 23
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(1030, 79)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(160, 160)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox5.TabIndex = 22
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(53, 19)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(67, 68)
        Me.PictureBox4.TabIndex = 21
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(374, 62)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(80, 80)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 20
        Me.PictureBox3.TabStop = False
        '
        'UserLookUpInfoBox
        '
        Me.UserLookUpInfoBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserLookUpInfoBox.Location = New System.Drawing.Point(361, 167)
        Me.UserLookUpInfoBox.Multiline = True
        Me.UserLookUpInfoBox.Name = "UserLookUpInfoBox"
        Me.UserLookUpInfoBox.ReadOnly = True
        Me.UserLookUpInfoBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.UserLookUpInfoBox.Size = New System.Drawing.Size(359, 345)
        Me.UserLookUpInfoBox.TabIndex = 0
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(136, 219)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker1.TabIndex = 19
        '
        'AddUserInformation
        '
        Me.AddUserInformation.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddUserInformation.Location = New System.Drawing.Point(133, 504)
        Me.AddUserInformation.Name = "AddUserInformation"
        Me.AddUserInformation.Size = New System.Drawing.Size(75, 23)
        Me.AddUserInformation.TabIndex = 0
        Me.AddUserInformation.Text = "Add user"
        Me.AddUserInformation.UseVisualStyleBackColor = True
        '
        'CheckIn
        '
        Me.CheckIn.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckIn.Location = New System.Drawing.Point(855, 401)
        Me.CheckIn.Name = "CheckIn"
        Me.CheckIn.Size = New System.Drawing.Size(75, 23)
        Me.CheckIn.TabIndex = 18
        Me.CheckIn.Text = "Check In"
        Me.CheckIn.UseVisualStyleBackColor = True
        '
        'AddNameText
        '
        Me.AddNameText.Location = New System.Drawing.Point(136, 87)
        Me.AddNameText.Name = "AddNameText"
        Me.AddNameText.Size = New System.Drawing.Size(100, 20)
        Me.AddNameText.TabIndex = 1
        '
        'CheckInMediaID
        '
        Me.CheckInMediaID.Location = New System.Drawing.Point(839, 366)
        Me.CheckInMediaID.Name = "CheckInMediaID"
        Me.CheckInMediaID.Size = New System.Drawing.Size(100, 20)
        Me.CheckInMediaID.TabIndex = 17
        '
        'AddPasswordText
        '
        Me.AddPasswordText.Location = New System.Drawing.Point(136, 126)
        Me.AddPasswordText.Name = "AddPasswordText"
        Me.AddPasswordText.Size = New System.Drawing.Size(100, 20)
        Me.AddPasswordText.TabIndex = 2
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(857, 345)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(63, 16)
        Me.Label22.TabIndex = 16
        Me.Label22.Text = "Media ID #"
        '
        'AddAddressText
        '
        Me.AddAddressText.Location = New System.Drawing.Point(136, 167)
        Me.AddAddressText.Name = "AddAddressText"
        Me.AddAddressText.Size = New System.Drawing.Size(100, 20)
        Me.AddAddressText.TabIndex = 3
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(850, 312)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(76, 19)
        Me.Label21.TabIndex = 15
        Me.Label21.Text = "Check In"
        '
        'AddEmailText
        '
        Me.AddEmailText.Location = New System.Drawing.Point(136, 270)
        Me.AddEmailText.Name = "AddEmailText"
        Me.AddEmailText.Size = New System.Drawing.Size(100, 20)
        Me.AddEmailText.TabIndex = 5
        '
        'CheckOut
        '
        Me.CheckOut.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckOut.Location = New System.Drawing.Point(854, 244)
        Me.CheckOut.Name = "CheckOut"
        Me.CheckOut.Size = New System.Drawing.Size(75, 23)
        Me.CheckOut.TabIndex = 14
        Me.CheckOut.Text = "Check Out"
        Me.CheckOut.UseVisualStyleBackColor = True
        '
        'AddPhoneText
        '
        Me.AddPhoneText.Location = New System.Drawing.Point(136, 316)
        Me.AddPhoneText.Name = "AddPhoneText"
        Me.AddPhoneText.Size = New System.Drawing.Size(100, 20)
        Me.AddPhoneText.TabIndex = 6
        '
        'CheckOutUserID
        '
        Me.CheckOutUserID.Location = New System.Drawing.Point(839, 202)
        Me.CheckOutUserID.Name = "CheckOutUserID"
        Me.CheckOutUserID.Size = New System.Drawing.Size(100, 20)
        Me.CheckOutUserID.TabIndex = 13
        '
        'AddFirstNameText
        '
        Me.AddFirstNameText.Location = New System.Drawing.Point(136, 366)
        Me.AddFirstNameText.Name = "AddFirstNameText"
        Me.AddFirstNameText.Size = New System.Drawing.Size(100, 20)
        Me.AddFirstNameText.TabIndex = 7
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(859, 173)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(56, 16)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "User ID #"
        '
        'AddLastNameText
        '
        Me.AddLastNameText.Location = New System.Drawing.Point(136, 413)
        Me.AddLastNameText.Name = "AddLastNameText"
        Me.AddLastNameText.Size = New System.Drawing.Size(100, 20)
        Me.AddLastNameText.TabIndex = 8
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(857, 110)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(63, 16)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "Media ID #"
        '
        'DeleteUserFromSystem
        '
        Me.DeleteUserFromSystem.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteUserFromSystem.Location = New System.Drawing.Point(501, 530)
        Me.DeleteUserFromSystem.Name = "DeleteUserFromSystem"
        Me.DeleteUserFromSystem.Size = New System.Drawing.Size(75, 23)
        Me.DeleteUserFromSystem.TabIndex = 0
        Me.DeleteUserFromSystem.Text = "Delete User"
        Me.DeleteUserFromSystem.UseVisualStyleBackColor = True
        '
        'CheckOutMediaID
        '
        Me.CheckOutMediaID.Location = New System.Drawing.Point(839, 133)
        Me.CheckOutMediaID.Name = "CheckOutMediaID"
        Me.CheckOutMediaID.Size = New System.Drawing.Size(100, 20)
        Me.CheckOutMediaID.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(50, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Username"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(841, 73)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(89, 19)
        Me.Label18.TabIndex = 12
        Me.Label18.Text = "Check Out"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(50, 130)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Password"
        '
        'UserLookUpSearchButton
        '
        Me.UserLookUpSearchButton.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserLookUpSearchButton.Location = New System.Drawing.Point(501, 129)
        Me.UserLookUpSearchButton.Name = "UserLookUpSearchButton"
        Me.UserLookUpSearchButton.Size = New System.Drawing.Size(75, 23)
        Me.UserLookUpSearchButton.TabIndex = 11
        Me.UserLookUpSearchButton.Text = "Search"
        Me.UserLookUpSearchButton.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(50, 171)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Address"
        '
        'LookUpUserLastNameText
        '
        Me.LookUpUserLastNameText.Location = New System.Drawing.Point(469, 93)
        Me.LookUpUserLastNameText.Name = "LookUpUserLastNameText"
        Me.LookUpUserLastNameText.Size = New System.Drawing.Size(140, 20)
        Me.LookUpUserLastNameText.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(50, 219)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 16)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Birthdate"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(50, 271)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 16)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "E-Mail"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(461, 62)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(159, 19)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "User Look Up By ID"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(50, 320)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 16)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Phone #"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(129, 59)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(118, 19)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Add New User"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(50, 370)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 16)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "First Name"
        '
        'IsUserAdmin
        '
        Me.IsUserAdmin.FormattingEnabled = True
        Me.IsUserAdmin.Items.AddRange(New Object() {"TRUE", "FALSE"})
        Me.IsUserAdmin.Location = New System.Drawing.Point(136, 458)
        Me.IsUserAdmin.Name = "IsUserAdmin"
        Me.IsUserAdmin.Size = New System.Drawing.Size(100, 21)
        Me.IsUserAdmin.TabIndex = 9
        Me.IsUserAdmin.Text = "FALSE"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(50, 417)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 16)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Last Name"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(50, 463)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 16)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Is Admin"
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.DarkCyan
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage1.Controls.Add(Me.PictureBox9)
        Me.TabPage1.Controls.Add(Me.Label26)
        Me.TabPage1.Controls.Add(Me.PictureBox7)
        Me.TabPage1.Controls.Add(Me.Label24)
        Me.TabPage1.Controls.Add(Me.Label23)
        Me.TabPage1.Controls.Add(Me.SearchReturnText)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.SearchMediaSubmitButton)
        Me.TabPage1.Controls.Add(Me.SearchText)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.SearchTypeDrop)
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1260, 667)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Search                      "
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(1035, 90)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(211, 528)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 14
        Me.PictureBox9.TabStop = False
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(899, 169)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(93, 20)
        Me.Label26.TabIndex = 13
        Me.Label26.Text = "Availability"
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(128, 28)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(27, 26)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox7.TabIndex = 12
        Me.PictureBox7.TabStop = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(59, 35)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(63, 19)
        Me.Label24.TabIndex = 11
        Me.Label24.Text = "Search"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Elephant", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(177, -2)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(857, 45)
        Me.Label23.TabIndex = 9
        Me.Label23.Text = "Welcome to LMS Library Management System!"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'SearchReturnText
        '
        Me.SearchReturnText.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchReturnText.Location = New System.Drawing.Point(34, 201)
        Me.SearchReturnText.Multiline = True
        Me.SearchReturnText.Name = "SearchReturnText"
        Me.SearchReturnText.ReadOnly = True
        Me.SearchReturnText.Size = New System.Drawing.Size(986, 433)
        Me.SearchReturnText.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(779, 19)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Title                                                 Author                     " & _
    "            Genre                        Category                    Location"
        '
        'SearchMediaSubmitButton
        '
        Me.SearchMediaSubmitButton.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchMediaSubmitButton.Location = New System.Drawing.Point(169, 133)
        Me.SearchMediaSubmitButton.Name = "SearchMediaSubmitButton"
        Me.SearchMediaSubmitButton.Size = New System.Drawing.Size(75, 23)
        Me.SearchMediaSubmitButton.TabIndex = 5
        Me.SearchMediaSubmitButton.Text = "Submit"
        Me.SearchMediaSubmitButton.UseVisualStyleBackColor = True
        '
        'SearchText
        '
        Me.SearchText.Location = New System.Drawing.Point(93, 96)
        Me.SearchText.Name = "SearchText"
        Me.SearchText.Size = New System.Drawing.Size(239, 20)
        Me.SearchText.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Search By:"
        '
        'SearchTypeDrop
        '
        Me.SearchTypeDrop.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchTypeDrop.FormattingEnabled = True
        Me.SearchTypeDrop.Items.AddRange(New Object() {"Name", "Author", "Genre"})
        Me.SearchTypeDrop.Location = New System.Drawing.Point(93, 66)
        Me.SearchTypeDrop.Name = "SearchTypeDrop"
        Me.SearchTypeDrop.Size = New System.Drawing.Size(121, 24)
        Me.SearchTypeDrop.TabIndex = 0
        Me.SearchTypeDrop.Text = "Choose Option"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(350, -33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(642, 189)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Search
        '
        Me.Search.Controls.Add(Me.TabPage1)
        Me.Search.Controls.Add(Me.SignIn)
        Me.Search.Controls.Add(Me.TabPage2)
        Me.Search.Location = New System.Drawing.Point(0, 1)
        Me.Search.Name = "Search"
        Me.Search.SelectedIndex = 0
        Me.Search.Size = New System.Drawing.Size(1268, 693)
        Me.Search.TabIndex = 0
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(501, 347)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(45, 13)
        Me.Label30.TabIndex = 29
        Me.Label30.Text = "Label30"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1268, 686)
        Me.Controls.Add(Me.Search)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Your Library"
        Me.SignIn.ResumeLayout(False)
        Me.SignIn.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Search.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SignIn As System.Windows.Forms.TabPage
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PassWordText As System.Windows.Forms.TextBox
    Friend WithEvents UserNameText As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SearchMediaSubmitButton As System.Windows.Forms.Button
    Friend WithEvents SearchText As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SearchTypeDrop As System.Windows.Forms.ComboBox
    Friend WithEvents Search As System.Windows.Forms.TabControl
    Friend WithEvents SignInButton As System.Windows.Forms.Button
    Friend WithEvents AddUserInformation As System.Windows.Forms.Button
    Friend WithEvents AddNameText As System.Windows.Forms.TextBox
    Friend WithEvents AddLastNameText As System.Windows.Forms.TextBox
    Friend WithEvents AddFirstNameText As System.Windows.Forms.TextBox
    Friend WithEvents AddPhoneText As System.Windows.Forms.TextBox
    Friend WithEvents AddEmailText As System.Windows.Forms.TextBox
    Friend WithEvents AddAddressText As System.Windows.Forms.TextBox
    Friend WithEvents AddPasswordText As System.Windows.Forms.TextBox
    Friend WithEvents Rentals As System.Windows.Forms.TextBox
    Friend WithEvents UserInfo As System.Windows.Forms.TextBox
    Friend WithEvents SearchReturnText As System.Windows.Forms.TextBox
    Friend WithEvents DeleteUserFromSystem As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents IsUserAdmin As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents UserLookUpInfoBox As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents LookUpUserLastNameText As System.Windows.Forms.TextBox
    Friend WithEvents UserLookUpSearchButton As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents CheckIn As System.Windows.Forms.Button
    Friend WithEvents CheckInMediaID As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents CheckOut As System.Windows.Forms.Button
    Friend WithEvents CheckOutUserID As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents CheckOutMediaID As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents FinePaidText As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents FinePaidButton As System.Windows.Forms.Button
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents SignOutButton As System.Windows.Forms.Button
    Friend WithEvents Label30 As System.Windows.Forms.Label

End Class
