using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FitSwipe.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Update_User_Property : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("99d45996-f979-4661-91b0-1849cd9326e2"));

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

            migrationBuilder.AlterColumn<double>(
                name: "Weight",
                table: "Users",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "Ward",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Street",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Users",
                type: "varchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Job",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<double>(
                name: "Height",
                table: "Users",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "District",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Balance",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "AvatarUrl",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "EmailTemplates",
                columns: new[] { "Id", "Body", "CreatedDate", "DeletedDate", "Description", "Name", "Params", "RecordStatus", "Status", "Subject", "UpdatedDate" },
                values: new object[] { new Guid("37ffcb4b-e151-4841-a6b3-9cd8d0e0d8ac"), "Chào mừng bạn đến với FitWipe! Kính gửi [Name], vui lòng xác nhận địa chỉ email của bạn bằng cách nhấn vào đường link sau: <a href=\"[VerificationLink]\">Xác nhận Email</a>.<br><br>Cảm ơn bạn đã tham gia cùng chúng tôi!<br><br>Đội ngũ FitWipe", new DateTime(2024, 9, 13, 11, 0, 14, 798, DateTimeKind.Local).AddTicks(4017), null, "Email này được gửi để xác nhận đăng ký tài khoản FitWipe.", "Register_Mail", "[Name], [VerificationLink]", 0, true, "Chào mừng đến với FitWipe! Vui lòng xác nhận email của bạn", null });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreateById", "CreatedDate", "DeletedDate", "Name", "RecordStatus", "TagType", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("01e60536-8f6d-4e51-9121-c2fb51046174"), "123abc", new DateTime(2024, 9, 13, 11, 0, 14, 798, DateTimeKind.Local).AddTicks(3981), null, "Giá rẻ", 0, 3, null },
                    { new Guid("4dc8625b-6c11-4169-8898-d6e4f07b6ea9"), "123abc", new DateTime(2024, 9, 13, 11, 0, 14, 798, DateTimeKind.Local).AddTicks(3921), null, "Bóng đá", 0, 0, null },
                    { new Guid("5c1f6d7d-ffac-4cfe-9672-67480f7cb0e2"), "123abc", new DateTime(2024, 9, 13, 11, 0, 14, 798, DateTimeKind.Local).AddTicks(3956), null, "Phát triển cơ bắp", 0, 1, null },
                    { new Guid("63a41480-88d6-4cbb-84df-29a358098135"), "123abc", new DateTime(2024, 9, 13, 11, 0, 14, 798, DateTimeKind.Local).AddTicks(3958), null, "Yoga", 0, 2, null },
                    { new Guid("7e6e1be0-41dd-41e4-9558-aa04d94336f1"), "123abc", new DateTime(2024, 9, 13, 11, 0, 14, 798, DateTimeKind.Local).AddTicks(3961), null, "Ngoại hình đẹp", 0, 3, null },
                    { new Guid("980142da-b60f-47b7-9600-2239f8a2cd61"), "123abc", new DateTime(2024, 9, 13, 11, 0, 14, 798, DateTimeKind.Local).AddTicks(3983), null, "Kiên trì", 0, 4, null },
                    { new Guid("9c25e1e5-83b5-45bb-9d5c-a7c40531223a"), "123abc", new DateTime(2024, 9, 13, 11, 0, 14, 798, DateTimeKind.Local).AddTicks(3985), null, "Siêng năng", 0, 4, null },
                    { new Guid("af5a3c23-7389-4716-a6c3-ffb182374f28"), "123abc", new DateTime(2024, 9, 13, 11, 0, 14, 798, DateTimeKind.Local).AddTicks(3959), null, "Cardino", 0, 2, null },
                    { new Guid("dcf1b292-c36d-48cb-9a90-7a77dc349a5e"), "123abc", new DateTime(2024, 9, 13, 11, 0, 14, 798, DateTimeKind.Local).AddTicks(3954), null, "Giảm cân", 0, 1, null },
                    { new Guid("dd2cdbb9-6f37-4808-aca0-92451530e993"), "123abc", new DateTime(2024, 9, 13, 11, 0, 14, 798, DateTimeKind.Local).AddTicks(3952), null, "Video game", 0, 0, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "123abc",
                column: "CreatedDate",
                value: new DateTime(2024, 9, 13, 11, 0, 14, 798, DateTimeKind.Local).AddTicks(3560));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "456def",
                column: "CreatedDate",
                value: new DateTime(2024, 9, 13, 11, 0, 14, 798, DateTimeKind.Local).AddTicks(3582));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "789ghi",
                column: "CreatedDate",
                value: new DateTime(2024, 9, 13, 11, 0, 14, 798, DateTimeKind.Local).AddTicks(3591));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("37ffcb4b-e151-4841-a6b3-9cd8d0e0d8ac"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("01e60536-8f6d-4e51-9121-c2fb51046174"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("4dc8625b-6c11-4169-8898-d6e4f07b6ea9"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("5c1f6d7d-ffac-4cfe-9672-67480f7cb0e2"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("63a41480-88d6-4cbb-84df-29a358098135"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("7e6e1be0-41dd-41e4-9558-aa04d94336f1"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("980142da-b60f-47b7-9600-2239f8a2cd61"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("9c25e1e5-83b5-45bb-9d5c-a7c40531223a"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("af5a3c23-7389-4716-a6c3-ffb182374f28"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("dcf1b292-c36d-48cb-9a90-7a77dc349a5e"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("dd2cdbb9-6f37-4808-aca0-92451530e993"));

            migrationBuilder.AlterColumn<double>(
                name: "Weight",
                table: "Users",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ward",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Street",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Job",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Height",
                table: "Users",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "District",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Balance",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AvatarUrl",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
    }
}
