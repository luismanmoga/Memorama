
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/30/2020 11:22:37
-- Generated from EDMX file: C:\Users\Luis Manuel\Desktop\Memorama\DataAccess\DB_Memorama.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Memorama];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_JugadorPuntuacion]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PuntuacionSet] DROP CONSTRAINT [FK_JugadorPuntuacion];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[JugadorSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[JugadorSet];
GO
IF OBJECT_ID(N'[dbo].[PuntuacionSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PuntuacionSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'JugadorSet'
CREATE TABLE [dbo].[JugadorSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Username] nvarchar(20)  NOT NULL,
    [Correo] nvarchar(50)  NOT NULL,
    [Contrasenia] nvarchar(max)  NOT NULL,
    [Estado] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PuntuacionSet'
CREATE TABLE [dbo].[PuntuacionSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Puntos] nvarchar(max)  NOT NULL,
    [Fecha] datetime  NOT NULL,
    [Jugador_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'JugadorSet'
ALTER TABLE [dbo].[JugadorSet]
ADD CONSTRAINT [PK_JugadorSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PuntuacionSet'
ALTER TABLE [dbo].[PuntuacionSet]
ADD CONSTRAINT [PK_PuntuacionSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Jugador_Id] in table 'PuntuacionSet'
ALTER TABLE [dbo].[PuntuacionSet]
ADD CONSTRAINT [FK_JugadorPuntuacion]
    FOREIGN KEY ([Jugador_Id])
    REFERENCES [dbo].[JugadorSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_JugadorPuntuacion'
CREATE INDEX [IX_FK_JugadorPuntuacion]
ON [dbo].[PuntuacionSet]
    ([Jugador_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------