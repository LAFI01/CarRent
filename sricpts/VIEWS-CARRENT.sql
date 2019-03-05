CREATE VIEW v_customer AS

SELECT * FROM customer cu INNER JOIN address a ON cu.fkAddress = a.idAddress INNER JOIN city ci ON a.fkCity = ci.idCity;