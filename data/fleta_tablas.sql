/*Cada vez que creamos algo, actualizamos este archivo, de tal forma que
 *siempre este listo para usarse para resetear toda la db */

--Eliminar Tablas
DROP TABLE LOL.tl_Roles_Funcionalidades
DROP TABLE LOL.tl_Usuarios_Roles
DROP TABLE LOL.tl_Roles
DROP TABLE LOL.tl_Respuestas
DROP TABLE LOL.tl_Preguntas
DROP TABLE LOL.tl_Pendientes
DROP TABLE LOL.tl_Facturas_Items
DROP TABLE LOL.tl_Facturas
DROP TABLE LOL.tl_Funcionalidades
DROP TABLE LOL.tl_Ofertas
DROP TABLE LOL.tl_Calificaciones
DROP TABLE LOL.tl_Compras
DROP TABLE LOL.tl_Empresas
DROP TABLE LOL.tl_Clientes
DROP TABLE LOL.tl_Publicaciones_Rubros
DROP TABLE LOL.tl_Rubros
DROP TABLE LOL.tl_Publicaciones
DROP TABLE LOL.tl_Publicacion_Tipos
DROP TABLE LOL.tl_Publicacion_Estados
DROP TABLE LOL.tl_Usuarios_Visibilidades_Ventas
DROP TABLE LOL.tl_Visibilidades
DROP TABLE LOL.tl_Usuarios

--Eliminar Procedimientos de migracion
DROP PROCEDURE LOL.sp_ImportarClientes
DROP PROCEDURE LOL.sp_ImportarEmpresas
DROP PROCEDURE LOL.sp_ImportarFacturas
DROP PROCEDURE LOL.sp_ImportarPublicacionTipos
DROP PROCEDURE LOL.sp_ImportarPublicacionEstados
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
DROP PROCEDURE LOL.sp_InicializarUsuariosVisibilidadesVentas

--Eliminar Procedimientos de aplicacion
DROP PROCEDURE LOL.sp_NuevaVisibilidad
DROP PROCEDURE LOL.sp_EditarVisibilidad
DROP PROCEDURE LOL.sp_BorrarVisibilidad
DROP PROCEDURE LOL.sp_TryLogin
DROP PROCEDURE LOL.sp_LoginFallido
DROP PROCEDURE LOL.sp_LoginExitoso
DROP PROCEDURE LOL.sp_CrearPublicacion
DROP PROCEDURE LOL.sp_InsertPublicacionRubro 
DROP PROCEDURE LOL.sp_GuardarCliente
DROP PROCEDURE LOL.sp_GuardarEmpresa
DROP PROCEDURE LOL.sp_PaginadorParaComprar
DROP PROCEDURE LOL.sp_PaginadorParaEditar
DROP PROCEDURE LOL.sp_CalificarVendedor
DROP PROCEDURE LOL.sp_VendedoresConMasStock
DROP PROCEDURE LOL.sp_InsertarUsuario
DROP PROCEDURE LOL.sp_crearCompra
DROP PROCEDURE LOL.sp_crearOferta
DROP PROCEDURE LOL.sp_editarPublicacion
DROP PROCEDURE LOL.sp_InsertarFactura
DROP PROCEDURE LOL.sp_InsertarFacturaItem
DROP PROCEDURE LOL.sp_RegistrarFinalizacionSubasta
DROP PROCEDURE LOL.sp_InsertarPendiente
DROP FUNCTION LOL.calificacionesPendientesDeUsuario

--Eliminar esquema
DROP SCHEMA LOL
