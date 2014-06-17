USE GD1C2014
GO

--Creacion del esquema LOL-----------------------------------------------------

CREATE SCHEMA LOL AUTHORIZATION gd
GO

--Creacion tipos de datos de usuario-------------------------------------------

CREATE TYPE [LOL].dataTable AS TABLE 
(
    Codigo numeric(18,0), 
    Cliente_ID numeric (18,0),
    Empresa_ID numeric (18,0),
    Descripcion nvarchar (255),
    Fecha datetime,
    Stock numeric (18,0),
    Fecha_Vencimiento datetime,
    Precio money,
    Tipo nvarchar (255),
    Visibilidad_Codigo numeric (18,0),
    Estado nvarchar (255),
    Permite_Preguntas bit,
	PrecioVisibilidad money
)

--Creacion de Tablas-----------------------------------------------------------

--Tabla Clientes
CREATE TABLE LOL.tl_Clientes (
	ID             NUMERIC(18, 0) NOT NULL,
	Tipo_Documento NVARCHAR(10) NOT NULL,
	Nro_Documento  NUMERIC(18, 0) NOT NULL,
	Apellido       NVARCHAR(255) NOT NULL,
	Nombre         NVARCHAR(255) NOT NULL,
	CUIL           NVARCHAR(50) NOT NULL,
	Fecha_Nac      DATETIME NULL,
	Mail           NVARCHAR(255) NULL,
	Dom_Calle      NVARCHAR(255) NULL,
	Nro_Calle      NUMERIC(18, 0) NULL,
	Piso           NUMERIC(18, 0) NULL,
	Depto          NVARCHAR(50) NULL,
	Cod_Postal     NVARCHAR(50) NULL,
	Telefono       NUMERIC(18, 0) NULL,
	Suma_Calificaciones NUMERIC(18, 0) NULL,
	Cantidad_Calificaciones NUMERIC(18, 0) NULL,

	PRIMARY KEY (ID)
)
GO

--Tabla Empresas
CREATE TABLE LOL.tl_Empresas (
	ID             NUMERIC(18, 0) NOT NULL,
	Razon_Social   NVARCHAR(255) NOT NULL,
	CUIT           NVARCHAR(50) NOT NULL,
	Fecha_Creacion DATETIME NOT NULL,
	Mail           NVARCHAR(50) NULL,
	Dom_Calle      NVARCHAR(100) NULL,
	Nro_Calle      NUMERIC(18, 0) NULL,
	Piso           NUMERIC(18, 0) NULL,
	Depto          NVARCHAR(50) NULL,
	Cod_Postal     NVARCHAR(50) NULL,
	Suma_Calificaciones NUMERIC(18, 0) NULL,
	Cantidad_Calificaciones NUMERIC(18, 0) NULL,

	PRIMARY KEY(ID)
)
GO

--Tabla Funcionalidades
CREATE TABLE LOL.tl_Funcionalidades (
	ID     NUMERIC(18, 0) IDENTITY(1,1) NOT NULL,
	Nombre NVARCHAR(50) NOT NULL,

	PRIMARY KEY(ID)
)
GO

--Tabla Visibilidades
CREATE TABLE LOL.tl_Visibilidades (
	Codigo      NUMERIC(18, 0) NOT NULL,
	Descripcion NVARCHAR(255) NOT NULL,
	Precio      MONEY NOT NULL,
	Porcentaje  NUMERIC(18, 2) NOT NULL,
	Duracion    INT NOT NULL,

	PRIMARY KEY(Codigo)
)
GO

--Tabla Roles
CREATE TABLE LOL.tl_Roles (
	ID         NUMERIC(18, 0) IDENTITY(1,1) NOT NULL,
	Nombre     NVARCHAR(50) NOT NULL,
	Habilitado BIT DEFAULT(1) NOT NULL ,

	PRIMARY KEY(ID)
)
GO

--Tabla Rubros
CREATE TABLE LOL.tl_Rubros (
	ID          NUMERIC(18, 0) IDENTITY(1,1) NOT NULL,
	Descripcion NVARCHAR(50) NOT NULL,
	Habilitado  BIT DEFAULT(1) NOT NULL,

	PRIMARY KEY(ID)
)
GO

--Tabla Publicaciones
CREATE TABLE LOL.tl_Publicaciones (
	Codigo             NUMERIC(18, 0) IDENTITY(1,1) NOT NULL,
	Cliente_ID         NUMERIC(18, 0) NULL,
	Empresa_ID         NUMERIC(18, 0) NULL,
	Descripcion        NVARCHAR(255) NOT NULL,
	Fecha              DATETIME NOT NULL,
	Stock              NUMERIC(18, 0) NOT NULL,
	Fecha_Vencimiento  DATETIME NOT NULL,
	Precio             MONEY NOT NULL,
	Tipo               NVARCHAR(255) NOT NULL,
	Visibilidad_Codigo NUMERIC(18, 0) NOT NULL,
	Estado             NVARCHAR(255) NOT NULL,
	Permite_Preguntas  BIT DEFAULT(1) NOT NULL,

	PRIMARY KEY(Codigo)
)
GO

--Tabla Preguntas
CREATE TABLE LOL.tl_Preguntas (
	ID                 NUMERIC(18, 0) IDENTITY(1,1) NOT NULL,
	Publicacion_Codigo NUMERIC(18, 0) NOT NULL,
	Cliente_ID         NUMERIC(18, 0) NOT NULL,
	Pregunta           NVARCHAR(255) NOT NULL,
	Fecha_Respuesta    DATE NULL,
	Respuesta          NVARCHAR(255) NULL,

	PRIMARY KEY(ID)
)
GO

--Tabla Publicaciones_Rubros
CREATE TABLE LOL.tl_Publicaciones_Rubros (
	Publicacion_Codigo NUMERIC(18, 0) NOT NULL,
	Rubro_ID           NUMERIC(18, 0) NOT NULL,

	PRIMARY KEY(Publicacion_Codigo, Rubro_ID)
)
GO

