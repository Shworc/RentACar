CREATE TABLE [dbo].[Zakupac] (
    [Id]       INT            IDENTITY (1, 1) NOT NULL,
    [Ime]      NVARCHAR (100) NOT NULL,
    [Password] NVARCHAR (50)  NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

