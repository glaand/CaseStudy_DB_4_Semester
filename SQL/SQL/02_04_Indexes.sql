/*	
	- Dateiname:		02_04_Indexes.sql
	- Beschreibung:		Konditionen und Bedingungen
	- Autor:			André Glatzl und Alban Ljutvija
	- Arbeitspaktet:	3.1
	- Version:			1.0
	- Datum:			01.09.2020
*/

-- Selektierung der Datenbank 

use Marktverwaltungssystem;

-- Persons
CREATE NONCLUSTERED INDEX IX_Persons_ManagerID
	ON Persons (manager_id);
GO
CREATE NONCLUSTERED INDEX IX_Persons_AddressID
	ON Persons (address_id);
GO
CREATE NONCLUSTERED INDEX IX_Persons_SQLUserID
	ON Persons (sql_user_id);
GO

-- Events
CREATE NONCLUSTERED INDEX IX_Events_EmployeeID
	ON Events (employee_id);
GO
CREATE NONCLUSTERED INDEX IX_Events_AreaID
	ON Events (area_id);
GO

-- Sellers
CREATE NONCLUSTERED INDEX IX_Sellers_SubscriptionID
	ON Sellers (subscription_id);
GO

-- Employees
CREATE NONCLUSTERED INDEX IX_Employees_EmployeeRoleID
	ON Employees (employee_role_id);
GO

-- CreditChecks
CREATE NONCLUSTERED INDEX IX_CreditChecks_EmployeeID
	ON CreditChecks (employee_id);
GO
CREATE NONCLUSTERED INDEX IX_CreditChecks_SellerID
	ON CreditChecks (seller_id);
GO

-- Invoices
CREATE NONCLUSTERED INDEX IX_Invoices_PersonID
	ON Invoices (person_id);
GO

-- Areas
CREATE NONCLUSTERED INDEX IX_Areas_AddressID
	ON Areas (address_id);
GO
CREATE NONCLUSTERED INDEX IX_Areas_EmployeeID
	ON Areas (employee_id);
GO
CREATE NONCLUSTERED INDEX IX_Areas_LandlordID
	ON Areas (landlord_id);
GO

-- RentalProperties
CREATE NONCLUSTERED INDEX IX_RentalProperties_AreaID
	ON RentalProperties (area_id);
GO

-- RentalPermissions
CREATE NONCLUSTERED INDEX IX_RentalPermissions_AreaID
	ON RentalPermissions (area_id);
GO

-- QualityChecks
CREATE NONCLUSTERED INDEX IX_QualityChecks_InspectorID
	ON QualityChecks (inspector_id);
GO
CREATE NONCLUSTERED INDEX IX_QualityChecks_SellerID
	ON QualityChecks (seller_id);
GO

-- Addresses
CREATE NONCLUSTERED INDEX IX_Addresses_PlaceID
	ON Addresses (place_id);
GO

-- Places
CREATE NONCLUSTERED INDEX IX_Places_DistrictID
	ON Places (district_id);
GO

-- InvoiceItem
CREATE NONCLUSTERED INDEX IX_InvoiceItem_InvoiceID
	ON InvoiceItem (invoice_id);
GO
CREATE NONCLUSTERED INDEX IX_InvoiceItem_OrderID
	ON InvoiceItem (order_id);
GO

-- SubscriptionOrders
CREATE NONCLUSTERED INDEX IX_SubscriptionsOrders_SubscriptionID
	ON SubscriptionsOrders (subscription_id);
GO

