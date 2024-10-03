using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FitSwipe.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Add_Location_And_content_Property_For_Slot : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Slots",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true,
                oldDefaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "Slots",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Slots",
                type: "text",
                nullable: true);

            migrationBuilder.InsertData(
                table: "EmailTemplates",
                columns: new[] { "Id", "Body", "CreatedDate", "DeletedDate", "Description", "Name", "Params", "RecordStatus", "Status", "Subject", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("23070e1c-c31f-40f1-8a95-0707d886d124"), "Chúng tôi đã nhận được yêu cầu đặt lại mật khẩu cho tài khoản của bạn tại FitWipe. Kính gửi [Name], vui lòng đặt lại mật khẩu của bạn bằng cách nhấn vào đường link sau: <a href=\"[ResetPasswordLink]\">Đặt lại mật khẩu</a>.<br><br>Nếu bạn không yêu cầu việc này, vui lòng bỏ qua email này.<br><br>Đội ngũ FitWipe", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(4004), null, "Email này được gửi khi người dùng yêu cầu đặt lại mật khẩu cho tài khoản FitWipe.", "Forgot_Password", "[Name], [ResetPasswordLink]", 0, true, "Yêu cầu đặt lại mật khẩu FitWipe", null },
                    { new Guid("db43eaaf-f531-4562-854f-e5c1dcce4a00"), "Chào mừng bạn đến với FitWipe! Kính gửi [Name], vui lòng xác nhận địa chỉ email của bạn bằng cách nhấn vào đường link sau: <a href=\"[VerificationLink]\">Xác nhận Email</a>.<br><br>Cảm ơn bạn đã tham gia cùng chúng tôi!<br><br>Đội ngũ FitWipe", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3989), null, "Email này được gửi để xác nhận đăng ký tài khoản FitWipe.", "Register_Mail", "[Name], [VerificationLink]", 0, true, "Chào mừng đến với FitWipe! Vui lòng xác nhận email của bạn", null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreateById", "CreatedDate", "DeletedDate", "Name", "RecordStatus", "SpecialTag", "TagImage", "TagType", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0ba914c2-381a-4a15-9e46-36fe333c4b46"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3884), null, "Không nặng nề với học viên", 0, null, null, 3, null },
                    { new Guid("11e7a5ce-33c4-4181-8d1c-9579d96ddcf3"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3920), null, "Nhạy cảm", 0, null, null, 4, null },
                    { new Guid("14d30ff8-a703-4d1b-a9f6-b8bad5393235"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3828), null, "Hội họa", 0, null, "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ea/Van_Gogh_-_Starry_Night_-_Google_Art_Project.jpg/1200px-Van_Gogh_-_Starry_Night_-_Google_Art_Project.jpg", 0, null },
                    { new Guid("1ab59e53-8842-4939-b6dc-3f6281b69ff8"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3840), null, "Triết học", 0, null, "https://www.rollingstone.com/wp-content/uploads/2024/01/unlocking_the_power_why_you_should_consider_hiring_philosophy_graduates-.jpg", 0, null },
                    { new Guid("1c214fbf-6209-46a1-95a6-60129e11150c"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3933), null, "Độc thân lâu năm", 0, null, null, 4, null },
                    { new Guid("2446e977-a5fc-4882-a267-84851c6b2537"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3867), null, "Tập ép dẻo", 0, null, "https://prod-everyoneactive-wp.s3.eu-west-2.amazonaws.com/wp-content/uploads/2020/03/23151503/flexibility-at-home.jpg", 2, null },
                    { new Guid("272c63fb-91f2-4cd5-99f9-802a445c5fc7"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3831), null, "Chơi nhạc cụ", 0, null, "https://t3.ftcdn.net/jpg/01/34/38/92/360_F_134389281_5Jak3tbsoDggHIfIKKwJ8L7064ACIMNE.jpg", 0, null },
                    { new Guid("30b807ed-17a5-4c96-a601-127d24c4ce5a"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3910), null, "Hòa đồng", 0, null, null, 4, null },
                    { new Guid("31421207-b0a5-4fd5-9e9e-cb54295c3bd4"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3857), null, "Yoga / Pilates", 0, null, "https://thamtapyoga.vn/wp-content/uploads/2024/01/3-2.jpeg", 2, null },
                    { new Guid("317119d2-3331-464b-8234-8040e05f0e4b"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3816), null, "Truyện tranh", 0, null, "https://taschen.makaira.media/taschen/image/upload/f_webp,w_1200/v1673462260/products-live/a3d446fb0046b587eb0ed76edca3f4d6.jpg", 0, null },
                    { new Guid("334c898c-d175-456d-9db0-8d3ee963a581"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3830), null, "Nghe nhạc", 0, null, "https://static.vecteezy.com/system/resources/thumbnails/037/044/052/small_2x/ai-generated-studio-shot-of-black-headphones-over-music-note-explosion-background-with-empty-space-for-text-photo.jpg", 0, null },
                    { new Guid("33e0b6ce-b1b1-49a2-a137-38bc5a876b9c"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3921), null, "Dễ nản", 0, null, null, 4, null },
                    { new Guid("390d9f10-4544-42a7-95f0-a24be41051ec"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3859), null, "Calisthenic", 0, null, "https://cdn.nhathuoclongchau.com.vn/unsafe/800x0/https://cms-prod.s3-sgn09.fptcloud.com/giai_dap_thac_mac_calisthenics_khac_gi_gym_1_8d5dd4026b.jpg", 2, null },
                    { new Guid("3d3ebb16-c2b2-475c-9b18-e680f1f68a15"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3888), null, "Biết truyền cảm hứng, tạo động lực", 0, null, null, 3, null },
                    { new Guid("44d89b6f-37a3-4d91-8b38-e286d7916b26"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3872), null, "Khác giới", 0, 0, null, 3, null },
                    { new Guid("49fc0439-c067-4216-b1c2-8eca770f4f0b"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3824), null, "Game", 0, null, "https://genk.mediacdn.vn/139269124445442048/2022/7/28/tmb-1658998970448906989995.jpg", 0, null },
                    { new Guid("4b6389b7-6c75-437a-a437-8484db37b721"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3849), null, "Tăng cảm giác hạnh phúc, giảm căng thẳng", 0, null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT8ZXc_bemAYbupxmGz0pZGy4L1Zr6hGVsYdA&s", 1, null },
                    { new Guid("4bc2cf27-a370-449f-9442-b13413706035"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3877), null, "Gần", 0, 2, null, 3, null },
                    { new Guid("4d7def33-0385-43f5-a68a-0f76ce25a026"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3823), null, "Khoa học", 0, null, "https://www.training.com.au/wp-content/uploads/science-stem-feature.png", 0, null },
                    { new Guid("4e13c06e-cd04-4144-bb58-5fe8867f9582"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3930), null, "Thoải mái", 0, null, null, 4, null },
                    { new Guid("4edd74c9-a330-4ccf-b6b8-afdd3cfe2cba"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3777), null, "Bóng chuyền", 0, null, "https://file.hstatic.net/200000333667/article/image.jpg_4b1e1c8ce20f4c32824f275f34ff30af_1024x1024.jpg", 0, null },
                    { new Guid("53385bcf-9d43-468a-9ec6-5e0126e1d145"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3870), null, "Cùng giới", 0, 1, null, 3, null },
                    { new Guid("59e56bde-d15d-4b9d-981d-8148ca38b779"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3827), null, "Nhiếp ảnh", 0, null, "https://aaftonline.com/blog/wp-content/uploads/2024/01/What-are-the-Benefits-of-Photography-Complete-Overview.png", 0, null },
                    { new Guid("5b6db537-4203-4c14-bd6e-02c52d6d998e"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3893), null, "Siêng năng", 0, null, null, 4, null },
                    { new Guid("5bf5b2b5-0711-4cf2-80fe-f5fed4db4006"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3833), null, "Tán gẫu", 0, null, "https://transcode-v2.app.engoo.com/image/fetch/f_auto,c_lfill,w_300,dpr_3/https://assets.app.engoo.com/images/rGTEEA2fm66YMzeJz2UbwkKOW62bZVlqKOKZrXlMN7g.jpeg", 0, null },
                    { new Guid("5c3dc1cb-025f-486e-8e6b-405a5b35c04a"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3848), null, "Cải thiện tình trạng bệnh", 0, null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQv509Yw7GUN5twNNk4G5Pvu1TBqFmhrL_3UQ&s", 1, null },
                    { new Guid("640b7106-27bb-4ba5-bcb8-8d11167c621e"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3837), null, "Địa lý", 0, null, "https://www.aag.org/wp-content/uploads/2021/12/shutterstock_1111879247.jpg", 0, null },
                    { new Guid("65c0bcbc-d1b1-4b90-9b74-481336d2efbf"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3861), null, "Cardio", 0, null, "https://file.hstatic.net/1000308068/file/tap-cardio-vao-luc-nao-la-hieu-qua-nhat_cb884317c05d4df980138121ee113112_grande.jpg", 2, null },
                    { new Guid("66053374-d3f3-4cf6-ab6f-41c2f0710537"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3886), null, "Luôn sẵn sàng tư vấn ngoài giờ", 0, null, null, 3, null },
                    { new Guid("6974cda0-4e06-467a-8826-d569326d8dc5"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3918), null, "Nhút nhát", 0, null, null, 4, null },
                    { new Guid("6996b8cb-4ae1-4a87-bd66-8d0cca5fc476"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3924), null, "Sẵn sàng học hỏi", 0, null, null, 4, null },
                    { new Guid("69c490f4-93fb-47df-86ab-50822dbb8e65"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3780), null, "Thể thao nói chung", 0, null, "https://llv.edu.vn/media/2018/09/iStock-949190756-800x440.jpg", 0, null },
                    { new Guid("71056df5-03e5-461c-b00c-15a41ae900af"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3860), null, "Tập sức mạnh", 0, null, "https://www.thethaothientruong.vn/uploads/2020/Powerlifting-la-gi.jpg", 2, null },
                    { new Guid("73269ca9-81f0-4e85-8169-e2ded0c44177"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3842), null, "Quản lý cân nặng", 0, null, "https://thanhnien.mediacdn.vn/Uploaded/minhnguyet/2022_05_10/an-kieng-9141.jpg", 1, null },
                    { new Guid("732a417b-df84-40c1-8b57-800e8e108ff0"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3874), null, "Ngoại hình đẹp", 0, null, null, 3, null },
                    { new Guid("7db527b3-e307-4023-9930-da711d7d6c11"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3855), null, "Cải thiện sức bền", 0, null, "https://vinmec-prod.s3.amazonaws.com/images/20210524_085806_814180_chay-bo-bao-nhieu-cal.max-800x800.jpg", 1, null },
                    { new Guid("7f3b5a4a-79b3-4d08-a628-753725b7f96c"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3885), null, "Giàu kiến thức", 0, null, null, 3, null },
                    { new Guid("81c3efd3-2d1e-47b9-84a6-100ec92b78d4"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3863), null, "HIIT", 0, null, "https://hips.hearstapps.com/hmg-prod/images/athletes-doing-push-ups-with-dumbbells-on-floor-royalty-free-image-1638463573.jpg", 2, null },
                    { new Guid("8268863a-74db-4468-b04f-e68a914f0496"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3834), null, "Công nghệ", 0, null, "https://www.simplilearn.com/ice9/free_resources_article_thumb/Technology_Trends.jpg", 0, null },
                    { new Guid("896e1841-cdac-4fdb-935b-2eeecc60ca4e"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3866), null, "Kickfit", 0, null, "https://storage.googleapis.com/leep_app_website/2020/11/Kick-fit-khong-phai-la-kick-boxing.jpg", 2, null },
                    { new Guid("8ecc3332-7e27-4db7-b6c8-d7ce912fc4b7"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3786), null, "Đi, chạy bộ", 0, null, "https://pos.nvncdn.com/be3294-43017/art/artCT/20230228_9uObLfWys7Q0IXe4.jpg", 0, null },
                    { new Guid("95c9dfa9-6677-4001-a7f5-46919fcec11b"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3820), null, "Thể thao trí tuệ", 0, null, "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6f/ChessSet.jpg/640px-ChessSet.jpg", 0, null },
                    { new Guid("9b6303fa-6f25-4c0d-9d16-029aa10656b1"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3846), null, "Phòng tránh bệnh", 0, null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQv509Yw7GUN5twNNk4G5Pvu1TBqFmhrL_3UQ&s", 1, null },
                    { new Guid("a5901d79-b086-4c71-869f-0b6c2968163e"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3914), null, "Thi thoảng bất thường", 0, null, null, 4, null },
                    { new Guid("a69810cb-4396-4448-87b0-0b6fbbcbd768"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3814), null, "Phim ảnh", 0, null, "https://lawnet.vn/uploads/image/2023/10/17/015815855.jpg", 0, null },
                    { new Guid("aa6fcc1c-8da0-4daf-9ebe-fac4ffde66c4"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3781), null, "Bida", 0, null, "https://billiardshoanthuy.vn/wp-content/uploads/2021/05/phu-kien-ban-bida-2.jpg", 0, null },
                    { new Guid("ac915ed7-f005-422c-9232-7ad0b7a8e5be"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3892), null, "Kiên trì", 0, null, null, 4, null },
                    { new Guid("acfcb0f4-c046-4fb0-94f5-879bdf0aedf6"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3778), null, "Bóng rổ", 0, null, "https://thethaothienlong.vn/wp-content/uploads/2022/04/Kich-thuoc-qua-bong-ro-1.jpg", 0, null },
                    { new Guid("b80407e6-2164-4421-8715-e781bb2d1791"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3926), null, "Rảnh rỗi", 0, null, null, 4, null },
                    { new Guid("b8f345d2-7bec-4cc4-9d6b-33dc89502673"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3913), null, "Dễ gần", 0, null, null, 4, null },
                    { new Guid("b9b87061-5256-4c33-8e1a-5720cbe94747"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3818), null, "Du lịch", 0, null, "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/18/4f/7d/fc/caption.jpg?w=1200&h=1200&s=1", 0, null },
                    { new Guid("bba7ba0e-3c90-4728-b44f-236cc1c0588d"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3927), null, "Cầu toàn", 0, null, null, 4, null },
                    { new Guid("bbcb1845-03a4-47f9-b03b-7978c371347d"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3845), null, "Có body chuẩn chỉnh", 0, null, "https://cdn.nhathuoclongchau.com.vn/unsafe/800x0/https://cms-prod.s3-sgn09.fptcloud.com/fitness_la_gi_loi_ich_va_phuong_phap_tap_luyen_fitness_1_3c4e094223.png", 1, null },
                    { new Guid("c3f41a4c-6662-4c5e-96b8-207204e9fad6"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3770), null, "Bóng đá", 0, null, "https://cdn.tuoitre.vn/ttct//2020/12/13/16078750289060-lich-thi-dau-bong-da-hom-nay-0211.jpg", 0, null },
                    { new Guid("c4b02856-2fc2-45df-afae-44c41321e102"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3916), null, "Lạnh lùng, ít nói", 0, null, null, 4, null },
                    { new Guid("c64b54d8-9d8e-42fe-bc5e-62bc3d2125b9"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3836), null, "Lịch Sử", 0, null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRWz_tIgvQXPAaSmvYa7CqZo_biaRK9D_O8uA&s", 0, null },
                    { new Guid("c8af138d-47e0-431c-89dd-5ba0abc5ade1"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3853), null, "Cải thiện sự dẻo dai", 0, null, "https://cdn.shopify.com/s/files/1/0453/0381/files/fullsizeoutput_2d4_1024x1024.jpg?v=1662646979", 1, null },
                    { new Guid("cacd36a6-52d4-47d5-8f8e-41bfce8f3cab"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3879), null, "Tâm huyết với học viên", 0, null, null, 3, null },
                    { new Guid("d2f5e9c6-6845-428f-a08f-11f0279262af"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3875), null, "Cung cấp giá cả phải chăng", 0, null, null, 3, null },
                    { new Guid("d3a0ed82-2bdb-433c-a54a-3d7037ad3b91"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3868), null, "Thể dục nhịp điệu, theo nhạc", 0, null, "https://i.vietgiaitri.com/2018/10/9/the-duc-nhip-dieu-b2ab9f.jpg", 2, null },
                    { new Guid("d4e146c9-d4d4-4ec7-a388-fa16ec421eae"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3931), null, "Dễ bị khó chịu", 0, null, null, 4, null },
                    { new Guid("d574c585-31e3-42fa-a855-72fa69b6a63a"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3922), null, "Hay bị lười", 0, null, null, 4, null },
                    { new Guid("e511ff67-ba98-42e1-bbdb-5d8eb01f2581"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3889), null, "Đảm bảo mục tiêu cho học viên", 0, null, null, 3, null },
                    { new Guid("e8a7a606-2d85-4726-9643-38d60b515c3b"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3881), null, "Có trách nhiệm", 0, null, null, 3, null },
                    { new Guid("eaaa2550-4a49-4a0d-a9ae-116c12f17e15"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3925), null, "Hiền lành", 0, null, null, 4, null },
                    { new Guid("eb6ee450-8439-4f88-8943-b831d4947d22"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3912), null, "Năng động", 0, null, null, 4, null },
                    { new Guid("ec96f4de-6f0f-4758-bf34-cb1504cdc8c6"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3841), null, "Sống Ảo", 0, null, "https://imagev3.vietnamplus.vn/w1000/Uploaded/2024/hotnnz/2024_08_13/song-ao3-6646.jpg.webp", 0, null },
                    { new Guid("f231bdcd-4b9d-4db2-bf88-66b012d6cb10"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3844), null, "Phát triển cơ bắp", 0, null, "https://www.dmoose.com/cdn/shop/articles/feature-image_87a28752-6da3-4be8-8814-d5221236136d.jpg?v=1676644951", 1, null },
                    { new Guid("f2ac3954-e315-426a-8552-2234b29e31ec"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3783), null, "Tập Gym", 0, null, "https://tiki.vn/blog/wp-content/uploads/2023/07/elite-fitness-1024x583.jpg", 0, null },
                    { new Guid("f869c795-eaba-47a3-832e-37385b14d37d"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3883), null, "Có kinh nghiệm", 0, null, null, 3, null },
                    { new Guid("fac089b2-b100-4484-8112-45d7de8ae82b"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3773), null, "Bơi lội", 0, null, "https://file.hstatic.net/1000391576/file/boi_loi_7d4d69c53ac1494eabb2a446d4d503a0_grande.jpg", 0, null },
                    { new Guid("fb4bdcea-d499-4bd4-895c-13405cd92906"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3821), null, "Đọc sách", 0, null, "https://images.theconversation.com/files/45159/original/rptgtpxd-1396254731.jpg?ixlib=rb-4.1.0&q=45&auto=format&w=1356&h=668&fit=crop", 0, null },
                    { new Guid("fc540615-8c76-4a9e-a5cd-e4a1ad555007"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3856), null, "Cải thiện sức khỏe tổng quát", 0, null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcThCjFemkP0h0IZYpu31k-xGK9IvigaysteqA&s", 1, null },
                    { new Guid("ff3fbc6d-65b8-4f7a-aa46-b4d2404689ef"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3909), null, "Vui tính, hài hước", 0, null, null, 4, null },
                    { new Guid("ff93b179-c581-44fa-900c-3f60d00f3513"), "123abc", new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3775), null, "Cầu Lông", 0, null, "https://vecgroup.vn/images/products/2021/08/24/large/qua-cau-long_1629778779.jpg", 0, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "123abc",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3620), new Guid("179440ae-f3ae-4145-8630-7ea4f2d56c94") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "456def",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3663), new Guid("e05674fc-a68b-437d-b1bf-e5bdcdb43d23") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "789ghi",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 10, 2, 12, 42, 25, 722, DateTimeKind.Utc).AddTicks(3675), new Guid("e3f49f07-23ba-45dc-aa17-dd7f7e08c1be") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("23070e1c-c31f-40f1-8a95-0707d886d124"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("db43eaaf-f531-4562-854f-e5c1dcce4a00"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("0ba914c2-381a-4a15-9e46-36fe333c4b46"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("11e7a5ce-33c4-4181-8d1c-9579d96ddcf3"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("14d30ff8-a703-4d1b-a9f6-b8bad5393235"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("1ab59e53-8842-4939-b6dc-3f6281b69ff8"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("1c214fbf-6209-46a1-95a6-60129e11150c"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("2446e977-a5fc-4882-a267-84851c6b2537"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("272c63fb-91f2-4cd5-99f9-802a445c5fc7"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("30b807ed-17a5-4c96-a601-127d24c4ce5a"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("31421207-b0a5-4fd5-9e9e-cb54295c3bd4"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("317119d2-3331-464b-8234-8040e05f0e4b"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("334c898c-d175-456d-9db0-8d3ee963a581"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("33e0b6ce-b1b1-49a2-a137-38bc5a876b9c"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("390d9f10-4544-42a7-95f0-a24be41051ec"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("3d3ebb16-c2b2-475c-9b18-e680f1f68a15"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("44d89b6f-37a3-4d91-8b38-e286d7916b26"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("49fc0439-c067-4216-b1c2-8eca770f4f0b"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("4b6389b7-6c75-437a-a437-8484db37b721"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("4bc2cf27-a370-449f-9442-b13413706035"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("4d7def33-0385-43f5-a68a-0f76ce25a026"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("4e13c06e-cd04-4144-bb58-5fe8867f9582"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("4edd74c9-a330-4ccf-b6b8-afdd3cfe2cba"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("53385bcf-9d43-468a-9ec6-5e0126e1d145"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("59e56bde-d15d-4b9d-981d-8148ca38b779"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("5b6db537-4203-4c14-bd6e-02c52d6d998e"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("5bf5b2b5-0711-4cf2-80fe-f5fed4db4006"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("5c3dc1cb-025f-486e-8e6b-405a5b35c04a"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("640b7106-27bb-4ba5-bcb8-8d11167c621e"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("65c0bcbc-d1b1-4b90-9b74-481336d2efbf"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("66053374-d3f3-4cf6-ab6f-41c2f0710537"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("6974cda0-4e06-467a-8826-d569326d8dc5"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("6996b8cb-4ae1-4a87-bd66-8d0cca5fc476"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("69c490f4-93fb-47df-86ab-50822dbb8e65"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("71056df5-03e5-461c-b00c-15a41ae900af"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("73269ca9-81f0-4e85-8169-e2ded0c44177"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("732a417b-df84-40c1-8b57-800e8e108ff0"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("7db527b3-e307-4023-9930-da711d7d6c11"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("7f3b5a4a-79b3-4d08-a628-753725b7f96c"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("81c3efd3-2d1e-47b9-84a6-100ec92b78d4"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("8268863a-74db-4468-b04f-e68a914f0496"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("896e1841-cdac-4fdb-935b-2eeecc60ca4e"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("8ecc3332-7e27-4db7-b6c8-d7ce912fc4b7"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("95c9dfa9-6677-4001-a7f5-46919fcec11b"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("9b6303fa-6f25-4c0d-9d16-029aa10656b1"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("a5901d79-b086-4c71-869f-0b6c2968163e"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("a69810cb-4396-4448-87b0-0b6fbbcbd768"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("aa6fcc1c-8da0-4daf-9ebe-fac4ffde66c4"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("ac915ed7-f005-422c-9232-7ad0b7a8e5be"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("acfcb0f4-c046-4fb0-94f5-879bdf0aedf6"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("b80407e6-2164-4421-8715-e781bb2d1791"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("b8f345d2-7bec-4cc4-9d6b-33dc89502673"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("b9b87061-5256-4c33-8e1a-5720cbe94747"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("bba7ba0e-3c90-4728-b44f-236cc1c0588d"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("bbcb1845-03a4-47f9-b03b-7978c371347d"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("c3f41a4c-6662-4c5e-96b8-207204e9fad6"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("c4b02856-2fc2-45df-afae-44c41321e102"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("c64b54d8-9d8e-42fe-bc5e-62bc3d2125b9"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("c8af138d-47e0-431c-89dd-5ba0abc5ade1"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("cacd36a6-52d4-47d5-8f8e-41bfce8f3cab"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("d2f5e9c6-6845-428f-a08f-11f0279262af"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("d3a0ed82-2bdb-433c-a54a-3d7037ad3b91"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("d4e146c9-d4d4-4ec7-a388-fa16ec421eae"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("d574c585-31e3-42fa-a855-72fa69b6a63a"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("e511ff67-ba98-42e1-bbdb-5d8eb01f2581"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("e8a7a606-2d85-4726-9643-38d60b515c3b"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("eaaa2550-4a49-4a0d-a9ae-116c12f17e15"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("eb6ee450-8439-4f88-8943-b831d4947d22"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("ec96f4de-6f0f-4758-bf34-cb1504cdc8c6"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("f231bdcd-4b9d-4db2-bf88-66b012d6cb10"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("f2ac3954-e315-426a-8552-2234b29e31ec"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("f869c795-eaba-47a3-832e-37385b14d37d"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("fac089b2-b100-4484-8112-45d7de8ae82b"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("fb4bdcea-d499-4bd4-895c-13405cd92906"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("fc540615-8c76-4a9e-a5cd-e4a1ad555007"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("ff3fbc6d-65b8-4f7a-aa46-b4d2404689ef"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("ff93b179-c581-44fa-900c-3f60d00f3513"));

            migrationBuilder.DropColumn(
                name: "Content",
                table: "Slots");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Slots");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Slots",
                type: "integer",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldDefaultValue: 0);

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
    }
}
