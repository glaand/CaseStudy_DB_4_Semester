/*	
	- Dateiname:		04_02_Views-Standortverwaltung.sql
	- Beschreibung:		Kontoerstellung
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
CREATE VIEW viewPersons_areaManagement AS
SELECT * FROM Persons;
go

GRANT SELECT, UPDATE, INSERT, DELETE ON viewPersons_areaManagement TO areaManagement;
go

/*
 *	- Tabelle: Landlords
 */
CREATE VIEW viewLandlords_areaManagement AS
SELECT * FROM Landlords;
go

GRANT SELECT, UPDATE, INSERT, DELETE ON viewLandlords_areaManagement TO areaManagement;
go


/*
 *	- Tabelle: Areas
 */
CREATE VIEW viewAreas_areaManagement AS
SELECT * FROM Areas;
go

GRANT SELECT, UPDATE, INSERT, DELETE ON viewAreas_areaManagement TO areaManagement;
go

/*
 *	- Tabelle: RentalProperties
 */
CREATE VIEW viewRentalProperties_areaManagement AS
SELECT * FROM RentalProperties;
go

GRANT SELECT, UPDATE, INSERT, DELETE ON viewRentalProperties_areaManagement TO areaManagement;
go

/*
 *	- Tabelle: RentalPermissions
 */
CREATE VIEW viewRentalPermissions_areaManagement AS
SELECT * FROM RentalPermissions;
go

GRANT SELECT, UPDATE, INSERT, DELETE ON viewRentalPermissions_areaManagement TO areaManagement;
go

/*
 *	- Tabelle: Addresses
 */
CREATE VIEW viewAddresses_areaManagement AS
SELECT * FROM Addresses;
go

GRANT SELECT ON viewAddresses_areaManagement TO areaManagement;
go

/*
 *	- Tabelle: Places
 */
CREATE VIEW viewPlaces_areaManagement AS
SELECT * FROM Places;
go

GRANT SELECT ON viewPlaces_areaManagement TO areaManagement;
go

/*
 *	- Tabelle: Districts
 */
CREATE VIEW viewDistricts_areaManagement AS
SELECT * FROM Districts;
go

GRANT SELECT ON viewDistricts_areaManagement TO areaManagement;
go