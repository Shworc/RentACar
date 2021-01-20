CREATE TABLE [dbo].[Rezervacija]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [DatumOd] DATE NOT NULL, 
    [DatumDo] DATE NOT NULL, 
    [ZakupacID] INT NOT NULL, 
    [AutomobilID] INT NOT NULL, 
    CONSTRAINT [FK_Rezervacija_Zakupac] FOREIGN KEY ([ZakupacID]) REFERENCES [Zakupac]([Id]), 
    CONSTRAINT [FK_Rezervacija_Automobil] FOREIGN KEY (AutomobilID) REFERENCES [Automobil]([Id]) 
)
