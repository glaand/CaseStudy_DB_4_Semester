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
ALTER ROLE customer_service ADD MEMBER VandaDeplazes;
go

-- Neues Konto f�r Walter Mozart f�r die Standortverwaltung
CREATE LOGIN WalterMozart WITH PASSWORD = '*xC4$1#w9PvK', CHECK_POLICY = OFF;
go
CREATE USER WalterMozart FOR LOGIN WalterMozart WITH DEFAULT_SCHEMA = Marktverwaltungssystem;
go
ALTER ROLE area_management ADD MEMBER WalterMozart;
go

-- Neues Konto f�r Beat Strikt f�r die Qualit�tsinspektion
CREATE LOGIN BeatStrikt WITH PASSWORD = 'sT!wzbE4bpEX', CHECK_POLICY = OFF;
go
CREATE USER BeatStrikt FOR LOGIN BeatStrikt WITH DEFAULT_SCHEMA = Marktverwaltungssystem;
go
ALTER ROLE quality_inspection ADD MEMBER BeatStrikt;
go

-- Neues Konto f�r Claudius Numerus f�r die Buchhaltung
CREATE LOGIN ClaudiusNumerus WITH PASSWORD = '!nvKXXDoBSaM', CHECK_POLICY = OFF;
go
CREATE USER ClaudiusNumerus FOR LOGIN ClaudiusNumerus WITH DEFAULT_SCHEMA = Marktverwaltungssystem;
go
ALTER ROLE accounting ADD MEMBER ClaudiusNumerus;
go

-- Neues Konto f�r LinuxServer001 f�r die Informationsplattform
CREATE LOGIN LinuxServer001 WITH PASSWORD = 'ixLjh@Vb1$cv', CHECK_POLICY = OFF;
go
CREATE USER LinuxServer001 FOR LOGIN LinuxServer001 WITH DEFAULT_SCHEMA = Marktverwaltungssystem;
go
ALTER ROLE information_platform ADD MEMBER LinuxServer001;
go