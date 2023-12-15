-- Create Database MyTestDB
CREATE DATABASE MyTestDB;
GO

-- Use MyTestDB
USE MyTestDB;
GO

-- Clients table with NumClient as an auto-increment column
CREATE TABLE Clients (
    NumClient INT IDENTITY(1,1) PRIMARY KEY,
    NomClient VARCHAR(20) NOT NULL,
    PrenomClient VARCHAR(15) NOT NULL,
    AdresseClient VARCHAR(30) NOT NULL,
    NumTelClient VARCHAR(25)
);

-- Commandes table with NumComd as an auto-increment column
CREATE TABLE Commandes (
    NumComd INT IDENTITY(1,1) PRIMARY KEY,
    NumClient INT, -- Assuming this is a foreign key to Clients table
    DateComd DATE NOT NULL,
    EtatComd INT
);

-- Inserting data into the Clients table
INSERT INTO Clients (NomClient, PrenomClient, AdresseClient, NumTelClient)
VALUES
    ('Dupont', 'Jean', '123 Rue de la Ville', '555-1234'),
    ('Martin', 'Sophie', '456 Avenue des Fleurs', '555-5678'),
    ('Lefevre', 'Paul', '789 Boulevard du Soleil', '555-9876');

-- Inserting data into the Commandes table
INSERT INTO Commandes (NumClient, DateComd, EtatComd)
VALUES
    (1, '2023-01-15', 1),
    (2, '2023-02-28', 2),
    (3, '2023-03-10', 1);
