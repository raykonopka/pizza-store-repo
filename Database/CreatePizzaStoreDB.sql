-- Setup database
USE MASTER;
GO

CREATE DATABASE PizzaStoreDB;
GO

USE PizzaStoreDB;
GO

CREATE SCHEMA PizzaStore;
GO



-- Create tables and primary keys
CREATE TABLE PizzaStore.Pizzas
(
    Id INT not null IDENTITY(1,1)
    ,PizzaSizeId INT not null
	,CrustTypeId INT not null
	,SauceTypeId INT not null
	,CheeseTypeId INT not null
	,OrderId INT not null
);

ALTER TABLE PizzaStore.Pizzas
    ADD CONSTRAINT pk_pizzas_id primary key clustered (Id);
GO


CREATE TABLE PizzaStore.PizzaSizes
(
    Id INT not null IDENTITY(1,1)
    ,PizzaSize NVARCHAR(100) not null
	,SizePrice DEC(19,4) not null
);

ALTER TABLE PizzaStore.PizzaSizes
    ADD CONSTRAINT pk_pizzasizes_id primary key clustered (Id);
GO


CREATE TABLE PizzaStore.CrustTypes
(
    Id INT not null IDENTITY(1,1)
    ,CrustTypeName NVARCHAR(150) not null
	,CrustPrice DEC(19,4) not null
);

ALTER TABLE PizzaStore.CrustTypes
    ADD CONSTRAINT pk_crusttypes_id primary key clustered (Id);
GO


CREATE TABLE PizzaStore.SauceTypes
(
    Id INT not null IDENTITY(1,1)
    ,SauceTypeName NVARCHAR(150) not null
	,SaucePrice DEC(19,4) not null
);

ALTER TABLE PizzaStore.SauceTypes
    ADD CONSTRAINT pk_saucetypes_id primary key clustered (Id);
GO


CREATE TABLE PizzaStore.CheeseTypes
(
    Id INT not null IDENTITY(1,1)
    ,CheeseTypeName NVARCHAR(150) not null
	,CheesePrice DEC(19,4) not null
);

ALTER TABLE PizzaStore.CheeseTypes
    ADD CONSTRAINT pk_cheesetypes_id primary key clustered (Id);
GO


CREATE TABLE PizzaStore.ToppingLists
(
    Id INT not null IDENTITY(1,1)
    ,PizzaId INT not null
	,ToppingId INT not null
	,ToppingPlacementId INT not null
);

ALTER TABLE PizzaStore.ToppingLists
    ADD CONSTRAINT pk_toppinglists_id primary key clustered (Id);
GO


CREATE TABLE PizzaStore.Toppings
(
    Id INT not null IDENTITY(1,1)
    ,ToppingName NVARCHAR(150) not null
	,Price DEC(19,4) not null
	,ToppingCategoryId INT not null
);

ALTER TABLE PizzaStore.Toppings
    ADD CONSTRAINT pk_toppings_id primary key clustered (Id);
GO


CREATE TABLE PizzaStore.ToppingCategories
(
    Id INT not null IDENTITY(1,1)
    ,CategoryName NVARCHAR(150) not null
);

ALTER TABLE PizzaStore.ToppingCategories
    ADD CONSTRAINT pk_toppingcategories_id primary key clustered (Id);
GO


CREATE TABLE PizzaStore.ToppingPlacements
(
    Id INT not null IDENTITY(1,1)
    ,Placement NVARCHAR(50) not null
);

ALTER TABLE PizzaStore.ToppingPlacements
    ADD CONSTRAINT pk_toppingplacement_id primary key clustered (Id);
GO


CREATE TABLE PizzaStore.Customers
(
    Id INT not null IDENTITY(1,1)
	,Username NVARCHAR(150) not null
	,UserPassword NVARCHAR(150) not null
	,DeliveryAddressId INT not null
);

ALTER TABLE PizzaStore.Customers
    ADD CONSTRAINT pk_customers_id primary key clustered (Id);
GO


CREATE TABLE PizzaStore.Orders
(
    Id INT not null IDENTITY(1,1)
	,Subtotal DEC(19,4) null
	,Taxes DEC(19,4) null
	,Total DEC(19,4) null
	,OrderDateTime DATETIME null
	,CustomerId INT not null
	,PaymentMethodId INT not null
);

ALTER TABLE PizzaStore.Orders
    ADD CONSTRAINT pk_orders_id primary key clustered (Id);
GO


CREATE TABLE PizzaStore.PaymentMethods
(
    Id INT not null IDENTITY(1,1)
	,PaymentName NVARCHAR(150) not null
);

ALTER TABLE PizzaStore.PaymentMethods
    ADD CONSTRAINT pk_paymentmethods_id primary key clustered (Id);
GO


CREATE TABLE PizzaStore.Stores
(
    Id INT not null IDENTITY(1,1)
	,StoreName NVARCHAR(150) not null
	,PhoneNumber NVARCHAR(10) not null
	,StoreAddressId INT not null
);

