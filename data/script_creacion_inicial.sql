USE GD1C2014
GO

--Creacion del esquema LOL-----------------------------------------------------

CREATE SCHEMA LOL AUTHORIZATION gd
GO

--Creacion de Tablas-----------------------------------------------------------

--Tabla Clientes
CREATE TABLE LOL.tl_Clientes (
	ID						NUMERIC(18, 0)	NOT NULL,
	Tipo_Documento			NVARCHAR(10)	NOT NULL,
	Nro_Documento			NUMERIC(18, 0)	NOT NULL,
	Apellido				NVARCHAR(255)	NOT NULL,
	Nombre					NVARCHAR(255)	NOT NULL,
	CUIL					NVARCHAR(50)	NOT NULL,
	Fecha_Nac				DATETIME		NULL,
	Mail					NVARCHAR(255)	NULL,
	Dom_Calle				NVARCHAR(255)	NULL,
	Nro_Calle				NUMERIC(18, 0)	NULL,
	Piso					NUMERIC(18, 0)	NULL,
	Depto					NVARCHAR(50)	NULL,
	Cod_Postal				NVARCHAR(50)	NULL,
	Telefono				NUMERIC(18, 0)	NULL,
	Suma_Calificaciones		NUMERIC(18, 0)	NOT NULL	DEFAULT(0),
	Cantidad_Calificaciones	NUMERIC(18, 0)	NOT NULL	DEFAULT(0),
	Habilitado				BIT DEFAULT(1)	NOT NULL,
	Comisiones_Pendientes	NUMERIC(18,0)	NOT NULL	DEFAULT(0),

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
	Suma_Calificaciones		NUMERIC(18, 0) DEFAULT(0) NOT NULL,
	Cantidad_Calificaciones	NUMERIC(18, 0) DEFAULT(0) NOT NULL,
	Habilitada				BIT DEFAULT(1) NOT NULL,
	Comisiones_Pendientes	NUMERIC(18,0) DEFAULT(0) NOT NULL,
	
	PRIMARY KEY(ID)
)
GO

--Tabla Funcionalidades
CREATE TABLE LOL.tl_Funcionalidades (
	ID		NUMERIC(18, 0)	IDENTITY(1,1)	NOT NULL,
	Nombre	NVARCHAR(50)	NOT NULL,

	PRIMARY KEY(ID)
)
GO

--Tabla Visibilidades
CREATE TABLE LOL.tl_Visibilidades (
	Codigo		NUMERIC(18, 0)	NOT NULL,
	Descripcion	NVARCHAR(255)	NOT NULL,
	Precio		MONEY			NOT NULL,
	Porcentaje	NUMERIC(18, 2)	NOT NULL,
	Duracion	INT				NOT NULL,

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
	ID			NUMERIC(18, 0)	IDENTITY(1,1)	NOT NULL,
	Descripcion	NVARCHAR(50)	NOT NULL,
	Habilitado 	BIT				DEFAULT(1)		NOT NULL,

	PRIMARY KEY(ID)
)
GO

--Tabla Publicaciones
CREATE TABLE LOL.tl_Publicaciones (
	Codigo				NUMERIC(18, 0)	NOT NULL	IDENTITY(1,1),
	Usuario_ID			NUMERIC(18, 0)	NOT NULL,
	Descripcion			NVARCHAR(255)	NOT NULL,
	Fecha				DATETIME		NOT NULL,
	Stock				NUMERIC(18, 0)	NOT NULL,
	Fecha_Vencimiento	DATETIME		NOT NULL,
	Precio				MONEY			NOT NULL,
	Tipo_ID				NUMERIC(18, 0)	NOT NULL,
	Visibilidad_Codigo	NUMERIC(18, 0)	NOT NULL,
	Estado_ID			NUMERIC(18, 0)	NOT NULL,
	Permite_Preguntas	BIT				NOT NULL	DEFAULT(1),

	PRIMARY KEY(Codigo)
)
GO

--Tabla Preguntas
CREATE TABLE LOL.tl_Preguntas (
	ID					NUMERIC(18, 0)	IDENTITY(1,1)	NOT NULL,
	Publicacion_Codigo	NUMERIC(18, 0)	NOT NULL,
	Usuario_ID			NUMERIC(18, 0)	NOT NULL,
	Pregunta			NVARCHAR(255)	NOT NULL,
	Fecha_Respuesta		DATE			NULL,
	Respuesta			NVARCHAR(255)	NULL,

	PRIMARY KEY(ID)
)
GO

--Tabla Publicaciones_Rubros
CREATE TABLE LOL.tl_Publicaciones_Rubros (
	Publicacion_Codigo	NUMERIC(18, 0)	NOT NULL,
	Rubro_ID			NUMERIC(18, 0)	NOT NULL,

	PRIMARY KEY(Publicacion_Codigo, Rubro_ID)
)
GO

--Tabla Publicacion_Tipos
CREATE TABLE LOL.tl_Publicacion_Tipos (
	ID			NUMERIC(18, 0)	IDENTITY(1,1)	NOT NULL,
	Tipo		NVARCHAR(50)	NOT NULL,
	Habilitado	BIT				DEFAULT(1)		NOT NULL,

	PRIMARY KEY(ID)
)
GO
--FALTA HACER -> Agregar Indice de Unique a 'TIpo'

--Tabla Publicacion_Estados
CREATE TABLE LOL.tl_Publicacion_Estados (
	ID			NUMERIC(18, 0)	IDENTITY(1,1)	NOT NULL,
	Estado		NVARCHAR(50)	NOT NULL,
	Habilitado	BIT				DEFAULT(1)		NOT NULL,

	PRIMARY KEY(ID)
)
GO
--FALTA HACER -> Agregar Indice de Unique a 'Estado'

--Tabla Roles_Funcionalidades
CREATE TABLE LOL.tl_Roles_Funcionalidades (
	Rol_ID				NUMERIC(18, 0)	NOT NULL,
	Funcionalidad_ID	NUMERIC(18, 0)	NOT NULL,

	PRIMARY KEY(Rol_ID, Funcionalidad_ID)
)
GO

--Tabla Usuarios
CREATE TABLE LOL.tl_Usuarios (
	ID				NUMERIC(18, 0)	IDENTITY(1,1)	NOT NULL,
	Username		NVARCHAR(50)	NOT NULL,
	Password		NVARCHAR(255)	NOT NULL,
	Logins_Fallidos	TINYINT			DEFAULT(0)		NOT NULL,
	Habilitado		BIT				DEFAULT(1)		NOT NULL,
	Activo			BIT				DEFAULT(1)		NOT NULL,
	Change_Password	BIT				DEFAULT(0)		NOT NULL,
	Calificaciones_Pendientes	TINYINT DEFAULT(0) NOT NULL,

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
	Pago_Descripcion NVARCHAR(255) NULL,

	PRIMARY KEY(Nro)
)
GO

