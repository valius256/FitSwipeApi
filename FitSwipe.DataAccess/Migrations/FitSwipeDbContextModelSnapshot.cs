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

            modelBuilder.Entity("FitSwipe.DataAccess.Model.Entity.EmailTemplate", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Params")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RecordStatus")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("EmailTemplates");

                    b.HasData(
                        new
                        {
                            Id = new Guid("37ffcb4b-e151-4841-a6b3-9cd8d0e0d8ac"),
                            Body = "Chào mừng bạn đến với FitWipe! Kính gửi [Name], vui lòng xác nhận địa chỉ email của bạn bằng cách nhấn vào đường link sau: <a href=\"[VerificationLink]\">Xác nhận Email</a>.<br><br>Cảm ơn bạn đã tham gia cùng chúng tôi!<br><br>Đội ngũ FitWipe",
                            CreatedDate = new DateTime(2024, 9, 13, 11, 0, 14, 798, DateTimeKind.Local).AddTicks(4017),
                            Description = "Email này được gửi để xác nhận đăng ký tài khoản FitWipe.",
                            Name = "Register_Mail",
                            Params = "[Name], [VerificationLink]",
                            RecordStatus = 0,
                            Status = true,
                            Subject = "Chào mừng đến với FitWipe! Vui lòng xác nhận email của bạn"
                        });
                });

            modelBuilder.Entity("FitSwipe.DataAccess.Model.Entity.FeedbackImage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MediaUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RecordStatus")
                        .HasColumnType("int");

                    b.Property<Guid>("TrainingId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("TrainingId");

                    b.ToTable("FeedbackImages");
                });

            modelBuilder.Entity("FitSwipe.DataAccess.Model.Entity.Report", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RecordStatus")
                        .HasColumnType("int");

                    b.Property<string>("ReporterId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("TargetId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ReporterId");

                    b.HasIndex("TargetId");

                    b.ToTable("Reports");
                });

            modelBuilder.Entity("FitSwipe.DataAccess.Model.Entity.ReportImage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MediaUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RecordStatus")
                        .HasColumnType("int");

                    b.Property<Guid>("ReportId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ReportId");

                    b.ToTable("ReportImages");
                });

            modelBuilder.Entity("FitSwipe.DataAccess.Model.Entity.Slot", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreateById")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Feedback")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PaymentStatus")
                        .HasColumnType("int");

                    b.Property<double?>("Rating")
                        .HasColumnType("float");

                    b.Property<int>("RecordStatus")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<Guid?>("TrainingId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CreateById");

                    b.HasIndex("TrainingId");

                    b.ToTable("Slots");
                });

            modelBuilder.Entity("FitSwipe.DataAccess.Model.Entity.Tag", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreateById")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

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

                    b.HasIndex("CreateById");

                    b.ToTable("Tags");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4dc8625b-6c11-4169-8898-d6e4f07b6ea9"),
                            CreateById = "123abc",
                            CreatedDate = new DateTime(2024, 9, 13, 11, 0, 14, 798, DateTimeKind.Local).AddTicks(3921),
                            Name = "Bóng đá",
                            RecordStatus = 0,
                            TagType = 0
                        },
                        new
                        {
                            Id = new Guid("dd2cdbb9-6f37-4808-aca0-92451530e993"),
                            CreateById = "123abc",
                            CreatedDate = new DateTime(2024, 9, 13, 11, 0, 14, 798, DateTimeKind.Local).AddTicks(3952),
                            Name = "Video game",
                            RecordStatus = 0,
                            TagType = 0
                        },
                        new
                        {
                            Id = new Guid("dcf1b292-c36d-48cb-9a90-7a77dc349a5e"),
                            CreateById = "123abc",
                            CreatedDate = new DateTime(2024, 9, 13, 11, 0, 14, 798, DateTimeKind.Local).AddTicks(3954),
                            Name = "Giảm cân",
                            RecordStatus = 0,
                            TagType = 1
                        },
                        new
                        {
                            Id = new Guid("5c1f6d7d-ffac-4cfe-9672-67480f7cb0e2"),
                            CreateById = "123abc",
                            CreatedDate = new DateTime(2024, 9, 13, 11, 0, 14, 798, DateTimeKind.Local).AddTicks(3956),
                            Name = "Phát triển cơ bắp",
                            RecordStatus = 0,
                            TagType = 1
                        },
                        new
                        {
                            Id = new Guid("63a41480-88d6-4cbb-84df-29a358098135"),
                            CreateById = "123abc",
                            CreatedDate = new DateTime(2024, 9, 13, 11, 0, 14, 798, DateTimeKind.Local).AddTicks(3958),
                            Name = "Yoga",
                            RecordStatus = 0,
                            TagType = 2
                        },
                        new
                        {
                            Id = new Guid("af5a3c23-7389-4716-a6c3-ffb182374f28"),
                            CreateById = "123abc",
                            CreatedDate = new DateTime(2024, 9, 13, 11, 0, 14, 798, DateTimeKind.Local).AddTicks(3959),
                            Name = "Cardino",
                            RecordStatus = 0,
                            TagType = 2
                        },
                        new
                        {
                            Id = new Guid("7e6e1be0-41dd-41e4-9558-aa04d94336f1"),
                            CreateById = "123abc",
                            CreatedDate = new DateTime(2024, 9, 13, 11, 0, 14, 798, DateTimeKind.Local).AddTicks(3961),
                            Name = "Ngoại hình đẹp",
                            RecordStatus = 0,
                            TagType = 3
                        },
                        new
                        {
                            Id = new Guid("01e60536-8f6d-4e51-9121-c2fb51046174"),
                            CreateById = "123abc",
                            CreatedDate = new DateTime(2024, 9, 13, 11, 0, 14, 798, DateTimeKind.Local).AddTicks(3981),
                            Name = "Giá rẻ",
                            RecordStatus = 0,
                            TagType = 3
                        },
                        new
                        {
                            Id = new Guid("980142da-b60f-47b7-9600-2239f8a2cd61"),
                            CreateById = "123abc",
                            CreatedDate = new DateTime(2024, 9, 13, 11, 0, 14, 798, DateTimeKind.Local).AddTicks(3983),
                            Name = "Kiên trì",
                            RecordStatus = 0,
                            TagType = 4
                        },
                        new
                        {
                            Id = new Guid("9c25e1e5-83b5-45bb-9d5c-a7c40531223a"),
                            CreateById = "123abc",
                            CreatedDate = new DateTime(2024, 9, 13, 11, 0, 14, 798, DateTimeKind.Local).AddTicks(3985),
                            Name = "Siêng năng",
                            RecordStatus = 0,
                            TagType = 4
                        });
                });

            modelBuilder.Entity("FitSwipe.DataAccess.Model.Entity.Training", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Feedback")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PTId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<double?>("Rating")
                        .HasColumnType("float");

                    b.Property<int>("RecordStatus")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("TraineeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("PTId");

                    b.HasIndex("TraineeId");

                    b.ToTable("Trainings");
                });

            modelBuilder.Entity("FitSwipe.DataAccess.Model.Entity.Transaction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Method")
                        .HasColumnType("int");

                    b.Property<int>("RecordStatus")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("TranscationCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserFireBaseId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserFireBaseId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("FitSwipe.DataAccess.Model.Entity.User", b =>
                {
                    b.Property<string>("FireBaseId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AvatarUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Balance")
                        .HasColumnType("int");

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("District")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<double?>("Height")
                        .HasColumnType("float");

                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Job")
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
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<int>("RecordStatus")
                        .HasColumnType("int");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Street")
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
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Weight")
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
                            CreatedDate = new DateTime(2024, 9, 13, 11, 0, 14, 798, DateTimeKind.Local).AddTicks(3560),
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
                            CreatedDate = new DateTime(2024, 9, 13, 11, 0, 14, 798, DateTimeKind.Local).AddTicks(3582),
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
                            CreatedDate = new DateTime(2024, 9, 13, 11, 0, 14, 798, DateTimeKind.Local).AddTicks(3591),
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

            modelBuilder.Entity("FitSwipe.DataAccess.Model.Entity.UserMedia", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MediaUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RecordStatus")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserMedias");
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

                    b.ToTable("UserTags");
                });

            modelBuilder.Entity("FitSwipe.DataAccess.Model.Entity.FeedbackImage", b =>
                {
                    b.HasOne("FitSwipe.DataAccess.Model.Entity.Training", "Training")
                        .WithMany("FeedbackImages")
                        .HasForeignKey("TrainingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Training");
                });

            modelBuilder.Entity("FitSwipe.DataAccess.Model.Entity.Report", b =>
                {
                    b.HasOne("FitSwipe.DataAccess.Model.Entity.User", "Reporter")
                        .WithMany("ReportsCreated")
                        .HasForeignKey("ReporterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FitSwipe.DataAccess.Model.Entity.User", "Target")
                        .WithMany("ReportsReceived")
                        .HasForeignKey("TargetId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Reporter");

                    b.Navigation("Target");
                });

            modelBuilder.Entity("FitSwipe.DataAccess.Model.Entity.ReportImage", b =>
                {
                    b.HasOne("FitSwipe.DataAccess.Model.Entity.Report", "Report")
                        .WithMany("ReportImages")
                        .HasForeignKey("ReportId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Report");
                });

            modelBuilder.Entity("FitSwipe.DataAccess.Model.Entity.Slot", b =>
                {
                    b.HasOne("FitSwipe.DataAccess.Model.Entity.User", "CreateBy")
                        .WithMany("SlotsCreated")
                        .HasForeignKey("CreateById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FitSwipe.DataAccess.Model.Entity.Training", "Training")
                        .WithMany("Slots")
                        .HasForeignKey("TrainingId");

                    b.Navigation("CreateBy");

                    b.Navigation("Training");
                });

            modelBuilder.Entity("FitSwipe.DataAccess.Model.Entity.Tag", b =>
                {
                    b.HasOne("FitSwipe.DataAccess.Model.Entity.User", "CreateBy")
                        .WithMany("TagsCreated")
                        .HasForeignKey("CreateById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CreateBy");
                });

            modelBuilder.Entity("FitSwipe.DataAccess.Model.Entity.Training", b =>
                {
                    b.HasOne("FitSwipe.DataAccess.Model.Entity.User", "PT")
                        .WithMany("TrainingsInstructing")
                        .HasForeignKey("PTId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FitSwipe.DataAccess.Model.Entity.User", "Trainee")
                        .WithMany("TrainingsAttending")
                        .HasForeignKey("TraineeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PT");

                    b.Navigation("Trainee");
                });

            modelBuilder.Entity("FitSwipe.DataAccess.Model.Entity.Transaction", b =>
                {
                    b.HasOne("FitSwipe.DataAccess.Model.Entity.User", "User")
                        .WithMany("Transactions")
                        .HasForeignKey("UserFireBaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("FitSwipe.DataAccess.Model.Entity.UserMedia", b =>
                {
                    b.HasOne("FitSwipe.DataAccess.Model.Entity.User", "User")
                        .WithMany("UserMedias")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
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
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Tag");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FitSwipe.DataAccess.Model.Entity.Report", b =>
                {
                    b.Navigation("ReportImages");
                });

            modelBuilder.Entity("FitSwipe.DataAccess.Model.Entity.Tag", b =>
                {
                    b.Navigation("UserTags");
                });

            modelBuilder.Entity("FitSwipe.DataAccess.Model.Entity.Training", b =>
                {
                    b.Navigation("FeedbackImages");

                    b.Navigation("Slots");
                });

            modelBuilder.Entity("FitSwipe.DataAccess.Model.Entity.User", b =>
                {
                    b.Navigation("ReportsCreated");

                    b.Navigation("ReportsReceived");

                    b.Navigation("SlotsCreated");

                    b.Navigation("TagsCreated");

                    b.Navigation("TrainingsAttending");

                    b.Navigation("TrainingsInstructing");

                    b.Navigation("Transactions");

                    b.Navigation("UserMedias");

                    b.Navigation("UserTags");
                });
#pragma warning restore 612, 618
        }
    }
}
