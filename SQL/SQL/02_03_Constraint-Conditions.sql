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
add constraint UQ_Email unique (email);
go

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