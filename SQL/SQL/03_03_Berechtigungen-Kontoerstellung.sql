/*	
	- Dateiname:		03_03_Berechtigungen-Kontoerstellung.sql
	- Beschreibung:		Kontoerstellung
	- Autor:			André Glatzl und Alban Ljutvija
	- Arbeitspaktet:	3.3
	- Version:			1.0
	- Datum:			04.08.2020
*/

-- Datenbank selektieren
use Marktverwaltungssystem;
go

-- Neues Konto für Vanda Deplazes für den Kundendienst
CREATE LOGIN VandaDeplazes WITH PASSWORD = 'mBGf5RhF[GqyD=mS', CHECK_POLICY = OFF;
go
CREATE USER VandaDeplazes FOR LOGIN VandaDeplazes WITH DEFAULT_SCHEMA = Marktverwaltungssystem;
go
ALTER ROLE customerService ADD MEMBER VandaDeplazes;
go

-- Neues Konto für Walter Mozart für die Standortverwaltung
CREATE LOGIN WalterMozart WITH PASSWORD = '*xC4$1#w9PvK', CHECK_POLICY = OFF;
go
CREATE USER WalterMozart FOR LOGIN WalterMozart WITH DEFAULT_SCHEMA = Marktverwaltungssystem;
go
ALTER ROLE areaManagement ADD MEMBER WalterMozart;
go

-- Neues Konto für Beat Strikt für die Qualitätsinspektion
CREATE LOGIN BeatStrikt WITH PASSWORD = 'sT!wzbE4bpEX', CHECK_POLICY = OFF;
go
CREATE USER BeatStrikt FOR LOGIN BeatStrikt WITH DEFAULT_SCHEMA = Marktverwaltungssystem;
go
ALTER ROLE qualityInspection ADD MEMBER BeatStrikt;
go

-- Neues Konto für Claudius Numerus für die Buchhaltung
CREATE LOGIN ClaudiusNumerus WITH PASSWORD = '!nvKXXDoBSaM', CHECK_POLICY = OFF;
go
CREATE USER ClaudiusNumerus FOR LOGIN ClaudiusNumerus WITH DEFAULT_SCHEMA = Marktverwaltungssystem;
go
ALTER ROLE accounting ADD MEMBER ClaudiusNumerus;
go

-- Neues Konto für LinuxServer001 für die Informationsplattform
CREATE LOGIN LinuxServer001 WITH PASSWORD = 'ixLjh@Vb1$cv', CHECK_POLICY = OFF;
go
CREATE USER LinuxServer001 FOR LOGIN LinuxServer001 WITH DEFAULT_SCHEMA = Marktverwaltungssystem;
go
ALTER ROLE informationPlatform ADD MEMBER LinuxServer001;
go