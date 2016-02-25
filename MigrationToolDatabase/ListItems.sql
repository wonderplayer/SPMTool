CREATE TABLE [dbo].[ListItems]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Value] NVARCHAR(MAX) NULL, 
    [FieldId] INT NOT NULL, 
    [ListGUId] NVARCHAR(50) NOT NULL 
)

GO

CREATE INDEX [IX_ListItems_ListGUId] ON [dbo].[ListItems] (ListGUId)

GO

CREATE INDEX [IX_ListItems_FieldId] ON [dbo].[ListItems] (FieldId)
