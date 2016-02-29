CREATE TABLE [dbo].[ListItems]
(
	[Id] SMALLINT NOT NULL PRIMARY KEY, 
    [FieldId] TINYINT NOT NULL, 
    [ContentTypeId] TINYINT NOT NULL 
)

GO

CREATE INDEX [IX_ListItems_FieldId] ON [dbo].[ListItems] (FieldId)

GO

CREATE INDEX [IX_ListItems_ContentTypeId] ON [dbo].[ListItems] (ContentTypeId)
