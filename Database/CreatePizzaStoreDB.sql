-- Setup database
USE master;
GO

CREATE DATABASE PizzaStoreDB;
GO

USE PizzaStoreDB;
GO

CREATE SCHEMA PizzaStore;
GO


-- Create tables and primary keys
CREATE TABLE PizzaStore.Product
(
    Id int not null IDENTITY(1,1)
    ,Price DEC(19,4) not null
    ,Category NVARCHAR(150) not null
    ,Credits INT not null 
);

ALTER TABLE Registration.Courses
    ADD CONSTRAINT pk_courses_id primary key clustered (Id);
GO