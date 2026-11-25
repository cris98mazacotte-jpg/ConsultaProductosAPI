
Imports Microsoft.EntityFrameworkCore
Imports System.Collections.Generic
Imports System.Threading.Tasks
Imports ConsultaProductosAPI.Data
Imports ConsultaProductosAPI.Models

Namespace Repositories

    Public Class ProductoRepository
        Implements IProductoRepository

        Private ReadOnly _contexto As InventarioDbContext

        Public Sub New(contexto As InventarioDbContext)
            _contexto = contexto
        End Sub

        Public Async Function ObtenerPorPrecioMayorAsync(
            precio As Decimal
        ) As Task(Of List(Of Producto)) _
            Implements IProductoRepository.ObtenerPorPrecioMayorAsync

            Dim resultado = Await _contexto.Productos _
                .Where(Function(p) p.Precio > precio) _
                .OrderBy(Function(p) p.Precio) _
                .ToListAsync()

            Return resultado

        End Function

    End Class

End Namespace
