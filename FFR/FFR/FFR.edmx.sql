
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 10/11/2013 17:12:38
-- Generated from EDMX file: C:\Users\NOLSEN\Source\Repos\MSSE680_Week7\FFR\FFR\FFR.edmx
-- --------------------------------------------------
IF NOT EXISTS(select * from sys.databases where name = 'FFR')
	CREATE DATABASE FFR;

SET QUOTED_IDENTIFIER OFF;
GO
USE [FFR];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Items_ItemCategory]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Items] DROP CONSTRAINT [FK_Items_ItemCategory];
GO
IF OBJECT_ID(N'[dbo].[FK_SalesHeader_Customer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SalesHeaders] DROP CONSTRAINT [FK_SalesHeader_Customer];
GO
IF OBJECT_ID(N'[dbo].[FK_SalesItems_Items]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SalesItems] DROP CONSTRAINT [FK_SalesItems_Items];
GO
IF OBJECT_ID(N'[dbo].[FK_SalesItems_SalesHeaders]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SalesItems] DROP CONSTRAINT [FK_SalesItems_SalesHeaders];
GO
IF OBJECT_ID(N'[dbo].[FK_WebUserTable_Customers]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[WebUserTable] DROP CONSTRAINT [FK_WebUserTable_Customers];
GO
IF OBJECT_ID(N'[dbo].[FK_WebUserTable_Employees]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[WebUserTable] DROP CONSTRAINT [FK_WebUserTable_Employees];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Customers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Customers];
GO
IF OBJECT_ID(N'[dbo].[Employees]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Employees];
GO
IF OBJECT_ID(N'[dbo].[ItemCategory]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ItemCategory];
GO
IF OBJECT_ID(N'[dbo].[Items]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Items];
GO
IF OBJECT_ID(N'[dbo].[SalesHeaders]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SalesHeaders];
GO
IF OBJECT_ID(N'[dbo].[SalesItems]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SalesItems];
GO
IF OBJECT_ID(N'[dbo].[WebUserTable]', 'U') IS NOT NULL
    DROP TABLE [dbo].[WebUserTable];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Customers'
CREATE TABLE [dbo].[Customers] (
    [CustomerId] int IDENTITY(1,1)  NOT NULL,
    [FirstName] varchar(50)  NULL,
    [LastName] varchar(50)  NULL,
    [Address] varchar(200)  NULL,
    [City] varchar(50)  NULL,
    [State] varchar(2)  NULL,
    [Zip] varchar(10)  NULL,
    [Suite] varchar(20)  NULL,
    [Phone] varchar(20)  NULL,
    [Email] varchar(100)  NULL,
    [Street] varchar(100)  NULL
);
GO

-- Creating table 'SalesHeaders'
CREATE TABLE [dbo].[SalesHeaders] (
    [SalesId] int IDENTITY(1,1)  NOT NULL,
    [CustomerId] int  NULL,
    [OrderSalesBalance] decimal(10,0)  NULL,
    [OrderTaxAmount] decimal(10,0)  NULL,
    [OrderTotal] decimal(10,0)  NULL,
    [SalesStatus] varchar(30)  NULL
);
GO

-- Creating table 'Items'
CREATE TABLE [dbo].[Items] (
    [ItemId] int IDENTITY(1,1)  NOT NULL,
    [ItemName] varchar(50)  NULL,
    [QuantityAvailable] int  NULL,
    [ItemCost] decimal(18,0)  NULL,
    [Price] decimal(18,0)  NULL,
    [ItemCategoryId] int  NULL
);
GO

-- Creating table 'SalesItems'
CREATE TABLE [dbo].[SalesItems] (
    [SalesItemTransId] int IDENTITY(1,1) NOT NULL,
    [SalesId] int  NOT NULL,
    [ItemId] int  NOT NULL,
	[CartId] string NULL,
    [Qty] int  NULL,
    [Price] decimal(19,4)  NULL,
    [LineAmount] decimal(19,4)  NULL,
    [ItemName] varchar(50)  NULL
);
GO

-- Creating table 'Employees'
CREATE TABLE [dbo].[Employees] (
    [EmployeeId] int IDENTITY(1,1) NOT NULL,
    [EmployeeFirstName] varchar(50)  NULL,
    [EmployeeLastName] varchar(50)  NULL,
    [EmployeePhone] varchar(20)  NULL,
    [Employeetype] varchar(10)  NULL
);
GO

-- Creating table 'ItemCategories'
CREATE TABLE [dbo].[ItemCategories] (
    [ItemCategoryId] int IDENTITY(1,1)  NOT NULL,
    [Category] nchar(20)  NULL,
    [Description] nchar(50)  NULL
);
GO

-- Creating table 'WebUserTables'
CREATE TABLE [dbo].[WebUserTables] (
    [UserId] int IDENTITY(1,1)  NOT NULL,
    [UserName] nchar(20)  NOT NULL,
    [Password] nchar(20)  NOT NULL,
    [CustomerId] int  NULL,
    [EmployeeId] int  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [CustomerId] in table 'Customers'
ALTER TABLE [dbo].[Customers]
ADD CONSTRAINT [PK_Customers]
    PRIMARY KEY CLUSTERED ([CustomerId] ASC);
GO

-- Creating primary key on [SalesId] in table 'SalesHeaders'
ALTER TABLE [dbo].[SalesHeaders]
ADD CONSTRAINT [PK_SalesHeaders]
    PRIMARY KEY CLUSTERED ([SalesId] ASC);
GO

-- Creating primary key on [ItemId] in table 'Items'
ALTER TABLE [dbo].[Items]
ADD CONSTRAINT [PK_Items]
    PRIMARY KEY CLUSTERED ([ItemId] ASC);
GO

-- Creating primary key on [SalesItemTransId] in table 'SalesItems'
ALTER TABLE [dbo].[SalesItems]
ADD CONSTRAINT [PK_SalesItems]
    PRIMARY KEY CLUSTERED ([SalesItemTransId] ASC);
GO

-- Creating primary key on [EmployeeId] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [PK_Employees]
    PRIMARY KEY CLUSTERED ([EmployeeId] ASC);
GO

-- Creating primary key on [ItemCategoryId] in table 'ItemCategories'
ALTER TABLE [dbo].[ItemCategories]
ADD CONSTRAINT [PK_ItemCategories]
    PRIMARY KEY CLUSTERED ([ItemCategoryId] ASC);
GO

-- Creating primary key on [UserId] in table 'WebUserTables'
ALTER TABLE [dbo].[WebUserTables]
ADD CONSTRAINT [PK_WebUserTables]
    PRIMARY KEY CLUSTERED ([UserId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CustomerId] in table 'SalesHeaders'
ALTER TABLE [dbo].[SalesHeaders]
ADD CONSTRAINT [FK_SalesHeader_Customer]
    FOREIGN KEY ([CustomerId])
    REFERENCES [dbo].[Customers]
        ([CustomerId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_SalesHeader_Customer'
CREATE INDEX [IX_FK_SalesHeader_Customer]
ON [dbo].[SalesHeaders]
    ([CustomerId]);
GO

-- Creating foreign key on [ItemId] in table 'SalesItems'
ALTER TABLE [dbo].[SalesItems]
ADD CONSTRAINT [FK_SalesItems_Items]
    FOREIGN KEY ([ItemId])
    REFERENCES [dbo].[Items]
        ([ItemId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_SalesItems_Items'
CREATE INDEX [IX_FK_SalesItems_Items]
ON [dbo].[SalesItems]
    ([ItemId]);
GO

-- Creating foreign key on [SalesId] in table 'SalesItems'
ALTER TABLE [dbo].[SalesItems]
ADD CONSTRAINT [FK_SalesItems_SalesHeaders]
    FOREIGN KEY ([SalesId])
    REFERENCES [dbo].[SalesHeaders]
        ([SalesId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_SalesItems_SalesHeaders'
CREATE INDEX [IX_FK_SalesItems_SalesHeaders]
ON [dbo].[SalesItems]
    ([SalesId]);
GO

-- Creating foreign key on [CustomerId] in table 'WebUserTables'
ALTER TABLE [dbo].[WebUserTables]
ADD CONSTRAINT [FK_WebUserTable_Customers]
    FOREIGN KEY ([CustomerId])
    REFERENCES [dbo].[Customers]
        ([CustomerId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_WebUserTable_Customers'
CREATE INDEX [IX_FK_WebUserTable_Customers]
ON [dbo].[WebUserTables]
    ([CustomerId]);
GO

-- Creating foreign key on [EmployeeId] in table 'WebUserTables'
ALTER TABLE [dbo].[WebUserTables]
ADD CONSTRAINT [FK_WebUserTable_Employees]
    FOREIGN KEY ([EmployeeId])
    REFERENCES [dbo].[Employees]
        ([EmployeeId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_WebUserTable_Employees'
CREATE INDEX [IX_FK_WebUserTable_Employees]
ON [dbo].[WebUserTables]
    ([EmployeeId]);
GO

-- Creating foreign key on [ItemCategoryId] in table 'Items'
ALTER TABLE [dbo].[Items]
ADD CONSTRAINT [FK_Items_ItemCategory]
    FOREIGN KEY ([ItemCategoryId])
    REFERENCES [dbo].[ItemCategories]
        ([ItemCategoryId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Items_ItemCategory'
CREATE INDEX [IX_FK_Items_ItemCategory]
ON [dbo].[Items]
    ([ItemCategoryId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------