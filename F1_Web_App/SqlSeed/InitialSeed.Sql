USE [F1_Web_App]
GO
SET IDENTITY_INSERT [dbo].[Countries] ON 
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (1, N'Germany')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (2, N'France')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (3, N'Netherlands')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (4, N'Mexico')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (5, N'Monaco')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (6, N'Spain')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (7, N'United Kingdom')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (8, N'Australia')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (9, N'Singapore')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (10, N'Canada')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (11, N'Finland')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (12, N'China')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (13, N'Denmark')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (14, N'Belgium')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (15, N'Japan')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (16, N'New Zealand')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (17, N'Thailand')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (18, N'Argentina')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (19, N'USA')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (20, N'Switzerland')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (21, N'Bahrain')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (22, N'Saudi Arabia')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (23, N'Azerbaijan')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (24, N'Italy')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (25, N'Austria')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (26, N'Hungary')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (27, N'Japan')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (28, N'Qatar')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (29, N'Brazil')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (30, N'UAE')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (31, N'Bulgaria')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (32, N'Russia')
GO
SET IDENTITY_INSERT [dbo].[Countries] OFF
GO
SET IDENTITY_INSERT [dbo].[Circuits] ON 
GO
INSERT [dbo].[Circuits] ([Id], [Name], [CountryId], [ImageUrl], [IsLegacy]) VALUES (1, N'Bahrain International Circuit', 21, N'https://media.formula1.com/image/upload/f_auto,c_limit,w_1440,q_auto/f_auto/q_auto/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Bahrain_Circuit', 0)
GO
INSERT [dbo].[Circuits] ([Id], [Name], [CountryId], [ImageUrl], [IsLegacy]) VALUES (2, N'Jeddah Corniche Circuit', 22, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Saudi_Arabia_Circuit', 0)
GO
INSERT [dbo].[Circuits] ([Id], [Name], [CountryId], [ImageUrl], [IsLegacy]) VALUES (3, N'Albert Park Circuit', 8, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_771/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Australia_Circuit', 0)
GO
INSERT [dbo].[Circuits] ([Id], [Name], [CountryId], [ImageUrl], [IsLegacy]) VALUES (4, N'Baku City Circuit', 23, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Baku_Circuit', 0)
GO
INSERT [dbo].[Circuits] ([Id], [Name], [CountryId], [ImageUrl], [IsLegacy]) VALUES (5, N'Miami International Autodrome', 19, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Miami_Circuit', 0)
GO
INSERT [dbo].[Circuits] ([Id], [Name], [CountryId], [ImageUrl], [IsLegacy]) VALUES (6, N'Imola Circuit', 24, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Emilia_Romagna_Circuit', 0)
GO
INSERT [dbo].[Circuits] ([Id], [Name], [CountryId], [ImageUrl], [IsLegacy]) VALUES (7, N'Circuit de Monaco', 5, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Monaco_Circuit', 0)
GO
INSERT [dbo].[Circuits] ([Id], [Name], [CountryId], [ImageUrl], [IsLegacy]) VALUES (8, N'Circuit Gilles Villeneuve', 10, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Canada_Circuit', 0)
GO
INSERT [dbo].[Circuits] ([Id], [Name], [CountryId], [ImageUrl], [IsLegacy]) VALUES (9, N'Red Bull Ring', 25, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Austria_Circuit', 0)
GO
INSERT [dbo].[Circuits] ([Id], [Name], [CountryId], [ImageUrl], [IsLegacy]) VALUES (10, N'Silverstone Circuit', 7, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Great_Britain_Circuit', 0)
GO
INSERT [dbo].[Circuits] ([Id], [Name], [CountryId], [ImageUrl], [IsLegacy]) VALUES (11, N'Hungaroring', 26, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Hungary_Circuit', 0)
GO
INSERT [dbo].[Circuits] ([Id], [Name], [CountryId], [ImageUrl], [IsLegacy]) VALUES (12, N'Circuit de Barcelona-Catalunya', 6, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Spain_Circuit', 0)
GO
INSERT [dbo].[Circuits] ([Id], [Name], [CountryId], [ImageUrl], [IsLegacy]) VALUES (13, N'Circuit de Spa-Francorchamps', 14, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Belgium_Circuit', 0)
GO
INSERT [dbo].[Circuits] ([Id], [Name], [CountryId], [ImageUrl], [IsLegacy]) VALUES (14, N'Zandvoort Circuit', 3, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Netherlands_Circuit', 0)
GO
INSERT [dbo].[Circuits] ([Id], [Name], [CountryId], [ImageUrl], [IsLegacy]) VALUES (15, N'Monza Circuit', 24, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Italy_Circuit', 0)
GO
INSERT [dbo].[Circuits] ([Id], [Name], [CountryId], [ImageUrl], [IsLegacy]) VALUES (16, N'Marina Bay Street Circuit', 9, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Singapore_Circuit', 0)
GO
INSERT [dbo].[Circuits] ([Id], [Name], [CountryId], [ImageUrl], [IsLegacy]) VALUES (17, N'Suzuka International Racing Course', 27, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Japan_Circuit', 0)
GO
INSERT [dbo].[Circuits] ([Id], [Name], [CountryId], [ImageUrl], [IsLegacy]) VALUES (18, N'Losail International Circuit', 28, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Qatar_Circuit', 0)
GO
INSERT [dbo].[Circuits] ([Id], [Name], [CountryId], [ImageUrl], [IsLegacy]) VALUES (19, N'Circuit of the Americas', 19, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/USA_Circuit', 0)
GO
INSERT [dbo].[Circuits] ([Id], [Name], [CountryId], [ImageUrl], [IsLegacy]) VALUES (20, N'Autódromo Hermanos Rodríguez', 4, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Mexico_Circuit', 0)
GO
INSERT [dbo].[Circuits] ([Id], [Name], [CountryId], [ImageUrl], [IsLegacy]) VALUES (21, N'Interlagos Circuit', 29, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Brazil_Circuit', 0)
GO
INSERT [dbo].[Circuits] ([Id], [Name], [CountryId], [ImageUrl], [IsLegacy]) VALUES (22, N'Las Vegas Street Circuit', 19, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Las_Vegas_Circuit', 0)
GO
INSERT [dbo].[Circuits] ([Id], [Name], [CountryId], [ImageUrl], [IsLegacy]) VALUES (23, N'Shanghai International Circuit', 12, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/China_Circuit', 0)
GO
INSERT [dbo].[Circuits] ([Id], [Name], [CountryId], [ImageUrl], [IsLegacy]) VALUES (24, N'Yas Marina Circuit', 30, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Abu_Dhabi_Circuit', 0)
GO
SET IDENTITY_INSERT [dbo].[Circuits] OFF
GO
SET IDENTITY_INSERT [dbo].[Teams] ON 
GO
INSERT [dbo].[Teams] ([Id], [Name], [CountryId], [ImageUrl]) VALUES (2, N'Red Bull Racing', 7, N'https://media.formula1.com/image/upload/f_auto,c_limit,w_1440,q_auto/f_auto,c_fill,q_75,w_1320,g_faces,ar_16:9/content/dam/fom-website/manual/DriverAndTeamImages/2024/2053163352_16by9Centre')
GO
INSERT [dbo].[Teams] ([Id], [Name], [CountryId], [ImageUrl]) VALUES (3, N'Mercedes-AMG Petronas', 7, N'https://media.formula1.com/image/upload/f_auto,c_limit,w_1440,q_auto/f_auto,c_fill,q_75,w_1320,g_faces,ar_16:9/content/dam/fom-website/manual/DriverAndTeamImages/2024/2055023690_16by9South')
GO
INSERT [dbo].[Teams] ([Id], [Name], [CountryId], [ImageUrl]) VALUES (4, N'Ferrari', 24, N'https://media.formula1.com/image/upload/f_auto,c_limit,w_1440,q_auto/f_auto,c_fill,q_75,w_1320,g_faces,ar_16:9/content/dam/fom-website/manual/DriverAndTeamImages/2024/2027373349_16by9Centre')
GO
INSERT [dbo].[Teams] ([Id], [Name], [CountryId], [ImageUrl]) VALUES (5, N'McLaren', 7, N'https://media.formula1.com/image/upload/f_auto,c_limit,w_1440,q_auto/f_auto,c_fill,q_75,w_1320,g_faces,ar_16:9/content/dam/fom-website/manual/DriverAndTeamImages/2024/2032675059_16by9Centre')
GO
INSERT [dbo].[Teams] ([Id], [Name], [CountryId], [ImageUrl]) VALUES (6, N'Alpine', 2, N'https://media.formula1.com/image/upload/f_auto,c_limit,w_1440,q_auto/f_auto,c_fill,q_75,w_1320,g_faces,ar_16:9/content/dam/fom-website/manual/DriverAndTeamImages/2024/2065862959_16by9Centre')
GO
INSERT [dbo].[Teams] ([Id], [Name], [CountryId], [ImageUrl]) VALUES (7, N'Aston Martin', 7, N'https://media.formula1.com/image/upload/f_auto,c_limit,w_1440,q_auto/f_auto,c_fill,q_75,w_1320,g_faces,ar_16:9/content/dam/fom-website/manual/DriverAndTeamImages/2024/2053204844_16by9Centre')
GO
INSERT [dbo].[Teams] ([Id], [Name], [CountryId], [ImageUrl]) VALUES (8, N'Haas F1 Team', 19, N'https://media.formula1.com/image/upload/f_auto,c_limit,w_1440,q_auto/f_auto,c_fill,q_75,w_1320,g_faces,ar_16:9/content/dam/fom-website/manual/DriverAndTeamImages/2024/2068767588_16by9North')
GO
INSERT [dbo].[Teams] ([Id], [Name], [CountryId], [ImageUrl]) VALUES (9, N'Williams', 7, N'https://media.formula1.com/image/upload/f_auto,c_limit,w_1440,q_auto/f_auto,c_fill,q_auto,w_1320,t_16by9Centre,g_faces,ar_16:9/trackside-images/2024/F1_Grand_Prix_of_Italy___Practice/2169471457')
GO
INSERT [dbo].[Teams] ([Id], [Name], [CountryId], [ImageUrl]) VALUES (10, N'RB Formula One Team', 24, N'https://media.formula1.com/image/upload/f_auto,c_limit,w_1440,q_auto/f_auto,c_fill,q_auto,w_1320,t_16by9Centre,g_faces,ar_16:9/trackside-images/2024/F1_Grand_Prix_of_United_States/2179851387')
GO
INSERT [dbo].[Teams] ([Id], [Name], [CountryId], [ImageUrl]) VALUES (11, N'Kick Sauber', 20, N'https://media.formula1.com/image/upload/f_auto,c_limit,w_1440,q_auto/f_auto,c_fill,q_75,w_1320,g_faces,ar_16:9/content/dam/fom-website/manual/DriverAndTeamImages/2024/2047992871_16by9North')
GO
SET IDENTITY_INSERT [dbo].[Teams] OFF
GO
SET IDENTITY_INSERT [dbo].[Events] ON 
GO
INSERT [dbo].[Events] ([Id], [CircuitId], [EventDate]) VALUES (1, 1, CAST(N'2024-03-02T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Events] ([Id], [CircuitId], [EventDate]) VALUES (2, 2, CAST(N'2024-03-09T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Events] ([Id], [CircuitId], [EventDate]) VALUES (3, 3, CAST(N'2024-03-24T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Events] ([Id], [CircuitId], [EventDate]) VALUES (4, 4, CAST(N'2024-04-07T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Events] ([Id], [CircuitId], [EventDate]) VALUES (5, 5, CAST(N'2024-04-21T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Events] ([Id], [CircuitId], [EventDate]) VALUES (6, 6, CAST(N'2024-05-05T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Events] ([Id], [CircuitId], [EventDate]) VALUES (7, 7, CAST(N'2024-05-19T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Events] ([Id], [CircuitId], [EventDate]) VALUES (8, 8, CAST(N'2024-05-26T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Events] ([Id], [CircuitId], [EventDate]) VALUES (9, 9, CAST(N'2024-06-09T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Events] ([Id], [CircuitId], [EventDate]) VALUES (10, 10, CAST(N'2024-06-23T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Events] ([Id], [CircuitId], [EventDate]) VALUES (11, 11, CAST(N'2024-06-30T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Events] ([Id], [CircuitId], [EventDate]) VALUES (12, 12, CAST(N'2024-07-07T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Events] ([Id], [CircuitId], [EventDate]) VALUES (13, 13, CAST(N'2024-07-21T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Events] ([Id], [CircuitId], [EventDate]) VALUES (14, 14, CAST(N'2024-07-28T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Events] ([Id], [CircuitId], [EventDate]) VALUES (15, 15, CAST(N'2024-08-25T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Events] ([Id], [CircuitId], [EventDate]) VALUES (16, 16, CAST(N'2024-09-01T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Events] ([Id], [CircuitId], [EventDate]) VALUES (17, 17, CAST(N'2024-09-15T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Events] ([Id], [CircuitId], [EventDate]) VALUES (18, 18, CAST(N'2024-09-22T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Events] ([Id], [CircuitId], [EventDate]) VALUES (19, 19, CAST(N'2024-10-20T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Events] ([Id], [CircuitId], [EventDate]) VALUES (20, 20, CAST(N'2024-10-27T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Events] ([Id], [CircuitId], [EventDate]) VALUES (21, 21, CAST(N'2024-11-03T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Events] ([Id], [CircuitId], [EventDate]) VALUES (22, 22, CAST(N'2024-11-17T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Events] ([Id], [CircuitId], [EventDate]) VALUES (23, 23, CAST(N'2024-12-01T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Events] ([Id], [CircuitId], [EventDate]) VALUES (24, 24, CAST(N'2024-12-15T00:00:00.0000000' AS DateTime2))
GO
SET IDENTITY_INSERT [dbo].[Events] OFF
GO
SET IDENTITY_INSERT [dbo].[Drivers] ON 
GO
INSERT [dbo].[Drivers] ([Id], [DriverNumber], [Name], [TeamId], [ImageUrl], [IsRetired]) VALUES (6, 1, N'Max Verstappen', 2, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/verstappen', 0)
GO
INSERT [dbo].[Drivers] ([Id], [DriverNumber], [Name], [TeamId], [ImageUrl], [IsRetired]) VALUES (8, 4, N'Lando Norris', 5, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/norris', 0)
GO
INSERT [dbo].[Drivers] ([Id], [DriverNumber], [Name], [TeamId], [ImageUrl], [IsRetired]) VALUES (9, 10, N'Pierre Gasly', 6, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/gasly', 0)
GO
INSERT [dbo].[Drivers] ([Id], [DriverNumber], [Name], [TeamId], [ImageUrl], [IsRetired]) VALUES (10, 11, N'Sergio Pérez', 2, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/perez', 0)
GO
INSERT [dbo].[Drivers] ([Id], [DriverNumber], [Name], [TeamId], [ImageUrl], [IsRetired]) VALUES (11, 14, N'Fernando Alonso', 7, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/alonso', 0)
GO
INSERT [dbo].[Drivers] ([Id], [DriverNumber], [Name], [TeamId], [ImageUrl], [IsRetired]) VALUES (12, 16, N'Charles Leclerc', 4, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/leclerc', 0)
GO
INSERT [dbo].[Drivers] ([Id], [DriverNumber], [Name], [TeamId], [ImageUrl], [IsRetired]) VALUES (13, 18, N'Lance Stroll', 7, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/drivers/2024Drivers/stroll', 0)
GO
INSERT [dbo].[Drivers] ([Id], [DriverNumber], [Name], [TeamId], [ImageUrl], [IsRetired]) VALUES (14, 20, N'Kevin Magnussen', 8, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/magnussen', 0)
GO
INSERT [dbo].[Drivers] ([Id], [DriverNumber], [Name], [TeamId], [ImageUrl], [IsRetired]) VALUES (15, 22, N'Yuki Tsunoda', 10, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/tsunoda', 0)
GO
INSERT [dbo].[Drivers] ([Id], [DriverNumber], [Name], [TeamId], [ImageUrl], [IsRetired]) VALUES (16, 23, N'Alexander Albon', 9, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/albon', 0)
GO
INSERT [dbo].[Drivers] ([Id], [DriverNumber], [Name], [TeamId], [ImageUrl], [IsRetired]) VALUES (17, 24, N'Guanyu Zhou', 11, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/zhou', 0)
GO
INSERT [dbo].[Drivers] ([Id], [DriverNumber], [Name], [TeamId], [ImageUrl], [IsRetired]) VALUES (18, 27, N'Nico Hülkenberg', 8, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/hulkenberg', 0)
GO
INSERT [dbo].[Drivers] ([Id], [DriverNumber], [Name], [TeamId], [ImageUrl], [IsRetired]) VALUES (19, 30, N'Liam Lawson', 10, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/drivers/2024Drivers/lawson', 0)
GO
INSERT [dbo].[Drivers] ([Id], [DriverNumber], [Name], [TeamId], [ImageUrl], [IsRetired]) VALUES (20, 31, N'Esteban Ocon', 6, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/ocon', 0)
GO
INSERT [dbo].[Drivers] ([Id], [DriverNumber], [Name], [TeamId], [ImageUrl], [IsRetired]) VALUES (21, 43, N'Franco Colapinto', 9, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/drivers/2024Drivers/colapinto', 0)
GO
INSERT [dbo].[Drivers] ([Id], [DriverNumber], [Name], [TeamId], [ImageUrl], [IsRetired]) VALUES (22, 44, N'Lewis Hamilton', 3, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/hamilton', 0)
GO
INSERT [dbo].[Drivers] ([Id], [DriverNumber], [Name], [TeamId], [ImageUrl], [IsRetired]) VALUES (24, 55, N'Carlos Sainz', 4, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/sainz', 0)
GO
INSERT [dbo].[Drivers] ([Id], [DriverNumber], [Name], [TeamId], [ImageUrl], [IsRetired]) VALUES (25, 63, N'George Russell', 3, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/russell', 0)
GO
INSERT [dbo].[Drivers] ([Id], [DriverNumber], [Name], [TeamId], [ImageUrl], [IsRetired]) VALUES (26, 77, N'Valtteri Bottas', 11, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/bottas', 0)
GO
INSERT [dbo].[Drivers] ([Id], [DriverNumber], [Name], [TeamId], [ImageUrl], [IsRetired]) VALUES (27, 81, N'Oscar Piastri', 5, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/piastri', 0)
GO
INSERT [dbo].[Drivers] ([Id], [DriverNumber], [Name], [TeamId], [ImageUrl], [IsRetired]) VALUES (29, 3, N'Michael Schumacher', 4, N'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTgL0a4VSKJI2PhRLVTG0SXBHPusyBTr5GNaw&s', 1)
GO
SET IDENTITY_INSERT [dbo].[Drivers] OFF
GO
SET IDENTITY_INSERT [dbo].[Results] ON 
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (1, 25, 6, 1)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (2, 18, 10, 1)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (3, 15, 24, 1)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (4, 12, 12, 1)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (5, 10, 25, 1)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (6, 8, 8, 1)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (7, 6, 22, 1)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (8, 4, 27, 1)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (9, 2, 11, 1)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (10, 1, 13, 1)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (11, 0, 17, 1)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (12, 0, 14, 1)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (13, 0, 19, 1)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (14, 0, 15, 1)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (15, 0, 16, 1)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (16, 0, 18, 1)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (17, 0, 20, 1)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (18, 0, 9, 1)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (19, 0, 26, 1)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (20, 0, 21, 1)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (21, 25, 6, 2)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (22, 18, 10, 2)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (23, 16, 12, 2)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (24, 12, 27, 2)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (25, 10, 11, 2)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (26, 8, 25, 2)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (27, 6, 24, 2)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (28, 4, 8, 2)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (29, 2, 22, 2)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (30, 1, 18, 2)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (31, 0, 16, 2)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (32, 0, 14, 2)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (33, 0, 20, 2)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (34, 0, 19, 2)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (35, 0, 15, 2)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (36, 0, 21, 2)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (37, 0, 26, 2)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (38, 0, 17, 2)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (39, 0, 13, 2)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (40, 0, 9, 2)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (41, 25, 24, 3)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (42, 19, 12, 3)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (43, 15, 8, 3)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (44, 12, 27, 3)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (45, 10, 10, 3)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (46, 8, 13, 3)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (47, 6, 15, 3)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (48, 4, 11, 3)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (49, 2, 18, 3)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (50, 1, 14, 3)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (51, 0, 16, 3)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (52, 0, 21, 3)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (53, 0, 9, 3)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (54, 0, 26, 3)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (55, 0, 17, 3)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (56, 0, 20, 3)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (57, 0, 25, 3)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (58, 0, 22, 3)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (59, 0, 6, 3)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (60, 26, 6, 4)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (61, 18, 10, 4)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (62, 15, 24, 4)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (63, 12, 12, 4)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (64, 10, 8, 4)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (65, 8, 11, 4)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (66, 6, 25, 4)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (67, 4, 27, 4)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (68, 2, 22, 4)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (69, 1, 15, 4)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (70, 0, 18, 4)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (71, 0, 13, 4)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (72, 0, 14, 4)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (73, 0, 26, 4)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (74, 0, 20, 4)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (75, 0, 9, 4)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (77, 0, 17, 4)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (78, 0, 19, 4)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (79, 0, 16, 4)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (80, 25, 6, 5)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (81, 18, 8, 5)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (82, 15, 10, 5)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (83, 12, 12, 5)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (84, 10, 24, 5)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (85, 8, 25, 5)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (86, 7, 11, 5)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (87, 4, 27, 5)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (88, 2, 22, 5)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (89, 1, 18, 5)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (90, 0, 20, 5)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (91, 0, 16, 5)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (92, 0, 9, 5)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (93, 0, 17, 5)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (94, 0, 13, 5)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (95, 0, 14, 5)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (96, 0, 21, 5)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (97, 0, 19, 5)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (98, 0, 15, 5)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (99, 0, 26, 5)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (100, 25, 8, 6)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (101, 18, 6, 6)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (102, 15, 10, 6)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (103, 12, 12, 6)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (104, 10, 24, 6)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (105, 8, 11, 6)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (106, 6, 25, 6)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (107, 4, 27, 6)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (108, 2, 22, 6)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (109, 1, 18, 6)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (110, 0, 16, 6)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (111, 0, 14, 6)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (112, 0, 20, 6)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (113, 0, 9, 6)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (114, 0, 17, 6)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (115, 0, 13, 6)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (116, 0, 19, 6)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (117, 0, 26, 6)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (118, 0, 15, 6)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (119, 0, 21, 6)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (120, 25, 6, 7)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (121, 18, 8, 7)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (122, 15, 12, 7)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (123, 12, 27, 7)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (124, 10, 24, 7)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (125, 8, 22, 7)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (126, 7, 25, 7)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (127, 4, 10, 7)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (128, 2, 13, 7)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (129, 1, 15, 7)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (130, 0, 18, 7)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (131, 0, 14, 7)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (132, 0, 19, 7)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (133, 0, 20, 7)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (134, 0, 17, 7)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (135, 0, 9, 7)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (136, 0, 21, 7)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (137, 0, 26, 7)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (138, 0, 11, 7)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (139, 0, 16, 7)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (140, 25, 12, 8)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (141, 18, 27, 8)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (142, 15, 24, 8)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (143, 12, 8, 8)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (144, 10, 25, 8)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (145, 8, 6, 8)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (146, 7, 22, 8)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (147, 4, 15, 8)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (148, 2, 16, 8)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (149, 1, 9, 8)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (150, 0, 11, 8)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (151, 0, 19, 8)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (152, 0, 26, 8)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (153, 0, 13, 8)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (154, 0, 21, 8)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (155, 0, 17, 8)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (156, 0, 20, 8)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (157, 0, 10, 8)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (158, 0, 18, 8)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (159, 0, 14, 8)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (160, 25, 6, 9)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (161, 18, 8, 9)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (162, 15, 25, 9)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (163, 13, 22, 9)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (164, 10, 27, 9)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (165, 8, 11, 9)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (166, 6, 13, 9)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (167, 4, 19, 9)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (168, 2, 9, 9)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (169, 1, 20, 9)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (170, 0, 18, 9)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (171, 0, 14, 9)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (172, 0, 26, 9)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (173, 0, 15, 9)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (174, 0, 17, 9)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (175, 0, 24, 9)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (176, 0, 16, 9)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (177, 0, 10, 9)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (178, 0, 12, 9)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (179, 0, 21, 9)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (180, 25, 6, 10)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (181, 19, 8, 10)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (182, 15, 22, 10)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (183, 12, 25, 10)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (184, 10, 12, 10)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (185, 8, 24, 10)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (186, 6, 27, 10)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (187, 4, 10, 10)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (188, 2, 9, 10)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (189, 1, 20, 10)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (190, 0, 18, 10)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (191, 0, 11, 10)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (192, 0, 17, 10)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (193, 0, 13, 10)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (194, 0, 19, 10)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (195, 0, 26, 10)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (196, 0, 14, 10)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (197, 0, 16, 10)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (198, 0, 15, 10)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (199, 0, 21, 10)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (200, 25, 25, 11)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (201, 18, 27, 11)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (202, 15, 24, 11)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (203, 12, 22, 11)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (204, 10, 6, 11)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (205, 8, 18, 11)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (206, 6, 10, 11)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (207, 4, 14, 11)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (208, 2, 19, 11)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (209, 1, 9, 11)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (210, 0, 12, 11)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (211, 0, 20, 11)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (212, 0, 13, 11)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (213, 0, 15, 11)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (214, 0, 16, 11)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (215, 0, 26, 11)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (216, 0, 17, 11)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (217, 0, 11, 11)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (218, 0, 21, 11)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (219, 0, 8, 11)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (240, 25, 27, 12)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (241, 18, 8, 12)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (242, 15, 22, 12)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (243, 12, 12, 12)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (244, 10, 6, 12)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (245, 8, 24, 12)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (246, 6, 10, 12)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (247, 5, 25, 12)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (248, 2, 15, 12)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (249, 1, 13, 12)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (250, 0, 11, 12)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (251, 0, 19, 12)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (252, 0, 18, 12)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (253, 0, 16, 12)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (254, 0, 14, 12)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (255, 0, 26, 12)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (256, 0, 21, 12)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (257, 0, 20, 12)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (258, 0, 17, 12)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (259, 0, 9, 12)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (260, 25, 22, 13)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (261, 18, 27, 13)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (262, 15, 12, 13)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (263, 12, 6, 13)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (264, 10, 8, 13)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (265, 8, 24, 13)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (266, 7, 10, 13)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (267, 4, 11, 13)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (268, 2, 20, 13)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (269, 1, 19, 13)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (270, 0, 13, 13)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (271, 0, 16, 13)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (272, 0, 9, 13)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (273, 0, 14, 13)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (274, 0, 26, 13)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (275, 0, 15, 13)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (276, 0, 21, 13)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (277, 0, 18, 13)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (278, 0, 17, 13)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (280, 26, 8, 14)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (281, 18, 6, 14)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (282, 15, 12, 14)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (283, 12, 27, 14)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (284, 10, 24, 14)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (285, 8, 10, 14)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (286, 6, 25, 14)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (287, 4, 22, 14)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (288, 2, 9, 14)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (289, 1, 11, 14)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (290, 0, 18, 14)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (291, 0, 19, 14)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (292, 0, 13, 14)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (293, 0, 16, 14)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (294, 0, 20, 14)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (295, 0, 21, 14)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (296, 0, 15, 14)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (297, 0, 14, 14)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (298, 0, 26, 14)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (299, 0, 17, 14)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (300, 25, 12, 15)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (301, 18, 27, 15)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (302, 16, 8, 15)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (303, 12, 24, 15)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (304, 10, 22, 15)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (305, 8, 6, 15)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (306, 6, 25, 15)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (307, 4, 10, 15)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (308, 2, 16, 15)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (309, 1, 14, 15)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (310, 0, 11, 15)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (311, 0, 21, 15)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (312, 0, 19, 15)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (313, 0, 20, 15)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (314, 0, 9, 15)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (315, 0, 26, 15)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (316, 0, 18, 15)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (317, 0, 17, 15)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (318, 0, 13, 15)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (319, 0, 15, 15)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (320, 25, 27, 16)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (321, 18, 12, 16)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (322, 15, 25, 16)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (323, 13, 8, 16)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (324, 10, 6, 16)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (325, 8, 11, 16)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (326, 6, 16, 16)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (327, 4, 21, 16)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (328, 2, 22, 16)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (329, 1, 10, 16)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (330, 0, 18, 16)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (331, 0, 9, 16)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (332, 0, 19, 16)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (333, 0, 17, 16)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (334, 0, 20, 16)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (335, 0, 26, 16)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (336, 0, 10, 16)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (337, 0, 24, 16)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (338, 0, 13, 16)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (339, 0, 15, 16)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (340, 25, 8, 17)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (341, 18, 6, 17)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (342, 15, 27, 17)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (343, 12, 25, 17)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (344, 10, 12, 17)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (345, 8, 22, 17)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (346, 6, 24, 17)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (347, 4, 11, 17)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (348, 2, 18, 17)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (349, 1, 10, 17)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (350, 0, 21, 17)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (351, 0, 15, 17)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (352, 0, 20, 17)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (353, 0, 13, 17)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (354, 0, 17, 17)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (355, 0, 26, 17)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (356, 0, 9, 17)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (357, 0, 19, 17)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (358, 0, 14, 17)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (359, 0, 16, 17)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (360, 25, 12, 18)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (361, 18, 24, 18)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (362, 15, 6, 18)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (363, 12, 8, 18)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (364, 10, 27, 18)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (365, 8, 25, 18)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (366, 6, 10, 18)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (367, 4, 18, 18)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (368, 2, 19, 18)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (369, 1, 21, 18)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (370, 0, 14, 18)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (371, 0, 9, 18)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (372, 0, 11, 18)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (373, 0, 15, 18)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (374, 0, 13, 18)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (375, 0, 16, 18)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (376, 0, 26, 18)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (377, 0, 20, 18)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (378, 0, 17, 18)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (379, 0, 22, 18)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (380, 25, 24, 19)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (381, 18, 8, 19)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (382, 16, 12, 19)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (383, 12, 22, 19)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (384, 10, 25, 19)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (385, 8, 6, 19)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (386, 6, 14, 19)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (387, 4, 27, 19)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (388, 2, 18, 19)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (389, 1, 9, 19)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (390, 0, 13, 19)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (391, 0, 21, 19)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (392, 0, 20, 19)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (393, 0, 26, 19)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (394, 0, 17, 19)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (395, 0, 19, 19)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (396, 0, 10, 19)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (397, 0, 11, 19)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (398, 0, 16, 19)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (399, 0, 15, 19)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (400, 26, 6, 20)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (401, 18, 20, 20)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (402, 15, 9, 20)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (403, 12, 25, 20)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (404, 10, 12, 20)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (405, 8, 8, 20)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (406, 6, 15, 20)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (407, 4, 27, 20)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (408, 2, 19, 20)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (409, 1, 22, 20)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (410, 0, 10, 20)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (411, 0, 14, 20)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (412, 0, 26, 20)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (413, 0, 11, 20)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (414, 0, 17, 20)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (415, 0, 24, 20)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (416, 0, 21, 20)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (417, 0, 16, 20)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (418, 0, 13, 20)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (419, 0, 18, 20)
GO
SET IDENTITY_INSERT [dbo].[Results] OFF
GO
