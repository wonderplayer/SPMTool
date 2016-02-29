CREATE TABLE [dbo].[Fields]
(
	[Id] TINYINT NOT NULL PRIMARY KEY, 
    [Caption] NVARCHAR(MAX) NOT NULL, 
    [InternalName] NVARCHAR(MAX) NOT NULL, 
    [DataTypeId] TINYINT NOT NULL
)

GO

CREATE INDEX [IX_Fields_DataTypeId] ON [dbo].[Fields] (DataTypeId)
