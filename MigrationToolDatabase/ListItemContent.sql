CREATE TABLE [dbo].[ListItemContent]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Content] NVARCHAR(MAX) NULL, 
    [ListItemId] SMALLINT NOT NULL, 
    [FieldId] TINYINT NOT NULL
)

GO

CREATE INDEX [IX_ListItemContent_ListItemId] ON [dbo].[ListItemContent] (ListItemId)

GO

CREATE INDEX [IX_ListItemContent_FieldId] ON [dbo].[ListItemContent] (FieldId)
