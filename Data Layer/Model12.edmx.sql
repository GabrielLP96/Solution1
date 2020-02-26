
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/26/2020 20:44:56
-- Generated from EDMX file: C:\Users\gabri\source\repos\Solution1\Data Layer\Model12.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_AlumnusProgram]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserSet_Alumnus] DROP CONSTRAINT [FK_AlumnusProgram];
GO
IF OBJECT_ID(N'[dbo].[FK_ProgramSection]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProgramSet] DROP CONSTRAINT [FK_ProgramSection];
GO
IF OBJECT_ID(N'[dbo].[FK_SectionEmployee]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserSet_Employee] DROP CONSTRAINT [FK_SectionEmployee];
GO
IF OBJECT_ID(N'[dbo].[FK_EmployeeEvent]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EventSet] DROP CONSTRAINT [FK_EmployeeEvent];
GO
IF OBJECT_ID(N'[dbo].[FK_EventAlumnus]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserSet_Alumnus] DROP CONSTRAINT [FK_EventAlumnus];
GO
IF OBJECT_ID(N'[dbo].[FK_Alumnus_inherits_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserSet_Alumnus] DROP CONSTRAINT [FK_Alumnus_inherits_User];
GO
IF OBJECT_ID(N'[dbo].[FK_Employee_inherits_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserSet_Employee] DROP CONSTRAINT [FK_Employee_inherits_User];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO
IF OBJECT_ID(N'[dbo].[UserSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserSet];
GO
IF OBJECT_ID(N'[dbo].[ProgramSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProgramSet];
GO
IF OBJECT_ID(N'[dbo].[SectionSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SectionSet];
GO
IF OBJECT_ID(N'[dbo].[EventSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EventSet];
GO
IF OBJECT_ID(N'[dbo].[UserSet_Alumnus]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserSet_Alumnus];
GO
IF OBJECT_ID(N'[dbo].[UserSet_Employee]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserSet_Employee];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- Creating table 'UserSet'
CREATE TABLE [dbo].[UserSet] (
    [PersId] int IDENTITY(1,1) NOT NULL,
    [PersCode] nvarchar(max)  NOT NULL,
    [Fname] nvarchar(max)  NOT NULL,
    [Lname] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Username] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ProgramSet'
CREATE TABLE [dbo].[ProgramSet] (
    [ProgramId] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Section_SectionId] int  NULL
);
GO

-- Creating table 'SectionSet'
CREATE TABLE [dbo].[SectionSet] (
    [SectionId] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'EventSet'
CREATE TABLE [dbo].[EventSet] (
    [EventId] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Choose] nvarchar(max)  NOT NULL,
    [EmployeePersId] int  NULL
);
GO

-- Creating table 'UserSet_Alumnus'
CREATE TABLE [dbo].[UserSet_Alumnus] (
    [SNumber] nvarchar(max)  NOT NULL,
    [EventEventId] int  NULL,
    [PersId] int  NOT NULL,
    [Program_ProgramId] int  NULL
);
GO

-- Creating table 'UserSet_Employee'
CREATE TABLE [dbo].[UserSet_Employee] (
    [Signature] nvarchar(max)  NOT NULL,
    [EventEventId] int  NULL,
    [PersId] int  NOT NULL,
    [Section_SectionId] int  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- Creating primary key on [PersId] in table 'UserSet'
ALTER TABLE [dbo].[UserSet]
ADD CONSTRAINT [PK_UserSet]
    PRIMARY KEY CLUSTERED ([PersId] ASC);
GO

-- Creating primary key on [ProgramId] in table 'ProgramSet'
ALTER TABLE [dbo].[ProgramSet]
ADD CONSTRAINT [PK_ProgramSet]
    PRIMARY KEY CLUSTERED ([ProgramId] ASC);
GO

-- Creating primary key on [SectionId] in table 'SectionSet'
ALTER TABLE [dbo].[SectionSet]
ADD CONSTRAINT [PK_SectionSet]
    PRIMARY KEY CLUSTERED ([SectionId] ASC);
GO

-- Creating primary key on [EventId] in table 'EventSet'
ALTER TABLE [dbo].[EventSet]
ADD CONSTRAINT [PK_EventSet]
    PRIMARY KEY CLUSTERED ([EventId] ASC);
GO

-- Creating primary key on [PersId] in table 'UserSet_Alumnus'
ALTER TABLE [dbo].[UserSet_Alumnus]
ADD CONSTRAINT [PK_UserSet_Alumnus]
    PRIMARY KEY CLUSTERED ([PersId] ASC);
GO

-- Creating primary key on [PersId] in table 'UserSet_Employee'
ALTER TABLE [dbo].[UserSet_Employee]
ADD CONSTRAINT [PK_UserSet_Employee]
    PRIMARY KEY CLUSTERED ([PersId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Program_ProgramId] in table 'UserSet_Alumnus'
ALTER TABLE [dbo].[UserSet_Alumnus]
ADD CONSTRAINT [FK_AlumnusProgram]
    FOREIGN KEY ([Program_ProgramId])
    REFERENCES [dbo].[ProgramSet]
        ([ProgramId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AlumnusProgram'
CREATE INDEX [IX_FK_AlumnusProgram]
ON [dbo].[UserSet_Alumnus]
    ([Program_ProgramId]);
GO

-- Creating foreign key on [Section_SectionId] in table 'ProgramSet'
ALTER TABLE [dbo].[ProgramSet]
ADD CONSTRAINT [FK_ProgramSection]
    FOREIGN KEY ([Section_SectionId])
    REFERENCES [dbo].[SectionSet]
        ([SectionId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProgramSection'
CREATE INDEX [IX_FK_ProgramSection]
ON [dbo].[ProgramSet]
    ([Section_SectionId]);
GO

-- Creating foreign key on [Section_SectionId] in table 'UserSet_Employee'
ALTER TABLE [dbo].[UserSet_Employee]
ADD CONSTRAINT [FK_SectionEmployee]
    FOREIGN KEY ([Section_SectionId])
    REFERENCES [dbo].[SectionSet]
        ([SectionId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SectionEmployee'
CREATE INDEX [IX_FK_SectionEmployee]
ON [dbo].[UserSet_Employee]
    ([Section_SectionId]);
GO

-- Creating foreign key on [EmployeePersId] in table 'EventSet'
ALTER TABLE [dbo].[EventSet]
ADD CONSTRAINT [FK_EmployeeEvent]
    FOREIGN KEY ([EmployeePersId])
    REFERENCES [dbo].[UserSet_Employee]
        ([PersId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmployeeEvent'
CREATE INDEX [IX_FK_EmployeeEvent]
ON [dbo].[EventSet]
    ([EmployeePersId]);
GO

-- Creating foreign key on [EventEventId] in table 'UserSet_Alumnus'
ALTER TABLE [dbo].[UserSet_Alumnus]
ADD CONSTRAINT [FK_EventAlumnus]
    FOREIGN KEY ([EventEventId])
    REFERENCES [dbo].[EventSet]
        ([EventId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EventAlumnus'
CREATE INDEX [IX_FK_EventAlumnus]
ON [dbo].[UserSet_Alumnus]
    ([EventEventId]);
GO

-- Creating foreign key on [PersId] in table 'UserSet_Alumnus'
ALTER TABLE [dbo].[UserSet_Alumnus]
ADD CONSTRAINT [FK_Alumnus_inherits_User]
    FOREIGN KEY ([PersId])
    REFERENCES [dbo].[UserSet]
        ([PersId])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [PersId] in table 'UserSet_Employee'
ALTER TABLE [dbo].[UserSet_Employee]
ADD CONSTRAINT [FK_Employee_inherits_User]
    FOREIGN KEY ([PersId])
    REFERENCES [dbo].[UserSet]
        ([PersId])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------