Public Class BackupCleaner
    Public Sub Clean(folder As String)
        System.IO.Directory.Delete("/var/backups/" & folder, True)
    End Sub
End Class
