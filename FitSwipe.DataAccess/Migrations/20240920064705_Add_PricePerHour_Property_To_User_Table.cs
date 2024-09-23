using System;
using FitSwipe.DataAccess.Model.Entity;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FitSwipe.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Add_PricePerHour_Property_To_User_Table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("628dde66-cba3-4a21-9972-24c587d3a148"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("c5a547e0-8f6e-4073-9eb2-726586d72b96"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("066157a2-de43-4ef0-aed3-56f7fed93d71"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("0cc4b849-1109-4ae1-815b-6780a82d86f1"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("132d0446-4f76-4c12-af3c-77ca81539a49"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("38839592-592c-4992-9f57-6aed89340235"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("7a4a2b73-afb8-4f0a-92ff-fe4c048f2e15"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("b14121be-19df-4f1f-9e0f-cdb0d0d25f24"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("b177d97d-556b-4fef-b08c-fe2a21af274a"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("bf09e679-6890-4268-9623-192ec73ca9b0"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("e8e47835-ed8d-49db-940c-2c3f4c7eabdc"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("fc5f8c17-6b94-47bb-9de5-58faf238f6f3"));

            migrationBuilder.InsertData(
                table: "EmailTemplates",
                columns: new[] { "Id", "Body", "CreatedDate", "DeletedDate", "Description", "Name", "Params", "RecordStatus", "Status", "Subject", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("af88cc24-2edf-4d62-8be7-64c7845a7c83"), "Chào mừng bạn đến với FitWipe! Kính gửi [Name], vui lòng xác nhận địa chỉ email của bạn bằng cách nhấn vào đường link sau: <a href=\"[VerificationLink]\">Xác nhận Email</a>.<br><br>Cảm ơn bạn đã tham gia cùng chúng tôi!<br><br>Đội ngũ FitWipe", new DateTime(2024, 9, 20, 13, 47, 4, 575, DateTimeKind.Local).AddTicks(129), null, "Email này được gửi để xác nhận đăng ký tài khoản FitWipe.", "Register_Mail", "[Name], [VerificationLink]", 0, true, "Chào mừng đến với FitWipe! Vui lòng xác nhận email của bạn", null },
                    { new Guid("e651b2b4-7213-4820-9b20-0c92f9e59cb7"), "Chúng tôi đã nhận được yêu cầu đặt lại mật khẩu cho tài khoản của bạn tại FitWipe. Kính gửi [Name], vui lòng đặt lại mật khẩu của bạn bằng cách nhấn vào đường link sau: <a href=\"[ResetPasswordLink]\">Đặt lại mật khẩu</a>.<br><br>Nếu bạn không yêu cầu việc này, vui lòng bỏ qua email này.<br><br>Đội ngũ FitWipe", new DateTime(2024, 9, 20, 13, 47, 4, 575, DateTimeKind.Local).AddTicks(155), null, "Email này được gửi khi người dùng yêu cầu đặt lại mật khẩu cho tài khoản FitWipe.", "Forgot_Password", "[Name], [ResetPasswordLink]", 0, true, "Yêu cầu đặt lại mật khẩu FitWipe", null }
                });
            
            
            migrationBuilder.AddColumn<decimal>(
                name: "PricePerHour",
                table: "Users",
                type: "decimal(10, 2)",
                defaultValue: 0m
                );


            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[]
                {
                    "Id", "CreateById", "CreatedDate", "DeletedDate", "Name", "RecordStatus", "TagImage", "TagType",
                    "UpdatedDate"
                },
                values: new object[,]
                {
                    {
                        new Guid("04cedcf8-4a8b-47a0-b8cd-5700deb60cb8"), "123abc",
                        new DateTime(2024, 9, 20, 13, 47, 4, 575, DateTimeKind.Local).AddTicks(95), null, "Kiên trì", 0,
                        null, 4, null
                    },
                    {
                        new Guid("2195e62a-e67c-4773-a557-f355c32d171a"), "123abc",
                        new DateTime(2024, 9, 20, 13, 47, 4, 575, DateTimeKind.Local).AddTicks(97), null, "Siêng năng",
                        0, null, 4, null
                    },
                    {
                        new Guid("34853b0b-ac13-46c9-9a0f-447a2957bf31"), "123abc",
                        new DateTime(2024, 9, 20, 13, 47, 4, 575, DateTimeKind.Local).AddTicks(63), null, "Bóng đá", 0,
                        null, 0, null
                    },
                    {
                        new Guid("3f15fe50-e20c-44f1-8783-4a549ddd0eb6"), "123abc",
                        new DateTime(2024, 9, 20, 13, 47, 4, 575, DateTimeKind.Local).AddTicks(86), null,
                        "Phát triển cơ bắp", 0, null, 1, null
                    },
                    {
                        new Guid("47a3ffdb-485b-4481-86f5-8585fe1fe0b3"), "123abc",
                        new DateTime(2024, 9, 20, 13, 47, 4, 575, DateTimeKind.Local).AddTicks(94), null, "Giá rẻ", 0,
                        null, 3, null
                    },
                    {
                        new Guid("4874d5ca-3b73-4a6a-8656-8b336add3a42"), "123abc",
                        new DateTime(2024, 9, 20, 13, 47, 4, 575, DateTimeKind.Local).AddTicks(92), null,
                        "Ngoại hình đẹp", 0, null, 3, null
                    },
                    {
                        new Guid("4aaebacb-8153-46f5-bd8a-be4d2352b55f"), "123abc",
                        new DateTime(2024, 9, 20, 13, 47, 4, 575, DateTimeKind.Local).AddTicks(65), null, "Video game",
                        0, null, 0, null
                    },
                    {
                        new Guid("56d8a7bb-0a16-4257-aaea-84acaea64456"), "123abc",
                        new DateTime(2024, 9, 20, 13, 47, 4, 575, DateTimeKind.Local).AddTicks(88), null, "Yoga", 0,
                        null, 2, null
                    },
                    {
                        new Guid("e1d1c48f-de02-4e33-93f7-c66683c69773"), "123abc",
                        new DateTime(2024, 9, 20, 13, 47, 4, 575, DateTimeKind.Local).AddTicks(90), null, "Cardino", 0,
                        null, 2, null
                    },
                    {
                        new Guid("f27fef6b-faf0-413a-9be8-0bd7c4b7ab60"), "123abc",
                        new DateTime(2024, 9, 20, 13, 47, 4, 575, DateTimeKind.Local).AddTicks(67), null, "Giảm cân", 0,
                        null, 1, null
                    }
                });
            
            
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "123abc",
                columns: new[] { "CreatedDate", "Id", "PricePerHour" },
                values: new object[] { new DateTime(2024, 9, 20, 13, 47, 4, 574, DateTimeKind.Local).AddTicks(9633), new Guid("a4e79704-41c2-4e13-9831-fa4413159ade"), 0.00 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "456def",
                columns: new[] { "CreatedDate", "Id", "PricePerHour"  },
                values: new object[] { new DateTime(2024, 9, 20, 13, 47, 4, 574, DateTimeKind.Local).AddTicks(9678), new Guid("b2489e1d-9421-4a0e-b273-bb0837262728"), 100000.00 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "789ghi",
                columns: new[] { "CreatedDate", "Id",  "PricePerHour" },
                values: new object[] { new DateTime(2024, 9, 20, 13, 47, 4, 574, DateTimeKind.Local).AddTicks(9721), new Guid("f2367743-2f93-4af4-ba04-f521d6588839"),1500000.00 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("af88cc24-2edf-4d62-8be7-64c7845a7c83"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("e651b2b4-7213-4820-9b20-0c92f9e59cb7"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("04cedcf8-4a8b-47a0-b8cd-5700deb60cb8"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("2195e62a-e67c-4773-a557-f355c32d171a"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("34853b0b-ac13-46c9-9a0f-447a2957bf31"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("3f15fe50-e20c-44f1-8783-4a549ddd0eb6"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("47a3ffdb-485b-4481-86f5-8585fe1fe0b3"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("4874d5ca-3b73-4a6a-8656-8b336add3a42"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("4aaebacb-8153-46f5-bd8a-be4d2352b55f"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("56d8a7bb-0a16-4257-aaea-84acaea64456"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("e1d1c48f-de02-4e33-93f7-c66683c69773"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("f27fef6b-faf0-413a-9be8-0bd7c4b7ab60"));

            migrationBuilder.InsertData(
                table: "EmailTemplates",
                columns: new[] { "Id", "Body", "CreatedDate", "DeletedDate", "Description", "Name", "Params", "RecordStatus", "Status", "Subject", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("628dde66-cba3-4a21-9972-24c587d3a148"), "Chào mừng bạn đến với FitWipe! Kính gửi [Name], vui lòng xác nhận địa chỉ email của bạn bằng cách nhấn vào đường link sau: <a href=\"[VerificationLink]\">Xác nhận Email</a>.<br><br>Cảm ơn bạn đã tham gia cùng chúng tôi!<br><br>Đội ngũ FitWipe", new DateTime(2024, 9, 20, 13, 40, 11, 436, DateTimeKind.Local).AddTicks(1989), null, "Email này được gửi để xác nhận đăng ký tài khoản FitWipe.", "Register_Mail", "[Name], [VerificationLink]", 0, true, "Chào mừng đến với FitWipe! Vui lòng xác nhận email của bạn", null },
                    { new Guid("c5a547e0-8f6e-4073-9eb2-726586d72b96"), "Chúng tôi đã nhận được yêu cầu đặt lại mật khẩu cho tài khoản của bạn tại FitWipe. Kính gửi [Name], vui lòng đặt lại mật khẩu của bạn bằng cách nhấn vào đường link sau: <a href=\"[ResetPasswordLink]\">Đặt lại mật khẩu</a>.<br><br>Nếu bạn không yêu cầu việc này, vui lòng bỏ qua email này.<br><br>Đội ngũ FitWipe", new DateTime(2024, 9, 20, 13, 40, 11, 436, DateTimeKind.Local).AddTicks(2009), null, "Email này được gửi khi người dùng yêu cầu đặt lại mật khẩu cho tài khoản FitWipe.", "Forgot_Password", "[Name], [ResetPasswordLink]", 0, true, "Yêu cầu đặt lại mật khẩu FitWipe", null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreateById", "CreatedDate", "DeletedDate", "Name", "RecordStatus", "TagImage", "TagType", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("066157a2-de43-4ef0-aed3-56f7fed93d71"), "123abc", new DateTime(2024, 9, 20, 13, 40, 11, 436, DateTimeKind.Local).AddTicks(1952), null, "Ngoại hình đẹp", 0, null, 3, null },
                    { new Guid("0cc4b849-1109-4ae1-815b-6780a82d86f1"), "123abc", new DateTime(2024, 9, 20, 13, 40, 11, 436, DateTimeKind.Local).AddTicks(1960), null, "Siêng năng", 0, null, 4, null },
                    { new Guid("132d0446-4f76-4c12-af3c-77ca81539a49"), "123abc", new DateTime(2024, 9, 20, 13, 40, 11, 436, DateTimeKind.Local).AddTicks(1956), null, "Kiên trì", 0, null, 4, null },
                    { new Guid("38839592-592c-4992-9f57-6aed89340235"), "123abc", new DateTime(2024, 9, 20, 13, 40, 11, 436, DateTimeKind.Local).AddTicks(1945), null, "Giảm cân", 0, null, 1, null },
                    { new Guid("7a4a2b73-afb8-4f0a-92ff-fe4c048f2e15"), "123abc", new DateTime(2024, 9, 20, 13, 40, 11, 436, DateTimeKind.Local).AddTicks(1943), null, "Video game", 0, null, 0, null },
                    { new Guid("b14121be-19df-4f1f-9e0f-cdb0d0d25f24"), "123abc", new DateTime(2024, 9, 20, 13, 40, 11, 436, DateTimeKind.Local).AddTicks(1954), null, "Giá rẻ", 0, null, 3, null },
                    { new Guid("b177d97d-556b-4fef-b08c-fe2a21af274a"), "123abc", new DateTime(2024, 9, 20, 13, 40, 11, 436, DateTimeKind.Local).AddTicks(1925), null, "Bóng đá", 0, null, 0, null },
                    { new Guid("bf09e679-6890-4268-9623-192ec73ca9b0"), "123abc", new DateTime(2024, 9, 20, 13, 40, 11, 436, DateTimeKind.Local).AddTicks(1950), null, "Cardino", 0, null, 2, null },
                    { new Guid("e8e47835-ed8d-49db-940c-2c3f4c7eabdc"), "123abc", new DateTime(2024, 9, 20, 13, 40, 11, 436, DateTimeKind.Local).AddTicks(1947), null, "Phát triển cơ bắp", 0, null, 1, null },
                    { new Guid("fc5f8c17-6b94-47bb-9de5-58faf238f6f3"), "123abc", new DateTime(2024, 9, 20, 13, 40, 11, 436, DateTimeKind.Local).AddTicks(1948), null, "Yoga", 0, null, 2, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "123abc",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 9, 20, 13, 40, 11, 436, DateTimeKind.Local).AddTicks(1580), new Guid("caa1117e-ee27-46ad-ac75-d0e4b8b2dd6e") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "456def",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 9, 20, 13, 40, 11, 436, DateTimeKind.Local).AddTicks(1632), new Guid("177648f2-912b-424d-99f1-7f719f81f20b") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "789ghi",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 9, 20, 13, 40, 11, 436, DateTimeKind.Local).AddTicks(1643), new Guid("62751167-1b64-4cf4-a074-2e02909b667d") });
        }
    }
}
