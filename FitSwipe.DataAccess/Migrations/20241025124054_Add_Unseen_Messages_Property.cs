using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitSwipe.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Add_Unseen_Messages_Property : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UnseenMessaged",
                table: "UserChatRooms",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UnseenMessaged",
                table: "UserChatRooms");
        }
    }
}
