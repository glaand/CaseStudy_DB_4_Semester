/*	
	- Dateiname:		02_Constraints.sql
	- Beschreibung:		Tabellenverknüpfung, Restriktionen und Bedingungen
	- Autor:			André Glatzl und Alban Ljutvija
	- Arbeitspaktet:	3.1
	- Version:			1.0
	- Datum:			21.07.2020
*/

--Selektierung der Datenbank 

use Marktverwaltungssystem;

-- Persons Tabellenverknüpfung und Bedingungen

alter table Persons 
add constraint PK_Persons primary key (person_id);
go

alter table Persons
add constraint UQ_Email unique (email);
go

alter table Persons
add constraint FK_Persons_Persons foreign key (manager_id) references Persons (person_id);
go

-- Event Tabellenverknüpfung und Bedingungen

alter table "Events"
add constraint PK_Events primary key (event_id);
go

-- Zuerst muss der primary key von der Tabelle Employees gesetzt werden um den foreign key setzen zu können.

alter table "Events"
add constraint FK_Events_Employees foreign key (employee_id) references Employees (employee_id); 
go

-- Zuerst muss der primary key von der Tabelle Areas gesetzt werden um den Foreign key setzen zu können.

alter table "Events"
add constraint FK_Events_Areas foreign key (area_id) references Areas (area_id);
go

alter table "Events"
add constraint CH_Date check (event_date >= CURRENT_TIMESTAMP);
go

-- Landlord Tabellenverknüpfung

alter table Landlords
add constraint PK_Landlords primary key (landlord_id);
go

-- RentalPropertyReservations Tabellenverknüpfung

alter table RentalPropertyReservations
add constraint PK_RentalPropertyReservations primary key (seller_id, rental_property_id);
go

-- Zuerst muss der primary key von der Tabelle Sellers gesetzt werden um den Foreign key setzen zu können.

alter table RentalPropertyReservations
add constraint FK_RentalPropertyReservations_Seller foreign key (seller_id) references Sellers (seller_id);
go

-- Zuerst muss der primary key von der Tabelle RentalProperties gesetzt werden um den Foreign key setzen zu können.

alter table RentalPropertyReservations
add constraint FK_RentalPropertyReservations_RentalProperties foreign key (rental_property_id) references RentalProperties;
go

-- Sellers Tabellenverknüpfung und Bedingungen

alter table Sellers
add constraint PK_Sellers primary key (seller_id);
go

-- Zuerst muss der primary key von der Tabelle Subscriptions gesetzt werden um den Foreign key setzen zu können.

alter table Sellers
add constraint FK_Sellers_Subscriptions foreign key (subscriptions_id) references Subscriptions;
go

alter table Sellers
add constraint CH_Update check (last_update <= CURRENT_TIMESTAMP);
go

-- Inspectors Tabellenverknüpfung

alter table Inspectors
add constraint PK_Inspectors primary key (inspector_id);
go

alter table Inspectors
add default (25.00) for hourly_salary;
go

-- Visitors Tabellenverknüpfung und Bedingungen

alter table Visitors
add constraint PK_Visitors primary key (visitor_id);
go

-- Employees Tabellenverknüpfung 

alter table Employees
add constraint PK_Employees primary key (employee_id);
go

-- Zuerst muss der primary key von der Tabelle EmployeeRoles gesetzt werden um den Foreign key setzen zu können.

alter table Employees
add constraint FK_Employees_EmployeeRoles foreign key (employee_role_id) references EmployeeRoles;
go

alter table Employees
add default (30.00) for hourly_salary;
go

-- EmplyeeRoles Tabellenverknüpfung

alter table EmployeeRoles
add constraint PK_EmployeeRoles primary key (employee_role_id);
go

-- CreditChecks Tabellenverknüpfung

alter table CreditChecks
add constraint PK_CreditChecks primary key (credit_check_id);
go

alter table CreditChecks
add constraint FK_CreditChecks_Employees foreign key (employee_id) references Employees;
go

