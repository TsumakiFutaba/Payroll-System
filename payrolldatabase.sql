-- CREATE DATABASE payrolldatabase;

USE payrolldatabase;

CREATE TABLE Employee_Info(
employee_id int NOT NULL PRIMARY KEY,
employee_name nvarchar(250) NOT NULL,
age int,
gender nvarchar(250),
bday date NOT NULL,
email nvarchar(250) NOT NULL,
position nvarchar(250) NOT NULL,
usrname nvarchar(250) NOT NULL,
pw nvarchar(250) NOT NULL,
sss int NOT NULL,
philhealth int NOT NULL,
pagibig int NOT NULL
);

--BEGIN TRANSACTION;
--SET IDENTITY_INSERT Employee_Info ON;
--COMMIT TRANSACTION;

-- View all rows on the Employee_Info table
