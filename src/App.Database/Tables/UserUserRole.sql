CREATE TABLE [dbo].[UserUserRole]
(
    [UserID] INT NOT NULL,
    [RoleID] INT NOT NULL,

    CONSTRAINT [PK_UserUserRole_UserID_RoleID] PRIMARY KEY CLUSTERED ([UserID] ASC, [RoleID] ASC),
    CONSTRAINT [FK_UserUserRole_User] FOREIGN KEY ([UserID]) REFERENCES [dbo].[User] ([UserID]) ON DELETE CASCADE,
    CONSTRAINT [FK_UserUserRole_UserRole] FOREIGN KEY ([RoleID]) REFERENCES [dbo].[UserRole] ([RoleID]) ON DELETE CASCADE
);

GO
CREATE NONCLUSTERED INDEX [IX_UserUserRole_UserID]
    ON [dbo].[UserUserRole] ([UserID] ASC);

GO
CREATE NONCLUSTERED INDEX [IX_UserUserRole_RoleID]
    ON [dbo].[UserUserRole] ([RoleID] ASC);
