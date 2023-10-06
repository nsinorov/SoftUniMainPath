CREATE TABLE [Categories]
(
	[Id] INT PRIMARY KEY IDENTITY,
	[CategoryName] VARCHAR(50) NOT NULL,
	[DailyRate] DECIMAL(6, 2) NOT NULL,
	[WeeklyRate] DECIMAL(6, 2) NOT NULL,
	[MonthlyRate] DECIMAL(6, 2) NOT NULL,
	[WeekendRate] DECIMAL(6, 2) NOT NULL
)

CREATE TABLE [Cars]
(
	[Id] INT PRIMARY KEY IDENTITY,
	[PlateNumber] VARCHAR(30) NOT NULL,
	[Manufacturer] VARCHAR(50) NOT NULL,
	[Model] VARCHAR(50) NOT NULL,
	[CarYear] INT NOT NULL,
	[CategoryId] INT FOREIGN KEY REFERENCES [Categories](Id) NOT NULL,
	[Doors] INT NOT NULL,
	[Picture] IMAGE,
	[Condition] NVARCHAR(1000) NOT NULL,
	[Available] BIT NOT NULL
)

CREATE TABLE [Employees]
(
	[Id] INT PRIMARY KEY IDENTITY,
	[FirstName] VARCHAR(30) NOT NULL,
	[LastName] VARCHAR(30) NOT NULL,
	[Title] VARCHAR(50) NOT NULL,
	[Notes] NVARCHAR(1000)
)

CREATE TABLE [Customers]
(
	[Id] INT PRIMARY KEY IDENTITY,
	[DriverLicenceNumber] INT NOT NULL,
	[FullName] VARCHAR(50) NOT NULL,
	[Address] VARCHAR(200) NOT NULL,
	[City] VARCHAR(50) NOT NULL,
	[ZIPCode] INT NOT NULL,
	[Notes] NVARCHAR(1000)
)

CREATE TABLE [RentalOrders]
(
	[Id] INT PRIMARY KEY IDENTITY,
	[EmployeeId] INT FOREIGN KEY REFERENCES [Employees](Id) NOT NULL,
	[CustomerId] INT FOREIGN KEY REFERENCES [Customers](Id) NOT NULL,
	[CarId] INT FOREIGN KEY REFERENCES [Cars](Id) NOT NULL,
	[TankLevel] INT NOT NULL,
	[KilometrageStart] INT NOT NULL,
	[KilometrageEnd] INT NOT NULL,
	[TotalKilometrage] INT NOT NULL,
	[StartDate] DATE NOT NULL,
	[EndDate] DATE NOT NULL,
	[TotalDays] INT NOT NULL,
	[RateApplied] DECIMAL(6, 2) NOT NULL,
	[TaxRate] DECIMAL(4, 2) NOT NULL,
	[OrderStatus] VARCHAR(50) NOT NULL,
	[Notes] NVARCHAR(1000)
)

INSERT INTO [Categories] VALUES
	('First category name', 10.00, 50.00, 150.00, 20.00),
	('Second category name', 50.00, 250.00, 750.00, 100.00),
	('Third category name', 100.00, 500.00, 1500.00, 200.00)

INSERT INTO [Cars] VALUES
	('PLN 0001', 'Ford', 'Model A', 1994, 1, 4, NULL, 'Good', 1),
	('PLN 0002', 'Tesla', 'Model B', 2021, 2, 4, NULL, 'Great', 1),
	('PLN 0003', 'Capsule Corp', 'Model C', 2054, 3, 10, NULL, 'Best', 0)

INSERT INTO [Employees] VALUES
	('Tyler', 'Durden', 'Edward Norton`s Alter Ego', NULL),
	('Plain', 'Jane', 'some gal', NULL),
	('Average', 'Joe', 'some dude', NULL)

INSERT INTO [Customers] VALUES
	('123456', 'Jimmy Carr', 'Britain', 'London', 1000, NULL),
	('654321', 'Bill Burr', 'USA', 'Washington', 2000, NULL),
	('999999', 'Louis CK', 'Mexico', 'Mexico City', 3000, NULL)

INSERT INTO [RentalOrders] VALUES
	(1, 1, 1, 70, 90000, 100000, 10000, '1994-10-01', '1994-10-21', 20, 100.00, 14.00, 'Pending', NULL),
	(2, 2, 2, 85, 250000, 2750000, 25000, '2011-11-12', '2011-11-24', 12, 150.00, 17.50, 'Canceled', NULL),
	(3, 3, 3, 90, 0, 120000, 120000, '2025-04-05', '2025-05-02', 27, 220.00, 21.25, 'Delivered', NULL)