--Tabla Roles_Funcionalidades
CREATE TABLE LOL.tl_Roles_Funcionalidades (
	Rol_ID           NUMERIC(18, 0) NOT NULL,
	Funcionalidad_ID NUMERIC(18, 0) NOT NULL,

	PRIMARY KEY(Rol_ID, Funcionalidad_ID)
)
GO

--Tabla Usuarios
CREATE TABLE LOL.tl_Usuarios (
	ID              NUMERIC(18, 0) IDENTITY(1,1) NOT NULL,
	Username        NVARCHAR(50) NOT NULL,
	Password        NVARCHAR(255) NOT NULL,
	Logins_Fallidos TINYINT DEFAULT(0) NOT NULL,
	Habilitado      BIT DEFAULT(1) NOT NULL,
	Activo          BIT DEFAULT(1) NOT NULL,
	Change_Password BIT DEFAULT(0) NOT NULL,

	PRIMARY KEY(ID)
)
GO


--Tabla Usuarios_Roles
CREATE TABLE LOL.tl_Usuarios_Roles (
	Usuario_ID NUMERIC(18, 0) NOT NULL,
	Rol_ID     NUMERIC(18, 0) NOT NULL,
	Habilitado BIT DEFAULT(1) NOT NULL,

	PRIMARY KEY(Usuario_ID, Rol_ID)
)
GO

--Tabla Facturas
CREATE TABLE LOL.tl_Facturas (
	Nro              NUMERIC(18, 0) IDENTITY(1,1) NOT NULL,
	Fecha            DATETIME NOT NULL,
	Publicacion_Cod  NUMERIC(18, 0) NOT NULL,
	Pago_Descripcion NVARCHAR(255) NULL,
	Total            MONEY DEFAULT(0.00) NOT NULL,

	PRIMARY KEY(Nro)
)
GO

--Tabla Compras
CREATE TABLE LOL.tl_Compras (
	ID                          NUMERIC(18, 0) IDENTITY(1,1) NOT NULL,
	Publicacion_Codigo          NUMERIC(18, 0) NOT NULL,
	Cliente_ID                  NUMERIC(18, 0) NOT NULL,
	Cantidad                    NUMERIC(18, 0) NOT NULL,
	Fecha                       DATETIME NOT NULL,
	Calificacion_Codigo         NUMERIC(18, 0) DEFAULT(NULL) NULL,
	Calificacion_Cant_Estrellas NUMERIC(18, 0) DEFAULT(NULL) NULL,
	Calificacion_Descripcion    NVARCHAR(255) DEFAULT(NULL) NULL,
	Comision_Pagada             BIT DEFAULT(0) NOT NULL,

	PRIMARY KEY(ID)
)
GO

--Tabla Ofertas
CREATE TABLE LOL.tl_Ofertas (
	ID                 NUMERIC(18, 0) IDENTITY(1,1) NOT NULL,
	Publicacion_Codigo NUMERIC(18, 0) NOT NULL,
	Cliente_ID         NUMERIC(18, 0) NOT NULL,
	Fecha              DATE NOT NULL,
	Monto              MONEY NOT NULL,

	PRIMARY KEY(ID)
)
GO

--Tabla Facturas_Items
CREATE TABLE LOL.tl_Facturas_Items (
	ID          NUMERIC(18, 0) IDENTITY(1,1) NOT NULL,
	Factura_Nro NUMERIC(18, 0) NOT NULL,
	Cantidad    NUMERIC(18, 0) NOT NULL,
	Monto       MONEY NOT NULL,
	Compra_ID   NUMERIC(18, 0) NULL

	PRIMARY KEY(ID)
)
GO

--Tabla Pendientes
CREATE TABLE LOL.tl_Pendientes(
	ID                 NUMERIC(18, 0) IDENTITY(1,1) NOT NULL,
	Fecha              DATE NOT NULL,
	Monto              MONEY NOT NULL,
	Publicacion_Codigo NUMERIC(18, 0) NOT NULL,
	Compra_ID          NUMERIC(18, 0) NULL,

	PRIMARY KEY(ID)
)
GO

--Creacion de Foreign Keys-----------------------------------------------------

--Publicaciones.Cliente_ID -> Clientes.ID
ALTER TABLE LOL.tl_Publicaciones WITH CHECK ADD
	CONSTRAINT fk_Publicaciones_Cliente
	FOREIGN KEY (Cliente_ID)
	REFERENCES LOL.tl_Clientes (ID)

--Publicaciones.Empresa_ID -> Empresas.ID
ALTER TABLE LOL.tl_Publicaciones WITH CHECK ADD
	CONSTRAINT fk_Publicaciones_Empresa
	FOREIGN KEY (Empresa_ID)
	REFERENCES LOL.tl_Empresas (ID)

--Publicaciones.Visibilidad_Codigo -> Visibilidades.Codigo
ALTER TABLE LOL.tl_Publicaciones WITH CHECK ADD
	CONSTRAINT fk_Publicaciones_Visibilidad
	FOREIGN KEY (Visibilidad_Codigo)
	REFERENCES LOL.tl_Visibilidades (Codigo)

--Preguntas.Publicacion_Codigo -> Publicaciones.Codigo
ALTER TABLE LOL.tl_Preguntas WITH CHECK ADD
	CONSTRAINT fk_Preguntas_Publicacion
	FOREIGN KEY (Publicacion_Codigo)
	REFERENCES LOL.tl_Publicaciones (Codigo)

--Publicaciones_Rubros.Codigo -> Publicaciones.Codigo
ALTER TABLE LOL.tl_Publicaciones_Rubros WITH CHECK ADD
	CONSTRAINT fk_Publicaciones_Rubros_Publicacion
	FOREIGN KEY (Publicacion_Codigo)
	REFERENCES LOL.tl_Publicaciones (Codigo)

--Publicaciones_Rubros.Rubro_ID -> Rubros.ID
ALTER TABLE LOL.tl_Publicaciones_Rubros WITH CHECK ADD
	CONSTRAINT fk_Publicaciones_Rubros_Rubro
	FOREIGN KEY (Rubro_ID)
	REFERENCES LOL.tl_Rubros (ID)

