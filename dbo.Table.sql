CREATE TABLE [dbo].[MovieTable]
(
	[MovieID] INT NOT NULL PRIMARY KEY, 
    [MovieName] NVARCHAR(50) NULL, 
    [Genre] NVARCHAR(50) NULL, 
    [Rating] INT NULL, 
    [Price] DECIMAL(10, 2) NULL
)
