using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLagring.Migrations
{
    /// <inheritdoc />
    public partial class TableFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StadiumId",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Teams_CountryId",
                table: "Teams",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_StadiumId",
                table: "Teams",
                column: "StadiumId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Countries_CountryId",
                table: "Teams",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Stadiums_StadiumId",
                table: "Teams",
                column: "StadiumId",
                principalTable: "Stadiums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Countries_CountryId",
                table: "Teams");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Stadiums_StadiumId",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_CountryId",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_StadiumId",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "StadiumId",
                table: "Teams");
        }
    }
}
