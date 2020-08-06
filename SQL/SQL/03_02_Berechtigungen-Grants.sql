/*	
	- Dateiname:		03_02_Berechtigungen-Grants.sql
	- Beschreibung:		Grants 
	- Autor:			Andr� Glatzl und Alban Ljutvija
	- Arbeitspaktet:	3.2
	- Version:			1.0
	- Datum:			04.08.2020
*/

-- Datenbank selektieren
use Marktverwaltungssystem;
go

/*
 *	- Tabelle: Persons
 */
GRANT SELECT, UPDATE, INSERT ON Persons TO customer_service;
go
GRANT SELECT, UPDATE, INSERT ON Persons TO area_management;
go
GRANT SELECT ON Persons TO quality_inspection;
go
GRANT SELECT ON Persons TO accounting;
go
GRANT SELECT, UPDATE, INSERT ON Persons TO information_platform;
go

/*
 *	- Tabelle: Events
 */
GRANT SELECT, UPDATE, INSERT ON Events TO customer_service;
go
GRANT SELECT ON Events TO information_platform;
go

/*
 *	- Tabelle: RentalPropertyReservations
 */
GRANT SELECT, UPDATE, INSERT on RentalPropertyReservations TO customer_service;
go

/*
 *	- Tabelle: Landlords
 */
GRANT SELECT, UPDATE, INSERT on Landlords TO customer_service;
go
GRANT SELECT, UPDATE, INSERT on Landlords TO area_management;
go

/*
 *	- Tabelle: Sellers
 */
GRANT SELECT, UPDATE, INSERT ON Sellers TO customer_service;
go
GRANT SELECT ON Sellers TO quality_inspection;
go
GRANT SELECT ON Sellers TO accounting;
go
GRANT SELECT ON Sellers TO information_platform;
go

/*
 *	- Tabelle: Inspectors
 */
GRANT SELECT ON Inspectors TO accounting;
go

/*
 *	- Tabelle: Visitors
 */
GRANT SELECT, UPDATE, INSERT ON Visitors TO information_platform;
go

/*
 *	- Tabelle: Employees
 */
GRANT SELECT ON Employees TO accounting;
go

/*
 *	- Tabelle: EmployeeRoles
 */
-- NOBODY

/*
 *	- Tabelle: CreditChecks
 */
GRANT SELECT, UPDATE, INSERT ON CreditChecks TO customer_service;
go

/*
 *	- Tabelle: Invoices
 */
GRANT SELECT, UPDATE, INSERT ON Invoices TO customer_service;
go
GRANT SELECT, UPDATE, INSERT ON Invoices TO accounting;
go

/*
 *	- Tabelle: Areas
 */
GRANT SELECT ON Areas TO customer_service;
go
GRANT SELECT, UPDATE, INSERT ON Areas TO area_management;
go
GRANT SELECT ON Areas TO quality_inspection;
go
GRANT SELECT ON Areas TO accounting;
go
GRANT SELECT ON Areas TO information_platform;
go

/*
 *	- Tabelle: RentalProperties
 */
GRANT SELECT ON RentalProperties TO customer_service;
go
GRANT SELECT, UPDATE, INSERT ON RentalProperties TO area_management;
go
GRANT SELECT ON RentalProperties TO quality_inspection;
go
GRANT SELECT ON RentalProperties TO accounting;
go
GRANT SELECT ON RentalProperties TO information_platform;
go

/*
 *	- Tabelle: RentalPermissions
 */
GRANT SELECT ON RentalProperties TO customer_service;
go
GRANT SELECT, UPDATE, INSERT ON RentalProperties TO area_management;
go
GRANT SELECT ON RentalProperties TO quality_inspection;
go
GRANT SELECT ON RentalProperties TO accounting;
go
GRANT SELECT ON RentalProperties TO information_platform;
go

/*
 *	- Tabelle: QualityChecks
 */
GRANT SELECT, UPDATE, INSERT ON QualityChecks TO customer_service;
go
GRANT SELECT, UPDATE, INSERT ON QualityChecks TO quality_inspection;
go

/*
 *	- Tabelle: Addresses
 */
GRANT SELECT ON Addresses TO customer_service;
go
GRANT SELECT ON Addresses TO area_management;
go
GRANT SELECT ON Addresses TO quality_inspection;
go
GRANT SELECT ON Addresses TO accounting;
go
GRANT SELECT ON Addresses TO information_platform;
go

/*
 *	- Tabelle: Places
 */
GRANT SELECT ON Places TO customer_service;
go
GRANT SELECT ON Places TO area_management;
go
GRANT SELECT ON Places TO quality_inspection;
go
GRANT SELECT ON Places TO accounting;
go
GRANT SELECT ON Places TO information_platform;
go

/*
 *	- Tabelle: Districts
 */
GRANT SELECT ON Districts TO customer_service;
go
GRANT SELECT ON Districts TO area_management;
go
GRANT SELECT ON Districts TO quality_inspection;
go
GRANT SELECT ON Districts TO accounting;
go
GRANT SELECT ON Districts TO information_platform;
go

/*
 *	- Tabelle: InvoiceItem
 */
GRANT SELECT, UPDATE, INSERT ON InvoiceItem TO customer_service;
go
GRANT SELECT, UPDATE, INSERT ON InvoiceItem TO accounting;
go

/*
 *	- Tabelle: Subscriptions
 */
GRANT SELECT, UPDATE, INSERT ON Subscriptions TO customer_service;
go
GRANT SELECT Subscriptions TO accounting;
go

/*
 *	- Tabelle: Orders
 */
GRANT SELECT, UPDATE, INSERT ON Orders TO customer_service;
go
GRANT SELECT, UPDATE, INSERT ON Orders TO accounting;
go

/*
 *	- Tabelle: SalaryOrders
 */
GRANT SELECT, UPDATE, INSERT ON SalaryOrders TO accounting;
go

/*
 *	- Tabelle: SubscriptionsOrders
 */
GRANT SELECT, UPDATE, INSERT ON SubscriptionsOrders TO customer_service;
go
GRANT SELECT, UPDATE, INSERT ON SubscriptionsOrders TO accounting;
go