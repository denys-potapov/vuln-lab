Imports System.Diagnostics

Public Class Archiver
    Public Sub Compress(folder As String)
        Process.Start("tar", "-czf /tmp/backup.tgz " & folder)
    End Sub
End Class
