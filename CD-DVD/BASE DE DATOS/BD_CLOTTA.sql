create table rubros(
id_rubro integer,
nombre varchar(30),
CONSTRAINT pk_rubros PRIMARY KEY (id_rubro)
)


create table fabricas(
id_fabrica integer,
nombre varchar(30),
telefono varchar(30),
CONSTRAINT pk_fabricas PRIMARY KEY (id_fabrica)
)


create table bancos(
id_banco integer,
nombre varchar(30),
telefono integer,
CONSTRAINT pk_bancos PRIMARY KEY (id_banco)
)


create table entidades_crediticias(
id_entidad_crediticia integer,
nombre varchar(30),
telefono integer,
CONSTRAINT pk_entdidad_crediticia PRIMARY KEY (id_entidad_crediticia)
)


create table usuarios(
id_usuario varchar(30),
nombre varchar(30),
apellido varchar(30),
contraseña varchar(10),
fecha_alta date,
CONSTRAINT pk_usuarios PRIMARY KEY (id_usuario)
)


create table formas_pago(
id_forma_pago integer,
nombre varchar(20),
porcentaje float,
CONSTRAINT pk_formas_pago PRIMARY KEY (id_forma_pago)
)


create table tipo_documento(
id_tipo_documento integer,
nombre_tipo_documento varchar(10),
CONSTRAINT pk_tipo_documento PRIMARY KEY (id_tipo_documento)
)


create table clientes(
numero_documento varchar(20),
tipo_documento integer,
nombre_cliente varchar(30),
apellido_cliente varchar(30),
telefono_cliente numeric NULL,
e_mail_cliente varchar(90) NULL,
CONSTRAINT pk_clientes PRIMARY KEY (numero_documento, tipo_documento),
CONSTRAINT fk_tipo_doc FOREIGN KEY (tipo_documento) REFERENCES tipo_documento(id_tipo_documento)
)


create table productos(
id_producto integer,
descripcion varchar(100),
stock integer,
precio_compra float,
precio_venta float,
id_rubro integer,
id_fabrica integer,
dado_de_baja bit,
CONSTRAINT pk_productos PRIMARY KEY (id_producto),
CONSTRAINT fk_rubro FOREIGN KEY (id_rubro) REFERENCES rubros(id_rubro),
CONSTRAINT fk_farbrica FOREIGN KEY (id_fabrica) REFERENCES fabricas(id_fabrica)
)


create table compras(
id_compra integer,
fecha_compra varchar(90),
hora_compra varchar(90),
monto float,
CONSTRAINT pk_compras PRIMARY KEY (id_compra)
)


create table detalles_compras(
id_compra integer,
id_producto integer,
cantidad integer,
precio_unitario float,
CONSTRAINT pk_detalles_compras PRIMARY KEY (id_compra, id_producto),
CONSTRAINT fk_compra FOREIGN KEY (id_compra) REFERENCES compras(id_compra),
CONSTRAINT fk_producto FOREIGN KEY (id_producto) REFERENCES productos(id_producto)
)

create table ventas(
id_venta integer,
fecha_venta date, 
hora_venta varchar(90),
id_usuario varchar(30),
numero_documento_cliente varchar(20),
tipo_documento_cliente integer,
total float,
CONSTRAINT pk_ventas PRIMARY KEY (id_venta),
CONSTRAINT fk_usuario FOREIGN KEY (id_usuario) REFERENCES usuarios(id_usuario),
CONSTRAINT fk_cliente_venta FOREIGN KEY (numero_documento_cliente, tipo_documento_cliente) REFERENCES clientes(numero_documento, tipo_documento)
)




create table detalle_ventas(
id_venta integer,
id_producto integer,
cantidad integer,
precio_unitario float,
CONSTRAINT pk_detalle_ventas PRIMARY KEY (id_venta, id_producto),
CONSTRAINT fk_venta FOREIGN KEY (id_venta) REFERENCES ventas(id_venta),
CONSTRAINT fk_producto_ventas FOREIGN KEY (id_producto) REFERENCES productos(id_producto)
)


create table cupon(
id_cupon integer,
numero_lote integer,
numero_autorizacion_online integer,
precio float,
CONSTRAINT pk_cupon PRIMARY KEY (id_cupon)
)


