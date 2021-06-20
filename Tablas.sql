CREATE database ni5508816_1_DB;
use ni5508816_1_DB;
-- TABLAS INDEPENDIENTES
CREATE TABLE generos
(
idGenero int not null auto_increment,
nombreGenero varchar(20),
primary key(idgenero)
);
CREATE TABLE peliculas
(
idPelicula INT NOT NULL AUTO_INCREMENT,
nombrePelicula varchar(50),
descripcionPelicula varchar(500),
PRIMARY KEY (idPelicula)
);
CREATE TABLE actores
(
idActor INT NOT NULL AUTO_INCREMENT,
nombreActor varchar(50),
PRIMARY KEY (idActor)
);
CREATE TABLE directores
(
idDirector INT NOT NULL AUTO_INCREMENT,
nombreDirector varchar(50),
PRIMARY KEY (idDirector)
);
CREATE TABLE plataformas
(
idPlataforma INT NOT NULL AUTO_INCREMENT,
nombrePlataforma varchar(50),
PRIMARY KEY (idPlataforma)
);
CREATE TABLE tipos
(
idTipo INT NOT NULL AUTO_INCREMENT,
nombreTipo varchar(13),
PRIMARY KEY (idTipo)
);
CREATE TABLE distribuciones
(
idDistribucion INT NOT NULL AUTO_INCREMENT,
precioDistribucion int,
calidadDistribucion varchar(5),
idTipo int,
FOREIGN KEY(idTipo) REFERENCES tipos(idTipo),
PRIMARY KEY (idDistribucion)
);
CREATE TABLE usuarios
(
	idUsuario int not null auto_increment,
    nombreUsuario varchar(20),
    contraseñaUsuario varchar(20),
    PRIMARY KEY (idUsuario)
);
CREATE TABLE comentarios
(
idUsuario int not null auto_increment,
comentario varchar(300),
idPelicula int,
FOREIGN KEY(idUsuario) REFERENCES usuarios(idusuario),
FOREIGN KEY(idPelicula) REFERENCES peliculas(idPelicula)
);
-- TABLAS DEPENDIENTES
CREATE TABLE interpretes
(
idActor int not null,
idPelicula int not null,
FOREIGN KEY(idActor) REFERENCES actores(idActor),
FOREIGN KEY(idPelicula) REFERENCES peliculas(idPelicula)
);
CREATE TABLE cordinadores
(
idPelicula int not null,
idDirector int not null,
FOREIGN KEY(idPelicula) REFERENCES peliculas(idPelicula),
FOREIGN KEY(idDirector) REFERENCES directores(idDirector)
);
CREATE TABLE contiene
(
idPelicula int not null,
idPlataforma int not null,
FOREIGN KEY(idPelicula) REFERENCES peliculas(idPelicula),
FOREIGN KEY(idPlataforma) REFERENCES plataformas(idPlataforma)
);
CREATE TABLE servicios
(
idPlataforma int not null,
idDistribucion int not null,
FOREIGN KEY(idPlataforma) REFERENCES plataformas(idPlataforma),
FOREIGN KEY(idDistribucion) REFERENCES distribuciones(idDistribucion)
);
CREATE TABLE categorias
(
idPelicula int not null,
idGenero int not null,
FOREIGN KEY(idPelicula) REFERENCES peliculas(idPelicula),
FOREIGN KEY(idgenero) REFERENCES generos(idGenero)
);
-- Ingreso de datos
INSERT INTO peliculas VALUES (DEFAULT, "El Padrino","Esta es la descripcion");
INSERT INTO peliculas VALUES (DEFAULT, "Forrest Gump","Esta es otra descripcion");
INSERT INTO actores VALUES (DEFAULT, "Alfredo James Pacino");
INSERT INTO actores VALUES (DEFAULT, "Marlon Brando Jr.");
INSERT INTO actores VALUES (DEFAULT, "Tom Hanks");
INSERT INTO directores VALUES (DEFAULT, "Francis Ford Coppola");
INSERT INTO directores VALUES (DEFAULT, "Robert Zemeckis");
INSERT INTO plataformas VALUES (DEFAULT, "Netflix");
INSERT INTO plataformas VALUES (DEFAULT, "Amazon Prime");
INSERT INTO usuarios VALUES (DEFAULT, "Pekines", "1234");
INSERT INTO usuarios VALUES (DEFAULT, "Juanito", "4321");
INSERT INTO comentarios VALUES (1,"Muy buena pelicula, la recomiendo.",1);
INSERT INTO comentarios VALUES (2,"Muy mala pelicula no se escucha",1);
INSERT INTO comentarios VALUES (1,"Aceptable y divertida",2);
INSERT INTO tipos VALUES(DEFAULT,"Venta");
INSERT INTO tipos VALUES(DEFAULT,"Renta");
INSERT INTO tipos VALUES(DEFAULT,"Renta y Venta");
INSERT INTO tipos VALUES(DEFAULT,"Plan");
INSERT INTO distribuciones VALUES (DEFAULT,78,"1080",3);

INSERT INTO interpretes VALUES(1,1);
INSERT INTO interpretes VALUES(2,1);
INSERT INTO interpretes VALUES(3,2);
INSERT INTO cordinadores VALUES(1,1);
INSERT INTO contiene VALUES(1,1);
INSERT INTO servicios VALUES(1,1);
INSERT INTO servicios VALUES(2,1);

-- Titulo pelicula
SELECT nombrePelicula FROM peliculas WHERE idPelicula = 1;
-- Descripcion pelicula
SELECT descripcionPelicula FROM peliculas WHERE idPelicula = 1;
-- Actores
SELECT actores.nombreActor FROM actores 
INNER JOIN interpretes ON actores.idactor = interpretes.idactor 
INNER JOIN peliculas ON interpretes.idpelicula = peliculas.idpelicula
WHERE peliculas.idpelicula = 1;
-- Directores
SELECT directores.nombreDirector FROM directores 
INNER JOIN cordinadores ON directores.iddirector = cordinadores.iddirector 
INNER JOIN peliculas ON cordinadores.idpelicula = peliculas.idpelicula
WHERE peliculas.idpelicula = 1;
-- Plataformas
SELECT plataformas.nombrePlataforma FROM plataformas
INNER JOIN contiene ON plataformas.idplataforma = contiene.idplataforma 
INNER JOIN peliculas ON contiene.idpelicula = peliculas.idpelicula
WHERE peliculas.idpelicula = 1;
-- Comentarios de las peliculas
SELECT usuarios.nombreusuario, comentarios.comentario FROM usuarios
INNER JOIN comentarios ON usuarios.idusuario = comentarios.idusuario
INNER JOIN peliculas ON comentarios.idpelicula = peliculas.idpelicula
WHERE peliculas.idpelicula = 1;

-- usuario
CREATE USER 'becario1'@'localhost' IDENTIFIED BY 'abc123';
/* Asignamos los permisos para visualizar, insertar, actualizar y borrar en la tab                 la canciones para becario*/
GRANT SELECT, INSERT, UPDATE, DELETE ON streaming.actores TO 'becario1'@'localhost';

SHOW GRANTS FOR 'becario1'@'localhost';