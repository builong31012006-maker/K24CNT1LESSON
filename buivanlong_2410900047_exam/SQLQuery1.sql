-- Create Database
CREATE DATABASE bvlStudent_2410900047_Db;
GO

USE bvlStudent_2410900047_Db;
GO

-- Create Table longStudent
CREATE TABLE bvlStudent (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    bvlName NVARCHAR(100) NOT NULL,
    bvlGender NVARCHAR(10) NOT NULL,
    bvlBirthDay DATE NOT NULL,
    bvlEmail VARCHAR(100) NOT NULL UNIQUE,
    bvlPhone VARCHAR(15) NULL,
    bvlActive BIT NOT NULL DEFAULT 1
);
GO

-- Insert Sample Data
INSERT INTO bvlStudent (bvlName, bvlGender, bvlBirthDay, bvlEmail, bvlPhone, bvlActive)
VALUES 
(N'Nguyễn Văn Long', N'Nam', '2004-05-15', 'long2410900047@gmail.com', '0912345678', 1),
(N'Trần Thị B', N'Nữ', '2005-08-20', 'tranthib@gmail.com', '0987654321', 1);
GO