--Tabla Compras
CREATE TABLE LOL.tl_Compras (
	ID					NUMERIC(18, 0)	NOT NULL	IDENTITY(1,1),
	Publicacion_Codigo	NUMERIC(18, 0)	NOT NULL,
	Usuario_ID			NUMERIC(18, 0)	NOT NULL,
	Cantidad			NUMERIC(18, 0)	NOT NULL,
	Fecha				DATETIME		NOT NULL,
	Comision_Pagada		BIT				NOT NULL	DEFAULT(0),

	PRIMARY KEY(ID)
)
GO

--Tabla Calificaciones
CREATE TABLE LOL.tl_Calificaciones (
	Codigo				NUMERIC(18, 0)	IDENTITY(1,1)	NOT NULL,
	Compra_ID			NUMERIC(18,0)	NOT NULL,
	Cantidad_Estrellas	NUMERIC(18,0)	NOT NULL,
	Descripcion			NVARCHAR(255)	NOT NULL,

	PRIMARY KEY(Codigo)
)
GO

--Tabla Ofertas
CREATE TABLE LOL.tl_Ofertas (
	ID					NUMERIC(18, 0) IDENTITY(1,1) NOT NULL,
	Publicacion_Codigo	NUMERIC(18, 0) NOT NULL,
	Usuario_ID			NUMERIC(18, 0) NOT NULL,
	Fecha				DATE NOT NULL,
	Monto				MONEY NOT NULL,
	Ganadora			BIT DEFAULT(0) NOT NULL,

	PRIMARY KEY(ID)
)
GO

