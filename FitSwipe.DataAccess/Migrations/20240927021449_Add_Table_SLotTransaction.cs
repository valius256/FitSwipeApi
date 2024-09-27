using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FitSwipe.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Add_Table_SLotTransaction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FeedbackImages_Trainings_TrainingId",
                table: "FeedbackImages");

            migrationBuilder.DropForeignKey(
                name: "FK_ReportImages_Reports_ReportId",
                table: "ReportImages");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_Users_ReporterId",
                table: "Reports");

            migrationBuilder.DropForeignKey(
                name: "FK_Slots_Trainings_TrainingId",
                table: "Slots");

            migrationBuilder.DropForeignKey(
                name: "FK_Slots_Users_CreateById",
                table: "Slots");

            migrationBuilder.DropForeignKey(
                name: "FK_Tags_Users_CreateById",
                table: "Tags");

            migrationBuilder.DropForeignKey(
                name: "FK_Trainings_Users_TraineeId",
                table: "Trainings");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Users_UserFireBaseId",
                table: "Transactions");

            migrationBuilder.DropForeignKey(
                name: "FK_UserMedias_Users_UserId",
                table: "UserMedias");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTags_Tags_TagId",
                table: "UserTags");

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

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Transactions");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Transactions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "Slots",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Slots",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PaymentStatus",
                table: "Slots",
                type: "int",
                nullable: true,
                defaultValue: 1,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "SlotVideos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SlotId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VideoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RecordStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SlotVideos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SlotVideos_Slots_SlotId",
                        column: x => x.SlotId,
                        principalTable: "Slots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TransactionSlots",
                columns: table => new
                {
                    SlotId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TransactionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RecordStatus = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_SlotVideos_SlotId",
                table: "SlotVideos",
                column: "SlotId");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionSlots_TransactionId",
                table: "TransactionSlots",
                column: "TransactionId");

            migrationBuilder.AddForeignKey(
                name: "FK_FeedbackImages_Trainings_TrainingId",
                table: "FeedbackImages",
                column: "TrainingId",
                principalTable: "Trainings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReportImages_Reports_ReportId",
                table: "ReportImages",
                column: "ReportId",
                principalTable: "Reports",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_Users_ReporterId",
                table: "Reports",
                column: "ReporterId",
                principalTable: "Users",
                principalColumn: "FireBaseId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Slots_Trainings_TrainingId",
                table: "Slots",
                column: "TrainingId",
                principalTable: "Trainings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Slots_Users_CreateById",
                table: "Slots",
                column: "CreateById",
                principalTable: "Users",
                principalColumn: "FireBaseId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_Users_CreateById",
                table: "Tags",
                column: "CreateById",
                principalTable: "Users",
                principalColumn: "FireBaseId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Trainings_Users_TraineeId",
                table: "Trainings",
                column: "TraineeId",
                principalTable: "Users",
                principalColumn: "FireBaseId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Users_UserFireBaseId",
                table: "Transactions",
                column: "UserFireBaseId",
                principalTable: "Users",
                principalColumn: "FireBaseId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserMedias_Users_UserId",
                table: "UserMedias",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "FireBaseId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTags_Tags_TagId",
                table: "UserTags",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FeedbackImages_Trainings_TrainingId",
                table: "FeedbackImages");

            migrationBuilder.DropForeignKey(
                name: "FK_ReportImages_Reports_ReportId",
                table: "ReportImages");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_Users_ReporterId",
                table: "Reports");

            migrationBuilder.DropForeignKey(
                name: "FK_Slots_Trainings_TrainingId",
                table: "Slots");

            migrationBuilder.DropForeignKey(
                name: "FK_Slots_Users_CreateById",
                table: "Slots");

            migrationBuilder.DropForeignKey(
                name: "FK_Tags_Users_CreateById",
                table: "Tags");

            migrationBuilder.DropForeignKey(
                name: "FK_Trainings_Users_TraineeId",
                table: "Trainings");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Users_UserFireBaseId",
                table: "Transactions");

            migrationBuilder.DropForeignKey(
                name: "FK_UserMedias_Users_UserId",
                table: "UserMedias");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTags_Tags_TagId",
                table: "UserTags");

            migrationBuilder.DropTable(
                name: "SlotVideos");

            migrationBuilder.DropTable(
                name: "TransactionSlots");

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

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Transactions");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Transactions",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "Slots",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Slots",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "PaymentStatus",
                table: "Slots",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValue: 1);

            migrationBuilder.InsertData(
                table: "EmailTemplates",
                columns: new[] { "Id", "Body", "CreatedDate", "DeletedDate", "Description", "Name", "Params", "RecordStatus", "Status", "Subject", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("af88cc24-2edf-4d62-8be7-64c7845a7c83"), "Chào mừng bạn đến với FitWipe! Kính gửi [Name], vui lòng xác nhận địa chỉ email của bạn bằng cách nhấn vào đường link sau: <a href=\"[VerificationLink]\">Xác nhận Email</a>.<br><br>Cảm ơn bạn đã tham gia cùng chúng tôi!<br><br>Đội ngũ FitWipe", new DateTime(2024, 9, 20, 13, 47, 4, 575, DateTimeKind.Local).AddTicks(129), null, "Email này được gửi để xác nhận đăng ký tài khoản FitWipe.", "Register_Mail", "[Name], [VerificationLink]", 0, true, "Chào mừng đến với FitWipe! Vui lòng xác nhận email của bạn", null },
                    { new Guid("e651b2b4-7213-4820-9b20-0c92f9e59cb7"), "Chúng tôi đã nhận được yêu cầu đặt lại mật khẩu cho tài khoản của bạn tại FitWipe. Kính gửi [Name], vui lòng đặt lại mật khẩu của bạn bằng cách nhấn vào đường link sau: <a href=\"[ResetPasswordLink]\">Đặt lại mật khẩu</a>.<br><br>Nếu bạn không yêu cầu việc này, vui lòng bỏ qua email này.<br><br>Đội ngũ FitWipe", new DateTime(2024, 9, 20, 13, 47, 4, 575, DateTimeKind.Local).AddTicks(155), null, "Email này được gửi khi người dùng yêu cầu đặt lại mật khẩu cho tài khoản FitWipe.", "Forgot_Password", "[Name], [ResetPasswordLink]", 0, true, "Yêu cầu đặt lại mật khẩu FitWipe", null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreateById", "CreatedDate", "DeletedDate", "Name", "RecordStatus", "TagImage", "TagType", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("04cedcf8-4a8b-47a0-b8cd-5700deb60cb8"), "123abc", new DateTime(2024, 9, 20, 13, 47, 4, 575, DateTimeKind.Local).AddTicks(95), null, "Kiên trì", 0, null, 4, null },
                    { new Guid("2195e62a-e67c-4773-a557-f355c32d171a"), "123abc", new DateTime(2024, 9, 20, 13, 47, 4, 575, DateTimeKind.Local).AddTicks(97), null, "Siêng năng", 0, null, 4, null },
                    { new Guid("34853b0b-ac13-46c9-9a0f-447a2957bf31"), "123abc", new DateTime(2024, 9, 20, 13, 47, 4, 575, DateTimeKind.Local).AddTicks(63), null, "Bóng đá", 0, null, 0, null },
                    { new Guid("3f15fe50-e20c-44f1-8783-4a549ddd0eb6"), "123abc", new DateTime(2024, 9, 20, 13, 47, 4, 575, DateTimeKind.Local).AddTicks(86), null, "Phát triển cơ bắp", 0, null, 1, null },
                    { new Guid("47a3ffdb-485b-4481-86f5-8585fe1fe0b3"), "123abc", new DateTime(2024, 9, 20, 13, 47, 4, 575, DateTimeKind.Local).AddTicks(94), null, "Giá rẻ", 0, null, 3, null },
                    { new Guid("4874d5ca-3b73-4a6a-8656-8b336add3a42"), "123abc", new DateTime(2024, 9, 20, 13, 47, 4, 575, DateTimeKind.Local).AddTicks(92), null, "Ngoại hình đẹp", 0, null, 3, null },
                    { new Guid("4aaebacb-8153-46f5-bd8a-be4d2352b55f"), "123abc", new DateTime(2024, 9, 20, 13, 47, 4, 575, DateTimeKind.Local).AddTicks(65), null, "Video game", 0, null, 0, null },
                    { new Guid("56d8a7bb-0a16-4257-aaea-84acaea64456"), "123abc", new DateTime(2024, 9, 20, 13, 47, 4, 575, DateTimeKind.Local).AddTicks(88), null, "Yoga", 0, null, 2, null },
                    { new Guid("e1d1c48f-de02-4e33-93f7-c66683c69773"), "123abc", new DateTime(2024, 9, 20, 13, 47, 4, 575, DateTimeKind.Local).AddTicks(90), null, "Cardino", 0, null, 2, null },
                    { new Guid("f27fef6b-faf0-413a-9be8-0bd7c4b7ab60"), "123abc", new DateTime(2024, 9, 20, 13, 47, 4, 575, DateTimeKind.Local).AddTicks(67), null, "Giảm cân", 0, null, 1, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "123abc",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 9, 20, 13, 47, 4, 574, DateTimeKind.Local).AddTicks(9633), new Guid("a4e79704-41c2-4e13-9831-fa4413159ade") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "456def",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 9, 20, 13, 47, 4, 574, DateTimeKind.Local).AddTicks(9678), new Guid("b2489e1d-9421-4a0e-b273-bb0837262728") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "789ghi",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 9, 20, 13, 47, 4, 574, DateTimeKind.Local).AddTicks(9721), new Guid("f2367743-2f93-4af4-ba04-f521d6588839") });

            migrationBuilder.AddForeignKey(
                name: "FK_FeedbackImages_Trainings_TrainingId",
                table: "FeedbackImages",
                column: "TrainingId",
                principalTable: "Trainings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReportImages_Reports_ReportId",
                table: "ReportImages",
                column: "ReportId",
                principalTable: "Reports",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_Users_ReporterId",
                table: "Reports",
                column: "ReporterId",
                principalTable: "Users",
                principalColumn: "FireBaseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Slots_Trainings_TrainingId",
                table: "Slots",
                column: "TrainingId",
                principalTable: "Trainings",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Slots_Users_CreateById",
                table: "Slots",
                column: "CreateById",
                principalTable: "Users",
                principalColumn: "FireBaseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_Users_CreateById",
                table: "Tags",
                column: "CreateById",
                principalTable: "Users",
                principalColumn: "FireBaseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Trainings_Users_TraineeId",
                table: "Trainings",
                column: "TraineeId",
                principalTable: "Users",
                principalColumn: "FireBaseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Users_UserFireBaseId",
                table: "Transactions",
                column: "UserFireBaseId",
                principalTable: "Users",
                principalColumn: "FireBaseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserMedias_Users_UserId",
                table: "UserMedias",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "FireBaseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTags_Tags_TagId",
                table: "UserTags",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
