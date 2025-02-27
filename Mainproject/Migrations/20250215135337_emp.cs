using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mainproject.Migrations
{
    /// <inheritdoc />
    public partial class emp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctor",
                columns: table => new
                {
                    Doctor_Id = table.Column<int>(type: "int", nullable: false),
                    Doctor_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Doctor_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Doctor_Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctor", x => x.Doctor_Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Doctor");
        }
    }
}
