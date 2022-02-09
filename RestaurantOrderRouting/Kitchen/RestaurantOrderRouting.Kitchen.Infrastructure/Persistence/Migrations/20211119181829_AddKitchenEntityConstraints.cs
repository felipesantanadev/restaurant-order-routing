using Microsoft.EntityFrameworkCore.Migrations;

namespace RestaurantOrderRouting.Kitchen.Infrastructure.Persistence.Migrations
{
    public partial class AddKitchenEntityConstraints : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PointOfSaleIdentifier",
                table: "Kitchens",
                type: "character varying(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedName",
                table: "Kitchens",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Kitchens",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ContactEmail",
                table: "Kitchens",
                type: "character varying(80)",
                maxLength: 80,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Kitchens_ContactEmail",
                table: "Kitchens",
                column: "ContactEmail",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Kitchens_Name",
                table: "Kitchens",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Kitchens_NormalizedName",
                table: "Kitchens",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Kitchens_PointOfSaleIdentifier",
                table: "Kitchens",
                column: "PointOfSaleIdentifier",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Kitchens_ContactEmail",
                table: "Kitchens");

            migrationBuilder.DropIndex(
                name: "IX_Kitchens_Name",
                table: "Kitchens");

            migrationBuilder.DropIndex(
                name: "IX_Kitchens_NormalizedName",
                table: "Kitchens");

            migrationBuilder.DropIndex(
                name: "IX_Kitchens_PointOfSaleIdentifier",
                table: "Kitchens");

            migrationBuilder.AlterColumn<string>(
                name: "PointOfSaleIdentifier",
                table: "Kitchens",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedName",
                table: "Kitchens",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Kitchens",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "ContactEmail",
                table: "Kitchens",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(80)",
                oldMaxLength: 80);
        }
    }
}
