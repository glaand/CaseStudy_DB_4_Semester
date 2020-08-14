/*	
	- Dateiname:		04_04_Views-Buchhaltung.sql
	- Beschreibung:		Views
	- Autor:			André Glatzl und Alban Ljutvija
	- Arbeitspaktet:	3.3
	- Version:			1.0
	- Datum:			14.08.2020
*/

-- Datenbank selektieren
use Marktverwaltungssystem;
go

/*
 *	- Tabelle: Persons
 */
CREATE VIEW viewPersons_accounting AS
SELECT * FROM Persons;
go

GRANT SELECT ON viewPersons_accounting TO accounting;
go

/*
 *	- Tabelle: Sellers
 */
CREATE VIEW viewSellers_accounting AS
SELECT * FROM Sellers;
go

GRANT SELECT ON viewSellers_accounting TO accounting;
go


/*
 *	- Tabelle: Inspectors
 */
CREATE VIEW viewInspectors_accounting AS
SELECT * FROM Inspectors;
go

GRANT SELECT ON viewInspectors_accounting TO accounting;
go

/*
 *	- Tabelle: Employees
 */
CREATE VIEW viewEmployees_accounting AS
SELECT * FROM Employees;
go

GRANT SELECT ON viewEmployees_accounting TO Employees;
go

/*
 *	- Tabelle: Invoices
 */
CREATE VIEW viewInvoices_accounting AS
SELECT * FROM Invoices;
go

GRANT SELECT, UPDATE, INSERT, DELETE ON viewInvoices_accounting TO accounting;
go

/*
 *	- Tabelle: Areas
 */
CREATE VIEW viewAreas_accounting AS
SELECT * FROM Areas;
go

GRANT SELECT ON viewAreas_accounting TO accounting;
go

/*
 *	- Tabelle: RentalProperties
 */
CREATE VIEW viewRentalProperties_accounting AS
SELECT * FROM RentalProperties;
go

GRANT SELECT ON viewRentalProperties_accounting TO accounting;
go

/*
 *	- Tabelle: RentalPermissions
 */
CREATE VIEW viewRentalPermissions_accounting AS
SELECT * FROM RentalPermissions;
go

GRANT SELECT ON viewRentalPermissions_accounting TO accounting;
go

/*
 *	- Tabelle: Addresses
 */
CREATE VIEW viewAddresses_accounting AS
SELECT * FROM Addresses;
go

GRANT SELECT ON viewAddresses_accounting TO accounting;
go

/*
 *	- Tabelle: Places
 */
CREATE VIEW viewPlaces_accounting AS
SELECT * FROM Places;
go

GRANT SELECT ON viewPlaces_accounting TO accounting;
go

/*
 *	- Tabelle: Districts
 */
CREATE VIEW viewDistricts_accounting AS
SELECT * FROM Districts;
go

GRANT SELECT ON viewDistricts_accounting TO accounting;
go

/*
 *	- Tabelle: InvoiceItem
 */
CREATE VIEW viewInvoiceItem_accounting AS
SELECT * FROM InvoiceItem;
go

GRANT SELECT, UPDATE, INSERT, DELETE ON InvoiceItem TO accounting;
go

/*
 *	- Tabelle: Subscriptions
 */
CREATE VIEW viewSubscriptions_accounting AS
SELECT * FROM subscriptions;
go

GRANT SELECT ON viewSubscriptions_accounting TO accounting;
go

/*
 *	- Tabelle: Orders
 */
CREATE VIEW viewOrders_accounting AS
SELECT * FROM Orders;
go

GRANT SELECT, UPDATE, INSERT, DELETE ON viewOrders_accounting TO accounting;
go

/*
 *	- Tabelle: SalaryOrders
 */
CREATE VIEW viewSalaryOrders_accounting AS
SELECT * FROM SalaryOrders;
go

GRANT SELECT, UPDATE, INSERT, DELETE ON viewSalaryOrders_accounting TO accounting;
go

/*
 *	- Tabelle: SubscriptionsOrders
 */
CREATE VIEW viewSubscriptionsOrders_accounting AS
SELECT * FROM SubscriptionsOrders;
go

GRANT SELECT, UPDATE, INSERT, DELETE ON viewSubscriptionsOrders_accounting TO accounting;
go