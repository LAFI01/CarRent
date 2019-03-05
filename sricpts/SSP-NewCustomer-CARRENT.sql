DELIMITER //
CREATE PROCEDURE p_new_city
(
    IN _plz INT,
    IN _ort VARCHAR(50)
)

BEGIN
	INSERT INTO city(plz, ort)
    VALUE(_plz, _ort);
    
END //
DELIMITER ;

DELIMITER //
CREATE PROCEDURE p_new_address
(
    IN _street VARCHAR(50),
    IN _nr VARCHAR(10),
    IN _fkCity INT
)

BEGIN
	INSERT INTO address(street, nr, fkCity)
    VALUE(_street, _nr, _fkCity);
    
END //
DELIMITER ;

DELIMITER //
CREATE PROCEDURE p_new_customer
(
	IN _name VARCHAR(100),
    IN _firstname VARCHAR(100),
    IN _street VARCHAR(50),
    IN _nr VARCHAR(10),
    IN _plz INT,
    IN _ort VARCHAR(50)
)

BEGIN
	DECLARE cityId INT DEFAULT NULL;
    DECLARE addressId INT DEFAULT NULL;
    
    SELECT idCity FROM city WHERE LOWER(ort) = LOWER(_ort) INTO cityId;
    IF cityId IS NULL THEN
		SELECT MAX(idCity) + 1 FROM city INTO cityId;
        CALL p_new_city(_plz, _ort);
	END IF;
    
	SELECT idAddress FROM address WHERE LOWER(street) = LOWER(_street) AND LOWER(nr) = LOWER(_nr)  INTO addressId;
	IF addressId IS NULL THEN
		SELECT MAX(idAddress) + 1 FROM address INTO addressId;
        CALL p_new_address(_street, _nr, cityId);
	END IF;

	INSERT INTO customer(name, firstname, fkAddress)
    VALUE(_name, _firstname, addressId);

END //

DELIMITER ;
