DELIMITER $$
	CREATE PROCEDURE insertarGeneros(IN nombre varchar(20))
	BEGIN
		INSERT INTO generos VALUES(DEFAULT, nombre);
	END$$

DELIMITER $$
CREATE PROCEDURE insertarPelicula(IN nombre varchar(20), descripcion varchar(300), imagen BLOB)
BEGIN
	INSERT INTO peliculas VALUES(DEFAULT,nombre,descripcion,imagen);
END$$

DELIMITER $$
CREATE PROCEDURE insertarActor(IN nombre varchar(50))
BEGIN
    INSERT INTO actores VALUES(DEFAULT,nombre);
END $$

DELIMITER $$
CREATE PROCEDURE insertarDirector(IN nombre varchar(50))
BEGIN
    INSERT INTO directores VALUES(DEFAULT,nombre);
END $$

DELIMITER $$
CREATE PROCEDURE insertarPlataforma(nombre varchar(50))
BEGIN
    INSERT INTO plataformas VALUES(DEFAULT,nombre);
END $$

DELIMITER $$
CREATE PROCEDURE insertarTipo(IN nombre varchar(13))
BEGIN
    INSERT INTO tipos VALUES(DEFAULT,nombre);
END $$

DELIMITER $$
CREATE PROCEDURE insertarDistribucion(IN precio int,calidad varchar(5),tipo int)
BEGIN
    INSERT INTO distribuciones VALUES(DEFAULT,precio,calidad,tipo);
END $$

DELIMITER $$
CREATE PROCEDURE insertarUsuario(IN nombre varchar(20) , contrasena varchar (20))
BEGIN
    INSERT INTO usuarios VALUES(DEFAULT,nombre,contrasena);
END $$

DELIMITER $$
CREATE PROCEDURE insertarComentario(IN idUsuario int,comentario varchar(300), idPelicula int)
BEGIN
    INSERT INTO comentarios VALUES(DEFAULT,idUsuario,comentario,idPelicula);
END $$

DELIMITER $$
CREATE PROCEDURE insertarInterpretes(IN idActor int,idPelicula int)
BEGIN
    INSERT INTO directores VALUES(DEFAULT,idActor,idPelicula);
END $$

DELIMITER $$
CREATE PROCEDURE insertarCordinadores(IN idPelicula int,idDirector int)
BEGIN
    INSERT INTO directores VALUES(DEFAULT,idPelicula ,idDirector);
END $$

DELIMITER $$
CREATE PROCEDURE insertarContine(IN idPelicula int,idGenero int)
BEGIN
    INSERT INTO directores VALUES(DEFAULT,idPelicula ,idGenero);
END $$

DELIMITER $$
CREATE PROCEDURE insertarServicios(IN idPlataforma int, idDistribucion int)
BEGIN
    INSERT INTO directores VALUES(DEFAULT,idPlataforma ,idDistribucion);
END $$

DELIMITER $$
CREATE PROCEDURE insertarCategoria(IN idPelicula int,idGenero int)
BEGIN
    INSERT INTO directores VALUES(DEFAULT,idPelicula ,idGenero);
END $$