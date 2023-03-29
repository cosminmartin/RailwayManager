 IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'RailwayManager')
  BEGIN
    CREATE DATABASE [RailwayManager]

    END
    GO
       USE [RailwayManager]
    GO