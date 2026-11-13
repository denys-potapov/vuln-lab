Imports Microsoft.AspNetCore.Builder
Imports Microsoft.Extensions.DependencyInjection

Module Program
    Sub Main(args As String())
        Dim builder = WebApplication.CreateBuilder(args)
        builder.Services.AddControllers()

        Dim app = builder.Build()
        app.MapControllers()
        app.Run()
    End Sub
End Module
