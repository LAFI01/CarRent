SELECT * FROM carrent.car;

DELIMITER //
CREATE PROCEDURE p_new_car
(
	IN _brand VARCHAR(50),
    IN _type VARCHAR(50),
    IN _fkCarClass INT,
    IN _numberOfCars INT,
    IN _numberOfAvailableCars INT
)

BEGIN
	INSERT INTO car(brand, type, fkCarClass,numberOfCars, numberOfAvailableCars)
    VALUE(_brand, _type,_fkCarClass,_numberOfCars, _numberOfAvailableCars);
    
END //
DELIMITER ;