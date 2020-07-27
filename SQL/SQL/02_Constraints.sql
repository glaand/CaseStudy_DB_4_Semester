/*	
	- Dateiname:		02_Constraints.sql
	- Beschreibung:		Tabellenverkn�pfung, Restriktionen und Bedingungen
	- Autor:			Andr� Glatzl und Alban Ljutvija
	- Arbeitspaktet:	3.1
	- Version:			1.0
	- Datum:			21.07.2020
*/

--Selektierung der Datenbank 

use Marktverwaltungssystem;

-- Persons Tabellenverkn�pfung und Bedingungen

alter table Persons 
add constraint PK_Persons primary key (person_id);
go

alter table Persons
add constraint UQ_Email unique (email);
go

alter table Persons
add constraint FK_Persons_Persons foreign key (manager_id) references Persons.person_id  (person_id);
go

-- Event Tabellenverkn�pfung und Bedingungen

alter table "Events"
add constraint PK_Events primary key (event_id);
go

alter table "Events"
add constraint FK_Events_Employees foreign key (employee_id) references Employees.employee_id (employee_id);
go

alter table "Events"
add constraint FK_Events_Areas foreign key (area_id) references Areas.area_id (area_id)
go

alter table "Events"
add constraint CH_Date check (event_date >= CURRENT_TIMESTAMP);
go

-- Landlord Tabellenverkn�pfung

alter table Landlord
add constraint PK_Landlord primary key (landlord_id);

-- RentalPropertyReservations Tabellenverkn�pfung

alter table RentalPropertyReservations
add constraint PK_RentalPropertyReservations primary key (seller_id);
go

alter table RentalPropertyReservations
add constraint FK_RentalPropertyReservations_Seller foreign key (seller_id) references Sellers.seller_id (seller_id);
go

alter table RentalPropertyReservations
add constraint PK_RentalPropertyReservations primary key (rental_property_id);
go

alter table RentalPropertyReservations
add constraint FK_RentalPropertyReservations_RentalProperties foreign key (rental_property_id) references RentalProperties.rental_property_id;
go

-- Sellers Tabellenverkn�pfung und Bedingungen

alter table Sellers
add constraint PK_Sellers primary key (seller_id);
go
alter table Sellers
add constraint FK_Sellers_Subscriptions foreign key (subscriptions_id) references Subscriptions.subscriptions_id;
go

alter table Sellers
add constraint CH_Date check (last_update <= current_timestamp);
go

-- Inspectors Tabellenverkn�pfung

alter table Inspectors
add constraint PK_Inspectors primary key (inspector_id);
go

alter table Inspectors
add constraint DF_hourlysalary default (25.00);
go

-- Visitors Tabellenverkn�pfung und Bedingungen

alter table Visitors
add constraint PK_Visitors primary key (visitor_id);
go

alter table Visitors
add constraint CH_PW check (len([password])>(5) and [password] like '%[A-Z]%' and [password] like '%[0-9]%');
go

-- Employees Tabellenverkn�pfung 

alter table Employees
add constraint PK_Employees primary key (employee_id);
go

alter table Employees
add constraint FK_Employees_EmployeeRoles foreign key (employee_role_id) references EmployeeRoles.employee_role_id;
go

alter table Employees
add constraint DF_hourlysalary default (25.00);
go

