USE GD1C2014
GO

--Creacion del esquema LOL-----------------------------------------------------

CREATE SCHEMA LOL AUTHORIZATION gd
GO

--Creacion de Tablas-----------------------------------------------------------

--Tabla Clientes
CREATE TABLE LOL.tl_Clientes (
	ID             NUMERIC(18, 0) IDENTITY(1,1) NOT NULL,
	Tipo_Documento NVARCHAR(10) NOT NULL,
	Nro_Documento  NUMERIC(18, 0) NOT NULL,
	Apellido       NVARCHAR(255) NOT NULL,
	Nombre         NVARCHAR(255) NOT NULL,
	Fecha_Nac      DATETIME NULL,
	Mail           NVARCHAR(255) NULL,
	Dom_Calle      NVARCHAR(255) NULL,
	Nro_Calle      NUMERIC(18, 0) NULL,
	Piso           NUMERIC(18, 0) NULL,
	Depto          NVARCHAR(50) NULL,
	Cod_Postal     NVARCHAR(50) NULL,
	Telefono       NUMERIC(18, 0) NULL,

	--Aclaracion: Falla este unique en la importacion?
	--UNIQUE (Telefono),
	PRIMARY KEY (ID)
)
GO

--Tabla Empresas
CREATE TABLE LOL.tl_Empresas (
	ID             NUMERIC(18, 0) IDENTITY(1,1) NOT NULL,
	Razon_Social   NVARCHAR(255) NOT NULL,
	CUIT           NVARCHAR(50) NOT NULL,
	Fecha_Creacion DATETIME NOT NULL,
	Mail           NVARCHAR(50) NULL,
	Dom_Calle      NVARCHAR(100) NULL,
	Nro_Calle      NUMERIC(18, 0) NULL,
	Piso           NUMERIC(18, 0) NULL,
	Depto          NVARCHAR(50) NULL,
	Cod_Postal     NVARCHAR(50) NULL,

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
	Codigo      NUMERIC(18, 0) IDENTITY(1,1) NOT NULL,
	Descripcion NVARCHAR(255) NOT NULL,
	Precio      MONEY NOT NULL,
	Porcentaje  NUMERIC(18, 2) NOT NULL,

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
	Password        NVARCHAR(50) NOT NULL,
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
    	VALUES (@Usuario_ID,'admin','w23e')

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
	SET IDENTITY_INSERT LOL.tl_Visibilidades ON;

	DECLARE @max INT

    INSERT INTO LOL.tl_Visibilidades
		(Codigo,Descripcion,Precio,Porcentaje)
		SELECT DISTINCT
			Publicacion_Visibilidad_Cod,
			Publicacion_Visibilidad_Desc,
			Publicacion_Visibilidad_Precio,
			Publicacion_Visibilidad_Porcentaje
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

    INSERT INTO LOL.tl_Empresas
		SELECT DISTINCT
			Publ_Empresa_Razon_Social,
			Publ_Empresa_Cuit,
			Publ_Empresa_Fecha_Creacion,
			Publ_Empresa_Mail,
			Publ_Empresa_Dom_Calle,
			Publ_Empresa_Nro_Calle,
			Publ_Empresa_Piso,
			Publ_Empresa_Depto,
			Publ_Empresa_Cod_Postal
		FROM
			gd_esquema.Maestra
		WHERE
			Publ_Empresa_Cuit IS NOT NULL

	INSERT INTO LOL.tl_Usuarios
			SELECT
				CUIT,
				CUIT,
				0,
				1,
				1,
				1
			FROM
				LOL.tl_Empresas

	INSERT INTO LOL.tl_Usuarios_Roles
		SELECT
			tl_Usuarios.ID,
			@RolEmpresa_ID,
			1
		FROM
			LOL.tl_Empresas
				JOIN LOL.tl_Usuarios
				ON tl_Empresas.CUIT = LOL.tl_Usuarios.Username
END
GO

--Stored Procedure ImportarClientes
CREATE PROCEDURE [LOL].[sp_ImportarClientes]
AS
BEGIN

	SET NOCOUNT ON;
	DECLARE @RolCliente_ID INT = 2

	INSERT INTO LOL.tl_Clientes
		SELECT DISTINCT
			'DNI',
			Cli_Dni,
			Cli_Apeliido,
			Cli_Nombre,
			Cli_Fecha_Nac,
			Cli_Mail,
			Cli_Dom_Calle,
			Cli_Nro_Calle,
			Cli_Piso,
			Cli_Depto,
			Cli_Cod_Postal,
			NULL
		FROM
			gd_esquema.Maestra
		WHERE
			Cli_Dni IS NOT NULL
		UNION
		SELECT DISTINCT
			'DNI',
			Publ_Cli_Dni,
			Publ_Cli_Apeliido,
			Publ_Cli_Nombre,
			Publ_Cli_Fecha_Nac,
			Publ_Cli_Mail,
			Publ_Cli_Dom_Calle,
			Publ_Cli_Nro_Calle,
			Publ_Cli_Piso,
			Publ_Cli_Depto,
			Publ_Cli_Cod_Postal,
			NULL
		FROM
			gd_esquema.Maestra
		WHERE
			Publ_Cli_Dni IS NOT NULL

		INSERT INTO LOL.tl_Usuarios
			SELECT
				Nro_Documento,
				Nro_Documento,
				0,
				1,
				1,
				1
			FROM
				LOL.tl_Clientes

		INSERT INTO LOL.tl_Usuarios_Roles
			SELECT
				tl_Usuarios.ID,
				@RolCliente_ID,
				1
			FROM
				LOL.tl_Clientes
					JOIN LOL.tl_Usuarios
					ON CAST(tl_Clientes.Nro_Documento AS NVARCHAR(50)) =
						LOL.tl_Usuarios.Username
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
			Publicacion_Cod IS NOT NULL AND Publ_Empresa_Cuit IS NOT NULL

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
			Compra_Cantidad IS NOT NULL AND
			Calificacion_Codigo IS NOT NULL
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