create table ventasXformas_pago(
id_venta integer,
id_forma_pago integer,
monto_vxfp float,
id_cupon integer,
id_banco integer,
id_entidad_crediticia integer,
CONSTRAINT pk_ventas_forma_pago PRIMARY KEY (id_forma_pago, id_venta, id_entidad_crediticia, id_banco),
CONSTRAINT fk_venta_fp FOREIGN KEY (id_venta) REFERENCES ventas(id_venta),
CONSTRAINT fk_forma_pago_fp FOREIGN KEY (id_forma_pago) REFERENCES formas_pago(id_forma_pago),
CONSTRAINT fk_cupon FOREIGN KEY (id_cupon) REFERENCES cupon(id_cupon),
CONSTRAINT fk_banco FOREIGN KEY (id_banco) REFERENCES bancos(id_banco),
CONSTRAINT fk_entidad FOREIGN KEY (id_entidad_crediticia) REFERENCES entidades_crediticias(id_entidad_crediticia)
)


INSERT INTO cupon(id_cupon,numero_autorizacion_online,numero_lote,precio) VALUES (0,0,0,0) 

INSERT INTO tipo_documento (id_tipo_documento, nombre_tipo_documento ) VALUES (1,'DNI')
INSERT INTO tipo_documento (id_tipo_documento, nombre_tipo_documento ) VALUES (2,'PASAPORTE')
INSERT INTO tipo_documento (id_tipo_documento, nombre_tipo_documento ) VALUES (3,'LE')
INSERT INTO tipo_documento (id_tipo_documento, nombre_tipo_documento ) VALUES (4,'S/D')

INSERT INTO bancos(id_banco, nombre, telefono) VALUES (0,'(Seleccionar banco)',013842)
INSERT INTO bancos(id_banco, nombre, telefono) VALUES (1,'Galicia',013842)
INSERT INTO bancos(id_banco, nombre, telefono) VALUES (2,'Santander Rio',083143)
INSERT INTO bancos(id_banco, nombre, telefono) VALUES (3,'Banco Nación',083202)
INSERT INTO bancos(id_banco, nombre, telefono) VALUES (4,'Macro', 83104)
INSERT INTO bancos(id_banco, nombre, telefono) VALUES (5,'BanCor', 2349932)
INSERT INTO bancos(id_banco, nombre, telefono) VALUES (6,'BBVA Francés',3249)
INSERT INTO bancos(id_banco, nombre, telefono) VALUES (7,'HSBC',349203)
INSERT INTO bancos(id_banco, nombre, telefono) VALUES (8,'ICBC',24390)
INSERT INTO bancos(id_banco, nombre, telefono) VALUES (9,'Credicoop',32990243)
INSERT INTO bancos(id_banco, nombre, telefono) VALUES (10,'Patagonia',23940443)
INSERT INTO bancos(id_banco, nombre, telefono) VALUES (11,'Banco Provincia',083083)
INSERT INTO bancos(id_banco, nombre, telefono) VALUES (12,'Hipotecario',4308424)
INSERT INTO bancos(id_banco, nombre, telefono) VALUES (13,'Supervielle',208434)
INSERT INTO bancos(id_banco, nombre, telefono) VALUES (14,'City Bank', 3284)


INSERT INTO entidades_crediticias(id_entidad_crediticia, nombre, telefono) VALUES (0,'(Seleccionar tarjeta)',32480)
INSERT INTO entidades_crediticias(id_entidad_crediticia, nombre, telefono) VALUES (1,'VISA',32480)
INSERT INTO entidades_crediticias(id_entidad_crediticia, nombre, telefono) VALUES (2,'Master Card',32483)
INSERT INTO entidades_crediticias(id_entidad_crediticia, nombre, telefono) VALUES (3,'Naranja',32040)
INSERT INTO entidades_crediticias(id_entidad_crediticia, nombre, telefono) VALUES (4,'Maestro',2384028)
INSERT INTO entidades_crediticias(id_entidad_crediticia, nombre, telefono) VALUES (5,'Nativa',42397)

INSERT INTO formas_pago(id_forma_pago,nombre,porcentaje) VALUES (1,'EFECTIVO',0.25)
INSERT INTO formas_pago(id_forma_pago,nombre,porcentaje) VALUES (2,'DÉBITO',0.15)
INSERT INTO formas_pago(id_forma_pago,nombre,porcentaje) VALUES (3,'CRÉDITO',0.00)

