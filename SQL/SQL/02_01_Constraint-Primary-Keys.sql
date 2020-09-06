/*	
	- Dateiname:		02_01_Constraint-Primary-Keys.sql
	- Beschreibung:		Primärschlüsselvergabe
	- Autor:			André Glatzl und Alban Ljutvija
	- Arbeitspaktet:	3.1
	- Version:			1.0
	- Datum:			21.07.2020
*/

--Selektierung der Datenbank 

use Marktverwaltungssystem;

-- Tabelle Persons

alter table Persons 
add constraint PK_Persons primary key (person_id);
go

-- Tabelle Events

alter table "Events"
add constraint PK_Events primary key (event_id);
go

-- Tabelle Landlords

alter table Landlords
add constraint PK_Landlords primary key (landlord_id);
go

-- Tabelle RentalPropertyReservations 

alter table RentalPropertyReservations
add constraint PK_RentalPropertyReservations primary key (seller_id, rental_property_id);
go

-- Tabelle Sellers

alter table Sellers
add constraint PK_Sellers primary key (seller_id);
go

-- Tabelle Inspectors

alter table Inspectors
add constraint PK_Inspectors primary key (inspector_id);
go

-- Tabelle Visitors

alter table Visitors
add constraint PK_Visitors primary key (visitor_id);
go

-- Tabelle Employees 

alter table Employees
add constraint PK_Employees primary key (employee_id);
go

-- Tabelle EmplyeeRoles

alter table EmployeeRoles
add constraint PK_EmployeeRoles primary key (employee_role_id);
go

-- Tabelle CreditChecks

alter table CreditChecks
add constraint PK_CreditChecks primary key (credit_check_id);
go

-- Tabelle QualityChecks 

alter table QualityChecks
add constraint PK_QualityChecks primary key (quality_check_id);
go

-- Tabelle Invoices

alter table Invoices
add constraint PK_Invoices primary key (invoice_id);
go

-- Tabelle InvoiceItem

alter table InvoiceItem
add constraint PK_InvoiceItem primary key (invoice_item_id);
go

-- Tabelle Orders 

alter table Orders
add constraint PK_Orders primary key (order_id);
go

-- Tabelle SalaryOrders 

alter table SalaryOrders
add constraint PK_SalaryOrders primary key (salary_order_id);
go

-- Tabelle SubscriptionsOrders 

alter table SubscriptionsOrders
add constraint PK_SubscriptionsOrders primary key (subscription_order_id);
go

-- Tabelle Subscriptions

alter table Subscriptions
add constraint PK_Subscriptions primary key (subscription_id);
go

-- Tabelle Areas

alter table Areas
add constraint PK_Areas primary key (area_id);
go

-- Tabelle RentalProperties

alter table RentalProperties
add constraint PK_RentalProperties primary key (rental_property_id);
go

-- Tabelle Addresses 

alter table Addresses
add constraint PK_Addresses primary key (address_id);
go

-- Tabelle RentalPermissions 

alter table RentalPermissions
add constraint PK_RentalPermissions primary key (rental_permission_id);
go

-- Tabelle Places

alter table Places
add constraint PK_Places primary key (place_id);
go

-- Tabelle Districts

alter table Districts
add constraint PK_Districts primary key (district_id);
go