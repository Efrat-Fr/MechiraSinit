using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class ForceCreateLottery : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
       name: "lotteries",
       columns: table => new
       {
           Id = table.Column<int>(nullable: false)
               .Annotation("SqlServer:Identity", "1, 1"),
           GiftId = table.Column<int>(nullable: false),
           UserId = table.Column<int>(nullable: false)
       },
       constraints: table =>
       {
           table.PrimaryKey("PK_lotteries", x => x.Id);
           table.ForeignKey(
               name: "FK_lotteries_gifts_GiftId",
               column: x => x.GiftId,
               principalTable: "gifts",
               principalColumn: "Id",
               onDelete: ReferentialAction.Cascade);
           table.ForeignKey(
               name: "FK_lotteries_useres_UserId",
               column: x => x.UserId,
               principalTable: "useres",
               principalColumn: "Id",
               onDelete: ReferentialAction.Cascade);
       });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
       name: "lotteries");
        }
    }
}
