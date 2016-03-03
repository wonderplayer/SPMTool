CREATE TABLE [dbo].[Lists] (
    [Id]           SMALLINT       NOT NULL,
    [GUId]         NVARCHAR (50)  NOT NULL,
    [Name]         NVARCHAR (MAX) NOT NULL,
    [InternalName] NVARCHAR (MAX) NOT NULL,
    [URL]          NVARCHAR (MAX) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

