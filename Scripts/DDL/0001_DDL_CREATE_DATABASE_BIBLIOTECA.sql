CREATE DATABASE biblioteca
GO

USE biblioteca
GO

SELECT * FROM autores

SELECT * FROM editoriales

SELECT * FROM libros

SELECT * FROM autores_has_libros

CREATE TABLE autores (
	id NUMERIC(10, 0) IDENTITY(1,1),
	nombre VARCHAR(45),
	apellido VARCHAR(45),
	CONSTRAINT autores_pk PRIMARY KEY CLUSTERED (id)
);

CREATE TABLE editoriales (
	id NUMERIC(10, 0) IDENTITY(1,1),
	nombre VARCHAR(45),
	sede VARCHAR(45),
	CONSTRAINT editoriales_pk PRIMARY KEY CLUSTERED (id)
);

CREATE TABLE libros (
	ISBN NUMERIC(13, 0),
	editoriales_id NUMERIC(10, 0),
	titulo VARCHAR(45),
	sinopsis TEXT,
	n_paginas VARCHAR(45),
	CONSTRAINT libros_pk PRIMARY KEY CLUSTERED (ISBN),
	CONSTRAINT editoriales_fk FOREIGN KEY (editoriales_id) REFERENCES editoriales(id)
);

CREATE TABLE autores_has_libros (
	autores_id NUMERIC(10, 0),
	libros_ISBN NUMERIC(13, 0),
	CONSTRAINT autores_fk FOREIGN KEY (autores_id) REFERENCES autores(id),
	CONSTRAINT libros_fk FOREIGN KEY (libros_ISBN) REFERENCES libros(ISBN)
);