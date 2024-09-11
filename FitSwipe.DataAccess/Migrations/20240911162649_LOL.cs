using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FitSwipe.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class LOL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    FireBaseId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AvatarUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    Height = table.Column<double>(type: "float", nullable: false),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ward = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false),
                    Job = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Balance = table.Column<int>(type: "int", nullable: false),
                    PTStatus = table.Column<int>(type: "int", nullable: true),
                    PTExperienceYear = table.Column<double>(type: "float", nullable: true),
                    SubscriptionPurchasedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SubscriptionLevel = table.Column<int>(type: "int", nullable: true),
                    SubscriptionPaymentStatus = table.Column<int>(type: "int", nullable: true),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RecordStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.FireBaseId);
                });

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReporterId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TargetId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RecordStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reports_Users_ReporterId",
                        column: x => x.ReporterId,
                        principalTable: "Users",
                        principalColumn: "FireBaseId",
                        onDelete: ReferentialAction.Cascade);
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TagType = table.Column<int>(type: "int", nullable: false),
                    CreateById = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RecordStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tags_Users_CreateById",
                        column: x => x.CreateById,
                        principalTable: "Users",
                        principalColumn: "FireBaseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Trainings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TraineeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PTId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Feedback = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rating = table.Column<double>(type: "float", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RecordStatus = table.Column<int>(type: "int", nullable: false)
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
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TranscationCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Method = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    UserFireBaseId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RecordStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transactions_Users_UserFireBaseId",
                        column: x => x.UserFireBaseId,
                        principalTable: "Users",
                        principalColumn: "FireBaseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserMedias",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MediaUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RecordStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMedias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserMedias_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "FireBaseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReportImages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MediaUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReportId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RecordStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReportImages_Reports_ReportId",
                        column: x => x.ReportId,
                        principalTable: "Reports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTags",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TagId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RecordStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserTags_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MediaUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrainingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RecordStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedbackImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FeedbackImages_Trainings_TrainingId",
                        column: x => x.TrainingId,
                        principalTable: "Trainings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Slots",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrainingId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreateById = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    PaymentStatus = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: true),
                    Feedback = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RecordStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slots", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Slots_Trainings_TrainingId",
                        column: x => x.TrainingId,
                        principalTable: "Trainings",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Slots_Users_CreateById",
                        column: x => x.CreateById,
                        principalTable: "Users",
                        principalColumn: "FireBaseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "FireBaseId", "AvatarUrl", "Balance", "Bio", "City", "CreatedDate", "DateOfBirth", "DeletedDate", "District", "Email", "Gender", "Height", "Id", "Job", "PTExperienceYear", "PTStatus", "Password", "Phone", "RecordStatus", "Role", "Status", "Street", "SubscriptionLevel", "SubscriptionPaymentStatus", "SubscriptionPurchasedDate", "UpdatedDate", "UserName", "Ward", "Weight" },
                values: new object[,]
                {
                    { "123abc", "https://example.com/avatar1.jpg", 1000, "Fitness enthusiast and certified personal trainer.", "New York", new DateTime(2024, 9, 11, 23, 26, 48, 976, DateTimeKind.Local).AddTicks(477), new DateTime(1990, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Manhattan", "john.doe@example.com", 0, 180.30000000000001, new Guid("00000000-0000-0000-0000-000000000000"), "Student", null, null, "hashedpassword1", "1234567890", 0, 0, 0, "5th Avenue", null, null, null, null, "john doe", "Ward 5", 75.5 },
                    { "456def", "https://example.com/avatar2.jpg", 1500, "Yoga instructor with a passion for holistic health.", "Los Angeles", new DateTime(2024, 9, 11, 23, 26, 48, 976, DateTimeKind.Local).AddTicks(513), new DateTime(1985, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Beverly Hills", "jane.smith@example.com", 1, 170.19999999999999, new Guid("00000000-0000-0000-0000-000000000000"), "Yoga Instructor", 3.5, 1, "hashedpassword2", "0987654321", 0, 1, 0, "Rodeo Drive", 1, 0, new DateTime(2023, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "jane smith", "Ward 3", 65.0 },
                    { "789ghi", "https://example.com/avatar3.jpg", 2000, "Aspiring bodybuilder and nutrition expert.", "Chicago", new DateTime(2024, 9, 11, 23, 26, 48, 976, DateTimeKind.Local).AddTicks(531), new DateTime(1992, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lincoln Park", "alex.jones@example.com", 0, 185.40000000000001, new Guid("00000000-0000-0000-0000-000000000000"), "Nutritionist", 2.0, 0, "hashedpassword3", "5551234567", 0, 1, 0, "Clark Street", null, null, null, null, "alex jones", "Ward 7", 85.0 }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreateById", "CreatedDate", "DeletedDate", "Name", "RecordStatus", "TagType", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("24000c43-82a4-4ad0-956a-14f3ef8c2021"), "123abc", new DateTime(2024, 9, 11, 23, 26, 48, 976, DateTimeKind.Local).AddTicks(891), null, "Kiên trì", 0, 4, null },
                    { new Guid("3aac1b76-d956-48d7-9679-1635df2a060c"), "123abc", new DateTime(2024, 9, 11, 23, 26, 48, 976, DateTimeKind.Local).AddTicks(861), null, "Yoga", 0, 2, null },
                    { new Guid("3fd4b020-17b2-4cbd-8d4b-ca5ac800ac75"), "123abc", new DateTime(2024, 9, 11, 23, 26, 48, 976, DateTimeKind.Local).AddTicks(888), null, "Giá rẻ", 0, 3, null },
                    { new Guid("6d8860c6-81ff-41d8-a33f-f01befbefc8c"), "123abc", new DateTime(2024, 9, 11, 23, 26, 48, 976, DateTimeKind.Local).AddTicks(852), null, "Video game", 0, 0, null },
                    { new Guid("6f831dad-1ff3-4171-96a2-70c050fbbdc0"), "123abc", new DateTime(2024, 9, 11, 23, 26, 48, 976, DateTimeKind.Local).AddTicks(856), null, "Giảm cân", 0, 1, null },
                    { new Guid("936deede-2a98-4570-980c-79d90d198540"), "123abc", new DateTime(2024, 9, 11, 23, 26, 48, 976, DateTimeKind.Local).AddTicks(805), null, "Bóng đá", 0, 0, null },
                    { new Guid("95842055-67f6-4111-b52e-c3f02c9b220a"), "123abc", new DateTime(2024, 9, 11, 23, 26, 48, 976, DateTimeKind.Local).AddTicks(859), null, "Phát triển cơ bắp", 0, 1, null },
                    { new Guid("986462a9-d7d7-4a73-9ed1-ce336f1cf47d"), "123abc", new DateTime(2024, 9, 11, 23, 26, 48, 976, DateTimeKind.Local).AddTicks(885), null, "Ngoại hình đẹp", 0, 3, null },
                    { new Guid("9b5fe34b-6775-414e-80d7-a2c44fe11970"), "123abc", new DateTime(2024, 9, 11, 23, 26, 48, 976, DateTimeKind.Local).AddTicks(894), null, "Siêng năng", 0, 4, null },
                    { new Guid("f28f8ad1-ddee-4ccb-984c-db61bd3fa3d2"), "123abc", new DateTime(2024, 9, 11, 23, 26, 48, 976, DateTimeKind.Local).AddTicks(864), null, "Cardino", 0, 2, null }
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
                name: "FeedbackImages");

            migrationBuilder.DropTable(
                name: "ReportImages");

            migrationBuilder.DropTable(
                name: "Slots");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "UserMedias");

            migrationBuilder.DropTable(
                name: "UserTags");

            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropTable(
                name: "Trainings");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
