using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FitSwipe.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Add_Property_Descriptions_To_User_Table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("d002d6fd-beec-4d62-91b8-f7f14a2a2298"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("d353192d-2652-4cf3-9a7e-b987f3b7e39d"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("166ec7dc-d0b8-4cf4-a06f-c099a9e0ad4d"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("2bf3e0bf-de43-46c6-a926-2e550bf83681"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("346adc11-a6f3-4818-a3b0-02fb67a14ad9"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("78223ef7-771d-4fb0-894d-5ccc9d4dec29"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("79af082d-87cb-4e06-8527-55966caf2b63"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("a30ac05c-728c-4463-8505-05ae0a16dd61"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("aceced72-5d04-478a-b3b0-d5cacf85c69c"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("adf31298-684b-4a26-ad56-227cbd5a09bd"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("eb455c96-e17d-4388-9d5d-e363dd7019d1"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("f3e76667-ce2c-475a-b9eb-a8247ef9fdca"));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "EmailTemplates",
                columns: new[] { "Id", "Body", "CreatedDate", "DeletedDate", "Description", "Name", "Params", "RecordStatus", "Status", "Subject", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("6436b870-874b-4bcf-a679-e9c01c79507b"), "Chúng tôi đã nhận được yêu cầu đặt lại mật khẩu cho tài khoản của bạn tại FitWipe. Kính gửi [Name], vui lòng đặt lại mật khẩu của bạn bằng cách nhấn vào đường link sau: <a href=\"[ResetPasswordLink]\">Đặt lại mật khẩu</a>.<br><br>Nếu bạn không yêu cầu việc này, vui lòng bỏ qua email này.<br><br>Đội ngũ FitWipe", new DateTime(2024, 9, 19, 20, 34, 35, 578, DateTimeKind.Local).AddTicks(4489), null, "Email này được gửi khi người dùng yêu cầu đặt lại mật khẩu cho tài khoản FitWipe.", "Forgot_Password", "[Name], [ResetPasswordLink]", 0, true, "Yêu cầu đặt lại mật khẩu FitWipe", null },
                    { new Guid("960e2047-fb20-4b70-a84a-56f0c98719fe"), "Chào mừng bạn đến với FitWipe! Kính gửi [Name], vui lòng xác nhận địa chỉ email của bạn bằng cách nhấn vào đường link sau: <a href=\"[VerificationLink]\">Xác nhận Email</a>.<br><br>Cảm ơn bạn đã tham gia cùng chúng tôi!<br><br>Đội ngũ FitWipe", new DateTime(2024, 9, 19, 20, 34, 35, 578, DateTimeKind.Local).AddTicks(4461), null, "Email này được gửi để xác nhận đăng ký tài khoản FitWipe.", "Register_Mail", "[Name], [VerificationLink]", 0, true, "Chào mừng đến với FitWipe! Vui lòng xác nhận email của bạn", null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreateById", "CreatedDate", "DeletedDate", "Name", "RecordStatus", "TagImage", "TagType", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("19828bd0-aeb6-4b9f-82f7-9991f398731f"), "123abc", new DateTime(2024, 9, 19, 20, 34, 35, 578, DateTimeKind.Local).AddTicks(4382), null, "Phát triển cơ bắp", 0, null, 1, null },
                    { new Guid("3ba8fa6e-3cc7-463d-ac6c-a39731b7df83"), "123abc", new DateTime(2024, 9, 19, 20, 34, 35, 578, DateTimeKind.Local).AddTicks(4355), null, "Giảm cân", 0, null, 1, null },
                    { new Guid("7c2b04ff-bb23-4493-b34d-6a02a373047d"), "123abc", new DateTime(2024, 9, 19, 20, 34, 35, 578, DateTimeKind.Local).AddTicks(4393), null, "Siêng năng", 0, null, 4, null },
                    { new Guid("8344eaa5-c878-4ad5-aa62-21af57f2c29c"), "123abc", new DateTime(2024, 9, 19, 20, 34, 35, 578, DateTimeKind.Local).AddTicks(4390), null, "Giá rẻ", 0, null, 3, null },
                    { new Guid("c4035e13-8066-48f5-ae22-2c28e80dc14c"), "123abc", new DateTime(2024, 9, 19, 20, 34, 35, 578, DateTimeKind.Local).AddTicks(4350), null, "Bóng đá", 0, null, 0, null },
                    { new Guid("e3bc63bb-5051-4748-87f5-22d190500a91"), "123abc", new DateTime(2024, 9, 19, 20, 34, 35, 578, DateTimeKind.Local).AddTicks(4388), null, "Ngoại hình đẹp", 0, null, 3, null },
                    { new Guid("e5f7386c-824c-4ea7-b0cc-f50d15ff0bc0"), "123abc", new DateTime(2024, 9, 19, 20, 34, 35, 578, DateTimeKind.Local).AddTicks(4391), null, "Kiên trì", 0, null, 4, null },
                    { new Guid("eca3c307-03f7-4355-93b5-65552823cd06"), "123abc", new DateTime(2024, 9, 19, 20, 34, 35, 578, DateTimeKind.Local).AddTicks(4386), null, "Cardino", 0, null, 2, null },
                    { new Guid("f8df9800-4b47-4c94-abb8-5773e3b1aaf5"), "123abc", new DateTime(2024, 9, 19, 20, 34, 35, 578, DateTimeKind.Local).AddTicks(4384), null, "Yoga", 0, null, 2, null },
                    { new Guid("ffa72a71-1827-4b90-b0e7-1640adec28b1"), "123abc", new DateTime(2024, 9, 19, 20, 34, 35, 578, DateTimeKind.Local).AddTicks(4353), null, "Video game", 0, null, 0, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "123abc",
                columns: new[] { "CreatedDate", "Description", "Id" },
                values: new object[] { new DateTime(2024, 9, 19, 20, 34, 35, 578, DateTimeKind.Local).AddTicks(3883), null, new Guid("f422232f-0f19-4bee-99de-601bd2ec21a7") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "456def",
                columns: new[] { "CreatedDate", "Description", "Id" },
                values: new object[] { new DateTime(2024, 9, 19, 20, 34, 35, 578, DateTimeKind.Local).AddTicks(3947), null, new Guid("50854e99-ac9c-4420-b299-cb23d09a84fb") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "789ghi",
                columns: new[] { "CreatedDate", "Description", "Id" },
                values: new object[] { new DateTime(2024, 9, 19, 20, 34, 35, 578, DateTimeKind.Local).AddTicks(3957), null, new Guid("98805417-dc1d-4ad0-89b0-fcb33a5c96b4") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("6436b870-874b-4bcf-a679-e9c01c79507b"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("960e2047-fb20-4b70-a84a-56f0c98719fe"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("19828bd0-aeb6-4b9f-82f7-9991f398731f"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("3ba8fa6e-3cc7-463d-ac6c-a39731b7df83"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("7c2b04ff-bb23-4493-b34d-6a02a373047d"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("8344eaa5-c878-4ad5-aa62-21af57f2c29c"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("c4035e13-8066-48f5-ae22-2c28e80dc14c"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("e3bc63bb-5051-4748-87f5-22d190500a91"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("e5f7386c-824c-4ea7-b0cc-f50d15ff0bc0"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("eca3c307-03f7-4355-93b5-65552823cd06"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("f8df9800-4b47-4c94-abb8-5773e3b1aaf5"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("ffa72a71-1827-4b90-b0e7-1640adec28b1"));

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Users");

            migrationBuilder.InsertData(
                table: "EmailTemplates",
                columns: new[] { "Id", "Body", "CreatedDate", "DeletedDate", "Description", "Name", "Params", "RecordStatus", "Status", "Subject", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("d002d6fd-beec-4d62-91b8-f7f14a2a2298"), "Chào mừng bạn đến với FitWipe! Kính gửi [Name], vui lòng xác nhận địa chỉ email của bạn bằng cách nhấn vào đường link sau: <a href=\"[VerificationLink]\">Xác nhận Email</a>.<br><br>Cảm ơn bạn đã tham gia cùng chúng tôi!<br><br>Đội ngũ FitWipe", new DateTime(2024, 9, 19, 18, 44, 12, 476, DateTimeKind.Local).AddTicks(6292), null, "Email này được gửi để xác nhận đăng ký tài khoản FitWipe.", "Register_Mail", "[Name], [VerificationLink]", 0, true, "Chào mừng đến với FitWipe! Vui lòng xác nhận email của bạn", null },
                    { new Guid("d353192d-2652-4cf3-9a7e-b987f3b7e39d"), "Chúng tôi đã nhận được yêu cầu đặt lại mật khẩu cho tài khoản của bạn tại FitWipe. Kính gửi [Name], vui lòng đặt lại mật khẩu của bạn bằng cách nhấn vào đường link sau: <a href=\"[ResetPasswordLink]\">Đặt lại mật khẩu</a>.<br><br>Nếu bạn không yêu cầu việc này, vui lòng bỏ qua email này.<br><br>Đội ngũ FitWipe", new DateTime(2024, 9, 19, 18, 44, 12, 476, DateTimeKind.Local).AddTicks(6336), null, "Email này được gửi khi người dùng yêu cầu đặt lại mật khẩu cho tài khoản FitWipe.", "Forgot_Password", "[Name], [ResetPasswordLink]", 0, true, "Yêu cầu đặt lại mật khẩu FitWipe", null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreateById", "CreatedDate", "DeletedDate", "Name", "RecordStatus", "TagImage", "TagType", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("166ec7dc-d0b8-4cf4-a06f-c099a9e0ad4d"), "123abc", new DateTime(2024, 9, 19, 18, 44, 12, 476, DateTimeKind.Local).AddTicks(6149), null, "Yoga", 0, null, 2, null },
                    { new Guid("2bf3e0bf-de43-46c6-a926-2e550bf83681"), "123abc", new DateTime(2024, 9, 19, 18, 44, 12, 476, DateTimeKind.Local).AddTicks(6151), null, "Cardino", 0, null, 2, null },
                    { new Guid("346adc11-a6f3-4818-a3b0-02fb67a14ad9"), "123abc", new DateTime(2024, 9, 19, 18, 44, 12, 476, DateTimeKind.Local).AddTicks(6136), null, "Bóng đá", 0, null, 0, null },
                    { new Guid("78223ef7-771d-4fb0-894d-5ccc9d4dec29"), "123abc", new DateTime(2024, 9, 19, 18, 44, 12, 476, DateTimeKind.Local).AddTicks(6148), null, "Phát triển cơ bắp", 0, null, 1, null },
                    { new Guid("79af082d-87cb-4e06-8527-55966caf2b63"), "123abc", new DateTime(2024, 9, 19, 18, 44, 12, 476, DateTimeKind.Local).AddTicks(6157), null, "Kiên trì", 0, null, 4, null },
                    { new Guid("a30ac05c-728c-4463-8505-05ae0a16dd61"), "123abc", new DateTime(2024, 9, 19, 18, 44, 12, 476, DateTimeKind.Local).AddTicks(6155), null, "Giá rẻ", 0, null, 3, null },
                    { new Guid("aceced72-5d04-478a-b3b0-d5cacf85c69c"), "123abc", new DateTime(2024, 9, 19, 18, 44, 12, 476, DateTimeKind.Local).AddTicks(6158), null, "Siêng năng", 0, null, 4, null },
                    { new Guid("adf31298-684b-4a26-ad56-227cbd5a09bd"), "123abc", new DateTime(2024, 9, 19, 18, 44, 12, 476, DateTimeKind.Local).AddTicks(6146), null, "Giảm cân", 0, null, 1, null },
                    { new Guid("eb455c96-e17d-4388-9d5d-e363dd7019d1"), "123abc", new DateTime(2024, 9, 19, 18, 44, 12, 476, DateTimeKind.Local).AddTicks(6154), null, "Ngoại hình đẹp", 0, null, 3, null },
                    { new Guid("f3e76667-ce2c-475a-b9eb-a8247ef9fdca"), "123abc", new DateTime(2024, 9, 19, 18, 44, 12, 476, DateTimeKind.Local).AddTicks(6144), null, "Video game", 0, null, 0, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "123abc",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 9, 19, 18, 44, 12, 476, DateTimeKind.Local).AddTicks(5613), new Guid("e05cab2b-839c-4d4f-92d5-2b700e3a28d1") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "456def",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 9, 19, 18, 44, 12, 476, DateTimeKind.Local).AddTicks(5735), new Guid("edf44f9a-815b-4d04-a11d-d8c68f3b1139") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "789ghi",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 9, 19, 18, 44, 12, 476, DateTimeKind.Local).AddTicks(5746), new Guid("676428d9-c4dc-40b5-b04e-31b0af64b5ab") });
        }
    }
}
