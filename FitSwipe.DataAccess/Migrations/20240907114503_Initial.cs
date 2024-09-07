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
                    FavoriteSport = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RecordStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.FireBaseId);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "FireBaseId", "AvatarUrl", "Bio", "CreatedDate", "DateOfBirth", "DeletedDate", "Email", "FavoriteSport", "Gender", "Height", "Id", "Password", "Phone", "RecordStatus", "UpdatedDate", "UserName", "Weight" },
                values: new object[,]
                {
                    { "uid1", "https://example.com/avatar1.png", "Fitness enthusiast", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "johndoe@example.com", "[0,6]", 0, 180.19999999999999, new Guid("00000000-0000-0000-0000-000000000000"), "hashedpassword1", "1234567890", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "johndoe", 80.5 },
                    { "uid2", "https://example.com/avatar2.png", "Yoga lover", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "janesmith@example.com", "[2,3]", 1, 165.69999999999999, new Guid("00000000-0000-0000-0000-000000000000"), "hashedpassword2", "0987654321", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "janesmith", 60.299999999999997 },
                    { "uid3", "https://example.com/avatar3.png", "Crossfit and cycling fanatic", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "roberthill@example.com", "[5,7]", 0, 175.30000000000001, new Guid("00000000-0000-0000-0000-000000000000"), "hashedpassword3", "1122334455", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "roberthill", 75.0 },
                    { "uid4", "https://example.com/avatar4.png", "Dancer and fitness lover", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "sarahlee@example.com", "[4,1]", 1, 160.80000000000001, new Guid("00000000-0000-0000-0000-000000000000"), "hashedpassword4", "5544332211", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "sarahlee", 58.200000000000003 },
                    { "uid5", "https://example.com/avatar5.png", "Climbing and hiking lover", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "michaelgreen@example.com", "[9,10]", 0, 185.5, new Guid("00000000-0000-0000-0000-000000000000"), "hashedpassword5", "6677889900", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "michaelgreen", 85.700000000000003 },
                    { "uid6", "https://example.com/avatar6.png", "Pilates and yoga enthusiast", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "emilybrown@example.com", "[3,2]", 1, 170.0, new Guid("00000000-0000-0000-0000-000000000000"), "hashedpassword6", "1029384756", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "emilybrown", 63.0 },
                    { "uid7", "https://example.com/avatar7.png", "Swimming and crossfit lover", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "davidjohnson@example.com", "[8,5]", 0, 182.5, new Guid("00000000-0000-0000-0000-000000000000"), "hashedpassword7", "3344556677", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "davidjohnson", 90.299999999999997 },
                    { "uid8", "https://example.com/avatar8.png", "Yoga and running lover", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "oliviabaker@example.com", "[2,6]", 1, 162.30000000000001, new Guid("00000000-0000-0000-0000-000000000000"), "hashedpassword8", "4455667788", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "oliviabaker", 59.399999999999999 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
