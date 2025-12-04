USE master;

IF EXISTS(SELECT * FROM sys.databases WHERE name='db01')
BEGIN
	ALTER DATABASE db01 SET SINGLE_USER WITH ROLLBACK IMMEDIATE
	DROP DATABASE db01;
END;
GO

CREATE DATABASE db01
GO

USE db01;

CREATE TABLE dbo.Employee
(
emp_id int IDENTITY(1, 1) PRIMARY KEY,
emp_name nvarchar(20),
birthdate date,
salary int
);