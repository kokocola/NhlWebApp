using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NhlDAL.Migrations
{
    public partial class AddingPlayerStatsGoalie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TimeOnIcePerGame",
                table: "PlayerStats",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(TimeSpan),
                oldType: "time");

            migrationBuilder.AlterColumn<string>(
                name: "ShortHandedTimeOnIcePerGame",
                table: "PlayerStats",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(TimeSpan),
                oldType: "time");

            migrationBuilder.AlterColumn<string>(
                name: "ShortHandedTimeOnIce",
                table: "PlayerStats",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(TimeSpan),
                oldType: "time");

            migrationBuilder.AlterColumn<string>(
                name: "PowerPlayTimeOnIcePerGame",
                table: "PlayerStats",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(TimeSpan),
                oldType: "time");

            migrationBuilder.AlterColumn<string>(
                name: "EvenTimeOnIcePerGame",
                table: "PlayerStats",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(TimeSpan),
                oldType: "time");

            migrationBuilder.AddColumn<long>(
                name: "EvenSaves",
                table: "PlayerStats",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "EvenShots",
                table: "PlayerStats",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<double>(
                name: "EvenStrengthSavePercentage",
                table: "PlayerStats",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<long>(
                name: "GamesStarted",
                table: "PlayerStats",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<double>(
                name: "GoalAgainstAverage",
                table: "PlayerStats",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<long>(
                name: "GoalsAgainst",
                table: "PlayerStats",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "Losses",
                table: "PlayerStats",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "Ot",
                table: "PlayerStats",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<double>(
                name: "PowerPlaySavePercentage",
                table: "PlayerStats",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<long>(
                name: "PowerPlaySaves",
                table: "PlayerStats",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "PowerPlayShots",
                table: "PlayerStats",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<double>(
                name: "SavePercentage",
                table: "PlayerStats",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<long>(
                name: "Saves",
                table: "PlayerStats",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<double>(
                name: "ShortHandedSavePercentage",
                table: "PlayerStats",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<long>(
                name: "ShortHandedSaves",
                table: "PlayerStats",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "ShortHandedShots",
                table: "PlayerStats",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "ShotsAgainst",
                table: "PlayerStats",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "Shutouts",
                table: "PlayerStats",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "Ties",
                table: "PlayerStats",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "Wins",
                table: "PlayerStats",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EvenSaves",
                table: "PlayerStats");

            migrationBuilder.DropColumn(
                name: "EvenShots",
                table: "PlayerStats");

            migrationBuilder.DropColumn(
                name: "EvenStrengthSavePercentage",
                table: "PlayerStats");

            migrationBuilder.DropColumn(
                name: "GamesStarted",
                table: "PlayerStats");

            migrationBuilder.DropColumn(
                name: "GoalAgainstAverage",
                table: "PlayerStats");

            migrationBuilder.DropColumn(
                name: "GoalsAgainst",
                table: "PlayerStats");

            migrationBuilder.DropColumn(
                name: "Losses",
                table: "PlayerStats");

            migrationBuilder.DropColumn(
                name: "Ot",
                table: "PlayerStats");

            migrationBuilder.DropColumn(
                name: "PowerPlaySavePercentage",
                table: "PlayerStats");

            migrationBuilder.DropColumn(
                name: "PowerPlaySaves",
                table: "PlayerStats");

            migrationBuilder.DropColumn(
                name: "PowerPlayShots",
                table: "PlayerStats");

            migrationBuilder.DropColumn(
                name: "SavePercentage",
                table: "PlayerStats");

            migrationBuilder.DropColumn(
                name: "Saves",
                table: "PlayerStats");

            migrationBuilder.DropColumn(
                name: "ShortHandedSavePercentage",
                table: "PlayerStats");

            migrationBuilder.DropColumn(
                name: "ShortHandedSaves",
                table: "PlayerStats");

            migrationBuilder.DropColumn(
                name: "ShortHandedShots",
                table: "PlayerStats");

            migrationBuilder.DropColumn(
                name: "ShotsAgainst",
                table: "PlayerStats");

            migrationBuilder.DropColumn(
                name: "Shutouts",
                table: "PlayerStats");

            migrationBuilder.DropColumn(
                name: "Ties",
                table: "PlayerStats");

            migrationBuilder.DropColumn(
                name: "Wins",
                table: "PlayerStats");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "TimeOnIcePerGame",
                table: "PlayerStats",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "ShortHandedTimeOnIcePerGame",
                table: "PlayerStats",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "ShortHandedTimeOnIce",
                table: "PlayerStats",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "PowerPlayTimeOnIcePerGame",
                table: "PlayerStats",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "EvenTimeOnIcePerGame",
                table: "PlayerStats",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
