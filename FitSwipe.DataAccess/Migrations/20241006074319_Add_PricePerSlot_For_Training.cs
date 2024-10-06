using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FitSwipe.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Add_PricePerSlot_For_Training : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("7795bebb-04d6-4ed5-90ca-cb05cdef1ce0"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("8b50cb5e-051c-494a-bda3-4f019eadcd24"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("01e44d37-1c36-4fbe-9338-e500fd2d9842"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("02f66d5e-1bc9-4677-8f7c-f0288a1f8225"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("0528a934-f63c-49eb-8feb-898ced63aad5"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("091bdd48-5a0c-4bb7-8f28-6e66227933a4"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("0c1d6c22-7426-478c-b327-76e9b99f1101"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("0c65dcd8-6e0d-49a5-a9f7-2975ce556dd5"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("0dfe4292-b8e6-41e2-874f-794d29672e49"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("1031aed2-1958-43e9-a2e5-2dda19c24e21"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("1273b61f-fa13-4db0-b640-25aa59f88ce4"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("15d6e5db-db2e-4f69-8ca9-675bc9336a10"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("1c634ecc-4a7d-4fbd-a51c-6538723bf4ef"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("2039b40b-5694-4a80-9ba0-85d0db8ef1c0"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("22a7b666-d402-43c6-83a4-f66463ac0c80"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("23508eeb-cb8a-4c80-9a04-f2b19485a2d5"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("3030bc86-8da6-45ea-b29a-1250fe19a2ef"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("31493839-107b-4eed-994b-70083c406780"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("40e65f78-259f-428d-9722-e0676b7b0420"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("40fce20f-fd76-496e-899c-bb0b1ef44007"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("41de4518-b4a1-48c9-a188-9348fc209c86"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("4597cbf3-3bef-45cb-be67-1d5ef3a02f22"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("45df85e6-60b4-4fb5-baa0-25b0613567fa"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("46b447b8-d5b2-416d-a900-7d73d487d138"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("483953df-edb8-4921-82f7-a52e6e6161d0"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("4f0d3b18-11b8-4e7f-8b59-57886e339a59"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("5513ccc4-abfc-46cc-be90-922f5269b9cb"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("5537d6ce-f8e1-46f3-a71e-2556685d76ba"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("5ce3fdd3-c542-47ef-ab44-dcc5fd92043a"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("5dbd9f89-6e6a-40de-9712-054efde207d4"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("5e8f3e2c-31c2-4f94-89a6-ed5ca847844c"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("5fb2621c-433f-4e11-a7ab-a31b7739c638"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("5fbbfd5a-f7ab-406a-b718-5e2bff17c05c"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("66c87631-c884-45b7-b287-9fa32d29bf44"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("6b49aeba-26f5-42b8-82a1-ea49ff236e19"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("6e1d311f-7367-490a-a4c8-1a2496352eac"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("6f17f023-5c61-462c-b0be-e80856567660"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("7555638f-08a8-42c9-bf94-6f85ad87161b"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("78c7a6a5-2623-4864-94f3-9b786b58334e"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("7ba189e6-a800-49bf-9219-89e2b62f3a21"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("7c5c7f9a-85c8-424c-9417-d1fc61f87bef"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("87a799d7-578a-4723-a063-fde568bf2b97"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("87d5739b-f7ac-4c87-846d-6576e0fbc57c"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("8ab32dc6-80ee-4c46-9b7f-4e4f4c4e6fae"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("8f2e6a12-908a-4885-8979-079b3ce3b574"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("8f3355de-e591-45ed-b6a0-69ef75e44e2e"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("8f464ea8-fa70-407d-84fb-0f9bc240cd7d"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("9d8887af-9fe0-4af6-a5fc-c2691da6b6ee"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("a13f9896-b95f-46ef-ad7b-3e7aa5322a86"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("a16c68c3-9500-4a3c-9551-5d0133a96d36"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("a44c9f0e-5b16-4f88-ba5f-ccb195f7ff2c"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("a54a35c7-abf1-43b4-a437-cde306fbf851"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("a5b23d75-9325-4164-ba61-8067af862c74"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("ac874c07-444f-4624-9605-c384b616d7f1"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("b0bfa20d-50d0-42f0-befc-6cde9ec21d5c"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("b25f4bd0-ddd1-483c-9d7e-1670b30d321f"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("b4de45ba-fc81-49e5-9eb1-5bf7550f08fa"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("bade1927-ca85-4aa9-88df-6fd9494aa4f9"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("bbb9d9f6-bdcb-4988-81ee-f103200e4939"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("ca5907cd-cfc5-4de7-83f9-a9d46c535b21"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("cfd0739f-e268-4bda-b01a-b122be6a32fb"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("d6da0e93-5616-4412-b2d8-5e66ad137ae9"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("d7fbfd28-dcef-4a2e-86fd-77ddac2d158d"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("d847ac9f-a4f5-41a1-8e83-814f773552e6"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("d9387c24-2d9b-4a35-be6c-b7d19bcedab7"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("d96c2fcc-a7f5-4db0-b747-43bc5a0a8476"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("de2f8334-7769-4159-bfc7-71ad7c522044"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("e0a483b0-ca14-47c4-8e84-78e898ea160b"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("e4466e92-50fc-4382-947c-b8596e3f10d1"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("e695d66a-d9c7-43e0-9ed9-95fdfc88ad05"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("e7ca93ec-9bd9-49dd-92bf-60ce36b1d919"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("ec0da361-6c9c-41c5-bd3a-5c68f2aa1cf6"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("ef0a67de-2974-4c4e-886d-376a5379a013"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("f036a951-f70c-429a-add1-7a8d00fdc51f"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("f6a6727d-9e3c-4289-8871-a630b37bd032"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("ffcc9b69-437c-4ddf-9c8e-4fdcd9e52807"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("ffdfbad1-7525-4246-8f9a-6e0e62af0997"));

            migrationBuilder.AddColumn<int>(
                name: "PricePerSlot",
                table: "Trainings",
                type: "integer",
                nullable: true);

            migrationBuilder.InsertData(
                table: "EmailTemplates",
                columns: new[] { "Id", "Body", "CreatedDate", "DeletedDate", "Description", "Name", "Params", "RecordStatus", "Status", "Subject", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("9897dcd4-39e9-403b-beb5-ffe5aa28e888"), "Chúng tôi đã nhận được yêu cầu đặt lại mật khẩu cho tài khoản của bạn tại FitWipe. Kính gửi [Name], vui lòng đặt lại mật khẩu của bạn bằng cách nhấn vào đường link sau: <a href=\"[ResetPasswordLink]\">Đặt lại mật khẩu</a>.<br><br>Nếu bạn không yêu cầu việc này, vui lòng bỏ qua email này.<br><br>Đội ngũ FitWipe", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7339), null, "Email này được gửi khi người dùng yêu cầu đặt lại mật khẩu cho tài khoản FitWipe.", "Forgot_Password", "[Name], [ResetPasswordLink]", 0, true, "Yêu cầu đặt lại mật khẩu FitWipe", null },
                    { new Guid("a09462a9-397c-4a59-8fe1-985a78800a3d"), "Chào mừng bạn đến với FitWipe! Kính gửi [Name], vui lòng xác nhận địa chỉ email của bạn bằng cách nhấn vào đường link sau: <a href=\"[VerificationLink]\">Xác nhận Email</a>.<br><br>Cảm ơn bạn đã tham gia cùng chúng tôi!<br><br>Đội ngũ FitWipe", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7287), null, "Email này được gửi để xác nhận đăng ký tài khoản FitWipe.", "Register_Mail", "[Name], [VerificationLink]", 0, true, "Chào mừng đến với FitWipe! Vui lòng xác nhận email của bạn", null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreateById", "CreatedDate", "DeletedDate", "Name", "RecordStatus", "SpecialTag", "TagImage", "TagType", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("00d69c03-d1a7-4cc2-b2a6-84619043d98e"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7174), null, "Tập ép dẻo", 0, null, "https://prod-everyoneactive-wp.s3.eu-west-2.amazonaws.com/wp-content/uploads/2020/03/23151503/flexibility-at-home.jpg", 2, null },
                    { new Guid("05890b90-ff66-448a-bf5c-c6d7141b1ba3"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7120), null, "Bida", 0, null, "https://billiardshoanthuy.vn/wp-content/uploads/2021/05/phu-kien-ban-bida-2.jpg", 0, null },
                    { new Guid("08f67f61-c3d8-4232-bb27-2698b56cb2c2"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7222), null, "Thi thoảng bất thường", 0, null, null, 4, null },
                    { new Guid("0db2c9d3-9a72-483b-a3ff-f7206464ed29"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7176), null, "Thể dục nhịp điệu, theo nhạc", 0, null, "https://i.vietgiaitri.com/2018/10/9/the-duc-nhip-dieu-b2ab9f.jpg", 2, null },
                    { new Guid("0f660a55-c30b-4f54-bdce-8006607bd0a1"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7169), null, "Tập sức mạnh", 0, null, "https://www.thethaothientruong.vn/uploads/2020/Powerlifting-la-gi.jpg", 2, null },
                    { new Guid("16ab40c9-6143-4632-a802-c235db7e5d0f"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7136), null, "Hội họa", 0, null, "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ea/Van_Gogh_-_Starry_Night_-_Google_Art_Project.jpg/1200px-Van_Gogh_-_Starry_Night_-_Google_Art_Project.jpg", 0, null },
                    { new Guid("17b071c9-d55c-4d26-bcf6-b687bd06a970"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7160), null, "Cải thiện sự dẻo dai", 0, null, "https://cdn.shopify.com/s/files/1/0453/0381/files/fullsizeoutput_2d4_1024x1024.jpg?v=1662646979", 1, null },
                    { new Guid("1cb5f947-291b-4189-b680-36d6a9572e65"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7117), null, "Bóng rổ", 0, null, "https://thethaothienlong.vn/wp-content/uploads/2022/04/Kich-thuoc-qua-bong-ro-1.jpg", 0, null },
                    { new Guid("1d25b391-6df0-4da3-9184-622e9274de6b"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7139), null, "Chơi nhạc cụ", 0, null, "https://t3.ftcdn.net/jpg/01/34/38/92/360_F_134389281_5Jak3tbsoDggHIfIKKwJ8L7064ACIMNE.jpg", 0, null },
                    { new Guid("20756b72-fd94-4727-a169-70cef18697c9"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7214), null, "Siêng năng", 0, null, null, 4, null },
                    { new Guid("21cf4f6a-1757-4d5a-814f-d867be8b90f3"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7148), null, "Triết học", 0, null, "https://www.rollingstone.com/wp-content/uploads/2024/01/unlocking_the_power_why_you_should_consider_hiring_philosophy_graduates-.jpg", 0, null },
                    { new Guid("238af788-8505-4736-94bc-b02974891cc8"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7159), null, "Tăng cảm giác hạnh phúc, giảm căng thẳng", 0, null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT8ZXc_bemAYbupxmGz0pZGy4L1Zr6hGVsYdA&s", 1, null },
                    { new Guid("25a3e31f-6be6-42d0-8e04-20a3c87876bf"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7205), null, "Không nặng nề với học viên", 0, null, null, 3, null },
                    { new Guid("2b46d75f-d748-4aee-b0a1-140c9cf64d1a"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7235), null, "Thoải mái", 0, null, null, 4, null },
                    { new Guid("2b709d84-e994-494f-9130-669ba99a06e5"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7213), null, "Kiên trì", 0, null, null, 4, null },
                    { new Guid("2f83a40e-2bc9-4986-b432-7fc719f09e9e"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7155), null, "Có body chuẩn chỉnh", 0, null, "https://cdn.nhathuoclongchau.com.vn/unsafe/800x0/https://cms-prod.s3-sgn09.fptcloud.com/fitness_la_gi_loi_ich_va_phuong_phap_tap_luyen_fitness_1_3c4e094223.png", 1, null },
                    { new Guid("320b0cea-352e-4a30-91cd-8d01fc1960e1"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7207), null, "Giàu kiến thức", 0, null, null, 3, null },
                    { new Guid("38a54284-e1a4-4e57-adbd-14d0ff362269"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7131), null, "Đọc sách", 0, null, "https://images.theconversation.com/files/45159/original/rptgtpxd-1396254731.jpg?ixlib=rb-4.1.0&q=45&auto=format&w=1356&h=668&fit=crop", 0, null },
                    { new Guid("3abe01a8-937f-4e4e-bda5-325d660fe4b1"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7164), null, "Yoga / Pilates", 0, null, "https://thamtapyoga.vn/wp-content/uploads/2024/01/3-2.jpeg", 2, null },
                    { new Guid("3dfd865b-29c0-407e-9669-a88c36d8d7ca"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7145), null, "Lịch Sử", 0, null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRWz_tIgvQXPAaSmvYa7CqZo_biaRK9D_O8uA&s", 0, null },
                    { new Guid("410c496c-41cd-4ba5-8661-f60b050bc7ef"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7208), null, "Luôn sẵn sàng tư vấn ngoài giờ", 0, null, null, 3, null },
                    { new Guid("47a9e6c0-9215-4dae-b48d-2bffb5f71d9e"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7212), null, "Đảm bảo mục tiêu cho học viên", 0, null, null, 3, null },
                    { new Guid("4beeb98a-9a91-41d0-9fbb-c0087a07e3fb"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7157), null, "Cải thiện tình trạng bệnh", 0, null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQv509Yw7GUN5twNNk4G5Pvu1TBqFmhrL_3UQ&s", 1, null },
                    { new Guid("540ee3fc-7ae0-4407-991d-eacce9779824"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7170), null, "Cardio", 0, null, "https://file.hstatic.net/1000308068/file/tap-cardio-vao-luc-nao-la-hieu-qua-nhat_cb884317c05d4df980138121ee113112_grande.jpg", 2, null },
                    { new Guid("56acf317-2be6-4e09-9e8d-62bf4d0424a3"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7173), null, "Kickfit", 0, null, "https://storage.googleapis.com/leep_app_website/2020/11/Kick-fit-khong-phai-la-kick-boxing.jpg", 2, null },
                    { new Guid("56cdcfb2-4331-4bc9-a25e-74c470adf1e7"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7163), null, "Cải thiện sức khỏe tổng quát", 0, null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcThCjFemkP0h0IZYpu31k-xGK9IvigaysteqA&s", 1, null },
                    { new Guid("576929ce-c125-435b-a886-e18251064fcb"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7210), null, "Biết truyền cảm hứng, tạo động lực", 0, null, null, 3, null },
                    { new Guid("58053e66-d002-4d84-88c6-7a2350623c28"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7201), null, "Tâm huyết với học viên", 0, null, null, 3, null },
                    { new Guid("5945872f-6d7d-4faa-b51a-24935eed4eeb"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7167), null, "Calisthenic", 0, null, "https://cdn.nhathuoclongchau.com.vn/unsafe/800x0/https://cms-prod.s3-sgn09.fptcloud.com/giai_dap_thac_mac_calisthenics_khac_gi_gym_1_8d5dd4026b.jpg", 2, null },
                    { new Guid("5ad3fa2a-34cc-4db1-bd11-badf1bfdeb6b"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7144), null, "Công nghệ", 0, null, "https://www.simplilearn.com/ice9/free_resources_article_thumb/Technology_Trends.jpg", 0, null },
                    { new Guid("5bad94de-2459-48e8-bf9f-2669d56f5707"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7123), null, "Đi, chạy bộ", 0, null, "https://pos.nvncdn.com/be3294-43017/art/artCT/20230228_9uObLfWys7Q0IXe4.jpg", 0, null },
                    { new Guid("607b9ea0-6a51-47c3-a57d-e246a2d5b1c5"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7143), null, "Tán gẫu", 0, null, "https://transcode-v2.app.engoo.com/image/fetch/f_auto,c_lfill,w_300,dpr_3/https://assets.app.engoo.com/images/rGTEEA2fm66YMzeJz2UbwkKOW62bZVlqKOKZrXlMN7g.jpeg", 0, null },
                    { new Guid("609a3f99-2652-4c8f-989a-8405db6c0479"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7231), null, "Hiền lành", 0, null, null, 4, null },
                    { new Guid("67cb813e-3b6f-494c-bd5c-ebb88b8115e9"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7203), null, "Có kinh nghiệm", 0, null, null, 3, null },
                    { new Guid("6a6fa207-d3ad-4fae-b641-552b32aeee53"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7122), null, "Tập Gym", 0, null, "https://tiki.vn/blog/wp-content/uploads/2023/07/elite-fitness-1024x583.jpg", 0, null },
                    { new Guid("70b03f5b-ac6e-45d5-a1fb-fe19e8d9e06c"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7130), null, "Thể thao trí tuệ", 0, null, "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6f/ChessSet.jpg/640px-ChessSet.jpg", 0, null },
                    { new Guid("71230e63-8f0c-4eb9-902a-a169b195d73f"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7126), null, "Truyện tranh", 0, null, "https://taschen.makaira.media/taschen/image/upload/f_webp,w_1200/v1673462260/products-live/a3d446fb0046b587eb0ed76edca3f4d6.jpg", 0, null },
                    { new Guid("7479e06c-4f33-4a4c-b7bd-996fc6e3bca9"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7135), null, "Nhiếp ảnh", 0, null, "https://aaftonline.com/blog/wp-content/uploads/2024/01/What-are-the-Benefits-of-Photography-Complete-Overview.png", 0, null },
                    { new Guid("77e699f7-b9e8-49d4-8c53-a15ca5327c31"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7228), null, "Hay bị lười", 0, null, null, 4, null },
                    { new Guid("79236e17-fe1f-4382-bc2e-6a22b3e6e07c"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7107), null, "Bóng đá", 0, null, "https://cdn.tuoitre.vn/ttct//2020/12/13/16078750289060-lich-thi-dau-bong-da-hom-nay-0211.jpg", 0, null },
                    { new Guid("7ac19a30-5611-4294-b1c0-8c4fe87070e0"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7234), null, "Cầu toàn", 0, null, null, 4, null },
                    { new Guid("7b47d3dc-5ed7-4987-aadc-eceba4b6eee0"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7152), null, "Phát triển cơ bắp", 0, null, "https://www.dmoose.com/cdn/shop/articles/feature-image_87a28752-6da3-4be8-8814-d5221236136d.jpg?v=1676644951", 1, null },
                    { new Guid("7ca2d7b4-7f7d-4dc2-96fb-cc91066e35b8"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7134), null, "Game", 0, null, "https://genk.mediacdn.vn/139269124445442048/2022/7/28/tmb-1658998970448906989995.jpg", 0, null },
                    { new Guid("7da317b7-1a37-44bd-a77a-d9e4b94a9a1b"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7220), null, "Dễ gần", 0, null, null, 4, null },
                    { new Guid("7eecea45-87da-4638-8928-83d06a14c656"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7194), null, "Khác giới", 0, 0, null, 3, null },
                    { new Guid("8274bcf3-ce63-446a-9f6f-ffa6f06d454b"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7199), null, "Gần", 0, 2, null, 3, null },
                    { new Guid("82ec8cef-22ed-4d77-9691-79a2093be7a6"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7230), null, "Sẵn sàng học hỏi", 0, null, null, 4, null },
                    { new Guid("83c6bd6f-ab3a-43f3-8464-9a5eb52ffee9"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7127), null, "Du lịch", 0, null, "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/18/4f/7d/fc/caption.jpg?w=1200&h=1200&s=1", 0, null },
                    { new Guid("8650da68-06bf-4abd-9bf5-fd1ce302790e"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7151), null, "Quản lý cân nặng", 0, null, "https://thanhnien.mediacdn.vn/Uploaded/minhnguyet/2022_05_10/an-kieng-9141.jpg", 1, null },
                    { new Guid("8d980ec3-d3da-43a6-a8d7-1b4c8dfb01b6"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7112), null, "Cầu Lông", 0, null, "https://vecgroup.vn/images/products/2021/08/24/large/qua-cau-long_1629778779.jpg", 0, null },
                    { new Guid("94103628-8339-4ce8-bd56-ec8fdcc5ba11"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7132), null, "Khoa học", 0, null, "https://www.training.com.au/wp-content/uploads/science-stem-feature.png", 0, null },
                    { new Guid("9767fa26-f187-49e2-a84a-ab43dce23080"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7202), null, "Có trách nhiệm", 0, null, null, 3, null },
                    { new Guid("9b8699ba-4196-4adb-b905-679ed35ca9df"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7161), null, "Cải thiện sức bền", 0, null, "https://vinmec-prod.s3.amazonaws.com/images/20210524_085806_814180_chay-bo-bao-nhieu-cal.max-800x800.jpg", 1, null },
                    { new Guid("a88465bb-ad4e-4089-9aa7-b7a98f66e0ee"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7172), null, "HIIT", 0, null, "https://hips.hearstapps.com/hmg-prod/images/athletes-doing-push-ups-with-dumbbells-on-floor-royalty-free-image-1638463573.jpg", 2, null },
                    { new Guid("a9199340-687e-4252-8784-8aee0eea0782"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7156), null, "Phòng tránh bệnh", 0, null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQv509Yw7GUN5twNNk4G5Pvu1TBqFmhrL_3UQ&s", 1, null },
                    { new Guid("b10f4948-ef5b-4795-a536-e84fc4fc075e"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7219), null, "Năng động", 0, null, null, 4, null },
                    { new Guid("b529e72b-9b1c-41da-8222-3e5effc5122a"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7197), null, "Cung cấp giá cả phải chăng", 0, null, null, 3, null },
                    { new Guid("b6e8abbb-a918-4dd0-ae74-382917f483a3"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7237), null, "Độc thân lâu năm", 0, null, null, 4, null },
                    { new Guid("b742b66c-2697-49da-8c1c-8164ad38337d"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7216), null, "Vui tính, hài hước", 0, null, null, 4, null },
                    { new Guid("b888a39f-3972-4fab-b4f7-108513786392"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7232), null, "Rảnh rỗi", 0, null, null, 4, null },
                    { new Guid("bb8331f0-d5af-413d-9ba1-c0a250a26d8a"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7149), null, "Sống Ảo", 0, null, "https://imagev3.vietnamplus.vn/w1000/Uploaded/2024/hotnnz/2024_08_13/song-ao3-6646.jpg.webp", 0, null },
                    { new Guid("bbb2033c-5ab2-4f4a-8428-7637418ed3a7"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7177), null, "Cùng giới", 0, 1, null, 3, null },
                    { new Guid("bcd05733-a4be-4a63-aea4-ef92d74ba003"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7224), null, "Nhút nhát", 0, null, null, 4, null },
                    { new Guid("bfe59242-8e71-42b6-9081-ad785c8b3486"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7114), null, "Bóng chuyền", 0, null, "https://file.hstatic.net/200000333667/article/image.jpg_4b1e1c8ce20f4c32824f275f34ff30af_1024x1024.jpg", 0, null },
                    { new Guid("cb616407-a5db-4f3e-80c5-dd041f3be4e9"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7124), null, "Phim ảnh", 0, null, "https://lawnet.vn/uploads/image/2023/10/17/015815855.jpg", 0, null },
                    { new Guid("d7859643-898a-4973-90e2-db224879eb7c"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7196), null, "Ngoại hình đẹp", 0, null, null, 3, null },
                    { new Guid("d878a181-b6ab-40c0-836e-2451229cda9b"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7217), null, "Hòa đồng", 0, null, null, 4, null },
                    { new Guid("d8ee32ca-1d48-4b93-878b-924f9b492fa3"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7225), null, "Nhạy cảm", 0, null, null, 4, null },
                    { new Guid("dc99a08a-a4a2-4793-bdcf-dca797cab101"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7236), null, "Dễ bị khó chịu", 0, null, null, 4, null },
                    { new Guid("dd9fb7b1-d2b3-4720-bee6-3a7b67f23ed6"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7223), null, "Lạnh lùng, ít nói", 0, null, null, 4, null },
                    { new Guid("dfe30c50-675b-4192-8e97-63c9050aa668"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7138), null, "Nghe nhạc", 0, null, "https://static.vecteezy.com/system/resources/thumbnails/037/044/052/small_2x/ai-generated-studio-shot-of-black-headphones-over-music-note-explosion-background-with-empty-space-for-text-photo.jpg", 0, null },
                    { new Guid("e6f418bf-df3d-48f8-aade-f8fd27639db1"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7227), null, "Dễ nản", 0, null, null, 4, null },
                    { new Guid("f0d91cfe-dfad-4dc1-82b7-6b4a1aa4d9d1"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7119), null, "Thể thao nói chung", 0, null, "https://llv.edu.vn/media/2018/09/iStock-949190756-800x440.jpg", 0, null },
                    { new Guid("f1e6243b-2826-4ba7-928a-75a036e0ff22"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7147), null, "Địa lý", 0, null, "https://www.aag.org/wp-content/uploads/2021/12/shutterstock_1111879247.jpg", 0, null },
                    { new Guid("f348b46a-539b-4e0f-9c3a-7fd7a15a2fe4"), "123abc", new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(7111), null, "Bơi lội", 0, null, "https://file.hstatic.net/1000391576/file/boi_loi_7d4d69c53ac1494eabb2a446d4d503a0_grande.jpg", 0, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "101jkl",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(6880), new Guid("9eb7c5f3-bba3-44c8-a1d6-4fb10e027e99") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "123abc",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(6822), new Guid("d6f01fd6-d848-418b-8dd8-6169ec15c575") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "202mno",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(6885), new Guid("8b5913a1-6e0e-46b2-ae58-25c57a33e59e") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "303pqr",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(6889), new Guid("975b552b-f8f2-48bf-b5e1-09a6f222a292") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "404stu",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(6903), new Guid("dbfd485a-cbbb-42f7-ad6a-d165ba82c828") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "456def",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(6865), new Guid("6d3f1997-6be8-489f-9915-18c99f53f76d") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "505vwx",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(6909), new Guid("c38653b4-abec-4707-b57a-72e9075b7da0") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "606yza",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(6913), new Guid("b50aa7ec-4e08-4761-80d6-ce7ecf470172") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "707bcd",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(6918), new Guid("c51f83e4-2f6b-4999-b0d7-fc7268b6c74c") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "789ghi",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 10, 6, 7, 43, 19, 306, DateTimeKind.Utc).AddTicks(6875), new Guid("a03d0b49-caa9-4fa9-9445-167dd8de63b1") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("9897dcd4-39e9-403b-beb5-ffe5aa28e888"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("a09462a9-397c-4a59-8fe1-985a78800a3d"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00d69c03-d1a7-4cc2-b2a6-84619043d98e"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("05890b90-ff66-448a-bf5c-c6d7141b1ba3"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("08f67f61-c3d8-4232-bb27-2698b56cb2c2"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("0db2c9d3-9a72-483b-a3ff-f7206464ed29"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("0f660a55-c30b-4f54-bdce-8006607bd0a1"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("16ab40c9-6143-4632-a802-c235db7e5d0f"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("17b071c9-d55c-4d26-bcf6-b687bd06a970"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("1cb5f947-291b-4189-b680-36d6a9572e65"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("1d25b391-6df0-4da3-9184-622e9274de6b"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("20756b72-fd94-4727-a169-70cef18697c9"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("21cf4f6a-1757-4d5a-814f-d867be8b90f3"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("238af788-8505-4736-94bc-b02974891cc8"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("25a3e31f-6be6-42d0-8e04-20a3c87876bf"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("2b46d75f-d748-4aee-b0a1-140c9cf64d1a"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("2b709d84-e994-494f-9130-669ba99a06e5"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("2f83a40e-2bc9-4986-b432-7fc719f09e9e"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("320b0cea-352e-4a30-91cd-8d01fc1960e1"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("38a54284-e1a4-4e57-adbd-14d0ff362269"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("3abe01a8-937f-4e4e-bda5-325d660fe4b1"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("3dfd865b-29c0-407e-9669-a88c36d8d7ca"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("410c496c-41cd-4ba5-8661-f60b050bc7ef"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("47a9e6c0-9215-4dae-b48d-2bffb5f71d9e"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("4beeb98a-9a91-41d0-9fbb-c0087a07e3fb"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("540ee3fc-7ae0-4407-991d-eacce9779824"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("56acf317-2be6-4e09-9e8d-62bf4d0424a3"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("56cdcfb2-4331-4bc9-a25e-74c470adf1e7"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("576929ce-c125-435b-a886-e18251064fcb"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("58053e66-d002-4d84-88c6-7a2350623c28"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("5945872f-6d7d-4faa-b51a-24935eed4eeb"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("5ad3fa2a-34cc-4db1-bd11-badf1bfdeb6b"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("5bad94de-2459-48e8-bf9f-2669d56f5707"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("607b9ea0-6a51-47c3-a57d-e246a2d5b1c5"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("609a3f99-2652-4c8f-989a-8405db6c0479"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("67cb813e-3b6f-494c-bd5c-ebb88b8115e9"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("6a6fa207-d3ad-4fae-b641-552b32aeee53"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("70b03f5b-ac6e-45d5-a1fb-fe19e8d9e06c"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("71230e63-8f0c-4eb9-902a-a169b195d73f"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("7479e06c-4f33-4a4c-b7bd-996fc6e3bca9"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("77e699f7-b9e8-49d4-8c53-a15ca5327c31"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("79236e17-fe1f-4382-bc2e-6a22b3e6e07c"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("7ac19a30-5611-4294-b1c0-8c4fe87070e0"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("7b47d3dc-5ed7-4987-aadc-eceba4b6eee0"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("7ca2d7b4-7f7d-4dc2-96fb-cc91066e35b8"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("7da317b7-1a37-44bd-a77a-d9e4b94a9a1b"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("7eecea45-87da-4638-8928-83d06a14c656"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("8274bcf3-ce63-446a-9f6f-ffa6f06d454b"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("82ec8cef-22ed-4d77-9691-79a2093be7a6"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("83c6bd6f-ab3a-43f3-8464-9a5eb52ffee9"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("8650da68-06bf-4abd-9bf5-fd1ce302790e"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("8d980ec3-d3da-43a6-a8d7-1b4c8dfb01b6"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("94103628-8339-4ce8-bd56-ec8fdcc5ba11"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("9767fa26-f187-49e2-a84a-ab43dce23080"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("9b8699ba-4196-4adb-b905-679ed35ca9df"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("a88465bb-ad4e-4089-9aa7-b7a98f66e0ee"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("a9199340-687e-4252-8784-8aee0eea0782"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("b10f4948-ef5b-4795-a536-e84fc4fc075e"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("b529e72b-9b1c-41da-8222-3e5effc5122a"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("b6e8abbb-a918-4dd0-ae74-382917f483a3"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("b742b66c-2697-49da-8c1c-8164ad38337d"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("b888a39f-3972-4fab-b4f7-108513786392"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("bb8331f0-d5af-413d-9ba1-c0a250a26d8a"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("bbb2033c-5ab2-4f4a-8428-7637418ed3a7"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("bcd05733-a4be-4a63-aea4-ef92d74ba003"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("bfe59242-8e71-42b6-9081-ad785c8b3486"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("cb616407-a5db-4f3e-80c5-dd041f3be4e9"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("d7859643-898a-4973-90e2-db224879eb7c"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("d878a181-b6ab-40c0-836e-2451229cda9b"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("d8ee32ca-1d48-4b93-878b-924f9b492fa3"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("dc99a08a-a4a2-4793-bdcf-dca797cab101"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("dd9fb7b1-d2b3-4720-bee6-3a7b67f23ed6"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("dfe30c50-675b-4192-8e97-63c9050aa668"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("e6f418bf-df3d-48f8-aade-f8fd27639db1"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("f0d91cfe-dfad-4dc1-82b7-6b4a1aa4d9d1"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("f1e6243b-2826-4ba7-928a-75a036e0ff22"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("f348b46a-539b-4e0f-9c3a-7fd7a15a2fe4"));

            migrationBuilder.DropColumn(
                name: "PricePerSlot",
                table: "Trainings");

            migrationBuilder.InsertData(
                table: "EmailTemplates",
                columns: new[] { "Id", "Body", "CreatedDate", "DeletedDate", "Description", "Name", "Params", "RecordStatus", "Status", "Subject", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("7795bebb-04d6-4ed5-90ca-cb05cdef1ce0"), "Chúng tôi đã nhận được yêu cầu đặt lại mật khẩu cho tài khoản của bạn tại FitWipe. Kính gửi [Name], vui lòng đặt lại mật khẩu của bạn bằng cách nhấn vào đường link sau: <a href=\"[ResetPasswordLink]\">Đặt lại mật khẩu</a>.<br><br>Nếu bạn không yêu cầu việc này, vui lòng bỏ qua email này.<br><br>Đội ngũ FitWipe", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5256), null, "Email này được gửi khi người dùng yêu cầu đặt lại mật khẩu cho tài khoản FitWipe.", "Forgot_Password", "[Name], [ResetPasswordLink]", 0, true, "Yêu cầu đặt lại mật khẩu FitWipe", null },
                    { new Guid("8b50cb5e-051c-494a-bda3-4f019eadcd24"), "Chào mừng bạn đến với FitWipe! Kính gửi [Name], vui lòng xác nhận địa chỉ email của bạn bằng cách nhấn vào đường link sau: <a href=\"[VerificationLink]\">Xác nhận Email</a>.<br><br>Cảm ơn bạn đã tham gia cùng chúng tôi!<br><br>Đội ngũ FitWipe", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5242), null, "Email này được gửi để xác nhận đăng ký tài khoản FitWipe.", "Register_Mail", "[Name], [VerificationLink]", 0, true, "Chào mừng đến với FitWipe! Vui lòng xác nhận email của bạn", null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreateById", "CreatedDate", "DeletedDate", "Name", "RecordStatus", "SpecialTag", "TagImage", "TagType", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("01e44d37-1c36-4fbe-9338-e500fd2d9842"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5069), null, "Chơi nhạc cụ", 0, null, "https://t3.ftcdn.net/jpg/01/34/38/92/360_F_134389281_5Jak3tbsoDggHIfIKKwJ8L7064ACIMNE.jpg", 0, null },
                    { new Guid("02f66d5e-1bc9-4677-8f7c-f0288a1f8225"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5060), null, "Khoa học", 0, null, "https://www.training.com.au/wp-content/uploads/science-stem-feature.png", 0, null },
                    { new Guid("0528a934-f63c-49eb-8feb-898ced63aad5"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5082), null, "Có body chuẩn chỉnh", 0, null, "https://cdn.nhathuoclongchau.com.vn/unsafe/800x0/https://cms-prod.s3-sgn09.fptcloud.com/fitness_la_gi_loi_ich_va_phuong_phap_tap_luyen_fitness_1_3c4e094223.png", 1, null },
                    { new Guid("091bdd48-5a0c-4bb7-8f28-6e66227933a4"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5145), null, "Năng động", 0, null, null, 4, null },
                    { new Guid("0c1d6c22-7426-478c-b327-76e9b99f1101"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5107), null, "Cải thiện sức khỏe tổng quát", 0, null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcThCjFemkP0h0IZYpu31k-xGK9IvigaysteqA&s", 1, null },
                    { new Guid("0c65dcd8-6e0d-49a5-a9f7-2975ce556dd5"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5134), null, "Giàu kiến thức", 0, null, null, 3, null },
                    { new Guid("0dfe4292-b8e6-41e2-874f-794d29672e49"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5160), null, "Thoải mái", 0, null, null, 4, null },
                    { new Guid("1031aed2-1958-43e9-a2e5-2dda19c24e21"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5157), null, "Hiền lành", 0, null, null, 4, null },
                    { new Guid("1273b61f-fa13-4db0-b640-25aa59f88ce4"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5138), null, "Đảm bảo mục tiêu cho học viên", 0, null, null, 3, null },
                    { new Guid("15d6e5db-db2e-4f69-8ca9-675bc9336a10"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5099), null, "Cải thiện tình trạng bệnh", 0, null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQv509Yw7GUN5twNNk4G5Pvu1TBqFmhrL_3UQ&s", 1, null },
                    { new Guid("1c634ecc-4a7d-4fbd-a51c-6538723bf4ef"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5129), null, "Có trách nhiệm", 0, null, null, 3, null },
                    { new Guid("2039b40b-5694-4a80-9ba0-85d0db8ef1c0"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5104), null, "Cải thiện sức bền", 0, null, "https://vinmec-prod.s3.amazonaws.com/images/20210524_085806_814180_chay-bo-bao-nhieu-cal.max-800x800.jpg", 1, null },
                    { new Guid("22a7b666-d402-43c6-83a4-f66463ac0c80"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5073), null, "Lịch Sử", 0, null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRWz_tIgvQXPAaSmvYa7CqZo_biaRK9D_O8uA&s", 0, null },
                    { new Guid("23508eeb-cb8a-4c80-9a04-f2b19485a2d5"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5147), null, "Thi thoảng bất thường", 0, null, null, 4, null },
                    { new Guid("3030bc86-8da6-45ea-b29a-1250fe19a2ef"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5154), null, "Hay bị lười", 0, null, null, 4, null },
                    { new Guid("31493839-107b-4eed-994b-70083c406780"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5146), null, "Dễ gần", 0, null, null, 4, null },
                    { new Guid("40e65f78-259f-428d-9722-e0676b7b0420"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5116), null, "Tập ép dẻo", 0, null, "https://prod-everyoneactive-wp.s3.eu-west-2.amazonaws.com/wp-content/uploads/2020/03/23151503/flexibility-at-home.jpg", 2, null },
                    { new Guid("40fce20f-fd76-496e-899c-bb0b1ef44007"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5079), null, "Quản lý cân nặng", 0, null, "https://thanhnien.mediacdn.vn/Uploaded/minhnguyet/2022_05_10/an-kieng-9141.jpg", 1, null },
                    { new Guid("41de4518-b4a1-48c9-a188-9348fc209c86"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5137), null, "Biết truyền cảm hứng, tạo động lực", 0, null, null, 3, null },
                    { new Guid("4597cbf3-3bef-45cb-be67-1d5ef3a02f22"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5075), null, "Triết học", 0, null, "https://www.rollingstone.com/wp-content/uploads/2024/01/unlocking_the_power_why_you_should_consider_hiring_philosophy_graduates-.jpg", 0, null },
                    { new Guid("45df85e6-60b4-4fb5-baa0-25b0613567fa"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5049), null, "Tập Gym", 0, null, "https://tiki.vn/blog/wp-content/uploads/2023/07/elite-fitness-1024x583.jpg", 0, null },
                    { new Guid("46b447b8-d5b2-416d-a900-7d73d487d138"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5108), null, "Yoga / Pilates", 0, null, "https://thamtapyoga.vn/wp-content/uploads/2024/01/3-2.jpeg", 2, null },
                    { new Guid("483953df-edb8-4921-82f7-a52e6e6161d0"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5144), null, "Hòa đồng", 0, null, null, 4, null },
                    { new Guid("4f0d3b18-11b8-4e7f-8b59-57886e339a59"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5112), null, "Cardio", 0, null, "https://file.hstatic.net/1000308068/file/tap-cardio-vao-luc-nao-la-hieu-qua-nhat_cb884317c05d4df980138121ee113112_grande.jpg", 2, null },
                    { new Guid("5513ccc4-abfc-46cc-be90-922f5269b9cb"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5132), null, "Có kinh nghiệm", 0, null, null, 3, null },
                    { new Guid("5537d6ce-f8e1-46f3-a71e-2556685d76ba"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5065), null, "Hội họa", 0, null, "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ea/Van_Gogh_-_Starry_Night_-_Google_Art_Project.jpg/1200px-Van_Gogh_-_Starry_Night_-_Google_Art_Project.jpg", 0, null },
                    { new Guid("5ce3fdd3-c542-47ef-ab44-dcc5fd92043a"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5128), null, "Tâm huyết với học viên", 0, null, null, 3, null },
                    { new Guid("5dbd9f89-6e6a-40de-9712-054efde207d4"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5064), null, "Nhiếp ảnh", 0, null, "https://aaftonline.com/blog/wp-content/uploads/2024/01/What-are-the-Benefits-of-Photography-Complete-Overview.png", 0, null },
                    { new Guid("5e8f3e2c-31c2-4f94-89a6-ed5ca847844c"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5055), null, "Truyện tranh", 0, null, "https://taschen.makaira.media/taschen/image/upload/f_webp,w_1200/v1673462260/products-live/a3d446fb0046b587eb0ed76edca3f4d6.jpg", 0, null },
                    { new Guid("5fb2621c-433f-4e11-a7ab-a31b7739c638"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5165), null, "Độc thân lâu năm", 0, null, null, 4, null },
                    { new Guid("5fbbfd5a-f7ab-406a-b718-5e2bff17c05c"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5159), null, "Cầu toàn", 0, null, null, 4, null },
                    { new Guid("66c87631-c884-45b7-b287-9fa32d29bf44"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5113), null, "HIIT", 0, null, "https://hips.hearstapps.com/hmg-prod/images/athletes-doing-push-ups-with-dumbbells-on-floor-royalty-free-image-1638463573.jpg", 2, null },
                    { new Guid("6b49aeba-26f5-42b8-82a1-ea49ff236e19"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5045), null, "Bóng rổ", 0, null, "https://thethaothienlong.vn/wp-content/uploads/2022/04/Kich-thuoc-qua-bong-ro-1.jpg", 0, null },
                    { new Guid("6e1d311f-7367-490a-a4c8-1a2496352eac"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5062), null, "Game", 0, null, "https://genk.mediacdn.vn/139269124445442048/2022/7/28/tmb-1658998970448906989995.jpg", 0, null },
                    { new Guid("6f17f023-5c61-462c-b0be-e80856567660"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5119), null, "Thể dục nhịp điệu, theo nhạc", 0, null, "https://i.vietgiaitri.com/2018/10/9/the-duc-nhip-dieu-b2ab9f.jpg", 2, null },
                    { new Guid("7555638f-08a8-42c9-bf94-6f85ad87161b"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5077), null, "Sống Ảo", 0, null, "https://imagev3.vietnamplus.vn/w1000/Uploaded/2024/hotnnz/2024_08_13/song-ao3-6646.jpg.webp", 0, null },
                    { new Guid("78c7a6a5-2623-4864-94f3-9b786b58334e"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5158), null, "Rảnh rỗi", 0, null, null, 4, null },
                    { new Guid("7ba189e6-a800-49bf-9219-89e2b62f3a21"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5058), null, "Thể thao trí tuệ", 0, null, "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6f/ChessSet.jpg/640px-ChessSet.jpg", 0, null },
                    { new Guid("7c5c7f9a-85c8-424c-9417-d1fc61f87bef"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5035), null, "Bóng đá", 0, null, "https://cdn.tuoitre.vn/ttct//2020/12/13/16078750289060-lich-thi-dau-bong-da-hom-nay-0211.jpg", 0, null },
                    { new Guid("87a799d7-578a-4723-a063-fde568bf2b97"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5072), null, "Công nghệ", 0, null, "https://www.simplilearn.com/ice9/free_resources_article_thumb/Technology_Trends.jpg", 0, null },
                    { new Guid("87d5739b-f7ac-4c87-846d-6576e0fbc57c"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5150), null, "Nhút nhát", 0, null, null, 4, null },
                    { new Guid("8ab32dc6-80ee-4c46-9b7f-4e4f4c4e6fae"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5059), null, "Đọc sách", 0, null, "https://images.theconversation.com/files/45159/original/rptgtpxd-1396254731.jpg?ixlib=rb-4.1.0&q=45&auto=format&w=1356&h=668&fit=crop", 0, null },
                    { new Guid("8f2e6a12-908a-4885-8979-079b3ce3b574"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5123), null, "Khác giới", 0, 0, null, 3, null },
                    { new Guid("8f3355de-e591-45ed-b6a0-69ef75e44e2e"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5115), null, "Kickfit", 0, null, "https://storage.googleapis.com/leep_app_website/2020/11/Kick-fit-khong-phai-la-kick-boxing.jpg", 2, null },
                    { new Guid("8f464ea8-fa70-407d-84fb-0f9bc240cd7d"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5074), null, "Địa lý", 0, null, "https://www.aag.org/wp-content/uploads/2021/12/shutterstock_1111879247.jpg", 0, null },
                    { new Guid("9d8887af-9fe0-4af6-a5fc-c2691da6b6ee"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5068), null, "Nghe nhạc", 0, null, "https://static.vecteezy.com/system/resources/thumbnails/037/044/052/small_2x/ai-generated-studio-shot-of-black-headphones-over-music-note-explosion-background-with-empty-space-for-text-photo.jpg", 0, null },
                    { new Guid("a13f9896-b95f-46ef-ad7b-3e7aa5322a86"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5048), null, "Bida", 0, null, "https://billiardshoanthuy.vn/wp-content/uploads/2021/05/phu-kien-ban-bida-2.jpg", 0, null },
                    { new Guid("a16c68c3-9500-4a3c-9551-5d0133a96d36"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5042), null, "Cầu Lông", 0, null, "https://vecgroup.vn/images/products/2021/08/24/large/qua-cau-long_1629778779.jpg", 0, null },
                    { new Guid("a44c9f0e-5b16-4f88-ba5f-ccb195f7ff2c"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5101), null, "Tăng cảm giác hạnh phúc, giảm căng thẳng", 0, null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT8ZXc_bemAYbupxmGz0pZGy4L1Zr6hGVsYdA&s", 1, null },
                    { new Guid("a54a35c7-abf1-43b4-a437-cde306fbf851"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5126), null, "Gần", 0, 2, null, 3, null },
                    { new Guid("a5b23d75-9325-4164-ba61-8067af862c74"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5070), null, "Tán gẫu", 0, null, "https://transcode-v2.app.engoo.com/image/fetch/f_auto,c_lfill,w_300,dpr_3/https://assets.app.engoo.com/images/rGTEEA2fm66YMzeJz2UbwkKOW62bZVlqKOKZrXlMN7g.jpeg", 0, null },
                    { new Guid("ac874c07-444f-4624-9605-c384b616d7f1"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5043), null, "Bóng chuyền", 0, null, "https://file.hstatic.net/200000333667/article/image.jpg_4b1e1c8ce20f4c32824f275f34ff30af_1024x1024.jpg", 0, null },
                    { new Guid("b0bfa20d-50d0-42f0-befc-6cde9ec21d5c"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5143), null, "Vui tính, hài hước", 0, null, null, 4, null },
                    { new Guid("b25f4bd0-ddd1-483c-9d7e-1670b30d321f"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5136), null, "Luôn sẵn sàng tư vấn ngoài giờ", 0, null, null, 3, null },
                    { new Guid("b4de45ba-fc81-49e5-9eb1-5bf7550f08fa"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5081), null, "Phát triển cơ bắp", 0, null, "https://www.dmoose.com/cdn/shop/articles/feature-image_87a28752-6da3-4be8-8814-d5221236136d.jpg?v=1676644951", 1, null },
                    { new Guid("bade1927-ca85-4aa9-88df-6fd9494aa4f9"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5056), null, "Du lịch", 0, null, "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/18/4f/7d/fc/caption.jpg?w=1200&h=1200&s=1", 0, null },
                    { new Guid("bbb9d9f6-bdcb-4988-81ee-f103200e4939"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5156), null, "Sẵn sàng học hỏi", 0, null, null, 4, null },
                    { new Guid("ca5907cd-cfc5-4de7-83f9-a9d46c535b21"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5151), null, "Nhạy cảm", 0, null, null, 4, null },
                    { new Guid("cfd0739f-e268-4bda-b01a-b122be6a32fb"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5124), null, "Ngoại hình đẹp", 0, null, null, 3, null },
                    { new Guid("d6da0e93-5616-4412-b2d8-5e66ad137ae9"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5052), null, "Phim ảnh", 0, null, "https://lawnet.vn/uploads/image/2023/10/17/015815855.jpg", 0, null },
                    { new Guid("d7fbfd28-dcef-4a2e-86fd-77ddac2d158d"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5139), null, "Kiên trì", 0, null, null, 4, null },
                    { new Guid("d847ac9f-a4f5-41a1-8e83-814f773552e6"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5120), null, "Cùng giới", 0, 1, null, 3, null },
                    { new Guid("d9387c24-2d9b-4a35-be6c-b7d19bcedab7"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5125), null, "Cung cấp giá cả phải chăng", 0, null, null, 3, null },
                    { new Guid("d96c2fcc-a7f5-4db0-b747-43bc5a0a8476"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5111), null, "Tập sức mạnh", 0, null, "https://www.thethaothientruong.vn/uploads/2020/Powerlifting-la-gi.jpg", 2, null },
                    { new Guid("de2f8334-7769-4159-bfc7-71ad7c522044"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5153), null, "Dễ nản", 0, null, null, 4, null },
                    { new Guid("e0a483b0-ca14-47c4-8e84-78e898ea160b"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5162), null, "Dễ bị khó chịu", 0, null, null, 4, null },
                    { new Guid("e4466e92-50fc-4382-947c-b8596e3f10d1"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5051), null, "Đi, chạy bộ", 0, null, "https://pos.nvncdn.com/be3294-43017/art/artCT/20230228_9uObLfWys7Q0IXe4.jpg", 0, null },
                    { new Guid("e695d66a-d9c7-43e0-9ed9-95fdfc88ad05"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5038), null, "Bơi lội", 0, null, "https://file.hstatic.net/1000391576/file/boi_loi_7d4d69c53ac1494eabb2a446d4d503a0_grande.jpg", 0, null },
                    { new Guid("e7ca93ec-9bd9-49dd-92bf-60ce36b1d919"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5083), null, "Phòng tránh bệnh", 0, null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQv509Yw7GUN5twNNk4G5Pvu1TBqFmhrL_3UQ&s", 1, null },
                    { new Guid("ec0da361-6c9c-41c5-bd3a-5c68f2aa1cf6"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5047), null, "Thể thao nói chung", 0, null, "https://llv.edu.vn/media/2018/09/iStock-949190756-800x440.jpg", 0, null },
                    { new Guid("ef0a67de-2974-4c4e-886d-376a5379a013"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5133), null, "Không nặng nề với học viên", 0, null, null, 3, null },
                    { new Guid("f036a951-f70c-429a-add1-7a8d00fdc51f"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5140), null, "Siêng năng", 0, null, null, 4, null },
                    { new Guid("f6a6727d-9e3c-4289-8871-a630b37bd032"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5103), null, "Cải thiện sự dẻo dai", 0, null, "https://cdn.shopify.com/s/files/1/0453/0381/files/fullsizeoutput_2d4_1024x1024.jpg?v=1662646979", 1, null },
                    { new Guid("ffcc9b69-437c-4ddf-9c8e-4fdcd9e52807"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5149), null, "Lạnh lùng, ít nói", 0, null, null, 4, null },
                    { new Guid("ffdfbad1-7525-4246-8f9a-6e0e62af0997"), "123abc", new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(5110), null, "Calisthenic", 0, null, "https://cdn.nhathuoclongchau.com.vn/unsafe/800x0/https://cms-prod.s3-sgn09.fptcloud.com/giai_dap_thac_mac_calisthenics_khac_gi_gym_1_8d5dd4026b.jpg", 2, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "101jkl",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(4875), new Guid("7f3e397a-7e1a-44ba-a3a2-cc5dda6d6844") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "123abc",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(4806), new Guid("5f8cac23-52e1-4277-a3a7-ba27c44731ad") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "202mno",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(4890), new Guid("5e17953c-d58b-4f93-b8eb-b6bc07c04295") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "303pqr",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(4894), new Guid("99717835-3487-433d-92b9-91c3d1d203eb") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "404stu",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(4899), new Guid("16ffe082-0093-468b-a83c-b04cda21ca0c") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "456def",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(4859), new Guid("1da72a7f-841f-4ec1-bf1e-1715c9f6fc08") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "505vwx",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(4927), new Guid("e0e8f5d1-7f4d-4d38-972e-2dc01400937e") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "606yza",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(4933), new Guid("513925a4-eed4-42eb-a52b-6c5d5e6b65d9") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "707bcd",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(4938), new Guid("c43f39bc-6d48-4c0e-9b23-cf85682aaf2b") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "789ghi",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 10, 6, 7, 40, 21, 930, DateTimeKind.Utc).AddTicks(4870), new Guid("33fcaaf5-9833-4d81-b4f7-4893f3a47e8a") });
        }
    }
}
