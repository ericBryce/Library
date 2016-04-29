Public Class Admin
    Inherits User

    'opens exell, and creates workbook and worksheet objects
    Sub addUser(name As String, password As String, isAdmin As String,
                address As String, birthdate As String, email As String, phone As String,
                fName As String, lName As String)
        'message box asks admin to confirm or cancel adding user or not
        For row As Integer = 2 To userRowHeight
            If name = worksheetUsers.Range("A" & row).Value Then
                MsgBox("User name already exists")
                Exit Sub
            End If
        Next
        Dim result = MessageBox.Show("Are you sure you want to add user", "Add User", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = Windows.Forms.DialogResult.Yes Then
            'values passed in parameters
            worksheetUsers.Range("A" & userRowHeight).Value = name
            worksheetUsers.Range("B" & userRowHeight).Value = userRowHeight
            worksheetUsers.Range("C" & userRowHeight).Value = password
            worksheetUsers.Range("D" & userRowHeight).Value = isAdmin
            worksheetUsers.Range("E" & userRowHeight).Value = address
            worksheetUsers.Range("F" & userRowHeight).Value = birthdate
            worksheetUsers.Range("G" & userRowHeight).Value = email
            worksheetUsers.Range("H" & userRowHeight).Value = phone
            worksheetUsers.Range("I" & userRowHeight).Value = fName
            worksheetUsers.Range("J" & userRowHeight).Value = lName
            'updates rowheight in excel sheet
            userRowHeight = userRowHeight + 1
            worksheetUsers.Range("M2").Value = userRowHeight
            MsgBox("User added")
            SaveUserDatabase()
        Else : MsgBox("User not added")
        End If
    End Sub

    Sub deleteUser()
        'check to make sure to delete current user, current user is updated in user lookup wich must be done first
        Dim result = MessageBox.Show("Are you sure you want to delete user ", "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = Windows.Forms.DialogResult.Yes Then
            worksheetUsers.Range("A" & currentUserRow).EntireRow.Delete()
            'updates rowheight in excel sheet
            userRowHeight = userRowHeight - 1
            worksheetUsers.Range("M2").Value = userRowHeight
            MsgBox("User deleted")
            SaveUserDatabase()
        Else : MsgBox("User not deleted")
        End If
    End Sub

    Function UserLookUp(lastName As Integer) As String
        isMember = True
        For row As Integer = 2 To userRowHeight
            currentUserRow = row
            If lastName = worksheetUsers.Range("B" & row).Value Then
                Return PrintUserInfo() & vbNewLine & vbNewLine & "UserRentals:" & vbNewLine & PrintUserRentals()
            End If
        Next
        Return "User not found"
    End Function



End Class
