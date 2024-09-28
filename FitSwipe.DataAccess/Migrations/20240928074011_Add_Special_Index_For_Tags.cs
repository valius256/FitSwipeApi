using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FitSwipe.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Add_Special_Index_For_Tags : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "SpecialTag",
                table: "Tags",
                type: "integer",
                nullable: true);

            migrationBuilder.InsertData(
                table: "EmailTemplates",
                columns: new[] { "Id", "Body", "CreatedDate", "DeletedDate", "Description", "Name", "Params", "RecordStatus", "Status", "Subject", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("186371e4-bee0-4454-a917-b2a0ea0f0028"), "Chúng tôi đã nhận được yêu cầu đặt lại mật khẩu cho tài khoản của bạn tại FitWipe. Kính gửi [Name], vui lòng đặt lại mật khẩu của bạn bằng cách nhấn vào đường link sau: <a href=\"[ResetPasswordLink]\">Đặt lại mật khẩu</a>.<br><br>Nếu bạn không yêu cầu việc này, vui lòng bỏ qua email này.<br><br>Đội ngũ FitWipe", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4354), null, "Email này được gửi khi người dùng yêu cầu đặt lại mật khẩu cho tài khoản FitWipe.", "Forgot_Password", "[Name], [ResetPasswordLink]", 0, true, "Yêu cầu đặt lại mật khẩu FitWipe", null },
                    { new Guid("77081446-6469-4f01-915c-0008d121ed8d"), "Chào mừng bạn đến với FitWipe! Kính gửi [Name], vui lòng xác nhận địa chỉ email của bạn bằng cách nhấn vào đường link sau: <a href=\"[VerificationLink]\">Xác nhận Email</a>.<br><br>Cảm ơn bạn đã tham gia cùng chúng tôi!<br><br>Đội ngũ FitWipe", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4338), null, "Email này được gửi để xác nhận đăng ký tài khoản FitWipe.", "Register_Mail", "[Name], [VerificationLink]", 0, true, "Chào mừng đến với FitWipe! Vui lòng xác nhận email của bạn", null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreateById", "CreatedDate", "DeletedDate", "Name", "RecordStatus", "SpecialTag", "TagImage", "TagType", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("046b17a2-3847-43bc-a416-27795cfd2dcd"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4245), null, "Vui tính, hài hước", 0, null, null, 4, null },
                    { new Guid("084479e2-453c-4ef0-ad29-62dc17918271"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4117), null, "Thể thao trí tuệ", 0, null, "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6f/ChessSet.jpg/640px-ChessSet.jpg", 0, null },
                    { new Guid("0ac2aa99-4252-4c6b-ad85-1e38c64da948"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4283), null, "Rảnh rỗi", 0, null, null, 4, null },
                    { new Guid("0b00b2d7-4f82-47e0-a9c4-57d5cb93cf6d"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4202), null, "Cải thiện tình trạng bệnh", 0, null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQv509Yw7GUN5twNNk4G5Pvu1TBqFmhrL_3UQ&s", 1, null },
                    { new Guid("0cf277a8-8de4-44ee-a3de-fc522beb0b80"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4196), null, "Quản lý cân nặng", 0, null, "https://thanhnien.mediacdn.vn/Uploaded/minhnguyet/2022_05_10/an-kieng-9141.jpg", 1, null },
                    { new Guid("12898a9c-8b1a-4a8a-9511-bc865d6a1ae9"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4236), null, "Giàu kiến thức", 0, null, null, 3, null },
                    { new Guid("1f2c37ce-ed0e-41a9-a4b0-7db527b494e0"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4220), null, "Thể dục nhịp điệu, theo nhạc", 0, null, "https://i.vietgiaitri.com/2018/10/9/the-duc-nhip-dieu-b2ab9f.jpg", 2, null },
                    { new Guid("248cfff0-ea24-40bd-948b-ec27fc551470"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4102), null, "Bóng chuyền", 0, null, "https://file.hstatic.net/200000333667/article/image.jpg_4b1e1c8ce20f4c32824f275f34ff30af_1024x1024.jpg", 0, null },
                    { new Guid("25fab123-e126-4e49-bb2c-1b6761f1b0e7"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4230), null, "Tâm huyết với học viên", 0, null, null, 3, null },
                    { new Guid("26223132-03a6-4342-925e-1289fd59ff93"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4285), null, "Thoải mái", 0, null, null, 4, null },
                    { new Guid("26434370-2bf0-45ef-a318-63da37281acf"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4200), null, "Có body chuẩn chỉnh", 0, null, "https://cdn.nhathuoclongchau.com.vn/unsafe/800x0/https://cms-prod.s3-sgn09.fptcloud.com/fitness_la_gi_loi_ich_va_phuong_phap_tap_luyen_fitness_1_3c4e094223.png", 1, null },
                    { new Guid("2b2f66cf-7c98-496a-804f-b41b31d6b061"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4108), null, "Tập Gym", 0, null, "https://tiki.vn/blog/wp-content/uploads/2023/07/elite-fitness-1024x583.jpg", 0, null },
                    { new Guid("2fdd5635-e570-4018-b0b5-60b6ff2d5dfd"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4227), null, "Cung cấp giá cả phải chăng", 0, null, null, 3, null },
                    { new Guid("38b72fc4-db84-42e6-a4cd-68232270cbd0"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4215), null, "HIIT", 0, null, "https://hips.hearstapps.com/hmg-prod/images/athletes-doing-push-ups-with-dumbbells-on-floor-royalty-free-image-1638463573.jpg", 2, null },
                    { new Guid("38d30d7d-9496-4755-8f3f-f73649f492cf"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4212), null, "Tập sức mạnh", 0, null, "https://www.thethaothientruong.vn/uploads/2020/Powerlifting-la-gi.jpg", 2, null },
                    { new Guid("38f29e2d-8aff-4fe2-aad7-378f63b18068"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4184), null, "Chơi nhạc cụ", 0, null, "https://t3.ftcdn.net/jpg/01/34/38/92/360_F_134389281_5Jak3tbsoDggHIfIKKwJ8L7064ACIMNE.jpg", 0, null },
                    { new Guid("41c7408a-ede2-4d3d-9ab1-c09dbea91eaf"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4209), null, "Cải thiện sức khỏe tổng quát", 0, null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcThCjFemkP0h0IZYpu31k-xGK9IvigaysteqA&s", 1, null },
                    { new Guid("50693af5-52b2-4a08-b520-49b86ebb2ba3"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4216), null, "Kickfit", 0, null, "https://storage.googleapis.com/leep_app_website/2020/11/Kick-fit-khong-phai-la-kick-boxing.jpg", 2, null },
                    { new Guid("50de893a-77b7-46d5-8f51-8ff576e3717c"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4284), null, "Cầu toàn", 0, null, null, 4, null },
                    { new Guid("53610a61-af0b-450b-8f12-8f22fe7a74b3"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4178), null, "Nhiếp ảnh", 0, null, "https://aaftonline.com/blog/wp-content/uploads/2024/01/What-are-the-Benefits-of-Photography-Complete-Overview.png", 0, null },
                    { new Guid("58fb378d-4268-4ba9-b819-967cc8638a20"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4203), null, "Tăng cảm giác hạnh phúc, giảm căng thẳng", 0, null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT8ZXc_bemAYbupxmGz0pZGy4L1Zr6hGVsYdA&s", 1, null },
                    { new Guid("5c948a3b-d690-4c79-b077-e62add59d44b"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4104), null, "Bóng rổ", 0, null, "https://thethaothienlong.vn/wp-content/uploads/2022/04/Kich-thuoc-qua-bong-ro-1.jpg", 0, null },
                    { new Guid("5de3882c-8876-43f0-909a-2f972546e24e"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4107), null, "Bida", 0, null, "https://billiardshoanthuy.vn/wp-content/uploads/2021/05/phu-kien-ban-bida-2.jpg", 0, null },
                    { new Guid("616b7757-f98c-486f-b085-90509ff6bdec"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4228), null, "Gần", 0, 1, null, 3, null },
                    { new Guid("67719be1-3488-4833-b9e2-56d8c8364969"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4241), null, "Kiên trì", 0, null, null, 4, null },
                    { new Guid("683d1073-cd0b-4c43-9204-96278d65b1b2"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4201), null, "Phòng tránh bệnh", 0, null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQv509Yw7GUN5twNNk4G5Pvu1TBqFmhrL_3UQ&s", 1, null },
                    { new Guid("6a9f4424-30f4-42ca-86f9-0218e0262b3e"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4276), null, "Nhạy cảm", 0, null, null, 4, null },
                    { new Guid("6b7b30d8-cbe9-424e-976f-6c06de02ae2c"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4182), null, "Nghe nhạc", 0, null, "https://static.vecteezy.com/system/resources/thumbnails/037/044/052/small_2x/ai-generated-studio-shot-of-black-headphones-over-music-note-explosion-background-with-empty-space-for-text-photo.jpg", 0, null },
                    { new Guid("6b94dcee-8f4a-4973-95ef-ab0a2ecb8056"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4118), null, "Đọc sách", 0, null, "https://images.theconversation.com/files/45159/original/rptgtpxd-1396254731.jpg?ixlib=rb-4.1.0&q=45&auto=format&w=1356&h=668&fit=crop", 0, null },
                    { new Guid("724c4969-3c80-4164-a1bf-3efe4d6a0a89"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4238), null, "Biết truyền cảm hứng, tạo động lực", 0, null, null, 3, null },
                    { new Guid("7c708940-99a5-4702-96eb-452bf4b85b3f"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4100), null, "Cầu Lông", 0, null, "https://vecgroup.vn/images/products/2021/08/24/large/qua-cau-long_1629778779.jpg", 0, null },
                    { new Guid("8182b969-59d4-4ab3-b28e-fe81d9f2c665"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4226), null, "Ngoại hình đẹp", 0, null, null, 3, null },
                    { new Guid("8388e443-b629-4224-bb68-ef17783b18a9"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4248), null, "Dễ gần", 0, null, null, 4, null },
                    { new Guid("84b1da5e-b229-4b67-988b-0775acac570c"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4188), null, "Lịch Sử", 0, null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRWz_tIgvQXPAaSmvYa7CqZo_biaRK9D_O8uA&s", 0, null },
                    { new Guid("853bd588-87c0-4b9c-8b73-703e0d57c536"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4289), null, "Độc thân lâu năm", 0, null, null, 4, null },
                    { new Guid("9014099d-af92-4770-aa9d-8d4ed72544d5"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4288), null, "Dễ bị khó chịu", 0, null, null, 4, null },
                    { new Guid("92c79559-29dd-4709-a5ca-dcaec17b6456"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4207), null, "Cải thiện sức bền", 0, null, "https://vinmec-prod.s3.amazonaws.com/images/20210524_085806_814180_chay-bo-bao-nhieu-cal.max-800x800.jpg", 1, null },
                    { new Guid("92d67de8-bf14-42fe-9a20-1134e72533bc"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4191), null, "Triết học", 0, null, "https://www.rollingstone.com/wp-content/uploads/2024/01/unlocking_the_power_why_you_should_consider_hiring_philosophy_graduates-.jpg", 0, null },
                    { new Guid("93860d7d-4d38-45f1-b3f9-cb72f52c087a"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4224), null, "Khác giới", 0, 0, null, 3, null },
                    { new Guid("9393c533-d6c0-4307-b783-1444b4252fd9"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4085), null, "Bóng đá", 0, null, "https://cdn.tuoitre.vn/ttct//2020/12/13/16078750289060-lich-thi-dau-bong-da-hom-nay-0211.jpg", 0, null },
                    { new Guid("93f49eae-e763-4fba-b82b-facbf5af9e6b"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4279), null, "Hay bị lười", 0, null, null, 4, null },
                    { new Guid("9843e62b-f5a3-4e2d-93ab-bb3b009efd91"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4273), null, "Nhút nhát", 0, null, null, 4, null },
                    { new Guid("994ae7a6-fab7-4d63-a492-a42ed936417e"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4237), null, "Luôn sẵn sàng tư vấn ngoài giờ", 0, null, null, 3, null },
                    { new Guid("9d39de29-fb29-446c-81da-cd71ab94598d"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4197), null, "Phát triển cơ bắp", 0, null, "https://www.dmoose.com/cdn/shop/articles/feature-image_87a28752-6da3-4be8-8814-d5221236136d.jpg?v=1676644951", 1, null },
                    { new Guid("9ee3bd5e-c822-4d02-b43b-0a85fd71c8b3"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4282), null, "Hiền lành", 0, null, null, 4, null },
                    { new Guid("9f2f1f51-f0bd-407c-84f4-b520259e7869"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4105), null, "Thể thao nói chung", 0, null, "https://llv.edu.vn/media/2018/09/iStock-949190756-800x440.jpg", 0, null },
                    { new Guid("9f32584f-b234-4cc2-aaac-0276b7451959"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4110), null, "Đi, chạy bộ", 0, null, "https://pos.nvncdn.com/be3294-43017/art/artCT/20230228_9uObLfWys7Q0IXe4.jpg", 0, null },
                    { new Guid("9fc52271-509c-49d8-8874-6e2598c01af7"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4247), null, "Năng động", 0, null, null, 4, null },
                    { new Guid("a14ac864-546f-40ed-a714-5d1bf17f438e"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4243), null, "Siêng năng", 0, null, null, 4, null },
                    { new Guid("a287be8d-f0eb-49c0-96f7-758b9cd20dcc"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4176), null, "Game", 0, null, "https://genk.mediacdn.vn/139269124445442048/2022/7/28/tmb-1658998970448906989995.jpg", 0, null },
                    { new Guid("a2f2cbd0-172a-4144-a086-dcff60cf2e35"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4232), null, "Có trách nhiệm", 0, null, null, 3, null },
                    { new Guid("a8c23dc5-9fd2-44b7-83dd-9672c45aeabb"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4233), null, "Có kinh nghiệm", 0, null, null, 3, null },
                    { new Guid("b2f63fea-a572-4614-83df-833131e708ec"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4174), null, "Khoa học", 0, null, "https://www.training.com.au/wp-content/uploads/science-stem-feature.png", 0, null },
                    { new Guid("b36dc055-15f5-4df3-a548-5a0aecd7af32"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4099), null, "Bơi lội", 0, null, "https://file.hstatic.net/1000391576/file/boi_loi_7d4d69c53ac1494eabb2a446d4d503a0_grande.jpg", 0, null },
                    { new Guid("b7e98e43-ce66-4b77-9832-07258ac80720"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4189), null, "Địa lý", 0, null, "https://www.aag.org/wp-content/uploads/2021/12/shutterstock_1111879247.jpg", 0, null },
                    { new Guid("b7f2286d-1472-4064-827d-97fd1c502861"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4211), null, "Calisthenic", 0, null, "https://cdn.nhathuoclongchau.com.vn/unsafe/800x0/https://cms-prod.s3-sgn09.fptcloud.com/giai_dap_thac_mac_calisthenics_khac_gi_gym_1_8d5dd4026b.jpg", 2, null },
                    { new Guid("b97532ba-0ec1-47ad-93fd-8e5a70021143"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4112), null, "Phim ảnh", 0, null, "https://lawnet.vn/uploads/image/2023/10/17/015815855.jpg", 0, null },
                    { new Guid("bb85a97f-3ef0-4cca-a146-912a487fd86a"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4214), null, "Cardio", 0, null, "https://file.hstatic.net/1000308068/file/tap-cardio-vao-luc-nao-la-hieu-qua-nhat_cb884317c05d4df980138121ee113112_grande.jpg", 2, null },
                    { new Guid("c10f41dc-fbb1-4529-8b02-96719a857015"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4194), null, "Sống Ảo", 0, null, "https://imagev3.vietnamplus.vn/w1000/Uploaded/2024/hotnnz/2024_08_13/song-ao3-6646.jpg.webp", 0, null },
                    { new Guid("c838ca8a-be9f-4902-bab2-6beadc8d83c2"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4187), null, "Công nghệ", 0, null, "https://www.simplilearn.com/ice9/free_resources_article_thumb/Technology_Trends.jpg", 0, null },
                    { new Guid("cb720286-b137-4e47-93f9-b92983a54397"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4115), null, "Du lịch", 0, null, "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/18/4f/7d/fc/caption.jpg?w=1200&h=1200&s=1", 0, null },
                    { new Guid("cf762a23-090d-4146-be80-3d3788ccf215"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4185), null, "Tán gẫu", 0, null, "https://transcode-v2.app.engoo.com/image/fetch/f_auto,c_lfill,w_300,dpr_3/https://assets.app.engoo.com/images/rGTEEA2fm66YMzeJz2UbwkKOW62bZVlqKOKZrXlMN7g.jpeg", 0, null },
                    { new Guid("d39b856a-ccf9-427d-90ce-1964a3dddd33"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4205), null, "Cải thiện sự dẻo dai", 0, null, "https://cdn.shopify.com/s/files/1/0453/0381/files/fullsizeoutput_2d4_1024x1024.jpg?v=1662646979", 1, null },
                    { new Guid("dafbd727-f872-4058-b956-89fcfe8c936f"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4239), null, "Đảm bảo mục tiêu cho học viên", 0, null, null, 3, null },
                    { new Guid("dd55e29e-130a-44ab-b84f-e0e0df7f1a08"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4222), null, "Cùng giới", 0, 1, null, 3, null },
                    { new Guid("dfe60683-fd96-4b46-8db3-456cc382c590"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4235), null, "Không nặng nề với học viên", 0, null, null, 3, null },
                    { new Guid("e0e8ea3a-163f-4a58-a4ab-0ae6f67695aa"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4181), null, "Hội họa", 0, null, "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ea/Van_Gogh_-_Starry_Night_-_Google_Art_Project.jpg/1200px-Van_Gogh_-_Starry_Night_-_Google_Art_Project.jpg", 0, null },
                    { new Guid("e13dea97-3bef-43a4-ab7f-1308704062c7"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4219), null, "Tập ép dẻo", 0, null, "https://prod-everyoneactive-wp.s3.eu-west-2.amazonaws.com/wp-content/uploads/2020/03/23151503/flexibility-at-home.jpg", 2, null },
                    { new Guid("e1463b67-81dc-4210-87e7-762cf4786835"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4280), null, "Sẵn sàng học hỏi", 0, null, null, 4, null },
                    { new Guid("e8be3b15-ac9a-4ab3-ad40-39d07139cbf2"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4246), null, "Hòa đồng", 0, null, null, 4, null },
                    { new Guid("ee52ea2c-ba3d-47a9-833d-d6564f487038"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4272), null, "Lạnh lùng, ít nói", 0, null, null, 4, null },
                    { new Guid("f7e0def2-cacf-4944-92a6-c12dfc5fbf3a"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4210), null, "Yoga / Pilates", 0, null, "https://thamtapyoga.vn/wp-content/uploads/2024/01/3-2.jpeg", 2, null },
                    { new Guid("f8dd92f8-6cc4-4490-a8e2-f3e3a1919201"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4114), null, "Truyện tranh", 0, null, "https://taschen.makaira.media/taschen/image/upload/f_webp,w_1200/v1673462260/products-live/a3d446fb0046b587eb0ed76edca3f4d6.jpg", 0, null },
                    { new Guid("fda82cb9-bed1-466d-bd6e-45334d7f7c0a"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4270), null, "Thi thoảng bất thường", 0, null, null, 4, null },
                    { new Guid("ff635681-f851-4c6f-aa6e-6d5006945393"), "123abc", new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(4278), null, "Dễ nản", 0, null, null, 4, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "123abc",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(3607), new Guid("d3d0d2c0-c515-4f61-9109-00e91f710f2a") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "456def",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(3672), new Guid("55cd6401-d3d9-472d-a0bf-e2e209215256") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "789ghi",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 9, 28, 7, 40, 11, 490, DateTimeKind.Utc).AddTicks(3744), new Guid("1a938261-aa5b-4725-8603-6da3b85e5b14") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("186371e4-bee0-4454-a917-b2a0ea0f0028"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("77081446-6469-4f01-915c-0008d121ed8d"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("046b17a2-3847-43bc-a416-27795cfd2dcd"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("084479e2-453c-4ef0-ad29-62dc17918271"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("0ac2aa99-4252-4c6b-ad85-1e38c64da948"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("0b00b2d7-4f82-47e0-a9c4-57d5cb93cf6d"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("0cf277a8-8de4-44ee-a3de-fc522beb0b80"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("12898a9c-8b1a-4a8a-9511-bc865d6a1ae9"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("1f2c37ce-ed0e-41a9-a4b0-7db527b494e0"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("248cfff0-ea24-40bd-948b-ec27fc551470"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("25fab123-e126-4e49-bb2c-1b6761f1b0e7"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("26223132-03a6-4342-925e-1289fd59ff93"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("26434370-2bf0-45ef-a318-63da37281acf"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("2b2f66cf-7c98-496a-804f-b41b31d6b061"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("2fdd5635-e570-4018-b0b5-60b6ff2d5dfd"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("38b72fc4-db84-42e6-a4cd-68232270cbd0"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("38d30d7d-9496-4755-8f3f-f73649f492cf"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("38f29e2d-8aff-4fe2-aad7-378f63b18068"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("41c7408a-ede2-4d3d-9ab1-c09dbea91eaf"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("50693af5-52b2-4a08-b520-49b86ebb2ba3"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("50de893a-77b7-46d5-8f51-8ff576e3717c"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("53610a61-af0b-450b-8f12-8f22fe7a74b3"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("58fb378d-4268-4ba9-b819-967cc8638a20"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("5c948a3b-d690-4c79-b077-e62add59d44b"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("5de3882c-8876-43f0-909a-2f972546e24e"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("616b7757-f98c-486f-b085-90509ff6bdec"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("67719be1-3488-4833-b9e2-56d8c8364969"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("683d1073-cd0b-4c43-9204-96278d65b1b2"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("6a9f4424-30f4-42ca-86f9-0218e0262b3e"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("6b7b30d8-cbe9-424e-976f-6c06de02ae2c"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("6b94dcee-8f4a-4973-95ef-ab0a2ecb8056"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("724c4969-3c80-4164-a1bf-3efe4d6a0a89"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("7c708940-99a5-4702-96eb-452bf4b85b3f"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("8182b969-59d4-4ab3-b28e-fe81d9f2c665"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("8388e443-b629-4224-bb68-ef17783b18a9"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("84b1da5e-b229-4b67-988b-0775acac570c"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("853bd588-87c0-4b9c-8b73-703e0d57c536"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("9014099d-af92-4770-aa9d-8d4ed72544d5"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("92c79559-29dd-4709-a5ca-dcaec17b6456"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("92d67de8-bf14-42fe-9a20-1134e72533bc"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("93860d7d-4d38-45f1-b3f9-cb72f52c087a"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("9393c533-d6c0-4307-b783-1444b4252fd9"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("93f49eae-e763-4fba-b82b-facbf5af9e6b"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("9843e62b-f5a3-4e2d-93ab-bb3b009efd91"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("994ae7a6-fab7-4d63-a492-a42ed936417e"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("9d39de29-fb29-446c-81da-cd71ab94598d"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("9ee3bd5e-c822-4d02-b43b-0a85fd71c8b3"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("9f2f1f51-f0bd-407c-84f4-b520259e7869"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("9f32584f-b234-4cc2-aaac-0276b7451959"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("9fc52271-509c-49d8-8874-6e2598c01af7"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("a14ac864-546f-40ed-a714-5d1bf17f438e"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("a287be8d-f0eb-49c0-96f7-758b9cd20dcc"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("a2f2cbd0-172a-4144-a086-dcff60cf2e35"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("a8c23dc5-9fd2-44b7-83dd-9672c45aeabb"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("b2f63fea-a572-4614-83df-833131e708ec"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("b36dc055-15f5-4df3-a548-5a0aecd7af32"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("b7e98e43-ce66-4b77-9832-07258ac80720"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("b7f2286d-1472-4064-827d-97fd1c502861"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("b97532ba-0ec1-47ad-93fd-8e5a70021143"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("bb85a97f-3ef0-4cca-a146-912a487fd86a"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("c10f41dc-fbb1-4529-8b02-96719a857015"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("c838ca8a-be9f-4902-bab2-6beadc8d83c2"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("cb720286-b137-4e47-93f9-b92983a54397"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("cf762a23-090d-4146-be80-3d3788ccf215"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("d39b856a-ccf9-427d-90ce-1964a3dddd33"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("dafbd727-f872-4058-b956-89fcfe8c936f"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("dd55e29e-130a-44ab-b84f-e0e0df7f1a08"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("dfe60683-fd96-4b46-8db3-456cc382c590"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("e0e8ea3a-163f-4a58-a4ab-0ae6f67695aa"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("e13dea97-3bef-43a4-ab7f-1308704062c7"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("e1463b67-81dc-4210-87e7-762cf4786835"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("e8be3b15-ac9a-4ab3-ad40-39d07139cbf2"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("ee52ea2c-ba3d-47a9-833d-d6564f487038"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("f7e0def2-cacf-4944-92a6-c12dfc5fbf3a"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("f8dd92f8-6cc4-4490-a8e2-f3e3a1919201"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("fda82cb9-bed1-466d-bd6e-45334d7f7c0a"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("ff635681-f851-4c6f-aa6e-6d5006945393"));

            migrationBuilder.DropColumn(
                name: "SpecialTag",
                table: "Tags");

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
    }
}
