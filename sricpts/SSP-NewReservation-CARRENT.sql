DELIMITER //
CREATE PROCEDURE p_new_reservation
(
	IN _startDate DATETIME,
    IN _endDate DATETIME,
    IN _totalPrice DECIMAL,
    IN _isPickedUp bool,
    IN _customerFk INT,
    IN _carFk INT
)

BEGIN
	INSERT INTO reservation(startDate, endDate, totalPrice, isPickedUp, fkCustomer, fkCar)
    VALUE(_startDate, _endDate, _totalPrice, _isPickedUp, _customerFk, _carFk);

END //
DELIMITER ;