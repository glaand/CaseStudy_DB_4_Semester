/*	
	- Dateiname:		02_05_Views.sql
	- Beschreibung:		Views, Statistics
	- Autor:			André Glatzl und Alban Ljutvija
	- Arbeitspaktet:	3.1
	- Version:			1.0
	- Datum:			04.09.2020
*/

-- Selektierung der Datenbank 

use Marktverwaltungssystem;
go

DROP VIEW IF exists SUBSCRIPTIONS_SALES;
GO
-- Anzahl Verkäufe

CREATE VIEW SUBSCRIPTIONS_SALES
AS
SELECT Subscriptions."name",
		Subscriptions.duration,
		SubscriptionsOrders.subscription_order_id,
		Sellers.seller_id,
		Persons.firstname,
		Persons.lastname,
		(SELECT COUNT(subscription_order_id)FROM SubscriptionsOrders) AS TOTAL_SALES
		FROM Sellers INNER JOIN Subscriptions ON Subscriptions.subscription_id = Sellers.subscription_id
		INNER JOIN Persons ON Persons.person_id = Sellers.seller_id
		INNER JOIN SubscriptionsOrders ON SubscriptionsOrders.subscription_id = Subscriptions.subscription_id
		INNER JOIN Orders ON Orders.order_id = SubscriptionsOrders.subscription_order_id;
GO
SELECT * FROM SUBSCRIPTIONS_SALES;
GO
DROP VIEW IF exists EVENT_LIST;
GO

-- Event Liste

CREATE VIEW EVENT_LIST
AS
SELECT "Events".event_date,
		Addresses."address",
		Areas.additional_info,
		Places.place,
		Districts.district
		FROM "Events" INNER JOIN Areas ON AREAS.area_id = "Events".area_id
		INNER JOIN Addresses ON Addresses.address_id = Areas.address_id
		INNER JOIN Places ON Places.place_id = Addresses.place_id
		INNER JOIN Districts ON Districts.district_id = Places.district_id;
GO
SELECT * FROM EVENT_LIST ORDER BY event_date;
GO
DROP VIEW EVENT_LIST;
GO






		
