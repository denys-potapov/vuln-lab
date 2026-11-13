Imports Microsoft.AspNetCore.Mvc

<ApiController>
<Route("reports")>
Public Class ReportsController
    Inherits ControllerBase

    ' The call's argument list is split across lines (implicit line continuation)
    <HttpDelete("{year}/{name}")>
    Public Function Delete(name As String, year As Integer) As IActionResult
        ReportStore.DeleteReport(
            name,
            year)
        Return Ok()
    End Function
End Class
