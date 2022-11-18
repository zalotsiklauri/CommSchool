-- Students
use HomeWorkWeek15;
-- 1
SELECT * from Students where StudentsID = 1
-- 2
SELECT * from Students where DoB > '1990-01-01'
-- 3
SELECT Firstname, Lastname, YEAR(CURRENT_TIMESTAMP) - YEAR(DoB) from Students where (Country = 'Georgia' or Country = 'Libya')
-- 4
INSERT into Students (Firstname,Lastname,Country) VALUES ('giorgi','gorozia','spain')
-- 5
SELECT TOP 5 Firstname, MiddleTest from Students ORDER BY MiddleTest DESC
-- 6
DELETE from Students OUTPUT deleted.* where FinalTest = 19   
-- 7
UPDATE Students SET FinalTest = 0 WHERE MiddleTest = 1 
-- persons
-- 1
SELECT * from Persons where PrivateId LIKE '163%'
-- 2
SELECT * from Persons where Lastname = City
-- 3
SELECT * FROM Persons WHERE Country in ('Canada','Monaco')  
-- 4
SELECT Firstname, Lastname, PrivateID from Persons where Email is NULL
-- 5 
SELECT * FROM Persons WHERE Country in ('Spain','Turkey') AND Salary BETWEEN 1000 and 3000   
-- 6 
SELECT WorkPlace FROM Persons where WorkPlace LIKE '%LLC' or WorkPlace LIKE '%PC' or WorkPlace LIKE '%LLP' 
-- 7 

SELECT Email,IIF((len(Email)-len(REPLACE(Email,'.',''))) > 2,'more than 2 dots', 'less than 2 dots') as MAILINFO FROM Persons

-- 8 
SELECT * From Persons where PINcode like '%51'
-- 9
SELECT Country, AVG(Salary) from Persons GROUP By Country

