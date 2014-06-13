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

--Eliminar esquema
DROP SCHEMA LOL
