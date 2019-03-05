INSERT INTO city(PLZ, ort)
VALUES(9225, 'Wilen - Gottshaus'),
(9000, 'St.Gallen')
;

INSERT INTO address(street, nr, fkCity)
VALUES('Schoosswiesen', '11', 1),
('Rosenbergweg', '18c', 2)
;

INSERT INTO customer(name, firstname, fkAddress)
VALUES('Fitze','Ernst', 1),
('Fitze','Larissa', 2),
('Fitze','Marlene', 1),
('Blaser','Jerome', 2)
;

insert into carClass(designation, pricePerDay)
VALUES('Einfacheklasse', 30.35),
('Mittelklasse', 40.50),
('Luxusklasse', 60.00)
;

INSERT INTO car(brand,type,fkCarClass, numberOfCars)
VALUES('OPEL', 'normal', 1, 10),
('AUDI', 'A3', 2, 5),
('AUDI', 'Q7', 2, 5),
('BMW', 'Cabrio', 3, 5),
('BMW', 'Limousine', 3, 5)
;


 
