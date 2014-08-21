CREATE TABLE [dbo].[UserLogin]
(
    [UserID]        INT            NOT NULL,
    [LoginProvider] NVARCHAR (128) NOT NULL,
    [ProviderKey]   NVARCHAR (128) NOT NULL,

    CONSTRAINT [PK_UserLogin_UserID_LoginProvider_ProviderKey] PRIMARY KEY CLUSTERED ([UserID] ASC, [LoginProvider] ASC, [ProviderKey] ASC),
    CONSTRAINT [FK_UserLogin_User] FOREIGN KEY ([UserID]) REFERENCES [dbo].[User] ([UserID]) ON DELETE CASCADE
);

GO
CREATE NONCLUSTERED INDEX [IX_UserLogin_UserID]
    ON [dbo].[UserLogin] ([UserID] ASC);
