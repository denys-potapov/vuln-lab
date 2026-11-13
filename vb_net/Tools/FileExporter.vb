Public Class FileExporter
    Protected Header As String = ""

    Public Sub Save(path As String)
        System.IO.File.WriteAllText("/data/exports/" & path, Header)
    End Sub
End Class
