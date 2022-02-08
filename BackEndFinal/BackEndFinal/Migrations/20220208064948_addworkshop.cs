using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEndFinal.Migrations
{
    public partial class addworkshop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "workshops",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date1 = table.Column<int>(nullable: false),
                    Date2 = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    MyProperty = table.Column<int>(nullable: false),
                    Date = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    JoinNow = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_workshops", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "workshops");
        }
    }
}
