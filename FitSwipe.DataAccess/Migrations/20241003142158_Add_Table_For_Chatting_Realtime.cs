using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FitSwipe.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Add_Table_For_Chatting_Realtime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "ChatRoom",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    RoomName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    IsGroup = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    RecordStatus = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatRoom", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Message",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Content = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    UserFirebaseId = table.Column<string>(type: "text", nullable: false),
                    ChatRoomId = table.Column<Guid>(type: "uuid", nullable: false),
                    SentAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    RecordStatus = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Message", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Message_ChatRoom_ChatRoomId",
                        column: x => x.ChatRoomId,
                        principalTable: "ChatRoom",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Message_Users_UserFirebaseId",
                        column: x => x.UserFirebaseId,
                        principalTable: "Users",
                        principalColumn: "FireBaseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserChatRoom",
                columns: table => new
                {
                    UserFirebaseId = table.Column<string>(type: "text", nullable: false),
                    ChatRoomId = table.Column<Guid>(type: "uuid", nullable: false),
                    JoinedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserChatRoom", x => new { x.UserFirebaseId, x.ChatRoomId });
                    table.ForeignKey(
                        name: "FK_UserChatRoom_ChatRoom_ChatRoomId",
                        column: x => x.ChatRoomId,
                        principalTable: "ChatRoom",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserChatRoom_Users_UserFirebaseId",
                        column: x => x.UserFirebaseId,
                        principalTable: "Users",
                        principalColumn: "FireBaseId",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Message_ChatRoomId",
                table: "Message",
                column: "ChatRoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Message_UserFirebaseId",
                table: "Message",
                column: "UserFirebaseId");

            migrationBuilder.CreateIndex(
                name: "IX_UserChatRoom_ChatRoomId",
                table: "UserChatRoom",
                column: "ChatRoomId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Message");

            migrationBuilder.DropTable(
                name: "UserChatRoom");

            migrationBuilder.DropTable(
                name: "ChatRoom");

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
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(8958), new Guid("5d84ecec-e9a4-4f8c-9c40-1384e54a3830") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "123abc",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(8866), new Guid("31dbffb2-2139-4d92-96e9-e519f3b838d4") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "202mno",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(8983), new Guid("941b0ada-4fde-4e0d-bd5e-45242577a9b3") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "303pqr",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(8992), new Guid("6c68ef29-619f-4ecf-9e4b-d075265b1e8e") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "404stu",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9001), new Guid("9f1f7459-e909-4584-924d-73e082458181") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "456def",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(8928), new Guid("a887e5d3-f651-4c00-802b-97377eaf0ba0") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "505vwx",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9009), new Guid("94b9aa1e-0645-47c1-9b25-7f1b46fcff46") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "606yza",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9082), new Guid("887e086f-87d5-40ff-8971-354b12dfbe5f") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "707bcd",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(9092), new Guid("4e6cdddd-de1d-47ac-931b-826623678488") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "FireBaseId",
                keyValue: "789ghi",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2024, 10, 2, 17, 19, 13, 395, DateTimeKind.Utc).AddTicks(8947), new Guid("29f2efa8-1938-4566-9912-e69f18651667") });
        }
    }
}