--Roles_Funcionalidades.Rol_ID -> Roles.ID
ALTER TABLE LOL.tl_Roles_Funcionalidades WITH CHECK ADD
	CONSTRAINT fk_Roles_Funcionalidades_Rol
	FOREIGN KEY (Rol_ID)
	REFERENCES LOL.tl_Roles (ID)

--Roles_Funcionalidades.Funcionalidad_ID -> Funcionalidad.ID
ALTER TABLE LOL.tl_Roles_Funcionalidades WITH CHECK ADD
	CONSTRAINT fk_Roles_Funcionalidades_Funcionalidad
	FOREIGN KEY (Funcionalidad_ID)
	REFERENCES LOL.tl_Funcionalidades (ID)

--Usuarios_Roles.Usuario_ID -> Usuario.ID
ALTER TABLE LOL.tl_Usuarios_Roles WITH CHECK ADD
	CONSTRAINT fk_Usuarios_Roles_Usuario
	FOREIGN KEY (Usuario_ID)
	REFERENCES LOL.tl_Usuarios (ID)

--Usuarios_Roles.Rol_ID -> Rol.ID
ALTER TABLE LOL.tl_Usuarios_Roles WITH CHECK ADD
	CONSTRAINT fk_Usuarios_Roles_Rol
	FOREIGN KEY (Rol_ID)
	REFERENCES LOL.tl_Roles (ID)

--Facturas.Publicacion_Cod -> Publicaciones.Codigo
ALTER TABLE LOL.tl_Facturas WITH CHECK ADD
	CONSTRAINT fk_Facturas_Publicacion
	FOREIGN KEY (Publicacion_Cod)
	REFERENCES LOL.tl_Publicaciones (Codigo)

--Compras.Cliente_ID -> Clientes.ID
ALTER TABLE LOL.tl_Compras WITH CHECK ADD
	CONSTRAINT fk_Compras_Cliente
	FOREIGN KEY (Cliente_ID)
	REFERENCES LOL.tl_Clientes (ID)

--Compras.Publicacion_Codigo -> Publicaciones.Codigo
ALTER TABLE LOL.tl_Compras WITH CHECK ADD
	CONSTRAINT fk_Compras_Publicacion
	FOREIGN KEY (Publicacion_Codigo)
	REFERENCES LOL.tl_Publicaciones (Codigo)

--Ofertas.Cliente_ID -> Clientes.ID
ALTER TABLE LOL.tl_Ofertas WITH CHECK ADD
	CONSTRAINT fk_Ofertas_Cliente
	FOREIGN KEY (Cliente_ID)
	REFERENCES LOL.tl_Clientes (ID)

--Ofertas.Publicacion_Codigo -> Publicaciones.Codigo
ALTER TABLE LOL.tl_Ofertas WITH CHECK ADD
	CONSTRAINT fk_Ofertas_Publicacion
	FOREIGN KEY (Publicacion_Codigo)
	REFERENCES LOL.tl_Publicaciones (Codigo)

--Facturas_Items.Compra_ID -> Compra.ID
ALTER TABLE LOL.tl_Facturas_Items WITH CHECK ADD
	CONSTRAINT fk_Facturas_Items_Compra
	FOREIGN KEY (Compra_ID)
	REFERENCES LOL.tl_Compras (ID)

--Facturas_Items.Factura_Nro -> Factura.Nro
ALTER TABLE LOL.tl_Facturas_Items WITH CHECK ADD
	CONSTRAINT fk_Facturas_Items_Factura
	FOREIGN KEY (Factura_Nro)
	REFERENCES LOL.tl_Facturas (Nro)

--Pendientes.Publicacion_Codigo -> Publicaciones.Codigo
ALTER TABLE LOL.tl_Pendientes WITH CHECK ADD
	CONSTRAINT fk_Pendientes_Publicacion
	FOREIGN KEY (Publicacion_Codigo)
	REFERENCES LOL.tl_Publicaciones (Codigo)

--Pendientes.Compra_ID -> Compra.ID
ALTER TABLE LOL.tl_Pendientes WITH CHECK ADD
	CONSTRAINT fk_Pendientes_Compra
	FOREIGN KEY (Compra_ID)
	REFERENCES LOL.tl_Compras (ID)

GO



--Creacion de Stored Procedures------------------------------------------------

--Stored Procedure InicializarFuncionalidades
CREATE PROCEDURE LOL.sp_InicializarFuncionalidades
AS
BEGIN

	SET IDENTITY_INSERT LOL.tl_Funcionalidades ON;

	INSERT INTO LOL.tl_Funcionalidades (ID,Nombre)
		VALUES (1,'ABM de Rol')
	INSERT INTO LOL.tl_Funcionalidades (ID,Nombre)
		VALUES (2,'ABM de Cliente')
	INSERT INTO LOL.tl_Funcionalidades (ID,Nombre)
		VALUES (3,'ABM de Empresa')
	INSERT INTO LOL.tl_Funcionalidades (ID,Nombre)
		VALUES (4,'ABM de Rubro')
	INSERT INTO LOL.tl_Funcionalidades (ID,Nombre)
		VALUES (5,'ABM Visibilidad de Publicacion')
	INSERT INTO LOL.tl_Funcionalidades (ID,Nombre)
		VALUES (6,'Generar Publicacion')
	INSERT INTO LOL.tl_Funcionalidades (ID,Nombre)
		VALUES (7,'Editar Publicacion')
	INSERT INTO LOL.tl_Funcionalidades (ID,Nombre)
		VALUES (8,'Gestion de Preguntas')
	INSERT INTO LOL.tl_Funcionalidades (ID,Nombre)
		VALUES (9,'Comprar/Ofertar')
	INSERT INTO LOL.tl_Funcionalidades (ID,Nombre)
		VALUES (10,'Historial del Cliente')
	INSERT INTO LOL.tl_Funcionalidades (ID,Nombre)
		VALUES (11,'Calificar al Vendedor')
	INSERT INTO LOL.tl_Funcionalidades (ID,Nombre)
		VALUES (12,'Facturar Publicaciones')
	INSERT INTO LOL.tl_Funcionalidades (ID,Nombre)
		VALUES (13,'Listado Estadistico')

END
GO

