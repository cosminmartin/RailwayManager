﻿global using Domain.Contracts.Tickets.Commands;
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
global using Domain.Implementations.Tickets.Behaviour.Validators;
global using Domain.Implementations.Tickets.Commands;
global using Domain.Implementations.Tickets.Commands.CreateTicket;
global using Domain.Implementations.Tickets.Queries;
global using Domain.Implementations.Tickets.Queries.GetById;
global using Domain.Implementations.Trains.Behaviour.Validators;
global using Domain.Implementations.Trains.Commands;
global using Domain.Implementations.Trains.Commands.CreateTrain;
global using Domain.Implementations.Trains.Commands.DeleteTrain;
global using Domain.Implementations.Trains.Commands.EditTrain;
global using Domain.Implementations.Trains.Queries;
global using Domain.Implementations.Trains.Queries.GetAllTrains;
global using Domain.Implementations.Trains.Queries.GetById;
global using Domain.Implementations.Users.Behaviour.Validators;
global using Domain.Implementations.Users.Commands;
global using Domain.Implementations.Users.Commands.CreateUser;
global using Domain.Implementations.Users.Commands.LoginUser;
global using Domain.Implementations.Users.Queries;
global using Domain.Implementations.Users.Queries.GetByEmail;
global using Domain.Implementations.Users.Queries.GetById;
global using FluentValidation;
global using Libraries.JWTTokenManager;
global using Libraries.PasswordManager.Extensions;
global using Microsoft.Extensions.DependencyInjection;
