/*	
	- Dateiname:		02_04_Anfangsdaten.sql
	- Beschreibung:		Konditionen und Bedingungen
	- Autor:			André Glatzl und Alban Ljutvija
	- Arbeitspaktet:	3.3
	- Version:			1.0
	- Datum:			06.08.2020
*/

--Selektierung der Datenbank 
use Marktverwaltungssystem;

--Anfangsdaten für EmployeeRoles
INSERT INTO EmployeeRoles ("name")
VALUES 
	('Kundendienst'),
	('Standortverwalter'),
	('Qualitätsinspektion'),
	('Buchhaltung');

--Anfangsdaten für Kantone
INSERT INTO Districts (district)
VALUES
	('Zürich'),
	('Bern'),
	('Luzern'),
	('Uri'),
	('Schwyz'),
	('Obwalden'),
	('Nidwalden'),
	('Glarus'),
	('Zug'),
	('Freiburg'),
	('Solothurn'),
	('Basel-Stadt'),
	('Basel-Landschaft'),
	('Schaffhausen'),
	('Appenzell Ausserrhoden'),
	('Appenzell Innerrhoden'),
	('St. Gallen'),
	('Graubünden'),
	('Aargau'),
	('Thurgau'),
	('Tessin'),
	('Waadt'),
	('Wallis'),
	('Neuenburg'),
	('Genf'),
	('Jura');
go

--Anfangsdaten für Städte
INSERT INTO Places (district_id, place, place_id)
VALUES
	((SELECT district_id FROM Districts WHERE district = 'Zürich'), 'Zürich-Stadt', 8000),
	((SELECT district_id FROM Districts WHERE district = 'Bern'), 'Bern', 3000),
	((SELECT district_id FROM Districts WHERE district = 'Luzern'), 'Luzern', 6000),
	((SELECT district_id FROM Districts WHERE district = 'Uri'), 'Altdorf', 6460),
	((SELECT district_id FROM Districts WHERE district = 'Schwyz'), 'Schwyz', 6430),
	((SELECT district_id FROM Districts WHERE district = 'Obwalden'), 'Sarnen', 6060),
	((SELECT district_id FROM Districts WHERE district = 'Nidwalden'), 'Stans', 6370),
	((SELECT district_id FROM Districts WHERE district = 'Glarus'), 'Glarus', 8750),
	((SELECT district_id FROM Districts WHERE district = 'Zug'), 'Zug', 6300),
	((SELECT district_id FROM Districts WHERE district = 'Freiburg'), 'Freiburg', 1700),
	((SELECT district_id FROM Districts WHERE district = 'Solothurn'), 'Solothurn', 4500),
	((SELECT district_id FROM Districts WHERE district = 'Basel-Stadt'), 'Basel', 4001),
	((SELECT district_id FROM Districts WHERE district = 'Basel-Landschaft'), 'Liestal', 4410),
	((SELECT district_id FROM Districts WHERE district = 'Schaffhausen'), 'Schaffhausen', 8200),
	((SELECT district_id FROM Districts WHERE district = 'Appenzell Ausserrhoden'), 'Herisau', 9100),
	((SELECT district_id FROM Districts WHERE district = 'Appenzell Innerrhoden'), 'Appenzell', 9050),
	((SELECT district_id FROM Districts WHERE district = 'St. Gallen'), 'St. Gallen', 9000),
	((SELECT district_id FROM Districts WHERE district = 'Graubünden'), 'Chur', 7000),
	((SELECT district_id FROM Districts WHERE district = 'Aargau'), 'Aarau', 5000),
	((SELECT district_id FROM Districts WHERE district = 'Thurgau'), 'Frauenfeld', 8500),
	((SELECT district_id FROM Districts WHERE district = 'Tessin'), 'Bellinzona', 6500),
	((SELECT district_id FROM Districts WHERE district = 'Waadt'), 'Lausanne', 1000),
	((SELECT district_id FROM Districts WHERE district = 'Wallis'), 'Sitten', 1950),
	((SELECT district_id FROM Districts WHERE district = 'Neuenburg'), 'Neuenburg', 2000),
	((SELECT district_id FROM Districts WHERE district = 'Genf'), 'Genf', 1201),
	((SELECT district_id FROM Districts WHERE district = 'Jura'), 'Delsberg', 2800);
go

--Anfangsdaten für Adressen
INSERT INTO Addresses (place_id, address)
VALUES
	((SELECT place_id FROM Places WHERE place = 'Zürich-Stadt'), 'Bahnhofstrasse'),
	((SELECT place_id FROM Places WHERE place = 'Bern'), 'Marktgasse'),
	((SELECT place_id FROM Places WHERE place = 'Luzern'), 'Habsburgerstrasse'),
	((SELECT place_id FROM Places WHERE place = 'Altdorf'), 'Seedorferstrasse'),
	((SELECT place_id FROM Places WHERE place = 'Schwyz'), 'Schützenstrasse'),
	((SELECT place_id FROM Places WHERE place = 'Sarnen'), 'Schwanderstrasse'),
	((SELECT place_id FROM Places WHERE place = 'Stans'), 'Buochsterstrasse'),
	((SELECT place_id FROM Places WHERE place = 'Glarus'), 'Kirchstrasse'),
	((SELECT place_id FROM Places WHERE place = 'Zug'), 'Zugerstrasse'),
	((SELECT place_id FROM Places WHERE place = 'Freiburg'), 'Rue des Alpes'),
	((SELECT place_id FROM Places WHERE place = 'Solothurn'), 'Gibelinstrasse'),
	((SELECT place_id FROM Places WHERE place = 'Basel'), 'Riehenstrasse'),
	((SELECT place_id FROM Places WHERE place = 'Liestal'), 'Tiergartenstrasse'),
	((SELECT place_id FROM Places WHERE place = 'Schaffhausen'), 'Alpenstrasse'),
	((SELECT place_id FROM Places WHERE place = 'Herisau'), 'Poststrasse'),
	((SELECT place_id FROM Places WHERE place = 'Appenzell'), 'Hauptgasse'),
	((SELECT place_id FROM Places WHERE place = 'St. Gallen'), 'Oberstrasse'),
	((SELECT place_id FROM Places WHERE place = 'Chur'), 'Giacomettistrasse'),
	((SELECT place_id FROM Places WHERE place = 'Aarau'), 'Mühlemattstrasse'),
	((SELECT place_id FROM Places WHERE place = 'Frauenfeld'), 'Oberkirchstrasse'),
	((SELECT place_id FROM Places WHERE place = 'Bellinzona'), 'Viale Officina'),
	((SELECT place_id FROM Places WHERE place = 'Lausanne'), 'Rue du Midi'),
	((SELECT place_id FROM Places WHERE place = 'Sitten'), 'Rue Oscar Bider'),
	((SELECT place_id FROM Places WHERE place = 'Neuenburg'), 'Rue des Fahys'),
	((SELECT place_id FROM Places WHERE place = 'Genf'), 'Rue de la Confédération'),
	((SELECT place_id FROM Places WHERE place = 'Delsberg'), 'Bellevoie');
go

--Anfangsdaten für Abonnemente
INSERT INTO Subscriptions ("name", duration, rental_properties_quantity, price)
VALUES
	('Probe Abo', 2, 1, 100),
	('Halbjährliches Abo', 6, 1, 400),
	('Jährliches Abo', 12, 1, 600),
	('Regional Abo', 6, 3, 600);