Imports System.Diagnostics

Public Class ToolRunner
    Protected ToolPath As String = "/usr/bin/env"

    Public Sub Execute(arguments As String)
        Process.Start(ToolPath, arguments)
    End Sub
End Class
