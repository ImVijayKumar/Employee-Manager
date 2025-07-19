DROP DATABASE IF EXISTS EmployeeDB;
CREATE DATABASE EmployeeDB;
USE EmployeeDB;

CREATE TABLE States (
    StateID INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(100) NOT NULL
);

CREATE TABLE Employees (
    EmployeeID INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Designation VARCHAR(100) NOT NULL,
    DOB DATE NOT NULL,
    DOJ DATE NOT NULL,
    Salary DECIMAL(18,2) NOT NULL,
    Gender VARCHAR(10) NOT NULL,
    StateID INT NOT NULL,
    FOREIGN KEY (StateID) REFERENCES States(StateID)
);

INSERT INTO States (Name) VALUES
('Andhra Pradesh'),
('Arunachal Pradesh'),
('Assam'),
('Bihar'),
('Chhattisgarh'),
('Goa'),
('Gujarat'),
('Haryana'),
('Himachal Pradesh'),
('Jammu and Kashmir'),
('Jharkhand'),
('Karnataka'),
('Kerala'),
('Madhya Pradesh'),
('Maharashtra'),
('Manipur'),
('Meghalaya'),
('Mizoram'),
('Nagaland'),
('Odisha'),
('Punjab'),
('Rajasthan'),
('Sikkim'),
('Tamil Nadu'),
('Telangana'),
('Tripura'),
('Uttar Pradesh'),
('Uttarakhand'),
('West Bengal');

INSERT INTO Employees (Name, Designation, DOB, DOJ, Salary, Gender, StateID) VALUES
('JVijay Kumar', 'Software Engineer', '2001-11-27', '2024-06-15', 30000.00, 'M', 1),
('M Prabhu Dasu', 'Front End Developer', '2000-01-14', '2024-03-20', 33000.00, 'M', 1),
('Manish', 'Full Stack Engineer', '2003-01-15', '2024-01-10', 25000.00, 'M', 1);
