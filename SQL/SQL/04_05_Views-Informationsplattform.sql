/*	
	- Dateiname:		04_05_Views-Informationsplattform.sql
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
CREATE VIEW viewPersons_informationPlatform AS
SELECT * FROM Persons
go

GRANT SELECT, UPDATE, INSERT, DELETE ON viewPersons_informationPlatform TO informationPlatform;
go

/*
 *	- Tabelle: Events
 */
CREATE VIEW viewEvents_informationPlatform AS
SELECT * FROM Events
go

GRANT SELECT ON viewEvents_informationPlatform TO informationPlatform;
go

/*
 *	- Tabelle: Sellers
 */
CREATE VIEW viewSellers_informationPlatform AS
SELECT * FROM Sellers;
go

GRANT SELECT ON viewSellers_informationPlatform TO informationPlatform;
go

/*
 *	- Tabelle: Visitors
 */
CREATE VIEW viewVisitors_informationPlatform AS
SELECT * FROM Visitors;
go

GRANT SELECT, UPDATE, INSERT, DELETE ON viewVisitors_informationPlatform TO informationPlatform;
go


/*
 *	- Tabelle: Areas
 */
CREATE VIEW viewAreas_informationPlatform AS
SELECT * FROM Areas;
go

GRANT SELECT ON viewAreas_informationPlatform TO informationPlatform;
go

/*
 *	- Tabelle: RentalProperties
 */
CREATE VIEW viewRentalProperties_informationPlatform AS
SELECT * FROM RentalProperties;
go

GRANT SELECT ON viewRentalProperties_informationPlatform TO informationPlatform;
go

/*
 *	- Tabelle: RentalPermissions
 */
CREATE VIEW viewRentalPermissions_informationPlatform AS
SELECT * FROM RentalPermissions;
go

GRANT SELECT ON viewRentalPermissions_informationPlatform TO informationPlatform;
go


/*
 *	- Tabelle: Addresses
 */
CREATE VIEW viewAddresses_informationPlatform AS
SELECT * FROM Addresses;
go

GRANT SELECT ON viewAddresses_informationPlatform TO informationPlatform;
go

/*
 *	- Tabelle: Places
 */
CREATE VIEW viewPlaces_informationPlatform AS
SELECT * FROM Places;
go

GRANT SELECT ON viewPlaces_informationPlatform TO informationPlatform;
go

/*
 *	- Tabelle: Districts
 */
CREATE VIEW viewDistricts_informationPlatform AS
SELECT * FROM Districts;
go

GRANT SELECT ON viewDistricts_informationPlatform TO informationPlatform;
go
