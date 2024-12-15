using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Angular_Crud.Migrations
{
    /// <inheritdoc />
    public partial class Updating_realtions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "PaymentDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PaymentDetails_DepartmentId",
                table: "PaymentDetails",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentDetails_Departments_DepartmentId",
                table: "PaymentDetails",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaymentDetails_Departments_DepartmentId",
                table: "PaymentDetails");

            migrationBuilder.DropIndex(
                name: "IX_PaymentDetails_DepartmentId",
                table: "PaymentDetails");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "PaymentDetails");
        }
    }
}
