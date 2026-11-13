Imports System.Diagnostics

Public Module NetworkTools
    Public Sub RunPing(host As String, count As Integer)
        Process.Start("ping", "-c " & count & " " & host)
    End Sub
End Module