INSERT INTO rubros(id_rubro,nombre) VALUES(0,'(Seleccionar valor)')
INSERT INTO rubros(id_rubro,nombre) VALUES(1,'Jean')
INSERT INTO rubros(id_rubro,nombre) VALUES(2,'Jean Chupin')
INSERT INTO rubros(id_rubro,nombre) VALUES(3,'Calzas')
INSERT INTO rubros(id_rubro,nombre) VALUES(4,'Sweters')
INSERT INTO rubros(id_rubro,nombre) VALUES(5,'Remeras basicas')
INSERT INTO rubros(id_rubro,nombre) VALUES(6,'Babuchas')
INSERT INTO rubros(id_rubro,nombre) VALUES(7,'Camisas')
INSERT INTO rubros(id_rubro,nombre) VALUES(8,'Zapatillas')
INSERT INTO rubros(id_rubro,nombre) VALUES(9,'Pañuelos')
INSERT INTO rubros(id_rubro,nombre) VALUES(10,'Zapatos')
INSERT INTO rubros(id_rubro,nombre) VALUES(11,'Camperas')
INSERT INTO rubros(id_rubro,nombre) VALUES(12,'Buzos')
INSERT INTO rubros(id_rubro,nombre) VALUES(13,'Saquitos')
INSERT INTO rubros(id_rubro,nombre) VALUES(14,'Accesorios')
INSERT INTO rubros(id_rubro,nombre) VALUES(15,'Polleras')
INSERT INTO rubros(id_rubro,nombre) VALUES(16,'Ropa Interior')
INSERT INTO rubros(id_rubro,nombre) VALUES(17,'Carteras')
INSERT INTO rubros(id_rubro,nombre) VALUES(18,'Mochila')
INSERT INTO rubros(id_rubro,nombre) VALUES(19,'Tapados')
INSERT INTO rubros(id_rubro,nombre) VALUES(20,'Vestidos')
INSERT INTO rubros(id_rubro,nombre) VALUES(21,'Chalecos')

INSERT INTO fabricas(id_fabrica,nombre,telefono) VALUES (0,'(Seleccionar valor)',01146827047)
INSERT INTO fabricas(id_fabrica,nombre,telefono) VALUES (1,'47 Street',03487434551)
INSERT INTO fabricas(id_fabrica,nombre,telefono) VALUES (2,'Sara',01145236582)
INSERT INTO fabricas(id_fabrica,nombre,telefono) VALUES (3,'Shira',011452875315)
INSERT INTO fabricas(id_fabrica,nombre,telefono) VALUES (4,'A.Y Not Dead.',01145238974)
INSERT INTO fabricas(id_fabrica,nombre,telefono) VALUES (5,'Akiabara',01145236316)
INSERT INTO fabricas(id_fabrica,nombre,telefono) VALUES (6,'Agarrate Catalina',03854213190)
INSERT INTO fabricas(id_fabrica,nombre,telefono) VALUES (7,'Awada',01148318877)
INSERT INTO fabricas(id_fabrica,nombre,telefono) VALUES (8,'Chocolate',01143738801)
INSERT INTO fabricas(id_fabrica,nombre,telefono) VALUES (9,'Complot',02204853490)
INSERT INTO fabricas(id_fabrica,nombre,telefono) VALUES (10,'De la Ostia',03624464981)

