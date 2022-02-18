using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpenseTrackerAPI.Migrations
{
    public partial class Add_ModelBases : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderStatuses");

            migrationBuilder.DropTable(
                name: "PaymentMethods");

            migrationBuilder.DropTable(
                name: "PurchaseTaxes");

            migrationBuilder.DropTable(
                name: "UOMs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserAccounts",
                table: "UserAccounts");

            migrationBuilder.RenameTable(
                name: "UserAccounts",
                newName: "ModelBases");

            migrationBuilder.AlterColumn<int>(
                name: "Password",
                table: "ModelBases",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Login",
                table: "ModelBases",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Localisation",
                table: "ModelBases",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ModelBases",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "ModelBases",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Discription",
                table: "ModelBases",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InvoiceItemId",
                table: "ModelBases",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsOnline",
                table: "ModelBases",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "ModelBases",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OrderStatusName",
                table: "ModelBases",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PaymentMethodName",
                table: "ModelBases",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PaymentMethod_OrderId",
                table: "ModelBases",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PurchaseTax_Description",
                table: "ModelBases",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TaxRatePercent",
                table: "ModelBases",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UOM_Discription",
                table: "ModelBases",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UOM_InvoiceItemId",
                table: "ModelBases",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UomName",
                table: "ModelBases",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserAccount_OrderId",
                table: "ModelBases",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ModelBases",
                table: "ModelBases",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ModelBases",
                table: "ModelBases");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "ModelBases");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "ModelBases");

            migrationBuilder.DropColumn(
                name: "Discription",
                table: "ModelBases");

            migrationBuilder.DropColumn(
                name: "InvoiceItemId",
                table: "ModelBases");

            migrationBuilder.DropColumn(
                name: "IsOnline",
                table: "ModelBases");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "ModelBases");

            migrationBuilder.DropColumn(
                name: "OrderStatusName",
                table: "ModelBases");

            migrationBuilder.DropColumn(
                name: "PaymentMethodName",
                table: "ModelBases");

            migrationBuilder.DropColumn(
                name: "PaymentMethod_OrderId",
                table: "ModelBases");

            migrationBuilder.DropColumn(
                name: "PurchaseTax_Description",
                table: "ModelBases");

            migrationBuilder.DropColumn(
                name: "TaxRatePercent",
                table: "ModelBases");

            migrationBuilder.DropColumn(
                name: "UOM_Discription",
                table: "ModelBases");

            migrationBuilder.DropColumn(
                name: "UOM_InvoiceItemId",
                table: "ModelBases");

            migrationBuilder.DropColumn(
                name: "UomName",
                table: "ModelBases");

            migrationBuilder.DropColumn(
                name: "UserAccount_OrderId",
                table: "ModelBases");

            migrationBuilder.RenameTable(
                name: "ModelBases",
                newName: "UserAccounts");

            migrationBuilder.AlterColumn<int>(
                name: "Password",
                table: "UserAccounts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Login",
                table: "UserAccounts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Localisation",
                table: "UserAccounts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserAccounts",
                table: "UserAccounts",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "OrderStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedData = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Discription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    OrderStatusName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedData = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedData = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    IsOnline = table.Column<bool>(type: "bit", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    PaymentMethodName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedData = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseTaxes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedData = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InvoiceItemId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaxRatePercent = table.Column<int>(type: "int", nullable: false),
                    UpdatedData = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseTaxes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UOMs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedData = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Discription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InvoiceItemId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    UomName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedData = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UOMs", x => x.Id);
                });
        }
    }
}
