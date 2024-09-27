using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FitSwipe.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Add_Description_Rename_Url_to_ThumbailUrl_To_SlotVideo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("2549dc34-b7e6-4d68-a026-8b5e09f23362"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("3d4a1c24-ed0b-4497-9019-99103af4390b"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("0cfc7076-b3d5-4b8b-b9d5-4ec5fb651d1c"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("4b379bea-f884-405d-8e47-6aa087633f14"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("5873fa44-8f08-45b2-8a00-6170515ca940"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("60856b8a-33b4-40b3-b4ce-a57a8c8b9a22"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("991b69e6-cf77-4d82-975d-0cdb0999f4a3"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("aed8e0d1-0b25-48e5-a50e-d39bfde282be"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("befc0381-c5bf-4b7c-abd3-d9180fe73c17"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("d98b9fbe-6ea2-404b-a171-ecc73ea95440"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("f6ebaff4-cf62-4fdd-9f2c-64f5cf609ec4"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("ff178496-071d-4830-89d4-e72cc7991552"));

            migrationBuilder.RenameColumn(
                name: "Url",
                table: "SlotVideos",
                newName: "ThumbnailUrl");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "SlotVideos",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "EmailTemplates",
                columns: new[] { "Id", "Body", "CreatedDate", "DeletedDate", "Description", "Name", "Params", "RecordStatus", "Status", "Subject", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("9dab181d-e92c-4c96-8639-58aca36dd0af"), "Chào mừng bạn đến với FitWipe! Kính gửi [Name], vui lòng xác nhận địa chỉ email của bạn bằng cách nhấn vào đường link sau: <a href=\"[VerificationLink]\">Xác nhận Email</a>.<br><br>Cảm ơn bạn đã tham gia cùng chúng tôi!<br><br>Đội ngũ FitWipe", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9444), null, "Email này được gửi để xác nhận đăng ký tài khoản FitWipe.", "Register_Mail", "[Name], [VerificationLink]", 0, true, "Chào mừng đến với FitWipe! Vui lòng xác nhận email của bạn", null },
                    { new Guid("b63a8267-fd8e-4afb-b2ef-1363896b704d"), "Chúng tôi đã nhận được yêu cầu đặt lại mật khẩu cho tài khoản của bạn tại FitWipe. Kính gửi [Name], vui lòng đặt lại mật khẩu của bạn bằng cách nhấn vào đường link sau: <a href=\"[ResetPasswordLink]\">Đặt lại mật khẩu</a>.<br><br>Nếu bạn không yêu cầu việc này, vui lòng bỏ qua email này.<br><br>Đội ngũ FitWipe", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9460), null, "Email này được gửi khi người dùng yêu cầu đặt lại mật khẩu cho tài khoản FitWipe.", "Forgot_Password", "[Name], [ResetPasswordLink]", 0, true, "Yêu cầu đặt lại mật khẩu FitWipe", null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreateById", "CreatedDate", "DeletedDate", "Name", "RecordStatus", "TagImage", "TagType", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("026c9bf5-1976-414d-90b4-ae7aa69906b3"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9320), null, "Kickfit", 0, "https://storage.googleapis.com/leep_app_website/2020/11/Kick-fit-khong-phai-la-kick-boxing.jpg", 2, null },
                    { new Guid("0673e71d-c5cb-4747-8f23-ab533f26190e"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9278), null, "Đọc sách", 0, "https://images.theconversation.com/files/45159/original/rptgtpxd-1396254731.jpg?ixlib=rb-4.1.0&q=45&auto=format&w=1356&h=668&fit=crop", 0, null },
                    { new Guid("078017a8-7b62-412a-81b1-901aa73724e4"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9289), null, "Tán gẫu", 0, "https://transcode-v2.app.engoo.com/image/fetch/f_auto,c_lfill,w_300,dpr_3/https://assets.app.engoo.com/images/rGTEEA2fm66YMzeJz2UbwkKOW62bZVlqKOKZrXlMN7g.jpeg", 0, null },
                    { new Guid("0aef0faf-db54-496e-9814-c53d2f2aed37"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9373), null, "Đảm bảo mục tiêu cho học viên", 0, null, 3, null },
                    { new Guid("0c93538c-5c00-42b6-baac-2e7b6836b176"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9302), null, "Có body chuẩn chỉnh", 0, "https://cdn.nhathuoclongchau.com.vn/unsafe/800x0/https://cms-prod.s3-sgn09.fptcloud.com/fitness_la_gi_loi_ich_va_phuong_phap_tap_luyen_fitness_1_3c4e094223.png", 1, null },
                    { new Guid("0ded48af-c30e-4a3c-8783-fead5ee70d30"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9282), null, "Game", 0, "https://genk.mediacdn.vn/139269124445442048/2022/7/28/tmb-1658998970448906989995.jpg", 0, null },
                    { new Guid("0f313c7e-36fe-4c2c-a5c7-03fd52c8d29f"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9334), null, "Có kinh nghiệm", 0, null, 3, null },
                    { new Guid("16f271c1-681e-4acb-8bd7-1948a03d5c72"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9265), null, "Thể thao nói chung", 0, "https://llv.edu.vn/media/2018/09/iStock-949190756-800x440.jpg", 0, null },
                    { new Guid("1899247b-bb23-4737-bc9e-6cefd64362d9"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9261), null, "Bóng chuyền", 0, "https://file.hstatic.net/200000333667/article/image.jpg_4b1e1c8ce20f4c32824f275f34ff30af_1024x1024.jpg", 0, null },
                    { new Guid("2087e966-862f-43ae-b5ec-483244ee2ba8"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9263), null, "Bóng rổ", 0, "https://thethaothienlong.vn/wp-content/uploads/2022/04/Kich-thuoc-qua-bong-ro-1.jpg", 0, null },
                    { new Guid("2344a487-1cab-410b-ae84-54d531e2d739"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9331), null, "Gần", 0, null, 3, null },
                    { new Guid("249b4ac0-df18-45a1-8d31-ef3accaad67a"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9281), null, "Khoa học", 0, "https://www.training.com.au/wp-content/uploads/science-stem-feature.png", 0, null },
                    { new Guid("2e3ba8da-4898-479b-973d-701a84b2dbc4"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9399), null, "Độc thân lâu năm", 0, null, 4, null },
                    { new Guid("36f5ec40-8e7b-4579-81bb-62afb0641dcb"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9378), null, "Hòa đồng", 0, null, 4, null },
                    { new Guid("3d4f0adc-fa91-4719-b6a7-22448461034b"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9312), null, "Yoga / Pilates", 0, "https://thamtapyoga.vn/wp-content/uploads/2024/01/3-2.jpeg", 2, null },
                    { new Guid("3e0874c3-9d6c-4f78-95db-40ec27f38735"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9385), null, "Lạnh lùng, ít nói", 0, null, 4, null },
                    { new Guid("4358d71c-71c9-482d-b5a0-90a26f95e272"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9377), null, "Vui tính, hài hước", 0, null, 4, null },
                    { new Guid("45635113-ece4-443d-a0b0-60c399a57bf3"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9298), null, "Sống Ảo", 0, "https://imagev3.vietnamplus.vn/w1000/Uploaded/2024/hotnnz/2024_08_13/song-ao3-6646.jpg.webp", 0, null },
                    { new Guid("53604545-8806-43f6-bb9c-021c20c49a28"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9222), null, "Bơi lội", 0, "https://file.hstatic.net/1000391576/file/boi_loi_7d4d69c53ac1494eabb2a446d4d503a0_grande.jpg", 0, null },
                    { new Guid("5b69a218-a081-4026-8c72-9d0b4f6ec4a4"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9224), null, "Cầu Lông", 0, "https://vecgroup.vn/images/products/2021/08/24/large/qua-cau-long_1629778779.jpg", 0, null },
                    { new Guid("5cc8cca2-56c3-4e8e-bac1-be7eed5a49d8"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9318), null, "Cardio", 0, "https://file.hstatic.net/1000308068/file/tap-cardio-vao-luc-nao-la-hieu-qua-nhat_cb884317c05d4df980138121ee113112_grande.jpg", 2, null },
                    { new Guid("5fa59548-dab3-49e2-9525-a4129bbe4327"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9337), null, "Giàu kiến thức", 0, null, 3, null },
                    { new Guid("5fadddba-d1db-46e5-8a65-118f74289531"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9286), null, "Nghe nhạc", 0, "https://static.vecteezy.com/system/resources/thumbnails/037/044/052/small_2x/ai-generated-studio-shot-of-black-headphones-over-music-note-explosion-background-with-empty-space-for-text-photo.jpg", 0, null },
                    { new Guid("6028368c-4f5a-4375-80d2-ab128e1c1bed"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9285), null, "Hội họa", 0, "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ea/Van_Gogh_-_Starry_Night_-_Google_Art_Project.jpg/1200px-Van_Gogh_-_Starry_Night_-_Google_Art_Project.jpg", 0, null },
                    { new Guid("605d27e2-b9a4-4793-8d5b-3498b4e5c1ac"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9301), null, "Phát triển cơ bắp", 0, "https://www.dmoose.com/cdn/shop/articles/feature-image_87a28752-6da3-4be8-8814-d5221236136d.jpg?v=1676644951", 1, null },
                    { new Guid("61741640-580d-4acf-9bfe-f01f6404b319"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9303), null, "Phòng tránh bệnh", 0, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQv509Yw7GUN5twNNk4G5Pvu1TBqFmhrL_3UQ&s", 1, null },
                    { new Guid("654bcd13-d808-42b6-8b3a-2d21e71fb97d"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9290), null, "Công nghệ", 0, "https://www.simplilearn.com/ice9/free_resources_article_thumb/Technology_Trends.jpg", 0, null },
                    { new Guid("6632d3a3-16a7-4894-839a-1e272582cdaa"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9395), null, "Cầu toàn", 0, null, 4, null },
                    { new Guid("671b87b7-574d-447f-8107-cfcbdca95175"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9274), null, "Truyện tranh", 0, "https://taschen.makaira.media/taschen/image/upload/f_webp,w_1200/v1673462260/products-live/a3d446fb0046b587eb0ed76edca3f4d6.jpg", 0, null },
                    { new Guid("6b273813-1626-4bc6-81a1-bf9b40984ba7"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9283), null, "Nhiếp ảnh", 0, "https://aaftonline.com/blog/wp-content/uploads/2024/01/What-are-the-Benefits-of-Photography-Complete-Overview.png", 0, null },
                    { new Guid("6b6a1ebf-2548-4ba9-b2f3-74ee4058d76c"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9324), null, "Thể dục nhịp điệu, theo nhạc", 0, "https://i.vietgiaitri.com/2018/10/9/the-duc-nhip-dieu-b2ab9f.jpg", 2, null },
                    { new Guid("6dea1c5e-5b7a-459a-b653-2ba8655267a7"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9386), null, "Nhút nhát", 0, null, 4, null },
                    { new Guid("6f245dce-fc7b-4be0-8f04-1ab2abc930fc"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9397), null, "Thoải mái", 0, null, 4, null },
                    { new Guid("71b56b91-6da1-44cd-8350-a23d78c67a61"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9273), null, "Phim ảnh", 0, "https://lawnet.vn/uploads/image/2023/10/17/015815855.jpg", 0, null },
                    { new Guid("72c26106-5037-4400-8068-97e0fc06f8d9"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9321), null, "Tập ép dẻo", 0, "https://prod-everyoneactive-wp.s3.eu-west-2.amazonaws.com/wp-content/uploads/2020/03/23151503/flexibility-at-home.jpg", 2, null },
                    { new Guid("768e495d-2c65-4467-90ab-320dfb6ddcba"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9371), null, "Biết truyền cảm hứng, tạo động lực", 0, null, 3, null },
                    { new Guid("7853ad68-a792-429f-91ad-7c38b55cde77"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9388), null, "Dễ nản", 0, null, 4, null },
                    { new Guid("79461e39-79e2-410c-b4b0-e0eacd7761d9"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9296), null, "Triết học", 0, "https://www.rollingstone.com/wp-content/uploads/2024/01/unlocking_the_power_why_you_should_consider_hiring_philosophy_graduates-.jpg", 0, null },
                    { new Guid("7f8d7e37-628d-458d-a651-02a34aed82eb"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9392), null, "Hiền lành", 0, null, 4, null },
                    { new Guid("8053cfb5-95e6-446c-82b5-a1f132924514"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9310), null, "Cải thiện sức bền", 0, "https://vinmec-prod.s3.amazonaws.com/images/20210524_085806_814180_chay-bo-bao-nhieu-cal.max-800x800.jpg", 1, null },
                    { new Guid("884a7e85-5cfd-4af8-9ed7-c1e60c2ba599"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9333), null, "Có trách nhiệm", 0, null, 3, null },
                    { new Guid("8d743caf-2ef4-4b51-93e2-3a9b62f8d001"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9315), null, "Tập sức mạnh", 0, "https://www.thethaothientruong.vn/uploads/2020/Powerlifting-la-gi.jpg", 2, null },
                    { new Guid("912d263e-5466-48c5-b760-37e23c484a60"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9338), null, "Luôn sẵn sàng tư vấn ngoài giờ", 0, null, 3, null },
                    { new Guid("92e577c3-6af9-45b0-a05f-81eaf37551e8"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9309), null, "Cải thiện sự dẻo dai", 0, "https://cdn.shopify.com/s/files/1/0453/0381/files/fullsizeoutput_2d4_1024x1024.jpg?v=1662646979", 1, null },
                    { new Guid("95de61bd-41a5-4df6-9cae-bb184060a4e2"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9271), null, "Đi, chạy bộ", 0, "https://pos.nvncdn.com/be3294-43017/art/artCT/20230228_9uObLfWys7Q0IXe4.jpg", 0, null },
                    { new Guid("9e7b2860-11ad-44da-8819-98e40dab668b"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9276), null, "Du lịch", 0, "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/18/4f/7d/fc/caption.jpg?w=1200&h=1200&s=1", 0, null },
                    { new Guid("a6f1c6d5-788b-4b3d-b33c-1d21f586d2f3"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9311), null, "Cải thiện sức khỏe tổng quát", 0, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcThCjFemkP0h0IZYpu31k-xGK9IvigaysteqA&s", 1, null },
                    { new Guid("a90b18b3-d2e8-4dcc-b1d7-6f6f8ba689ea"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9293), null, "Lịch Sử", 0, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRWz_tIgvQXPAaSmvYa7CqZo_biaRK9D_O8uA&s", 0, null },
                    { new Guid("ab230182-23e1-4bc3-8278-141720845270"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9394), null, "Rảnh rỗi", 0, null, 4, null },
                    { new Guid("ac15103e-b4c5-4d4f-a1dc-eabded5de807"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9287), null, "Chơi nhạc cụ", 0, "https://t3.ftcdn.net/jpg/01/34/38/92/360_F_134389281_5Jak3tbsoDggHIfIKKwJ8L7064ACIMNE.jpg", 0, null },
                    { new Guid("ad1d3642-d1e3-4267-9968-f894c6285405"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9398), null, "Dễ bị khó chịu", 0, null, 4, null },
                    { new Guid("ae1f7c21-73c9-499a-a36d-a6de9fa0c6c6"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9268), null, "Bida", 0, "https://billiardshoanthuy.vn/wp-content/uploads/2021/05/phu-kien-ban-bida-2.jpg", 0, null },
                    { new Guid("b1e2fe75-c015-43ec-a091-21ee3cb20828"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9379), null, "Năng động", 0, null, 4, null },
                    { new Guid("b5b3769e-560d-45f6-bd0f-9d3b44b63ff4"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9381), null, "Dễ gần", 0, null, 4, null },
                    { new Guid("babd1031-c47a-4155-a6df-5e2168c27750"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9314), null, "Calisthenic", 0, "https://cdn.nhathuoclongchau.com.vn/unsafe/800x0/https://cms-prod.s3-sgn09.fptcloud.com/giai_dap_thac_mac_calisthenics_khac_gi_gym_1_8d5dd4026b.jpg", 2, null },
                    { new Guid("bc8ffbcd-bb17-447c-bef7-9d0db02663c4"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9270), null, "Tập Gym", 0, "https://tiki.vn/blog/wp-content/uploads/2023/07/elite-fitness-1024x583.jpg", 0, null },
                    { new Guid("bcef80ba-3744-4cb4-b1e2-872d7f517da9"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9325), null, "Cùng giới", 0, null, 3, null },
                    { new Guid("bf28c84b-9f4b-424b-a206-6290a9c36504"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9391), null, "Sẵn sàng học hỏi", 0, null, 4, null },
                    { new Guid("c33797eb-24bb-4042-a110-0ff08ff36014"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9294), null, "Địa lý", 0, "https://www.aag.org/wp-content/uploads/2021/12/shutterstock_1111879247.jpg", 0, null },
                    { new Guid("c6210779-4926-4eb9-ad4d-b64f022b75fd"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9390), null, "Hay bị lười", 0, null, 4, null },
                    { new Guid("c6b3b650-2469-4b83-81d5-a97136162182"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9375), null, "Siêng năng", 0, null, 4, null },
                    { new Guid("ced8a812-2076-424d-a6bf-e536dcf37a20"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9332), null, "Tâm huyết với học viên", 0, null, 3, null },
                    { new Guid("d0757b7a-e694-4ea4-a4d2-c0b991bb7111"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9383), null, "Thi thoảng bất thường", 0, null, 4, null },
                    { new Guid("d1ff8db9-249f-4016-805d-9e0d61eaf537"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9306), null, "Cải thiện tình trạng bệnh", 0, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQv509Yw7GUN5twNNk4G5Pvu1TBqFmhrL_3UQ&s", 1, null },
                    { new Guid("d3dc082f-9580-4f20-a7f9-a3d096b284bb"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9327), null, "Ngoại hình đẹp", 0, null, 3, null },
                    { new Guid("d575d79b-d131-4f46-b11a-66f68689d6d1"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9277), null, "Thể thao trí tuệ", 0, "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6f/ChessSet.jpg/640px-ChessSet.jpg", 0, null },
                    { new Guid("d6eeb511-1c79-4f45-8082-70f6d4a7850a"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9307), null, "Tăng cảm giác hạnh phúc, giảm căng thẳng", 0, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT8ZXc_bemAYbupxmGz0pZGy4L1Zr6hGVsYdA&s", 1, null },
                    { new Guid("e76263db-10f6-4583-93da-22b4a03084be"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9336), null, "Không nặng nề với học viên", 0, null, 3, null },
                    { new Guid("ee2d2162-1351-4e2c-8dfb-79a31711d517"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9387), null, "Nhạy cảm", 0, null, 4, null },
                    { new Guid("ef557231-8fce-4c09-9a9a-4f929c3920e4"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9330), null, "Giá rẻ", 0, null, 3, null },
                    { new Guid("f2b76847-1c18-449b-9440-e1939a840222"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9319), null, "HIIT", 0, "https://hips.hearstapps.com/hmg-prod/images/athletes-doing-push-ups-with-dumbbells-on-floor-royalty-free-image-1638463573.jpg", 2, null },
                    { new Guid("f6967e2b-126e-477d-a3bb-8942344d8700"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9299), null, "Quản lý cân nặng", 0, "https://thanhnien.mediacdn.vn/Uploaded/minhnguyet/2022_05_10/an-kieng-9141.jpg", 1, null },
                    { new Guid("f698cba5-fa3a-4c14-9c6d-c5ddc3ceff40"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9374), null, "Kiên trì", 0, null, 4, null },
                    { new Guid("f775f955-f6d7-4e82-8c49-988bde1aec73"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9326), null, "Khác giới", 0, null, 3, null },
                    { new Guid("fd4cb8b9-d1b9-4ce9-902d-9accd17bf8dc"), "123abc", new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9219), null, "Bóng đá", 0, "https://cdn.tuoitre.vn/ttct//2020/12/13/16078750289060-lich-thi-dau-bong-da-hom-nay-0211.jpg", 0, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "123abc",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9048), new Guid("ee721eaa-5327-4776-9f3a-f54dc81e1070") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "456def",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9124), new Guid("256c9c22-a980-44ee-a6e6-291cbcfdde00") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "789ghi",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 9, 27, 15, 29, 16, 816, DateTimeKind.Utc).AddTicks(9135), new Guid("a6b29f5b-85f5-4862-ae31-80de282a4fe1") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("9dab181d-e92c-4c96-8639-58aca36dd0af"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("b63a8267-fd8e-4afb-b2ef-1363896b704d"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("026c9bf5-1976-414d-90b4-ae7aa69906b3"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("0673e71d-c5cb-4747-8f23-ab533f26190e"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("078017a8-7b62-412a-81b1-901aa73724e4"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("0aef0faf-db54-496e-9814-c53d2f2aed37"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("0c93538c-5c00-42b6-baac-2e7b6836b176"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("0ded48af-c30e-4a3c-8783-fead5ee70d30"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("0f313c7e-36fe-4c2c-a5c7-03fd52c8d29f"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("16f271c1-681e-4acb-8bd7-1948a03d5c72"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("1899247b-bb23-4737-bc9e-6cefd64362d9"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("2087e966-862f-43ae-b5ec-483244ee2ba8"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("2344a487-1cab-410b-ae84-54d531e2d739"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("249b4ac0-df18-45a1-8d31-ef3accaad67a"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("2e3ba8da-4898-479b-973d-701a84b2dbc4"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("36f5ec40-8e7b-4579-81bb-62afb0641dcb"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("3d4f0adc-fa91-4719-b6a7-22448461034b"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("3e0874c3-9d6c-4f78-95db-40ec27f38735"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("4358d71c-71c9-482d-b5a0-90a26f95e272"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("45635113-ece4-443d-a0b0-60c399a57bf3"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("53604545-8806-43f6-bb9c-021c20c49a28"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("5b69a218-a081-4026-8c72-9d0b4f6ec4a4"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("5cc8cca2-56c3-4e8e-bac1-be7eed5a49d8"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("5fa59548-dab3-49e2-9525-a4129bbe4327"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("5fadddba-d1db-46e5-8a65-118f74289531"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("6028368c-4f5a-4375-80d2-ab128e1c1bed"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("605d27e2-b9a4-4793-8d5b-3498b4e5c1ac"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("61741640-580d-4acf-9bfe-f01f6404b319"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("654bcd13-d808-42b6-8b3a-2d21e71fb97d"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("6632d3a3-16a7-4894-839a-1e272582cdaa"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("671b87b7-574d-447f-8107-cfcbdca95175"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("6b273813-1626-4bc6-81a1-bf9b40984ba7"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("6b6a1ebf-2548-4ba9-b2f3-74ee4058d76c"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("6dea1c5e-5b7a-459a-b653-2ba8655267a7"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("6f245dce-fc7b-4be0-8f04-1ab2abc930fc"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("71b56b91-6da1-44cd-8350-a23d78c67a61"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("72c26106-5037-4400-8068-97e0fc06f8d9"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("768e495d-2c65-4467-90ab-320dfb6ddcba"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("7853ad68-a792-429f-91ad-7c38b55cde77"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("79461e39-79e2-410c-b4b0-e0eacd7761d9"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("7f8d7e37-628d-458d-a651-02a34aed82eb"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("8053cfb5-95e6-446c-82b5-a1f132924514"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("884a7e85-5cfd-4af8-9ed7-c1e60c2ba599"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("8d743caf-2ef4-4b51-93e2-3a9b62f8d001"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("912d263e-5466-48c5-b760-37e23c484a60"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("92e577c3-6af9-45b0-a05f-81eaf37551e8"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("95de61bd-41a5-4df6-9cae-bb184060a4e2"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("9e7b2860-11ad-44da-8819-98e40dab668b"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("a6f1c6d5-788b-4b3d-b33c-1d21f586d2f3"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("a90b18b3-d2e8-4dcc-b1d7-6f6f8ba689ea"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("ab230182-23e1-4bc3-8278-141720845270"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("ac15103e-b4c5-4d4f-a1dc-eabded5de807"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("ad1d3642-d1e3-4267-9968-f894c6285405"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("ae1f7c21-73c9-499a-a36d-a6de9fa0c6c6"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("b1e2fe75-c015-43ec-a091-21ee3cb20828"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("b5b3769e-560d-45f6-bd0f-9d3b44b63ff4"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("babd1031-c47a-4155-a6df-5e2168c27750"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("bc8ffbcd-bb17-447c-bef7-9d0db02663c4"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("bcef80ba-3744-4cb4-b1e2-872d7f517da9"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("bf28c84b-9f4b-424b-a206-6290a9c36504"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("c33797eb-24bb-4042-a110-0ff08ff36014"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("c6210779-4926-4eb9-ad4d-b64f022b75fd"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("c6b3b650-2469-4b83-81d5-a97136162182"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("ced8a812-2076-424d-a6bf-e536dcf37a20"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("d0757b7a-e694-4ea4-a4d2-c0b991bb7111"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("d1ff8db9-249f-4016-805d-9e0d61eaf537"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("d3dc082f-9580-4f20-a7f9-a3d096b284bb"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("d575d79b-d131-4f46-b11a-66f68689d6d1"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("d6eeb511-1c79-4f45-8082-70f6d4a7850a"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("e76263db-10f6-4583-93da-22b4a03084be"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("ee2d2162-1351-4e2c-8dfb-79a31711d517"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("ef557231-8fce-4c09-9a9a-4f929c3920e4"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("f2b76847-1c18-449b-9440-e1939a840222"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("f6967e2b-126e-477d-a3bb-8942344d8700"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("f698cba5-fa3a-4c14-9c6d-c5ddc3ceff40"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("f775f955-f6d7-4e82-8c49-988bde1aec73"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("fd4cb8b9-d1b9-4ce9-902d-9accd17bf8dc"));

            migrationBuilder.DropColumn(
                name: "Description",
                table: "SlotVideos");

            migrationBuilder.RenameColumn(
                name: "ThumbnailUrl",
                table: "SlotVideos",
                newName: "Url");

            migrationBuilder.InsertData(
                table: "EmailTemplates",
                columns: new[] { "Id", "Body", "CreatedDate", "DeletedDate", "Description", "Name", "Params", "RecordStatus", "Status", "Subject", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("2549dc34-b7e6-4d68-a026-8b5e09f23362"), "Chúng tôi đã nhận được yêu cầu đặt lại mật khẩu cho tài khoản của bạn tại FitWipe. Kính gửi [Name], vui lòng đặt lại mật khẩu của bạn bằng cách nhấn vào đường link sau: <a href=\"[ResetPasswordLink]\">Đặt lại mật khẩu</a>.<br><br>Nếu bạn không yêu cầu việc này, vui lòng bỏ qua email này.<br><br>Đội ngũ FitWipe", new DateTime(2024, 9, 27, 7, 50, 24, 509, DateTimeKind.Utc).AddTicks(7771), null, "Email này được gửi khi người dùng yêu cầu đặt lại mật khẩu cho tài khoản FitWipe.", "Forgot_Password", "[Name], [ResetPasswordLink]", 0, true, "Yêu cầu đặt lại mật khẩu FitWipe", null },
                    { new Guid("3d4a1c24-ed0b-4497-9019-99103af4390b"), "Chào mừng bạn đến với FitWipe! Kính gửi [Name], vui lòng xác nhận địa chỉ email của bạn bằng cách nhấn vào đường link sau: <a href=\"[VerificationLink]\">Xác nhận Email</a>.<br><br>Cảm ơn bạn đã tham gia cùng chúng tôi!<br><br>Đội ngũ FitWipe", new DateTime(2024, 9, 27, 7, 50, 24, 509, DateTimeKind.Utc).AddTicks(7749), null, "Email này được gửi để xác nhận đăng ký tài khoản FitWipe.", "Register_Mail", "[Name], [VerificationLink]", 0, true, "Chào mừng đến với FitWipe! Vui lòng xác nhận email của bạn", null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreateById", "CreatedDate", "DeletedDate", "Name", "RecordStatus", "TagImage", "TagType", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0cfc7076-b3d5-4b8b-b9d5-4ec5fb651d1c"), "123abc", new DateTime(2024, 9, 27, 7, 50, 24, 509, DateTimeKind.Utc).AddTicks(7714), null, "Siêng năng", 0, null, 4, null },
                    { new Guid("4b379bea-f884-405d-8e47-6aa087633f14"), "123abc", new DateTime(2024, 9, 27, 7, 50, 24, 509, DateTimeKind.Utc).AddTicks(7709), null, "Ngoại hình đẹp", 0, null, 3, null },
                    { new Guid("5873fa44-8f08-45b2-8a00-6170515ca940"), "123abc", new DateTime(2024, 9, 27, 7, 50, 24, 509, DateTimeKind.Utc).AddTicks(7704), null, "Phát triển cơ bắp", 0, null, 1, null },
                    { new Guid("60856b8a-33b4-40b3-b4ce-a57a8c8b9a22"), "123abc", new DateTime(2024, 9, 27, 7, 50, 24, 509, DateTimeKind.Utc).AddTicks(7708), null, "Cardino", 0, null, 2, null },
                    { new Guid("991b69e6-cf77-4d82-975d-0cdb0999f4a3"), "123abc", new DateTime(2024, 9, 27, 7, 50, 24, 509, DateTimeKind.Utc).AddTicks(7685), null, "Giảm cân", 0, null, 1, null },
                    { new Guid("aed8e0d1-0b25-48e5-a50e-d39bfde282be"), "123abc", new DateTime(2024, 9, 27, 7, 50, 24, 509, DateTimeKind.Utc).AddTicks(7681), null, "Bóng đá", 0, null, 0, null },
                    { new Guid("befc0381-c5bf-4b7c-abd3-d9180fe73c17"), "123abc", new DateTime(2024, 9, 27, 7, 50, 24, 509, DateTimeKind.Utc).AddTicks(7713), null, "Kiên trì", 0, null, 4, null },
                    { new Guid("d98b9fbe-6ea2-404b-a171-ecc73ea95440"), "123abc", new DateTime(2024, 9, 27, 7, 50, 24, 509, DateTimeKind.Utc).AddTicks(7706), null, "Yoga", 0, null, 2, null },
                    { new Guid("f6ebaff4-cf62-4fdd-9f2c-64f5cf609ec4"), "123abc", new DateTime(2024, 9, 27, 7, 50, 24, 509, DateTimeKind.Utc).AddTicks(7683), null, "Video game", 0, null, 0, null },
                    { new Guid("ff178496-071d-4830-89d4-e72cc7991552"), "123abc", new DateTime(2024, 9, 27, 7, 50, 24, 509, DateTimeKind.Utc).AddTicks(7711), null, "Giá rẻ", 0, null, 3, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "123abc",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 9, 27, 7, 50, 24, 509, DateTimeKind.Utc).AddTicks(7495), new Guid("946e340e-2207-48fe-82f6-7ac424008bab") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "456def",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 9, 27, 7, 50, 24, 509, DateTimeKind.Utc).AddTicks(7538), new Guid("8a9d3d48-4fc4-4218-83db-8de82b247a28") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "789ghi",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 9, 27, 7, 50, 24, 509, DateTimeKind.Utc).AddTicks(7547), new Guid("6142fe08-d75d-46bb-bc89-a0f860192c0a") });
        }
    }
}
