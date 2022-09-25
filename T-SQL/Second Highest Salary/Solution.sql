IF ((SELECT COUNT(*) 
     FROM (SELECT salary 
	   FROM Employee
           GROUP BY salary) AS Agg) >= 2)
		   
     SELECT TOP 1 salary AS SecondHighestSalary 
     FROM Employee 
     WHERE salary < (SELECT MAX(salary) FROM Employee)
     ORDER BY salary DESC
ELSE
     SELECT TOP 1 NULL AS SecondHighestSalary 
     FROM Employee
	
	
	
