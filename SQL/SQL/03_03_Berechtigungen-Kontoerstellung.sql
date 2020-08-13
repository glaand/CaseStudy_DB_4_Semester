/*	
	- Dateiname:		03_03_Berechtigungen-Kontoerstellung.sql
	- Beschreibung:		Kontoerstellung
	- Autor:			Andr� Glatzl und Alban Ljutvija
	- Arbeitspaktet:	3.2
	- Version:			1.0
	- Datum:			04.08.2020
*/

-- Datenbank selektieren
use Marktverwaltungssystem;
go

-- Neues Konto f�r Vanda Deplazes f�r den Kundendienst
CREATE LOGIN VandaDeplazes WITH PASSWORD = 'mBGf5RhF[GqyD=mS', CHECK_POLICY = OFF;
go
CREATE USER VandaDeplazes FOR LOGIN VandaDeplazes WITH DEFAULT_SCHEMA = Marktverwaltungssystem;
go
ALTER ROLE customerService ADD MEMBER VandaDeplazes;
go

-- Query zum Persons erstellen mit sql_user_id von sys.database_principals
INSERT INTO Persons (firstname, lastname, email, phone_nr, manager_id, address_id, sql_user_id) 
VALUES 
(
	'Vanda', 
	'Deplazes', 
	'vandadeplazes@gmail.com', 
	'0792009988', 
	null, 
	1,
	(select principal_id from sys.database_principals where "name" = 'VandaDeplazes')
);
go

-- Query zum Employee erstellen für Vanda
INSERT INTO Employees (employee_id, employee_role_id, hourly_salary)
VALUES 
(
	(SELECT person_id FROM Persons WHERE email = 'vandadeplazes@gmail.com'), 
	(SELECT employee_role_id FROM EmployeeRoles WHERE "name" = 'Kundendienst'),
	25.00
);
go





-- Neues Konto f�r Walter Mozart f�r die Standortverwaltung
CREATE LOGIN WalterMozart WITH PASSWORD = '*xC4$1#w9PvK', CHECK_POLICY = OFF;
go
CREATE USER WalterMozart FOR LOGIN WalterMozart WITH DEFAULT_SCHEMA = Marktverwaltungssystem;
go
ALTER ROLE areaManagement ADD MEMBER WalterMozart;
go
-- Query zum Persons erstellen mit sql_user_id von sys.database_principals
INSERT INTO Persons (firstname, lastname, email, phone_nr, manager_id, address_id, sql_user_id) 
VALUES 
(
	'Walter', 
	'Mozart', 
	'waltermozart@gmail.com', 
	'0761234455', 
	(SELECT person_id FROM Persons WHERE email = 'vandadeplazes@gmail.com'), 
	2,
	(select principal_id from sys.database_principals where "name" = 'WalterMozart')
);
go

-- Query zum Employee erstellen für Walter
INSERT INTO Employees (employee_id, employee_role_id, hourly_salary)
VALUES 
(
	(SELECT person_id FROM Persons WHERE email = 'waltermozart@gmail.com'), 
	(SELECT employee_role_id FROM EmployeeRoles WHERE "name" = 'Standortverwalter'),
	30.00
);
go










-- Neues Konto f�r Beat Strikt f�r die Qualit�tsinspektion
CREATE LOGIN BeatStrikt WITH PASSWORD = 'sT!wzbE4bpEX', CHECK_POLICY = OFF;
go
CREATE USER BeatStrikt FOR LOGIN BeatStrikt WITH DEFAULT_SCHEMA = Marktverwaltungssystem;
go
ALTER ROLE qualityInspection ADD MEMBER BeatStrikt;
go
-- Query zum Persons erstellen mit sql_user_id von sys.database_principals
INSERT INTO Persons (firstname, lastname, email, phone_nr, manager_id, address_id, sql_user_id) 
VALUES 
(
	'Beat', 
	'Strikt', 
	'beatstrikt@gmail.com', 
	'0769998877', 
	(SELECT person_id FROM Persons WHERE email = 'vandadeplazes@gmail.com'), 
	3,
	(select principal_id from sys.database_principals where "name" = 'BeatStrikt')
);
go

-- Query zum Employee erstellen für Beat
INSERT INTO Employees (employee_id, employee_role_id, hourly_salary)
VALUES 
(
	(SELECT person_id FROM Persons WHERE email = 'beatstrikt@gmail.com'), 
	(SELECT employee_role_id FROM EmployeeRoles WHERE "name" = 'Qualitätsinspektion'),
	70.00
);
go










-- Neues Konto f�r Claudius Numerus f�r die Buchhaltung
CREATE LOGIN ClaudiusNumerus WITH PASSWORD = '!nvKXXDoBSaM', CHECK_POLICY = OFF;
go
CREATE USER ClaudiusNumerus FOR LOGIN ClaudiusNumerus WITH DEFAULT_SCHEMA = Marktverwaltungssystem;
go
ALTER ROLE accounting ADD MEMBER ClaudiusNumerus;
go
-- Query zum Persons erstellen mit sql_user_id von sys.database_principals
INSERT INTO Persons (firstname, lastname, email, phone_nr, manager_id, address_id, sql_user_id) 
VALUES 
(
	'Claudius', 
	'Numerus', 
	'claudiusnumerus@gmail.com', 
	'0782367283', 
	(SELECT person_id FROM Persons WHERE email = 'waltermozart@gmail.com'), 
	4,
	(select principal_id from sys.database_principals where "name" = 'ClaudiusNumerus')
);
go

-- Query zum Employee erstellen für Beat
INSERT INTO Employees (employee_id, employee_role_id, hourly_salary)
VALUES 
(
	(SELECT person_id FROM Persons WHERE email = 'claudiusnumerus@gmail.com'), 
	(SELECT employee_role_id FROM EmployeeRoles WHERE "name" = 'Buchhaltung'),
	70.00
);
go








-- Neues Konto f�r LinuxServer001 f�r die Informationsplattform
CREATE LOGIN LinuxServer001 WITH PASSWORD = 'ixLjh@Vb1$cv', CHECK_POLICY = OFF;
go
CREATE USER LinuxServer001 FOR LOGIN LinuxServer001 WITH DEFAULT_SCHEMA = Marktverwaltungssystem;
go
ALTER ROLE informationPlatform ADD MEMBER LinuxServer001;
go