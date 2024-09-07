﻿// <auto-generated />
using System;
using FitSwipe.DataAccess.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FitSwipe.DataAccess.Migrations
{
    [DbContext(typeof(FitSwipeDbContext))]
    [Migration("20240907114503_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FitSwipe.Shared.Model.User.User", b =>
                {
                    b.Property<string>("FireBaseId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AvatarUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FavoriteSport")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<double>("Height")
                        .HasColumnType("float");

                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RecordStatus")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("FireBaseId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            FireBaseId = "uid1",
                            AvatarUrl = "https://example.com/avatar1.png",
                            Bio = "Fitness enthusiast",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfBirth = new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeletedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "johndoe@example.com",
                            FavoriteSport = "[0,6]",
                            Gender = 0,
                            Height = 180.19999999999999,
                            Id = new Guid("00000000-0000-0000-0000-000000000000"),
                            Password = "hashedpassword1",
                            Phone = "1234567890",
                            RecordStatus = 0,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserName = "johndoe",
                            Weight = 80.5
                        },
                        new
                        {
                            FireBaseId = "uid2",
                            AvatarUrl = "https://example.com/avatar2.png",
                            Bio = "Yoga lover",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfBirth = new DateTime(1992, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeletedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "janesmith@example.com",
                            FavoriteSport = "[2,3]",
                            Gender = 1,
                            Height = 165.69999999999999,
                            Id = new Guid("00000000-0000-0000-0000-000000000000"),
                            Password = "hashedpassword2",
                            Phone = "0987654321",
                            RecordStatus = 0,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserName = "janesmith",
                            Weight = 60.299999999999997
                        },
                        new
                        {
                            FireBaseId = "uid3",
                            AvatarUrl = "https://example.com/avatar3.png",
                            Bio = "Crossfit and cycling fanatic",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfBirth = new DateTime(1985, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeletedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "roberthill@example.com",
                            FavoriteSport = "[5,7]",
                            Gender = 0,
                            Height = 175.30000000000001,
                            Id = new Guid("00000000-0000-0000-0000-000000000000"),
                            Password = "hashedpassword3",
                            Phone = "1122334455",
                            RecordStatus = 0,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserName = "roberthill",
                            Weight = 75.0
                        },
                        new
                        {
                            FireBaseId = "uid4",
                            AvatarUrl = "https://example.com/avatar4.png",
                            Bio = "Dancer and fitness lover",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfBirth = new DateTime(1995, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeletedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "sarahlee@example.com",
                            FavoriteSport = "[4,1]",
                            Gender = 1,
                            Height = 160.80000000000001,
                            Id = new Guid("00000000-0000-0000-0000-000000000000"),
                            Password = "hashedpassword4",
                            Phone = "5544332211",
                            RecordStatus = 0,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserName = "sarahlee",
                            Weight = 58.200000000000003
                        },
                        new
                        {
                            FireBaseId = "uid5",
                            AvatarUrl = "https://example.com/avatar5.png",
                            Bio = "Climbing and hiking lover",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfBirth = new DateTime(1988, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeletedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "michaelgreen@example.com",
                            FavoriteSport = "[9,10]",
                            Gender = 0,
                            Height = 185.5,
                            Id = new Guid("00000000-0000-0000-0000-000000000000"),
                            Password = "hashedpassword5",
                            Phone = "6677889900",
                            RecordStatus = 0,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserName = "michaelgreen",
                            Weight = 85.700000000000003
                        },
                        new
                        {
                            FireBaseId = "uid6",
                            AvatarUrl = "https://example.com/avatar6.png",
                            Bio = "Pilates and yoga enthusiast",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfBirth = new DateTime(1996, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeletedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "emilybrown@example.com",
                            FavoriteSport = "[3,2]",
                            Gender = 1,
                            Height = 170.0,
                            Id = new Guid("00000000-0000-0000-0000-000000000000"),
                            Password = "hashedpassword6",
                            Phone = "1029384756",
                            RecordStatus = 0,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserName = "emilybrown",
                            Weight = 63.0
                        },
                        new
                        {
                            FireBaseId = "uid7",
                            AvatarUrl = "https://example.com/avatar7.png",
                            Bio = "Swimming and crossfit lover",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfBirth = new DateTime(1982, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeletedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "davidjohnson@example.com",
                            FavoriteSport = "[8,5]",
                            Gender = 0,
                            Height = 182.5,
                            Id = new Guid("00000000-0000-0000-0000-000000000000"),
                            Password = "hashedpassword7",
                            Phone = "3344556677",
                            RecordStatus = 0,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserName = "davidjohnson",
                            Weight = 90.299999999999997
                        },
                        new
                        {
                            FireBaseId = "uid8",
                            AvatarUrl = "https://example.com/avatar8.png",
                            Bio = "Yoga and running lover",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfBirth = new DateTime(1994, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeletedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "oliviabaker@example.com",
                            FavoriteSport = "[2,6]",
                            Gender = 1,
                            Height = 162.30000000000001,
                            Id = new Guid("00000000-0000-0000-0000-000000000000"),
                            Password = "hashedpassword8",
                            Phone = "4455667788",
                            RecordStatus = 0,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserName = "oliviabaker",
                            Weight = 59.399999999999999
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
