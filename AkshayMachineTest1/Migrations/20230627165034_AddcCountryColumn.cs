using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AkshayMachineTest1.Migrations
{
    public partial class AddcCountryColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Information");

            migrationBuilder.CreateTable(
                name: "country",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_country", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "country");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Information",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
