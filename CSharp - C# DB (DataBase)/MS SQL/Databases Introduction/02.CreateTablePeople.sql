CREATE TABLE [People]
(
   [Id] INT PRIMARY KEY IDENTITY  ,
   [Name] NVARCHAR(200) NOT NULL,
   [Picture] VARBINARY(MAX),
   [Height] DECIMAL(3, 2),
   [Weight] DECIMAL(5, 2),
   [Gender] CHAR(1) NOT NULL,
   CHECK ([Gender] = 'm' OR [Gender] = 'f'), 
   [BirthDate] DATE NOT NULL,
   [Biography] NVARCHAR(MAX)
)

INSERT INTO [People]([Name], [Height], [Weight], [Gender], [BirthDate])
     VALUES
('Pesho', 1.65, 70.6, 'm', '2003-01-07'),
('Gosho', NULL, NULL, 'm', '1977-08-02'),
('Maria', 1.74, 55.6, 'f', '1949-10-24'),
('ToshoKykata', 1.70, 80, 'm', '1969-06-09'),
('GlavniaIliev', 1.30, 40, 'm', '1969-06-09')
