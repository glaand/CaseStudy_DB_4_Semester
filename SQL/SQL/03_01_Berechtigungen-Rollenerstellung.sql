/*	
	- Dateiname:		03_01_Berechtigungen-Rollenerstellung.sql
	- Beschreibung:		Rollenerstellung 
	- Autor:			André Glatzl und Alban Ljutvija
	- Arbeitspaktet:	3.2
	- Version:			1.0
	- Datum:			04.08.2020
*/

-- Datenbank selektieren
use Marktverwaltungssystem;
go

-- Rolle für den Kundendienst erstellen
drop role if exists customerService;
go
create role customerService;
go

-- Rolle für die Standortverwaltung erstellen
drop role if exists areaManagement;
go
create role areaManagement;
go

-- Rolle für die Qualitätsinspektion erstellen
drop role if exists qualityInspection;
go
create role qualityInspection;
go

-- Rolle für die Buchhaltung
drop role if exists accounting;
go
create role accounting;
go

-- Rolle für die Informationsplattform
drop role if exists informationPlatform;
go
create role informationPlatform;
go