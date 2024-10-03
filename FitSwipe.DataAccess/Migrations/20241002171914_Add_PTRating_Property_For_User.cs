using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FitSwipe.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Add_PTRating_Property_For_User : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("4d222663-cdd6-4d27-a639-7318527a5747"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("8200b207-320e-4009-9013-408ed7689bfe"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("0a55b36a-6724-4dee-988f-61100b2800a4"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("0c1b8083-8501-49d3-adda-32c9eafccdf3"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("0cdeed83-8255-4604-9a9e-f9c9bded2d69"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("10ccf78a-8ec0-412b-97c2-662638191b1e"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("10f150d1-fd71-49c5-853e-c6f9effef006"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("1419f9dd-cdc4-4cd0-83d3-0751e8819c98"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("15c7ae90-0f99-425f-b68a-55a71f7f7e5c"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("1f416dd7-0574-4ca5-9c90-d5e25887fa31"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("2ab03b2d-9719-47d3-ac0e-42dfae1c2bcc"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("341486ff-388a-4fe6-ad82-c3f1cbf1707b"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("359fd7d1-b677-4466-9a95-6b38fbf31d93"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("3f96abc2-fe8e-4979-b97a-be10cc738d69"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("4265e2cc-ada7-455b-97aa-9099fb08898b"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("4281e1ac-1e01-4427-89da-5fed7e508134"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("4467e761-8019-4553-a341-d566a947481d"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("4533834e-c2ac-40e6-9b68-6d9c87555782"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("459d5ce9-1b28-411d-bf97-41f4f51dcb88"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("4d025b36-2508-453e-a489-e77d957cbea3"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("4e778b7c-71cf-4b78-ae12-c080173554ce"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("502fc407-33c7-4131-b072-28f232103e4c"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("50d1d2f7-bef5-401b-bf74-4ebccc75a4f5"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("51242843-b319-41f3-8c0b-2c19527d4a80"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("51f59bde-22fe-44bf-9626-80c0c05c94f4"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("534a662c-27e8-4ac2-bd25-ffc32a359217"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("55fbd02d-6ada-4db9-8c95-594b58499774"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("5b9217df-a281-478d-a2f5-636dcf72e37b"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("5defc1ab-b478-478b-8200-ec9e8aecf063"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("5fec8c08-536b-4297-83d7-1fc855e118af"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("60ac450f-3092-4c51-9f6c-34d81135784e"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("6a404cb0-ded4-4fbe-b8e4-bebd9e1c1cea"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("713957b5-28a9-4629-9f44-25f1e0e397c4"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("72ab2e02-54ef-4e1d-a6e3-32d5cd47cce4"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("7933b2c4-cc49-49c2-8b29-1b0c61bc0b31"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("7a2f5587-118f-4aa4-93bb-f9f46b85ffd0"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("7b2a3c7e-ecf0-4f74-9991-bf27b9cfe111"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("7c2437e3-7c04-48b5-bee4-df8ef183bb28"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("852cc1cf-df2e-4121-955c-45a4abc11c0d"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("8741c577-0b21-4944-9e38-d8ce96b48b9e"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("898e1305-9c4a-4eaa-8c1f-4f8f84eb087f"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("89b3f17f-eb3b-4802-9fb2-694390b174f0"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("9713930e-eb53-4f10-a2f9-826de2391553"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("9ad8f365-0dbc-4853-905f-02992fa3b818"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("9ada5b53-df39-4c05-999c-c2b72c0c2197"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("9d6f15c3-6155-44f4-ad56-de2958e27c25"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("a12605f1-f2ca-4fcc-97aa-fce26516d99a"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("a3aaa9d9-bdca-4c4c-954d-170d5c8f7a81"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("a3b16ebb-d032-4f88-99b0-0b496cd372d8"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("a4082a9f-569c-40fc-8ab9-8ce1a61141e7"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("a7e7dec8-23df-4b23-9955-59e4387da4b1"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("ad211a7c-727e-4fee-8eb3-c4691f8bd1a4"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("b3c2692c-4f42-41ed-aa1e-f85e50505eee"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("b58b0973-c8f8-46ef-9f3a-bc18cb1675b7"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("b711a2c9-e7d6-412c-8a2c-bef183546309"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("b82eb77c-8176-486e-b1f8-093689bae3d3"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("bac36144-8194-4b91-bace-252238ea49eb"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("baf752b8-c11e-4f9a-986a-95522cd0ef1c"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("bdd29ba3-56bb-4309-9176-b01688821fc1"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("bf952303-dc7b-4793-9f24-d22bf39abd6e"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("bff84c4b-63fa-473c-ac6a-39397ac82b59"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("c20c44f1-1cbb-4131-bb40-6c2b013b1d6f"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("c839cb64-10f2-4c48-af1a-05812679ef77"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("ce32aa3e-3b02-4b37-8200-439456563e70"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("cf47b4e2-7f8f-4d3c-aa6e-841ee2f9d04c"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("d3679c29-3251-47ec-bd6f-7a7b861a90f9"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("d3a93747-f7e2-4ff8-be85-e4b8ec957b1c"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("d5cff4a7-293e-47a0-964f-87ab630bd0ea"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("e10e6946-7b2d-490a-bd06-593211ad4c41"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("e12be1c1-fb6d-4582-8c24-679ab9660202"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("e1c89aa7-4e6d-4f43-8b04-f268cdd1d0a5"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("e7654a7f-2c98-4d4e-a9f2-f44de9d4ca5d"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("f22748f5-71f9-4823-a1c9-4cda239b1fb2"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("f8efa17c-7c40-4090-bd4c-12cdb2eb57fa"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("faa4b885-e150-481e-a6e7-8886d0f93e44"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("fbc4934e-d7d0-40a8-a463-b832768945af"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("fd60bde3-a149-44e0-8a35-51d626ad19a4"));

            migrationBuilder.AddColumn<double>(
                name: "PTRating",
                table: "Users",
                type: "double precision",
                nullable: true);

            migrationBuilder.InsertData(
                table: "EmailTemplates",
                columns: new[] { "Id", "Body", "CreatedDate", "DeletedDate", "Description", "Name", "Params", "RecordStatus", "Status", "Subject", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("5911b672-54f8-4412-86b9-d4f08b54ef7b"), "Chúng tôi đã nhận được yêu cầu đặt lại mật khẩu cho tài khoản của bạn tại FitWipe. Kính gửi [Name], vui lòng đặt lại mật khẩu của bạn bằng cách nhấn vào đường link sau: <a href=\"[ResetPasswordLink]\">Đặt lại mật khẩu</a>.<br><br>Nếu bạn không yêu cầu việc này, vui lòng bỏ qua email này.<br><br>Đội ngũ FitWipe", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9755), null, "Email này được gửi khi người dùng yêu cầu đặt lại mật khẩu cho tài khoản FitWipe.", "Forgot_Password", "[Name], [ResetPasswordLink]", 0, true, "Yêu cầu đặt lại mật khẩu FitWipe", null },
                    { new Guid("5c895ba7-bc67-42e2-ba2b-cad9b87e982a"), "Chào mừng bạn đến với FitWipe! Kính gửi [Name], vui lòng xác nhận địa chỉ email của bạn bằng cách nhấn vào đường link sau: <a href=\"[VerificationLink]\">Xác nhận Email</a>.<br><br>Cảm ơn bạn đã tham gia cùng chúng tôi!<br><br>Đội ngũ FitWipe", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9727), null, "Email này được gửi để xác nhận đăng ký tài khoản FitWipe.", "Register_Mail", "[Name], [VerificationLink]", 0, true, "Chào mừng đến với FitWipe! Vui lòng xác nhận email của bạn", null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreateById", "CreatedDate", "DeletedDate", "Name", "RecordStatus", "SpecialTag", "TagImage", "TagType", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("02a358b6-a1fb-4c2a-bce9-b4a12b458813"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9433), null, "Cải thiện sức khỏe tổng quát", 0, null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcThCjFemkP0h0IZYpu31k-xGK9IvigaysteqA&s", 1, null },
                    { new Guid("06aec7ad-3198-4ac9-b584-b37da96736e6"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9471), null, "Cung cấp giá cả phải chăng", 0, null, null, 3, null },
                    { new Guid("088bba8a-409e-4a07-9dd0-b47489e6f496"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9539), null, "Rảnh rỗi", 0, null, null, 4, null },
                    { new Guid("097278be-7ebe-46b5-ba42-df99e4399ce8"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9355), null, "Lịch Sử", 0, null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRWz_tIgvQXPAaSmvYa7CqZo_biaRK9D_O8uA&s", 0, null },
                    { new Guid("0ba25be0-7fe0-451c-b56e-2ea70f417760"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9529), null, "Dễ nản", 0, null, null, 4, null },
                    { new Guid("163bbcd0-335f-47e4-b7b1-e2aff36aa259"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9503), null, "Siêng năng", 0, null, null, 4, null },
                    { new Guid("18ab40a7-a6f2-4eb6-8dc1-8f9d682513bd"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9439), null, "Calisthenic", 0, null, "https://cdn.nhathuoclongchau.com.vn/unsafe/800x0/https://cms-prod.s3-sgn09.fptcloud.com/giai_dap_thac_mac_calisthenics_khac_gi_gym_1_8d5dd4026b.jpg", 2, null },
                    { new Guid("18d16372-aaa8-4aab-84a7-9559b3bdd2e2"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9326), null, "Đọc sách", 0, null, "https://images.theconversation.com/files/45159/original/rptgtpxd-1396254731.jpg?ixlib=rb-4.1.0&q=45&auto=format&w=1356&h=668&fit=crop", 0, null },
                    { new Guid("1a0592bd-15db-4bbd-9029-d01af7faa4a3"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9304), null, "Bida", 0, null, "https://billiardshoanthuy.vn/wp-content/uploads/2021/05/phu-kien-ban-bida-2.jpg", 0, null },
                    { new Guid("1ebed850-7ce2-40d6-b6d7-3c9181e00963"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9517), null, "Thi thoảng bất thường", 0, null, null, 4, null },
                    { new Guid("1f73e933-4036-4e9f-bd6f-17a545fc6fca"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9381), null, "Tăng cảm giác hạnh phúc, giảm căng thẳng", 0, null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT8ZXc_bemAYbupxmGz0pZGy4L1Zr6hGVsYdA&s", 1, null },
                    { new Guid("227d340e-fb3c-4c44-b464-f51c0cf098d4"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9479), null, "Có trách nhiệm", 0, null, null, 3, null },
                    { new Guid("245b080a-2d2a-4594-adc8-056d5ec38960"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9284), null, "Bơi lội", 0, null, "https://file.hstatic.net/1000391576/file/boi_loi_7d4d69c53ac1494eabb2a446d4d503a0_grande.jpg", 0, null },
                    { new Guid("2ac5ef91-7a4a-4300-a9e1-64f21a50b5e6"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9332), null, "Game", 0, null, "https://genk.mediacdn.vn/139269124445442048/2022/7/28/tmb-1658998970448906989995.jpg", 0, null },
                    { new Guid("2baf74fa-2028-49ee-a940-2857994acfb1"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9550), null, "Độc thân lâu năm", 0, null, null, 4, null },
                    { new Guid("3068f395-42da-4a02-a2c0-40ddb8cf4115"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9453), null, "Tập ép dẻo", 0, null, "https://prod-everyoneactive-wp.s3.eu-west-2.amazonaws.com/wp-content/uploads/2020/03/23151503/flexibility-at-home.jpg", 2, null },
                    { new Guid("320a98a0-d222-438b-a93c-1c380ac5615d"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9436), null, "Yoga / Pilates", 0, null, "https://thamtapyoga.vn/wp-content/uploads/2024/01/3-2.jpeg", 2, null },
                    { new Guid("3511c9b0-c9b7-4926-9e02-a8c8df696a0e"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9510), null, "Hòa đồng", 0, null, null, 4, null },
                    { new Guid("372e941b-f4d5-4951-9587-6693f5dd1895"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9461), null, "Cùng giới", 0, 1, null, 3, null },
                    { new Guid("373744b9-6113-49d9-b444-244ef40ee0e6"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9473), null, "Gần", 0, 2, null, 3, null },
                    { new Guid("38189688-da95-41d4-a61f-b4f3c3aab849"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9487), null, "Không nặng nề với học viên", 0, null, null, 3, null },
                    { new Guid("3a6287a3-52e9-4c6b-8d39-9e99c4b63c02"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9484), null, "Có kinh nghiệm", 0, null, null, 3, null },
                    { new Guid("3d6c7462-c521-4a3e-be33-e620aa7cfc37"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9335), null, "Nhiếp ảnh", 0, null, "https://aaftonline.com/blog/wp-content/uploads/2024/01/What-are-the-Benefits-of-Photography-Complete-Overview.png", 0, null },
                    { new Guid("3f82fb98-c502-4f6f-ab51-052228cb5da4"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9379), null, "Cải thiện tình trạng bệnh", 0, null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQv509Yw7GUN5twNNk4G5Pvu1TBqFmhrL_3UQ&s", 1, null },
                    { new Guid("43d20cfb-d4f9-4ed0-8dbf-a1506a3f8f1f"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9360), null, "Triết học", 0, null, "https://www.rollingstone.com/wp-content/uploads/2024/01/unlocking_the_power_why_you_should_consider_hiring_philosophy_graduates-.jpg", 0, null },
                    { new Guid("43e4fda4-dd6c-4853-af47-4b3c42de0c1c"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9536), null, "Hiền lành", 0, null, null, 4, null },
                    { new Guid("46337243-38a3-4532-a826-6ff3c6feb1eb"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9498), null, "Đảm bảo mục tiêu cho học viên", 0, null, null, 3, null },
                    { new Guid("4c7230b9-8535-4e0a-88cf-92ec16257006"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9426), null, "Cải thiện sức bền", 0, null, "https://vinmec-prod.s3.amazonaws.com/images/20210524_085806_814180_chay-bo-bao-nhieu-cal.max-800x800.jpg", 1, null },
                    { new Guid("53b1b595-3484-4e9c-b489-22856308044f"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9298), null, "Bóng rổ", 0, null, "https://thethaothienlong.vn/wp-content/uploads/2022/04/Kich-thuoc-qua-bong-ro-1.jpg", 0, null },
                    { new Guid("5b3fdb23-caaa-4ecb-b468-9da40626caa7"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9312), null, "Phim ảnh", 0, null, "https://lawnet.vn/uploads/image/2023/10/17/015815855.jpg", 0, null },
                    { new Guid("66b45df5-4fe5-49ae-99ca-9f24cb611f39"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9307), null, "Tập Gym", 0, null, "https://tiki.vn/blog/wp-content/uploads/2023/07/elite-fitness-1024x583.jpg", 0, null },
                    { new Guid("69d1e547-57c1-4a73-afac-6b7ee82a50db"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9374), null, "Có body chuẩn chỉnh", 0, null, "https://cdn.nhathuoclongchau.com.vn/unsafe/800x0/https://cms-prod.s3-sgn09.fptcloud.com/fitness_la_gi_loi_ich_va_phuong_phap_tap_luyen_fitness_1_3c4e094223.png", 1, null },
                    { new Guid("6a28185f-e0cc-4ec4-81d9-f3f68fed2349"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9544), null, "Thoải mái", 0, null, null, 4, null },
                    { new Guid("6c63e9a2-e20a-4abe-a2fc-53dde07de027"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9358), null, "Địa lý", 0, null, "https://www.aag.org/wp-content/uploads/2021/12/shutterstock_1111879247.jpg", 0, null },
                    { new Guid("6e8d5465-d70f-4c63-b54f-8c3bdb5241e8"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9321), null, "Du lịch", 0, null, "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/18/4f/7d/fc/caption.jpg?w=1200&h=1200&s=1", 0, null },
                    { new Guid("707d4989-8963-4c60-821c-801e20081071"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9338), null, "Hội họa", 0, null, "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ea/Van_Gogh_-_Starry_Night_-_Google_Art_Project.jpg/1200px-Van_Gogh_-_Starry_Night_-_Google_Art_Project.jpg", 0, null },
                    { new Guid("744a62a2-4e14-4a0f-9e9b-5f3a511da39a"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9442), null, "Tập sức mạnh", 0, null, "https://www.thethaothientruong.vn/uploads/2020/Powerlifting-la-gi.jpg", 2, null },
                    { new Guid("75598f28-49e8-4fb6-97ae-21bbead8ecd9"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9376), null, "Phòng tránh bệnh", 0, null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQv509Yw7GUN5twNNk4G5Pvu1TBqFmhrL_3UQ&s", 1, null },
                    { new Guid("77df8b3a-4305-459c-a544-26076c0f3bd9"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9525), null, "Nhạy cảm", 0, null, null, 4, null },
                    { new Guid("788eddd6-e24e-43d5-bc0e-8f703ea0fec1"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9329), null, "Khoa học", 0, null, "https://www.training.com.au/wp-content/uploads/science-stem-feature.png", 0, null },
                    { new Guid("7e6cc9ad-98b6-4c43-b4b0-cd6741cc2399"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9447), null, "HIIT", 0, null, "https://hips.hearstapps.com/hmg-prod/images/athletes-doing-push-ups-with-dumbbells-on-floor-royalty-free-image-1638463573.jpg", 2, null },
                    { new Guid("80841fae-05a9-4fb8-a589-8b5cc0c6b818"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9368), null, "Quản lý cân nặng", 0, null, "https://thanhnien.mediacdn.vn/Uploaded/minhnguyet/2022_05_10/an-kieng-9141.jpg", 1, null },
                    { new Guid("80e66a20-4b0d-4571-bcde-3e262c31ee42"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9494), null, "Biết truyền cảm hứng, tạo động lực", 0, null, null, 3, null },
                    { new Guid("85048918-6b61-454a-810b-e98f83c80ebe"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9294), null, "Bóng chuyền", 0, null, "https://file.hstatic.net/200000333667/article/image.jpg_4b1e1c8ce20f4c32824f275f34ff30af_1024x1024.jpg", 0, null },
                    { new Guid("87181132-07be-4afb-8413-9847fac37b0e"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9450), null, "Kickfit", 0, null, "https://storage.googleapis.com/leep_app_website/2020/11/Kick-fit-khong-phai-la-kick-boxing.jpg", 2, null },
                    { new Guid("891da9b9-9708-4467-ba2c-19ba97ff976b"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9343), null, "Nghe nhạc", 0, null, "https://static.vecteezy.com/system/resources/thumbnails/037/044/052/small_2x/ai-generated-studio-shot-of-black-headphones-over-music-note-explosion-background-with-empty-space-for-text-photo.jpg", 0, null },
                    { new Guid("89bc2bb3-e053-4a0c-8115-639ee27de8bd"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9346), null, "Chơi nhạc cụ", 0, null, "https://t3.ftcdn.net/jpg/01/34/38/92/360_F_134389281_5Jak3tbsoDggHIfIKKwJ8L7064ACIMNE.jpg", 0, null },
                    { new Guid("8c7dc9cf-a491-40ea-9018-7ef59fc7bb61"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9489), null, "Giàu kiến thức", 0, null, null, 3, null },
                    { new Guid("8f6c7353-6d07-4257-9e00-93624cc0e7e3"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9318), null, "Truyện tranh", 0, null, "https://taschen.makaira.media/taschen/image/upload/f_webp,w_1200/v1673462260/products-live/a3d446fb0046b587eb0ed76edca3f4d6.jpg", 0, null },
                    { new Guid("91a840b3-875b-48d8-bb23-3cd81d3c1ed7"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9353), null, "Công nghệ", 0, null, "https://www.simplilearn.com/ice9/free_resources_article_thumb/Technology_Trends.jpg", 0, null },
                    { new Guid("960b9abb-fd81-43f7-8010-556b17530e25"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9532), null, "Hay bị lười", 0, null, null, 4, null },
                    { new Guid("9a03ec94-deab-4ed6-b4fc-5f2e11dba1b6"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9541), null, "Cầu toàn", 0, null, null, 4, null },
                    { new Guid("a2734f25-4ad2-4753-8155-d26e86bc0915"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9323), null, "Thể thao trí tuệ", 0, null, "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6f/ChessSet.jpg/640px-ChessSet.jpg", 0, null },
                    { new Guid("ad3f6c4a-4002-4ac9-aedf-51f7d80995ce"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9291), null, "Cầu Lông", 0, null, "https://vecgroup.vn/images/products/2021/08/24/large/qua-cau-long_1629778779.jpg", 0, null },
                    { new Guid("bac9fa65-0907-44ea-8a19-b9ce382c09f0"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9522), null, "Nhút nhát", 0, null, null, 4, null },
                    { new Guid("bd667558-7e79-469d-86df-35c3d592665d"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9546), null, "Dễ bị khó chịu", 0, null, null, 4, null },
                    { new Guid("c349fe52-60ee-4f30-9df3-18511985eefc"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9300), null, "Thể thao nói chung", 0, null, "https://llv.edu.vn/media/2018/09/iStock-949190756-800x440.jpg", 0, null },
                    { new Guid("c52fa24c-1f20-4e9d-83ec-cfb48e964650"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9309), null, "Đi, chạy bộ", 0, null, "https://pos.nvncdn.com/be3294-43017/art/artCT/20230228_9uObLfWys7Q0IXe4.jpg", 0, null },
                    { new Guid("cd2278aa-ea39-4a43-8e8b-7a7a3c5be42b"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9350), null, "Tán gẫu", 0, null, "https://transcode-v2.app.engoo.com/image/fetch/f_auto,c_lfill,w_300,dpr_3/https://assets.app.engoo.com/images/rGTEEA2fm66YMzeJz2UbwkKOW62bZVlqKOKZrXlMN7g.jpeg", 0, null },
                    { new Guid("ce9f99c4-206e-4b08-8728-09686b2d5a83"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9371), null, "Phát triển cơ bắp", 0, null, "https://www.dmoose.com/cdn/shop/articles/feature-image_87a28752-6da3-4be8-8814-d5221236136d.jpg?v=1676644951", 1, null },
                    { new Guid("cf4db104-674d-4167-ae2e-80fc3de5d38e"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9500), null, "Kiên trì", 0, null, null, 4, null },
                    { new Guid("cf5ff747-363c-47e2-8d47-590adc328e76"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9508), null, "Vui tính, hài hước", 0, null, null, 4, null },
                    { new Guid("d08253b5-8fa4-407e-b44e-7df5e7b1f6ac"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9515), null, "Dễ gần", 0, null, null, 4, null },
                    { new Guid("d2e3c5a5-6334-44af-89b8-82a06dc82017"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9363), null, "Sống Ảo", 0, null, "https://imagev3.vietnamplus.vn/w1000/Uploaded/2024/hotnnz/2024_08_13/song-ao3-6646.jpg.webp", 0, null },
                    { new Guid("d3f781fe-7ea8-4efc-969f-78b97cfc959a"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9492), null, "Luôn sẵn sàng tư vấn ngoài giờ", 0, null, null, 3, null },
                    { new Guid("d6485d91-a034-4ea9-8213-9147f924f16c"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9445), null, "Cardio", 0, null, "https://file.hstatic.net/1000308068/file/tap-cardio-vao-luc-nao-la-hieu-qua-nhat_cb884317c05d4df980138121ee113112_grande.jpg", 2, null },
                    { new Guid("d7153127-8ab8-478e-af1a-e75eabad1ed2"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9458), null, "Thể dục nhịp điệu, theo nhạc", 0, null, "https://i.vietgiaitri.com/2018/10/9/the-duc-nhip-dieu-b2ab9f.jpg", 2, null },
                    { new Guid("e25f6770-c284-42e2-89a2-356653970918"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9520), null, "Lạnh lùng, ít nói", 0, null, null, 4, null },
                    { new Guid("e35476f7-4f48-403c-83a7-538cfdc88f78"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9469), null, "Ngoại hình đẹp", 0, null, null, 3, null },
                    { new Guid("e4fb55b9-c0b7-430d-a7ed-abe87e904f9f"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9278), null, "Bóng đá", 0, null, "https://cdn.tuoitre.vn/ttct//2020/12/13/16078750289060-lich-thi-dau-bong-da-hom-nay-0211.jpg", 0, null },
                    { new Guid("e98e931e-faa3-4485-aad4-79cd69c2d84f"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9476), null, "Tâm huyết với học viên", 0, null, null, 3, null },
                    { new Guid("ea12e995-abc2-43d4-88e1-b2eed75ef27a"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9384), null, "Cải thiện sự dẻo dai", 0, null, "https://cdn.shopify.com/s/files/1/0453/0381/files/fullsizeoutput_2d4_1024x1024.jpg?v=1662646979", 1, null },
                    { new Guid("ec62331c-48e5-4de1-a307-30015c6e583a"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9534), null, "Sẵn sàng học hỏi", 0, null, null, 4, null },
                    { new Guid("f1981d58-c56c-483e-8995-5713658fb8ea"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9466), null, "Khác giới", 0, 0, null, 3, null },
                    { new Guid("faef9c5b-76f0-4954-a16c-c01935f8bc29"), "123abc", new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9513), null, "Năng động", 0, null, null, 4, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "101jkl",
                columns: new[] { "CreatedDate", "Id", "PTRating" },
                values: new object[] { new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(8958), new Guid("5d84ecec-e9a4-4f8c-9c40-1384e54a3830"), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "123abc",
                columns: new[] { "CreatedDate", "Id", "PTRating" },
                values: new object[] { new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(8866), new Guid("31dbffb2-2139-4d92-96e9-e519f3b838d4"), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "202mno",
                columns: new[] { "CreatedDate", "Id", "PTRating" },
                values: new object[] { new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(8983), new Guid("941b0ada-4fde-4e0d-bd5e-45242577a9b3"), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "303pqr",
                columns: new[] { "CreatedDate", "Id", "PTRating" },
                values: new object[] { new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(8992), new Guid("6c68ef29-619f-4ecf-9e4b-d075265b1e8e"), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "404stu",
                columns: new[] { "CreatedDate", "Id", "PTRating" },
                values: new object[] { new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9001), new Guid("9f1f7459-e909-4584-924d-73e082458181"), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "456def",
                columns: new[] { "CreatedDate", "Id", "PTRating" },
                values: new object[] { new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(8928), new Guid("a887e5d3-f651-4c00-802b-97377eaf0ba0"), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "505vwx",
                columns: new[] { "CreatedDate", "Id", "PTRating" },
                values: new object[] { new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9009), new Guid("94b9aa1e-0645-47c1-9b25-7f1b46fcff46"), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "606yza",
                columns: new[] { "CreatedDate", "Id", "PTRating" },
                values: new object[] { new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9082), new Guid("887e086f-87d5-40ff-8971-354b12dfbe5f"), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "707bcd",
                columns: new[] { "CreatedDate", "Id", "PTRating" },
                values: new object[] { new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9092), new Guid("4e6cdddd-de1d-47ac-931b-826623678488"), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "789ghi",
                columns: new[] { "CreatedDate", "Id", "PTRating" },
                values: new object[] { new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(8947), new Guid("29f2efa8-1938-4566-9912-e69f18651667"), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("5911b672-54f8-4412-86b9-d4f08b54ef7b"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("5c895ba7-bc67-42e2-ba2b-cad9b87e982a"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("02a358b6-a1fb-4c2a-bce9-b4a12b458813"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("06aec7ad-3198-4ac9-b584-b37da96736e6"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("088bba8a-409e-4a07-9dd0-b47489e6f496"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("097278be-7ebe-46b5-ba42-df99e4399ce8"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("0ba25be0-7fe0-451c-b56e-2ea70f417760"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("163bbcd0-335f-47e4-b7b1-e2aff36aa259"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("18ab40a7-a6f2-4eb6-8dc1-8f9d682513bd"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("18d16372-aaa8-4aab-84a7-9559b3bdd2e2"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("1a0592bd-15db-4bbd-9029-d01af7faa4a3"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("1ebed850-7ce2-40d6-b6d7-3c9181e00963"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("1f73e933-4036-4e9f-bd6f-17a545fc6fca"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("227d340e-fb3c-4c44-b464-f51c0cf098d4"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("245b080a-2d2a-4594-adc8-056d5ec38960"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("2ac5ef91-7a4a-4300-a9e1-64f21a50b5e6"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("2baf74fa-2028-49ee-a940-2857994acfb1"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("3068f395-42da-4a02-a2c0-40ddb8cf4115"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("320a98a0-d222-438b-a93c-1c380ac5615d"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("3511c9b0-c9b7-4926-9e02-a8c8df696a0e"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("372e941b-f4d5-4951-9587-6693f5dd1895"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("373744b9-6113-49d9-b444-244ef40ee0e6"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("38189688-da95-41d4-a61f-b4f3c3aab849"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("3a6287a3-52e9-4c6b-8d39-9e99c4b63c02"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("3d6c7462-c521-4a3e-be33-e620aa7cfc37"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("3f82fb98-c502-4f6f-ab51-052228cb5da4"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("43d20cfb-d4f9-4ed0-8dbf-a1506a3f8f1f"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("43e4fda4-dd6c-4853-af47-4b3c42de0c1c"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("46337243-38a3-4532-a826-6ff3c6feb1eb"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("4c7230b9-8535-4e0a-88cf-92ec16257006"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("53b1b595-3484-4e9c-b489-22856308044f"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("5b3fdb23-caaa-4ecb-b468-9da40626caa7"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("66b45df5-4fe5-49ae-99ca-9f24cb611f39"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("69d1e547-57c1-4a73-afac-6b7ee82a50db"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("6a28185f-e0cc-4ec4-81d9-f3f68fed2349"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("6c63e9a2-e20a-4abe-a2fc-53dde07de027"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("6e8d5465-d70f-4c63-b54f-8c3bdb5241e8"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("707d4989-8963-4c60-821c-801e20081071"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("744a62a2-4e14-4a0f-9e9b-5f3a511da39a"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("75598f28-49e8-4fb6-97ae-21bbead8ecd9"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("77df8b3a-4305-459c-a544-26076c0f3bd9"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("788eddd6-e24e-43d5-bc0e-8f703ea0fec1"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("7e6cc9ad-98b6-4c43-b4b0-cd6741cc2399"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("80841fae-05a9-4fb8-a589-8b5cc0c6b818"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("80e66a20-4b0d-4571-bcde-3e262c31ee42"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("85048918-6b61-454a-810b-e98f83c80ebe"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("87181132-07be-4afb-8413-9847fac37b0e"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("891da9b9-9708-4467-ba2c-19ba97ff976b"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("89bc2bb3-e053-4a0c-8115-639ee27de8bd"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("8c7dc9cf-a491-40ea-9018-7ef59fc7bb61"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("8f6c7353-6d07-4257-9e00-93624cc0e7e3"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("91a840b3-875b-48d8-bb23-3cd81d3c1ed7"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("960b9abb-fd81-43f7-8010-556b17530e25"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("9a03ec94-deab-4ed6-b4fc-5f2e11dba1b6"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("a2734f25-4ad2-4753-8155-d26e86bc0915"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("ad3f6c4a-4002-4ac9-aedf-51f7d80995ce"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("bac9fa65-0907-44ea-8a19-b9ce382c09f0"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("bd667558-7e79-469d-86df-35c3d592665d"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("c349fe52-60ee-4f30-9df3-18511985eefc"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("c52fa24c-1f20-4e9d-83ec-cfb48e964650"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("cd2278aa-ea39-4a43-8e8b-7a7a3c5be42b"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("ce9f99c4-206e-4b08-8728-09686b2d5a83"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("cf4db104-674d-4167-ae2e-80fc3de5d38e"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("cf5ff747-363c-47e2-8d47-590adc328e76"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("d08253b5-8fa4-407e-b44e-7df5e7b1f6ac"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("d2e3c5a5-6334-44af-89b8-82a06dc82017"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("d3f781fe-7ea8-4efc-969f-78b97cfc959a"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("d6485d91-a034-4ea9-8213-9147f924f16c"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("d7153127-8ab8-478e-af1a-e75eabad1ed2"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("e25f6770-c284-42e2-89a2-356653970918"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("e35476f7-4f48-403c-83a7-538cfdc88f78"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("e4fb55b9-c0b7-430d-a7ed-abe87e904f9f"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("e98e931e-faa3-4485-aad4-79cd69c2d84f"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("ea12e995-abc2-43d4-88e1-b2eed75ef27a"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("ec62331c-48e5-4de1-a307-30015c6e583a"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("f1981d58-c56c-483e-8995-5713658fb8ea"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("faef9c5b-76f0-4954-a16c-c01935f8bc29"));

            migrationBuilder.DropColumn(
                name: "PTRating",
                table: "Users");

            migrationBuilder.InsertData(
                table: "EmailTemplates",
                columns: new[] { "Id", "Body", "CreatedDate", "DeletedDate", "Description", "Name", "Params", "RecordStatus", "Status", "Subject", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("4d222663-cdd6-4d27-a639-7318527a5747"), "Chào mừng bạn đến với FitWipe! Kính gửi [Name], vui lòng xác nhận địa chỉ email của bạn bằng cách nhấn vào đường link sau: <a href=\"[VerificationLink]\">Xác nhận Email</a>.<br><br>Cảm ơn bạn đã tham gia cùng chúng tôi!<br><br>Đội ngũ FitWipe", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(9186), null, "Email này được gửi để xác nhận đăng ký tài khoản FitWipe.", "Register_Mail", "[Name], [VerificationLink]", 0, true, "Chào mừng đến với FitWipe! Vui lòng xác nhận email của bạn", null },
                    { new Guid("8200b207-320e-4009-9013-408ed7689bfe"), "Chúng tôi đã nhận được yêu cầu đặt lại mật khẩu cho tài khoản của bạn tại FitWipe. Kính gửi [Name], vui lòng đặt lại mật khẩu của bạn bằng cách nhấn vào đường link sau: <a href=\"[ResetPasswordLink]\">Đặt lại mật khẩu</a>.<br><br>Nếu bạn không yêu cầu việc này, vui lòng bỏ qua email này.<br><br>Đội ngũ FitWipe", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(9201), null, "Email này được gửi khi người dùng yêu cầu đặt lại mật khẩu cho tài khoản FitWipe.", "Forgot_Password", "[Name], [ResetPasswordLink]", 0, true, "Yêu cầu đặt lại mật khẩu FitWipe", null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreateById", "CreatedDate", "DeletedDate", "Name", "RecordStatus", "SpecialTag", "TagImage", "TagType", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0a55b36a-6724-4dee-988f-61100b2800a4"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(9043), null, "Calisthenic", 0, null, "https://cdn.nhathuoclongchau.com.vn/unsafe/800x0/https://cms-prod.s3-sgn09.fptcloud.com/giai_dap_thac_mac_calisthenics_khac_gi_gym_1_8d5dd4026b.jpg", 2, null },
                    { new Guid("0c1b8083-8501-49d3-adda-32c9eafccdf3"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(9124), null, "Dễ nản", 0, null, null, 4, null },
                    { new Guid("0cdeed83-8255-4604-9a9e-f9c9bded2d69"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(9102), null, "Giàu kiến thức", 0, null, null, 3, null },
                    { new Guid("10ccf78a-8ec0-412b-97c2-662638191b1e"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(9011), null, "Hội họa", 0, null, "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ea/Van_Gogh_-_Starry_Night_-_Google_Art_Project.jpg/1200px-Van_Gogh_-_Starry_Night_-_Google_Art_Project.jpg", 0, null },
                    { new Guid("10f150d1-fd71-49c5-853e-c6f9effef006"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(9062), null, "Tâm huyết với học viên", 0, null, null, 3, null },
                    { new Guid("1419f9dd-cdc4-4cd0-83d3-0751e8819c98"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(8998), null, "Phim ảnh", 0, null, "https://lawnet.vn/uploads/image/2023/10/17/015815855.jpg", 0, null },
                    { new Guid("15c7ae90-0f99-425f-b68a-55a71f7f7e5c"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(9110), null, "Siêng năng", 0, null, null, 4, null },
                    { new Guid("1f416dd7-0574-4ca5-9c90-d5e25887fa31"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(9032), null, "Tăng cảm giác hạnh phúc, giảm căng thẳng", 0, null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT8ZXc_bemAYbupxmGz0pZGy4L1Zr6hGVsYdA&s", 1, null },
                    { new Guid("2ab03b2d-9719-47d3-ac0e-42dfae1c2bcc"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(9052), null, "Thể dục nhịp điệu, theo nhạc", 0, null, "https://i.vietgiaitri.com/2018/10/9/the-duc-nhip-dieu-b2ab9f.jpg", 2, null },
                    { new Guid("341486ff-388a-4fe6-ad82-c3f1cbf1707b"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(9126), null, "Sẵn sàng học hỏi", 0, null, null, 4, null },
                    { new Guid("359fd7d1-b677-4466-9a95-6b38fbf31d93"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(9038), null, "Cải thiện sức bền", 0, null, "https://vinmec-prod.s3.amazonaws.com/images/20210524_085806_814180_chay-bo-bao-nhieu-cal.max-800x800.jpg", 1, null },
                    { new Guid("3f96abc2-fe8e-4979-b97a-be10cc738d69"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(9064), null, "Có trách nhiệm", 0, null, null, 3, null },
                    { new Guid("4265e2cc-ada7-455b-97aa-9099fb08898b"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(8995), null, "Đi, chạy bộ", 0, null, "https://pos.nvncdn.com/be3294-43017/art/artCT/20230228_9uObLfWys7Q0IXe4.jpg", 0, null },
                    { new Guid("4281e1ac-1e01-4427-89da-5fed7e508134"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(8990), null, "Thể thao nói chung", 0, null, "https://llv.edu.vn/media/2018/09/iStock-949190756-800x440.jpg", 0, null },
                    { new Guid("4467e761-8019-4553-a341-d566a947481d"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(9135), null, "Độc thân lâu năm", 0, null, null, 4, null },
                    { new Guid("4533834e-c2ac-40e6-9b68-6d9c87555782"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(9106), null, "Đảm bảo mục tiêu cho học viên", 0, null, null, 3, null },
                    { new Guid("459d5ce9-1b28-411d-bf97-41f4f51dcb88"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(9056), null, "Khác giới", 0, 0, null, 3, null },
                    { new Guid("4d025b36-2508-453e-a489-e77d957cbea3"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(9112), null, "Vui tính, hài hước", 0, null, null, 4, null },
                    { new Guid("4e778b7c-71cf-4b78-ae12-c080173554ce"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(9122), null, "Nhạy cảm", 0, null, null, 4, null },
                    { new Guid("502fc407-33c7-4131-b072-28f232103e4c"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(8985), null, "Cầu Lông", 0, null, "https://vecgroup.vn/images/products/2021/08/24/large/qua-cau-long_1629778779.jpg", 0, null },
                    { new Guid("50d1d2f7-bef5-401b-bf74-4ebccc75a4f5"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(9058), null, "Ngoại hình đẹp", 0, null, null, 3, null },
                    { new Guid("51242843-b319-41f3-8c0b-2c19527d4a80"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(9045), null, "Cardio", 0, null, "https://file.hstatic.net/1000308068/file/tap-cardio-vao-luc-nao-la-hieu-qua-nhat_cb884317c05d4df980138121ee113112_grande.jpg", 2, null },
                    { new Guid("51f59bde-22fe-44bf-9626-80c0c05c94f4"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(9117), null, "Thi thoảng bất thường", 0, null, null, 4, null },
                    { new Guid("534a662c-27e8-4ac2-bd25-ffc32a359217"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(9005), null, "Khoa học", 0, null, "https://www.training.com.au/wp-content/uploads/science-stem-feature.png", 0, null },
                    { new Guid("55fbd02d-6ada-4db9-8c95-594b58499774"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(9127), null, "Hiền lành", 0, null, null, 4, null },
                    { new Guid("5b9217df-a281-478d-a2f5-636dcf72e37b"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(9100), null, "Không nặng nề với học viên", 0, null, null, 3, null },
                    { new Guid("5defc1ab-b478-478b-8200-ec9e8aecf063"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(9134), null, "Dễ bị khó chịu", 0, null, null, 4, null },
                    { new Guid("5fec8c08-536b-4297-83d7-1fc855e118af"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(9108), null, "Kiên trì", 0, null, null, 4, null },
                    { new Guid("60ac450f-3092-4c51-9f6c-34d81135784e"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(9006), null, "Game", 0, null, "https://genk.mediacdn.vn/139269124445442048/2022/7/28/tmb-1658998970448906989995.jpg", 0, null },
                    { new Guid("6a404cb0-ded4-4fbe-b8e4-bebd9e1c1cea"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(9131), null, "Thoải mái", 0, null, null, 4, null },
                    { new Guid("713957b5-28a9-4629-9f44-25f1e0e397c4"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(9047), null, "HIIT", 0, null, "https://hips.hearstapps.com/hmg-prod/images/athletes-doing-push-ups-with-dumbbells-on-floor-royalty-free-image-1638463573.jpg", 2, null },
                    { new Guid("72ab2e02-54ef-4e1d-a6e3-32d5cd47cce4"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(9053), null, "Cùng giới", 0, 1, null, 3, null },
                    { new Guid("7933b2c4-cc49-49c2-8b29-1b0c61bc0b31"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(9020), null, "Địa lý", 0, null, "https://www.aag.org/wp-content/uploads/2021/12/shutterstock_1111879247.jpg", 0, null },
                    { new Guid("7a2f5587-118f-4aa4-93bb-f9f46b85ffd0"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(9118), null, "Lạnh lùng, ít nói", 0, null, null, 4, null },
                    { new Guid("7b2a3c7e-ecf0-4f74-9991-bf27b9cfe111"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(9098), null, "Có kinh nghiệm", 0, null, null, 3, null },
                    { new Guid("7c2437e3-7c04-48b5-bee4-df8ef183bb28"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(8928), null, "Bóng đá", 0, null, "https://cdn.tuoitre.vn/ttct//2020/12/13/16078750289060-lich-thi-dau-bong-da-hom-nay-0211.jpg", 0, null },
                    { new Guid("852cc1cf-df2e-4121-955c-45a4abc11c0d"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(9060), null, "Gần", 0, 2, null, 3, null },
                    { new Guid("8741c577-0b21-4944-9e38-d8ce96b48b9e"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(9119), null, "Nhút nhát", 0, null, null, 4, null },
                    { new Guid("898e1305-9c4a-4eaa-8c1f-4f8f84eb087f"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(8999), null, "Truyện tranh", 0, null, "https://taschen.makaira.media/taschen/image/upload/f_webp,w_1200/v1673462260/products-live/a3d446fb0046b587eb0ed76edca3f4d6.jpg", 0, null },
                    { new Guid("89b3f17f-eb3b-4802-9fb2-694390b174f0"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(9059), null, "Cung cấp giá cả phải chăng", 0, null, null, 3, null },
                    { new Guid("9713930e-eb53-4f10-a2f9-826de2391553"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(8988), null, "Bóng rổ", 0, null, "https://thethaothienlong.vn/wp-content/uploads/2022/04/Kich-thuoc-qua-bong-ro-1.jpg", 0, null },
                    { new Guid("9ad8f365-0dbc-4853-905f-02992fa3b818"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(9027), null, "Phát triển cơ bắp", 0, null, "https://www.dmoose.com/cdn/shop/articles/feature-image_87a28752-6da3-4be8-8814-d5221236136d.jpg?v=1676644951", 1, null },
                    { new Guid("9ada5b53-df39-4c05-999c-c2b72c0c2197"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(8993), null, "Tập Gym", 0, null, "https://tiki.vn/blog/wp-content/uploads/2023/07/elite-fitness-1024x583.jpg", 0, null },
                    { new Guid("9d6f15c3-6155-44f4-ad56-de2958e27c25"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(9017), null, "Công nghệ", 0, null, "https://www.simplilearn.com/ice9/free_resources_article_thumb/Technology_Trends.jpg", 0, null },
                    { new Guid("a12605f1-f2ca-4fcc-97aa-fce26516d99a"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(9130), null, "Cầu toàn", 0, null, null, 4, null },
                    { new Guid("a3aaa9d9-bdca-4c4c-954d-170d5c8f7a81"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(9015), null, "Tán gẫu", 0, null, "https://transcode-v2.app.engoo.com/image/fetch/f_auto,c_lfill,w_300,dpr_3/https://assets.app.engoo.com/images/rGTEEA2fm66YMzeJz2UbwkKOW62bZVlqKOKZrXlMN7g.jpeg", 0, null },
                    { new Guid("a3b16ebb-d032-4f88-99b0-0b496cd372d8"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(9025), null, "Quản lý cân nặng", 0, null, "https://thanhnien.mediacdn.vn/Uploaded/minhnguyet/2022_05_10/an-kieng-9141.jpg", 1, null },
                    { new Guid("a4082a9f-569c-40fc-8ab9-8ce1a61141e7"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(9021), null, "Triết học", 0, null, "https://www.rollingstone.com/wp-content/uploads/2024/01/unlocking_the_power_why_you_should_consider_hiring_philosophy_graduates-.jpg", 0, null },
                    { new Guid("a7e7dec8-23df-4b23-9955-59e4387da4b1"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(9129), null, "Rảnh rỗi", 0, null, null, 4, null },
                    { new Guid("ad211a7c-727e-4fee-8eb3-c4691f8bd1a4"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(9029), null, "Phòng tránh bệnh", 0, null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQv509Yw7GUN5twNNk4G5Pvu1TBqFmhrL_3UQ&s", 1, null },
                    { new Guid("b3c2692c-4f42-41ed-aa1e-f85e50505eee"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(9009), null, "Nhiếp ảnh", 0, null, "https://aaftonline.com/blog/wp-content/uploads/2024/01/What-are-the-Benefits-of-Photography-Complete-Overview.png", 0, null },
                    { new Guid("b58b0973-c8f8-46ef-9f3a-bc18cb1675b7"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(8986), null, "Bóng chuyền", 0, null, "https://file.hstatic.net/200000333667/article/image.jpg_4b1e1c8ce20f4c32824f275f34ff30af_1024x1024.jpg", 0, null },
                    { new Guid("b711a2c9-e7d6-412c-8a2c-bef183546309"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(9014), null, "Chơi nhạc cụ", 0, null, "https://t3.ftcdn.net/jpg/01/34/38/92/360_F_134389281_5Jak3tbsoDggHIfIKKwJ8L7064ACIMNE.jpg", 0, null },
                    { new Guid("b82eb77c-8176-486e-b1f8-093689bae3d3"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(9115), null, "Dễ gần", 0, null, null, 4, null },
                    { new Guid("bac36144-8194-4b91-bace-252238ea49eb"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(9048), null, "Kickfit", 0, null, "https://storage.googleapis.com/leep_app_website/2020/11/Kick-fit-khong-phai-la-kick-boxing.jpg", 2, null },
                    { new Guid("baf752b8-c11e-4f9a-986a-95522cd0ef1c"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(9041), null, "Yoga / Pilates", 0, null, "https://thamtapyoga.vn/wp-content/uploads/2024/01/3-2.jpeg", 2, null },
                    { new Guid("bdd29ba3-56bb-4309-9176-b01688821fc1"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(9002), null, "Thể thao trí tuệ", 0, null, "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6f/ChessSet.jpg/640px-ChessSet.jpg", 0, null },
                    { new Guid("bf952303-dc7b-4793-9f24-d22bf39abd6e"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(9114), null, "Năng động", 0, null, null, 4, null },
                    { new Guid("bff84c4b-63fa-473c-ac6a-39397ac82b59"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(9003), null, "Đọc sách", 0, null, "https://images.theconversation.com/files/45159/original/rptgtpxd-1396254731.jpg?ixlib=rb-4.1.0&q=45&auto=format&w=1356&h=668&fit=crop", 0, null },
                    { new Guid("c20c44f1-1cbb-4131-bb40-6c2b013b1d6f"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(9034), null, "Cải thiện sự dẻo dai", 0, null, "https://cdn.shopify.com/s/files/1/0453/0381/files/fullsizeoutput_2d4_1024x1024.jpg?v=1662646979", 1, null },
                    { new Guid("c839cb64-10f2-4c48-af1a-05812679ef77"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(9105), null, "Biết truyền cảm hứng, tạo động lực", 0, null, null, 3, null },
                    { new Guid("ce32aa3e-3b02-4b37-8200-439456563e70"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(9028), null, "Có body chuẩn chỉnh", 0, null, "https://cdn.nhathuoclongchau.com.vn/unsafe/800x0/https://cms-prod.s3-sgn09.fptcloud.com/fitness_la_gi_loi_ich_va_phuong_phap_tap_luyen_fitness_1_3c4e094223.png", 1, null },
                    { new Guid("cf47b4e2-7f8f-4d3c-aa6e-841ee2f9d04c"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(9125), null, "Hay bị lười", 0, null, null, 4, null },
                    { new Guid("d3679c29-3251-47ec-bd6f-7a7b861a90f9"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(9018), null, "Lịch Sử", 0, null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRWz_tIgvQXPAaSmvYa7CqZo_biaRK9D_O8uA&s", 0, null },
                    { new Guid("d3a93747-f7e2-4ff8-be85-e4b8ec957b1c"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(9001), null, "Du lịch", 0, null, "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/18/4f/7d/fc/caption.jpg?w=1200&h=1200&s=1", 0, null },
                    { new Guid("d5cff4a7-293e-47a0-964f-87ab630bd0ea"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(9050), null, "Tập ép dẻo", 0, null, "https://prod-everyoneactive-wp.s3.eu-west-2.amazonaws.com/wp-content/uploads/2020/03/23151503/flexibility-at-home.jpg", 2, null },
                    { new Guid("e10e6946-7b2d-490a-bd06-593211ad4c41"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(9040), null, "Cải thiện sức khỏe tổng quát", 0, null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcThCjFemkP0h0IZYpu31k-xGK9IvigaysteqA&s", 1, null },
                    { new Guid("e12be1c1-fb6d-4582-8c24-679ab9660202"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(9044), null, "Tập sức mạnh", 0, null, "https://www.thethaothientruong.vn/uploads/2020/Powerlifting-la-gi.jpg", 2, null },
                    { new Guid("e1c89aa7-4e6d-4f43-8b04-f268cdd1d0a5"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(9113), null, "Hòa đồng", 0, null, null, 4, null },
                    { new Guid("e7654a7f-2c98-4d4e-a9f2-f44de9d4ca5d"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(8991), null, "Bida", 0, null, "https://billiardshoanthuy.vn/wp-content/uploads/2021/05/phu-kien-ban-bida-2.jpg", 0, null },
                    { new Guid("f22748f5-71f9-4823-a1c9-4cda239b1fb2"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(9031), null, "Cải thiện tình trạng bệnh", 0, null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQv509Yw7GUN5twNNk4G5Pvu1TBqFmhrL_3UQ&s", 1, null },
                    { new Guid("f8efa17c-7c40-4090-bd4c-12cdb2eb57fa"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(9024), null, "Sống Ảo", 0, null, "https://imagev3.vietnamplus.vn/w1000/Uploaded/2024/hotnnz/2024_08_13/song-ao3-6646.jpg.webp", 0, null },
                    { new Guid("faa4b885-e150-481e-a6e7-8886d0f93e44"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(9013), null, "Nghe nhạc", 0, null, "https://static.vecteezy.com/system/resources/thumbnails/037/044/052/small_2x/ai-generated-studio-shot-of-black-headphones-over-music-note-explosion-background-with-empty-space-for-text-photo.jpg", 0, null },
                    { new Guid("fbc4934e-d7d0-40a8-a463-b832768945af"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(8982), null, "Bơi lội", 0, null, "https://file.hstatic.net/1000391576/file/boi_loi_7d4d69c53ac1494eabb2a446d4d503a0_grande.jpg", 0, null },
                    { new Guid("fd60bde3-a149-44e0-8a35-51d626ad19a4"), "123abc", new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(9103), null, "Luôn sẵn sàng tư vấn ngoài giờ", 0, null, null, 3, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "101jkl",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(8776), new Guid("084ca32e-04cc-4465-ba14-96ee38037a77") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "123abc",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(8702), new Guid("95942e36-3b5d-4a11-8fc7-94668a78cd4b") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "202mno",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(8781), new Guid("4d78820e-9137-4756-90e0-a2a0a615c42f") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "303pqr",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(8786), new Guid("57b432da-b170-4c77-9aa8-db46e9add976") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "404stu",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(8795), new Guid("bbf9a758-875b-4ba3-93d6-23b9657cd3ef") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "456def",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(8746), new Guid("9a330236-762b-4388-b2ee-1fcd13323ede") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "505vwx",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(8799), new Guid("7f813e50-a525-4853-8d95-68d5c2ab83a5") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "606yza",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(8804), new Guid("4eb3f97f-8afb-477d-a701-b0863812f538") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "707bcd",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(8808), new Guid("ee7620cb-0dd8-4759-a4c7-11d932e85bc3") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "789ghi",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 10, 2, 12, 58, 8, 771, DateTimeKind.Utc).AddTicks(8760), new Guid("5695900a-a998-453a-a2a3-99b28dd05a38") });
        }
    }
}
