using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FitSwipe.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Add_City_Property_To_User_Table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tags_Users_CreateById",
                table: "Tags");



            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Users",
                type: "text",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_Users_CreateById",
                table: "Tags",
                column: "CreateById",
                principalTable: "Users",
                principalColumn: "FireBaseId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tags_Users_CreateById",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Users");

            migrationBuilder.InsertData(
                table: "EmailTemplates",
                columns: new[] { "Id", "Body", "CreatedDate", "DeletedDate", "Description", "Name", "Params", "RecordStatus", "Status", "Subject", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("4b73346f-5832-40e1-ae5e-b5167f0c54ed"), "Chào mừng bạn đến với FitWipe! Kính gửi [Name], vui lòng xác nhận địa chỉ email của bạn bằng cách nhấn vào đường link sau: <a href=\"[VerificationLink]\">Xác nhận Email</a>.<br><br>Cảm ơn bạn đã tham gia cùng chúng tôi!<br><br>Đội ngũ FitWipe", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9626), null, "Email này được gửi để xác nhận đăng ký tài khoản FitWipe.", "Register_Mail", "[Name], [VerificationLink]", 0, true, "Chào mừng đến với FitWipe! Vui lòng xác nhận email của bạn", null },
                    { new Guid("4f8edc52-77c5-441b-ac63-9ee6b36ff0ac"), "Chúng tôi đã nhận được yêu cầu đặt lại mật khẩu cho tài khoản của bạn tại FitWipe. Kính gửi [Name], vui lòng đặt lại mật khẩu của bạn bằng cách nhấn vào đường link sau: <a href=\"[ResetPasswordLink]\">Đặt lại mật khẩu</a>.<br><br>Nếu bạn không yêu cầu việc này, vui lòng bỏ qua email này.<br><br>Đội ngũ FitWipe", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9646), null, "Email này được gửi khi người dùng yêu cầu đặt lại mật khẩu cho tài khoản FitWipe.", "Forgot_Password", "[Name], [ResetPasswordLink]", 0, true, "Yêu cầu đặt lại mật khẩu FitWipe", null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreateById", "CreatedDate", "DeletedDate", "Name", "RecordStatus", "SpecialTag", "TagImage", "TagType", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0126e6d2-97df-4d70-95eb-983985ba630c"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9373), null, "Thể thao nói chung", 0, null, "https://llv.edu.vn/media/2018/09/iStock-949190756-800x440.jpg", 0, null },
                    { new Guid("07b0e226-51b1-469e-a21f-a97730b6e29e"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9467), null, "Không nặng nề với học viên", 0, null, null, 3, null },
                    { new Guid("0e21cc2b-e01b-4d36-ab9c-77ddd1999dcc"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9508), null, "Độc thân lâu năm", 0, null, null, 4, null },
                    { new Guid("12078107-6b0f-4db3-955a-a158b3c544ba"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9363), null, "Bơi lội", 0, null, "https://file.hstatic.net/1000391576/file/boi_loi_7d4d69c53ac1494eabb2a446d4d503a0_grande.jpg", 0, null },
                    { new Guid("12090aed-1f54-4254-ae7d-2f0db8d9c6cf"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9491), null, "Nhút nhát", 0, null, null, 4, null },
                    { new Guid("13ad0701-16f3-4f59-8d3a-47f18e475983"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9375), null, "Bida", 0, null, "https://billiardshoanthuy.vn/wp-content/uploads/2021/05/phu-kien-ban-bida-2.jpg", 0, null },
                    { new Guid("181be059-e215-4d17-96cb-8038cd8c119b"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9446), null, "Kickfit", 0, null, "https://storage.googleapis.com/leep_app_website/2020/11/Kick-fit-khong-phai-la-kick-boxing.jpg", 2, null },
                    { new Guid("192c1aff-2824-4ca8-810f-93eb3bfc27aa"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9435), null, "Tập sức mạnh", 0, null, "https://www.thethaothientruong.vn/uploads/2020/Powerlifting-la-gi.jpg", 2, null },
                    { new Guid("1b340c12-a9b7-45e9-bfcb-f21adaa61284"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9477), null, "Kiên trì", 0, null, null, 4, null },
                    { new Guid("2708f7c9-2417-4daa-9ee9-743c780c5b37"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9462), null, "Tâm huyết với học viên", 0, null, null, 3, null },
                    { new Guid("294f2331-3eb0-4463-ad87-294329663c32"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9391), null, "Khoa học", 0, null, "https://www.training.com.au/wp-content/uploads/science-stem-feature.png", 0, null },
                    { new Guid("29d73e01-f8d9-4fd1-8f34-5df2d38a3b05"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9469), null, "Giàu kiến thức", 0, null, null, 3, null },
                    { new Guid("2a6348df-932d-46d3-98bd-adc7316dadb3"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9480), null, "Vui tính, hài hước", 0, null, null, 4, null },
                    { new Guid("2adaaa73-d514-4c59-a645-dd559b92056a"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9385), null, "Thể thao trí tuệ", 0, null, "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6f/ChessSet.jpg/640px-ChessSet.jpg", 0, null },
                    { new Guid("2b5418e1-23fc-4987-94f9-efe76e234d15"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9416), null, "Có body chuẩn chỉnh", 0, null, "https://cdn.nhathuoclongchau.com.vn/unsafe/800x0/https://cms-prod.s3-sgn09.fptcloud.com/fitness_la_gi_loi_ich_va_phuong_phap_tap_luyen_fitness_1_3c4e094223.png", 1, null },
                    { new Guid("3069a281-57a2-41a6-b9dd-bb19117b5af4"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9507), null, "Dễ bị khó chịu", 0, null, null, 4, null },
                    { new Guid("373b2c96-6c0f-4d9b-a642-d94eef9e03e2"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9410), null, "Triết học", 0, null, "https://www.rollingstone.com/wp-content/uploads/2024/01/unlocking_the_power_why_you_should_consider_hiring_philosophy_graduates-.jpg", 0, null },
                    { new Guid("3c04281a-b281-4661-8354-9def2fa0392c"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9361), null, "Bóng đá", 0, null, "https://cdn.tuoitre.vn/ttct//2020/12/13/16078750289060-lich-thi-dau-bong-da-hom-nay-0211.jpg", 0, null },
                    { new Guid("44917e4b-2896-4609-aee0-03d5f03239b3"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9486), null, "Dễ gần", 0, null, null, 4, null },
                    { new Guid("4db0ebec-8ee0-44b8-93f9-088faf6e4b0b"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9380), null, "Phim ảnh", 0, null, "https://lawnet.vn/uploads/image/2023/10/17/015815855.jpg", 0, null },
                    { new Guid("5448dc38-ba73-4f92-9834-4d04bb9d9c4d"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9482), null, "Hòa đồng", 0, null, null, 4, null },
                    { new Guid("54769045-a1ec-4587-b327-2540218451ae"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9444), null, "HIIT", 0, null, "https://hips.hearstapps.com/hmg-prod/images/athletes-doing-push-ups-with-dumbbells-on-floor-royalty-free-image-1638463573.jpg", 2, null },
                    { new Guid("5852e363-0dfa-494d-a316-af325fcf4172"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9464), null, "Có trách nhiệm", 0, null, null, 3, null },
                    { new Guid("5daa8488-988a-4125-9964-2c152b88d856"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9501), null, "Hiền lành", 0, null, null, 4, null },
                    { new Guid("5f465542-53cc-4c41-a767-96fd3df9c74e"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9505), null, "Thoải mái", 0, null, null, 4, null },
                    { new Guid("6312f598-2f75-479a-a0f6-5d1a729aaa6f"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9448), null, "Tập ép dẻo", 0, null, "https://prod-everyoneactive-wp.s3.eu-west-2.amazonaws.com/wp-content/uploads/2020/03/23151503/flexibility-at-home.jpg", 2, null },
                    { new Guid("64a3b221-5e5c-4a60-a590-75223f5ed073"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9420), null, "Phòng tránh bệnh", 0, null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQv509Yw7GUN5twNNk4G5Pvu1TBqFmhrL_3UQ&s", 1, null },
                    { new Guid("67d788b6-e9e3-48f5-837a-3230e67989fb"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9377), null, "Tập Gym", 0, null, "https://tiki.vn/blog/wp-content/uploads/2023/07/elite-fitness-1024x583.jpg", 0, null },
                    { new Guid("69775cef-6a20-4e60-a512-face25b6c5df"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9443), null, "Cardio", 0, null, "https://file.hstatic.net/1000308068/file/tap-cardio-vao-luc-nao-la-hieu-qua-nhat_cb884317c05d4df980138121ee113112_grande.jpg", 2, null },
                    { new Guid("6a17c623-7ae7-4403-8332-67382f3bcf0c"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9497), null, "Sẵn sàng học hỏi", 0, null, null, 4, null },
                    { new Guid("70548b7b-2776-4b9a-9e5e-9f431c8097e2"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9460), null, "Gần", 0, 2, null, 3, null },
                    { new Guid("71907e0d-92f6-4f1c-9d4d-77a9af8da71f"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9367), null, "Bóng chuyền", 0, null, "https://file.hstatic.net/200000333667/article/image.jpg_4b1e1c8ce20f4c32824f275f34ff30af_1024x1024.jpg", 0, null },
                    { new Guid("74f1d5da-dc53-4bc0-b853-7456cfb07451"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9427), null, "Cải thiện sức bền", 0, null, "https://vinmec-prod.s3.amazonaws.com/images/20210524_085806_814180_chay-bo-bao-nhieu-cal.max-800x800.jpg", 1, null },
                    { new Guid("75152778-5e13-4d40-876a-3c7d359ab712"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9451), null, "Cùng giới", 0, 1, null, 3, null },
                    { new Guid("83467ce9-2e83-42c4-9750-08ae936c0707"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9399), null, "Chơi nhạc cụ", 0, null, "https://t3.ftcdn.net/jpg/01/34/38/92/360_F_134389281_5Jak3tbsoDggHIfIKKwJ8L7064ACIMNE.jpg", 0, null },
                    { new Guid("835133b1-06b7-4b04-b2d1-052ac7b7c379"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9379), null, "Đi, chạy bộ", 0, null, "https://pos.nvncdn.com/be3294-43017/art/artCT/20230228_9uObLfWys7Q0IXe4.jpg", 0, null },
                    { new Guid("860c9208-ca19-4fcf-9226-5d21c6da6833"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9365), null, "Cầu Lông", 0, null, "https://vecgroup.vn/images/products/2021/08/24/large/qua-cau-long_1629778779.jpg", 0, null },
                    { new Guid("8753c157-11a3-46f0-8ade-69a06a46730e"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9408), null, "Địa lý", 0, null, "https://www.aag.org/wp-content/uploads/2021/12/shutterstock_1111879247.jpg", 0, null },
                    { new Guid("886d219f-e887-4b9f-bff9-b06940c2194f"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9396), null, "Hội họa", 0, null, "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ea/Van_Gogh_-_Starry_Night_-_Google_Art_Project.jpg/1200px-Van_Gogh_-_Starry_Night_-_Google_Art_Project.jpg", 0, null },
                    { new Guid("897d2b8d-7dda-436d-8e5a-8f00b9a44c0b"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9430), null, "Yoga / Pilates", 0, null, "https://thamtapyoga.vn/wp-content/uploads/2024/01/3-2.jpeg", 2, null },
                    { new Guid("898202c3-19ef-4510-9eda-c24a8460a4f4"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9488), null, "Thi thoảng bất thường", 0, null, null, 4, null },
                    { new Guid("8a0cebf0-28fd-4b1d-a8e8-b5a25f688f24"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9413), null, "Quản lý cân nặng", 0, null, "https://thanhnien.mediacdn.vn/Uploaded/minhnguyet/2022_05_10/an-kieng-9141.jpg", 1, null },
                    { new Guid("8c6c797c-05ca-4dcb-8916-617b32b96f97"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9432), null, "Calisthenic", 0, null, "https://cdn.nhathuoclongchau.com.vn/unsafe/800x0/https://cms-prod.s3-sgn09.fptcloud.com/giai_dap_thac_mac_calisthenics_khac_gi_gym_1_8d5dd4026b.jpg", 2, null },
                    { new Guid("910af901-d1be-4f10-acb3-82ecdacffc56"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9384), null, "Du lịch", 0, null, "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/18/4f/7d/fc/caption.jpg?w=1200&h=1200&s=1", 0, null },
                    { new Guid("958ce2dd-e63e-4e93-9a9b-df4baf5d98de"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9369), null, "Bóng rổ", 0, null, "https://thethaothienlong.vn/wp-content/uploads/2022/04/Kich-thuoc-qua-bong-ro-1.jpg", 0, null },
                    { new Guid("97e34152-dcc7-4b2c-94c4-8db1eab790a6"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9394), null, "Nhiếp ảnh", 0, null, "https://aaftonline.com/blog/wp-content/uploads/2024/01/What-are-the-Benefits-of-Photography-Complete-Overview.png", 0, null },
                    { new Guid("9dc43fd6-f9de-438a-a4a3-0af5f0276d06"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9457), null, "Ngoại hình đẹp", 0, null, null, 3, null },
                    { new Guid("a5eb34d9-315e-42d3-b33c-12e0c5f607d7"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9453), null, "Khác giới", 0, 0, null, 3, null },
                    { new Guid("a742a330-df4a-48dc-a527-8ca591b2f5be"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9428), null, "Cải thiện sức khỏe tổng quát", 0, null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcThCjFemkP0h0IZYpu31k-xGK9IvigaysteqA&s", 1, null },
                    { new Guid("b196b1f6-c87b-434b-a4a2-7ec8cceaad4c"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9478), null, "Siêng năng", 0, null, null, 4, null },
                    { new Guid("b501e425-f95f-4f68-b527-67d94f16bec7"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9382), null, "Truyện tranh", 0, null, "https://taschen.makaira.media/taschen/image/upload/f_webp,w_1200/v1673462260/products-live/a3d446fb0046b587eb0ed76edca3f4d6.jpg", 0, null },
                    { new Guid("b94cf48f-92ac-4d36-aecb-9a5986dc7f28"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9392), null, "Game", 0, null, "https://genk.mediacdn.vn/139269124445442048/2022/7/28/tmb-1658998970448906989995.jpg", 0, null },
                    { new Guid("ba81f370-15be-4ff4-a8bd-a848f8a3f681"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9411), null, "Sống Ảo", 0, null, "https://imagev3.vietnamplus.vn/w1000/Uploaded/2024/hotnnz/2024_08_13/song-ao3-6646.jpg.webp", 0, null },
                    { new Guid("be4eee71-47b0-4568-8b2e-efd87ac3eab3"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9502), null, "Rảnh rỗi", 0, null, null, 4, null },
                    { new Guid("c29235a1-120f-437c-9746-88ccdfe49361"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9475), null, "Đảm bảo mục tiêu cho học viên", 0, null, null, 3, null },
                    { new Guid("c41bc5a5-69f3-47d6-88c4-c5cb79b21db3"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9465), null, "Có kinh nghiệm", 0, null, null, 3, null },
                    { new Guid("c7a1c458-fe4f-4f19-9fb2-f12b04a90e7b"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9483), null, "Năng động", 0, null, null, 4, null },
                    { new Guid("cca509be-d324-4561-9626-c2b2100d4971"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9422), null, "Cải thiện tình trạng bệnh", 0, null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQv509Yw7GUN5twNNk4G5Pvu1TBqFmhrL_3UQ&s", 1, null },
                    { new Guid("dc7acad6-345c-489f-86bc-f0b8ee61e8b0"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9397), null, "Nghe nhạc", 0, null, "https://static.vecteezy.com/system/resources/thumbnails/037/044/052/small_2x/ai-generated-studio-shot-of-black-headphones-over-music-note-explosion-background-with-empty-space-for-text-photo.jpg", 0, null },
                    { new Guid("de67f49e-57a1-4419-94a1-32788cf96db3"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9494), null, "Dễ nản", 0, null, null, 4, null },
                    { new Guid("df57334c-77f4-4f98-98fb-73b1c49bbead"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9489), null, "Lạnh lùng, ít nói", 0, null, null, 4, null },
                    { new Guid("e023d325-dabb-4ce1-9a76-63343e5d2d76"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9493), null, "Nhạy cảm", 0, null, null, 4, null },
                    { new Guid("e23372e9-e33b-485b-9b0f-bc42859cb214"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9458), null, "Cung cấp giá cả phải chăng", 0, null, null, 3, null },
                    { new Guid("e514cdbd-dc78-435e-84b8-3d299c438757"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9425), null, "Cải thiện sự dẻo dai", 0, null, "https://cdn.shopify.com/s/files/1/0453/0381/files/fullsizeoutput_2d4_1024x1024.jpg?v=1662646979", 1, null },
                    { new Guid("e5595468-7d02-4d1f-b0cd-ed86c1aa6d80"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9401), null, "Tán gẫu", 0, null, "https://transcode-v2.app.engoo.com/image/fetch/f_auto,c_lfill,w_300,dpr_3/https://assets.app.engoo.com/images/rGTEEA2fm66YMzeJz2UbwkKOW62bZVlqKOKZrXlMN7g.jpeg", 0, null },
                    { new Guid("e5e092d0-b089-47e0-b643-63fa62401edf"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9472), null, "Luôn sẵn sàng tư vấn ngoài giờ", 0, null, null, 3, null },
                    { new Guid("e72ba411-6498-4289-9688-d6a8aeffbf51"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9423), null, "Tăng cảm giác hạnh phúc, giảm căng thẳng", 0, null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT8ZXc_bemAYbupxmGz0pZGy4L1Zr6hGVsYdA&s", 1, null },
                    { new Guid("e9168ca8-2af2-45a7-abe6-b07bb29c4603"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9406), null, "Lịch Sử", 0, null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRWz_tIgvQXPAaSmvYa7CqZo_biaRK9D_O8uA&s", 0, null },
                    { new Guid("e98630e2-b975-4d75-8ed5-c74debdf0f3a"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9473), null, "Biết truyền cảm hứng, tạo động lực", 0, null, null, 3, null },
                    { new Guid("ea11f29e-fa79-4ba0-aa85-8fd6b920d6d9"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9450), null, "Thể dục nhịp điệu, theo nhạc", 0, null, "https://i.vietgiaitri.com/2018/10/9/the-duc-nhip-dieu-b2ab9f.jpg", 2, null },
                    { new Guid("ed9c94ed-e176-495e-9a49-42added8b0bd"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9496), null, "Hay bị lười", 0, null, null, 4, null },
                    { new Guid("ef2095d0-882e-4c6c-96cf-076b79e20320"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9389), null, "Đọc sách", 0, null, "https://images.theconversation.com/files/45159/original/rptgtpxd-1396254731.jpg?ixlib=rb-4.1.0&q=45&auto=format&w=1356&h=668&fit=crop", 0, null },
                    { new Guid("f53a0a95-85e0-497c-835a-b0aac370e5c6"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9404), null, "Công nghệ", 0, null, "https://www.simplilearn.com/ice9/free_resources_article_thumb/Technology_Trends.jpg", 0, null },
                    { new Guid("f9bda7ca-f857-475a-b7e0-de6f12abbe70"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9415), null, "Phát triển cơ bắp", 0, null, "https://www.dmoose.com/cdn/shop/articles/feature-image_87a28752-6da3-4be8-8814-d5221236136d.jpg?v=1676644951", 1, null },
                    { new Guid("fa0d0be6-e28a-4d7e-b04e-33428c2f5ee1"), "123abc", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9504), null, "Cầu toàn", 0, null, null, 4, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "FireBaseId", "AvatarUrl", "Balance", "Bio", "CreatedDate", "DateOfBirth", "DeletedDate", "Description", "Email", "Gender", "Height", "Id", "Job", "Latitude", "Longitude", "PTDegreeImageUrl", "PTExperienceYear", "PTRating", "PTStatus", "Password", "Phone", "PricePerHour", "RecordStatus", "Role", "Status", "SubscriptionLevel", "SubscriptionPaymentStatus", "SubscriptionPurchasedDate", "UpdatedDate", "UserName", "Weight" },
                values: new object[,]
                {
                    { "101jkl", "https://i.ibb.co/QY6zDfp/pt3.png", 3500, "Certified yoga instructor and personal trainer with 5 years of experience.", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9062), new DateTime(1988, 7, 15, 0, 0, 0, 0, DateTimeKind.Utc), null, null, "sarah.smith@example.com", 0, 170.19999999999999, new Guid("579500ef-f95a-4af6-9bfb-95417f1cb9cb"), "Yoga Instructor", 40.712800000000001, -74.006, null, 5.0, null, 1, "hashedpassword4", "5559876543", 200000.0, 0, 1, 0, null, null, null, null, "jocker_lol", 62.5 },
                    { "202mno", "https://i.ibb.co/27LXG3q/pt4.png", 2800, "CrossFit enthusiast and certified personal trainer specializing in HIIT workouts.", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9101), new DateTime(1995, 11, 22, 0, 0, 0, 0, DateTimeKind.Utc), null, null, "mike.johnson@example.com", 0, 180.0, new Guid("ad4de039-91d0-4566-b50c-2ad50baa81ee"), "CrossFit Trainer", 40.712800000000001, -74.006, null, 3.5, null, 1, "hashedpassword5", "5552468101", 180000.0, 0, 1, 0, null, null, null, null, "mike_johnson", 78.299999999999997 },
                    { "303pqr", "https://i.ibb.co/TWNFj0M/image.png", 4200, "Sports nutritionist and strength training coach with a focus on women's fitness.", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9107), new DateTime(1990, 5, 8, 0, 0, 0, 0, DateTimeKind.Utc), null, null, "emma.davis@example.com", 1, 165.5, new Guid("54aa3261-588d-47e5-94da-fcc4faddaef2"), "Strength Coach", 40.712800000000001, -74.006, null, 7.0, null, 1, "hashedpassword6", "5553691470", 220000.0, 0, 1, 0, null, null, null, null, "emma_davis", 58.700000000000003 },
                    { "404stu", "https://i.ibb.co/mR8n9zJ/pt2.png", 3800, "Former professional soccer player turned fitness coach. Specializes in sports-specific training.", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9113), new DateTime(1987, 9, 30, 0, 0, 0, 0, DateTimeKind.Utc), null, null, "carlos.rodriguez@example.com", 0, 175.30000000000001, new Guid("4083f14e-1896-46d5-b77c-2da56a511233"), "Sports Performance Coach", 40.712800000000001, -74.006, null, 6.5, null, 1, "hashedpassword7", "5557891234", 190000.0, 0, 1, 0, null, null, null, null, "carlos_rodriguez", 75.799999999999997 },
                    { "505vwx", "https://i.ibb.co/dDrHRqL/40c820d3e9d438025d4def0dedeab78a883cb8ab8c34614d1fb7d5ddf147668e-w-1024-h-1024-pmaid-165229888.png", 3200, "Pilates instructor and rehabilitation specialist. Focused on posture correction and core strength.", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9132), new DateTime(1993, 2, 14, 0, 0, 0, 0, DateTimeKind.Utc), null, null, "lisa.chen@example.com", 1, 162.0, new Guid("1ac57808-6b89-40c5-a91d-aca76d533758"), "Pilates Instructor", 40.712800000000001, -74.006, null, 4.0, null, 1, "hashedpassword8", "5554567890", 175000.0, 0, 1, 0, null, null, null, null, "lisa_chen", 54.200000000000003 },
                    { "606yza", "https://i.ibb.co/QY6zDfp/pt3.png", 4500, "Bodybuilding champion and powerlifting coach. Specializes in muscle gain and strength training.", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9138), new DateTime(1985, 8, 5, 0, 0, 0, 0, DateTimeKind.Utc), null, null, "marcus.brown@example.com", 0, 188.0, new Guid("b835fce0-eb54-435f-9edd-991cbabe6e9c"), "Strength and Conditioning Coach", 40.712800000000001, -74.006, null, 10.0, null, 1, "hashedpassword9", "5552345678", 230000.0, 0, 1, 0, null, null, null, null, "marcus_brown", 90.5 },
                    { "707bcd", "https://i.ibb.co/HYsHmpm/pt5.png", 3900, "Certified nutritionist and functional fitness trainer. Specializes in weight management and holistic health.", new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9151), new DateTime(1991, 12, 18, 0, 0, 0, 0, DateTimeKind.Utc), null, null, "will.taylor@example.com", 0, 168.5, new Guid("c0872c86-fac0-47d8-ae18-974803a89093"), "Functional Fitness Trainer", 40.712800000000001, -74.006, null, 3.5, null, 1, "hashedpassword10", "5558765432", 195000.0, 0, 1, 0, null, null, null, null, "will_taylor", 60.100000000000001 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_Users_CreateById",
                table: "Tags",
                column: "CreateById",
                principalTable: "Users",
                principalColumn: "FireBaseId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
