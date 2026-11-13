Imports Microsoft.AspNetCore.Mvc

<ApiController>
<Route("network")>
Public Class NetworkController
    Inherits ControllerBase

    ' The call's argument list is split across lines (implicit line continuation)
    <HttpGet("ping")>
    Public Function Ping(host As String, count As Integer) As IActionResult
        NetworkTools.RunPing(
            host,
            count)
        Return Ok()
    End Function
End Class
