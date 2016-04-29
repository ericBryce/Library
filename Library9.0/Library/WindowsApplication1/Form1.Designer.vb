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
            Me.UserLogin.SaveUserDatabase()
            Me.mediaSearch.SaveMediaDatabase()
            Me.UserLogin.CloseUserDatabase()
            Me.mediaSearch.CloseUserDatabase()
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
        Me.SignIn = New System.Windows.Forms.TabPage()
        Me.UserInfo = New System.Windows.Forms.TextBox()
        Me.Rentals = New System.Windows.Forms.TextBox()
        Me.UseNamePassSubmit = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PassWordText = New System.Windows.Forms.TextBox()
        Me.UserNameText = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.CheckIn = New System.Windows.Forms.Button()
        Me.CheckInMediaID = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.CheckOut = New System.Windows.Forms.Button()
        Me.CheckOutUserID = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.CheckOutMediaID = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.UserLookUpSearchButton = New System.Windows.Forms.Button()
        Me.LookUpUserLastNameText = New System.Windows.Forms.TextBox()
        Me.UserLookUpInfoBox = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.IsUserAdmin = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DeleteUserFromSystem = New System.Windows.Forms.Button()
        Me.AddLastNameText = New System.Windows.Forms.TextBox()
        Me.AddFirstNameText = New System.Windows.Forms.TextBox()
        Me.AddPhoneText = New System.Windows.Forms.TextBox()
        Me.AddEmailText = New System.Windows.Forms.TextBox()
        Me.AddAddressText = New System.Windows.Forms.TextBox()
        Me.AddPasswordText = New System.Windows.Forms.TextBox()
        Me.AddNameText = New System.Windows.Forms.TextBox()
        Me.AddUserInformation = New System.Windows.Forms.Button()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.SearchReturnText = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SearchMediaSubmitButton = New System.Windows.Forms.Button()
        Me.SearchText = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SearchTypeDrop = New System.Windows.Forms.ComboBox()
        Me.Search = New System.Windows.Forms.TabControl()
        Me.SignIn.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Search.SuspendLayout()
        Me.SuspendLayout()
        '
        'SignIn
        '
        Me.SignIn.BackColor = System.Drawing.Color.PaleTurquoise
        Me.SignIn.Controls.Add(Me.UserInfo)
        Me.SignIn.Controls.Add(Me.Rentals)
        Me.SignIn.Controls.Add(Me.UseNamePassSubmit)
        Me.SignIn.Controls.Add(Me.Label7)
        Me.SignIn.Controls.Add(Me.Label6)
        Me.SignIn.Controls.Add(Me.PassWordText)
        Me.SignIn.Controls.Add(Me.UserNameText)
        Me.SignIn.Controls.Add(Me.Label5)
        Me.SignIn.Controls.Add(Me.Label4)
        Me.SignIn.Location = New System.Drawing.Point(4, 22)
        Me.SignIn.Name = "SignIn"
        Me.SignIn.Padding = New System.Windows.Forms.Padding(3)
        Me.SignIn.Size = New System.Drawing.Size(1081, 666)
        Me.SignIn.TabIndex = 2
        Me.SignIn.Text = "Sign In                            "
        '
        'UserInfo
        '
        Me.UserInfo.Location = New System.Drawing.Point(30, 202)
        Me.UserInfo.Multiline = True
        Me.UserInfo.Name = "UserInfo"
        Me.UserInfo.Size = New System.Drawing.Size(438, 361)
        Me.UserInfo.TabIndex = 10
        '
        'Rentals
        '
        Me.Rentals.Location = New System.Drawing.Point(577, 183)
        Me.Rentals.Multiline = True
        Me.Rentals.Name = "Rentals"
        Me.Rentals.Size = New System.Drawing.Size(453, 407)
        Me.Rentals.TabIndex = 9
        '
        'UseNamePassSubmit
        '
        Me.UseNamePassSubmit.Location = New System.Drawing.Point(254, 46)
        Me.UseNamePassSubmit.Name = "UseNamePassSubmit"
        Me.UseNamePassSubmit.Size = New System.Drawing.Size(75, 62)
        Me.UseNamePassSubmit.TabIndex = 8
        Me.UseNamePassSubmit.Text = "Submit"
        Me.UseNamePassSubmit.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(586, 163)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Rentals"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "User Information"
        '
        'PassWordText
        '
        Me.PassWordText.HideSelection = False
        Me.PassWordText.Location = New System.Drawing.Point(109, 88)
        Me.PassWordText.MaxLength = 10
        Me.PassWordText.Name = "PassWordText"
        Me.PassWordText.Size = New System.Drawing.Size(100, 20)
        Me.PassWordText.TabIndex = 3
        Me.PassWordText.UseSystemPasswordChar = True
        '
        'UserNameText
        '
        Me.UserNameText.Location = New System.Drawing.Point(109, 46)
        Me.UserNameText.Name = "UserNameText"
        Me.UserNameText.Size = New System.Drawing.Size(100, 20)
        Me.UserNameText.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(45, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "PassWord"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "User Name"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.PaleTurquoise
        Me.TabPage2.Controls.Add(Me.DateTimePicker1)
        Me.TabPage2.Controls.Add(Me.CheckIn)
        Me.TabPage2.Controls.Add(Me.CheckInMediaID)
        Me.TabPage2.Controls.Add(Me.Label22)
        Me.TabPage2.Controls.Add(Me.Label21)
        Me.TabPage2.Controls.Add(Me.CheckOut)
        Me.TabPage2.Controls.Add(Me.CheckOutUserID)
        Me.TabPage2.Controls.Add(Me.Label20)
        Me.TabPage2.Controls.Add(Me.Label19)
        Me.TabPage2.Controls.Add(Me.CheckOutMediaID)
        Me.TabPage2.Controls.Add(Me.Label18)
        Me.TabPage2.Controls.Add(Me.UserLookUpSearchButton)
        Me.TabPage2.Controls.Add(Me.LookUpUserLastNameText)
        Me.TabPage2.Controls.Add(Me.UserLookUpInfoBox)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.IsUserAdmin)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.DeleteUserFromSystem)
        Me.TabPage2.Controls.Add(Me.AddLastNameText)
        Me.TabPage2.Controls.Add(Me.AddFirstNameText)
        Me.TabPage2.Controls.Add(Me.AddPhoneText)
        Me.TabPage2.Controls.Add(Me.AddEmailText)
        Me.TabPage2.Controls.Add(Me.AddAddressText)
        Me.TabPage2.Controls.Add(Me.AddPasswordText)
        Me.TabPage2.Controls.Add(Me.AddNameText)
        Me.TabPage2.Controls.Add(Me.AddUserInformation)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1081, 666)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Admin                       "
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(115, 173)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker1.TabIndex = 19
        '
        'CheckIn
        '
        Me.CheckIn.Location = New System.Drawing.Point(866, 388)
        Me.CheckIn.Name = "CheckIn"
        Me.CheckIn.Size = New System.Drawing.Size(75, 23)
        Me.CheckIn.TabIndex = 18
        Me.CheckIn.Text = "Check In"
        Me.CheckIn.UseVisualStyleBackColor = True
        '
        'CheckInMediaID
        '
        Me.CheckInMediaID.Location = New System.Drawing.Point(856, 351)
        Me.CheckInMediaID.Name = "CheckInMediaID"
        Me.CheckInMediaID.Size = New System.Drawing.Size(100, 20)
        Me.CheckInMediaID.TabIndex = 17
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(874, 320)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(60, 13)
        Me.Label22.TabIndex = 16
        Me.Label22.Text = "Media ID #"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(870, 283)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(67, 16)
        Me.Label21.TabIndex = 15
        Me.Label21.Text = "Check In"
        '
        'CheckOut
        '
        Me.CheckOut.Location = New System.Drawing.Point(866, 190)
        Me.CheckOut.Name = "CheckOut"
        Me.CheckOut.Size = New System.Drawing.Size(75, 23)
        Me.CheckOut.TabIndex = 14
        Me.CheckOut.Text = "Check Out"
        Me.CheckOut.UseVisualStyleBackColor = True
        '
        'CheckOutUserID
        '
        Me.CheckOutUserID.Location = New System.Drawing.Point(850, 147)
        Me.CheckOutUserID.Name = "CheckOutUserID"
        Me.CheckOutUserID.Size = New System.Drawing.Size(100, 20)
        Me.CheckOutUserID.TabIndex = 13
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(871, 120)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(53, 13)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "User ID #"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(868, 50)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(60, 13)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "Media ID #"
        '
        'CheckOutMediaID
        '
        Me.CheckOutMediaID.Location = New System.Drawing.Point(850, 73)
        Me.CheckOutMediaID.Name = "CheckOutMediaID"
        Me.CheckOutMediaID.Size = New System.Drawing.Size(100, 20)
        Me.CheckOutMediaID.TabIndex = 0
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(859, 13)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(78, 16)
        Me.Label18.TabIndex = 12
        Me.Label18.Text = "Check Out"
        '
        'UserLookUpSearchButton
        '
        Me.UserLookUpSearchButton.Location = New System.Drawing.Point(487, 80)
        Me.UserLookUpSearchButton.Name = "UserLookUpSearchButton"
        Me.UserLookUpSearchButton.Size = New System.Drawing.Size(75, 23)
        Me.UserLookUpSearchButton.TabIndex = 11
        Me.UserLookUpSearchButton.Text = "Search"
        Me.UserLookUpSearchButton.UseVisualStyleBackColor = True
        '
        'LookUpUserLastNameText
        '
        Me.LookUpUserLastNameText.Location = New System.Drawing.Point(455, 44)
        Me.LookUpUserLastNameText.Name = "LookUpUserLastNameText"
        Me.LookUpUserLastNameText.Size = New System.Drawing.Size(140, 20)
        Me.LookUpUserLastNameText.TabIndex = 0
        '
        'UserLookUpInfoBox
        '
        Me.UserLookUpInfoBox.Location = New System.Drawing.Point(347, 118)
        Me.UserLookUpInfoBox.Multiline = True
        Me.UserLookUpInfoBox.Name = "UserLookUpInfoBox"
        Me.UserLookUpInfoBox.Size = New System.Drawing.Size(359, 345)
        Me.UserLookUpInfoBox.TabIndex = 0
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(473, 13)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(103, 16)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "User Look Up"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(84, 11)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(107, 16)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Add New User"
        '
        'IsUserAdmin
        '
        Me.IsUserAdmin.FormattingEnabled = True
        Me.IsUserAdmin.Items.AddRange(New Object() {"TRUE", "FALSE"})
        Me.IsUserAdmin.Location = New System.Drawing.Point(115, 412)
        Me.IsUserAdmin.Name = "IsUserAdmin"
        Me.IsUserAdmin.Size = New System.Drawing.Size(100, 21)
        Me.IsUserAdmin.TabIndex = 9
        Me.IsUserAdmin.Text = "FALSE"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(32, 421)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(47, 13)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Is Admin"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(32, 373)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 13)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Last Name"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(32, 326)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "First Name"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(32, 270)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Phone #"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(32, 230)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "E-Mail"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(29, 173)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Birth date"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(29, 121)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Address"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(29, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Username"
        '
        'DeleteUserFromSystem
        '
        Me.DeleteUserFromSystem.Location = New System.Drawing.Point(487, 480)
        Me.DeleteUserFromSystem.Name = "DeleteUserFromSystem"
        Me.DeleteUserFromSystem.Size = New System.Drawing.Size(75, 23)
        Me.DeleteUserFromSystem.TabIndex = 0
        Me.DeleteUserFromSystem.Text = "Delete User"
        Me.DeleteUserFromSystem.UseVisualStyleBackColor = True
        '
        'AddLastNameText
        '
        Me.AddLastNameText.Location = New System.Drawing.Point(115, 367)
        Me.AddLastNameText.Name = "AddLastNameText"
        Me.AddLastNameText.Size = New System.Drawing.Size(100, 20)
        Me.AddLastNameText.TabIndex = 8
        '
        'AddFirstNameText
        '
        Me.AddFirstNameText.Location = New System.Drawing.Point(115, 320)
        Me.AddFirstNameText.Name = "AddFirstNameText"
        Me.AddFirstNameText.Size = New System.Drawing.Size(100, 20)
        Me.AddFirstNameText.TabIndex = 7
        '
        'AddPhoneText
        '
        Me.AddPhoneText.Location = New System.Drawing.Point(115, 270)
        Me.AddPhoneText.Name = "AddPhoneText"
        Me.AddPhoneText.Size = New System.Drawing.Size(100, 20)
        Me.AddPhoneText.TabIndex = 6
        '
        'AddEmailText
        '
        Me.AddEmailText.Location = New System.Drawing.Point(115, 224)
        Me.AddEmailText.Name = "AddEmailText"
        Me.AddEmailText.Size = New System.Drawing.Size(100, 20)
        Me.AddEmailText.TabIndex = 5
        '
        'AddAddressText
        '
        Me.AddAddressText.Location = New System.Drawing.Point(115, 121)
        Me.AddAddressText.Name = "AddAddressText"
        Me.AddAddressText.Size = New System.Drawing.Size(100, 20)
        Me.AddAddressText.TabIndex = 3
        '
        'AddPasswordText
        '
        Me.AddPasswordText.Location = New System.Drawing.Point(115, 80)
        Me.AddPasswordText.Name = "AddPasswordText"
        Me.AddPasswordText.Size = New System.Drawing.Size(100, 20)
        Me.AddPasswordText.TabIndex = 2
        '
        'AddNameText
        '
        Me.AddNameText.Location = New System.Drawing.Point(115, 38)
        Me.AddNameText.Name = "AddNameText"
        Me.AddNameText.Size = New System.Drawing.Size(100, 20)
        Me.AddNameText.TabIndex = 1
        '
        'AddUserInformation
        '
        Me.AddUserInformation.Location = New System.Drawing.Point(63, 452)
        Me.AddUserInformation.Name = "AddUserInformation"
        Me.AddUserInformation.Size = New System.Drawing.Size(75, 23)
        Me.AddUserInformation.TabIndex = 0
        Me.AddUserInformation.Text = "Add user"
        Me.AddUserInformation.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage1.Controls.Add(Me.SearchReturnText)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.SearchMediaSubmitButton)
        Me.TabPage1.Controls.Add(Me.SearchText)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.SearchTypeDrop)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1081, 666)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Search                      "
        '
        'SearchReturnText
        '
        Me.SearchReturnText.Location = New System.Drawing.Point(34, 201)
        Me.SearchReturnText.Multiline = True
        Me.SearchReturnText.Name = "SearchReturnText"
        Me.SearchReturnText.Size = New System.Drawing.Size(986, 433)
        Me.SearchReturnText.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(839, 19)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Title                                        Author                              " & _
    "     Genre                                     Category                         " & _
    "    Location"
        '
        'SearchMediaSubmitButton
        '
        Me.SearchMediaSubmitButton.Location = New System.Drawing.Point(121, 96)
        Me.SearchMediaSubmitButton.Name = "SearchMediaSubmitButton"
        Me.SearchMediaSubmitButton.Size = New System.Drawing.Size(75, 23)
        Me.SearchMediaSubmitButton.TabIndex = 5
        Me.SearchMediaSubmitButton.Text = "Submit"
        Me.SearchMediaSubmitButton.UseVisualStyleBackColor = True
        '
        'SearchText
        '
        Me.SearchText.Location = New System.Drawing.Point(13, 60)
        Me.SearchText.Name = "SearchText"
        Me.SearchText.Size = New System.Drawing.Size(331, 20)
        Me.SearchText.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Search By:"
        '
        'SearchTypeDrop
        '
        Me.SearchTypeDrop.FormattingEnabled = True
        Me.SearchTypeDrop.Items.AddRange(New Object() {"Name", "Author", "Genre"})
        Me.SearchTypeDrop.Location = New System.Drawing.Point(75, 21)
        Me.SearchTypeDrop.Name = "SearchTypeDrop"
        Me.SearchTypeDrop.Size = New System.Drawing.Size(121, 21)
        Me.SearchTypeDrop.TabIndex = 0
        Me.SearchTypeDrop.Text = "Choose Option"
        '
        'Search
        '
        Me.Search.Controls.Add(Me.TabPage1)
        Me.Search.Controls.Add(Me.TabPage2)
        Me.Search.Controls.Add(Me.SignIn)
        Me.Search.Location = New System.Drawing.Point(0, 1)
        Me.Search.Name = "Search"
        Me.Search.SelectedIndex = 0
        Me.Search.Size = New System.Drawing.Size(1089, 692)
        Me.Search.TabIndex = 0
        Me.Search.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1089, 693)
        Me.Controls.Add(Me.Search)
        Me.Name = "Form1"
        Me.Text = "Your Library"
        Me.SignIn.ResumeLayout(False)
        Me.SignIn.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
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
    Friend WithEvents UseNamePassSubmit As System.Windows.Forms.Button
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

End Class
