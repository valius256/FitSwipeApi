using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FitSwipe.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tag",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TagType = table.Column<int>(type: "int", nullable: false),
                    CreateById = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RecordStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tag", x => x.Id);
                });

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
                name: "UserTag",
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
                    table.PrimaryKey("PK_UserTag", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserTag_Tag_TagId",
                        column: x => x.TagId,
                        principalTable: "Tag",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserTag_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "FireBaseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Tag",
                columns: new[] { "Id", "CreateById", "CreatedDate", "DeletedDate", "Name", "RecordStatus", "TagType", "UpdatedDate" },
                values: new object[] { new Guid("3f27c7ae-4554-4775-8f3a-75353d84d150"), "123abc", new DateTime(2024, 9, 7, 22, 8, 27, 573, DateTimeKind.Local).AddTicks(2491), null, "Bóng đá", 0, 0, null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "FireBaseId", "AvatarUrl", "Balance", "Bio", "City", "CreatedDate", "DateOfBirth", "DeletedDate", "District", "Email", "Gender", "Height", "Id", "Job", "PTExperienceYear", "PTStatus", "Password", "Phone", "RecordStatus", "Role", "Status", "Street", "SubscriptionLevel", "SubscriptionPaymentStatus", "SubscriptionPurchasedDate", "UpdatedDate", "UserName", "Ward", "Weight" },
                values: new object[,]
                {
                    { "123abc", "https://example.com/avatar1.jpg", 1000, "Fitness enthusiast and certified personal trainer.", "New York", new DateTime(2024, 9, 7, 22, 8, 27, 573, DateTimeKind.Local).AddTicks(2172), new DateTime(1990, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Manhattan", "john.doe@example.com", 0, 180.30000000000001, new Guid("00000000-0000-0000-0000-000000000000"), "Student", null, null, "hashedpassword1", "1234567890", 0, 0, 0, "5th Avenue", null, null, null, null, "john doe", "Ward 5", 75.5 },
                    { "456def", "https://example.com/avatar2.jpg", 1500, "Yoga instructor with a passion for holistic health.", "Los Angeles", new DateTime(2024, 9, 7, 22, 8, 27, 573, DateTimeKind.Local).AddTicks(2211), new DateTime(1985, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Beverly Hills", "jane.smith@example.com", 1, 170.19999999999999, new Guid("00000000-0000-0000-0000-000000000000"), "Yoga Instructor", 3.5, 1, "hashedpassword2", "0987654321", 0, 1, 0, "Rodeo Drive", 1, 0, new DateTime(2023, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "jane smith", "Ward 3", 65.0 },
                    { "789ghi", "https://example.com/avatar3.jpg", 2000, "Aspiring bodybuilder and nutrition expert.", "Chicago", new DateTime(2024, 9, 7, 22, 8, 27, 573, DateTimeKind.Local).AddTicks(2231), new DateTime(1992, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lincoln Park", "alex.jones@example.com", 0, 185.40000000000001, new Guid("00000000-0000-0000-0000-000000000000"), "Nutritionist", 2.0, 0, "hashedpassword3", "5551234567", 0, 1, 0, "Clark Street", null, null, null, null, "alex jones", "Ward 7", 85.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserTag_TagId",
                table: "UserTag",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTag_UserId",
                table: "UserTag",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserTag");

            migrationBuilder.DropTable(
                name: "Tag");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
