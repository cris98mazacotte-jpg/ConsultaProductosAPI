
Imports Microsoft.AspNetCore.Mvc
Imports System.Threading.Tasks
Imports ConsultaProductosAPI.Models
Imports ConsultaProductosAPI.Services

Namespace Controllers

    <ApiController>
    <Route("api/[controller]")>
    Public Class ProductoController
        Inherits ControllerBase

        Private ReadOnly _service As IProductoService

        Public Sub New(service As IProductoService)
            _service = service
        End Sub

        <HttpGet("filtrar-precio")>
        Public Async Function ObtenerPorPrecioSuperior(
            <FromQuery> precio As Decimal
        ) As Task(Of IActionResult)

            Dim productos = Await _service.ObtenerPorPrecioMayorAsync(precio)

            Return Ok(productos)

        End Function

    End Class

End Namespace
