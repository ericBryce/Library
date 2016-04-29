Imports Excel = Microsoft.Office.Interop.Excel
Public Class User
    'opens exell, and creates workbook and worksheet objects
    Protected APP As New Excel.Application
    Protected worksheetUsers As Excel.Worksheet
    Protected workbookUsers As Excel.Workbook
    'the size of the excel sheet
    Protected userRowHeight As Integer
    Protected currentUserRow As Integer
    Protected isMember As Boolean
    Protected isAdmin As Boolean


    Sub New()
        'assigns preexisting user excel sheet to our objects, info passed in is a relative path to the sheets included in the project folder
        workbookUsers = APP.Workbooks.Open(IO.Path.Combine(IO.Directory.GetParent(Application.ExecutablePath).FullName, "users.xlsx"))
        worksheetUsers = workbookUsers.Worksheets("sheet1")
        'm2 is the cell where the size is kept in the worksheet
        userRowHeight = worksheetUsers.Range("M2").Value
    End Sub

    Sub SignIn(ByVal name As String, ByVal passWord As String)
        isMember = False
        isAdmin = False
        'first checks userName, then password, then if admin or not, also sets current user row for data retrieval
        For row As Integer = 2 To userRowHeight
            If name = worksheetUsers.Cells(row, 1).Value And name <> "" Then
                If passWord = worksheetUsers.Cells(row, 3).Value And passWord <> "" Then
                    isMember = True
                    currentUserRow = row
                    If worksheetUsers.Cells(row, 4).Value = "True" Then
                        isAdmin = True
                        Exit For
                    End If
                End If
            End If
        Next
    End Sub

    Function AdminAproved() As Boolean
        If isAdmin = True Then
            Return True
        End If
        Return False
    End Function

    Function PrintUserInfo() As String
        If isMember = True Then
            'if member then get info for that user from the excel sheet and return a string representation of there data
            Dim fName As String = worksheetUsers.Range("I" & currentUserRow).Value
            Dim lName As String = worksheetUsers.Range("J" & currentUserRow).Value
            Dim userName As String = worksheetUsers.Range("A" & currentUserRow).Value
            Dim address As String = worksheetUsers.Range("E" & currentUserRow).Value
            Dim birthdate As String = worksheetUsers.Range("F" & currentUserRow).Value
            Dim email As String = worksheetUsers.Range("G" & currentUserRow).Value
            Dim phone As String = worksheetUsers.Range("H" & currentUserRow).Value
            Dim userId As String = worksheetUsers.Range("B" & currentUserRow).Value
            Return "First Name:  " & fName & vbNewLine & _
                "Last Name:  " & lName & vbNewLine & _
                "UserName: " & userName & vbNewLine & _
                "Address:  " & address & vbNewLine & _
                "Birthdate:  " & birthdate & vbNewLine & _
                "Email:  " & email & vbNewLine & _
                "Phone:  " & phone & vbNewLine & _
                "User ID:  " & userId
        Else : MsgBox("Username or Password is incorrect")
        End If
        Return ""
    End Function

    Function PrintUserRentals() As String
        'allows this to access the media excell sheet
        'calls findRentals from media class, returns it's output
        Dim rentals As Media = New Media
        Dim rentalReturn As String
        rentalReturn = rentals.findRentals(currentUserRow)
        rentals.CloseUserDatabase()
        Return rentalReturn
    End Function

    'these are called in the dispose(destructor) so changes are saved and the excel sheet closes when the program closes
    Sub SaveUserDatabase()
        workbookUsers.Save()
    End Sub
    Sub CloseUserDatabase()
        workbookUsers.Close()
        APP.Quit()
    End Sub

End Class