--Stored Procedure InicializarRoles
CREATE PROCEDURE LOL.sp_InicializarRoles
AS
BEGIN

	SET IDENTITY_INSERT LOL.tl_Roles ON

	DECLARE @Administrativo_ID INT = 1
	DECLARE @Cliente_ID INT = 2
	DECLARE @Empresa_ID INT = 3

	-- Crear el Rol: Administrativo
	INSERT INTO LOL.tl_Roles (ID,Nombre)
		VALUES (@Administrativo_ID,'Administrativo')
	INSERT INTO LOL.tl_Roles (ID,Nombre)
		VALUES (@Cliente_ID,'Cliente')
	INSERT INTO LOL.tl_Roles (ID,Nombre)
		VALUES (@Empresa_ID,'Empresa')

	-- Asignarle TODAS las Funcionalidades al Rol Administrativo
	INSERT INTO LOL.tl_Roles_Funcionalidades
		SELECT @Administrativo_ID,F.ID FROM tl_Funcionalidades F

	-- Asignarle Funcionalidades al Rol Cliente
	INSERT INTO LOL.tl_Roles_Funcionalidades VALUES (@Cliente_ID,6)
	INSERT INTO LOL.tl_Roles_Funcionalidades VALUES (@Cliente_ID,7)
	INSERT INTO LOL.tl_Roles_Funcionalidades VALUES (@Cliente_ID,8)
	INSERT INTO LOL.tl_Roles_Funcionalidades VALUES (@Cliente_ID,9)
	INSERT INTO LOL.tl_Roles_Funcionalidades VALUES (@Cliente_ID,10)
	INSERT INTO LOL.tl_Roles_Funcionalidades VALUES (@Cliente_ID,11)
	INSERT INTO LOL.tl_Roles_Funcionalidades VALUES (@Cliente_ID,12)
	INSERT INTO LOL.tl_Roles_Funcionalidades VALUES (@Cliente_ID,13)

	-- Asignarle Funcionalidades al Rol Empresa
	INSERT INTO LOL.tl_Roles_Funcionalidades VALUES (@Empresa_ID,6)
	INSERT INTO LOL.tl_Roles_Funcionalidades VALUES (@Empresa_ID,7)
	INSERT INTO LOL.tl_Roles_Funcionalidades VALUES (@Empresa_ID,8)
	INSERT INTO LOL.tl_Roles_Funcionalidades VALUES (@Empresa_ID,10)
	INSERT INTO LOL.tl_Roles_Funcionalidades VALUES (@Empresa_ID,12)
	INSERT INTO LOL.tl_Roles_Funcionalidades VALUES (@Empresa_ID,13)

END
GO

--Stored Procedure InicializarUsuarioAdmin
CREATE PROCEDURE LOL.sp_InicializarUsuarioAdmin
AS
BEGIN

	SET IDENTITY_INSERT LOL.tl_Usuarios ON;

	DECLARE @Usuario_ID INT = 1
	DECLARE @Administrativo_ID INT = 1

	-- Crear el Usuario: admin
	INSERT INTO LOL.tl_Usuarios (ID,Username,Password)
		VALUES (@Usuario_ID,'admin','e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7')

	-- Asocio el Usuario admin con el Rol Administrativo
	INSERT INTO LOL.tl_Usuarios_Roles (Usuario_ID,Rol_ID)
		VALUES (@Usuario_ID,@Administrativo_ID)

END
GO

--Stored Procedure ImportarVisibilidades
CREATE PROCEDURE LOL.sp_ImportarVisibilidades
AS
BEGIN

	SET NOCOUNT ON;

	DECLARE @max INT

	INSERT INTO LOL.tl_Visibilidades
		(Codigo,Descripcion,Precio,Porcentaje,Duracion)
		SELECT DISTINCT
			Publicacion_Visibilidad_Cod,
			Publicacion_Visibilidad_Desc,
			Publicacion_Visibilidad_Precio,
			Publicacion_Visibilidad_Porcentaje,
			DATEDIFF(d,Publicacion_Fecha,Publicacion_Fecha_Venc)
		FROM
			gd_esquema.Maestra
		WHERE
			Publicacion_Visibilidad_Cod IS NOT NULL

END
GO

--Stored Procedure ImportarRubros
CREATE PROCEDURE LOL.sp_ImportarRubros
AS
BEGIN

	SET NOCOUNT ON;

	INSERT INTO LOL.tl_Rubros
		SELECT DISTINCT
			Publicacion_Rubro_Descripcion,
			1
		FROM
			gd_esquema.Maestra
		WHERE
			Maestra.Publicacion_Rubro_Descripcion IS NOT NULL

END
GO

--Stored Procedure ImportarEmpresas
CREATE PROCEDURE LOL.sp_ImportarEmpresas
AS
BEGIN

	SET NOCOUNT ON;
	DECLARE @RolEmpresa_ID INT = 3

	INSERT INTO LOL.tl_Usuarios
		SELECT DISTINCT
			Publ_Empresa_Cuit,
			Publ_Empresa_Cuit,
			0,
			1,
			1,
			1
		FROM
			gd_esquema.Maestra
		WHERE
			Publ_Empresa_Cuit IS NOT NULL

	INSERT INTO LOL.tl_Empresas
		SELECT DISTINCT
			U.ID,
			Publ_Empresa_Razon_Social,
			Publ_Empresa_Cuit,
			Publ_Empresa_Fecha_Creacion,
			Publ_Empresa_Mail,
			Publ_Empresa_Dom_Calle,
			Publ_Empresa_Nro_Calle,
			Publ_Empresa_Piso,
			Publ_Empresa_Depto,
			Publ_Empresa_Cod_Postal,
			0, -- SumaCalificaciones
			0 -- CantidadCalificaciones
		FROM
			LOL.tl_Usuarios U JOIN gd_esquema.Maestra M ON (U.Username = M.Publ_Empresa_Cuit)

	INSERT INTO LOL.tl_Usuarios_Roles
		SELECT
			tl_Usuarios.ID,
			@RolEmpresa_ID,
			1
		FROM
			LOL.tl_Empresas JOIN LOL.tl_Usuarios ON (tl_Empresas.CUIT = LOL.tl_Usuarios.Username)

