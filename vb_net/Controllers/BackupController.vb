Imports Microsoft.AspNetCore.Mvc

<ApiController>
<Route("backup")>
Public Class BackupController
    Inherits ControllerBase

    ' The variable's type comes from the `As New` shorthand
    <HttpGet("archive")>
    Public Function Archive(folder As String) As IActionResult
        Dim archiver As New Archiver()
        archiver.Compress(folder)
        Return Ok()
    End Function
End Class
