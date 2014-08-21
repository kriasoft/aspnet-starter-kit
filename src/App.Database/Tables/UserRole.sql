CREATE TABLE [dbo].[UserRole]
(
    [RoleID] INT          NOT NULL,
    [Name]   [dbo].[Name] NOT NULL,

    CONSTRAINT [PK_UserRole_RoleID] PRIMARY KEY CLUSTERED ([RoleID] ASC),
    CONSTRAINT [UK_UserRole_Name] UNIQUE NONCLUSTERED ([Name] ASC)
);
