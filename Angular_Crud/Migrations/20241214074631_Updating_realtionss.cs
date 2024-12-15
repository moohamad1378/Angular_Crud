using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Angular_Crud.Migrations
{
    /// <inheritdoc />
    public partial class Updating_realtionss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PaymentDetailsId",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaymentDetailsId",
                table: "Departments");
        }
    }
}
