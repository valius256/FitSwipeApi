using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FitSwipe.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addemailtype : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("24000c43-82a4-4ad0-956a-14f3ef8c2021"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("3aac1b76-d956-48d7-9679-1635df2a060c"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("3fd4b020-17b2-4cbd-8d4b-ca5ac800ac75"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("6d8860c6-81ff-41d8-a33f-f01befbefc8c"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("6f831dad-1ff3-4171-96a2-70c050fbbdc0"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("936deede-2a98-4570-980c-79d90d198540"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("95842055-67f6-4111-b52e-c3f02c9b220a"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("986462a9-d7d7-4a73-9ed1-ce336f1cf47d"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("9b5fe34b-6775-414e-80d7-a2c44fe11970"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("f28f8ad1-ddee-4ccb-984c-db61bd3fa3d2"));

            migrationBuilder.CreateTable(
                name: "EmailTemplates",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Params = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RecordStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailTemplates", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "EmailTemplates",
                columns: new[] { "Id", "Body", "CreatedDate", "DeletedDate", "Description", "Name", "Params", "RecordStatus", "Status", "Subject", "UpdatedDate" },
                values: new object[] { new Guid("99d45996-f979-4661-91b0-1849cd9326e2"), "Chào mừng bạn đến với FitWipe! Kính gửi [Name], vui lòng xác nhận địa chỉ email của bạn bằng cách nhấn vào đường link sau: <a href=\"[VerificationLink]\">Xác nhận Email</a>.<br><br>Cảm ơn bạn đã tham gia cùng chúng tôi!<br><br>Đội ngũ FitWipe", new DateTime(2024, 9, 13, 9, 40, 16, 207, DateTimeKind.Local).AddTicks(1894), null, "Email này được gửi để xác nhận đăng ký tài khoản FitWipe.", "Register_Mail", "[Name], [VerificationLink]", 0, true, "Chào mừng đến với FitWipe! Vui lòng xác nhận email của bạn", null });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreateById", "CreatedDate", "DeletedDate", "Name", "RecordStatus", "TagType", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("1d40e227-34fe-49ae-bf3d-f760f4587671"), "123abc", new DateTime(2024, 9, 13, 9, 40, 16, 207, DateTimeKind.Local).AddTicks(1730), null, "Cardino", 0, 2, null },
                    { new Guid("24e3fbd0-c566-4003-8693-6b53a26c5b44"), "123abc", new DateTime(2024, 9, 13, 9, 40, 16, 207, DateTimeKind.Local).AddTicks(1769), null, "Siêng năng", 0, 4, null },
                    { new Guid("37746ec9-77e7-4f23-8581-82dc8a39a53e"), "123abc", new DateTime(2024, 9, 13, 9, 40, 16, 207, DateTimeKind.Local).AddTicks(1163), null, "Bóng đá", 0, 0, null },
                    { new Guid("54c1fe87-454c-4079-88bb-77112eadfee2"), "123abc", new DateTime(2024, 9, 13, 9, 40, 16, 207, DateTimeKind.Local).AddTicks(1728), null, "Yoga", 0, 2, null },
                    { new Guid("69c05d09-c421-48c0-bc8c-535d8b882507"), "123abc", new DateTime(2024, 9, 13, 9, 40, 16, 207, DateTimeKind.Local).AddTicks(1726), null, "Phát triển cơ bắp", 0, 1, null },
                    { new Guid("835e2424-87ff-4ce9-9786-a85a83f89e67"), "123abc", new DateTime(2024, 9, 13, 9, 40, 16, 207, DateTimeKind.Local).AddTicks(1767), null, "Kiên trì", 0, 4, null },
                    { new Guid("b69568f1-4554-45b6-a8d1-4cffa337a47e"), "123abc", new DateTime(2024, 9, 13, 9, 40, 16, 207, DateTimeKind.Local).AddTicks(1724), null, "Giảm cân", 0, 1, null },
                    { new Guid("bb082e23-fc4f-4155-8708-9c031e2aaf46"), "123abc", new DateTime(2024, 9, 13, 9, 40, 16, 207, DateTimeKind.Local).AddTicks(1764), null, "Giá rẻ", 0, 3, null },
                    { new Guid("c73e2bb5-118c-42f7-be86-4375b925db72"), "123abc", new DateTime(2024, 9, 13, 9, 40, 16, 207, DateTimeKind.Local).AddTicks(1733), null, "Ngoại hình đẹp", 0, 3, null },
                    { new Guid("e8bb5ea5-bcc2-47a2-ab2f-67019f17fc57"), "123abc", new DateTime(2024, 9, 13, 9, 40, 16, 207, DateTimeKind.Local).AddTicks(1714), null, "Video game", 0, 0, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "123abc",
                column: "CreatedDate",
                value: new DateTime(2024, 9, 13, 9, 40, 16, 206, DateTimeKind.Local).AddTicks(9685));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "456def",
                column: "CreatedDate",
                value: new DateTime(2024, 9, 13, 9, 40, 16, 206, DateTimeKind.Local).AddTicks(9713));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "789ghi",
                column: "CreatedDate",
                value: new DateTime(2024, 9, 13, 9, 40, 16, 206, DateTimeKind.Local).AddTicks(9729));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmailTemplates");

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("1d40e227-34fe-49ae-bf3d-f760f4587671"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("24e3fbd0-c566-4003-8693-6b53a26c5b44"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("37746ec9-77e7-4f23-8581-82dc8a39a53e"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("54c1fe87-454c-4079-88bb-77112eadfee2"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("69c05d09-c421-48c0-bc8c-535d8b882507"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("835e2424-87ff-4ce9-9786-a85a83f89e67"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("b69568f1-4554-45b6-a8d1-4cffa337a47e"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("bb082e23-fc4f-4155-8708-9c031e2aaf46"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("c73e2bb5-118c-42f7-be86-4375b925db72"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("e8bb5ea5-bcc2-47a2-ab2f-67019f17fc57"));

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

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "123abc",
                column: "CreatedDate",
                value: new DateTime(2024, 9, 11, 23, 26, 48, 976, DateTimeKind.Local).AddTicks(477));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "456def",
                column: "CreatedDate",
                value: new DateTime(2024, 9, 11, 23, 26, 48, 976, DateTimeKind.Local).AddTicks(513));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "789ghi",
                column: "CreatedDate",
                value: new DateTime(2024, 9, 11, 23, 26, 48, 976, DateTimeKind.Local).AddTicks(531));
        }
    }
}
