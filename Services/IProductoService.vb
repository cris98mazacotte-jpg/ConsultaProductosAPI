
Imports System.Collections.Generic
Imports System.Threading.Tasks
Imports ConsultaProductosAPI.Models

Namespace Services

    Public Interface IProductoService

        Function ObtenerPorPrecioMayorAsync(precio As Decimal) As Task(Of List(Of Producto))

    End Interface

End Namespace
