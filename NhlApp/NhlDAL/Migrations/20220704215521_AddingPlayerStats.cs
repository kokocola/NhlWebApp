using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NhlDAL.Migrations
{
    public partial class AddingPlayerStats : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlayerStats",
                columns: table => new
                {
                    PlayerStatsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TimeOnIce = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Assists = table.Column<int>(type: "int", nullable: false),
                    Goals = table.Column<int>(type: "int", nullable: false),
                    Pim = table.Column<int>(type: "int", nullable: false),
                    Shots = table.Column<int>(type: "int", nullable: false),
                    Games = table.Column<int>(type: "int", nullable: false),
                    Hits = table.Column<int>(type: "int", nullable: false),
                    PowerPlayGoals = table.Column<int>(type: "int", nullable: false),
                    PowerPlayPoints = table.Column<int>(type: "int", nullable: false),
                    PowerPlayTimeOnIce = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EvenTimeOnIce = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PenaltyMinutes = table.Column<int>(type: "int", nullable: false),
                    FaceOffPct = table.Column<int>(type: "int", nullable: false),
                    ShotPct = table.Column<double>(type: "float", nullable: false),
                    GameWinningGoals = table.Column<int>(type: "int", nullable: false),
                    OverTimeGoals = table.Column<int>(type: "int", nullable: false),
                    ShortHandedGoals = table.Column<int>(type: "int", nullable: false),
                    ShortHandedPoints = table.Column<int>(type: "int", nullable: false),
                    ShortHandedTimeOnIce = table.Column<TimeSpan>(type: "time", nullable: false),
                    Blocked = table.Column<int>(type: "int", nullable: false),
                    PlusMinus = table.Column<int>(type: "int", nullable: false),
                    Points = table.Column<int>(type: "int", nullable: false),
                    Shifts = table.Column<int>(type: "int", nullable: false),
                    TimeOnIcePerGame = table.Column<TimeSpan>(type: "time", nullable: false),
                    EvenTimeOnIcePerGame = table.Column<TimeSpan>(type: "time", nullable: false),
                    ShortHandedTimeOnIcePerGame = table.Column<TimeSpan>(type: "time", nullable: false),
                    PowerPlayTimeOnIcePerGame = table.Column<TimeSpan>(type: "time", nullable: false),
                    SeasonStart = table.Column<int>(type: "int", nullable: false),
                    SeasonEnd = table.Column<int>(type: "int", nullable: false),
                    GameType = table.Column<int>(type: "int", nullable: false),
                    PlayerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerStats", x => x.PlayerStatsId);
                    table.ForeignKey(
                        name: "FK_PlayerStats_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlayerStats_PlayerId",
                table: "PlayerStats",
                column: "PlayerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlayerStats");
        }
    }
}
