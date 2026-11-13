Imports Microsoft.AspNetCore.Mvc

<ApiController>
<Route("backup")>
Public Class BackupController
    Inherits ControllerBase

    ' The variable's type comes from the `As New` shorthand
    <HttpDelete("{folder}")>
    Public Function Remove(folder As String) As IActionResult
        Dim cleaner As New BackupCleaner()
        cleaner.Clean(folder)
        Return Ok()
    End Function
End Class
