CREATE DATABASE carrent;
use carrent;

CREATE TABLE city(
 idCity INT UNIQUE AUTO_INCREMENT  PRIMARY KEY,
 plz INT NOT NULL,
 ort VARCHAR(50) NOT NULL
 );
 
 CREATE TABLE address(
  idAddress INT  UNIQUE AUTO_INCREMENT  PRIMARY KEY,
  street VARCHAR(50) NOT NULL,
  nr VARCHAR(10) NOT NULL,
  fkCity INT  NOT NULL,
  FOREIGN KEY(fkCity) REFERENCES city(idCity)
  );
  
CREATE TABLE customer(
idCustomer INT UNIQUE AUTO_INCREMENT  PRIMARY KEY,
name VARCHAR(100) NOT NULL,
firstname VARCHAR(100) NOT NULL,
fkAddress INT   NOT NULL,
FOREIGN KEY(fkAddress) REFERENCES address(idAddress)
);

CREATE TABLE carClass(
 idCarClass INT  UNIQUE AUTO_INCREMENT  PRIMARY KEY,
 designation ENUM ('EinfacheKlasse', 'Mittelklasse', 'Luxusklasse'),
 pricePerDay decimal(15,2) NOT NULL
 );
 
 CREATE TABLE car(
idCar INT  UNIQUE AUTO_INCREMENT  PRIMARY KEY,
brand VARCHAR(50) NOT NULL,
type VARCHAR(50) NOT NULL,
isAvailable BOOL DEFAULT TRUE,
fkCarClass INT NOT NULL,
numberOfCars INT NOT NULL,
FOREIGN KEY(fkCarClass) REFERENCES carClass(idCarClass)
);

CREATE TABLE reservation(
idReservation INT UNIQUE AUTO_INCREMENT  PRIMARY KEY,
startDate DATETIME NOT NULL,
endDate DATETIME NOT NULL,
totalPrice decimal(15,2) NOT NULL,
isPickedUp BOOL DEFAULT FALSE,
fkCustomer INT,
fkCar INT ,
FOREIGN KEY(fkCustomer) REFERENCES customer(idCustomer),
FOREIGN KEY(fkCar) REFERENCES car(idCar)
);

CREATE TABLE Contract(
idContract INT  UNIQUE AUTO_INCREMENT  PRIMARY KEY,
fkReservation INT UNIQUE,
gotCarBack BOOL DEFAULT FALSE,
createdDate TIMESTAMP,
FOREIGN KEY(fkReservation) REFERENCES reservation(idReservation)
);


 
 


