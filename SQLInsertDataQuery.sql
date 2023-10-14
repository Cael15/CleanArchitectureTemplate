USE master 
GO

CREATE DATABASE CleanArchitectureTemplateDB;
GO


USE CleanArchitectureTemplateDB;
GO


CREATE TABLE Entity (
    Id UNIQUEIDENTIFIER PRIMARY KEY,
    Name NVARCHAR(255) NOT NULL,
    LastName NVARCHAR(255) NOT NULL,
    Age INT NOT NULL,
    Price DECIMAL(18, 2) NOT NULL,
    CreatedAt DATETIME NOT NULL,
    IsActive BIT NOT NULL
);

