using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieCharacterWebAPIProject.Migrations
{
    public partial class manytomanyrelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Faction",
                columns: table => new
                {
                    Factionid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    factionname = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faction", x => x.Factionid);
                });

            migrationBuilder.CreateTable(
                name: "CharacterFaction",
                columns: table => new
                {
                    Factionid = table.Column<int>(type: "int", nullable: false),
                    charactersCharacterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterFaction", x => new { x.Factionid, x.charactersCharacterId });
                    table.ForeignKey(
                        name: "FK_CharacterFaction_Characters_charactersCharacterId",
                        column: x => x.charactersCharacterId,
                        principalTable: "Characters",
                        principalColumn: "CharacterId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterFaction_Faction_Factionid",
                        column: x => x.Factionid,
                        principalTable: "Faction",
                        principalColumn: "Factionid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterFaction_charactersCharacterId",
                table: "CharacterFaction",
                column: "charactersCharacterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CharacterFaction");

            migrationBuilder.DropTable(
                name: "Faction");
        }
    }
}
