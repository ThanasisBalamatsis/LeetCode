SELECT name AS Customers FROM Customers
LEFT OUTER JOIN Orders
ON Customers.id = customerId
WHERE customerId IS NULL;