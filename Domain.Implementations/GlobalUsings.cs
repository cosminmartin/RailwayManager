﻿global using DataAccess.Contracts.Contracts.Ticket;
global using DataAccess.Contracts.Contracts.Train;
global using DataAccess.Contracts.Contracts.User;
global using DataAccess.Contracts.Entities;
global using DataAccess.Contracts.Repositories.Tickets;
global using DataAccess.Contracts.Repositories.Trains;
global using DataAccess.Contracts.Repositories.Users;
global using Domain.Contracts.Dtos.Ticket;
global using Domain.Contracts.Dtos.Train;
global using Domain.Contracts.Dtos.User;
global using Domain.Contracts.Tickets.Commands;
global using Domain.Contracts.Tickets.Commands.CreateTicket;
global using Domain.Contracts.Tickets.Queries;
global using Domain.Contracts.Tickets.Queries.GetById;
global using Domain.Contracts.Trains.Commands;
global using Domain.Contracts.Trains.Commands.CreateTrain;
global using Domain.Contracts.Trains.Commands.DeleteTrain;
global using Domain.Contracts.Trains.Commands.EditTrain;
global using Domain.Contracts.Trains.Queries;
global using Domain.Contracts.Trains.Queries.GetAllTrains;
global using Domain.Contracts.Trains.Queries.GetById;
global using Domain.Contracts.Users.Commands;
global using Domain.Contracts.Users.Commands.CreateUser;
global using Domain.Contracts.Users.Commands.LoginUser;
global using Domain.Contracts.Users.Queries;
global using Domain.Contracts.Users.Queries.GetByEmail;
global using Domain.Contracts.Users.Queries.GetById;
global using Domain.Implementations.Tickets.Behaviour.Mappings;
global using Domain.Implementations.Tickets.Behaviour.Models;
global using Domain.Implementations.Trains.Behaviour.Mappings;
global using Domain.Implementations.Trains.Behaviour.Models;
global using Domain.Implementations.Users.Behaviour.Mappings;
global using Domain.Implementations.Users.Behaviour.Models;
global using FluentValidation;
global using Libraries.Exceptions;
global using Libraries.JWTTokenManager;
global using Libraries.PasswordManager.Managers.Password;
global using Libraries.Shared.Constants;
global using Microsoft.Extensions.Options;