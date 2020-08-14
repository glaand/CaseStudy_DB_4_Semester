/*	
	- Dateiname:		04_01_Views-Kundendienst.sql
	- Beschreibung:		Views
	- Autor:			Andr? Glatzl und Alban Ljutvija
	- Arbeitspaktet:	3.3
	- Version:			1.0
	- Datum:			13.08.2020
*/

-- Datenbank selektieren
use Marktverwaltungssystem;
go

/*
 *	- Tabelle: Persons
 */
CREATE VIEW viewPersons_qualityInspection AS
SELECT * FROM Persons;
go

GRANT SELECT ON viewPersons_qualityInspection TO qualityInspection;
go

/*
 *	- Tabelle: Sellers
 */
CREATE VIEW viewSellers_qualityInspection AS
SELECT * FROM Sellers;
go

GRANT SELECT ON viewSellers_qualityInspection TO qualityInspection;
go

/*
 *	- Tabelle: Areas
 */
CREATE VIEW viewAreas_qualityInspection AS
SELECT * FROM Areas;
go

GRANT SELECT ON viewAreas_qualityInspection;
go

/*
 *	- Tabelle: RentalProperties
 */
CREATE VIEW viewRentalProperties_qualityInspection AS
SELECT * FROM RentalProperties;
go

GRANT SELECT ON viewRentalProperties_qualityInspection TO qualityInspection;
go

/*
 *	- Tabelle: RentalPermissions
 */
CREATE VIEW viewRentalPermissions_qualityInspection AS
SELECT * FROM RentalPermissions;
go

GRANT SELECT ON viewRentalPermissions_qualityInspection TO qualityInspection;
go

/*
 *	- Tabelle: QualityChecks
 */
CREATE VIEW viewQualityChecks_qualityInspection AS
SELECT * FROM QualityChecks;
go

GRANT SELECT, UPDATE, INSERT, DELETE ON viewQualityChecks_qualityInspection TO qualityInspection;
go

/*
 *	- Tabelle: Addresses
 */
CREATE VIEW viewAddresses_qualityInspection AS
SELECT * FROM Addresses;
go

GRANT SELECT ON viewAddresses_qualityInspection TO qualityInspection;
go

/*
 *	- Tabelle: Places
 */
CREATE VIEW viewPlaces_qualityInspection AS
SELECT * FROM Places;
go

GRANT SELECT ON viewPlaces_qualityInspection TO qualityInspection;
go

/*
 *	- Tabelle: Districts
 */
CREATE VIEW viewDistricts_qualityInspection AS
SELECT * FROM Districts;
go

GRANT SELECT ON viewDistricts_qualityInspection TO qualityInspection;
go