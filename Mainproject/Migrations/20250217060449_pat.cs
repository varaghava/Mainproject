using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mainproject.Migrations
{
    /// <inheritdoc />
    public partial class pat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    Patient_Id = table.Column<int>(type: "int", nullable: false),
                    Patient_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Patient_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Patient_Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.Patient_Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Patient");
        }
    }
}
