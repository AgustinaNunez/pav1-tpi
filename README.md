# pav1-tpi
## Clotta
    Universidad Tecnológica Nacional - Facultad Regional Córdoba
<hr>

### Ramo o actividad
Venta de artículos de indumentaria.
### Objetivo del sistema
Gestionar las ventas de un local de ropa, controlando el stock disponible y generando informes de utilidad para el negocio. 
### Alcances
* Gestionar ventas.
* Gestionar compras.
* Administrar stock.
* Administrar empleados.
* Administrar productos.
* Administrar cupones.
* Administrar clientes.
No aplica:
* Gestión de gastos de insumos.
* Administración de pagos de sueldos, comisiones a empleados.
* Administrar cuentas corrientes, ni de usuarios ni de clientes.
### Solución propuesta
En el sistema de información a desarrollar está orientado a un local de ropa donde el usuario deberá loguearse, con esto se tendrá registro de quién está utilizando el sistema, esta información será importante para luego tener en cuenta las comisiones de cada empleado.
El sistema permitirá registrar artículos, registrar la compra de artículos, registrar las ventas. Cuando se realice una venta el sistema tendrá disponibles las diferentes formas de pago para registrar dicha transacción, cabe aclarar que en una misma venta se puede dar la situación de tener que registrar una parte del monto a pagar con una forma de pago y lo restante con otra, automáticamente al registrar la venta se actualiza el stock.
Se podrá buscar qué monto y qué artículo/s se vendieron en un determinado día y hora.
Se podrá buscar un artículo filtrando por fábrica y/o por rubro.
El sistema permitirá generar informes respecto al comportamiento de las ventas en determinados momentos.
### DBMS a utilizar
SQL Management Studio 2008
### Menú
#### Altas/Bajas/Modificaciones/Consultas
* Empleados
* Productos
* Cupones
* Clientes
* Cargas y/o Procesos
* Ventas a clientes.
* Compras a proveedores.
#### Listados/Reportes
* Emitir un informe de los productos en stock.
* Emitir un informe con las ventas de cada usuario.
#### Estadísticas
* Rubro más vendido en un período determinado por el usuario.
* Fábrica más vendida en un período determinado por el usuario.
* Usuario con más ventas en un período determinado por el usuario.