ALTER TABLE PizzaStore.Stores
    ADD CONSTRAINT pk_stores_id primary key clustered (Id);
GO


CREATE TABLE PizzaStore.DaysOpen
(
    Id INT not null IDENTITY(1,1)
	,StoreId INT not null
	,DayOpenEntryId INT not null
);

ALTER TABLE PizzaStore.DaysOpen
    ADD CONSTRAINT pk_daysopen_id primary key clustered (Id);
GO


CREATE TABLE PizzaStore.DaysOpenEntries
(
    Id INT not null IDENTITY(1,1)
	,DayTitleId INT not null
	,OpenTime TIME(0) not null
	,CloseTime TIME(0) not null
);

ALTER TABLE PizzaStore.DaysOpenEntries
    ADD CONSTRAINT pk_daysopenentries_id primary key clustered (Id);
GO


CREATE TABLE PizzaStore.DayTitles
(
    Id INT not null IDENTITY(1,1)
	,DayTitle NVARCHAR(100) not null
);

ALTER TABLE PizzaStore.DayTitles
    ADD CONSTRAINT pk_daytitles_id primary key clustered (Id);
GO


CREATE TABLE PizzaStore.Addresses
(
    Id INT not null IDENTITY(1,1)
	,Street NVARCHAR(300) not null
	,City NVARCHAR(200) not null
	,LocationState NVARCHAR(150) not null
	,ZipCode INT not null
);

ALTER TABLE PizzaStore.Addresses
    ADD CONSTRAINT pk_addresses_id primary key clustered (Id);
GO



-- Create foreign keys

-- Pizza foreign keys
ALTER TABLE PizzaStore.Pizzas
	ADD CONSTRAINT fk_pizzas_pizzasizeid FOREIGN KEY (PizzaSizeId) REFERENCES PizzaStore.PizzaSizes (Id);
ALTER TABLE PizzaStore.Pizzas
	ADD CONSTRAINT fk_pizzas_crusttypeid FOREIGN KEY (CrustTypeId) REFERENCES PizzaStore.CrustTypes (Id);
ALTER TABLE PizzaStore.Pizzas
    ADD CONSTRAINT fk_pizzas_saucetypeid FOREIGN KEY (SauceTypeId) REFERENCES PizzaStore.SauceTypes (Id); 
ALTER TABLE PizzaStore.Pizzas
    ADD CONSTRAINT fk_pizzas_cheesetypeid FOREIGN KEY (CheeseTypeId) REFERENCES PizzaStore.CheeseTypes (Id); 
ALTER TABLE PizzaStore.Pizzas
    ADD CONSTRAINT fk_pizzas_orderid FOREIGN KEY (OrderId) REFERENCES PizzaStore.Orders (Id);
GO

-- Topping List foreign keys
ALTER TABLE PizzaStore.ToppingLists
    ADD CONSTRAINT fk_toppinglists_pizzaid FOREIGN KEY (PizzaId) REFERENCES PizzaStore.Pizzas (Id);
ALTER TABLE PizzaStore.ToppingLists
    ADD CONSTRAINT fk_toppinglists_toppingid FOREIGN KEY (ToppingId) REFERENCES PizzaStore.Toppings (Id);
ALTER TABLE PizzaStore.ToppingLists
    ADD CONSTRAINT fk_toppinglists_toppingplacementid FOREIGN KEY (ToppingPlacementId) REFERENCES PizzaStore.ToppingPlacements (Id);
GO

-- Topping foreign keys
ALTER TABLE PizzaStore.Toppings
    ADD CONSTRAINT fk_toppings_toppingcategoryid FOREIGN KEY (ToppingCategoryId) REFERENCES PizzaStore.ToppingCategories (Id);
GO

-- Customer foreign keys
ALTER TABLE PizzaStore.Customers
    ADD CONSTRAINT fk_customers_deliveryaddressid FOREIGN KEY (DeliveryAddressId) REFERENCES PizzaStore.Addresses (Id);
GO

-- Order foreign keys
ALTER TABLE PizzaStore.Orders
    ADD CONSTRAINT fk_orders_customerid FOREIGN KEY (CustomerId) REFERENCES PizzaStore.Customers (Id);
ALTER TABLE PizzaStore.Orders
    ADD CONSTRAINT fk_orders_paymentmethodid FOREIGN KEY (PaymentMethodId) REFERENCES PizzaStore.PaymentMethods (Id);
GO

-- Store foreign keys
ALTER TABLE PizzaStore.Stores
    ADD CONSTRAINT fk_stores_storeaddressid FOREIGN KEY (StoreAddressId) REFERENCES PizzaStore.Addresses (Id);
GO

-- Days Open foreign keys
ALTER TABLE PizzaStore.DaysOpen
    ADD CONSTRAINT fk_daysopen_storeid FOREIGN KEY (StoreId) REFERENCES PizzaStore.Stores (Id);
