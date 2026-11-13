use master;

create database Traductor;
GO

use Traductor;
GO

create table Roles
(
IdRol int identity primary key,
NombreRol nvarchar(20)
);
GO

create table Usuarios
(
IdUsuario int identity primary key,
NombreUsuario nvarchar(50),
Clave nvarchar(10),
Rol int foreign key references Roles(IdRol)
);
GO

create table Idiomas
(
IdIdioma int identity primary key,
Abreviacion nvarchar(2), --ES,FR,IN,AL
Idioma nvarchar(10)
);
GO

create table Palabras
(
IdPalabra int identity primary key,
PalabraEspanol nvarchar(100),
CodigoPalabra nvarchar(10) --para la consulta por codigo
);
GO

create table Traducciones
(
IdTraduccion int identity primary key,
PalabraId int foreign key references Palabras(IdPalabra),
IdiomaId int foreign key references Idiomas(IdIdioma),
Traduccion nvarchar(100)
);
GO

insert into Roles values 
('Administrador'), 
('Usuario');
GO
 

INSERT INTO Usuarios VALUES 
('admin_gago', 'Admin123*', 1),
('carlos_dev', 'Pass2026', 2),
('maria_tradu', 'Tradu456', 2),
('lucia_perez', 'Clave789', 2),
('soporte_tec', 'Soporte#1', 1);
GO

INSERT INTO Idiomas VALUES 
('ES', 'Español'),
('EN', 'Inglés'),
('FR', 'Francés'),
('AL', 'Alemán');
GO

INSERT INTO Palabras VALUES 
('Casa', 'P001'),
('Perro', 'P002'),
('Gato', 'P003'),
('Libro', 'P004'),
('Agua', 'P005'),
('Comida', 'P006'),
('Escuela', 'P007'),
('Amigo', 'P008'),
('Familia', 'P009'),
('Trabajo', 'P010'),
('Automóvil', 'P011'),
('Ciudad', 'P012'),
('Árbol', 'P013'),
('Feliz', 'P014'),
('Sol', 'P015');
GO

INSERT INTO Traducciones (PalabraId, IdiomaId, Traduccion) VALUES 
-- Casa (PalabraId: 1)
(1, 1, 'Casa'),
(1, 2, 'House'),
(1, 3, 'Maison'),
(1, 4, 'Haus'),

-- Perro (PalabraId: 2)
(2, 1, 'Perro'),
(2, 2, 'Dog'),
(2, 3, 'Chien'),
(2, 4, 'Hund'),

-- Gato (PalabraId: 3)
(3, 1, 'Gato'),
(3, 2, 'Cat'),
(3, 3, 'Chat'),
(3, 4, 'Katze'),

-- Libro (PalabraId: 4)
(4, 1, 'Libro'),
(4, 2, 'Book'),
(4, 3, 'Livre'),
(4, 4, 'Buch'),

-- Agua (PalabraId: 5)
(5, 1, 'Agua'),
(5, 2, 'Water'),
(5, 3, 'Eau'),
(5, 4, 'Wasser'),

-- Comida (PalabraId: 6)
(6, 1, 'Comida'),
(6, 2, 'Food'),
(6, 3, 'Nourriture'),
(6, 4, 'Essen'),

-- Escuela (PalabraId: 7)
(7, 1, 'Escuela'),
(7, 2, 'School'),
(7, 3, 'École'),
(7, 4, 'Schule'),

-- Amigo (PalabraId: 8)
(8, 1, 'Amigo'),
(8, 2, 'Friend'),
(8, 3, 'Ami'),
(8, 4, 'Freund'),

-- Familia (PalabraId: 9)
(9, 1, 'Familia'),
(9, 2, 'Family'),
(9, 3, 'Famille'),
(9, 4, 'Familie'),

-- Trabajo (PalabraId: 10)
(10, 1, 'Trabajo'),
(10, 2, 'Work'),
(10, 3, 'Travail'),
(10, 4, 'Arbeit'),

-- Automóvil (PalabraId: 11)
(11, 1, 'Automóvil'),
(11, 2, 'Car'),
(11, 3, 'Voiture'),
(11, 4, 'Auto'),

-- Ciudad (PalabraId: 12)
(12, 1, 'Ciudad'),
(12, 2, 'City'),
(12, 3, 'Ville'),
(12, 4, 'Stadt'),

-- Árbol (PalabraId: 13)
(13, 1, 'Árbol'),
(13, 2, 'Tree'),
(13, 3, 'Arbre'),
(13, 4, 'Baum'),

-- Feliz (PalabraId: 14)
(14, 1, 'Feliz'),
(14, 2, 'Happy'),
(14, 3, 'Heureux'),
(14, 4, 'Glücklich'),

-- Sol (PalabraId: 15)
(15, 1, 'Sol'),
(15, 2, 'Sun'),
(15, 3, 'Soleil'),
(15, 4, 'Sonne');
GO






