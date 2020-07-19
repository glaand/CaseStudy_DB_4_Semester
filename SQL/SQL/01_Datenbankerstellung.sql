
/*	
	- Dateiname:		01_Datenbankerstellung.sql
	- Beschreibung:		Datenbankerstellung und Aufbau der Tabellen
	- Autor:			André Glatzl und Alban Ljutvija
	- Arbeitspaktet:	3.1
	- Version:			1.0
	- Datum:			19.07.2020
*/


-- Datenbank erstellen

create database Marktverwaltungssystem;

go

use Marktverwaltungssystem;

go

-- Tabellen erstellen

create table Persons (
person_id			int(11)			not null,
firstname			varchar(50)		not null,
lastname			varchar(50)		not null,
email				varchar(50)		not null,
phone_nr			varchar(20)		not null,
manager_id			int(11)			not null
);
go

create table "Events" (
event_id			int(11)			not null,
employee_id			int(11)			not null,
area_id				int(11)			not null,
event_date			datetime		not null
)
go

create table Landlord (
landlord_id			int(11)			not null
)
go

create table RentalPropertyReservations (
seller_id			int(11)			not null,
rental_property_id	int(11)			not null
)
go

create table Sellers (
seller_id			int(11)			not null,
subscriptons_id		int(11)			not null,
"description"		text			null,
last_update			datetime		not null
)
go

create table Inspectors (
inspector_id		int(11)			not null,
salary_hourly		decimal(6,2)	not null
)
go

create table Visitors (
visitor_id			int(11)			not null,
password			text			not null
)
go



