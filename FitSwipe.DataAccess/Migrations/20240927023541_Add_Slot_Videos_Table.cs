using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FitSwipe.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Add_Slot_Videos_Table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SlotVideos_Slots_SlotId",
                table: "SlotVideos");

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("6a9f3507-a330-482d-9b63-3154d00c1d43"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("9c56c3bc-b40c-4e1f-a36d-6d51ae4f443f"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("1d8f4a6d-a72f-4471-885f-2ebba7aca4c4"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("20c0081c-a9fb-49ff-94ab-3921f06b7d6d"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("2455bada-77ab-4193-bfc5-43b24cac3e43"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("299adece-8f54-4558-8a0a-934bda8db592"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("4c72490a-815a-47d9-99bd-b97e97bd6741"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("8c236bbd-d4b3-4249-b08b-5deb1c29ab9e"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("8ea08891-ad11-4e7f-99a6-3f02eff83b7d"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("9689fa27-d287-4bf4-bd78-734a36152b18"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("9a510e65-3c75-4917-85ca-95802b71abc8"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("a969c1d2-d00b-48d5-8daf-915ee4a1a23d"));

            migrationBuilder.InsertData(
                table: "EmailTemplates",
                columns: new[] { "Id", "Body", "CreatedDate", "DeletedDate", "Description", "Name", "Params", "RecordStatus", "Status", "Subject", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0422300c-6fc0-437f-8b65-e5921f03ba65"), "Chúng tôi đã nhận được yêu cầu đặt lại mật khẩu cho tài khoản của bạn tại FitWipe. Kính gửi [Name], vui lòng đặt lại mật khẩu của bạn bằng cách nhấn vào đường link sau: <a href=\"[ResetPasswordLink]\">Đặt lại mật khẩu</a>.<br><br>Nếu bạn không yêu cầu việc này, vui lòng bỏ qua email này.<br><br>Đội ngũ FitWipe", new DateTime(2024, 9, 27, 9, 35, 40, 326, DateTimeKind.Local).AddTicks(5760), null, "Email này được gửi khi người dùng yêu cầu đặt lại mật khẩu cho tài khoản FitWipe.", "Forgot_Password", "[Name], [ResetPasswordLink]", 0, true, "Yêu cầu đặt lại mật khẩu FitWipe", null },
                    { new Guid("3fa1e03a-fa7e-42f4-b851-a51e18def90b"), "Chào mừng bạn đến với FitWipe! Kính gửi [Name], vui lòng xác nhận địa chỉ email của bạn bằng cách nhấn vào đường link sau: <a href=\"[VerificationLink]\">Xác nhận Email</a>.<br><br>Cảm ơn bạn đã tham gia cùng chúng tôi!<br><br>Đội ngũ FitWipe", new DateTime(2024, 9, 27, 9, 35, 40, 326, DateTimeKind.Local).AddTicks(5622), null, "Email này được gửi để xác nhận đăng ký tài khoản FitWipe.", "Register_Mail", "[Name], [VerificationLink]", 0, true, "Chào mừng đến với FitWipe! Vui lòng xác nhận email của bạn", null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreateById", "CreatedDate", "DeletedDate", "Name", "RecordStatus", "TagImage", "TagType", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("345ec15d-42b3-448a-9bc3-2edecf55673d"), "123abc", new DateTime(2024, 9, 27, 9, 35, 40, 326, DateTimeKind.Local).AddTicks(5492), null, "Bóng đá", 0, null, 0, null },
                    { new Guid("6a99e1a9-4a3c-473c-a3c8-777f944de1fe"), "123abc", new DateTime(2024, 9, 27, 9, 35, 40, 326, DateTimeKind.Local).AddTicks(5529), null, "Phát triển cơ bắp", 0, null, 1, null },
                    { new Guid("6e1018cd-23a8-4dad-89c9-3dbd13a0b160"), "123abc", new DateTime(2024, 9, 27, 9, 35, 40, 326, DateTimeKind.Local).AddTicks(5546), null, "Kiên trì", 0, null, 4, null },
                    { new Guid("6e2127af-6c34-4b74-bc48-a27cc8fe937c"), "123abc", new DateTime(2024, 9, 27, 9, 35, 40, 326, DateTimeKind.Local).AddTicks(5549), null, "Siêng năng", 0, null, 4, null },
                    { new Guid("6f6cc7d1-2c3c-406f-ba2d-3c239b90e8d0"), "123abc", new DateTime(2024, 9, 27, 9, 35, 40, 326, DateTimeKind.Local).AddTicks(5538), null, "Cardino", 0, null, 2, null },
                    { new Guid("721b346f-41c2-4f35-85fd-23ac6eeb9330"), "123abc", new DateTime(2024, 9, 27, 9, 35, 40, 326, DateTimeKind.Local).AddTicks(5535), null, "Yoga", 0, null, 2, null },
                    { new Guid("73331a03-ab7a-4962-9bc4-a73ad64f193a"), "123abc", new DateTime(2024, 9, 27, 9, 35, 40, 326, DateTimeKind.Local).AddTicks(5496), null, "Video game", 0, null, 0, null },
                    { new Guid("8d750c81-089a-4018-aa95-1c4215bc1bb1"), "123abc", new DateTime(2024, 9, 27, 9, 35, 40, 326, DateTimeKind.Local).AddTicks(5541), null, "Ngoại hình đẹp", 0, null, 3, null },
                    { new Guid("efc33543-7354-4b7c-af2b-0ce44bdac07a"), "123abc", new DateTime(2024, 9, 27, 9, 35, 40, 326, DateTimeKind.Local).AddTicks(5499), null, "Giảm cân", 0, null, 1, null },
                    { new Guid("fa717782-b51b-4a82-96e9-683acc942944"), "123abc", new DateTime(2024, 9, 27, 9, 35, 40, 326, DateTimeKind.Local).AddTicks(5544), null, "Giá rẻ", 0, null, 3, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "123abc",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 9, 27, 9, 35, 40, 326, DateTimeKind.Local).AddTicks(4786), new Guid("80f50c05-0dcc-49c7-acd0-4549425874c5") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "456def",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 9, 27, 9, 35, 40, 326, DateTimeKind.Local).AddTicks(4875), new Guid("c2a5e40b-54ba-45cd-8e1f-20b6af02f985") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "789ghi",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 9, 27, 9, 35, 40, 326, DateTimeKind.Local).AddTicks(4893), new Guid("d86635c7-ef52-4dd0-b0e5-5a34c81a8ad5") });

            migrationBuilder.AddForeignKey(
                name: "FK_SlotVideos_Slots_SlotId",
                table: "SlotVideos",
                column: "SlotId",
                principalTable: "Slots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SlotVideos_Slots_SlotId",
                table: "SlotVideos");

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("0422300c-6fc0-437f-8b65-e5921f03ba65"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("3fa1e03a-fa7e-42f4-b851-a51e18def90b"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("345ec15d-42b3-448a-9bc3-2edecf55673d"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("6a99e1a9-4a3c-473c-a3c8-777f944de1fe"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("6e1018cd-23a8-4dad-89c9-3dbd13a0b160"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("6e2127af-6c34-4b74-bc48-a27cc8fe937c"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("6f6cc7d1-2c3c-406f-ba2d-3c239b90e8d0"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("721b346f-41c2-4f35-85fd-23ac6eeb9330"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("73331a03-ab7a-4962-9bc4-a73ad64f193a"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("8d750c81-089a-4018-aa95-1c4215bc1bb1"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("efc33543-7354-4b7c-af2b-0ce44bdac07a"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("fa717782-b51b-4a82-96e9-683acc942944"));

            migrationBuilder.InsertData(
                table: "EmailTemplates",
                columns: new[] { "Id", "Body", "CreatedDate", "DeletedDate", "Description", "Name", "Params", "RecordStatus", "Status", "Subject", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("6a9f3507-a330-482d-9b63-3154d00c1d43"), "Chúng tôi đã nhận được yêu cầu đặt lại mật khẩu cho tài khoản của bạn tại FitWipe. Kính gửi [Name], vui lòng đặt lại mật khẩu của bạn bằng cách nhấn vào đường link sau: <a href=\"[ResetPasswordLink]\">Đặt lại mật khẩu</a>.<br><br>Nếu bạn không yêu cầu việc này, vui lòng bỏ qua email này.<br><br>Đội ngũ FitWipe", new DateTime(2024, 9, 27, 9, 14, 48, 499, DateTimeKind.Local).AddTicks(2869), null, "Email này được gửi khi người dùng yêu cầu đặt lại mật khẩu cho tài khoản FitWipe.", "Forgot_Password", "[Name], [ResetPasswordLink]", 0, true, "Yêu cầu đặt lại mật khẩu FitWipe", null },
                    { new Guid("9c56c3bc-b40c-4e1f-a36d-6d51ae4f443f"), "Chào mừng bạn đến với FitWipe! Kính gửi [Name], vui lòng xác nhận địa chỉ email của bạn bằng cách nhấn vào đường link sau: <a href=\"[VerificationLink]\">Xác nhận Email</a>.<br><br>Cảm ơn bạn đã tham gia cùng chúng tôi!<br><br>Đội ngũ FitWipe", new DateTime(2024, 9, 27, 9, 14, 48, 499, DateTimeKind.Local).AddTicks(2842), null, "Email này được gửi để xác nhận đăng ký tài khoản FitWipe.", "Register_Mail", "[Name], [VerificationLink]", 0, true, "Chào mừng đến với FitWipe! Vui lòng xác nhận email của bạn", null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreateById", "CreatedDate", "DeletedDate", "Name", "RecordStatus", "TagImage", "TagType", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("1d8f4a6d-a72f-4471-885f-2ebba7aca4c4"), "123abc", new DateTime(2024, 9, 27, 9, 14, 48, 499, DateTimeKind.Local).AddTicks(2786), null, "Yoga", 0, null, 2, null },
                    { new Guid("20c0081c-a9fb-49ff-94ab-3921f06b7d6d"), "123abc", new DateTime(2024, 9, 27, 9, 14, 48, 499, DateTimeKind.Local).AddTicks(2790), null, "Ngoại hình đẹp", 0, null, 3, null },
                    { new Guid("2455bada-77ab-4193-bfc5-43b24cac3e43"), "123abc", new DateTime(2024, 9, 27, 9, 14, 48, 499, DateTimeKind.Local).AddTicks(2784), null, "Phát triển cơ bắp", 0, null, 1, null },
                    { new Guid("299adece-8f54-4558-8a0a-934bda8db592"), "123abc", new DateTime(2024, 9, 27, 9, 14, 48, 499, DateTimeKind.Local).AddTicks(2755), null, "Bóng đá", 0, null, 0, null },
                    { new Guid("4c72490a-815a-47d9-99bd-b97e97bd6741"), "123abc", new DateTime(2024, 9, 27, 9, 14, 48, 499, DateTimeKind.Local).AddTicks(2795), null, "Siêng năng", 0, null, 4, null },
                    { new Guid("8c236bbd-d4b3-4249-b08b-5deb1c29ab9e"), "123abc", new DateTime(2024, 9, 27, 9, 14, 48, 499, DateTimeKind.Local).AddTicks(2782), null, "Giảm cân", 0, null, 1, null },
                    { new Guid("8ea08891-ad11-4e7f-99a6-3f02eff83b7d"), "123abc", new DateTime(2024, 9, 27, 9, 14, 48, 499, DateTimeKind.Local).AddTicks(2758), null, "Video game", 0, null, 0, null },
                    { new Guid("9689fa27-d287-4bf4-bd78-734a36152b18"), "123abc", new DateTime(2024, 9, 27, 9, 14, 48, 499, DateTimeKind.Local).AddTicks(2793), null, "Kiên trì", 0, null, 4, null },
                    { new Guid("9a510e65-3c75-4917-85ca-95802b71abc8"), "123abc", new DateTime(2024, 9, 27, 9, 14, 48, 499, DateTimeKind.Local).AddTicks(2788), null, "Cardino", 0, null, 2, null },
                    { new Guid("a969c1d2-d00b-48d5-8daf-915ee4a1a23d"), "123abc", new DateTime(2024, 9, 27, 9, 14, 48, 499, DateTimeKind.Local).AddTicks(2791), null, "Giá rẻ", 0, null, 3, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "123abc",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 9, 27, 9, 14, 48, 499, DateTimeKind.Local).AddTicks(2321), new Guid("5ce2737b-17ce-489c-8bcf-c75557cfae72") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "456def",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 9, 27, 9, 14, 48, 499, DateTimeKind.Local).AddTicks(2382), new Guid("a880d4c3-35b0-430e-98c0-f9fd552d6b8a") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "789ghi",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 9, 27, 9, 14, 48, 499, DateTimeKind.Local).AddTicks(2393), new Guid("d0842e66-2d1d-4244-be9c-cfc62b3cfc41") });

            migrationBuilder.AddForeignKey(
                name: "FK_SlotVideos_Slots_SlotId",
                table: "SlotVideos",
                column: "SlotId",
                principalTable: "Slots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
