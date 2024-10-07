using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FitSwipe.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Update_Property_For_Realtime_Chatting : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Message_ChatRoom_ChatRoomId",
                table: "Message");

            migrationBuilder.DropForeignKey(
                name: "FK_Message_Users_UserFirebaseId",
                table: "Message");

            migrationBuilder.DropForeignKey(
                name: "FK_UserChatRoom_ChatRoom_ChatRoomId",
                table: "UserChatRoom");

            migrationBuilder.DropForeignKey(
                name: "FK_UserChatRoom_Users_UserFirebaseId",
                table: "UserChatRoom");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserChatRoom",
                table: "UserChatRoom");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Message",
                table: "Message");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChatRoom",
                table: "ChatRoom");

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("22ec258e-7958-492d-ab08-216a09623e4b"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("6cfa782e-8fb0-439c-817a-3501777cc2be"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00efa009-bb6d-4cfc-8076-4371982d62f2"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("02e91999-97e7-4eab-a6f0-6ce99ef12d47"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("0628cccc-1d5e-4898-afec-0bd166aa4c2e"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("07c9b81b-b757-484d-92df-42827f4edb5d"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("0cf7a331-af01-4eef-9fc8-1f69990724b9"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("0f78dc08-41d1-4f72-9af4-b8ea8ed90b8e"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("0fa7c5fe-0e9f-4a24-9eed-81d1c9cb41cb"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("10a50f12-e646-47dc-baf9-8a7d6d1a0ed4"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("13f695e7-5752-4fc1-8be0-d418332fc007"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("174f6ae7-5491-426c-93a5-32660ee61190"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("1d72ca89-4187-47f7-bbf7-9f967bac681a"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("1eacd9c4-24b6-4198-9ae5-c47af28eb138"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("23061dad-35a0-4b19-93fe-1bc52879ee63"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("3361bbb4-905d-4731-819e-760a7c262306"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("34776aa4-b491-49f8-9cd6-715363657e69"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("398ff589-ed7c-4a13-9af7-f8128ce56d76"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("3c9bbb59-d489-4155-a29e-63e4053a118b"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("3d56443c-38fe-4157-aab8-aed04a5af9f3"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("3e9e7bbc-8fbe-4205-99eb-9d65a9f38b68"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("43ec96e4-8d3e-4f01-ac36-c76626ac3317"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("4495e43d-4f1e-4290-a76c-c04ff8b69ddd"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("449a90d0-c84c-448d-9650-bedc8df6b721"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("4934df40-1fc2-436a-a597-695fbd1c9271"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("49b3bb31-8117-4443-a117-edb8f2a3bf9b"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("49cbb02e-f212-4765-92e0-c922b14a9c73"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("501c338c-c2f2-4151-a99b-b9c2f9aecc1d"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("5e3237f3-667d-4bf3-8ef2-fdf19df96575"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("6979ea44-8be2-4d3a-b7cd-57ae160fd101"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("69fa736e-25ea-4028-94b9-16c71c6f4392"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("6ac2508f-3a1c-453c-864b-0fa76598cf00"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("6cdb9d20-2149-46b6-8b04-c7da4ee4b2b7"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("75ff233c-ca86-4309-918f-782f2b0c0a9b"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("7653db23-b9ac-4282-a6df-a28829b6256c"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("77b79b26-391f-47b2-9df0-a448093dc3f3"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("7a701f2c-68ab-4e8f-ba32-7c408796eae0"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("7d2904d7-a3e4-4c48-a526-fa3d8ef65d5b"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("7e819bc2-d2ca-457d-aefe-326f264c3348"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("7fdef875-f46b-4730-8dcb-c236106921a4"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("7fe87a79-fccc-467c-a467-215856e2bc2a"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("827e2284-cc23-4e5d-ada2-ab79d45e95da"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("886ae848-7f85-43dc-a8e1-a18dc0895869"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("8a0fb0c1-ffaf-4636-b058-93f88d0f9cda"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("8a1183e3-4b3e-42e2-a66f-f60e246dd144"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("8c5856f8-93a7-4225-9946-72cfa1a8b901"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("90de2233-37f7-4baf-adf0-7470bcd95134"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("94991376-6603-4646-b998-1d8bd91d1430"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("9584188e-af40-4fa6-9fe4-cc222fa36565"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("9667fc39-7934-4dcf-8cbb-0fbacdf37ce0"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("970b36d4-703f-4020-a6fd-ea195dcf57ec"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("97413666-fde4-480e-8c50-c6c8952d2c25"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("98adbeba-ee5a-466b-9794-98cbf4612c40"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("a76e7bd2-bfa2-4200-937c-52acea97d338"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("a9bb656c-709f-4015-9f4e-cd6f83708aa5"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("aa89997b-a937-4503-a6f3-0cc14cfef073"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("b3ab7fa5-1e10-43e6-bfdd-817ad380ff0c"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("b6414e17-3a7a-4371-882f-a3d538ce0ac8"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("b64ca38d-0bbe-497c-9f04-15b92cf640e7"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("b7a08b56-a766-477b-91c8-7e8af1b42ce5"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("b8ef3a73-ec80-4546-be6b-7c3b984a0300"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("bc222c1c-4704-4b96-bab3-4cb910181624"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("c0c47e2d-45dd-4bde-93b3-033aef710544"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("c23ee31b-11fc-495f-bef8-0c8f20e9e07f"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("c378eca7-6336-4b35-89e6-198ff66faa0d"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("c5a5f7b7-784f-4520-8738-44451bc23b2b"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("c792a42e-d9ff-4945-a816-05752f61eca2"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("cd535567-5cbf-4a69-853c-2fb4bcdb71a4"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("d4d3237a-c90c-46ac-b1e3-48bfbd343ffd"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("d8347015-a7a4-48fb-90ec-d647a813e0b5"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("daa2956a-2177-45e2-93fb-a248f6a47024"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("dbf3a817-5fa5-48bb-acfb-8bea7bc1e82e"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("dc184cd9-9828-412c-ba7e-9a88529a5f10"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("e634f0be-0ff2-48a7-b162-8aba42c82262"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("e93bb680-ade3-42a3-9ec5-479626f3f541"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("ec6b93e4-ba24-4736-8491-71dc5e3665ce"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("f47316fa-a007-4a52-a20a-116d2fcb50f3"));

            migrationBuilder.RenameTable(
                name: "UserChatRoom",
                newName: "UserChatRooms");

            migrationBuilder.RenameTable(
                name: "Message",
                newName: "Messages");

            migrationBuilder.RenameTable(
                name: "ChatRoom",
                newName: "ChatRooms");

            migrationBuilder.RenameIndex(
                name: "IX_UserChatRoom_ChatRoomId",
                table: "UserChatRooms",
                newName: "IX_UserChatRooms_ChatRoomId");

            migrationBuilder.RenameIndex(
                name: "IX_Message_UserFirebaseId",
                table: "Messages",
                newName: "IX_Messages_UserFirebaseId");

            migrationBuilder.RenameIndex(
                name: "IX_Message_ChatRoomId",
                table: "Messages",
                newName: "IX_Messages_ChatRoomId");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "UserChatRooms",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "UserChatRooms",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "UserChatRooms",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "RecordStatus",
                table: "UserChatRooms",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "UserChatRooms",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserChatRooms",
                table: "UserChatRooms",
                columns: new[] { "UserFirebaseId", "ChatRoomId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Messages",
                table: "Messages",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChatRooms",
                table: "ChatRooms",
                column: "Id");

            migrationBuilder.InsertData(
                table: "EmailTemplates",
                columns: new[] { "Id", "Body", "CreatedDate", "DeletedDate", "Description", "Name", "Params", "RecordStatus", "Status", "Subject", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("1088ebda-9d83-425c-ad28-885a758b8a48"), "Chúng tôi đã nhận được yêu cầu đặt lại mật khẩu cho tài khoản của bạn tại FitWipe. Kính gửi [Name], vui lòng đặt lại mật khẩu của bạn bằng cách nhấn vào đường link sau: <a href=\"[ResetPasswordLink]\">Đặt lại mật khẩu</a>.<br><br>Nếu bạn không yêu cầu việc này, vui lòng bỏ qua email này.<br><br>Đội ngũ FitWipe", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8822), null, "Email này được gửi khi người dùng yêu cầu đặt lại mật khẩu cho tài khoản FitWipe.", "Forgot_Password", "[Name], [ResetPasswordLink]", 0, true, "Yêu cầu đặt lại mật khẩu FitWipe", null },
                    { new Guid("5cb7f275-d2b4-4fa8-84c6-ba462d317ad7"), "Chào mừng bạn đến với FitWipe! Kính gửi [Name], vui lòng xác nhận địa chỉ email của bạn bằng cách nhấn vào đường link sau: <a href=\"[VerificationLink]\">Xác nhận Email</a>.<br><br>Cảm ơn bạn đã tham gia cùng chúng tôi!<br><br>Đội ngũ FitWipe", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8802), null, "Email này được gửi để xác nhận đăng ký tài khoản FitWipe.", "Register_Mail", "[Name], [VerificationLink]", 0, true, "Chào mừng đến với FitWipe! Vui lòng xác nhận email của bạn", null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreateById", "CreatedDate", "DeletedDate", "Name", "RecordStatus", "SpecialTag", "TagImage", "TagType", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("00f7e862-dbbd-4eeb-a608-a600c17a8d11"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8558), null, "Đi, chạy bộ", 0, null, "https://pos.nvncdn.com/be3294-43017/art/artCT/20230228_9uObLfWys7Q0IXe4.jpg", 0, null },
                    { new Guid("026563e1-2934-43bf-9e60-b81c21fdc0ca"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8686), null, "Nhạy cảm", 0, null, null, 4, null },
                    { new Guid("07542823-898c-4b82-8d5c-4efa31d8d6e7"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8656), null, "Tâm huyết với học viên", 0, null, null, 3, null },
                    { new Guid("0e86e285-a1af-4348-95f4-f4f6c499e7bf"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8662), null, "Giàu kiến thức", 0, null, null, 3, null },
                    { new Guid("0fa6852c-bfb7-4f17-87c4-5503cd334ca9"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8646), null, "Cùng giới", 0, 1, null, 3, null },
                    { new Guid("150968ad-a609-434c-9b1a-4e71fe2a31ae"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8568), null, "Khoa học", 0, null, "https://www.training.com.au/wp-content/uploads/science-stem-feature.png", 0, null },
                    { new Guid("1906f7b8-36ce-41c1-9b27-f90e2be09c10"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8574), null, "Nhiếp ảnh", 0, null, "https://aaftonline.com/blog/wp-content/uploads/2024/01/What-are-the-Benefits-of-Photography-Complete-Overview.png", 0, null },
                    { new Guid("1ba6c05c-7b9e-4738-ae40-f6d023acbf91"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8579), null, "Chơi nhạc cụ", 0, null, "https://t3.ftcdn.net/jpg/01/34/38/92/360_F_134389281_5Jak3tbsoDggHIfIKKwJ8L7064ACIMNE.jpg", 0, null },
                    { new Guid("1cf648db-5a73-480a-ad0e-427f3cc37e4b"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8602), null, "Tăng cảm giác hạnh phúc, giảm căng thẳng", 0, null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT8ZXc_bemAYbupxmGz0pZGy4L1Zr6hGVsYdA&s", 1, null },
                    { new Guid("1f3ef91e-f673-4350-ab94-8ad1252bdde8"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8603), null, "Cải thiện sự dẻo dai", 0, null, "https://cdn.shopify.com/s/files/1/0453/0381/files/fullsizeoutput_2d4_1024x1024.jpg?v=1662646979", 1, null },
                    { new Guid("1fe84570-aa36-489d-b30e-7d174b46ba60"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8678), null, "Dễ gần", 0, null, null, 4, null },
                    { new Guid("22465e4e-dd44-455b-a3ea-ac634f103513"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8549), null, "Bóng rổ", 0, null, "https://thethaothienlong.vn/wp-content/uploads/2022/04/Kich-thuoc-qua-bong-ro-1.jpg", 0, null },
                    { new Guid("33e38af7-14df-467d-b4cb-b1eed627cc86"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8597), null, "Phòng tránh bệnh", 0, null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQv509Yw7GUN5twNNk4G5Pvu1TBqFmhrL_3UQ&s", 1, null },
                    { new Guid("384c20c8-c284-4184-9d83-10e0ba517d2d"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8698), null, "Thoải mái", 0, null, null, 4, null },
                    { new Guid("3e945985-9a75-4491-8bee-9f89cb77f7b3"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8654), null, "Gần", 0, 2, null, 3, null },
                    { new Guid("3f9b4574-34df-44a2-b7f9-1ef059bac82d"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8595), null, "Có body chuẩn chỉnh", 0, null, "https://cdn.nhathuoclongchau.com.vn/unsafe/800x0/https://cms-prod.s3-sgn09.fptcloud.com/fitness_la_gi_loi_ich_va_phuong_phap_tap_luyen_fitness_1_3c4e094223.png", 1, null },
                    { new Guid("40b06200-a101-4c24-894d-3075872a87a7"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8694), null, "Rảnh rỗi", 0, null, null, 4, null },
                    { new Guid("40faaab5-1d84-49ef-8f0f-40a447d946ce"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8668), null, "Đảm bảo mục tiêu cho học viên", 0, null, null, 3, null },
                    { new Guid("43124093-336b-43cf-92ed-34d06fcb508d"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8561), null, "Truyện tranh", 0, null, "https://taschen.makaira.media/taschen/image/upload/f_webp,w_1200/v1673462260/products-live/a3d446fb0046b587eb0ed76edca3f4d6.jpg", 0, null },
                    { new Guid("44a27be3-9f88-4ccd-aa2f-fd0d0ce8019e"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8657), null, "Có trách nhiệm", 0, null, null, 3, null },
                    { new Guid("4628e6d1-46d5-4b8c-a3d8-0a1d2fdeb4b8"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8702), null, "Độc thân lâu năm", 0, null, null, 4, null },
                    { new Guid("46a322cd-1d5a-45e0-a011-07e606fd9a2a"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8697), null, "Cầu toàn", 0, null, null, 4, null },
                    { new Guid("499d68e1-1dcc-44cf-b64c-e0296055b810"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8592), null, "Quản lý cân nặng", 0, null, "https://thanhnien.mediacdn.vn/Uploaded/minhnguyet/2022_05_10/an-kieng-9141.jpg", 1, null },
                    { new Guid("49b361f2-07a0-4ffb-b489-a93d602d6629"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8649), null, "Ngoại hình đẹp", 0, null, null, 3, null },
                    { new Guid("4af816c9-4ce9-43f4-88d9-ebc938212ebf"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8631), null, "Yoga / Pilates", 0, null, "https://thamtapyoga.vn/wp-content/uploads/2024/01/3-2.jpeg", 2, null },
                    { new Guid("4c7d54bc-7c33-4973-8407-9a4978c92a2f"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8590), null, "Sống Ảo", 0, null, "https://imagev3.vietnamplus.vn/w1000/Uploaded/2024/hotnnz/2024_08_13/song-ao3-6646.jpg.webp", 0, null },
                    { new Guid("527c5ad5-f53f-4cd8-af93-0b7b62a82ded"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8599), null, "Cải thiện tình trạng bệnh", 0, null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQv509Yw7GUN5twNNk4G5Pvu1TBqFmhrL_3UQ&s", 1, null },
                    { new Guid("581a0087-cc79-4075-8c71-9c807a8b82f0"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8634), null, "Tập sức mạnh", 0, null, "https://www.thethaothientruong.vn/uploads/2020/Powerlifting-la-gi.jpg", 2, null },
                    { new Guid("5a2f2306-dc81-4ebb-af05-0559a9bc6392"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8670), null, "Kiên trì", 0, null, null, 4, null },
                    { new Guid("5b272c69-948a-445d-b901-745f52e58b9c"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8674), null, "Hòa đồng", 0, null, null, 4, null },
                    { new Guid("5b76ee68-a0ca-499b-a085-6466003a3fcb"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8560), null, "Phim ảnh", 0, null, "https://lawnet.vn/uploads/image/2023/10/17/015815855.jpg", 0, null },
                    { new Guid("5fb4e449-be5e-4959-a138-682280153964"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8689), null, "Hay bị lười", 0, null, null, 4, null },
                    { new Guid("6005034c-f627-4482-b9e6-bd80ec61564c"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8605), null, "Cải thiện sức bền", 0, null, "https://vinmec-prod.s3.amazonaws.com/images/20210524_085806_814180_chay-bo-bao-nhieu-cal.max-800x800.jpg", 1, null },
                    { new Guid("6fe2eb53-c4c8-49aa-ac27-a2bf81a3e5bb"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8639), null, "HIIT", 0, null, "https://hips.hearstapps.com/hmg-prod/images/athletes-doing-push-ups-with-dumbbells-on-floor-royalty-free-image-1638463573.jpg", 2, null },
                    { new Guid("701d94ec-2c41-4cdd-84c2-8fe1f3326873"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8641), null, "Kickfit", 0, null, "https://storage.googleapis.com/leep_app_website/2020/11/Kick-fit-khong-phai-la-kick-boxing.jpg", 2, null },
                    { new Guid("7429d1dc-b209-45bb-af1c-2a15b514bae9"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8563), null, "Du lịch", 0, null, "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/18/4f/7d/fc/caption.jpg?w=1200&h=1200&s=1", 0, null },
                    { new Guid("7a584c25-4d4f-437b-a2b5-79f58d6589ec"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8683), null, "Lạnh lùng, ít nói", 0, null, null, 4, null },
                    { new Guid("8008bf4b-7ef1-41b8-a476-8e9920589f80"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8636), null, "Cardio", 0, null, "https://file.hstatic.net/1000308068/file/tap-cardio-vao-luc-nao-la-hieu-qua-nhat_cb884317c05d4df980138121ee113112_grande.jpg", 2, null },
                    { new Guid("82a9ddfa-001c-43f4-abdd-f27dc031d6f9"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8687), null, "Dễ nản", 0, null, null, 4, null },
                    { new Guid("85a50e7b-fe1a-4b0a-9972-4c8c27b6020f"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8553), null, "Bida", 0, null, "https://billiardshoanthuy.vn/wp-content/uploads/2021/05/phu-kien-ban-bida-2.jpg", 0, null },
                    { new Guid("8ad6e980-637f-46a3-b705-93fe8012658a"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8575), null, "Hội họa", 0, null, "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ea/Van_Gogh_-_Starry_Night_-_Google_Art_Project.jpg/1200px-Van_Gogh_-_Starry_Night_-_Google_Art_Project.jpg", 0, null },
                    { new Guid("8be2943e-69c2-4214-a6a5-45ed573b454c"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8673), null, "Vui tính, hài hước", 0, null, null, 4, null },
                    { new Guid("8e42f639-9d23-4ae3-aa07-1e057c81226a"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8651), null, "Cung cấp giá cả phải chăng", 0, null, null, 3, null },
                    { new Guid("95f10990-3cac-459d-9d0a-590afe82d395"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8665), null, "Biết truyền cảm hứng, tạo động lực", 0, null, null, 3, null },
                    { new Guid("994b6279-6027-4525-ab51-e6c1f63d1142"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8659), null, "Có kinh nghiệm", 0, null, null, 3, null },
                    { new Guid("9aa5a039-d7cc-4bf0-be28-1ccab2374c46"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8582), null, "Công nghệ", 0, null, "https://www.simplilearn.com/ice9/free_resources_article_thumb/Technology_Trends.jpg", 0, null },
                    { new Guid("9b23533e-377c-4983-b86f-52e7f4b85903"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8589), null, "Triết học", 0, null, "https://www.rollingstone.com/wp-content/uploads/2024/01/unlocking_the_power_why_you_should_consider_hiring_philosophy_graduates-.jpg", 0, null },
                    { new Guid("9f16f1d4-2138-4023-9cba-606a6954de94"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8584), null, "Lịch Sử", 0, null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRWz_tIgvQXPAaSmvYa7CqZo_biaRK9D_O8uA&s", 0, null },
                    { new Guid("a171a83c-849b-48c0-bb06-66c948bb1f64"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8700), null, "Dễ bị khó chịu", 0, null, null, 4, null },
                    { new Guid("a5a03ee8-4b74-4487-b126-5590645df20f"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8644), null, "Thể dục nhịp điệu, theo nhạc", 0, null, "https://i.vietgiaitri.com/2018/10/9/the-duc-nhip-dieu-b2ab9f.jpg", 2, null },
                    { new Guid("a87f2e98-bf60-40f2-85c5-29a2e2ae419b"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8587), null, "Địa lý", 0, null, "https://www.aag.org/wp-content/uploads/2021/12/shutterstock_1111879247.jpg", 0, null },
                    { new Guid("ac40ed89-1a89-4ef7-90d4-566c68314f53"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8680), null, "Thi thoảng bất thường", 0, null, null, 4, null },
                    { new Guid("ad23c5c3-3361-4182-a245-4acee3b9d068"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8572), null, "Game", 0, null, "https://genk.mediacdn.vn/139269124445442048/2022/7/28/tmb-1658998970448906989995.jpg", 0, null },
                    { new Guid("ada5731e-12b8-4c0e-8ab8-c079b04eabb8"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8676), null, "Năng động", 0, null, null, 4, null },
                    { new Guid("ae70cc07-1b6c-4de3-b797-365c258dba2e"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8580), null, "Tán gẫu", 0, null, "https://transcode-v2.app.engoo.com/image/fetch/f_auto,c_lfill,w_300,dpr_3/https://assets.app.engoo.com/images/rGTEEA2fm66YMzeJz2UbwkKOW62bZVlqKOKZrXlMN7g.jpeg", 0, null },
                    { new Guid("b1287b3f-7999-4154-9499-7dc4c5fee0ec"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8690), null, "Sẵn sàng học hỏi", 0, null, null, 4, null },
                    { new Guid("b5839c12-6b6e-4b32-bcd9-364542953cd6"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8546), null, "Cầu Lông", 0, null, "https://vecgroup.vn/images/products/2021/08/24/large/qua-cau-long_1629778779.jpg", 0, null },
                    { new Guid("bb5846f8-e192-4eb7-bd32-7ce7c1e25535"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8548), null, "Bóng chuyền", 0, null, "https://file.hstatic.net/200000333667/article/image.jpg_4b1e1c8ce20f4c32824f275f34ff30af_1024x1024.jpg", 0, null },
                    { new Guid("bd57e151-e026-4c04-b9f2-7e40bdf437e0"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8643), null, "Tập ép dẻo", 0, null, "https://prod-everyoneactive-wp.s3.eu-west-2.amazonaws.com/wp-content/uploads/2020/03/23151503/flexibility-at-home.jpg", 2, null },
                    { new Guid("bd72993b-146c-4b26-afd8-0e2e57e9f475"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8551), null, "Thể thao nói chung", 0, null, "https://llv.edu.vn/media/2018/09/iStock-949190756-800x440.jpg", 0, null },
                    { new Guid("c529175b-4ea8-4d27-b712-eb205ae2a748"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8629), null, "Cải thiện sức khỏe tổng quát", 0, null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcThCjFemkP0h0IZYpu31k-xGK9IvigaysteqA&s", 1, null },
                    { new Guid("c640ad21-e4b2-4607-8c7d-e757bb7c2a46"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8671), null, "Siêng năng", 0, null, null, 4, null },
                    { new Guid("d15b6a12-0296-46d5-95d3-4152c63ece19"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8664), null, "Luôn sẵn sàng tư vấn ngoài giờ", 0, null, null, 3, null },
                    { new Guid("d2f5641c-c2e0-40dd-aff7-34d0c4fcbee0"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8564), null, "Thể thao trí tuệ", 0, null, "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6f/ChessSet.jpg/640px-ChessSet.jpg", 0, null },
                    { new Guid("db871eb8-8663-4703-8c6b-997d827a080d"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8684), null, "Nhút nhát", 0, null, null, 4, null },
                    { new Guid("db9d6bdf-42c3-4381-8887-5c3a5beebb4e"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8541), null, "Bóng đá", 0, null, "https://cdn.tuoitre.vn/ttct//2020/12/13/16078750289060-lich-thi-dau-bong-da-hom-nay-0211.jpg", 0, null },
                    { new Guid("e13d682f-4a00-4654-b5a1-c0c69239a9ab"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8577), null, "Nghe nhạc", 0, null, "https://static.vecteezy.com/system/resources/thumbnails/037/044/052/small_2x/ai-generated-studio-shot-of-black-headphones-over-music-note-explosion-background-with-empty-space-for-text-photo.jpg", 0, null },
                    { new Guid("e2f87e5a-5b2b-43b9-bae2-95495b94295f"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8632), null, "Calisthenic", 0, null, "https://cdn.nhathuoclongchau.com.vn/unsafe/800x0/https://cms-prod.s3-sgn09.fptcloud.com/giai_dap_thac_mac_calisthenics_khac_gi_gym_1_8d5dd4026b.jpg", 2, null },
                    { new Guid("e3aba9e5-3cb4-45ae-a176-86e0fe493c7d"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8594), null, "Phát triển cơ bắp", 0, null, "https://www.dmoose.com/cdn/shop/articles/feature-image_87a28752-6da3-4be8-8814-d5221236136d.jpg?v=1676644951", 1, null },
                    { new Guid("e6c91982-f8f2-4740-9ef3-e23186dfff61"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8660), null, "Không nặng nề với học viên", 0, null, null, 3, null },
                    { new Guid("e7481ce0-412d-4964-8b88-88031525fb30"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8544), null, "Bơi lội", 0, null, "https://file.hstatic.net/1000391576/file/boi_loi_7d4d69c53ac1494eabb2a446d4d503a0_grande.jpg", 0, null },
                    { new Guid("eca2138d-f128-4b55-a453-91d15898aea4"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8648), null, "Khác giới", 0, 0, null, 3, null },
                    { new Guid("ed1218ff-7b08-4000-96ed-f9a1d2cc933e"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8556), null, "Tập Gym", 0, null, "https://tiki.vn/blog/wp-content/uploads/2023/07/elite-fitness-1024x583.jpg", 0, null },
                    { new Guid("ed8d2783-2828-484b-89bb-bc20bf3969ae"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8692), null, "Hiền lành", 0, null, null, 4, null },
                    { new Guid("ef8360d6-621b-4184-adfb-82be447c2a7d"), "123abc", new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8566), null, "Đọc sách", 0, null, "https://images.theconversation.com/files/45159/original/rptgtpxd-1396254731.jpg?ixlib=rb-4.1.0&q=45&auto=format&w=1356&h=668&fit=crop", 0, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "101jkl",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8298), new Guid("172ce872-fecb-43dd-baa8-b06e7df64e56") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "123abc",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8182), new Guid("ee7e4f28-03d0-4b7c-a606-52669be8222b") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "202mno",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8304), new Guid("96814efd-6fc8-49e6-9e97-879f97c4c7a0") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "303pqr",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8309), new Guid("59511d77-e088-41a9-b63e-46cd6438d6bf") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "404stu",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8315), new Guid("04ce47a3-eadf-4f18-a3e3-d9b16a51b0a2") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "456def",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8282), new Guid("5ed410f6-f630-4744-9e70-950c2e14a7f8") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "505vwx",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8320), new Guid("59103d79-1386-4f1c-a856-50ecbd09e82a") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "606yza",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8356), new Guid("a71b47fd-000c-4fc4-97cb-4081dbad1f81") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "707bcd",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8364), new Guid("38a5f00c-ab27-42d4-a807-184b39dd6bc0") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "789ghi",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 10, 4, 3, 15, 52, 251, DateTimeKind.Utc).AddTicks(8292), new Guid("e057336e-f525-46f3-94b1-3eb6d9a20335") });

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_ChatRooms_ChatRoomId",
                table: "Messages",
                column: "ChatRoomId",
                principalTable: "ChatRooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Users_UserFirebaseId",
                table: "Messages",
                column: "UserFirebaseId",
                principalTable: "Users",
                principalColumn: "FireBaseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserChatRooms_ChatRooms_ChatRoomId",
                table: "UserChatRooms",
                column: "ChatRoomId",
                principalTable: "ChatRooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserChatRooms_Users_UserFirebaseId",
                table: "UserChatRooms",
                column: "UserFirebaseId",
                principalTable: "Users",
                principalColumn: "FireBaseId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_ChatRooms_ChatRoomId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Users_UserFirebaseId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_UserChatRooms_ChatRooms_ChatRoomId",
                table: "UserChatRooms");

            migrationBuilder.DropForeignKey(
                name: "FK_UserChatRooms_Users_UserFirebaseId",
                table: "UserChatRooms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserChatRooms",
                table: "UserChatRooms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Messages",
                table: "Messages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChatRooms",
                table: "ChatRooms");

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("1088ebda-9d83-425c-ad28-885a758b8a48"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("5cb7f275-d2b4-4fa8-84c6-ba462d317ad7"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00f7e862-dbbd-4eeb-a608-a600c17a8d11"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("026563e1-2934-43bf-9e60-b81c21fdc0ca"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("07542823-898c-4b82-8d5c-4efa31d8d6e7"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("0e86e285-a1af-4348-95f4-f4f6c499e7bf"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("0fa6852c-bfb7-4f17-87c4-5503cd334ca9"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("150968ad-a609-434c-9b1a-4e71fe2a31ae"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("1906f7b8-36ce-41c1-9b27-f90e2be09c10"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("1ba6c05c-7b9e-4738-ae40-f6d023acbf91"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("1cf648db-5a73-480a-ad0e-427f3cc37e4b"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("1f3ef91e-f673-4350-ab94-8ad1252bdde8"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("1fe84570-aa36-489d-b30e-7d174b46ba60"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("22465e4e-dd44-455b-a3ea-ac634f103513"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("33e38af7-14df-467d-b4cb-b1eed627cc86"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("384c20c8-c284-4184-9d83-10e0ba517d2d"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("3e945985-9a75-4491-8bee-9f89cb77f7b3"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("3f9b4574-34df-44a2-b7f9-1ef059bac82d"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("40b06200-a101-4c24-894d-3075872a87a7"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("40faaab5-1d84-49ef-8f0f-40a447d946ce"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("43124093-336b-43cf-92ed-34d06fcb508d"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("44a27be3-9f88-4ccd-aa2f-fd0d0ce8019e"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("4628e6d1-46d5-4b8c-a3d8-0a1d2fdeb4b8"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("46a322cd-1d5a-45e0-a011-07e606fd9a2a"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("499d68e1-1dcc-44cf-b64c-e0296055b810"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("49b361f2-07a0-4ffb-b489-a93d602d6629"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("4af816c9-4ce9-43f4-88d9-ebc938212ebf"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("4c7d54bc-7c33-4973-8407-9a4978c92a2f"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("527c5ad5-f53f-4cd8-af93-0b7b62a82ded"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("581a0087-cc79-4075-8c71-9c807a8b82f0"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("5a2f2306-dc81-4ebb-af05-0559a9bc6392"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("5b272c69-948a-445d-b901-745f52e58b9c"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("5b76ee68-a0ca-499b-a085-6466003a3fcb"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("5fb4e449-be5e-4959-a138-682280153964"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("6005034c-f627-4482-b9e6-bd80ec61564c"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("6fe2eb53-c4c8-49aa-ac27-a2bf81a3e5bb"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("701d94ec-2c41-4cdd-84c2-8fe1f3326873"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("7429d1dc-b209-45bb-af1c-2a15b514bae9"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("7a584c25-4d4f-437b-a2b5-79f58d6589ec"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("8008bf4b-7ef1-41b8-a476-8e9920589f80"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("82a9ddfa-001c-43f4-abdd-f27dc031d6f9"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("85a50e7b-fe1a-4b0a-9972-4c8c27b6020f"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("8ad6e980-637f-46a3-b705-93fe8012658a"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("8be2943e-69c2-4214-a6a5-45ed573b454c"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("8e42f639-9d23-4ae3-aa07-1e057c81226a"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("95f10990-3cac-459d-9d0a-590afe82d395"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("994b6279-6027-4525-ab51-e6c1f63d1142"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("9aa5a039-d7cc-4bf0-be28-1ccab2374c46"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("9b23533e-377c-4983-b86f-52e7f4b85903"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("9f16f1d4-2138-4023-9cba-606a6954de94"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("a171a83c-849b-48c0-bb06-66c948bb1f64"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("a5a03ee8-4b74-4487-b126-5590645df20f"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("a87f2e98-bf60-40f2-85c5-29a2e2ae419b"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("ac40ed89-1a89-4ef7-90d4-566c68314f53"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("ad23c5c3-3361-4182-a245-4acee3b9d068"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("ada5731e-12b8-4c0e-8ab8-c079b04eabb8"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("ae70cc07-1b6c-4de3-b797-365c258dba2e"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("b1287b3f-7999-4154-9499-7dc4c5fee0ec"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("b5839c12-6b6e-4b32-bcd9-364542953cd6"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("bb5846f8-e192-4eb7-bd32-7ce7c1e25535"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("bd57e151-e026-4c04-b9f2-7e40bdf437e0"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("bd72993b-146c-4b26-afd8-0e2e57e9f475"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("c529175b-4ea8-4d27-b712-eb205ae2a748"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("c640ad21-e4b2-4607-8c7d-e757bb7c2a46"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("d15b6a12-0296-46d5-95d3-4152c63ece19"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("d2f5641c-c2e0-40dd-aff7-34d0c4fcbee0"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("db871eb8-8663-4703-8c6b-997d827a080d"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("db9d6bdf-42c3-4381-8887-5c3a5beebb4e"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("e13d682f-4a00-4654-b5a1-c0c69239a9ab"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("e2f87e5a-5b2b-43b9-bae2-95495b94295f"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("e3aba9e5-3cb4-45ae-a176-86e0fe493c7d"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("e6c91982-f8f2-4740-9ef3-e23186dfff61"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("e7481ce0-412d-4964-8b88-88031525fb30"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("eca2138d-f128-4b55-a453-91d15898aea4"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("ed1218ff-7b08-4000-96ed-f9a1d2cc933e"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("ed8d2783-2828-484b-89bb-bc20bf3969ae"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("ef8360d6-621b-4184-adfb-82be447c2a7d"));

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "UserChatRooms");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "UserChatRooms");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "UserChatRooms");

            migrationBuilder.DropColumn(
                name: "RecordStatus",
                table: "UserChatRooms");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "UserChatRooms");

            migrationBuilder.RenameTable(
                name: "UserChatRooms",
                newName: "UserChatRoom");

            migrationBuilder.RenameTable(
                name: "Messages",
                newName: "Message");

            migrationBuilder.RenameTable(
                name: "ChatRooms",
                newName: "ChatRoom");

            migrationBuilder.RenameIndex(
                name: "IX_UserChatRooms_ChatRoomId",
                table: "UserChatRoom",
                newName: "IX_UserChatRoom_ChatRoomId");

            migrationBuilder.RenameIndex(
                name: "IX_Messages_UserFirebaseId",
                table: "Message",
                newName: "IX_Message_UserFirebaseId");

            migrationBuilder.RenameIndex(
                name: "IX_Messages_ChatRoomId",
                table: "Message",
                newName: "IX_Message_ChatRoomId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserChatRoom",
                table: "UserChatRoom",
                columns: new[] { "UserFirebaseId", "ChatRoomId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Message",
                table: "Message",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChatRoom",
                table: "ChatRoom",
                column: "Id");

            migrationBuilder.InsertData(
                table: "EmailTemplates",
                columns: new[] { "Id", "Body", "CreatedDate", "DeletedDate", "Description", "Name", "Params", "RecordStatus", "Status", "Subject", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("22ec258e-7958-492d-ab08-216a09623e4b"), "Chào mừng bạn đến với FitWipe! Kính gửi [Name], vui lòng xác nhận địa chỉ email của bạn bằng cách nhấn vào đường link sau: <a href=\"[VerificationLink]\">Xác nhận Email</a>.<br><br>Cảm ơn bạn đã tham gia cùng chúng tôi!<br><br>Đội ngũ FitWipe", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7780), null, "Email này được gửi để xác nhận đăng ký tài khoản FitWipe.", "Register_Mail", "[Name], [VerificationLink]", 0, true, "Chào mừng đến với FitWipe! Vui lòng xác nhận email của bạn", null },
                    { new Guid("6cfa782e-8fb0-439c-817a-3501777cc2be"), "Chúng tôi đã nhận được yêu cầu đặt lại mật khẩu cho tài khoản của bạn tại FitWipe. Kính gửi [Name], vui lòng đặt lại mật khẩu của bạn bằng cách nhấn vào đường link sau: <a href=\"[ResetPasswordLink]\">Đặt lại mật khẩu</a>.<br><br>Nếu bạn không yêu cầu việc này, vui lòng bỏ qua email này.<br><br>Đội ngũ FitWipe", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7803), null, "Email này được gửi khi người dùng yêu cầu đặt lại mật khẩu cho tài khoản FitWipe.", "Forgot_Password", "[Name], [ResetPasswordLink]", 0, true, "Yêu cầu đặt lại mật khẩu FitWipe", null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreateById", "CreatedDate", "DeletedDate", "Name", "RecordStatus", "SpecialTag", "TagImage", "TagType", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("00efa009-bb6d-4cfc-8076-4371982d62f2"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7705), null, "Nhạy cảm", 0, null, null, 4, null },
                    { new Guid("02e91999-97e7-4eab-a6f0-6ce99ef12d47"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7639), null, "Yoga / Pilates", 0, null, "https://thamtapyoga.vn/wp-content/uploads/2024/01/3-2.jpeg", 2, null },
                    { new Guid("0628cccc-1d5e-4898-afec-0bd166aa4c2e"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7704), null, "Nhút nhát", 0, null, null, 4, null },
                    { new Guid("07c9b81b-b757-484d-92df-42827f4edb5d"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7588), null, "Phim ảnh", 0, null, "https://lawnet.vn/uploads/image/2023/10/17/015815855.jpg", 0, null },
                    { new Guid("0cf7a331-af01-4eef-9fc8-1f69990724b9"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7713), null, "Hiền lành", 0, null, null, 4, null },
                    { new Guid("0f78dc08-41d1-4f72-9af4-b8ea8ed90b8e"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7632), null, "Tăng cảm giác hạnh phúc, giảm căng thẳng", 0, null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT8ZXc_bemAYbupxmGz0pZGy4L1Zr6hGVsYdA&s", 1, null },
                    { new Guid("0fa7c5fe-0e9f-4a24-9eed-81d1c9cb41cb"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7661), null, "Ngoại hình đẹp", 0, null, null, 3, null },
                    { new Guid("10a50f12-e646-47dc-baf9-8a7d6d1a0ed4"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7598), null, "Khoa học", 0, null, "https://www.training.com.au/wp-content/uploads/science-stem-feature.png", 0, null },
                    { new Guid("13f695e7-5752-4fc1-8be0-d418332fc007"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7690), null, "Kiên trì", 0, null, null, 4, null },
                    { new Guid("174f6ae7-5491-426c-93a5-32660ee61190"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7630), null, "Cải thiện tình trạng bệnh", 0, null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQv509Yw7GUN5twNNk4G5Pvu1TBqFmhrL_3UQ&s", 1, null },
                    { new Guid("1d72ca89-4187-47f7-bbf7-9f967bac681a"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7707), null, "Dễ nản", 0, null, null, 4, null },
                    { new Guid("1eacd9c4-24b6-4198-9ae5-c47af28eb138"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7572), null, "Cầu Lông", 0, null, "https://vecgroup.vn/images/products/2021/08/24/large/qua-cau-long_1629778779.jpg", 0, null },
                    { new Guid("23061dad-35a0-4b19-93fe-1bc52879ee63"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7674), null, "Gần", 0, 2, null, 3, null },
                    { new Guid("3361bbb4-905d-4731-819e-760a7c262306"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7605), null, "Nghe nhạc", 0, null, "https://static.vecteezy.com/system/resources/thumbnails/037/044/052/small_2x/ai-generated-studio-shot-of-black-headphones-over-music-note-explosion-background-with-empty-space-for-text-photo.jpg", 0, null },
                    { new Guid("34776aa4-b491-49f8-9cd6-715363657e69"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7597), null, "Đọc sách", 0, null, "https://images.theconversation.com/files/45159/original/rptgtpxd-1396254731.jpg?ixlib=rb-4.1.0&q=45&auto=format&w=1356&h=668&fit=crop", 0, null },
                    { new Guid("398ff589-ed7c-4a13-9af7-f8128ce56d76"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7622), null, "Quản lý cân nặng", 0, null, "https://thanhnien.mediacdn.vn/Uploaded/minhnguyet/2022_05_10/an-kieng-9141.jpg", 1, null },
                    { new Guid("3c9bbb59-d489-4155-a29e-63e4053a118b"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7647), null, "HIIT", 0, null, "https://hips.hearstapps.com/hmg-prod/images/athletes-doing-push-ups-with-dumbbells-on-floor-royalty-free-image-1638463573.jpg", 2, null },
                    { new Guid("3d56443c-38fe-4157-aab8-aed04a5af9f3"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7701), null, "Thi thoảng bất thường", 0, null, null, 4, null },
                    { new Guid("3e9e7bbc-8fbe-4205-99eb-9d65a9f38b68"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7687), null, "Biết truyền cảm hứng, tạo động lực", 0, null, null, 3, null },
                    { new Guid("43ec96e4-8d3e-4f01-ac36-c76626ac3317"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7571), null, "Bơi lội", 0, null, "https://file.hstatic.net/1000391576/file/boi_loi_7d4d69c53ac1494eabb2a446d4d503a0_grande.jpg", 0, null },
                    { new Guid("4495e43d-4f1e-4290-a76c-c04ff8b69ddd"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7663), null, "Cung cấp giá cả phải chăng", 0, null, null, 3, null },
                    { new Guid("449a90d0-c84c-448d-9650-bedc8df6b721"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7613), null, "Lịch Sử", 0, null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRWz_tIgvQXPAaSmvYa7CqZo_biaRK9D_O8uA&s", 0, null },
                    { new Guid("4934df40-1fc2-436a-a597-695fbd1c9271"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7712), null, "Sẵn sàng học hỏi", 0, null, null, 4, null },
                    { new Guid("49b3bb31-8117-4443-a117-edb8f2a3bf9b"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7652), null, "Thể dục nhịp điệu, theo nhạc", 0, null, "https://i.vietgiaitri.com/2018/10/9/the-duc-nhip-dieu-b2ab9f.jpg", 2, null },
                    { new Guid("49cbb02e-f212-4765-92e0-c922b14a9c73"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7602), null, "Nhiếp ảnh", 0, null, "https://aaftonline.com/blog/wp-content/uploads/2024/01/What-are-the-Benefits-of-Photography-Complete-Overview.png", 0, null },
                    { new Guid("501c338c-c2f2-4151-a99b-b9c2f9aecc1d"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7649), null, "Kickfit", 0, null, "https://storage.googleapis.com/leep_app_website/2020/11/Kick-fit-khong-phai-la-kick-boxing.jpg", 2, null },
                    { new Guid("5e3237f3-667d-4bf3-8ef2-fdf19df96575"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7615), null, "Địa lý", 0, null, "https://www.aag.org/wp-content/uploads/2021/12/shutterstock_1111879247.jpg", 0, null },
                    { new Guid("6979ea44-8be2-4d3a-b7cd-57ae160fd101"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7633), null, "Cải thiện sự dẻo dai", 0, null, "https://cdn.shopify.com/s/files/1/0453/0381/files/fullsizeoutput_2d4_1024x1024.jpg?v=1662646979", 1, null },
                    { new Guid("69fa736e-25ea-4028-94b9-16c71c6f4392"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7688), null, "Đảm bảo mục tiêu cho học viên", 0, null, null, 3, null },
                    { new Guid("6ac2508f-3a1c-453c-864b-0fa76598cf00"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7582), null, "Thể thao nói chung", 0, null, "https://llv.edu.vn/media/2018/09/iStock-949190756-800x440.jpg", 0, null },
                    { new Guid("6cdb9d20-2149-46b6-8b04-c7da4ee4b2b7"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7646), null, "Cardio", 0, null, "https://file.hstatic.net/1000308068/file/tap-cardio-vao-luc-nao-la-hieu-qua-nhat_cb884317c05d4df980138121ee113112_grande.jpg", 2, null },
                    { new Guid("75ff233c-ca86-4309-918f-782f2b0c0a9b"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7642), null, "Calisthenic", 0, null, "https://cdn.nhathuoclongchau.com.vn/unsafe/800x0/https://cms-prod.s3-sgn09.fptcloud.com/giai_dap_thac_mac_calisthenics_khac_gi_gym_1_8d5dd4026b.jpg", 2, null },
                    { new Guid("7653db23-b9ac-4282-a6df-a28829b6256c"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7708), null, "Hay bị lười", 0, null, null, 4, null },
                    { new Guid("77b79b26-391f-47b2-9df0-a448093dc3f3"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7680), null, "Không nặng nề với học viên", 0, null, null, 3, null },
                    { new Guid("7a701f2c-68ab-4e8f-ba32-7c408796eae0"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7699), null, "Dễ gần", 0, null, null, 4, null },
                    { new Guid("7d2904d7-a3e4-4c48-a526-fa3d8ef65d5b"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7580), null, "Bóng rổ", 0, null, "https://thethaothienlong.vn/wp-content/uploads/2022/04/Kich-thuoc-qua-bong-ro-1.jpg", 0, null },
                    { new Guid("7e819bc2-d2ca-457d-aefe-326f264c3348"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7654), null, "Cùng giới", 0, 1, null, 3, null },
                    { new Guid("7fdef875-f46b-4730-8dcb-c236106921a4"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7612), null, "Công nghệ", 0, null, "https://www.simplilearn.com/ice9/free_resources_article_thumb/Technology_Trends.jpg", 0, null },
                    { new Guid("7fe87a79-fccc-467c-a467-215856e2bc2a"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7620), null, "Sống Ảo", 0, null, "https://imagev3.vietnamplus.vn/w1000/Uploaded/2024/hotnnz/2024_08_13/song-ao3-6646.jpg.webp", 0, null },
                    { new Guid("827e2284-cc23-4e5d-ada2-ab79d45e95da"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7715), null, "Rảnh rỗi", 0, null, null, 4, null },
                    { new Guid("886ae848-7f85-43dc-a8e1-a18dc0895869"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7566), null, "Bóng đá", 0, null, "https://cdn.tuoitre.vn/ttct//2020/12/13/16078750289060-lich-thi-dau-bong-da-hom-nay-0211.jpg", 0, null },
                    { new Guid("8a0fb0c1-ffaf-4636-b058-93f88d0f9cda"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7603), null, "Hội họa", 0, null, "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ea/Van_Gogh_-_Starry_Night_-_Google_Art_Project.jpg/1200px-Van_Gogh_-_Starry_Night_-_Google_Art_Project.jpg", 0, null },
                    { new Guid("8a1183e3-4b3e-42e2-a66f-f60e246dd144"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7637), null, "Cải thiện sức khỏe tổng quát", 0, null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcThCjFemkP0h0IZYpu31k-xGK9IvigaysteqA&s", 1, null },
                    { new Guid("8c5856f8-93a7-4225-9946-72cfa1a8b901"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7719), null, "Dễ bị khó chịu", 0, null, null, 4, null },
                    { new Guid("90de2233-37f7-4baf-adf0-7470bcd95134"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7718), null, "Thoải mái", 0, null, null, 4, null },
                    { new Guid("94991376-6603-4646-b998-1d8bd91d1430"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7585), null, "Tập Gym", 0, null, "https://tiki.vn/blog/wp-content/uploads/2023/07/elite-fitness-1024x583.jpg", 0, null },
                    { new Guid("9584188e-af40-4fa6-9fe4-cc222fa36565"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7702), null, "Lạnh lùng, ít nói", 0, null, null, 4, null },
                    { new Guid("9667fc39-7934-4dcf-8cbb-0fbacdf37ce0"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7623), null, "Phát triển cơ bắp", 0, null, "https://www.dmoose.com/cdn/shop/articles/feature-image_87a28752-6da3-4be8-8814-d5221236136d.jpg?v=1676644951", 1, null },
                    { new Guid("970b36d4-703f-4020-a6fd-ea195dcf57ec"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7587), null, "Đi, chạy bộ", 0, null, "https://pos.nvncdn.com/be3294-43017/art/artCT/20230228_9uObLfWys7Q0IXe4.jpg", 0, null },
                    { new Guid("97413666-fde4-480e-8c50-c6c8952d2c25"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7635), null, "Cải thiện sức bền", 0, null, "https://vinmec-prod.s3.amazonaws.com/images/20210524_085806_814180_chay-bo-bao-nhieu-cal.max-800x800.jpg", 1, null },
                    { new Guid("98adbeba-ee5a-466b-9794-98cbf4612c40"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7574), null, "Bóng chuyền", 0, null, "https://file.hstatic.net/200000333667/article/image.jpg_4b1e1c8ce20f4c32824f275f34ff30af_1024x1024.jpg", 0, null },
                    { new Guid("a76e7bd2-bfa2-4200-937c-52acea97d338"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7693), null, "Vui tính, hài hước", 0, null, null, 4, null },
                    { new Guid("a9bb656c-709f-4015-9f4e-cd6f83708aa5"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7677), null, "Có trách nhiệm", 0, null, null, 3, null },
                    { new Guid("aa89997b-a937-4503-a6f3-0cc14cfef073"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7659), null, "Khác giới", 0, 0, null, 3, null },
                    { new Guid("b3ab7fa5-1e10-43e6-bfdd-817ad380ff0c"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7679), null, "Có kinh nghiệm", 0, null, null, 3, null },
                    { new Guid("b6414e17-3a7a-4371-882f-a3d538ce0ac8"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7644), null, "Tập sức mạnh", 0, null, "https://www.thethaothientruong.vn/uploads/2020/Powerlifting-la-gi.jpg", 2, null },
                    { new Guid("b64ca38d-0bbe-497c-9f04-15b92cf640e7"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7590), null, "Truyện tranh", 0, null, "https://taschen.makaira.media/taschen/image/upload/f_webp,w_1200/v1673462260/products-live/a3d446fb0046b587eb0ed76edca3f4d6.jpg", 0, null },
                    { new Guid("b7a08b56-a766-477b-91c8-7e8af1b42ce5"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7595), null, "Thể thao trí tuệ", 0, null, "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6f/ChessSet.jpg/640px-ChessSet.jpg", 0, null },
                    { new Guid("b8ef3a73-ec80-4546-be6b-7c3b984a0300"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7698), null, "Năng động", 0, null, null, 4, null },
                    { new Guid("bc222c1c-4704-4b96-bab3-4cb910181624"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7583), null, "Bida", 0, null, "https://billiardshoanthuy.vn/wp-content/uploads/2021/05/phu-kien-ban-bida-2.jpg", 0, null },
                    { new Guid("c0c47e2d-45dd-4bde-93b3-033aef710544"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7600), null, "Game", 0, null, "https://genk.mediacdn.vn/139269124445442048/2022/7/28/tmb-1658998970448906989995.jpg", 0, null },
                    { new Guid("c23ee31b-11fc-495f-bef8-0c8f20e9e07f"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7695), null, "Hòa đồng", 0, null, null, 4, null },
                    { new Guid("c378eca7-6336-4b35-89e6-198ff66faa0d"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7618), null, "Triết học", 0, null, "https://www.rollingstone.com/wp-content/uploads/2024/01/unlocking_the_power_why_you_should_consider_hiring_philosophy_graduates-.jpg", 0, null },
                    { new Guid("c5a5f7b7-784f-4520-8738-44451bc23b2b"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7591), null, "Du lịch", 0, null, "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/18/4f/7d/fc/caption.jpg?w=1200&h=1200&s=1", 0, null },
                    { new Guid("c792a42e-d9ff-4945-a816-05752f61eca2"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7684), null, "Giàu kiến thức", 0, null, null, 3, null },
                    { new Guid("cd535567-5cbf-4a69-853c-2fb4bcdb71a4"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7628), null, "Phòng tránh bệnh", 0, null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQv509Yw7GUN5twNNk4G5Pvu1TBqFmhrL_3UQ&s", 1, null },
                    { new Guid("d4d3237a-c90c-46ac-b1e3-48bfbd343ffd"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7607), null, "Chơi nhạc cụ", 0, null, "https://t3.ftcdn.net/jpg/01/34/38/92/360_F_134389281_5Jak3tbsoDggHIfIKKwJ8L7064ACIMNE.jpg", 0, null },
                    { new Guid("d8347015-a7a4-48fb-90ec-d647a813e0b5"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7650), null, "Tập ép dẻo", 0, null, "https://prod-everyoneactive-wp.s3.eu-west-2.amazonaws.com/wp-content/uploads/2020/03/23151503/flexibility-at-home.jpg", 2, null },
                    { new Guid("daa2956a-2177-45e2-93fb-a248f6a47024"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7676), null, "Tâm huyết với học viên", 0, null, null, 3, null },
                    { new Guid("dbf3a817-5fa5-48bb-acfb-8bea7bc1e82e"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7685), null, "Luôn sẵn sàng tư vấn ngoài giờ", 0, null, null, 3, null },
                    { new Guid("dc184cd9-9828-412c-ba7e-9a88529a5f10"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7627), null, "Có body chuẩn chỉnh", 0, null, "https://cdn.nhathuoclongchau.com.vn/unsafe/800x0/https://cms-prod.s3-sgn09.fptcloud.com/fitness_la_gi_loi_ich_va_phuong_phap_tap_luyen_fitness_1_3c4e094223.png", 1, null },
                    { new Guid("e634f0be-0ff2-48a7-b162-8aba42c82262"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7716), null, "Cầu toàn", 0, null, null, 4, null },
                    { new Guid("e93bb680-ade3-42a3-9ec5-479626f3f541"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7721), null, "Độc thân lâu năm", 0, null, null, 4, null },
                    { new Guid("ec6b93e4-ba24-4736-8491-71dc5e3665ce"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7691), null, "Siêng năng", 0, null, null, 4, null },
                    { new Guid("f47316fa-a007-4a52-a20a-116d2fcb50f3"), "123abc", new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7610), null, "Tán gẫu", 0, null, "https://transcode-v2.app.engoo.com/image/fetch/f_auto,c_lfill,w_300,dpr_3/https://assets.app.engoo.com/images/rGTEEA2fm66YMzeJz2UbwkKOW62bZVlqKOKZrXlMN7g.jpeg", 0, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "101jkl",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7254), new Guid("f7dfa554-a9ad-46ed-aed6-274000f1f325") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "123abc",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7180), new Guid("022462a1-ab66-43b8-9534-12d13d92f92d") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "202mno",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7260), new Guid("65b4013a-088b-4be1-ac74-da58c3352f87") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "303pqr",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7265), new Guid("15598f43-0bf4-4374-bc54-f71c2b54b4bd") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "404stu",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7294), new Guid("e9aae356-6974-453b-bc2f-457091ef6f33") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "456def",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7236), new Guid("1fb1cc67-6925-44ea-a603-0551a12235a0") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "505vwx",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7299), new Guid("3710b397-ee72-4911-b029-a1aecda558c5") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "606yza",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7304), new Guid("710574a2-2c13-45f6-9d50-e2d7c8fe4fb7") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "707bcd",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7310), new Guid("5ae97f3f-ec91-4f87-a093-df48ae26ae86") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "789ghi",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 10, 3, 14, 21, 57, 388, DateTimeKind.Utc).AddTicks(7246), new Guid("2f4ddb5b-a486-46b8-bea3-50fbff0d35ae") });

            migrationBuilder.AddForeignKey(
                name: "FK_Message_ChatRoom_ChatRoomId",
                table: "Message",
                column: "ChatRoomId",
                principalTable: "ChatRoom",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Message_Users_UserFirebaseId",
                table: "Message",
                column: "UserFirebaseId",
                principalTable: "Users",
                principalColumn: "FireBaseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserChatRoom_ChatRoom_ChatRoomId",
                table: "UserChatRoom",
                column: "ChatRoomId",
                principalTable: "ChatRoom",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserChatRoom_Users_UserFirebaseId",
                table: "UserChatRoom",
                column: "UserFirebaseId",
                principalTable: "Users",
                principalColumn: "FireBaseId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