END
GO

--Stored Procedure ImportarClientes
CREATE PROCEDURE LOL.sp_ImportarClientes
AS
BEGIN

	SET NOCOUNT ON;
	DECLARE @RolCliente_ID INT = 2

	INSERT INTO LOL.tl_Usuarios
		SELECT DISTINCT
			Cli_Dni,
			Cli_Dni,
			0,
			1,
			1,
			1
		FROM
			gd_esquema.Maestra
		WHERE
			Cli_Dni IS NOT NULL
		UNION
		SELECT DISTINCT
			Publ_Cli_Dni,
			Publ_Cli_Dni,
			0,
			1,
			1,
			1
		FROM
			gd_esquema.Maestra
		WHERE
			Publ_Cli_Dni IS NOT NULL

	INSERT INTO LOL.tl_Clientes
		SELECT DISTINCT
			U.ID,
			'DNI',
			Cli_Dni,
			Cli_Apeliido,
			Cli_Nombre,
			Cli_Dni, --CUIL
			Cli_Fecha_Nac,
			Cli_Mail,
			Cli_Dom_Calle,
			Cli_Nro_Calle,
			Cli_Piso,
			Cli_Depto,
			Cli_Cod_Postal,
			NULL, -- TELEFONO
			0, -- SumaCalificaciones
			0 -- CantidadCalificaciones
		FROM
			LOL.tl_Usuarios U JOIN gd_esquema.Maestra M ON (U.Username = CAST(M.Cli_Dni AS NVARCHAR(50)))

	INSERT INTO LOL.tl_Usuarios_Roles
		SELECT
			U.ID,
			@RolCliente_ID,
			1
		FROM
			LOL.tl_Clientes C JOIN LOL.tl_Usuarios U ON (U.Username = CAST(C.Nro_Documento AS NVARCHAR(50)))					

END
GO

--Stored Procedure ImportarPublicaciones
CREATE PROCEDURE LOL.sp_ImportarPublicaciones
AS
BEGIN

	SET NOCOUNT ON;
	SET IDENTITY_INSERT LOL.tl_Publicaciones ON;

	INSERT INTO LOL.tl_Publicaciones
		(Codigo,Cliente_ID,Empresa_ID,Descripcion,Stock,Fecha,
			Fecha_Vencimiento,Precio,Tipo,Visibilidad_Codigo,Estado,
			Permite_Preguntas)
		SELECT DISTINCT
			Publicacion_Cod,
			C.ID,
			NULL,
			Publicacion_Descripcion,
			Publicacion_Stock,
			Publicacion_Fecha,
			Publicacion_Fecha_Venc,
			Publicacion_Precio,
			Publicacion_Tipo,
			Publicacion_Visibilidad_Cod,
			Publicacion_Estado,
			1
		FROM
			gd_esquema.Maestra M
				LEFT JOIN LOL.tl_Clientes C
				ON (M.Publ_Cli_Dni = C.Nro_Documento)
		WHERE
			Publicacion_Cod IS NOT NULL AND Publ_Cli_Dni IS NOT NULL

	INSERT INTO LOL.tl_Publicaciones
		(Codigo,Cliente_ID,Empresa_ID,Descripcion,Stock,Fecha,
			Fecha_Vencimiento,Precio,Tipo,Visibilidad_Codigo,Estado,
			Permite_Preguntas)
		SELECT DISTINCT
			Publicacion_Cod,
			NULL,
			E.ID,
			Publicacion_Descripcion,
			Publicacion_Stock,
			Publicacion_Fecha,
			Publicacion_Fecha_Venc,
			Publicacion_Precio,
			Publicacion_Tipo,
			Publicacion_Visibilidad_Cod,
			Publicacion_Estado,
			1
		FROM
			gd_esquema.Maestra M
				LEFT JOIN LOL.tl_Empresas E
				ON (M.Publ_Empresa_Cuit = E.CUIT)
		WHERE
			Publicacion_Cod IS NOT NULL AND
			Publ_Empresa_Cuit IS NOT NULL

	INSERT INTO LOL.tl_Publicaciones_Rubros
		SELECT DISTINCT
			(Publicacion_Cod),
			R.ID
		FROM
			gd_esquema.Maestra M
				JOIN LOL.tl_Rubros R
				ON (M.Publicacion_Rubro_Descripcion = R.Descripcion)
		WHERE
			Publicacion_Cod IS NOT NULL

END
GO

--Stored Procedure ImportarCompras
CREATE PROCEDURE LOL.sp_ImportarCompras
AS
BEGIN

	SET NOCOUNT ON;

	-- Aclaracion: Suponemos que todas las compras están Calificadas
	INSERT INTO LOL.tl_Compras
		SELECT
			Publicacion_Cod,
			C.ID,
			Compra_Cantidad,
			Compra_Fecha,
			Calificacion_Codigo,
			Calificacion_Cant_Estrellas,
			Calificacion_Descripcion,
			-- Aclaracion: Comision_pagada en 0 o en 1?
			1
		FROM
			gd_esquema.Maestra M
				JOIN LOL.tl_Clientes C
				ON (M.Cli_Dni = C.Nro_Documento)
		WHERE
			Compra_Cantidad IS NOT NULL
			--Asi importamos las compras que no estan calificadas, no se si falta algo mas
			--Calificacion_Codigo IS NOT NULL

END
GO

--Stored Procedure ImportarFacturas
CREATE PROCEDURE LOL.sp_ImportarFacturas
AS
BEGIN

	SET NOCOUNT ON;
	SET IDENTITY_INSERT LOL.tl_Facturas ON;

	INSERT INTO LOL.tl_Facturas
		(Nro,Fecha,Publicacion_Cod, Pago_Descripcion)
		SELECT DISTINCT
			--Aclaracion: El total de la factura hay que calcularlo o es null?
			Factura_Nro,Factura_Fecha,Publicacion_Cod, Forma_Pago_Desc
		FROM
			gd_esquema.Maestra
		WHERE
			Factura_Nro IS NOT NULL

	INSERT INTO LOL.tl_Facturas_Items
		SELECT
			--Aclaracion Compra_ID es null?
			Factura_Nro,Item_Factura_Cantidad,Item_Factura_Monto,Null
		FROM
			gd_esquema.Maestra
		WHERE
			Item_Factura_Cantidad IS NOT NULL

