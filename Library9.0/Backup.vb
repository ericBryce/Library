Public Class Form1

    Dim mediaSearch As Media = New Media
    Dim UserLogin As Admin = New Admin

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SearchMediaSubmitButton.Click
        SearchReturnText.Clear()
        Dim searchType, search As String
        searchType = SearchTypeDrop.Text
        search = SearchText.Text
        SearchReturnText.Text = mediaSearch.searchMedia(searchType, search)
    End Sub

    Private Sub UseNamePassSubmit_Click(sender As Object, e As EventArgs) Handles UseNamePassSubmit.Click
        Dim userName As String
        Dim password As String
        userName = UserNameText.Text
        password = PassWordText.Text
        UserLogin.SignIn(userName, password)
        UserInfo.Text = UserLogin.PrintUserInfo()
        Rentals.Text = UserLogin.PrintUserRentals()
    End Sub

    Private Sub AddUserInformation_Click(sender As Object, e As EventArgs) Handles AddUserInformation.Click
        UserLogin.addUser(AddNameText.Text, AddPasswordText.Text, IsUserAdmin.Text, AddAddressText.Text,
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
        UserLookUpInfoBox.Text = UserLogin.UserLookUp(LookUpUserLastNameText.Text)
    End Sub

    Private Sub DeleteUserFromSystem_Click(sender As Object, e As EventArgs) Handles DeleteUserFromSystem.Click
        UserLogin.deleteUser()
    End Sub

    Private Sub CheckOut_Click(sender As Object, e As EventArgs) Handles CheckOut.Click
        mediaSearch.CheckOutMedia(CheckOutMediaID.Text, CheckOutUserID.Text)
    End Sub

    Private Sub CheckIn_Click(sender As Object, e As EventArgs) Handles CheckIn.Click
        mediaSearch.CheckInMedia(CheckInMediaID.Text)
    End Sub

End Class
