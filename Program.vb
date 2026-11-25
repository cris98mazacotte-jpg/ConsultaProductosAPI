Imports ConsultaProductosAPI.Data
Imports ConsultaProductosAPI.Repositories
Imports ConsultaProductosAPI.Services
Imports Microsoft.AspNetCore.Builder
Imports Microsoft.EntityFrameworkCore
Imports Microsoft.Extensions.Configuration
Imports Microsoft.Extensions.DependencyInjection
Imports Microsoft.Extensions.Hosting
Imports System

Module Program

    Sub Main(args As String())

        Dim builder = WebApplication.CreateBuilder(args)

        ' Configurar la conexion a SQL Server
        Dim cadenaConexion As String =
        builder.Configuration.GetConnectionString("ConexionInventario")

        Dim configurarDb As Action(Of DbContextOptionsBuilder) =
        Sub(options)
            options.UseSqlServer(cadenaConexion)
        End Sub

        builder.Services.AddDbContext(Of InventarioDbContext)(configurarDb)

        ' Configurar servicios de la API
        builder.Services.AddControllers()
        builder.Services.AddEndpointsApiExplorer()
        builder.Services.AddSwaggerGen()

        ' Registrar Repository y Service
        builder.Services.AddScoped(Of IProductoRepository, ProductoRepository)()
        builder.Services.AddScoped(Of IProductoService, ProductoService)()

        Dim app = builder.Build()

        If app.Environment.IsDevelopment() Then
            app.UseSwagger()
            app.UseSwaggerUI()
        End If

        app.UseHttpsRedirection()
        app.MapControllers()

        app.Run()

    End Sub

End Module
