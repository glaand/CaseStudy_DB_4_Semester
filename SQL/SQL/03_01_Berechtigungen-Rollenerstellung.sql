/*	
	- Dateiname:		03_01_Berechtigungen-Rollenerstellung.sql
	- Beschreibung:		Rollenerstellung 
	- Autor:			Andr� Glatzl und Alban Ljutvija
	- Arbeitspaktet:	3.2
	- Version:			1.0
	- Datum:			04.08.2020
*/

-- Datenbank selektieren
use Marktverwaltungssystem;
go

-- Rolle f�r den Kundendienst erstellen
drop role if exists customerService;
go
create role customerService;
go

-- Rolle f�r die Standortverwaltung erstellen
drop role if exists areaManagement;
go
create role areaManagement;
go

-- Rolle f�r die Qualit�tsinspektion erstellen
drop role if exists qualityInspection;
go
create role qualityInspection;
go

-- Rolle f�r die Buchhaltung
drop role if exists accounting;
go
create role accounting;
go

-- Rolle f�r die Informationsplattform
drop role if exists informationPlatform;
go
create role informationPlatform;
go