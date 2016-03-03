CREATE TABLE [dbo].[Fields] (
    [Id]     TINYINT        NOT NULL,
    [Name]   NVARCHAR (MAX) NOT NULL,
    [ListId] SMALLINT       NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Fields_Lists] FOREIGN KEY ([ListId]) REFERENCES [dbo].[Lists] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Fields_ListId]
    ON [dbo].[Fields]([ListId] ASC);

