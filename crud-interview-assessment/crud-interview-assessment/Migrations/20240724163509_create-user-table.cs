using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace crud_interview_assessment.Migrations
{
    /// <inheritdoc />
    public partial class createusertable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProductNo",
                table: "Products",
                newName: "Id");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmailId = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Products",
                newName: "ProductNo");
        }
    }
}
