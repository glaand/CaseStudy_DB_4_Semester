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
drop role if exists customer_service;
go
create role customer_service;
go

-- Rolle f�r die Standortverwaltung erstellen
drop role if exists area_management;
go
create role area_management;
go

-- Rolle f�r die Qualit�tsinspektion erstellen
drop role if exists quality_inspection;
go
create role quality_inspection;
go

-- Rolle f�r die Buchhaltung
drop role if exists accounting;
go
create role accounting;
go

-- Rolle f�r die Informationsplattform
drop role if exists information_platform;
go
create role information_platform;
go