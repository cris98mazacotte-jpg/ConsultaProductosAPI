
Namespace Models

    Public Class Categoria

        Public Property Id As Integer
        Public Property Nombre As String
        Public Property Descripcion As String

        ' Relacion con Productos
        Public Overridable Property Productos As ICollection(Of Producto)

    End Class

End Namespace
