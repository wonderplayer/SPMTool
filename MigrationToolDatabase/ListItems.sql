CREATE TABLE [dbo].[ListItems]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Value] NVARCHAR(MAX) NULL, 
    [FieldId] INT NOT NULL, 
    [ListGUId] NVARCHAR(50) NOT NULL, 
    CONSTRAINT [FK_ListItems_ListGUId_ToLists] FOREIGN KEY (ListGUId) REFERENCES Lists(GUId)
)
