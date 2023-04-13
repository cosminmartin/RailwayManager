 IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'RailwayManagerDb')
  BEGIN
    CREATE DATABASE [RailwayManagerDb]

    END
    GO
       USE [RailwayManagerDb]
    GO