CREATE TABLE [dbo].[UserClaim]
(
    [UserID]     INT                   NOT NULL,
    [ClaimID]    INT IDENTITY (1000,1) NOT NULL,
    [ClaimType]  NVARCHAR (MAX)        NULL,
    [ClaimValue] NVARCHAR (MAX)        NULL,

    CONSTRAINT [PK_UserClaim_ClaimID] PRIMARY KEY CLUSTERED ([ClaimID] ASC),
    CONSTRAINT [FK_UserClaim_User] FOREIGN KEY ([UserID]) REFERENCES [dbo].[User] ([UserID]) ON DELETE CASCADE
);

GO
CREATE NONCLUSTERED INDEX [IX_UserClaim_UserID]
    ON [dbo].[UserClaim] ([UserID] ASC);