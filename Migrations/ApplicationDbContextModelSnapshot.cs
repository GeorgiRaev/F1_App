﻿// <auto-generated />
using System;
using F1_App.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace F1_App.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("F1_App.Data.Models.Driver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DriverNumber")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Team")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Drivers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateTime(1997, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DriverNumber = 1,
                            Name = "Max Verstappen",
                            Nationality = "Netherlands",
                            PhotoUrl = "https://cdn-3.motorsport.com/images/mgl/6D1XbeV0/s800/max-verstappen-red-bull-racing.jpg",
                            Team = "Red Bull Racing"
                        },
                        new
                        {
                            Id = 2,
                            BirthDate = new DateTime(1990, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DriverNumber = 11,
                            Name = "Sergio Perez",
                            Nationality = "Mexico",
                            PhotoUrl = "https://cdn-3.motorsport.com/images/mgl/2y3qRdo6/s8/sergio-perez-red-bull-racing.jpg",
                            Team = "Red Bull Racing"
                        },
                        new
                        {
                            Id = 3,
                            BirthDate = new DateTime(1997, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DriverNumber = 16,
                            Name = "Charles Leclerc",
                            Nationality = "Monaco",
                            PhotoUrl = "https://media.formula1.com/image/upload/v1712849104/content/dam/fom-website/drivers/2024Drivers/leclerc.png",
                            Team = "Scuderia Ferrari"
                        },
                        new
                        {
                            Id = 4,
                            BirthDate = new DateTime(1994, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DriverNumber = 55,
                            Name = "Carlos Sainz",
                            Nationality = "Spain",
                            PhotoUrl = "https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/sainz",
                            Team = "Scuderia Ferrari"
                        },
                        new
                        {
                            Id = 5,
                            BirthDate = new DateTime(1985, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DriverNumber = 44,
                            Name = "Lewis Hamilton",
                            Nationality = "United Kingdom",
                            PhotoUrl = "https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/hamilton",
                            Team = "Mercedes-AMG Petronas F1 Team"
                        },
                        new
                        {
                            Id = 6,
                            BirthDate = new DateTime(1998, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DriverNumber = 63,
                            Name = "George Russell",
                            Nationality = "United Kingdom",
                            PhotoUrl = "https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/russell",
                            Team = "Mercedes-AMG Petronas F1 Team"
                        },
                        new
                        {
                            Id = 7,
                            BirthDate = new DateTime(1999, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DriverNumber = 4,
                            Name = "Lando Norris",
                            Nationality = "United Kingdom",
                            PhotoUrl = "https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/norris",
                            Team = "McLaren"
                        },
                        new
                        {
                            Id = 8,
                            BirthDate = new DateTime(2001, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DriverNumber = 81,
                            Name = "Oscar Piastri",
                            Nationality = "Australia",
                            PhotoUrl = "https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/piastri",
                            Team = "McLaren"
                        },
                        new
                        {
                            Id = 9,
                            BirthDate = new DateTime(1996, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DriverNumber = 31,
                            Name = "Esteban Ocon",
                            Nationality = "France",
                            PhotoUrl = "https://media.formula1.com/image/upload/v1712849107/content/dam/fom-website/drivers/2024Drivers/ocon.png",
                            Team = "Alpine"
                        },
                        new
                        {
                            Id = 10,
                            BirthDate = new DateTime(1996, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DriverNumber = 10,
                            Name = "Pierre Gasly",
                            Nationality = "France",
                            PhotoUrl = "https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/gasly",
                            Team = "Alpine"
                        },
                        new
                        {
                            Id = 11,
                            BirthDate = new DateTime(1981, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DriverNumber = 14,
                            Name = "Fernando Alonso",
                            Nationality = "Spain",
                            PhotoUrl = "https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/alonso",
                            Team = "Aston Martin"
                        },
                        new
                        {
                            Id = 12,
                            BirthDate = new DateTime(1998, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DriverNumber = 18,
                            Name = "Lance Stroll",
                            Nationality = "Canada",
                            PhotoUrl = "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/drivers/2024Drivers/stroll",
                            Team = "Aston Martin"
                        },
                        new
                        {
                            Id = 13,
                            BirthDate = new DateTime(1989, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DriverNumber = 77,
                            Name = "Valtteri Bottas",
                            Nationality = "Finland",
                            PhotoUrl = "https://media.formula1.com/image/upload/v1712849101/content/dam/fom-website/drivers/2024Drivers/bottas.png",
                            Team = "Kick Sauber-Ferrari"
                        },
                        new
                        {
                            Id = 14,
                            BirthDate = new DateTime(1999, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DriverNumber = 24,
                            Name = "Zhou Guanyu",
                            Nationality = "China",
                            PhotoUrl = "https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/zhou",
                            Team = "Kick Sauber-Ferrari"
                        },
                        new
                        {
                            Id = 15,
                            BirthDate = new DateTime(1992, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DriverNumber = 20,
                            Name = "Kevin Magnussen",
                            Nationality = "Denmark",
                            PhotoUrl = "https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/magnussen",
                            Team = "Haas"
                        },
                        new
                        {
                            Id = 16,
                            BirthDate = new DateTime(1987, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DriverNumber = 27,
                            Name = "Nico Hulkenberg",
                            Nationality = "Germany",
                            PhotoUrl = "https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/hulkenberg",
                            Team = "Haas"
                        },
                        new
                        {
                            Id = 17,
                            BirthDate = new DateTime(2000, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DriverNumber = 22,
                            Name = "Yuki Tsunoda",
                            Nationality = "Japan",
                            PhotoUrl = "https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/tsunoda",
                            Team = "Visa Cash App RB F1 Team"
                        },
                        new
                        {
                            Id = 18,
                            BirthDate = new DateTime(2002, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DriverNumber = 30,
                            Name = "Liam Lawson",
                            Nationality = "New Zealand",
                            PhotoUrl = "https://media.formula1.com/image/upload/f_auto/q_auto/v1727704191/content/dam/fom-website/drivers/2024Drivers/lawson.png",
                            Team = "Visa Cash App RB F1 Team"
                        },
                        new
                        {
                            Id = 19,
                            BirthDate = new DateTime(1996, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DriverNumber = 23,
                            Name = "Alexander Albon",
                            Nationality = "Thailand",
                            PhotoUrl = "https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/albon",
                            Team = "Williams"
                        },
                        new
                        {
                            Id = 20,
                            BirthDate = new DateTime(2003, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DriverNumber = 43,
                            Name = "Franco Colapinto",
                            Nationality = "Argentine",
                            PhotoUrl = "https://media.formula1.com/image/upload/f_auto/q_auto/v1724927004/content/dam/fom-website/drivers/2024Drivers/colapinto.png",
                            Team = "Williams"
                        });
                });

            modelBuilder.Entity("F1_App.Data.Models.F1History", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AdditionalInfo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChampionDriver")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChampionTeam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfRaces")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("F1Histories");
                });

            modelBuilder.Entity("F1_App.Data.Models.RaceResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DriverId")
                        .HasColumnType("int");

                    b.Property<int>("Position")
                        .HasColumnType("int");

                    b.Property<DateTime>("RaceDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RaceId")
                        .HasColumnType("int");

                    b.Property<string>("RaceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DriverId");

                    b.ToTable("RaceResults");
                });

            modelBuilder.Entity("F1_App.Data.Models.Track", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("LengthKm")
                        .HasColumnType("float");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PhotoUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tracks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            LengthKm = 5.4119999999999999,
                            Location = "Sakhir, Bahrain",
                            Name = "Bahrain International Circuit",
                            PhotoUrl = "https://media.formula1.com/image/upload/f_auto,c_limit,w_1440,q_auto/f_auto/q_auto/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Bahrain_Circuit"
                        },
                        new
                        {
                            Id = 2,
                            LengthKm = 6.1740000000000004,
                            Location = "Jeddah, Saudi Arabia",
                            Name = "Jeddah Corniche Circuit",
                            PhotoUrl = "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Saudi_Arabia_Circuit"
                        },
                        new
                        {
                            Id = 3,
                            LengthKm = 5.2779999999999996,
                            Location = "Melbourne, Australia",
                            Name = "Albert Park Circuit",
                            PhotoUrl = "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Australia_Circuit.png"
                        },
                        new
                        {
                            Id = 4,
                            LengthKm = 6.0030000000000001,
                            Location = "Baku, Azerbaijan",
                            Name = "Baku City Circuit",
                            PhotoUrl = "https://media.formula1.com/image/upload/f_auto,c_limit,w_1440,q_auto/f_auto/q_auto/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Baku_Circuit"
                        },
                        new
                        {
                            Id = 5,
                            LengthKm = 5.4119999999999999,
                            Location = "Miami, United States",
                            Name = "Miami International Autodrome",
                            PhotoUrl = "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Miami_Circuit"
                        },
                        new
                        {
                            Id = 6,
                            LengthKm = 4.9089999999999998,
                            Location = "Imola, Italy",
                            Name = "Imola Circuit",
                            PhotoUrl = "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Emilia_Romagna_Circuit"
                        },
                        new
                        {
                            Id = 7,
                            LengthKm = 3.3370000000000002,
                            Location = "Monte Carlo, Monaco",
                            Name = "Circuit de Monaco",
                            PhotoUrl = "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Monoco_Circuit.png"
                        },
                        new
                        {
                            Id = 8,
                            LengthKm = 4.6749999999999998,
                            Location = "Barcelona, Spain",
                            Name = "Circuit de Barcelona-Catalunya",
                            PhotoUrl = "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Spain_Circuit.png"
                        },
                        new
                        {
                            Id = 9,
                            LengthKm = 4.3609999999999998,
                            Location = "Montreal, Canada",
                            Name = "Circuit Gilles Villeneuve",
                            PhotoUrl = "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Canada_Circuit.png"
                        },
                        new
                        {
                            Id = 10,
                            LengthKm = 4.3179999999999996,
                            Location = "Spielberg, Austria",
                            Name = "Red Bull Ring",
                            PhotoUrl = "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Austria_Circuit.png"
                        },
                        new
                        {
                            Id = 11,
                            LengthKm = 5.891,
                            Location = "Silverstone, United Kingdom",
                            Name = "Silverstone Circuit",
                            PhotoUrl = "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Great_Britain_Circuit.png"
                        },
                        new
                        {
                            Id = 12,
                            LengthKm = 4.3810000000000002,
                            Location = "Budapest, Hungary",
                            Name = "Hungaroring",
                            PhotoUrl = "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Hungary_Circuit.png"
                        },
                        new
                        {
                            Id = 13,
                            LengthKm = 7.0039999999999996,
                            Location = "Spa, Belgium",
                            Name = "Circuit de Spa-Francorchamps",
                            PhotoUrl = "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Belgium_Circuit.png"
                        },
                        new
                        {
                            Id = 14,
                            LengthKm = 4.2590000000000003,
                            Location = "Zandvoort, Netherlands",
                            Name = "Circuit Zandvoort",
                            PhotoUrl = "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Netherlands_Circuit.png"
                        },
                        new
                        {
                            Id = 15,
                            LengthKm = 5.7930000000000001,
                            Location = "Monza, Italy",
                            Name = "Monza Circuit",
                            PhotoUrl = "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Italy_Circuit.png"
                        },
                        new
                        {
                            Id = 16,
                            LengthKm = 5.0629999999999997,
                            Location = "Singapore",
                            Name = "Marina Bay Street Circuit",
                            PhotoUrl = "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Singapore_Circuit.png"
                        },
                        new
                        {
                            Id = 17,
                            LengthKm = 5.8070000000000004,
                            Location = "Suzuka, Japan",
                            Name = "Suzuka International Racing Course",
                            PhotoUrl = "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Japan_Circuit.png"
                        },
                        new
                        {
                            Id = 18,
                            LengthKm = 5.3799999999999999,
                            Location = "Doha, Qatar",
                            Name = "Losail International Circuit",
                            PhotoUrl = "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Qatar_Circuit"
                        },
                        new
                        {
                            Id = 19,
                            LengthKm = 5.5129999999999999,
                            Location = "Austin, United States",
                            Name = "Circuit of the Americas",
                            PhotoUrl = "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/USA_Circuit.png"
                        },
                        new
                        {
                            Id = 20,
                            LengthKm = 4.3040000000000003,
                            Location = "Mexico City, Mexico",
                            Name = "Autódromo Hermanos Rodríguez",
                            PhotoUrl = "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Mexico_Circuit.png"
                        },
                        new
                        {
                            Id = 21,
                            LengthKm = 4.3090000000000002,
                            Location = "São Paulo, Brazil",
                            Name = "Interlagos Circuit",
                            PhotoUrl = "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Brazil_Circuit.png"
                        },
                        new
                        {
                            Id = 22,
                            LengthKm = 6.1200000000000001,
                            Location = "Las Vegas, United States",
                            Name = "Las Vegas Street Circuit",
                            PhotoUrl = "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Las_Vegas_Circuit"
                        },
                        new
                        {
                            Id = 23,
                            LengthKm = 5.2809999999999997,
                            Location = "Abu Dhabi, United Arab Emirates",
                            Name = "Yas Marina Circuit",
                            PhotoUrl = "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Abu_Dhabi_Circuit.png"
                        });
                });

            modelBuilder.Entity("F1_App.Data.Models.UpcomingRace", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("RaceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TrackId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TrackId");

                    b.ToTable("UpcomingRaces");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("F1_App.Data.Models.RaceResult", b =>
                {
                    b.HasOne("F1_App.Data.Models.Driver", "Driver")
                        .WithMany()
                        .HasForeignKey("DriverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Driver");
                });

            modelBuilder.Entity("F1_App.Data.Models.UpcomingRace", b =>
                {
                    b.HasOne("F1_App.Data.Models.Track", "Track")
                        .WithMany()
                        .HasForeignKey("TrackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Track");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
