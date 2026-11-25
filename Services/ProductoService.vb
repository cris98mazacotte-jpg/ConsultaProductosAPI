
Imports System.Collections.Generic
Imports System.Threading.Tasks
Imports ConsultaProductosAPI.Models
Imports ConsultaProductosAPI.Repositories

Namespace Services

    Public Class ProductoService
        Implements IProductoService

        Private ReadOnly _repository As IProductoRepository

        Public Sub New(repository As IProductoRepository)
            _repository = repository
        End Sub

        Public Async Function ObtenerPorPrecioMayorAsync(
            precio As Decimal
        ) As Task(Of List(Of Producto)) _
            Implements IProductoService.ObtenerPorPrecioMayorAsync

            Return Await _repository.ObtenerPorPrecioMayorAsync(precio)

        End Function

    End Class

End Namespace
