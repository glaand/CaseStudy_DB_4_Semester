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

-- Fremdschl�ssel Persons

alter table Persons
add constraint FK_Persons_Persons foreign key (manager_id) references Persons (person_id);
go

alter table Persons
add constraint FK_Persons_Addresses foreign key (address_id) references Addresses (address_id);
go

-- Fremdschl�ssel Events

alter table "Events"
add constraint FK_Events_Employees foreign key (employee_id) references Employees (employee_id); 
go

alter table "Events"
add constraint FK_Events_Areas foreign key (area_id) references Areas (area_id);
go

-- Fremdschl�ssel Landlords (IS-A Beziehung)

alter table Landlords
add constraint FK_Landlords_Persons foreign key (landlord_id) references Persons (person_id);
go

-- Fremdschl�ssel RentalPropertyReservations

alter table RentalPropertyReservations
add constraint FK_RentalPropertyReservations_Seller foreign key (seller_id) references Sellers (seller_id);
go

alter table RentalPropertyReservations
add constraint FK_RentalPropertyReservations_RentalProperties foreign key (rental_property_id) references RentalProperties (rental_property_id);
go

-- Fremdschl�ssel Sellers

alter table Sellers
add constraint FK_Sellers_Subscriptions foreign key (subscription_id) references Subscriptions (subscription_id);
go

-- (IS-A Beziehung)
alter table Sellers
add constraint FK_Sellers_Persons foreign key (seller_id) references Persons (person_id);
go

-- Fremdschl�ssel Inspectors (IS-A Beziehung)

alter table Inspectors
add constraint FK_Inspectors_Persons foreign key (inspector_id) references Persons (person_id);
go

-- Fremdschl�ssel Visitors (IS-A Beziehung)

alter table Visitors
add constraint FK_Visitors_Persons foreign key (visitor_id) references Persons (person_id);
go

-- Fremdschl�ssel Employees

alter table Employees
add constraint FK_Employees_EmployeeRoles foreign key (employee_role_id) references EmployeeRoles (employee_role_id);
go

-- (IS-A Beziehung)

alter table Employees
add constraint FK_Employees_Persons foreign key (employee_id) references Persons (person_id);
go

-- Fremdschl�ssel CreditChecks

alter table CreditChecks
add constraint FK_CreditChecks_Employees foreign key (employee_id) references Employees (employee_id);
go

alter table CreditChecks
add constraint FK_CreditChecks_Sellers foreign key (seller_id) references Sellers (seller_id);
go

-- Fremdschl�ssel QualityChecks

alter table QualityChecks
add constraint FK_QualityChecks_Inspectors foreign key (inspector_id) references Inspectors (inspector_id);
go

alter table QualityChecks
add constraint FK_QualityChecks_Sellers foreign key (seller_id) references Sellers (seller_id);
go

-- Fremdschl�ssel Invoices

alter table Invoices 
add constraint FK_Invoices_Persons foreign key (person_id) references Persons (person_id);
go

-- Fremdschl�ssel InvoiceItem

alter table InvoiceItem
add constraint FK_InvoiceItem_Invoices foreign key (invoice_id) references Invoices (invoice_id);
go

alter table InvoiceItem 
add constraint FK_InvoiceItem_Orders foreign key (order_id) references Orders (order_id);
go

-- (IS-A Beziehung)

alter table SalaryOrders
add constraint FK_SalaryOrders_Orders foreign key (salary_order_id) references Orders (order_id);
go

-- Fremdschl�ssel SubscriptionsOrders

alter table SubscriptionsOrders
add constraint FK_SubscriptionsOrders_Subscriptions foreign key (subscription_id) references Subscriptions (subscription_id);
go

-- (IS-A Beziehung)

alter table SubscriptionsOrders
add constraint FK_SubscriptionsOrders_Orders foreign key (subscription_order_id) references Orders (order_id);
go

-- Fremdschl�ssel Areas

alter table Areas
add constraint FK_Areas_Addresses foreign key (address_id) references Addresses (address_id);
go

alter table Areas
add constraint FK_Areas_Employees foreign key (employee_id) references Employees (employee_id);
go

alter table Areas
add constraint FK_Areas_Landlords foreign key (landlord_id) references Landlords (landlord_id);
go

-- Fremdschl�ssel RentalProperties

alter table RentalProperties
add constraint FK_RentalProperties_Areas foreign key (area_id) references Areas (area_id);
go

-- Fremdschl�ssel Addresses

alter table Addresses
add constraint FK_Addresses_Places foreign key (place_id) references Places (place_id);
go

-- Fremdschl�ssel RentalPermissions

alter table RentalPermissions
add constraint FK_RentalPermissions_Areas foreign key (area_id) references Areas (area_id) on delete cascade;
go

-- Fremdschl�ssel Places

alter table Places
add constraint FK_Places_Districts foreign key (district_id) references Districts (district_id);
go