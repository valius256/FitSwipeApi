using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FitSwipe.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmailTemplates",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<bool>(type: "boolean", nullable: false),
                    Body = table.Column<string>(type: "text", nullable: false),
                    Params = table.Column<string>(type: "text", nullable: true),
                    Subject = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    RecordStatus = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailTemplates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    FireBaseId = table.Column<string>(type: "text", nullable: false),
                    UserName = table.Column<string>(type: "text", nullable: false),
                    Gender = table.Column<int>(type: "integer", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    AvatarUrl = table.Column<string>(type: "text", nullable: true),
                    Phone = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Weight = table.Column<double>(type: "double precision", nullable: true),
                    Height = table.Column<double>(type: "double precision", nullable: true),
                    Bio = table.Column<string>(type: "text", nullable: true),
                    City = table.Column<string>(type: "text", nullable: true),
                    District = table.Column<string>(type: "text", nullable: true),
                    Ward = table.Column<string>(type: "text", nullable: true),
                    Street = table.Column<string>(type: "text", nullable: true),
                    Role = table.Column<int>(type: "integer", nullable: false),
                    Job = table.Column<string>(type: "text", nullable: true),
                    PricePerHour = table.Column<double>(type: "numeric(10,2)", nullable: false, defaultValue: 0.0),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    Balance = table.Column<int>(type: "integer", nullable: true),
                    PTStatus = table.Column<int>(type: "integer", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    PTExperienceYear = table.Column<double>(type: "double precision", nullable: true),
                    PTDegreeImageUrl = table.Column<string>(type: "text", nullable: true),
                    SubscriptionPurchasedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    SubscriptionLevel = table.Column<int>(type: "integer", nullable: true),
                    SubscriptionPaymentStatus = table.Column<int>(type: "integer", nullable: true),
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    RecordStatus = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.FireBaseId);
                });

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ReporterId = table.Column<string>(type: "text", nullable: false),
                    TargetId = table.Column<string>(type: "text", nullable: false),
                    Reason = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    RecordStatus = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reports_Users_ReporterId",
                        column: x => x.ReporterId,
                        principalTable: "Users",
                        principalColumn: "FireBaseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reports_Users_TargetId",
                        column: x => x.TargetId,
                        principalTable: "Users",
                        principalColumn: "FireBaseId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    TagType = table.Column<int>(type: "integer", nullable: false),
                    CreateById = table.Column<string>(type: "text", nullable: false),
                    TagImage = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    RecordStatus = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tags_Users_CreateById",
                        column: x => x.CreateById,
                        principalTable: "Users",
                        principalColumn: "FireBaseId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Trainings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    TraineeId = table.Column<string>(type: "text", nullable: false),
                    PTId = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    Feedback = table.Column<string>(type: "text", nullable: true),
                    Rating = table.Column<double>(type: "double precision", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    RecordStatus = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trainings_Users_PTId",
                        column: x => x.PTId,
                        principalTable: "Users",
                        principalColumn: "FireBaseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Trainings_Users_TraineeId",
                        column: x => x.TraineeId,
                        principalTable: "Users",
                        principalColumn: "FireBaseId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    TranscationCode = table.Column<string>(type: "text", nullable: false),
                    Method = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    UserFireBaseId = table.Column<string>(type: "text", nullable: false),
                    Amount = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    RecordStatus = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transactions_Users_UserFireBaseId",
                        column: x => x.UserFireBaseId,
                        principalTable: "Users",
                        principalColumn: "FireBaseId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserMedias",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    MediaUrl = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    RecordStatus = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMedias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserMedias_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "FireBaseId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ReportImages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    MediaUrl = table.Column<string>(type: "text", nullable: false),
                    ReportId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    RecordStatus = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReportImages_Reports_ReportId",
                        column: x => x.ReportId,
                        principalTable: "Reports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserTags",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    TagId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    RecordStatus = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserTags_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserTags_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "FireBaseId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FeedbackImages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    MediaUrl = table.Column<string>(type: "text", nullable: false),
                    TrainingId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    RecordStatus = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedbackImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FeedbackImages_Trainings_TrainingId",
                        column: x => x.TrainingId,
                        principalTable: "Trainings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Slots",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    StartTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    TrainingId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreateById = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    PaymentStatus = table.Column<int>(type: "integer", nullable: true, defaultValue: 1),
                    Rating = table.Column<double>(type: "double precision", nullable: true),
                    Feedback = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    RecordStatus = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slots", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Slots_Trainings_TrainingId",
                        column: x => x.TrainingId,
                        principalTable: "Trainings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Slots_Users_CreateById",
                        column: x => x.CreateById,
                        principalTable: "Users",
                        principalColumn: "FireBaseId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SlotVideos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SlotId = table.Column<Guid>(type: "uuid", nullable: false),
                    VideoUrl = table.Column<string>(type: "text", nullable: false),
                    Url = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    RecordStatus = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SlotVideos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SlotVideos_Slots_SlotId",
                        column: x => x.SlotId,
                        principalTable: "Slots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TransactionSlots",
                columns: table => new
                {
                    SlotId = table.Column<Guid>(type: "uuid", nullable: false),
                    TransactionId = table.Column<Guid>(type: "uuid", nullable: false),
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    RecordStatus = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionSlots", x => new { x.SlotId, x.TransactionId });
                    table.ForeignKey(
                        name: "FK_TransactionSlots_Slots_SlotId",
                        column: x => x.SlotId,
                        principalTable: "Slots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TransactionSlots_Transactions_TransactionId",
                        column: x => x.TransactionId,
                        principalTable: "Transactions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "EmailTemplates",
                columns: new[] { "Id", "Body", "CreatedDate", "DeletedDate", "Description", "Name", "Params", "RecordStatus", "Status", "Subject", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("2549dc34-b7e6-4d68-a026-8b5e09f23362"), "Chúng tôi đã nhận được yêu cầu đặt lại mật khẩu cho tài khoản của bạn tại FitWipe. Kính gửi [Name], vui lòng đặt lại mật khẩu của bạn bằng cách nhấn vào đường link sau: <a href=\"[ResetPasswordLink]\">Đặt lại mật khẩu</a>.<br><br>Nếu bạn không yêu cầu việc này, vui lòng bỏ qua email này.<br><br>Đội ngũ FitWipe", new DateTime(2024, 9, 27, 7, 50, 24, 509, DateTimeKind.Utc).AddTicks(7771), null, "Email này được gửi khi người dùng yêu cầu đặt lại mật khẩu cho tài khoản FitWipe.", "Forgot_Password", "[Name], [ResetPasswordLink]", 0, true, "Yêu cầu đặt lại mật khẩu FitWipe", null },
                    { new Guid("3d4a1c24-ed0b-4497-9019-99103af4390b"), "Chào mừng bạn đến với FitWipe! Kính gửi [Name], vui lòng xác nhận địa chỉ email của bạn bằng cách nhấn vào đường link sau: <a href=\"[VerificationLink]\">Xác nhận Email</a>.<br><br>Cảm ơn bạn đã tham gia cùng chúng tôi!<br><br>Đội ngũ FitWipe", new DateTime(2024, 9, 27, 7, 50, 24, 509, DateTimeKind.Utc).AddTicks(7749), null, "Email này được gửi để xác nhận đăng ký tài khoản FitWipe.", "Register_Mail", "[Name], [VerificationLink]", 0, true, "Chào mừng đến với FitWipe! Vui lòng xác nhận email của bạn", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "FireBaseId", "AvatarUrl", "Balance", "Bio", "City", "CreatedDate", "DateOfBirth", "DeletedDate", "Description", "District", "Email", "Gender", "Height", "Id", "Job", "PTDegreeImageUrl", "PTExperienceYear", "PTStatus", "Password", "Phone", "RecordStatus", "Role", "Status", "Street", "SubscriptionLevel", "SubscriptionPaymentStatus", "SubscriptionPurchasedDate", "UpdatedDate", "UserName", "Ward", "Weight" },
                values: new object[] { "123abc", "https://example.com/avatar1.jpg", 1000, "Fitness enthusiast and certified personal trainer.", "New York", new DateTime(2024, 9, 27, 7, 50, 24, 509, DateTimeKind.Utc).AddTicks(7495), new DateTime(1990, 5, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, null, "Manhattan", "john.doe@example.com", 0, 180.30000000000001, new Guid("946e340e-2207-48fe-82f6-7ac424008bab"), "Student", null, null, null, "hashedpassword1", "1234567890", 0, 0, 0, "5th Avenue", null, null, null, null, "john doe", "Ward 5", 75.5 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "FireBaseId", "AvatarUrl", "Balance", "Bio", "City", "CreatedDate", "DateOfBirth", "DeletedDate", "Description", "District", "Email", "Gender", "Height", "Id", "Job", "PTDegreeImageUrl", "PTExperienceYear", "PTStatus", "Password", "Phone", "PricePerHour", "RecordStatus", "Role", "Status", "Street", "SubscriptionLevel", "SubscriptionPaymentStatus", "SubscriptionPurchasedDate", "UpdatedDate", "UserName", "Ward", "Weight" },
                values: new object[,]
                {
                    { "456def", "https://example.com/avatar2.jpg", 1500, "Yoga instructor with a passion for holistic health.", "Los Angeles", new DateTime(2024, 9, 27, 7, 50, 24, 509, DateTimeKind.Utc).AddTicks(7538), new DateTime(1985, 8, 20, 0, 0, 0, 0, DateTimeKind.Utc), null, null, "Beverly Hills", "jane.smith@example.com", 1, 170.19999999999999, new Guid("8a9d3d48-4fc4-4218-83db-8de82b247a28"), "Yoga Instructor", null, 3.5, 1, "hashedpassword2", "0987654321", 100000.0, 0, 1, 0, "Rodeo Drive", 1, 0, new DateTime(2023, 2, 10, 0, 0, 0, 0, DateTimeKind.Utc), null, "jane smith", "Ward 3", 65.0 },
                    { "789ghi", "https://example.com/avatar3.jpg", 2000, "Aspiring bodybuilder and nutrition expert.", "Chicago", new DateTime(2024, 9, 27, 7, 50, 24, 509, DateTimeKind.Utc).AddTicks(7547), new DateTime(1992, 3, 10, 0, 0, 0, 0, DateTimeKind.Utc), null, null, "Lincoln Park", "alex.jones@example.com", 0, 185.40000000000001, new Guid("6142fe08-d75d-46bb-bc89-a0f860192c0a"), "Nutritionist", null, 2.0, 0, "hashedpassword3", "5551234567", 150000.0, 0, 1, 0, "Clark Street", null, null, null, null, "alex jones", "Ward 7", 85.0 }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreateById", "CreatedDate", "DeletedDate", "Name", "RecordStatus", "TagImage", "TagType", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0cfc7076-b3d5-4b8b-b9d5-4ec5fb651d1c"), "123abc", new DateTime(2024, 9, 27, 7, 50, 24, 509, DateTimeKind.Utc).AddTicks(7714), null, "Siêng năng", 0, null, 4, null },
                    { new Guid("4b379bea-f884-405d-8e47-6aa087633f14"), "123abc", new DateTime(2024, 9, 27, 7, 50, 24, 509, DateTimeKind.Utc).AddTicks(7709), null, "Ngoại hình đẹp", 0, null, 3, null },
                    { new Guid("5873fa44-8f08-45b2-8a00-6170515ca940"), "123abc", new DateTime(2024, 9, 27, 7, 50, 24, 509, DateTimeKind.Utc).AddTicks(7704), null, "Phát triển cơ bắp", 0, null, 1, null },
                    { new Guid("60856b8a-33b4-40b3-b4ce-a57a8c8b9a22"), "123abc", new DateTime(2024, 9, 27, 7, 50, 24, 509, DateTimeKind.Utc).AddTicks(7708), null, "Cardino", 0, null, 2, null },
                    { new Guid("991b69e6-cf77-4d82-975d-0cdb0999f4a3"), "123abc", new DateTime(2024, 9, 27, 7, 50, 24, 509, DateTimeKind.Utc).AddTicks(7685), null, "Giảm cân", 0, null, 1, null },
                    { new Guid("aed8e0d1-0b25-48e5-a50e-d39bfde282be"), "123abc", new DateTime(2024, 9, 27, 7, 50, 24, 509, DateTimeKind.Utc).AddTicks(7681), null, "Bóng đá", 0, null, 0, null },
                    { new Guid("befc0381-c5bf-4b7c-abd3-d9180fe73c17"), "123abc", new DateTime(2024, 9, 27, 7, 50, 24, 509, DateTimeKind.Utc).AddTicks(7713), null, "Kiên trì", 0, null, 4, null },
                    { new Guid("d98b9fbe-6ea2-404b-a171-ecc73ea95440"), "123abc", new DateTime(2024, 9, 27, 7, 50, 24, 509, DateTimeKind.Utc).AddTicks(7706), null, "Yoga", 0, null, 2, null },
                    { new Guid("f6ebaff4-cf62-4fdd-9f2c-64f5cf609ec4"), "123abc", new DateTime(2024, 9, 27, 7, 50, 24, 509, DateTimeKind.Utc).AddTicks(7683), null, "Video game", 0, null, 0, null },
                    { new Guid("ff178496-071d-4830-89d4-e72cc7991552"), "123abc", new DateTime(2024, 9, 27, 7, 50, 24, 509, DateTimeKind.Utc).AddTicks(7711), null, "Giá rẻ", 0, null, 3, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FeedbackImages_TrainingId",
                table: "FeedbackImages",
                column: "TrainingId");

            migrationBuilder.CreateIndex(
                name: "IX_ReportImages_ReportId",
                table: "ReportImages",
                column: "ReportId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_ReporterId",
                table: "Reports",
                column: "ReporterId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_TargetId",
                table: "Reports",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_Slots_CreateById",
                table: "Slots",
                column: "CreateById");

            migrationBuilder.CreateIndex(
                name: "IX_Slots_TrainingId",
                table: "Slots",
                column: "TrainingId");

            migrationBuilder.CreateIndex(
                name: "IX_SlotVideos_SlotId",
                table: "SlotVideos",
                column: "SlotId");

            migrationBuilder.CreateIndex(
                name: "IX_Tags_CreateById",
                table: "Tags",
                column: "CreateById");

            migrationBuilder.CreateIndex(
                name: "IX_Trainings_PTId",
                table: "Trainings",
                column: "PTId");

            migrationBuilder.CreateIndex(
                name: "IX_Trainings_TraineeId",
                table: "Trainings",
                column: "TraineeId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_UserFireBaseId",
                table: "Transactions",
                column: "UserFireBaseId");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionSlots_TransactionId",
                table: "TransactionSlots",
                column: "TransactionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserMedias_UserId",
                table: "UserMedias",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTags_TagId",
                table: "UserTags",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTags_UserId",
                table: "UserTags",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmailTemplates");

            migrationBuilder.DropTable(
                name: "FeedbackImages");

            migrationBuilder.DropTable(
                name: "ReportImages");

            migrationBuilder.DropTable(
                name: "SlotVideos");

            migrationBuilder.DropTable(
                name: "TransactionSlots");

            migrationBuilder.DropTable(
                name: "UserMedias");

            migrationBuilder.DropTable(
                name: "UserTags");

            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropTable(
                name: "Slots");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Trainings");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
