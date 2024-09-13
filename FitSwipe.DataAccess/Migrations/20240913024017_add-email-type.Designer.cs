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
    [Migration("20240913024017_add-email-type")]
    partial class addemailtype
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            Id = new Guid("99d45996-f979-4661-91b0-1849cd9326e2"),
                            Body = "Chào mừng bạn đến với FitWipe! Kính gửi [Name], vui lòng xác nhận địa chỉ email của bạn bằng cách nhấn vào đường link sau: <a href=\"[VerificationLink]\">Xác nhận Email</a>.<br><br>Cảm ơn bạn đã tham gia cùng chúng tôi!<br><br>Đội ngũ FitWipe",
                            CreatedDate = new DateTime(2024, 9, 13, 9, 40, 16, 207, DateTimeKind.Local).AddTicks(1894),
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
                            Id = new Guid("37746ec9-77e7-4f23-8581-82dc8a39a53e"),
                            CreateById = "123abc",
                            CreatedDate = new DateTime(2024, 9, 13, 9, 40, 16, 207, DateTimeKind.Local).AddTicks(1163),
                            Name = "Bóng đá",
                            RecordStatus = 0,
                            TagType = 0
                        },
                        new
                        {
                            Id = new Guid("e8bb5ea5-bcc2-47a2-ab2f-67019f17fc57"),
                            CreateById = "123abc",
                            CreatedDate = new DateTime(2024, 9, 13, 9, 40, 16, 207, DateTimeKind.Local).AddTicks(1714),
                            Name = "Video game",
                            RecordStatus = 0,
                            TagType = 0
                        },
                        new
                        {
                            Id = new Guid("b69568f1-4554-45b6-a8d1-4cffa337a47e"),
                            CreateById = "123abc",
                            CreatedDate = new DateTime(2024, 9, 13, 9, 40, 16, 207, DateTimeKind.Local).AddTicks(1724),
                            Name = "Giảm cân",
                            RecordStatus = 0,
                            TagType = 1
                        },
                        new
                        {
                            Id = new Guid("69c05d09-c421-48c0-bc8c-535d8b882507"),
                            CreateById = "123abc",
                            CreatedDate = new DateTime(2024, 9, 13, 9, 40, 16, 207, DateTimeKind.Local).AddTicks(1726),
                            Name = "Phát triển cơ bắp",
                            RecordStatus = 0,
                            TagType = 1
                        },
                        new
                        {
                            Id = new Guid("54c1fe87-454c-4079-88bb-77112eadfee2"),
                            CreateById = "123abc",
                            CreatedDate = new DateTime(2024, 9, 13, 9, 40, 16, 207, DateTimeKind.Local).AddTicks(1728),
                            Name = "Yoga",
                            RecordStatus = 0,
                            TagType = 2
                        },
                        new
                        {
                            Id = new Guid("1d40e227-34fe-49ae-bf3d-f760f4587671"),
                            CreateById = "123abc",
                            CreatedDate = new DateTime(2024, 9, 13, 9, 40, 16, 207, DateTimeKind.Local).AddTicks(1730),
                            Name = "Cardino",
                            RecordStatus = 0,
                            TagType = 2
                        },
                        new
                        {
                            Id = new Guid("c73e2bb5-118c-42f7-be86-4375b925db72"),
                            CreateById = "123abc",
                            CreatedDate = new DateTime(2024, 9, 13, 9, 40, 16, 207, DateTimeKind.Local).AddTicks(1733),
                            Name = "Ngoại hình đẹp",
                            RecordStatus = 0,
                            TagType = 3
                        },
                        new
                        {
                            Id = new Guid("bb082e23-fc4f-4155-8708-9c031e2aaf46"),
                            CreateById = "123abc",
                            CreatedDate = new DateTime(2024, 9, 13, 9, 40, 16, 207, DateTimeKind.Local).AddTicks(1764),
                            Name = "Giá rẻ",
                            RecordStatus = 0,
                            TagType = 3
                        },
                        new
                        {
                            Id = new Guid("835e2424-87ff-4ce9-9786-a85a83f89e67"),
                            CreateById = "123abc",
                            CreatedDate = new DateTime(2024, 9, 13, 9, 40, 16, 207, DateTimeKind.Local).AddTicks(1767),
                            Name = "Kiên trì",
                            RecordStatus = 0,
                            TagType = 4
                        },
                        new
                        {
                            Id = new Guid("24e3fbd0-c566-4003-8693-6b53a26c5b44"),
                            CreateById = "123abc",
                            CreatedDate = new DateTime(2024, 9, 13, 9, 40, 16, 207, DateTimeKind.Local).AddTicks(1769),
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
                            CreatedDate = new DateTime(2024, 9, 13, 9, 40, 16, 206, DateTimeKind.Local).AddTicks(9685),
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
                            CreatedDate = new DateTime(2024, 9, 13, 9, 40, 16, 206, DateTimeKind.Local).AddTicks(9713),
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
                            CreatedDate = new DateTime(2024, 9, 13, 9, 40, 16, 206, DateTimeKind.Local).AddTicks(9729),
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
