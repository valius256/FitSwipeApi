using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitSwipe.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Add_Slot_Number_to_Slot_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SlotNumber",
                table: "Slots",
                type: "integer",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SlotNumber",
                table: "Slots");
        }
    }
}