END
GO

--Stored Procedure ImportarOfertas
CREATE PROCEDURE LOL.sp_ImportarOfertas
AS
BEGIN

	SET NOCOUNT ON;

	INSERT INTO LOL.tl_Ofertas
		SELECT
			Publicacion_Cod,
			C.ID,
			Oferta_Fecha,
			Oferta_Monto
		FROM
		gd_esquema.Maestra M
			JOIN LOL.tl_Clientes C
			ON (M.Cli_Dni = C.Nro_Documento)
		WHERE
			Oferta_Monto IS NOT NULL

END
GO

--Ejecucion de Stored Procedures-----------------------------------------------

EXEC LOL.sp_InicializarFuncionalidades
EXEC LOL.sp_InicializarRoles
EXEC LOL.sp_InicializarUsuarioAdmin
EXEC LOL.sp_ImportarVisibilidades
EXEC LOL.sp_ImportarRubros
EXEC LOL.sp_ImportarEmpresas
EXEC LOL.sp_ImportarClientes
EXEC LOL.sp_ImportarPublicaciones
EXEC LOL.sp_ImportarCompras
EXEC LOL.sp_ImportarFacturas
EXEC LOL.sp_ImportarOfertas

GO

--FIN MIGRACION----------------------------------------------------------------

--Creación de Tipos de datos de usuario----------------------------------------



--Stored procedures de la nueva aplicacion-------------------------------------

/* Stored Procedure NuevaVisibilidad */
CREATE PROCEDURE LOL.sp_NuevaVisibilidad @codigo INT,
										 @descripcion NVARCHAR(255),
										 @precio MONEY,
										 @porcentaje NUMERIC(18, 2),
										 @duracion INT
AS
BEGIN

	DECLARE @error NVARCHAR(255)

	IF EXISTS (SELECT *
			   FROM LOL.tl_Visibilidades
			   WHERE tl_Visibilidades.Codigo = @codigo)
	BEGIN
		SET @error = 'Codigo existente.'
    	RAISERROR (@error, 11,1)
    	RETURN -1
    END

    IF (@porcentaje NOT BETWEEN 0 AND 100)
    BEGIN
    	SET @error = 'Porcentaje incorrecto. Ingrese uno entre 0 y 100.'
    	RAISERROR (@error, 11,1)
    	RETURN -1
    END
    
    IF (@precio < 0)
    BEGIN
		SET @error = 'Precio Incorrecto. Debe ser mayor a cero.'
		RAISERROR (@error, 11,1)
		RETURN -1
	END
	
	INSERT INTO LOL.tl_Visibilidades (Codigo, Descripcion, Precio, Porcentaje, Duracion)
		VALUES(@codigo, @descripcion, @precio, @porcentaje, @duracion)
    
END
GO

/* Stored Procedure BorrarVisibilidad */
CREATE PROCEDURE LOL.sp_BorrarVisibilidad @codigo INT
AS
BEGIN

	DECLARE @error NVARCHAR(255)

	IF EXISTS (SELECT *
			   FROM LOL.tl_Publicaciones
			   WHERE tl_Publicaciones.Visibilidad_Codigo = @codigo)
	BEGIN
		SET @error = N'No se puede eliminar visibilidad. Hay publicaciones que la referencian.'
    	RAISERROR (@error, 11,1)
    	RETURN -1
    END
	
	DELETE FROM LOL.tl_Visibilidades 
		WHERE tl_Visibilidades.Codigo = @codigo
    
END
GO

/* Stored Procedure EditarVisibilidad */
CREATE PROCEDURE LOL.sp_EditarVisibilidad @codigo INT,
									      @descripcion NVARCHAR(255),
										  @precio MONEY,
										  @porcentaje NUMERIC(18, 2),
										  @duracion INT
AS
BEGIN

	DECLARE @error NVARCHAR(255)

	IF (@porcentaje NOT BETWEEN 0 AND 100)
    BEGIN
    	SET @error = 'Porcentaje incorrecto. Ingrese uno entre 0 y 100.'
    	RAISERROR (@error, 11,1)
    	RETURN -1
    END
    
    IF (@precio < 0)
    BEGIN
		SET @error = 'Precio Incorrecto. Debe ser mayor a cero.'
		RAISERROR (@error, 11,1)
		RETURN -1
	END
	
	UPDATE LOL.tl_Visibilidades
		SET Descripcion=@descripcion, Porcentaje=@porcentaje, Precio=@precio, Duracion=@duracion
		WHERE Codigo=@codigo
    
END
GO
/* Stored Procedure sp_LoginFallido */
CREATE PROCEDURE LOL.sp_LoginFallido @user VARCHAR(50)

AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @MAX INT = 3
	DECLARE @loginsFallidos INT

    SELECT @loginsFallidos = Logins_Fallidos FROM LOL.tl_Usuarios WHERE Username = @user
    if (@loginsFallidos = (@MAX - 1))
		UPDATE LOL.tl_Usuarios SET Logins_Fallidos = @MAX , Habilitado = 0 WHERE Username = @user
	ELSE
		UPDATE LOL.tl_Usuarios SET Logins_Fallidos = Logins_Fallidos + 1 WHERE Username = @user
END
GO

/* Stored Procedure sp_LoginEitoso */
CREATE PROCEDURE LOL.sp_LoginExitoso @user VARCHAR(50)
	
AS
BEGIN

	SET NOCOUNT ON;

	UPDATE LOL.tl_Usuarios SET Logins_Fallidos = 0 WHERE Username = @user
END
GO

/* Stored Procedure sp_TryLogin */
CREATE PROCEDURE LOL.sp_TryLogin @user varchar(50),
                                 @pass varchar(50),
	                             @ID int OUT

