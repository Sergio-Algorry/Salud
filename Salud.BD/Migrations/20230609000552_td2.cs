using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Salud.BD.Migrations
{
    /// <inheritdoc />
    public partial class td2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "TipoDocumento_Cod_UQ",
                table: "TipoDocumentos",
                column: "Cod",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "TipoDocumento_Cod_UQ",
                table: "TipoDocumentos");
        }
    }
}
