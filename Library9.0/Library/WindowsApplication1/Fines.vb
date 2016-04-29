Public Class Fines
    Function DueDate() As Date
        Return DateAdd(DateInterval.Month, 1, DateTime.Today)
    End Function

    Function GetFines(dueDate As Date) As Double
        Dim fine As Double
        Dim daysLate As Integer = 0
        If DateTime.Today > dueDate Then
            daysLate = DateDiff(DateInterval.Day, dueDate, DateTime.Today)
        End If
        fine = (daysLate * 0.05)
        Return fine
    End Function
End Class
