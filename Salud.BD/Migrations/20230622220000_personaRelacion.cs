using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Salud.BD.Migrations
{
    /// <inheritdoc />
    public partial class personaRelacion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Titulo",
                table: "Profesiones",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CodProfesion",
                table: "Profesiones",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Apellido",
                table: "Personas",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "Personas",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NumDoc",
                table: "Personas",
                type: "nvarchar(9)",
                maxLength: 9,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "TipoDocumentoId",
                table: "Personas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "Profesion_Cod_UQ",
                table: "Profesiones",
                column: "CodProfesion",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "Persona_TD_DNI_UQ",
                table: "Personas",
                columns: new[] { "TipoDocumentoId", "NumDoc" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_TipoDocumentos_TipoDocumentoId",
                table: "Personas",
                column: "TipoDocumentoId",
                principalTable: "TipoDocumentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personas_TipoDocumentos_TipoDocumentoId",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "Profesion_Cod_UQ",
                table: "Profesiones");

            migrationBuilder.DropIndex(
                name: "Persona_TD_DNI_UQ",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Apellido",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "NumDoc",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "TipoDocumentoId",
                table: "Personas");

            migrationBuilder.AlterColumn<string>(
                name: "Titulo",
                table: "Profesiones",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "CodProfesion",
                table: "Profesiones",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(4)",
                oldMaxLength: 4);
        }
    }
}
