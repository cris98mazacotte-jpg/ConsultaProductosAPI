
Namespace Models

    Public Class Producto

        Public Property Id As Integer
        Public Property Nombre As String
        Public Property Descripcion As String
        Public Property Precio As Decimal
        Public Property Stock As Integer
        Public Property FechaRegistro As DateTime
        Public Property CategoriaId As Integer

        ' Relacion con Categoria
        Public Property Categoria As Categoria

    End Class

End Namespace
