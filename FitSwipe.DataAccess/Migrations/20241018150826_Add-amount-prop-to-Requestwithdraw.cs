using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitSwipe.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddamountproptoRequestwithdraw : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "RequestWithdraws",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "RequestWithdraws");
        }
    }
}
