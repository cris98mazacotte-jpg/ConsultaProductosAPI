# Consultas avanzadas con LINQ y Entity Framework Core

## Descripción

El objetivo es implementar consultas avanzadas utilizando LINQ y Entity Framework Core para buscar productos cuyo precio sea superior a un importe determinado y ordenar los resultados de menor a mayor precio.

## Tecnologías utilizadas

- Visual Basic .NET
- .NET 10
- ASP.NET Core Web API
- Entity Framework Core
- SQL Server
- LINQ
- Swagger

## Estructura del proyecto

- **Controllers:** contiene los controladores de la API.
- **Data:** contiene el contexto de Entity Framework Core.
- **Models:** contiene las entidades Producto y Categoria.
- **Repositories:** contiene la lógica de acceso a datos.
- **Services:** contiene la lógica de los servicios.

## Consulta LINQ implementada

```vb
Dim resultado = Await _contexto.Productos _
    .Where(Function(p) p.Precio > precio) _
    .OrderBy(Function(p) p.Precio) _
    .ToListAsync()
```

### Explicación

- `Where`: filtra los productos cuyo precio sea superior al importe indicado.
- `OrderBy`: ordena los resultados por precio de menor a mayor.
- `ToListAsync`: ejecuta la consulta y devuelve una lista de productos.

## Endpoint implementado

**GET /api/Producto/filtrar-precio**

Parámetro de consulta: `precio`.

Ejemplo:

`GET /api/Producto/filtrar-precio?precio=100000`

## Pruebas realizadas

| Importe | Resultado |
|---|---|
| 0 | Devuelve los 5 productos de prueba |
| 100000 | Devuelve 3 productos |
| 5000000 | Devuelve una lista vacía |

Todas las pruebas devolvieron HTTP 200 OK.

## Configuración de la base de datos

El proyecto utiliza SQL Server y la base de datos `InventarioDB`.

La cadena de conexión se encuentra en `appsettings.json`. Debe adaptarse al nombre de la instancia de SQL Server del entorno donde se ejecute el proyecto.

## Ejecución

1. Abrir el proyecto en Visual Studio.
2. Verificar la cadena de conexión a SQL Server.
3. Ejecutar la aplicación con F5.
4. Acceder a Swagger para probar el endpoint.
