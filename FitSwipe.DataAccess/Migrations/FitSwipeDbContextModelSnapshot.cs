﻿// <auto-generated />
using System;
using FitSwipe.DataAccess.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FitSwipe.DataAccess.Migrations
{
    [DbContext(typeof(FitSwipeDbContext))]
    partial class FitSwipeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FitSwipe.DataAccess.Model.Entity.Tag", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreateById")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RecordStatus")
                        .HasColumnType("int");

                    b.Property<int>("TagType")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Tag");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3f27c7ae-4554-4775-8f3a-75353d84d150"),
                            CreateById = "123abc",
                            CreatedDate = new DateTime(2024, 9, 7, 22, 8, 27, 573, DateTimeKind.Local).AddTicks(2491),
                            Name = "Bóng đá",
                            RecordStatus = 0,
                            TagType = 0
                        });
                });

            modelBuilder.Entity("FitSwipe.DataAccess.Model.Entity.User", b =>
                {
                    b.Property<string>("FireBaseId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AvatarUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Balance")
                        .HasColumnType("int");

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<double>("Height")
                        .HasColumnType("float");

                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Job")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("PTExperienceYear")
                        .HasColumnType("float");

                    b.Property<int?>("PTStatus")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RecordStatus")
                        .HasColumnType("int");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SubscriptionLevel")
                        .HasColumnType("int");

                    b.Property<int?>("SubscriptionPaymentStatus")
                        .HasColumnType("int");

                    b.Property<DateTime?>("SubscriptionPurchasedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ward")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("FireBaseId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            FireBaseId = "123abc",
                            AvatarUrl = "https://example.com/avatar1.jpg",
                            Balance = 1000,
                            Bio = "Fitness enthusiast and certified personal trainer.",
                            City = "New York",
                            CreatedDate = new DateTime(2024, 9, 7, 22, 8, 27, 573, DateTimeKind.Local).AddTicks(2172),
                            DateOfBirth = new DateTime(1990, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            District = "Manhattan",
                            Email = "john.doe@example.com",
                            Gender = 0,
                            Height = 180.30000000000001,
                            Id = new Guid("00000000-0000-0000-0000-000000000000"),
                            Job = "Student",
                            Password = "hashedpassword1",
                            Phone = "1234567890",
                            RecordStatus = 0,
                            Role = 0,
                            Status = 0,
                            Street = "5th Avenue",
                            UserName = "john doe",
                            Ward = "Ward 5",
                            Weight = 75.5
                        },
                        new
                        {
                            FireBaseId = "456def",
                            AvatarUrl = "https://example.com/avatar2.jpg",
                            Balance = 1500,
                            Bio = "Yoga instructor with a passion for holistic health.",
                            City = "Los Angeles",
                            CreatedDate = new DateTime(2024, 9, 7, 22, 8, 27, 573, DateTimeKind.Local).AddTicks(2211),
                            DateOfBirth = new DateTime(1985, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            District = "Beverly Hills",
                            Email = "jane.smith@example.com",
                            Gender = 1,
                            Height = 170.19999999999999,
                            Id = new Guid("00000000-0000-0000-0000-000000000000"),
                            Job = "Yoga Instructor",
                            PTExperienceYear = 3.5,
                            PTStatus = 1,
                            Password = "hashedpassword2",
                            Phone = "0987654321",
                            RecordStatus = 0,
                            Role = 1,
                            Status = 0,
                            Street = "Rodeo Drive",
                            SubscriptionLevel = 1,
                            SubscriptionPaymentStatus = 0,
                            SubscriptionPurchasedDate = new DateTime(2023, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserName = "jane smith",
                            Ward = "Ward 3",
                            Weight = 65.0
                        },
                        new
                        {
                            FireBaseId = "789ghi",
                            AvatarUrl = "https://example.com/avatar3.jpg",
                            Balance = 2000,
                            Bio = "Aspiring bodybuilder and nutrition expert.",
                            City = "Chicago",
                            CreatedDate = new DateTime(2024, 9, 7, 22, 8, 27, 573, DateTimeKind.Local).AddTicks(2231),
                            DateOfBirth = new DateTime(1992, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            District = "Lincoln Park",
                            Email = "alex.jones@example.com",
                            Gender = 0,
                            Height = 185.40000000000001,
                            Id = new Guid("00000000-0000-0000-0000-000000000000"),
                            Job = "Nutritionist",
                            PTExperienceYear = 2.0,
                            PTStatus = 0,
                            Password = "hashedpassword3",
                            Phone = "5551234567",
                            RecordStatus = 0,
                            Role = 1,
                            Status = 0,
                            Street = "Clark Street",
                            UserName = "alex jones",
                            Ward = "Ward 7",
                            Weight = 85.0
                        });
                });

            modelBuilder.Entity("FitSwipe.DataAccess.Model.Entity.UserTag", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RecordStatus")
                        .HasColumnType("int");

                    b.Property<Guid>("TagId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("TagId");

                    b.HasIndex("UserId");

                    b.ToTable("UserTag");
                });

            modelBuilder.Entity("FitSwipe.DataAccess.Model.Entity.UserTag", b =>
                {
                    b.HasOne("FitSwipe.DataAccess.Model.Entity.Tag", "Tag")
                        .WithMany("UserTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FitSwipe.DataAccess.Model.Entity.User", "User")
                        .WithMany("UserTags")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tag");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FitSwipe.DataAccess.Model.Entity.Tag", b =>
                {
                    b.Navigation("UserTags");
                });

            modelBuilder.Entity("FitSwipe.DataAccess.Model.Entity.User", b =>
                {
                    b.Navigation("UserTags");
                });
#pragma warning restore 612, 618
        }
    }
}
