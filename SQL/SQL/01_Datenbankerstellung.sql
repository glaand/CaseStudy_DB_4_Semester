
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
	person_id						int				not null,
	firstname						varchar(50)		not null,
	lastname						varchar(50)		null,
	email							varchar(50)		not null,
	phone_nr						varchar(20)		null,
	manager_id						int				null
);
go

create table "Events" (
	event_id						int				not null,
	employee_id						int				not null,
	area_id							int				not null,
	event_date						datetime		not null
);
go

create table Landlords (
	landlord_id						int				not null
)
go

create table RentalPropertyReservations (
	seller_id						int				not null,
	rental_property_id				int				not null
);
go

create table Sellers (
	seller_id						int				not null,
	subscription_id					int				null,
	"description"					text			null,
	last_update						datetime		null
);
go

create table Inspectors (
	inspector_id					int				not null,
	hourly_salary					decimal(6,2)	not null
);
go

create table Visitors (
	visitor_id						int				not null,
	"password"						text			not null,
	wants_newsletter				bit				not null
);
go

create table Employees (
	employee_id						int				not null,
	employee_role_id				int				not null,
	hourly_salary					decimal(6,2)	not null
);
go

create table EmployeeRoles (
	employee_role_id				int				not null,
	"name"							varchar(30)		not null
);
go

create table CreditChecks (
	credit_check_id					int				not null,
	employee_id						int				not null,
	seller_id						int				not null,
	visit_date						date			not null,
	approved						bit				null,
	approved_on						datetime		null
);
go

create table QualityChecks (
	quality_check_id				int				not null,
	inspector_id					int				not null,
	seller_id						int				not null,
	round_check						tinyint			not null,
	approved						bit				null,
	approved_on						datetime		null
);
go

create table Invoices(
	invoice_id						int				not null,
	person_id						int				not null,
	vat								decimal(5,2)	not null,
	paid_on							datetime		null,
	created_on						datetime		not null
);
go

create table InvoiceItem (
	invoice_item_id					int				not null,
	invoice_id						int				not null,
	order_id						int				not null
);	
go

create table Orders (
	order_id						int				not null,
	created_on						datetime		not null,
	total_price						decimal(9,2)	not null
);
go

create table SalaryOrders(
	salary_order_id					int				not null,
	person_id						int				not null,
	"hours"							int				not null
);
go

create table SubscriptionsOrders (
	subscription_order_id			int				not null,
	subscription_id					int				not null
);
go

create table Subscriptions (
	subscription_id					int				not null,
	"name"							varchar(50)		not null,
	duration						int				not null,
	rental_properties_quantity		tinyint			not null,
	price							decimal(6,2)	not null
);
go

create table Areas (
	area_id							int				not null,
	latitude						decimal(9,6)	not null,
	longitude						decimal(9,6)	not null,
	address_id						int				not null,
	additional_info					varchar(50)		null,
	"square"						decimal(6,2)	not null,
	employee_id						int				not null,
	landlord_id						int				not null
);
go

create table RentalProperties (
	rental_property_id				int				not null,
	area_id							int				not null,
	"square"						decimal(6,2)	not null
);
go

create table Addresses (
	address_id						int				not null,
	place_id						int				not null,
	"address"						varchar(50)		not null
); 
go

create table RentalPermissions (
	rental_permission_id			int				not null,
	rental_property_id				int				not null,
	"date"							date			not null
);
go

create table Places (
	place_id						int				not null,
	district_id						int				not null,
	place							varchar(50)		not null
);
go

create table	Districts (
	district_id						int				not null,
	district						varchar(50)		not null,
);
go





