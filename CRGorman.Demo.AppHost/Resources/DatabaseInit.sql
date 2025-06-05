IF DB_ID('{{databaseName}}') IS NULL
    CREATE DATABASE [{{databaseName}}];
GO

-- Use the database
USE [{{databaseName}}];
GO

CREATE TABLE Game(
    Id INT,
    Title TEXT,
    Guide TEXT
);

CREATE TABLE Act(
    GameId INT,
    Id INT,
    Title TEXT,
);

-- Create the mission guide table
CREATE TABLE MissionGuide (
    GameId INT,
    ActId INT,
    MissionId INT,
    PRIMARY KEY (Game, Act, Mission),
    Title TEXT,
    Guide TEXT
);
GO