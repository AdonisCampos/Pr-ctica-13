CREATE DATABASE Usuarios
GO
USE Usuarios
GO
CREATE TABLE Credenciales(
usuario varchar(50),
clave varchar(50)
);
GO

INSERT INTO Credenciales(usuario, clave)VALUES('Adonis','123');
INSERT INTO Credenciales(usuario, clave)VALUES('Bernardo','1234');
GO

SELECT * FROM Credenciales
GO