alter table CreditChecks
add constraint FK_CreditChecks_Sellers foreign key (seller_id) references Sellers;
go

-- QualityChecks Tabellenverknüpfung

alter table QualityChecks
add constraint PK_QualityChecks primary key (quality_check_id);
go

alter table QualityChecks
add constraint FK_QualityChecks_Inspectors foreign key (inspector_id) references Inspectors;
go

alter table QualityChecks
add constraint FK_QualityChecks_Sellers foreign key (seller_id) references Sellers;
go

-- Invoices Tabellenverknüpfung

alter table Invoices
add constraint PK_Invoices primary key (invoice_id);
go

alter table Invoices 
add constraint FK_Invoices_Persons foreign key (person_id) references Persons;
go

alter table Invoices
add default (8.00) for vat;
go

-- InvoiceItem Tabellenverknüpfung

alter table InvoiceItem
add constraint PK_InvoiceItem primary key (invoice_item_id);
go

alter table InvoiceItem
add constraint FK_InvoiceItem_Invoices foreign key (invoice_id) references Invoices;
go

-- Zuerst muss der primary key von der Tabelle Orders gesetzt werden um den Foreign key setzen zu können.

alter table InvoiceItem 
add constraint FK_InvoiceItem_Orders foreign key (order_id) references Orders;
go

-- Orders Tabellenverknüpfung

alter table Orders
add constraint PK_Orders primary key (order_id);
go

-- SalaryOrders Tabellenverknüpfung

alter table SalaryOrders
add constraint PK_SalaryOrders primary key (salary_order_id);
go

alter table SalaryOrders
add constraint FK_SalaryOrders_Persons foreign key (person_id) references Persons;
go

-- SubscriptionsOrders Tabellenverknüpfung

alter table SubscriptionsOrders
add constraint PK_SubscriptionsOrders primary key (subscription_order_id);
go

alter table SubscriptionsOrders
add constraint FK_SubscriptionsOrders_Subscriptions foreign key (subscription_id) references Subscriptions;
go

-- Subscriptions Tabellenverknüpfung

alter table Subscriptions
add constraint PK_Subscriptions primary key (subscription_id);
go

-- Areas Tabellenverknüpfung und Bedingungen

alter table Areas
add constraint PK_Areas primary key (area_id);
go

-- Zuerst muss der primary key von der Tabelle Addresses gesetzt werden um den Foreign key setzen zu können.

alter table Areas
add constraint FK_Areas_Addresses foreign key (address_id) references Addresses;
go

alter table Areas
add constraint FK_Areas_Employees foreign key (employee_id) references Employees;
go

alter table Areas
add constraint FK_Areas_Landlords foreign key (landlord_id) references Landlords;
go

-- RentalProperties Tabellenverknüpfung

alter table RentalProperties
add constraint PK_RentalProperties primary key (rental_property_id);
go

alter table RentalProperties
add constraint FK_RentalProperties_Areas foreign key (area_id) references Areas;
go

-- Addresses Tabellenverknüpfung

alter table Addresses
add constraint PK_Addresses primary key (address_id);
go

-- Zuerst muss der primary key von der Tabelle Places gesetzt werden um den Foreign key setzen zu können.

alter table Addresses
add constraint FK_Addresses_Places foreign key (place_id) references Places;
go

-- RentalPermissions Tabellenverknüpfung

alter table RentalPermissions
add constraint PK_RentalPermissions primary key (rental_permission_id);
go

alter table RentalPermissions
add constraint FK_RentalPermissions_RentalProperties foreign key (rental_property_id) references RentalProperties;
go

-- Places Tabellenverknüpfung

alter table Places
add constraint PK_Places primary key (place_id);
go

-- Zuerst muss der primary key von der Tabelle Districts gesetzt werden um den Foreign key setzen zu können.

alter table Places
add constraint FK_Places_Districts foreign key (district_id) references Districts;
go

-- Districts Tabellenverknüpfung

alter table Districts
add constraint PK_Districts primary key (district_id);
go

alter table Districts
add constraint UQ_district unique (district);
go




