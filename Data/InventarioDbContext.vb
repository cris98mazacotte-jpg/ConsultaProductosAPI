Imports Microsoft.EntityFrameworkCore
Imports ConsultaProductosAPI.Models

Namespace Data

    Public Class InventarioDbContext
        Inherits DbContext

        Public Sub New(options As DbContextOptions(Of InventarioDbContext))
            MyBase.New(options)
        End Sub

        Public Property Productos As DbSet(Of Producto)

        Public Property Categorias As DbSet(Of Categoria)

    End Class

End Namespace
