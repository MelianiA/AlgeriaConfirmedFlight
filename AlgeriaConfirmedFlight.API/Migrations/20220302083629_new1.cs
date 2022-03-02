using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlgeriaConfirmedFlight.API.Migrations
{
    public partial class new1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VolComfirme_Compagnie_CompagnieId",
                table: "VolComfirme");

            migrationBuilder.DropIndex(
                name: "IX_VolComfirme_CompagnieId",
                table: "VolComfirme");

            migrationBuilder.RenameColumn(
                name: "CompagnieId",
                table: "VolComfirme",
                newName: "Compagnie");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Compagnie",
                table: "VolComfirme",
                newName: "CompagnieId");

            migrationBuilder.CreateIndex(
                name: "IX_VolComfirme_CompagnieId",
                table: "VolComfirme",
                column: "CompagnieId");

            migrationBuilder.AddForeignKey(
                name: "FK_VolComfirme_Compagnie_CompagnieId",
                table: "VolComfirme",
                column: "CompagnieId",
                principalTable: "Compagnie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
