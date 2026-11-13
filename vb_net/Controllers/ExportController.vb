Imports Microsoft.AspNetCore.Mvc

<ApiController>
<Route("export")>
Public Class ExportController
    Inherits ControllerBase

    ' Save is declared on FileExporter and inherited by CsvExporter
    <HttpPost("csv")>
    Public Function ToCsv(file As String) As IActionResult
        Dim exporter As CsvExporter = New CsvExporter()
        exporter.Save(file & ".csv")
        Return Ok()
    End Function
End Class
