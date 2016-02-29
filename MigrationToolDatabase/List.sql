CREATE TABLE [dbo].[List]
(
	[Id] TINYINT NOT NULL PRIMARY KEY, 
    [ListId] SMALLINT NOT NULL 
)

GO


CREATE INDEX [IX_List_ListId] ON [dbo].[List] (ListId)
