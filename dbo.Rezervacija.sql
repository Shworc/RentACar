CREATE TABLE [dbo].[Rezervacija] (
    [Id]          INT  NOT NULL IDENTITY,
    [DatumOd]     DATE NOT NULL,
    [DatumDo]     DATE NOT NULL,
    [ZakupacID]   INT  NOT NULL,
    [AutomobilID] INT  NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Rezervacija_Automobil] FOREIGN KEY ([AutomobilID]) REFERENCES [dbo].[Automobil] ([Id]),
    CONSTRAINT [FK_Rezervacija_Zakupac] FOREIGN KEY ([ZakupacID]) REFERENCES [dbo].[Zakupac] ([Id])
);

