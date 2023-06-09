﻿IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Trains')
    CREATE TABLE Trains (
	Id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWSEQUENTIALID() NOT NULL,
	Name VARCHAR(256) NOT NULL,
	DepartureStation VARCHAR(256) NOT NULL,
	ArrivalStation VARCHAR(256) NOT NULL,
	DepartureDate datetime DEFAULT GETDATE(),
	ArrivalDate datetime DEFAULT GETDATE(),
	Duration datetime DEFAULT GETDATE(),
	Status VARCHAR(256) NOT NULL
)
GO