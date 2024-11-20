using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitSwipe.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Update_RequestWithdraw_Add_TransactionCode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TransactionCode",
                table: "RequestWithdraws",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TransactionCode",
                table: "RequestWithdraws");
        }
    }
}