ALTER TABLE PizzaStore.DaysOpen
    ADD CONSTRAINT fk_daysopen_dayopenentryid FOREIGN KEY (DayOpenEntryId) REFERENCES PizzaStore.DaysOpenEntries (Id);
GO

-- Day Open Entry foreign keys
ALTER TABLE PizzaStore.DaysOpenEntries
    ADD CONSTRAINT fk_daysopenentries_daytitleid  FOREIGN KEY (DayTitleId) REFERENCES PizzaStore.DayTitles (Id);



-- Add default data for foreign key dependencies
INSERT INTO PizzaStore.PizzaSizes
VALUES ('Small', 6.00), ('Medium', 8.00), ('Large', 10.00);
GO

INSERT INTO PizzaStore.CheeseTypes
VALUES ('Normal', 0.00), ('Extra', 1.00), ('No Cheese', 0.00);
GO

INSERT INTO PizzaStore.CrustTypes
VALUES ('Normal', 0.00), ('Thin', 0.00);
GO

INSERT INTO PizzaStore.SauceTypes
VALUES ('Normal', 0.00), ('Extra', 0.75), ('Alfredo', 0.00), ('No Sauce', 0.00);
GO

INSERT INTO PizzaStore.ToppingPlacements
VALUES ('Full'), ('Left'), ('Right');
GO

INSERT INTO PizzaStore.ToppingCategories
VALUES ('Vegtables'), ('Meats'), ('Additional Cheeses');
GO

INSERT INTO PizzaStore.Toppings
VALUES 
('Onions', 1.00, 1),
('Green Peppers', 1.00, 1),
('Mushrooms', 1.25, 1),
('Pepperoni', 1.00, 2), 
('Chicken', 1.50, 2),
('Bacon', 1.50, 2),
('Parmesan', 0.75, 3),
('Asiago', 0.75, 3),
('Feta', 0.75, 3);
GO

INSERT INTO PizzaStore.Addresses
VALUES ('123 Imaginary Drive', 'Herndon', 'Virginia', 20171);
GO

INSERT INTO PizzaStore.Customers
VALUES ('rayuser', 'password123', 1);
GO

INSERT INTO PizzaStore.PaymentMethods
VALUES ('Credit Card'), ('Cash');
GO

INSERT INTO PizzaStore.Orders
VALUES (12.00, 0.84, 12.84, '2016-11-10 18:30:00.000', 1, 1);
GO

INSERT INTO PizzaStore.Pizzas
VALUES (2, 1, 1, 1, 1);
GO

INSERT INTO PizzaStore.ToppingLists
VALUES (1, 1, 1), (1, 6, 2), (1, 5, 3), (1, 8, 1);
GO

INSERT INTO PizzaStore.Addresses
VALUES ('123 Pizza Lane', 'Herndon', 'Virginia', 20174);
GO

INSERT INTO PizzaStore.Stores
VALUES ('Herndon Pizza', '7031231234', 2);
GO

INSERT INTO PizzaStore.DayTitles
VALUES 
('Monday'),
('Tuesday'),
('Wednesday'),
('Thursday'),
('Friday'),
('Saturday'),
('Sunday');

INSERT INTO PizzaStore.DaysOpenEntries
VALUES 
(1, '10:00:00', '22:30:00'),
(2, '10:00:00', '22:30:00'),
(3, '10:00:00', '22:30:00'),
(4, '10:00:00', '22:30:00'),
(5, '10:00:00', '22:30:00'),
(6, '8:00:00', '23:00:00'),
(7, '12:00:00', '20:30:00');
GO

INSERT INTO PizzaStore.DaysOpen
VALUES 
(1, 1),
(1, 2),
(1, 3),
(1, 4),
(1, 5),
(1, 6),
(1, 7);
GO



-- Read existing data
SELECT * FROM
PizzaStore.PizzaSizes
GO

SELECT * FROM
PizzaStore.CheeseTypes
GO

SELECT * FROM
PizzaStore.CrustTypes
GO

SELECT * FROM
PizzaStore.SauceTypes
GO

SELECT * FROM
PizzaStore.ToppingPlacements
GO

SELECT * FROM
PizzaStore.ToppingCategories
GO

SELECT * FROM
PizzaStore.Toppings
GO

SELECT * FROM
PizzaStore.Addresses
GO

SELECT * FROM
PizzaStore.Customers
GO

SELECT * FROM
PizzaStore.PaymentMethods
GO

SELECT * FROM
PizzaStore.Orders
GO

SELECT * FROM
PizzaStore.Pizzas
GO

SELECT * FROM
PizzaStore.ToppingLists
GO

SELECT * FROM
PizzaStore.Stores
GO

SELECT * FROM
PizzaStore.DayTitles
GO

SELECT * FROM
PizzaStore.DaysOpenEntries
GO

SELECT * FROM
PizzaStore.DaysOpen
GO



/*
-- Remove existing data
DELETE FROM PizzaStore.Pizzas
WHERE Id = 4;
GO
*/

