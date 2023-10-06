CREATE TABLE [Users]
(
   [Id] BIGINT PRIMARY KEY IDENTITY,
   [Username] VARCHAR(30) NOT NULL,
   [Password] VARCHAR(26) NOT NULL,
   [ProfilePicture] VARBINARY(MAX),
   [LastLoginTime] DATE,
   [IsDeleted] BIT NOT NULL
)

INSERT INTO [Users] ([Username], [Password], [IsDeleted])
   VALUES
('dragonwasp', 'dr4g0nw45p', 0),
('anonymous', '4n0nym0u5', 0),
('yourmother123', 'imtoodumbforagoodpassword', 1),
('iknowyourewatching', '12341234', 1),
('thegirlwiththedragontattoo', 'lisbethsalander', 0)