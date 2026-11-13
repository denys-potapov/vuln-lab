Imports Microsoft.AspNetCore.Mvc

<ApiController>
<Route("convert")>
Public Class ConvertController
    Inherits ControllerBase

    ' Execute is declared on ToolRunner and inherited by PdfConverter
    <HttpGet("pdf")>
    Public Function ToPdf(file As String) As IActionResult
        Dim converter As PdfConverter = New PdfConverter()
        converter.Execute(file & " output.pdf")
        Return Ok()
    End Function
End Class
