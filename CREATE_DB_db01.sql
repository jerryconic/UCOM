USE master;

IF EXISTS(SELECT * FROM sys.databases WHERE name = 'db01')
BEGIN
	ALTER DATABASE db01 SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
	DROP DATABASE db01;
END
GO
CREATE DATABASE db01;
GO
USE db01;

CREATE TABLE dbo.Product
(
ProductID int,
ProductName nvarchar(20),
Price int
);

INSERT INTO dbo.Product(ProductID, ProductName, Price)
VALUES(1, 'A-Product', 9000);

UPDATE dbo.Product
SET ProductName='CPU', PRICE=12000
WHERE ProductID = 1;

DELETE FROM dbo.Product
WHERE ProductID = 1;

SELECT * FROM dbo.Product;