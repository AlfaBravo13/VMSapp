CREATE TABLE [dbo].[Experiments]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Title] NVARCHAR(200) NOT NULL, 
    [Requirement] NVARCHAR(200) NULL, 
    [Description] NVARCHAR(1000) NULL
)
