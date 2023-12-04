CREATE TABLE [dbo].[Map]
(
	[t] DATETIME NOT NULL , 
    [X] INT NOT NULL, 
    [Y] INT NOT NULL, 
    [Z] INT NOT NULL, 
    [Terrain] INT NULL, 
    [ManaDensity] INT NULL, 
    PRIMARY KEY ([X])
)
