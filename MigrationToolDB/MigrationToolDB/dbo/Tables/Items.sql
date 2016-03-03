CREATE TABLE [dbo].[Items] (
    [Id]        INT           NOT NULL,
    [SchemaXML] VARCHAR (MAX) NOT NULL,
    [ListId]    SMALLINT      NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Items_Lists] FOREIGN KEY ([ListId]) REFERENCES [dbo].[Lists] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Items_ListId]
    ON [dbo].[Items]([ListId] ASC);

