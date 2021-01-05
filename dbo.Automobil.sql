CREATE TABLE [dbo].[Automobil] (
    [Id]    INT            NOT NULL IDENTITY,
    [Marka] NVARCHAR (50)  NOT NULL,
    [Naziv] NVARCHAR (100) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

