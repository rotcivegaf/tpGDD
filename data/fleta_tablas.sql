/*Cada vez que creamos algo, actualizamos este archivo, de tal forma que
 *siempre este listo para usarse para resetear toda la db */

--Eliminar Tablas
DROP TABLE LOL.tl_roles_funcionalidades
DROP TABLE LOL.tl_publicaciones_rubros
DROP TABLE LOL.tl_rubros
DROP TABLE LOL.tl_usuarios_roles
DROP TABLE LOL.tl_usuarios
DROP TABLE LOL.tl_roles
DROP TABLE LOL.tl_preguntas
DROP TABLE LOL.tl_pendientes
DROP TABLE LOL.tl_facturas_items
DROP TABLE LOL.tl_facturas
DROP TABLE LOL.tl_funcionalidades
DROP TABLE LOL.tl_ofertas
DROP TABLE LOL.tl_compras
DROP TABLE LOL.tl_publicaciones
DROP TABLE LOL.tl_visibilidades
DROP TABLE LOL.tl_empresas
DROP TABLE LOL.tl_clientes

--Eliminar Procedimientos de migracion
DROP PROCEDURE LOL.sp_ImportarClientes
DROP PROCEDURE LOL.sp_ImportarEmpresas
DROP PROCEDURE LOL.sp_ImportarFacturas
DROP PROCEDURE LOL.sp_ImportarPublicaciones
DROP PROCEDURE LOL.sp_ImportarRubros
DROP PROCEDURE LOL.sp_ImportarVisibilidades
DROP PROCEDURE LOL.sp_InicializarFuncionalidades
DROP PROCEDURE LOL.sp_InicializarRoles
DROP PROCEDURE LOL.sp_InicializarUsuarioAdmin
DROP PROCEDURE LOL.sp_ImportarCompras
DROP PROCEDURE LOL.sp_InicializarCalificacionesClientes
DROP PROCEDURE LOL.sp_InicializarCalificacionesEmpresas
DROP PROCEDURE LOL.sp_ImportarOfertas


--Eliminar Procedimientos de aplicacion
DROP PROCEDURE LOL.sp_NuevaVisibilidad
DROP PROCEDURE LOL.sp_EditarVisibilidad
DROP PROCEDURE LOL.sp_BorrarVisibilidad
DROP PROCEDURE LOL.sp_TryLogin
DROP PROCEDURE LOL.sp_LoginFallido
DROP PROCEDURE LOL.sp_LoginExitoso
DROP PROCEDURE LOL.sp_CrearPublicacion
DROP PROCEDURE LOL.sp_InsertPublicacionRubro 
--DROP PROCEDURE LOL.sp_InsertarCliente
DROP PROCEDURE LOL.sp_GuardarCliente
DROP PROCEDURE LOL.sp_GuardarEmpresa
DROP PROCEDURE LOL.sp_Paginador
DROP PROCEDURE LOL.sp_CalificarVendedor
DROP PROCEDURE LOL.sp_VendedoresConMasStock
DROP PROCEDURE LOL.sp_InsertarUsuario
DROP PROCEDURE LOL.sp_crearCompra
DROP PROCEDURE LOL.sp_crearOferta
DROP PROCEDURE LOL.sp_editarPublicacion
DROP PROCEDURE LOL.sp_InsertarFactura

--Eliminar Tipo de dato
DROP TYPE LOL.dataTable

--Eliminar esquema
DROP SCHEMA LOL