INSERT INTO productos(id_producto,descripcion,stock,precio_compra,precio_lista,id_rubro,id_fabrica,dado_de_baja) VALUES (0,'Campera verde', 1,250, 750,10,1,0)
INSERT INTO productos(id_producto,descripcion,stock,precio_compra,precio_lista,id_rubro,id_fabrica,dado_de_baja) VALUES (1,'Jean nevado celeste', 1,240, 645, 2,2,0)
INSERT INTO productos(id_producto,descripcion,stock,precio_compra,precio_lista,id_rubro,id_fabrica,dado_de_baja) VALUES (2,'Camisa Hindú', 1, 200,320, 2,3,0)
INSERT INTO productos(id_producto,descripcion,stock,precio_compra,precio_lista,id_rubro,id_fabrica,dado_de_baja) VALUES (3,'Sweater Hilo Estampado', 1,300, 480,3,9,0)
INSERT INTO productos(id_producto,descripcion,stock,precio_compra,precio_lista,id_rubro,id_fabrica,dado_de_baja) VALUES (4,'Buzo con Mickey', 1,230,650,12,5,0)
INSERT INTO productos(id_producto,descripcion,stock,precio_compra,precio_lista,id_rubro,id_fabrica,dado_de_baja) VALUES (5,'Musculosa lisa blanca', 0,300, 350,3,10,0)
INSERT INTO productos(id_producto,descripcion,stock,precio_compra,precio_lista,id_rubro,id_fabrica,dado_de_baja) VALUES (6,'Musculosa lisa negra', 0,220, 275,	3,4,0)
INSERT INTO productos(id_producto,descripcion,stock,precio_compra,precio_lista,id_rubro,id_fabrica,dado_de_baja) VALUES (7,'Campera vaquera celeste', 1,300, 545,3,5,0)
INSERT INTO productos(id_producto,descripcion,stock,precio_compra,precio_lista,id_rubro,id_fabrica,dado_de_baja) VALUES (8,'Buzo gris mangas 3/4',	1, 500,635,	12,7,0)
INSERT INTO productos(id_producto,descripcion,stock,precio_compra,precio_lista,id_rubro,id_fabrica,dado_de_baja) VALUES (9,'Sweater grueso azul marino',1,10,12,3,8,0)
INSERT INTO productos(id_producto,descripcion,stock,precio_compra,precio_lista,id_rubro,id_fabrica,dado_de_baja) VALUES (10,'Chalina verde con detalles dorados',2,100,150,9,10,0)
INSERT INTO productos(id_producto,descripcion,stock,precio_compra,precio_lista,id_rubro,id_fabrica,dado_de_baja) VALUES (11,'Remera mangas largas c/inscripción', 0,100, 340,3,3,0)
INSERT INTO productos(id_producto,descripcion,stock,precio_compra,precio_lista,id_rubro,id_fabrica,dado_de_baja) VALUES (12,'Chupin negro',2,300,650,3,4,0)
INSERT INTO productos(id_producto,descripcion,stock,precio_compra,precio_lista,id_rubro,id_fabrica,dado_de_baja) VALUES (13,'Gorro verde militar', 2,60,150,14,7,0)
INSERT INTO productos(id_producto,descripcion,stock,precio_compra,precio_lista,id_rubro,id_fabrica,dado_de_baja) VALUES (14,'Mochila portanotebook cuero bordó',1,300,870,3,6,0)
INSERT INTO productos(id_producto,descripcion,stock,precio_compra,precio_lista,id_rubro,id_fabrica,dado_de_baja) VALUES (15,'Cartera color beige', 1,400,450,3,2,0)
INSERT INTO productos(id_producto,descripcion,stock,precio_compra,precio_lista,id_rubro,id_fabrica,dado_de_baja) VALUES (16,'Saquito de lana gris', 1,300,575,19,1,0)
INSERT INTO productos(id_producto,descripcion,stock,precio_compra,precio_lista,id_rubro,id_fabrica,dado_de_baja) VALUES (17,'Vestido verde estampado', 1,400,700,20,9,0)
INSERT INTO productos(id_producto,descripcion,stock,precio_compra,precio_lista,id_rubro,id_fabrica,dado_de_baja) VALUES (18,'Soquetes rallados rosa', 10,10, 50,3,8,0)
INSERT INTO productos(id_producto,descripcion,stock,precio_compra,precio_lista,id_rubro,id_fabrica,dado_de_baja) VALUES (19,'Campera de cuero negro', 2,300, 950,3,5,0)
INSERT INTO productos(id_producto,descripcion,stock,precio_compra,precio_lista,id_rubro,id_fabrica,dado_de_baja) VALUES (20,'Pulseras de plata',3,10, 120,14,8,0)
INSERT INTO productos(id_producto,descripcion,stock,precio_compra,precio_lista,id_rubro,id_fabrica,dado_de_baja) VALUES (21,'Aros c/ detalle violeta', 3,10, 70,14,2,0)
INSERT INTO productos(id_producto,descripcion,stock,precio_compra,precio_lista,id_rubro,id_fabrica,dado_de_baja) VALUES (22,'Buzo blanco c/inscripción',1,100, 480,12,3,0)
INSERT INTO productos(id_producto,descripcion,stock,precio_compra,precio_lista,id_rubro,id_fabrica,dado_de_baja) VALUES (23,'Cartera de mano estampada',1,130, 350,3,6,0)
INSERT INTO productos(id_producto,descripcion,stock,precio_compra,precio_lista,id_rubro,id_fabrica,dado_de_baja) VALUES (24,'Remera violeta',0,200, 275,3,10,0)

