MERGE INTO [dbo].[UserRole] AS Target
USING (VALUES

    (1, N'Administrator'),
    (2, N'Moderator')

) AS Source ([RoleID], [Name])
ON Target.[RoleID] = Source.[RoleID]
-- Update matched rows
WHEN MATCHED THEN
UPDATE SET [Name] = Source.[Name]
-- Insert new rows
WHEN NOT MATCHED BY TARGET THEN
INSERT ([RoleID], [Name])
VALUES ([RoleID], [Name])
-- Delete rows that are in the target but not the source
WHEN NOT MATCHED BY SOURCE THEN
DELETE;
GO