AS
BEGIN
	DECLARE @tl_pass VARCHAR(50);
	DECLARE @tl_ID INT;
	DECLARE @tl_Habilitado INT;
	DECLARE @error NVARCHAR(255);

	SET NOCOUNT ON;

	SELECT @tl_pass = U.Password,@tl_ID = U.ID, @tl_Habilitado = U.Habilitado FROM LOL.tl_Usuarios U WHERE Username = @user

	
	IF (@tl_pass IS NULL)
		 -- NO EXISTE EL USUARIO
		BEGIN
			SET @ID = -3;
			SET @error = 'Usuario inexistente.'
    		RAISERROR (@error, 11,1)
    		RETURN -1
    	END
	ELSE
		IF (@tl_Habilitado = 0)
			BEGIN
				SET @ID = -2; -- EL USUARIO ESTA INHABILITADO
				SET @error = 'Usuario inhabilitado.'
    			RAISERROR (@error, 11,1)
    			RETURN -1
    		END	
		ELSE
			IF(@pass = @tl_pass)
				-- CONTRASENIA CORRECTA
				BEGIN
					EXEC LOL.sp_LoginExitoso @user;
					SET @ID = @tl_ID;
				END
			ELSE
				-- CONTRASENIA INCORRECTA
				BEGIN
					EXEC LOL.sp_LoginFallido @user;
					SET @ID = -1;
					SET @error = 'Contrasenia incorrecta.'
    				RAISERROR (@error, 11,1)
    				RETURN -1
				END
END
GO

/* Stored Procedure CrearPublicacion*/
CREATE PROCEDURE LOL.sp_CrearPublicacion @descripcion nvarchar(255),
                                         @fecha datetime,
                                         @stock numeric(18, 0),
                                         @fecha_vencimiento datetime,
                                         @precio money,
                                         @tipo nvarchar(255),
                                         @visibilidad_Codigo numeric(18, 0),
                                         @estado nvarchar(255),
                                         @permite_Preguntas bit,
                                         @ID int OUT

AS
BEGIN

INSERT INTO LOL.tl_Publicaciones 
	(Descripcion, Fecha, Stock,Fecha_Vencimiento, Precio,
	 Tipo, Visibilidad_Codigo, Estado, Permite_Preguntas) 
	VALUES
		(@descripcion,@fecha,@stock,@fecha_vencimiento,@precio,@tipo,@visibilidad_Codigo,
		 @estado,@permite_preguntas)
		 
 -- Esto devuelve el valor de ID de publicación creado en este caso
SELECT @ID = @@IDENTITY
    
END
GO

CREATE PROCEDURE LOL.sp_InsertPublicacionRubro 
                                         @Publicacion_Codigo numeric(18, 0),
										 @Rubro_ID numeric (18,0)

AS
BEGIN

INSERT INTO LOL.tl_Publicaciones_Rubros 
	(Publicacion_Codigo, Rubro_ID) 
	VALUES
		(@Publicacion_Codigo, @Rubro_ID)

    
END
GO

/* Stored Procedure GuardarCliente*/
CREATE PROCEDURE [LOL].[sp_GuardarCliente] 
	@isNew BIT,
	@UserPassword NVARCHAR(255) = '',
	@ID INT,
	@TipoDocumento NVARCHAR(10),
	@Nro_Documento INT,
	@CUIL NVARCHAR(15),
	@Apellido NVARCHAR(255),
	@Nombre NVARCHAR(255),
	@FechaNacimiento DATE = NULL,
	@Mail NVARCHAR(255) = NULL,
	@DomCalle NVARCHAR(255) = NULL,
	@NroCalle INT = NULL,
	@Piso INT = NULL,
	@Depto NVARCHAR(50) = NULL,
	@CodPostal NVARCHAR(50) = NULL,
	@Telefono INT
AS
BEGIN
	DECLARE @error NVARCHAR(255);
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	IF EXISTS(SELECT * FROM LOL.tl_Clientes WHERE Tipo_Documento = @TipoDocumento AND Nro_Documento = @Nro_Documento AND ID <> @ID)
		BEGIN
			SET @error = 'DNI Existente';
			RAISERROR (@error, 11,1)
    			RETURN -1
		END
	IF EXISTS(SELECT * FROM LOL.tl_Clientes WHERE CUIL = @CUIL AND ID <> @ID)
		BEGIN
			SET @error = 'CUIL Existente';
			RAISERROR (@error, 11,1)
    			RETURN -1
		END
	IF(@Telefono IS NOT NULL)
		IF EXISTS(SELECT * FROM LOL.tl_Clientes WHERE Telefono = @Telefono AND ID <> @ID)
			BEGIN
				SET @error = 'Celular Existente';
				RAISERROR (@error, 11,1)
    				RETURN -1
			END

	BEGIN TRAN
	-- Todo OK
	IF (@UserPassword <> '')
		BEGIN
			INSERT INTO LOL.tl_Usuarios(Username,Password,Change_Password) VALUES (@Nro_Documento,@UserPassword,1)
			SELECT @ID = @@IDENTITY
		END
	IF (@isNew = 1)
		INSERT INTO LOL.tl_Clientes VALUES(
			@ID,
			@TipoDocumento,
			@Nro_Documento,
			@CUIL,
			@Apellido,
			@Nombre,
			@FechaNacimiento,
			@Mail,
			@DomCalle,
			@NroCalle,
			@Piso,
			@Depto,
			@CodPostal,
			@Telefono,
			0,
			0)
	ELSE
		UPDATE LOL.tl_Clientes SET
			Tipo_Documento = @TipoDocumento,
			Nro_Documento = @Nro_Documento,
			CUIL = @CUIL,
			Apellido = @Apellido,
			Nombre = @Nombre,
			Fecha_Nac = @FechaNacimiento,
			Mail = @Mail,
			Dom_Calle = @DomCalle,
			Nro_Calle = @NroCalle,
			Piso = @Piso,
			Depto = @Depto,
			Cod_Postal = @CodPostal,
			Telefono = @Telefono
		WHERE
			ID = @ID
	COMMIT

END
GO

