-- ============================================================
--  Skills International School – Database Setup Script
--  Run this in SQL Server Management Studio (SSMS)
--  before starting the application.
-- ============================================================

-- 1. Create the database
CREATE DATABASE Student;
GO

USE Student;
GO

-- 2. Registration table  (Figure X)
CREATE TABLE Registration (
    regNo       INT            NOT NULL PRIMARY KEY,
    firstName   VARCHAR(50)    NULL,
    lastName    VARCHAR(50)    NULL,
    dateOfBirth DATETIME       NULL,
    gender      VARCHAR(50)    NULL,
    address     VARCHAR(50)    NULL,
    email       VARCHAR(50)    NULL,
    mobilePhone INT            NULL,
    homePhone   INT            NULL,
    parentName  VARCHAR(50)    NULL,
    nic         VARCHAR(50)    NULL,
    contactNo   INT            NULL
);
GO

-- 3. Logins table  (Figure IX – optional, for multiple users)
CREATE TABLE Logins (
    username    VARCHAR(50)    NOT NULL PRIMARY KEY,
    password    VARCHAR(50)    NOT NULL
);
GO

-- 4. Insert the default admin user into Logins
--    (The app also accepts Admin / Skills@123 without this row,
--     but inserting here demonstrates the multi-user capability.)
INSERT INTO Logins (username, password)
VALUES ('Admin', 'Skills@123');
GO

-- ============================================================
--  Verification queries
-- ============================================================
SELECT * FROM Registration;
SELECT * FROM Logins;