INSERT INTO usuarios(id_usuario,nombre,apellido,contraseña,fecha_alta) VALUES ('(Seleccionar valor)','','','','2017-05-21')
INSERT INTO usuarios(id_usuario,nombre,apellido,contraseña,fecha_alta) VALUES('62719','Juan Ignacio','Van Heerden','37665760',(convert(datetime,'21-05-17 10:34:09 PM',5)))
INSERT INTO usuarios(id_usuario,nombre,apellido,contraseña,fecha_alta) VALUES('62809','Agustina','Nuñez Moreno','38036094',(convert(datetime,'21-05-17 10:34:09 PM',5)))
INSERT INTO usuarios(id_usuario,nombre,apellido,contraseña,fecha_alta) VALUES('68582','Brian','Calcaterra','37665760',(convert(datetime,'21-05-17 10:34:09 PM',5)))
INSERT INTO usuarios(id_usuario,nombre,apellido,contraseña,fecha_alta) VALUES('63867','Georgina','Gonzalez','37720825',(convert(datetime,'21-05-17 10:34:09 PM',5)))

INSERT INTO clientes(numero_documento,tipo_documento,nombre_cliente,apellido_cliente,telefono_cliente,e_mail_cliente) VALUES('25489351',1,'Macarena','Pérez',4216585,'ojasnd@gmail.com')
INSERT INTO clientes(numero_documento,tipo_documento,nombre_cliente,apellido_cliente,telefono_cliente,e_mail_cliente) VALUES('30489563',1,'Gimena','Icardi',4873215,'aodsjnsadno@gmail.com')
INSERT INTO clientes(numero_documento,tipo_documento,nombre_cliente,apellido_cliente,telefono_cliente,e_mail_cliente) VALUES('ABB875542',3,'Carlos','Menem',4896321,'carlitos.bomba@hotmail.com')
INSERT INTO clientes(numero_documento,tipo_documento,nombre_cliente,apellido_cliente,telefono_cliente,e_mail_cliente) VALUES('AAB235767',3,'Antonella Victoria','Cardozo',4568943,'antoc@gmail.com')
INSERT INTO clientes(numero_documento,tipo_documento,nombre_cliente,apellido_cliente,telefono_cliente,e_mail_cliente) VALUES('20489536',1,'María Silvia','Amores',4876892,'marisil@gmail.com')
INSERT INTO clientes(numero_documento,tipo_documento,nombre_cliente,apellido_cliente,telefono_cliente,e_mail_cliente) VALUES('18654983',1,'Josefina','Martínez',4675128,'josefinam@gmail.com')
INSERT INTO clientes(numero_documento,tipo_documento,nombre_cliente,apellido_cliente,telefono_cliente,e_mail_cliente) VALUES('35489375',1,'Sol','Pérez',4684934,'solperez@gmail.com')
INSERT INTO clientes(numero_documento,tipo_documento,nombre_cliente,apellido_cliente,telefono_cliente,e_mail_cliente) VALUES('34845632',1,'Solange','Rivas',4518735,'solrivas@gmail.com')


CREATE PROCEDURE AUTOGENERARCODIGO (@CODIGO CHAR(10) OUTPUT)
AS
IF (SELECT COUNT(*) FROM fabricas)= 0
SET @CODIGO = '0'
ELSE
SET
@CODIGO = (SELECT MAX(id_fabrica) FROM fabricas) + 1


CREATE PROCEDURE AUTOGENERARCODIGO_compras (@CODIGO CHAR(10) OUTPUT)
AS
IF (SELECT COUNT(*) FROM compras)= 0
SET @CODIGO = '0'
ELSE
SET
@CODIGO = (SELECT MAX(id_compra) FROM compras) + 1


CREATE PROCEDURE AUTOGENERARCODIGO_ventas (@CODIGO CHAR(10) OUTPUT)
AS
IF (SELECT COUNT(*) FROM ventas)= 0
SET @CODIGO = '0'
ELSE
SET
@CODIGO = (SELECT MAX(id_venta) FROM ventas) + 1


CREATE PROCEDURE AUTOGENERARCODIGO_productos (@CODIGO CHAR(10) OUTPUT)
AS
IF (SELECT COUNT(*) FROM productos)= 0
SET @CODIGO = '0'
ELSE
SET
@CODIGO = (SELECT MAX(id_producto) FROM productos) + 1