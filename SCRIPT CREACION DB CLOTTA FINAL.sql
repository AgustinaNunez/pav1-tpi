create table rubros(
id_rubro integer,
nombre varchar(30),
CONSTRAINT pk_rubros PRIMARY KEY (id_rubro)
)


create table fabricas(
id_fabrica integer,
nombre varchar(30),
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
telefono_cliente numeric,
e_mail_cliente varchar(90),
CONSTRAINT pk_clientes PRIMARY KEY (numero_documento, tipo_documento),
CONSTRAINT fk_tipo_doc FOREIGN KEY (tipo_documento) REFERENCES tipo_documento(id_tipo_documento)
)


create table productos(
id_producto integer,
descripcion varchar(100),
stock integer,
precio_lista float,
id_rubro integer,
id_fabrica integer,
CONSTRAINT pk_productos PRIMARY KEY (id_producto),
CONSTRAINT fk_rubro FOREIGN KEY (id_rubro) REFERENCES rubros(id_rubro),
CONSTRAINT fk_farbrica FOREIGN KEY (id_fabrica) REFERENCES fabricas(id_fabrica)
)


create table compras(
id_compra integer,
fecha_compra date,
hora_compra date,
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
hora_venta date,
id_usuario varchar(30),
numero_documento_cliente varchar(20),
tipo_documento_cliente integer,
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


create table tarjetas(
id_tarjeta integer,
apellido_nombre_tarjeta varchar(80),
fecha_vencimiento varchar(30),
id_banco integer,
id_entidad_crediticia integer,
CONSTRAINT pk_tarjetas PRIMARY KEY (id_tarjeta),
CONSTRAINT fk_banco FOREIGN KEY (id_banco) REFERENCES bancos(id_banco),
CONSTRAINT fk_entidad FOREIGN KEY (id_entidad_crediticia) REFERENCES entidades_crediticias(id_entidad_crediticia)
)


create table ventasXformas_pago(
numero_orden integer,
id_venta integer,
id_forma_pago integer,
monto_vxfp float,
numero_lote integer,
numero_autorizacion_online integer,
numero_cupon integer,
id_tarjeta integer,
CONSTRAINT pk_ventas_forma_pago PRIMARY KEY (numero_orden, id_forma_pago, id_venta),
CONSTRAINT fk_venta_fp FOREIGN KEY (id_venta) REFERENCES ventas(id_venta),
CONSTRAINT fk_forma_pago_fp FOREIGN KEY (id_forma_pago) REFERENCES formas_pago(id_forma_pago),
CONSTRAINT fk_tarjeta_fp FOREIGN KEY (id_tarjeta) REFERENCES tarjetas(id_tarjeta)
)


INSERT INTO tipo_documento (id_tipo_documento, nombre_tipo_documento ) VALUES (1,'DNI')
INSERT INTO tipo_documento (id_tipo_documento, nombre_tipo_documento ) VALUES (2,'PASAPORTE')
INSERT INTO tipo_documento (id_tipo_documento, nombre_tipo_documento ) VALUES (3,'LE')
INSERT INTO tipo_documento (id_tipo_documento, nombre_tipo_documento ) VALUES (4,'S/D')

INSERT INTO clientes (numero_documento, tipo_documento, nombre_cliente , apellido_cliente , telefono_cliente , e_mail_cliente  ) 
VALUES (11,2,'JA','JA',203040,'jajaja.com')

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

INSERT INTO entidades_crediticias(id_entidad_crediticia, nombre, telefono) VALUES (1,'VISA',32480)
INSERT INTO entidades_crediticias(id_entidad_crediticia, nombre, telefono) VALUES (2,'Master Card',32483)
INSERT INTO entidades_crediticias(id_entidad_crediticia, nombre, telefono) VALUES (3,'American Express',32040)
INSERT INTO entidades_crediticias(id_entidad_crediticia, nombre, telefono) VALUES (4,'Maestro',2384028)
INSERT INTO entidades_crediticias(id_entidad_crediticia, nombre, telefono) VALUES (5,'Cabal',42397)