--Tabla Facturas_Items
CREATE TABLE LOL.tl_Facturas_Items (
	ID					NUMERIC(18, 0) IDENTITY(1,1) NOT NULL,
	Factura_Nro			NUMERIC(18, 0) NOT NULL,
	Cantidad			NUMERIC(18, 0) NOT NULL,
	Monto				MONEY NOT NULL,
	Publicacion_Codigo	NUMERIC(18,0) NOT NULL,
	Compra_ID			NUMERIC(18, 0) NULL

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

--Tabla Usuarios_Visibilidades_Ventas
CREATE TABLE LOL.tl_Usuarios_Visibilidades_Ventas(
	Usuario_ID			NUMERIC(18, 0)	NOT NULL,
	Visibilidad_Codigo	NUMERIC(18, 0)	NOT NULL,
	Cantidad_Ventas		INT				DEFAULT(0)	NOT NULL,
	
	PRIMARY KEY(Usuario_ID,Visibilidad_Codigo)
)
GO

--Creacion de Foreign Keys-----------------------------------------------------

--Cliente.ID -> Usuario.ID
ALTER TABLE LOL.tl_Clientes WITH CHECK ADD
	CONSTRAINT fk_Cliente_Usuario
	FOREIGN KEY (ID)
	REFERENCES LOL.tl_Usuarios (ID)
	
--Empresa.ID -> Usuario.ID
ALTER TABLE LOL.tl_Empresas WITH CHECK ADD
	CONSTRAINT fk_Empresa_Usuario
	FOREIGN KEY (ID)
	REFERENCES LOL.tl_Usuarios (ID)

--Calificaciones.Compra_ID -> Compras.ID
ALTER TABLE LOL.tl_Calificaciones WITH CHECK ADD
	CONSTRAINT fk_Calificaciones_Compra
	FOREIGN KEY (Compra_ID)
	REFERENCES LOL.tl_Compras (ID)

--Publicaciones.Usuario_ID -> Usuarios.ID
ALTER TABLE LOL.tl_Publicaciones WITH CHECK ADD
	CONSTRAINT fk_Publicaciones_Usuario
	FOREIGN KEY (Usuario_ID)
	REFERENCES LOL.tl_Usuarios (ID)

--Publicaciones.Tipo_ID -> Publicacion_Tipos.ID
ALTER TABLE LOL.tl_Publicaciones WITH CHECK ADD
	CONSTRAINT fk_Publicaciones_Tipo
	FOREIGN KEY (Tipo_ID)
	REFERENCES LOL.tl_Publicacion_Tipos (ID)

--Publicaciones.Visibilidad_Codigo -> Visibilidades.Codigo
ALTER TABLE LOL.tl_Publicaciones WITH CHECK ADD
	CONSTRAINT fk_Publicaciones_Visibilidad
	FOREIGN KEY (Visibilidad_Codigo)
	REFERENCES LOL.tl_Visibilidades (Codigo)

--Publicaciones.Estado_ID -> Publicacion_Estados.ID
ALTER TABLE LOL.tl_Publicaciones WITH CHECK ADD
	CONSTRAINT fk_Publicaciones_Estado
	FOREIGN KEY (Estado_ID)
	REFERENCES LOL.tl_Publicacion_Estados (ID)

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

--Compras.Usuario_ID -> Usuarios.ID
ALTER TABLE LOL.tl_Compras WITH CHECK ADD
	CONSTRAINT fk_Compras_Usuario
	FOREIGN KEY (Usuario_ID)
	REFERENCES LOL.tl_Usuarios (ID)

--Compras.Publicacion_Codigo -> Publicaciones.Codigo
ALTER TABLE LOL.tl_Compras WITH CHECK ADD
	CONSTRAINT fk_Compras_Publicacion
	FOREIGN KEY (Publicacion_Codigo)
	REFERENCES LOL.tl_Publicaciones (Codigo)

--Ofertas.Usuario_ID -> Usuarios.ID
ALTER TABLE LOL.tl_Ofertas WITH CHECK ADD
	CONSTRAINT fk_Ofertas_Usuario
	FOREIGN KEY (Usuario_ID)
	REFERENCES LOL.tl_Usuarios (ID)

--Ofertas.Publicacion_Codigo -> Publicaciones.Codigo
ALTER TABLE LOL.tl_Ofertas WITH CHECK ADD
	CONSTRAINT fk_Ofertas_Publicacion
	FOREIGN KEY (Publicacion_Codigo)
	REFERENCES LOL.tl_Publicaciones (Codigo)

--Facturas_Items.Publicacion_Codigo -> Publicaciones.Codigo
ALTER TABLE LOL.tl_Facturas_Items WITH CHECK ADD
	CONSTRAINT fk_Facturas_Items_Publicacion
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

--UsuariosVisibilidadesVentas.Usuario_ID -> Usuarios.ID
ALTER TABLE LOL.tl_Usuarios_Visibilidades_Ventas WITH CHECK ADD
	CONSTRAINT fk_Usuarios_Visibilidades_Ventas_Usuario_ID
	FOREIGN KEY (Usuario_ID)
	REFERENCES LOL.tl_Usuarios (ID)
GO

--UsuariosVisibilidadesVentas.Visibilidad_Codigo -> Visibilidades.Codigo
ALTER TABLE LOL.tl_Usuarios_Visibilidades_Ventas WITH CHECK ADD
	CONSTRAINT fk_Usuarios_Visibilidades_Ventas_Visibilidad_Codigo
	FOREIGN KEY (Visibilidad_Codigo)
	REFERENCES LOL.tl_Visibilidades (Codigo)
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

	SET IDENTITY_INSERT LOL.tl_Funcionalidades OFF;
END
GO

--Stored Procedure InicializarRoles
CREATE PROCEDURE LOL.sp_InicializarRoles
AS
BEGIN

	SET IDENTITY_INSERT LOL.tl_Roles ON;

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

	SET IDENTITY_INSERT LOL.tl_Roles OFF;
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

	SET IDENTITY_INSERT LOL.tl_Usuarios OFF;
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

	INSERT INTO LOL.tl_Usuarios (Username,Password,Change_Password)
		SELECT DISTINCT
			Publ_Empresa_Cuit,
			Publ_Empresa_Cuit,
			1
		FROM
			gd_esquema.Maestra
		WHERE
			Publ_Empresa_Cuit IS NOT NULL

	INSERT INTO LOL.tl_Empresas (ID,Razon_Social,CUIT,Fecha_Creacion,Mail,Dom_Calle,Nro_Calle,Piso,Depto,Cod_Postal)
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
			Publ_Empresa_Cod_Postal
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

	INSERT INTO LOL.tl_Usuarios (Username,Password,Change_Password)
		SELECT DISTINCT
			Cli_Dni,
			Cli_Dni,
			1
		FROM
			gd_esquema.Maestra
		WHERE
			Cli_Dni IS NOT NULL
		UNION
		SELECT DISTINCT
			Publ_Cli_Dni,
			Publ_Cli_Dni,
			1
		FROM
			gd_esquema.Maestra
		WHERE
			Publ_Cli_Dni IS NOT NULL

	INSERT INTO LOL.tl_Clientes(ID,Tipo_Documento,Nro_Documento,Apellido,Nombre,CUIL,Fecha_Nac,Mail,Dom_Calle,Nro_Calle,Piso,Depto,Cod_Postal,Telefono)
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
			NULL -- TELEFONO
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

--Stored Procedure ImportarPublicacionTipos
CREATE PROCEDURE LOL.sp_ImportarPublicacionTipos
AS
BEGIN
	SET NOCOUNT ON;
	SET IDENTITY_INSERT LOL.tl_Publicacion_Tipos ON;

	INSERT INTO LOL.tl_Publicacion_Tipos(ID,Tipo) VALUES(1,'Compra Inmediata');
	INSERT INTO LOL.tl_Publicacion_Tipos(ID,Tipo) VALUES(2,'Subasta');

	SET IDENTITY_INSERT LOL.tl_Publicacion_Tipos OFF;
END
GO

--Stored Procedure ImportarPublicacionEstados
CREATE PROCEDURE LOL.sp_ImportarPublicacionEstados
AS
BEGIN
	SET NOCOUNT ON;
	SET IDENTITY_INSERT LOL.tl_Publicacion_Estados ON;
	
	INSERT INTO LOL.tl_Publicacion_Estados(ID,Estado) VALUES(1,'Publicada');
	INSERT INTO LOL.tl_Publicacion_Estados(ID,Estado) VALUES(2,'Pausada');
	INSERT INTO LOL.tl_Publicacion_Estados(ID,Estado) VALUES(3,'Borrador');
	INSERT INTO LOL.tl_Publicacion_Estados(ID,Estado) VALUES(4,'Finalizada');
		
	SET IDENTITY_INSERT LOL.tl_Publicacion_Estados OFF;
END
GO

--Stored Procedure ImportarPublicaciones
CREATE PROCEDURE LOL.sp_ImportarPublicaciones
AS
BEGIN

	SET NOCOUNT ON;
	SET IDENTITY_INSERT LOL.tl_Publicaciones ON;

	-- Inserto las Publicaciones hechas por Clientes
	INSERT INTO LOL.tl_Publicaciones
		(Codigo,Usuario_ID,Descripcion,Fecha,Stock,
			Fecha_Vencimiento,Precio,Tipo_ID,Visibilidad_Codigo,Estado_ID,
			Permite_Preguntas)
		SELECT DISTINCT
			Publicacion_Cod,
			C.ID, --Usuario_ID
			Publicacion_Descripcion,
			Publicacion_Fecha,
			Publicacion_Stock,
			Publicacion_Fecha_Venc,
			Publicacion_Precio,
			T.ID,
			Publicacion_Visibilidad_Cod,
			E.ID,
			1 --Permite_Preguntas
		FROM
			gd_esquema.Maestra M
			JOIN LOL.tl_Clientes C ON (M.Publ_Cli_Dni = C.Nro_Documento)
			JOIN LOL.tl_Publicacion_Tipos T ON (M.Publicacion_Tipo = T.Tipo)
			JOIN LOL.tl_Publicacion_Estados E ON (M.Publicacion_Estado = E.Estado)
		WHERE
			Publicacion_Cod IS NOT NULL AND Publ_Cli_Dni IS NOT NULL

	-- Inserto las Publicaciones hechas por Empresas
	INSERT INTO LOL.tl_Publicaciones
		(Codigo,Usuario_ID,Descripcion,Fecha,Stock,
			Fecha_Vencimiento,Precio,Tipo_ID,Visibilidad_Codigo,Estado_ID,
			Permite_Preguntas)
		SELECT DISTINCT
			Publicacion_Cod,
			Em.ID, --Usuario_ID
			Publicacion_Descripcion,
			Publicacion_Fecha,
			Publicacion_Stock,
			Publicacion_Fecha_Venc,
			Publicacion_Precio,
			T.ID,
			Publicacion_Visibilidad_Cod,
			Es.ID,
			1 --Permite_Preguntas
		FROM
			gd_esquema.Maestra M
			JOIN LOL.tl_Empresas Em ON (M.Publ_Empresa_Cuit = Em.CUIT)
			JOIN LOL.tl_Publicacion_Tipos T ON (M.Publicacion_Tipo = T.Tipo)
			JOIN LOL.tl_Publicacion_Estados Es ON (M.Publicacion_Estado = Es.Estado)
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

	SET IDENTITY_INSERT LOL.tl_Publicaciones OFF;
END
GO

--Stored Procedure ImportarCompras
CREATE PROCEDURE LOL.sp_ImportarCompras
AS
BEGIN

	SET NOCOUNT ON;
	
	-- Creo la tabla TEMPORAL para generar el ID, y despues pasar los datos a las tablas Compras y Calificaciones
	CREATE TABLE LOL.tl_ComprasTEMP (
		ID					NUMERIC(18, 0)	NOT NULL	IDENTITY(1,1),
		Publicacion_Codigo	NUMERIC(18, 0)	NOT NULL,
		Usuario_ID			NUMERIC(18, 0)	NOT NULL,
		Cantidad			NUMERIC(18, 0)	NOT NULL,
		Fecha				DATETIME		NOT NULL,
		Comision_Pagada		BIT DEFAULT(0)	NOT NULL,
		Codigo				NUMERIC(18, 0)	NOT NULL,
		Cantidad_Estrellas	NUMERIC(18,0)	NOT NULL,
		Descripcion			NVARCHAR(255)	NOT NULL,
	
		PRIMARY KEY(ID)
	)
	
	-- Aclaracion: Suponemos que todas las compras están Calificadas
	-- Importamos todas las compras a una tabla TEMPORAL.
	INSERT INTO LOL.tl_ComprasTEMP
		SELECT
			Publicacion_Cod,
			C.ID,
			Compra_Cantidad,
			Compra_Fecha,
			1, --Comision_Pagada
			Calificacion_Codigo,
			Calificacion_Cant_Estrellas,
			Calificacion_Descripcion
		FROM
			gd_esquema.Maestra M
				JOIN LOL.tl_Clientes C
				ON (M.Cli_Dni = C.Nro_Documento)
		WHERE
			Compra_Cantidad IS NOT NULL AND
			Calificacion_Codigo IS NOT NULL

	-- Lleno la tabla Compras
	SET IDENTITY_INSERT LOL.tl_Compras ON;
	INSERT INTO LOL.tl_Compras
		(ID,Publicacion_Codigo,Usuario_ID,Cantidad,Fecha,Comision_Pagada)
		SELECT
			ID,
			Publicacion_Codigo,
			Usuario_ID,
			Cantidad,
			Fecha,
			Comision_Pagada
		FROM
			LOL.tl_ComprasTEMP
	SET IDENTITY_INSERT LOL.tl_Compras OFF;
	
	-- Lleno la tabla Calificaciones
	SET IDENTITY_INSERT LOL.tl_Calificaciones ON;
	INSERT INTO LOL.tl_Calificaciones
		(Codigo,Compra_ID,Cantidad_Estrellas,Descripcion)
		SELECT
			Codigo,
			ID,
			Cantidad_Estrellas,
			Descripcion
		FROM
			LOL.tl_ComprasTEMP
	SET IDENTITY_INSERT LOL.tl_Calificaciones OFF;

	DROP TABLE LOL.tl_ComprasTEMP
END
GO

--Stored Procedure InicializarCalificacionesClientes
CREATE PROCEDURE LOL.sp_InicializarCalificacionesClientes
AS
BEGIN
	UPDATE
		LOL.tl_Clientes
	SET
		Suma_Calificaciones = M.SumaTotal,
		Cantidad_Calificaciones = M.CantidadTotal
	FROM
		(SELECT
			Publ_Cli_Dni,
			SUM(Calificacion_Cant_Estrellas) AS SumaTotal,
			COUNT(0) AS CantidadTotal
		FROM
			gd_esquema.Maestra
		WHERE
			Publ_Cli_Dni IS NOT NULL AND
			Calificacion_Cant_Estrellas IS NOT NULL
		GROUP BY
			Publ_Cli_Dni) M JOIN LOL.tl_Clientes C ON (M.Publ_Cli_Dni = C.Nro_Documento)
END
GO

--Stored Procedure InicializarCalificacionesEmpresas
CREATE PROCEDURE LOL.sp_InicializarCalificacionesEmpresas
AS
BEGIN
	UPDATE
		LOL.tl_Empresas
	SET
		Suma_Calificaciones = M.SumaTotal,
		Cantidad_Calificaciones = M.CantidadTotal
	FROM
		(SELECT
			Publ_Empresa_Cuit,
			SUM(Calificacion_Cant_Estrellas) AS SumaTotal,
			COUNT(0) AS CantidadTotal
		FROM
			gd_esquema.Maestra
		WHERE
			Publ_Empresa_Cuit IS NOT NULL AND
			Calificacion_Cant_Estrellas IS NOT NULL
		GROUP BY
			Publ_Empresa_Cuit) M JOIN LOL.tl_Empresas E ON (M.Publ_Empresa_Cuit = E.CUIT)
END
GO

--Stored Procedure ImportarFacturas
CREATE PROCEDURE LOL.sp_ImportarFacturas
AS
BEGIN

	SET NOCOUNT ON;
	SET IDENTITY_INSERT LOL.tl_Facturas ON;

	INSERT INTO LOL.tl_Facturas
		(Nro,Fecha, Pago_Descripcion)
		SELECT DISTINCT
			Factura_Nro,Factura_Fecha, Forma_Pago_Desc
		FROM
			gd_esquema.Maestra
		WHERE
			Factura_Nro IS NOT NULL

	INSERT INTO LOL.tl_Facturas_Items
		SELECT
			--Aclaracion Compra_ID es null?
			Factura_Nro,Item_Factura_Cantidad,Item_Factura_Monto,Publicacion_Cod, Null
		FROM
			gd_esquema.Maestra
		WHERE
			Item_Factura_Cantidad IS NOT NULL

	SET IDENTITY_INSERT LOL.tl_Facturas OFF;
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
			Oferta_Monto,
			0 -- Ganadora
		FROM
		gd_esquema.Maestra M
			JOIN LOL.tl_Clientes C
			ON (M.Cli_Dni = C.Nro_Documento)
		WHERE
			Oferta_Monto IS NOT NULL

	UPDATE 
		LOL.tl_Ofertas 
	SET 
		Ganadora = 1 
	FROM 
		LOL.tl_Ofertas O 
			JOIN (SELECT Publicacion_Codigo, MAX(Monto) Monto FROM LOL.tl_Ofertas GROUP BY Publicacion_Codigo) AS Ganadoras
			ON O.Publicacion_Codigo = Ganadoras.Publicacion_Codigo AND O.Monto = Ganadoras.Monto

END
GO

/* Stored Procedure InicializarUsuariosVisibilidadesVentas */
CREATE PROCEDURE LOL.sp_InicializarUsuariosVisibilidadesVentas
AS
BEGIN

	INSERT INTO LOL.tl_Usuarios_Visibilidades_Ventas(Usuario_ID,Visibilidad_Codigo)
		SELECT U.ID,V.Codigo FROM LOL.tl_Usuarios U, LOL.tl_Visibilidades V

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
EXEC LOL.sp_ImportarPublicacionTipos
EXEC LOL.sp_ImportarPublicacionEstados
EXEC LOL.sp_ImportarPublicaciones
EXEC LOL.sp_ImportarCompras
EXEC LOL.sp_InicializarCalificacionesClientes
EXEC LOL.sp_InicializarCalificacionesEmpresas
EXEC LOL.sp_ImportarFacturas
EXEC LOL.sp_ImportarOfertas
EXEC LOL.sp_InicializarUsuariosVisibilidadesVentas
GO

--FIN MIGRACION----------------------------------------------------------------

--Creación de Tipos de datos de usuario----------------------------------------

--Creación de Triggers----------------------------------------

CREATE TRIGGER LOL.tr_PendientesAfterInsert
   ON  LOL.tl_Pendientes
   AFTER INSERT
AS 
BEGIN
	DECLARE @PublicacionCodigo INT;
	DECLARE @CompraID INT;
	DECLARE @UsuarioID INT;

	SET NOCOUNT ON;

    SELECT @PublicacionCodigo = Publicacion_Codigo, @CompraID = Compra_ID FROM INSERTED
    IF(@CompraID IS NOT NULL)
		BEGIN
			SELECT @UsuarioID = Usuario_ID FROM LOL.tl_Publicaciones WHERE Codigo = @PublicacionCodigo
			IF EXISTS(SELECT 0 FROM LOL.tl_Clientes WHERE ID = @UsuarioID) --Es Cliente
				UPDATE LOL.tl_Clientes SET Comisiones_Pendientes = Comisiones_Pendientes + 1 WHERE ID = @UsuarioID
			ELSE --Es Empresa
				UPDATE LOL.tl_Empresas SET Comisiones_Pendientes = Comisiones_Pendientes + 1 WHERE ID = @UsuarioID
		END

END
GO

CREATE TRIGGER LOL.tr_PendientesAfterDelete
   ON  LOL.tl_Pendientes
   AFTER DELETE
AS 
BEGIN
	DECLARE @PublicacionCodigo INT;
	DECLARE @CompraID INT;
	DECLARE @UsuarioID INT;

	SET NOCOUNT ON;

    SELECT @PublicacionCodigo = Publicacion_Codigo, @CompraID = Compra_ID FROM DELETED
    IF(@CompraID IS NOT NULL)
		BEGIN
			SELECT @UsuarioID = Usuario_ID FROM LOL.tl_Publicaciones WHERE Codigo = @PublicacionCodigo
			IF EXISTS(SELECT 0 FROM LOL.tl_Clientes WHERE ID = @UsuarioID) --Es Cliente
				UPDATE LOL.tl_Clientes SET Comisiones_Pendientes = Comisiones_Pendientes - 1 WHERE ID = @UsuarioID
			ELSE --Es Empresa
				UPDATE LOL.tl_Empresas SET Comisiones_Pendientes = Comisiones_Pendientes - 1 WHERE ID = @UsuarioID
		END

END
GO

CREATE TRIGGER LOL.tr_ClientesAfterUpdate
   ON  LOL.tl_Clientes
   AFTER UPDATE
AS 
BEGIN
	DECLARE @ID						INT;
	DECLARE @ComisionesPendientes	INT;
	DECLARE @EstadoPausadaID		INT;

	SET NOCOUNT ON;

    SELECT @ID = ID, @ComisionesPendientes = Comisiones_Pendientes FROM INSERTED
	IF (@ComisionesPendientes > 10)
		BEGIN
			SELECT @EstadoPausadaID = ID FROM LOL.tl_Publicacion_Estados WHERE Estado = 'Pausada'

			UPDATE LOL.tl_Clientes SET Habilitado = 0 WHERE ID = @ID
			UPDATE LOL.tl_Usuarios_Roles SET Habilitado = 0 WHERE Usuario_ID = @ID AND Rol_ID = 2
			UPDATE LOL.tl_Publicaciones SET Estado_ID = @EstadoPausadaID WHERE Usuario_ID = @ID
		END

END
GO

CREATE TRIGGER LOL.tr_EmpresasAfterUpdate
   ON  LOL.tl_Empresas
   AFTER UPDATE
AS 
BEGIN
	DECLARE @ID						INT;
	DECLARE @ComisionesPendientes	INT;
	DECLARE @EstadoPausadaID		INT;

	SET NOCOUNT ON;

    SELECT @ID = ID, @ComisionesPendientes = Comisiones_Pendientes FROM INSERTED
	IF (@ComisionesPendientes > 10)
		BEGIN
			SELECT @EstadoPausadaID = ID FROM LOL.tl_Publicacion_Estados WHERE Estado = 'Pausada'

			UPDATE LOL.tl_Empresas SET Habilitada = 0 WHERE ID = @ID
			UPDATE LOL.tl_Usuarios_Roles SET Habilitado = 0 WHERE Usuario_ID = @ID AND Rol_ID = 3
			UPDATE LOL.tl_Publicaciones SET Estado_ID = @EstadoPausadaID WHERE Usuario_ID = @ID
		END

END
GO

CREATE TRIGGER LOL.tr_VisibilidadesAfterInsert
   ON  LOL.tl_Visibilidades
   AFTER INSERT
AS 
BEGIN
	DECLARE @Codigo INT
	
	SET NOCOUNT ON;

    SELECT @Codigo = Codigo FROM INSERTED;
	
    INSERT INTO LOL.tl_Usuarios_Visibilidades_Ventas(Usuario_ID,Visibilidad_Codigo)
		SELECT ID,@Codigo FROM LOL.tl_Usuarios

END
GO

CREATE TRIGGER LOL.tr_UsuariosAfterInsert
   ON  LOL.tl_Usuarios
   AFTER INSERT
AS 
BEGIN
	DECLARE @ID INT;

	SET NOCOUNT ON;

	SELECT @ID = ID FROM INSERTED;
	
    INSERT INTO LOL.tl_Usuarios_Visibilidades_Ventas(Usuario_ID,Visibilidad_Codigo)
		SELECT @ID,Codigo FROM LOL.tl_Visibilidades

END
GO

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

/* Stored Procedure PaginadorParaEditar */
CREATE PROCEDURE [LOL].[sp_PaginadorParaEditar]
	@UsuarioID INT,
	@Inicio INT,
	@QtyRegistros INT,
	@TotalRegistros INT OUT
AS
BEGIN
	SET NOCOUNT ON;

    WITH Results AS
	(
		SELECT
			ROW_NUMBER() OVER (ORDER BY V.Precio DESC) AS RowNum,
			P.Codigo, P.Usuario_ID, P.Descripcion, P.Fecha,
			P.Stock, P.Fecha_Vencimiento, P.Precio, T.Tipo, 
			V.Codigo AS Visibilidad_Codigo, V.Descripcion AS Visibilidad_Descripcion, 
			E.Estado, P.Permite_Preguntas
		FROM
			LOL.tl_Publicaciones P INNER JOIN
			LOL.tl_Publicacion_Tipos T ON P.Tipo_ID = T.ID INNER JOIN
			LOL.tl_Publicacion_Estados E ON P.Estado_ID = E.ID INNER JOIN
			LOL.tl_Visibilidades V ON P.Visibilidad_Codigo = V.Codigo
        WHERE
			P.Usuario_ID = @UsuarioID
	)

	SELECT Codigo, Usuario_ID, Descripcion, Fecha,
			Stock, Fecha_Vencimiento, Precio, Tipo, 
			Visibilidad_Codigo, Visibilidad_Descripcion, 
			Estado, Permite_Preguntas 
	FROM Results
	WHERE RowNum BETWEEN @Inicio AND @Inicio + @QtyRegistros -1;

	SELECT @TotalRegistros = COUNT(0) 
	FROM
		LOL.tl_Publicaciones P INNER JOIN
		LOL.tl_Publicacion_Tipos T ON P.Tipo_ID = T.ID INNER JOIN
		LOL.tl_Publicacion_Estados E ON P.Estado_ID = E.ID INNER JOIN
		LOL.tl_Visibilidades V ON P.Visibilidad_Codigo = V.Codigo
    WHERE
		P.Usuario_ID = @UsuarioID;
END
GO

/* Stored Procedure PaginadorParaComprar */
CREATE PROCEDURE [LOL].[sp_PaginadorParaComprar]
	@Usuario_ID INT,
	@Descripcion VARCHAR(50),
	@Rubro_ID INT,
	@FechaActual DATETIME,
	@Inicio INT,
	@QtyRegistros INT,
	@TotalRegistros INT OUT
AS
BEGIN
	SET NOCOUNT ON;

	WITH Results AS 
	(
		SELECT     
			ROW_NUMBER() OVER (ORDER BY V.Precio DESC) AS RowNum,
			P.Codigo, P.Usuario_ID, P.Descripcion, P.Fecha, P.Stock, P.Fecha_Vencimiento, P.Precio, T.Tipo, V.Codigo AS Visibilidad_Codigo, 
			V.Descripcion AS Visibilidad_Descripcion, E.Estado, P.Permite_Preguntas
		FROM
			LOL.tl_Publicaciones AS P INNER JOIN
			LOL.tl_Publicacion_Tipos AS T ON P.Tipo_ID = T.ID INNER JOIN
			LOL.tl_Publicacion_Estados AS E ON P.Estado_ID = E.ID INNER JOIN
			LOL.tl_Visibilidades AS V ON P.Visibilidad_Codigo = V.Codigo INNER JOIN
			LOL.tl_Publicaciones_Rubros AS PR ON P.Codigo = PR.Publicacion_Codigo
		WHERE
			(P.Usuario_ID <> @Usuario_ID) AND (P.Descripcion LIKE '%' + @Descripcion + '%') AND
			(PR.Rubro_ID = @Rubro_ID) AND (E.Estado = 'Publicada') AND (P.Fecha_Vencimiento >= @FechaActual)
	)

	SELECT Codigo, Usuario_ID, Descripcion, Fecha,
			Stock, Fecha_Vencimiento, Precio, Tipo, 
			Visibilidad_Codigo, Visibilidad_Descripcion, 
			Estado, Permite_Preguntas 
	FROM Results
	WHERE RowNum BETWEEN @Inicio AND @Inicio + @QtyRegistros -1
	
	SELECT @TotalRegistros = COUNT(0) 
	FROM
		LOL.tl_Publicaciones AS P INNER JOIN
		LOL.tl_Publicacion_Tipos AS T ON P.Tipo_ID = T.ID INNER JOIN
		LOL.tl_Publicacion_Estados AS E ON P.Estado_ID = E.ID INNER JOIN
		LOL.tl_Visibilidades AS V ON P.Visibilidad_Codigo = V.Codigo INNER JOIN
		LOL.tl_Publicaciones_Rubros AS PR ON P.Codigo = PR.Publicacion_Codigo
	WHERE
		(P.Usuario_ID <> @Usuario_ID) AND (P.Descripcion LIKE '%' + @Descripcion + '%') AND
		(PR.Rubro_ID = @Rubro_ID) AND (E.Estado = 'Publicada') AND (P.Fecha_Vencimiento >= @FechaActual)
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
CREATE PROCEDURE [LOL].[sp_TryLogin] @user VARCHAR(50),
                                 	@pass VARCHAR(50),
	                             	@ID INT OUT,
	                             	@ChangePassword BIT OUT

AS
BEGIN
	DECLARE @tl_pass VARCHAR(50);
	DECLARE @tl_ID INT;
	DECLARE @tl_Habilitado INT;
	DECLARE @tl_ChangePassword BIT;
	DECLARE @error NVARCHAR(255);

	SET NOCOUNT ON;

	SELECT @tl_pass = U.Password,@tl_ID = U.ID, @tl_Habilitado = U.Habilitado , @tl_ChangePassword = Change_Password FROM LOL.tl_Usuarios U WHERE Username = @user

	
	IF (@tl_pass IS NULL)
		 -- NO EXISTE EL USUARIO
		BEGIN
			SET @ID = -3;
			SET @error = 'Usuario inexistente.'
    			RAISERROR (@error, 11,1)
    			RETURN -1
	    	END
	ELSE
		IF (@tl_ChangePassword = 1)
			BEGIN
				EXEC LOL.sp_LoginExitoso @user;
				SET @ID = @tl_ID;
				SET @ChangePassword = @tl_ChangePassword;
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
						SET @ChangePassword = @tl_ChangePassword;
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

/* Stored Procedure InsertarPendientes */
CREATE PROCEDURE LOL.sp_InsertarPendiente
	@Fecha DATETIME,
	@Publicacion_Codigo INT,
	@Compra_ID INT = NULL
AS
BEGIN
	DECLARE @Visibilidad_Codigo INT;
	DECLARE @Vendedor_ID INT;
	DECLARE @Monto_Publicacion MONEY;
	DECLARE @Monto MONEY;
	DECLARE @QtyVentas INT;
	DECLARE @Porcentaje_Visibilidad NUMERIC(18,2);
	DECLARE @QtyVendida INT;
	
	SET NOCOUNT ON;

	SELECT 
		@Visibilidad_Codigo = Visibilidad_Codigo, @Vendedor_ID = Usuario_ID, @Monto_Publicacion = Precio
	FROM LOL.tl_Publicaciones WHERE Codigo = @Publicacion_Codigo;

    IF (@Compra_ID IS NULL) -- Pendiente por Publicar
		BEGIN
			SELECT @Monto = Precio FROM LOL.tl_Visibilidades WHERE Codigo = @Visibilidad_Codigo;
			INSERT INTO LOL.tl_Pendientes(Fecha,Monto,Publicacion_Codigo) VALUES (@Fecha,@Monto,@Publicacion_Codigo);
		END
	ELSE -- Pendiente Por Compra
		BEGIN
			SELECT @QtyVentas = Cantidad_Ventas FROM LOL.tl_Usuarios_Visibilidades_Ventas WHERE Usuario_ID = @Vendedor_ID AND Visibilidad_Codigo = @Visibilidad_Codigo
			IF (@QtyVentas = 9) -- La venta es bonificada
				UPDATE LOL.tl_Usuarios_Visibilidades_Ventas SET Cantidad_Ventas = 0 WHERE Usuario_ID = @Vendedor_ID AND Visibilidad_Codigo = @Visibilidad_Codigo;
			ELSE
				BEGIN
					SELECT @QtyVendida = Cantidad FROM LOL.tl_Compras WHERE ID = @Compra_ID;
					SELECT @Porcentaje_Visibilidad = Porcentaje FROM LOL.tl_Visibilidades WHERE Codigo = @Visibilidad_Codigo;
					SET @Monto = @QtyVendida * @Porcentaje_Visibilidad * @Monto_Publicacion;
					INSERT INTO LOL.tl_Pendientes(Fecha,Monto,Publicacion_Codigo,Compra_ID) VALUES
						(@Fecha,@Monto,@Publicacion_Codigo,@Compra_ID);
					UPDATE LOL.tl_Usuarios_Visibilidades_Ventas SET Cantidad_Ventas = Cantidad_Ventas + 1 WHERE Usuario_ID = @Vendedor_ID AND Visibilidad_Codigo = @Visibilidad_Codigo;
				END
		END
END
GO

/* Stored Procedure CrearPublicacion*/
CREATE PROCEDURE LOL.sp_CrearPublicacion 
	--@Cliente_ID INT = NULL,
	--@Empresa_ID INT = NULL,
	@Usuario_ID			INT,
	@descripcion		nvarchar(255),
	@fecha				datetime,
	@stock				numeric(18, 0),
	@fecha_vencimiento	datetime,
	@precio				money,
	@tipo_ID			INT,
	@visibilidad_Codigo	numeric(18, 0),
	@estado_ID			INT,
	@permite_Preguntas	bit,
	@ID					int OUT,
	@fechaPendiente		datetime,
	@monto				money
AS
BEGIN
	DECLARE @QtyPublicacionGratuitasActivas INT;
	DECLARE @Error NVARCHAR(255);

	IF (@visibilidad_Codigo = 10006)
		BEGIN
			
			SELECT @QtyPublicacionGratuitasActivas = COUNT(0) FROM LOL.tl_Publicaciones WHERE Usuario_ID = @Usuario_ID AND Visibilidad_Codigo = 10006 AND Estado_ID IN (1,2)--Publicada,Pausada
			IF (@QtyPublicacionGratuitasActivas >= 3)
				BEGIN
					SET @error = 'Tiene 3 o mas Publicaciones Gratuitas Activas';
					RAISERROR (@error, 11,1)
    				RETURN -1
				END
		END

	INSERT INTO LOL.tl_Publicaciones 
		(Usuario_ID,Descripcion, Fecha, Stock,Fecha_Vencimiento, Precio,
		 Tipo_ID, Visibilidad_Codigo, Estado_ID, Permite_Preguntas) 
		VALUES
			(@Usuario_ID,@descripcion,@fecha,@stock,@fecha_vencimiento,@precio,@tipo_ID,@visibilidad_Codigo,
			 @estado_ID,@permite_preguntas)
			 
	 -- Esto devuelve el valor de ID de publicación creado en este caso
	SELECT @ID = @@IDENTITY

	--INSERT INTO LOL.tl_Pendientes (Fecha, Monto, Publicacion_Codigo) VALUES (@fechaPendiente,@monto,@ID)
    EXEC LOL.sp_InsertarPendiente @fechaPendiente,@ID,NULL;

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
	@Telefono INT,
	@Habilitado BIT
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
	IF (@UserPassword <> '') -- Es creado por el Administrador
		BEGIN
			INSERT INTO LOL.tl_Usuarios(Username,Password,Change_Password) VALUES (@Nro_Documento,@UserPassword,1)
			SELECT @ID = @@IDENTITY
			INSERT INTO LOL.tl_Usuarios_Roles VALUES(@ID,2,1)
		END
	IF (@isNew = 1)
		INSERT INTO LOL.tl_Clientes (ID,Tipo_Documento,Nro_Documento,CUIL,Apellido,Nombre,Fecha_Nac,Mail,Dom_Calle,Nro_Calle,Piso,Depto,Cod_Postal,Telefono)
		VALUES(
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
			@Telefono)
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
			Telefono = @Telefono,
			Habilitado = @Habilitado
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
	@CodPostal NVARCHAR(50) = NULL,
	@Habilitada BIT
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
	IF (@UserPassword <> '') -- Es creada por el Administrador
		BEGIN
			INSERT INTO LOL.tl_Usuarios(Username,Password,Change_Password) VALUES (@CUIT,@UserPassword,1)
			SELECT @ID = @@IDENTITY
			INSERT INTO LOL.tl_Usuarios_Roles VALUES (@ID,3,1)
		END
	IF (@isNew = 1)
		INSERT INTO LOL.tl_Empresas (ID,Razon_Social,CUIT,Fecha_Creacion,Mail,Dom_Calle,Nro_Calle,Piso,Depto,Cod_Postal)
		VALUES(
			@ID,
			@Razon_Social,
			@CUIT,
			@FechaCreacion,
			@Mail,
			@DomCalle,
			@NroCalle,
			@Piso,
			@Depto,
			@CodPostal)
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
			Cod_Postal = @CodPostal,
			Habilitada = @Habilitada
		WHERE
			ID = @ID
	COMMIT

END
GO

/* Stored Procedure CalificarVendedor*/
CREATE PROCEDURE [LOL].[sp_CalificarVendedor]
	@CompraID INT,
	@CantidadEstrellas TINYINT,
	@Descripcion NVARCHAR(255) = NULL
AS
BEGIN
	--DECLARE @ClienteID INT;
	--DECLARE @EmpresaID INT;
	DECLARE @CompradorID	INT;
	DECLARE @UsuarioID		INT;
	--DECLARE @NewCalificacionCodigo	INT;

	SET NOCOUNT ON;

	SELECT 
		@UsuarioID = P.Usuario_ID
	FROM 
		(SELECT Publicacion_Codigo FROM LOL.tl_Compras WHERE (ID = @CompraID)) C JOIN LOL.tl_Publicaciones P ON (C.Publicacion_Codigo = P.Codigo)

	--SELECT @NewCalificacionCodigo = MAX(Calificacion_Codigo) + 1 FROM LOL.tl_Compras WHERE Calificacion_Codigo IS NOT NULL

	BEGIN TRANSACTION;
		INSERT INTO 
			LOL.tl_Calificaciones
		VALUES(
			@CompraID, @CantidadEstrellas, @Descripcion
		)

		IF EXISTS(SELECT 0 FROM LOL.tl_Clientes WHERE ID = @UsuarioID) --Es Cliente
			UPDATE LOL.tl_Clientes 
			SET Suma_Calificaciones = Suma_Calificaciones + @CantidadEstrellas, Cantidad_Calificaciones = Cantidad_Calificaciones + 1
			WHERE ID = @UsuarioID;
		ELSE --Es Empresa
			UPDATE LOL.tl_Empresas
			SET Suma_Calificaciones = Suma_Calificaciones + @CantidadEstrellas, Cantidad_Calificaciones = Cantidad_Calificaciones + 1
			WHERE ID = @UsuarioID;

		SELECT @CompradorID = Usuario_ID FROM LOL.tl_Compras WHERE ID = @CompraID
		UPDATE LOL.tl_Usuarios SET Calificaciones_Pendientes = Calificaciones_Pendientes - 1 WHERE ID = @CompradorID

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
		P.Usuario_ID AS 'Codigo de usuario',
		SUM(P.Stock) AS 'Productos sin vender'
	FROM
		LOL.tl_Publicaciones P
	WHERE
		YEAR(P.Fecha) = @anio AND
		(MONTH(P.Fecha) BETWEEN @trimestre AND (@trimestre+2)) AND
		(MONTH(P.Fecha) = (@trimestre + @mes) OR @mes IS NULL) AND
		(P.Visibilidad_Codigo = @visibilidad_codigo OR @visibilidad_codigo IS NULL)
	GROUP BY (P.Usuario_ID)
	ORDER BY 2 DESC

END
GO

/* Stored Procedure InsertarUsuario */
CREATE PROCEDURE [LOL].[sp_InsertarUsuario]
	@Username NVARCHAR(255),
	@Password NVARCHAR(255),
	@ID INT OUT
AS
BEGIN
	DECLARE @error varchar(255);
	SET NOCOUNT ON;

	IF EXISTS(SELECT Username FROM LOL.tl_Usuarios WHERE Username = @Username)
		BEGIN
			SET @error = 'Username Existente';
			RAISERROR (@error, 11,1);
    		RETURN -1;
		END
	INSERT INTO LOL.tl_Usuarios (Username,Password) VALUES (@Username,@Password)
	SELECT @ID = @@IDENTITY
	
END
GO

CREATE PROCEDURE [LOL].[sp_crearCompra]
	@Publicacion_Codigo	int,
	@Usuario_ID			int,
	@fecha				date,
	@Cantidad			INT,
	@fechaPendiente		date,
	@montoVisibilidad	money
	--PUB CODIGO Y COMPRA ID YA LO TENGO!
	--@ID INT OUT
AS
BEGIN
	DECLARE @ID INT;

	BEGIN TRAN
		INSERT INTO LOL.tl_Compras (Publicacion_Codigo, Usuario_ID, Cantidad, Fecha) VALUES
		(@Publicacion_Codigo, @Usuario_ID, @Cantidad, @fecha)
		SELECT @ID = @@IDENTITY
		
		--INSERT INTO LOL.tl_Pendientes (Fecha, Monto, Publicacion_Codigo, Compra_ID) VALUES (@fecha, @montoVisibilidad, @Publicacion_Codigo, @ID)
		EXEC LOL.sp_InsertarPendiente @fecha,@Publicacion_Codigo,@ID;

		IF EXISTS(SELECT * FROM LOL.tl_Publicaciones WHERE Codigo = @Publicacion_Codigo AND Stock = @Cantidad) --Se vendio todo el stock de la Publicacion
			UPDATE LOL.tl_Publicaciones set Stock = 0, Estado_ID = 4 WHERE Codigo = @Publicacion_Codigo
		ELSE
			UPDATE LOL.tl_Publicaciones set Stock = Stock - @Cantidad where Codigo = @Publicacion_Codigo

		UPDATE LOL.tl_Usuarios SET Calificaciones_Pendientes = Calificaciones_Pendientes + 1 WHERE ID = @Usuario_ID

	COMMIT

END
GO

CREATE PROCEDURE [LOL].[sp_crearOferta]
	@Publicacion_Codigo	int,
	@Usuario_ID			int,
	@fecha				date,
	@Monto				money
AS
BEGIN
	--DECLARE @ID INT;

	INSERT INTO LOL.tl_Ofertas (Publicacion_Codigo, Usuario_ID, Fecha, Monto) VALUES
	(@Publicacion_Codigo, @Usuario_ID, @fecha, @Monto)	
		
END
GO

CREATE PROCEDURE [LOL].[sp_editarPublicacion]
	@Publicacion_Codigo	INT,
	@Descripcion		NVARCHAR(255),
	@Fecha				DATETIME,
	@stock				NUMERIC(18, 0),
	@Fecha_Vencimiento	DATETIME,
	@precio				MONEY,
	@tipo_ID			INT,
	@visibilidad_Codigo	NUMERIC(18, 0),
	@Estado_ID			INT,
	@preguntas			BIT
	
AS
BEGIN
	
	UPDATE LOL.tl_Publicaciones
	SET
		Descripcion = @descripcion,
		Fecha = @Fecha,
		Stock = @stock,
		Fecha_Vencimiento = @Fecha_Vencimiento,
		Precio = @precio,
		Tipo_ID = @tipo_ID,
		Visibilidad_Codigo = @visibilidad_Codigo,
		Estado_ID = @Estado_ID,
		Permite_Preguntas = @preguntas
	WHERE Codigo = @Publicacion_Codigo

END
GO

/* Stored Procedure sp_InsertarFactura */
CREATE PROCEDURE LOL.sp_InsertarFactura
	@Fecha				DATETIME,
	@PagoDescripcion	NVARCHAR(255),
	@Nro				INT OUT
AS
BEGIN
	DECLARE @error varchar(255);
	SET NOCOUNT ON;

	INSERT INTO LOL.tl_Facturas (Fecha,Pago_Descripcion) VALUES (@Fecha,@PagoDescripcion)
	SELECT @Nro = @@IDENTITY

END
GO

/* sp_InsertarFacturaItem */
CREATE PROCEDURE [LOL].[sp_InsertarFacturaItem]
	@FacturaNro INT,
	@PendienteID INT
AS
BEGIN

	INSERT INTO LOL.tl_Facturas_Items 
		SELECT @FacturaNro, 0, Monto,Publicacion_Codigo,Compra_ID FROM LOL.tl_Pendientes WHERE ID = @PendienteID

	DELETE FROM LOL.tl_Pendientes WHERE ID = @PendienteID
	
END
GO

/* sp_RegistrarFinalizacionSubasta */
CREATE PROCEDURE LOL.sp_RegistrarFinalizacionSubasta
	@PublicacionCodigo	INT,
	@Fecha				DATE,
	@Precio				NUMERIC(18,2),
	@VisibilidadCodigo	INT
AS
BEGIN
	DECLARE @UsuarioID	INT;
	DECLARE @CompraID	INT;
	DECLARE @Porcentaje	NUMERIC(18,2);

	SET NOCOUNT ON;
	--Marco la Oferta mas alta como Ganadora
    UPDATE 
		LOL.tl_Ofertas 
	SET 
		Ganadora = 1 
	FROM 
		LOL.tl_Ofertas O 
			JOIN (SELECT Publicacion_Codigo, MAX(Monto) Monto FROM LOL.tl_Ofertas GROUP BY Publicacion_Codigo) AS Ganadoras
			ON Ganadoras.Publicacion_Codigo = @PublicacionCodigo AND O.Monto = Ganadoras.Monto
	-- Obtengo el Usuario_ID del que hizo la oferta Ganadora
	SELECT @UsuarioID = Usuario_ID FROM LOL.tl_Ofertas WHERE Publicacion_Codigo = @PublicacionCodigo AND Ganadora = 1
	--Registro la Compra
	INSERT INTO LOL.tl_Compras(Publicacion_Codigo,Usuario_ID,Cantidad,Fecha)
	VALUES (@PublicacionCodigo,@UsuarioID,1,@Fecha)
	--Obtengo el ID de la Compra
	SELECT @CompraID = @@IDENTITY
	--Sumo Calificaciones_Pendientes al Usuario
	UPDATE LOL.tl_Usuarios SET Calificaciones_Pendientes = Calificaciones_Pendientes + 1 WHERE ID = @UsuarioID
	--Obtengo el Porcentaje segun el Codigo de Visibilidad
	SELECT @Porcentaje = Porcentaje FROM LOL.tl_Visibilidades WHERE Codigo = @VisibilidadCodigo
	--Agrego un registro en la tabla de Pendientes
	--INSERT INTO LOL.tl_Pendientes (Fecha,Monto,Publicacion_Codigo,Compra_ID) VALUES (@Fecha,@Precio * @Porcentaje,@PublicacionCodigo,@CompraID)
	EXEC LOL.sp_InsertarPendiente @Fecha,@PublicacionCodigo,@CompraID;

END
GO

CREATE FUNCTION LOL.calificacionesPendientesDeUsuario (@usuarioID int)
RETURNS int
AS
BEGIN
	DECLARE @sinCalif int
	SELECT
		@sinCalif = COUNT(*)
	FROM
		(
			SELECT
				ID, Publicacion_Codigo, Usuario_ID, Cantidad, Fecha, Comision_Pagada
			FROM
				LOL.tl_Compras
			WHERE
				(ID NOT IN (
					SELECT
						Compra_ID
                    FROM
						LOL.tl_Calificaciones)
				) AND
				(Usuario_ID = 94)
		) AS aux
		RETURN @sinCalif
END

