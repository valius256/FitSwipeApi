using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitSwipe.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Add_Email_For_Pay_Success : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "EmailTemplates",
                columns: new[] { "Id", "Body", "CreatedDate", "DeletedDate", "Description", "Name", "Params", "RecordStatus", "Status", "Subject", "UpdatedDate" },
                values: new object[,]
                {
                    {
                        Guid.NewGuid(),
                        "Kính gửi [Name],<br><br>Chúng tôi xin thông báo rằng thanh toán của bạn qua PayOs đã thành công.<br><br>Số tiền: [Amount]<br>Ngày thanh toán: [PaymentDate]<br><br>Cảm ơn bạn đã sử dụng dịch vụ của chúng tôi!<br><br>Đội ngũ FitWipe",
                        new DateTime(2024, 10, 14, 12, 46, 3, 245, DateTimeKind.Utc).AddTicks(9650),
                        null,
                        "Email này được gửi khi thanh toán qua PayOs thành công.",
                        "Payment_Success",
                        "[Name], [Amount], [PaymentDate]",
                        0,
                        true,
                        "Thông báo thanh toán thành công qua PayOs",
                        null
                    }
                });


        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