/* Stored Procedure GuardarEmpresa*/
CREATE PROCEDURE [LOL].[sp_GuardarEmpresa]
	@isNew BIT,
	@UserPassword NVARCHAR(255) = '',
	@ID INT,
	@Razon_Social NVARCHAR(255),
	@CUIT NVARCHAR(50),
	@FechaCreacion DATE = NULL,
	@Mail NVARCHAR(255) = NULL,
	@DomCalle NVARCHAR(255) = NULL,
	@NroCalle INT = NULL,
	@Piso INT = NULL,
	@Depto NVARCHAR(50) = NULL,
	@CodPostal NVARCHAR(50) = NULL
AS
BEGIN
	DECLARE @error NVARCHAR(255);
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	IF EXISTS(SELECT 0 FROM LOL.tl_Empresas WHERE CUIT = @CUIT AND ID <> @ID)
		BEGIN
			SET @error = 'CUIT Existente';
			RAISERROR (@error, 11,1)
    			RETURN -1
		END

	BEGIN TRAN
	-- Todo OK
	IF (@UserPassword <> '')
		BEGIN
			INSERT INTO LOL.tl_Usuarios(Username,Password,Change_Password) VALUES (@CUIT,@UserPassword,1)
			SELECT @ID = @@IDENTITY
		END
	IF (@isNew = 1)
		INSERT INTO LOL.tl_Empresas VALUES(
			@ID,
			@Razon_Social,
			@CUIT,
			@FechaCreacion,
			@Mail,
			@DomCalle,
			@NroCalle,
			@Piso,
			@Depto,
			@CodPostal,
			0,
			0)
	ELSE
		UPDATE LOL.tl_Empresas SET
			Razon_Social = @Razon_Social,
			CUIT = @CUIT,
			Fecha_Creacion = @FechaCreacion,
			Mail = @Mail,
			Dom_Calle = @DomCalle,
			Nro_Calle = @NroCalle,
			Piso = @Piso,
			Depto = @Depto,
			Cod_Postal = @CodPostal
		WHERE
			ID = @ID
	COMMIT

END
GO

/* Stored Procedure Paginador*/
CREATE PROCEDURE [LOL].[sp_Paginador]

	@Offset int,
	@Limit int,
	@Table dataTable READONLY
AS


BEGIN


;WITH Results AS

	(SELECT 
Codigo, 
Cliente_ID, 
Empresa_ID, 
Descripcion, 
Fecha, 
Stock, 
Fecha_Vencimiento, 
Precio, 
Tipo, 
Visibilidad_Codigo, 
Estado, 
Permite_Preguntas,
PrecioVisibilidad,

ROW_NUMBER() OVER (ORDER BY PrecioVisibilidad desc) AS RowNum

FROM @Table

)

SELECT 
Results.Codigo, 
Results.Cliente_ID, 
Results.Empresa_ID, 
Results.Descripcion, 
Results.Fecha, 
Results.Stock, 
Results.Fecha_Vencimiento, 
Results.Precio, 
Results.Tipo, 
Results.Visibilidad_Codigo, 
Results.Estado, 
Results.Permite_Preguntas

FROM Results
WHERE RowNum >= @Offset
AND RowNum < @Offset + @Limit

END
GO

/* Stored Procedure CalificarVendedor*/
CREATE PROCEDURE [LOL].[sp_CalificarVendedor]
	@CompraID INT,
	@CantidadEstrellas TINYINT,
	@Descripcion NVARCHAR(255) = NULL
AS
BEGIN
	DECLARE @ClienteID INT;
	DECLARE @EmpresaID INT;
	DECLARE @NewCalificacionCodigo INT;

	SET NOCOUNT ON;

	SELECT 
		@ClienteID = P.Cliente_ID,
		@EmpresaID = P.Empresa_ID
	FROM 
		(SELECT Publicacion_Codigo FROM LOL.tl_Compras WHERE (ID = @CompraID)) C JOIN LOL.tl_Publicaciones P ON (C.Publicacion_Codigo = P.Codigo)
	
	SELECT @NewCalificacionCodigo = MAX(Calificacion_Codigo) + 1 FROM LOL.tl_Compras WHERE Calificacion_Codigo IS NOT NULL
	
	BEGIN TRANSACTION;
		UPDATE 
			LOL.tl_Compras
		SET
			Calificacion_Codigo = @NewCalificacionCodigo,
			Calificacion_Cant_Estrellas = @CantidadEstrellas,
			Calificacion_Descripcion = @Descripcion
		WHERE
			ID = @CompraID;

		IF (@ClienteID IS NOT NULL)
			UPDATE LOL.tl_Clientes 
			SET Suma_Calificaciones = Suma_Calificaciones + @CantidadEstrellas, Cantidad_Calificaciones = Cantidad_Calificaciones + 1
			WHERE ID = @ClienteID;
		ELSE
			UPDATE LOL.tl_Empresas
			SET Suma_Calificaciones = Suma_Calificaciones + @CantidadEstrellas, Cantidad_Calificaciones = Cantidad_Calificaciones + 1
			WHERE ID = @EmpresaID;

	COMMIT
END
GO

/* Stored Procedure VendedoresConMasStock*/
CREATE PROCEDURE LOL.sp_VendedoresConMasStock @anio int,
											  @trimestre int,
											  @visibilidad_codigo int,
											  @mes int

AS
BEGIN

	SELECT TOP 5
		ISNULL(tl_Publicaciones.Cliente_ID, tl_Publicaciones.Empresa_ID) AS 'Codigo de usuario',
		SUM(tl_Publicaciones.Stock) AS 'Productos sin vender'
	FROM
		LOL.tl_Publicaciones
    WHERE
		YEAR(tl_Publicaciones.Fecha) = @anio AND
		(MONTH(tl_Publicaciones.Fecha) BETWEEN @trimestre AND (@trimestre+2)) AND
		(MONTH(tl_Publicaciones.Fecha) = (@trimestre + @mes) OR @mes IS NULL) AND
		(tl_Publicaciones.Visibilidad_Codigo = @visibilidad_codigo OR @visibilidad_codigo IS NULL)
	GROUP BY ISNULL(tl_Publicaciones.Cliente_ID, tl_Publicaciones.Empresa_ID)
	ORDER BY 2 DESC
	OPTION(RECOMPILE)
    
END
GO
