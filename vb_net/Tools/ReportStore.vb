Public Module ReportStore
    Public Sub DeleteReport(name As String, year As Integer)
        System.IO.File.Delete("/data/reports/" & year & "/" & name)
    End Sub
End Module
