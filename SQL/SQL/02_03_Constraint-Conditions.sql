/*	
	- Dateiname:		02_03_Constraint-Conditions.sql
	- Beschreibung:		Konditionen und Bedingungen
	- Autor:			André Glatzl und Alban Ljutvija
	- Arbeitspaktet:	3.1
	- Version:			1.0
	- Datum:			21.07.2020
*/

--Selektierung der Datenbank 

use Marktverwaltungssystem;

-- E-Mail Adresse muss einzigartig sein 
alter table Persons
add constraint UQ_Email unique (email)
go

-- gültige E-Mail Adresse
alter table Persons 
add constraint CH_Email check (email LIKE '%_@_%');

alter table Persons 
add constraint CH_Phone check (phone_nr not like '%[^0-9]%');

-- Das Eventdatum darf nicht in der Vergangenheit stattfinden

alter table "Events"
add constraint CH_Date check (event_date >= CURRENT_TIMESTAMP);
go

-- Ein CheckUpdate darf nicht in der Zukunft stattfinden.
alter table Sellers
add constraint CH_Update check (last_update <= CURRENT_TIMESTAMP);
go

-- Grundlohnvergabe der Inspektoren

alter table Inspectors
add default (25.00) for hourly_salary;
go

-- Grundlohnvergabe der Angestellten
alter table Employees
add default (30.00) for hourly_salary;
go

-- Grundwert der Mehrwertsteuer festlegen.
alter table Invoices
add default (7.70) for vat;
go

-- Ein Bezirk ist einmalig.
alter table Districts
add constraint UQ_district unique (district);
go

-- Besichtigungsdatum darf nicht nach Akzeptanzdatum stattfinden.
alter table CreditChecks
add constraint CC_Date check (visit_date < approved_on or approved_on is null);
go

-- Round-Checks bearbeiten
alter table QualityChecks
add default (1) for round_check;
go

alter table QualityChecks
add constraint QC_RoundCheck check (round_check BETWEEN 1 AND 2);
go

-- Postleitzahl Check
alter table Places
add constraint PLZ check (place_id BETWEEN 1000 AND 9999);
go

-- Werte für duration müssen grösser als 0 sein
alter table Subscriptions
add constraint unsigned check ("duration" > 0);
go

-- Werte für square müssen grösser als 0 sein
alter table Areas
add constraint "Areas_square" check ("square" > 0);
go

-- Werte für square müssen grösser als 0 sein
alter table RentalProperties
add constraint "RP_square" check ("square" > 0);
go

-- Breitengrade min. & max. Werte
alter table Areas
add constraint latitude_range check (latitude BETWEEN -90 AND 90);
go

-- Längengrade min. & max. Werte
alter table Areas
add constraint longitude_range check (longitude BETWEEN -180 AND 80);
go

-- Zahlungsdatum muss grösser als Erstelldatum sein
alter table Invoices
add constraint date_check check (paid_on > created_on);
go