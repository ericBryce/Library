Public Class Form1

    'rename this, doesn't make sense
    Dim media As Media = New Media
    'rename this, doesn't make sense
    Dim user As Admin = New Admin

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SearchMediaSubmitButton.Click
        SearchReturnText.Clear()
        SearchReturnText.Text = media.searchMedia(SearchTypeDrop.Text, SearchText.Text)
    End Sub

    Private Sub UseNamePassSubmit_Click(sender As Object, e As EventArgs) Handles SignInButton.Click
        user.SignIn(UserNameText.Text, PassWordText.Text)
        If user.AdminAproved() Then
            Panel1.Visible = True
        End If
        UserInfo.Text = user.PrintUserInfo()
        Rentals.Text = user.PrintUserRentals()
        UserNameText.Clear()
        PassWordText.Clear()
    End Sub

    Private Sub AddUserInformation_Click(sender As Object, e As EventArgs) Handles AddUserInformation.Click
        user.addUser(AddNameText.Text, AddPasswordText.Text, IsUserAdmin.Text, AddAddressText.Text,
                          DateTimePicker1.Text, AddEmailText.Text, AddPhoneText.Text,
                          AddFirstNameText.Text, AddLastNameText.Text)
        AddNameText.Clear()
        AddPasswordText.Clear()
        IsUserAdmin.Text = "False"
        AddAddressText.Clear()
        AddEmailText.Clear()
        AddPhoneText.Clear()
        AddFirstNameText.Clear()
        AddLastNameText.Clear()
    End Sub

    Private Sub UserLookUpSearchButton_Click(sender As Object, e As EventArgs) Handles UserLookUpSearchButton.Click
        If IsNumeric(LookUpUserLastNameText.Text) Then
            UserLookUpInfoBox.Text = user.UserLookUp(LookUpUserLastNameText.Text)
        Else : MsgBox("Please only enter user ID's")
        End If
    End Sub

    Private Sub DeleteUserFromSystem_Click(sender As Object, e As EventArgs) Handles DeleteUserFromSystem.Click
        user.deleteUser()
        UserLookUpInfoBox.Clear()
    End Sub

    Private Sub CheckOut_Click(sender As Object, e As EventArgs) Handles CheckOut.Click
        If IsNumeric(CheckOutMediaID) Or IsNumeric(CheckOutUserID) Then
            media.CheckOutMedia(CheckOutMediaID.Text, CheckOutUserID.Text)
            CheckOutMediaID.Clear()
            CheckOutUserID.Clear()
        Else : MsgBox("Please only enter id numbers")
        End If
    End Sub

    Private Sub CheckIn_Click(sender As Object, e As EventArgs) Handles CheckIn.Click
        If IsNumeric(CheckInMediaID) Then
            media.CheckInMedia(CheckInMediaID.Text)
            CheckInMediaID.Clear()
        Else : MsgBox("Please only enter id number")
        End If

    End Sub

    Private Sub FinePaidButton_Click(sender As Object, e As EventArgs) Handles FinePaidButton.Click
        media.deletefines(FinePaidText.Text)
    End Sub

    Private Sub SignOutButton_Click(sender As Object, e As EventArgs) Handles SignOutButton.Click
        UserInfo.Clear()
        Rentals.Clear()
        UserNameText.Clear()
        PassWordText.Clear()
        Panel1.Visible = False
    End Sub
End Class
