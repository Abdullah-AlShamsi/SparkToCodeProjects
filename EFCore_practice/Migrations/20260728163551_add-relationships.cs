 using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore_practice.Migrations
{
    /// <inheritdoc />
    public partial class addrelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "departmentID",
                table: "students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "hotelID",
                table: "students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "hotels",
                columns: table => new
                {
                    HotelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    location = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hotels", x => x.HotelId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_students_departmentID",
                table: "students",
                column: "departmentID");

            migrationBuilder.CreateIndex(
                name: "IX_students_hotelID",
                table: "students",
                column: "hotelID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_students_departments_departmentID",
                table: "students",
                column: "departmentID",
                principalTable: "departments",
                principalColumn: "departmentID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_students_hotels_hotelID",
                table: "students",
                column: "hotelID",
                principalTable: "hotels",
                principalColumn: "HotelId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_students_departments_departmentID",
                table: "students");

            migrationBuilder.DropForeignKey(
                name: "FK_students_hotels_hotelID",
                table: "students");

            migrationBuilder.DropTable(
                name: "hotels");

            migrationBuilder.DropIndex(
                name: "IX_students_departmentID",
                table: "students");

            migrationBuilder.DropIndex(
                name: "IX_students_hotelID",
                table: "students");

            migrationBuilder.DropColumn(
                name: "departmentID",
                table: "students");

            migrationBuilder.DropColumn(
                name: "hotelID",
                table: "students");
        }
    }
}
