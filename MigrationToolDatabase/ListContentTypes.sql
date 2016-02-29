CREATE TABLE [dbo].[ListContentTypes]
(
	[Id] TINYINT NOT NULL PRIMARY KEY, 
    [ContentTypeId] TINYINT NOT NULL, 
    [ListId] TINYINT NOT NULL
)

GO

CREATE INDEX [IX_ListContentTypes_ContentTypeId] ON [dbo].[ListContentTypes] (ContentTypeId)

GO

CREATE INDEX [IX_ListContentTypes_ListId] ON [dbo].[ListContentTypes] (ListId)
