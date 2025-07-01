CREATE TABLE Usuarios (
    UserName NVARCHAR(100) NOT NULL PRIMARY KEY,
    PasswordHash NVARCHAR(255) NOT NULL,
    Role NVARCHAR(20) NOT NULL CHECK (Role IN ('Utilizador', 'Administrador'))
);