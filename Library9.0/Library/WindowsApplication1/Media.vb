Imports Excel = Microsoft.Office.Interop.Excel
Public Class Media
    'opens exell, and creates workbook and worksheet objects
    Dim APP As New Excel.Application
    Dim worksheetMedia As Excel.Worksheet
    Dim workbookMedia As Excel.Workbook
    Dim mediaRowHeight As Integer
    Dim dueDatesAndFines As Fines = New Fines
    Dim isBlocked As Boolean = False

    Sub New()
        'assigns preexisting media excel sheet to our objects, info passed in is a relative path to the sheets included in the project folder
        workbookMedia = APP.Workbooks.Open(IO.Path.Combine(IO.Directory.GetParent(Application.ExecutablePath).FullName, "media.xlsx"))
        worksheetMedia = workbookMedia.Worksheets("sheet1")
        'm2 is the cell where the size is kept in the worksheet
        mediaRowHeight = worksheetMedia.Range("M2").Value
    End Sub

    Function searchMedia(ByRef searchType As String, ByRef search As String) As String
        Dim currentCell As String
        Dim column As Integer
        Dim available As String
        'checks to make sure all fields are filled out
        If searchType = "Choose Option" Then
            MsgBox("Please select search type")
            Return ""
        End If

        If search = "" Then
            MsgBox("Please enter search criteria")
            Return ""
        End If

        If search.Length < 3 Then
            MsgBox("please enter at least 3 characters")
            Return ""
        End If

        'gives search option a more usable value
        If searchType = "Name" Then column = 1
        If searchType = "Author" Then column = 2
        If searchType = "Genre" Then column = 4

        'string builder is used to make output easier
        Dim builder As New System.Text.StringBuilder
        builder.Append("")
        For row As Integer = 2 To mediaRowHeight
            currentCell = worksheetMedia.Cells(row, column).Value
            'substrings are used so searcher doesn't have to get the name exactly correct
            If search.Substring(0, 3).ToLower = currentCell.Substring(0, 3).ToLower Then
                If worksheetMedia.Range("E" & row).Value = -1 Then
                    available = "Available"
                Else : available = "Not Available"
                End If
                Dim name As String = worksheetMedia.Range("A" & row).Value
                Dim author As String = worksheetMedia.Range("B" & row).Value
                Dim type As String = worksheetMedia.Range("C" & row).Value
                Dim genre As String = worksheetMedia.Range("D" & row).Value
                Dim loc As String = worksheetMedia.Range("F" & row).Value

                builder.Append(name.PadRight(20) & author.PadRight(18) & type.PadRight(12) & _
                               genre.PadRight(12) & loc.PadRight(12) & available & vbNewLine)

            End If
        Next
        If builder.ToString = "" Then
            builder.Append("No results")
        End If
        Return builder.ToString
    End Function

    Public Function findRentals(userId As Integer) As String
        Dim fine As Double = 0
        Dim sumFine As Double = 0
        'string builder used to make out easier
        Dim builder As New System.Text.StringBuilder
        For row As Integer = 2 To mediaRowHeight
            'searched for loaned to cell for user rentals and returns book info
            'adding book availabitly later
            If userId = worksheetMedia.Range("E" & row).Value Then
                Dim dueDate As Date = worksheetMedia.Range("H" & row).Value
                If dueDatesAndFines.GetFines(dueDate) > 0 Then
                    fine = dueDatesAndFines.GetFines(dueDate)
                End If
                builder.Append("Title: " & worksheetMedia.Range("A" & row).Value &
                               ",  Media ID: " & worksheetMedia.Range("G" & row).Value &
                               "  Due Date: " & worksheetMedia.Range("H" & row).Value &
                               "  Fine: " & fine & vbNewLine)
                sumFine += fine
                fine = 0
            End If
        Next
        builder.Append(vbNewLine & "Total fines:  $" & sumFine)
        Return builder.ToString
    End Function

    Sub CheckOutMedia(mediaID As String, userID As String)
        'check for null values
        If mediaID = "" Or userID = "" Then
            MsgBox("Please enter all fields")
            Exit Sub
        End If

        If worksheetMedia.Range("A" & mediaID).Value = "" Then
            MsgBox("Media ID does not match any media in system")
            Exit Sub
        End If

        For row As Integer = 2 To mediaRowHeight
            If userID = worksheetMedia.Range("E" & row).Value Then
                If dueDatesAndFines.GetFines(worksheetMedia.Range("H" & row).Value) > 0 Then
                    MsgBox("This user has a block on there account due to late fees")
                    Exit Sub
                End If
            End If
        Next

        'if media value = -1(available) assigns user to that book and a due date
        If worksheetMedia.Range("E" & mediaID).Value = -1 Then
            worksheetMedia.Range("E" & mediaID).Value = userID
            worksheetMedia.Range("H" & mediaID).Value = dueDatesAndFines.DueDate
            MsgBox("Checkout complete")
            SaveMediaDatabase()
        Else : MsgBox("Media already checked out")
        End If


    End Sub

    Sub CheckInMedia(mediaID As String)
        If mediaID = "" Then
            MsgBox("Please enter all fields")
            Exit Sub
        End If

        If worksheetMedia.Range("G" & mediaID).Value = "" Then
            MsgBox("Media ID does not match any media in system")
            Exit Sub
        End If

        If dueDatesAndFines.GetFines(worksheetMedia.Range("H" & mediaID).Value) > 0 Then
            MsgBox("This book is over due, Fine = $" & dueDatesAndFines.GetFines(worksheetMedia.Range("H" & mediaID).Value))
            Exit Sub
        End If
        'resets value of book to -1(available)
        worksheetMedia.Range("E" & mediaID).Value = -1
        MsgBox("Media Checked In")
        SaveMediaDatabase()
    End Sub
    Sub deletefines(mediaId As Integer)
        If worksheetMedia.Range("G" & mediaId).Value = "" Then
            MsgBox("Media ID does not match any media in system")
            Exit Sub
        End If
        Dim result = MessageBox.Show("Are you sure you want to clear user fines", "Delete Fines", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = Windows.Forms.DialogResult.Yes Then
            worksheetMedia.Range("E" & mediaId).Value = -1
            worksheetMedia.Range("H" & mediaId).Value = ""
            MsgBox("Fines cleared")
            SaveMediaDatabase()
        Else : MsgBox("Fines still exist")
        End If
    End Sub

    'these are called in the dispose(destructor) so changes are saved and the excel sheet closes when the program closes
    Sub SaveMediaDatabase()
        workbookMedia.Save()
    End Sub
    Sub CloseUserDatabase()
        workbookMedia.Close()
        APP.Quit()
    End Sub
End Class
