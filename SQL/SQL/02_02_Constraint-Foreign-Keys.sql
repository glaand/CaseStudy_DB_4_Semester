/*	
	- Dateiname:		02_02_Constraint-Foreign-Keys.sql
	- Beschreibung:		Fremdschlüsselvergabe
	- Autor:			André Glatzl und Alban Ljutvija
	- Arbeitspaktet:	3.1
	- Version:			1.0
	- Datum:			21.07.2020
*/

--Selektierung der Datenbank 

use Marktverwaltungssystem;

-- Fremdschlüssel Persons

alter table Persons
add constraint FK_Persons_Persons foreign key (manager_id) references Persons (person_id);
go

-- Fremdschlüssel Events

alter table "Events"
add constraint FK_Events_Employees foreign key (employee_id) references Employees (employee_id); 
go

alter table "Events"
add constraint FK_Events_Areas foreign key (area_id) references Areas (area_id);
go

-- Fremdschlüssel RentalPropertyReservations

alter table RentalPropertyReservations
add constraint FK_RentalPropertyReservations_Seller foreign key (seller_id) references Sellers (seller_id);
go

alter table RentalPropertyReservations
add constraint FK_RentalPropertyReservations_RentalProperties foreign key (rental_property_id) references RentalProperties;
go

-- Fremdschlüssel Sellers

alter table Sellers
add constraint FK_Sellers_Subscriptions foreign key (subscriptions_id) references Subscriptions;
go

-- Fremdschlüssel Employees

alter table Employees
add constraint FK_Employees_EmployeeRoles foreign key (employee_role_id) references EmployeeRoles;
go

-- Fremdschlüssel CreditChecks

alter table CreditChecks
add constraint FK_CreditChecks_Employees foreign key (employee_id) references Employees;
go

alter table CreditChecks
add constraint FK_CreditChecks_Sellers foreign key (seller_id) references Sellers;
go

-- Fremdschlüssel QualityChecks

alter table QualityChecks
add constraint FK_QualityChecks_Inspectors foreign key (inspector_id) references Inspectors;
go

alter table QualityChecks
add constraint FK_QualityChecks_Sellers foreign key (seller_id) references Sellers;
go

-- Fremdschlüssel Invoices

alter table Invoices 
add constraint FK_Invoices_Persons foreign key (person_id) references Persons;
go

-- Fremdschlüssel InvoiceItem

alter table InvoiceItem
add constraint FK_InvoiceItem_Invoices foreign key (invoice_id) references Invoices;
go

alter table InvoiceItem 
add constraint FK_InvoiceItem_Orders foreign key (order_id) references Orders;
go

-- Fremdschlüssel SalaryOrders

alter table SalaryOrders
add constraint FK_SalaryOrders_Persons foreign key (person_id) references Persons;
go

-- Fremdschlüssel SubscriptionsOrders

alter table SubscriptionsOrders
add constraint FK_SubscriptionsOrders_Subscriptions foreign key (subscription_id) references Subscriptions;
go

-- Fremdschlüssel Areas

alter table Areas
add constraint FK_Areas_Addresses foreign key (address_id) references Addresses;
go

alter table Areas
add constraint FK_Areas_Employees foreign key (employee_id) references Employees;
go

alter table Areas
add constraint FK_Areas_Landlords foreign key (landlord_id) references Landlords;
go

-- Fremdschlüssel RentalProperties

alter table RentalProperties
add constraint FK_RentalProperties_Areas foreign key (area_id) references Areas;
go

-- Fremdschlüssel Addresses

alter table Addresses
add constraint FK_Addresses_Places foreign key (place_id) references Places;
go

-- Fremdschlüssel RentalPermissions

alter table RentalPermissions
add constraint FK_RentalPermissions_RentalProperties foreign key (rental_property_id) references RentalProperties;
go

-- Fremdschlüssel Places

alter table Places
add constraint FK_Places_Districts foreign key (district_id) references Districts;
go