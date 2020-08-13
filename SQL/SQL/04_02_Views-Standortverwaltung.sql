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

-- Employees für Standortverwaltung
CREATE VIEW viewEmployees_areaManagement AS
SELECT employee_id, employee_role_id, NULL as hourly_salary FROM Employees;
go

GRANT SELECT ON viewEmployees_areaManagement TO areaManagement;
go

-- EmployeeRoles für Standortverwaltung
CREATE VIEW viewEmployeeRoles_areaManagement AS
SELECT employee_role_id, name FROM EmployeeRoles;
go

GRANT SELECT ON viewEmployeeRoles_areaManagement TO areaManagement;
go