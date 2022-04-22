
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/21/2022 19:15:47
-- Generated from EDMX file: C:\Users\umesh\source\repos\ModelFirst\ModelFirst\Models\Trains.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [TrainsDb];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'tblTrains'
CREATE TABLE [dbo].[tblTrains] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [trainname] nvarchar(max)  NOT NULL,
    [trainno] nvarchar(max)  NOT NULL,
    [departure] datetime  NOT NULL,
    [destination] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'tblTrains'
ALTER TABLE [dbo].[tblTrains]
ADD CONSTRAINT [PK_tblTrains]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------