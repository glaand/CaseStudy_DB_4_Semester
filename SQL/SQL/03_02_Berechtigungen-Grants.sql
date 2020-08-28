/*	
	- Dateiname:		03_02_Berechtigungen-Grants.sql
	- Beschreibung:		Grants 
	- Autor:			André Glatzl und Alban Ljutvija
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
GRANT SELECT, UPDATE, INSERT, DELETE ON Persons TO customerService;
go
GRANT SELECT, UPDATE, INSERT, DELETE ON Persons TO areaManagement;
go
GRANT SELECT ON Persons TO qualityInspection;
go
GRANT SELECT ON Persons TO accounting;
go
GRANT SELECT, UPDATE, INSERT, DELETE ON Persons TO informationPlatform;
go

/*
 *	- Tabelle: Events
 */
GRANT SELECT, UPDATE, INSERT, DELETE ON Events TO customerService;
go
GRANT SELECT ON Events TO informationPlatform;
go

/*
 *	- Tabelle: RentalPropertyReservations
 */
GRANT SELECT, UPDATE, INSERT, DELETE ON RentalPropertyReservations TO customerService;
go

/*
 *	- Tabelle: Landlords
 */
GRANT SELECT, UPDATE, INSERT, DELETE ON Landlords TO customerService;
go
GRANT SELECT, UPDATE, INSERT, DELETE ON Landlords TO areaManagement;
go

/*
 *	- Tabelle: Sellers
 */
GRANT SELECT, UPDATE, INSERT, DELETE ON Sellers TO customerService;
go
GRANT SELECT ON Sellers TO areaManagement;
go
GRANT SELECT ON Sellers TO qualityInspection;
go
GRANT SELECT ON Sellers TO accounting;
go
GRANT SELECT ON Sellers TO informationPlatform;
go

/*
 *	- Tabelle: Inspectors
 */
GRANT SELECT ON Inspectors TO customerService;
go
GRANT SELECT ON Inspectors TO areaManagement;
go
GRANT SELECT ON Inspectors TO accounting;
go

/*
 *	- Tabelle: Visitors
 */
GRANT SELECT ON Visitors TO customerService;
go
GRANT SELECT ON Visitors TO areaManagement;
go
GRANT SELECT, UPDATE, INSERT, DELETE ON Visitors TO informationPlatform;
go

/*
 *	- Tabelle: Employees
 */
GRANT SELECT ON Employees TO customerService;
go
GRANT SELECT ON Employees TO accounting;
go
GRANT SELECT ON Employees TO areaManagement;
go

/*
 *	- Tabelle: EmployeeRoles
 */
GRANT SELECT ON EmployeeRoles TO customerService;
go
GRANT SELECT ON EmployeeRoles TO areaManagement;
go
GRANT SELECT ON EmployeeRoles TO accounting;
go

/*
 *	- Tabelle: CreditChecks
 */
GRANT SELECT, UPDATE, INSERT, DELETE ON CreditChecks TO customerService;
go

/*
 *	- Tabelle: Invoices
 */
GRANT SELECT, UPDATE, INSERT, DELETE ON Invoices TO customerService;
go
GRANT SELECT, UPDATE, INSERT, DELETE ON Invoices TO accounting;
go

/*
 *	- Tabelle: Areas
 */
GRANT SELECT ON Areas TO customerService;
go
GRANT SELECT, UPDATE, INSERT, DELETE ON Areas TO areaManagement;
go
GRANT SELECT ON Areas TO qualityInspection;
go
GRANT SELECT ON Areas TO accounting;
go
GRANT SELECT ON Areas TO informationPlatform;
go

/*
 *	- Tabelle: RentalProperties
 */
GRANT SELECT ON RentalProperties TO customerService;
go
GRANT SELECT, UPDATE, INSERT, DELETE ON RentalProperties TO areaManagement;
go
GRANT SELECT ON RentalProperties TO qualityInspection;
go
GRANT SELECT ON RentalProperties TO accounting;
go
GRANT SELECT ON RentalProperties TO informationPlatform;
go

/*
 *	- Tabelle: RentalPermissions
 */
GRANT SELECT ON RentalPermissions TO customerService;
go
GRANT SELECT, UPDATE, INSERT, DELETE ON RentalPermissions TO areaManagement;
go
GRANT SELECT ON RentalPermissions TO qualityInspection;
go
GRANT SELECT ON RentalPermissions TO accounting;
go
GRANT SELECT ON RentalPermissions TO informationPlatform;
go

/*
 *	- Tabelle: QualityChecks
 */
GRANT SELECT, UPDATE, INSERT, DELETE ON QualityChecks TO customerService;
go
GRANT SELECT, UPDATE, INSERT, DELETE ON QualityChecks TO qualityInspection;
go

/*
 *	- Tabelle: Addresses
 */
GRANT SELECT ON Addresses TO customerService;
go
GRANT SELECT ON Addresses TO areaManagement;
go
GRANT SELECT ON Addresses TO qualityInspection;
go
GRANT SELECT ON Addresses TO accounting;
go
GRANT SELECT ON Addresses TO informationPlatform;
go

/*
 *	- Tabelle: Places
 */
GRANT SELECT ON Places TO customerService;
go
GRANT SELECT ON Places TO areaManagement;
go
GRANT SELECT ON Places TO qualityInspection;
go
GRANT SELECT ON Places TO accounting;
go
GRANT SELECT ON Places TO informationPlatform;
go

/*
 *	- Tabelle: Districts
 */
GRANT SELECT ON Districts TO customerService;
go
GRANT SELECT ON Districts TO areaManagement;
go
GRANT SELECT ON Districts TO qualityInspection;
go
GRANT SELECT ON Districts TO accounting;
go
GRANT SELECT ON Districts TO informationPlatform;
go

/*
 *	- Tabelle: InvoiceItem
 */
GRANT SELECT, UPDATE, INSERT, DELETE ON InvoiceItem TO customerService;
go
GRANT SELECT, UPDATE, INSERT, DELETE ON InvoiceItem TO accounting;
go

/*
 *	- Tabelle: Subscriptions
 */
GRANT SELECT, UPDATE, INSERT, DELETE ON Subscriptions TO customerService;
go
GRANT SELECT ON Subscriptions TO accounting;
go

/*
 *	- Tabelle: Orders
 */
GRANT SELECT, UPDATE, INSERT, DELETE ON Orders TO customerService;
go
GRANT SELECT, UPDATE, INSERT, DELETE ON Orders TO accounting;
go

/*
 *	- Tabelle: SalaryOrders
 */
GRANT SELECT, UPDATE, INSERT, DELETE ON SalaryOrders TO accounting;
go

/*
 *	- Tabelle: SubscriptionsOrders
 */
GRANT SELECT, UPDATE, INSERT, DELETE ON SubscriptionsOrders TO customerService;
go
GRANT SELECT, UPDATE, INSERT, DELETE ON SubscriptionsOrders TO accounting;
go