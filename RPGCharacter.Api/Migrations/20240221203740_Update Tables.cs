using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RPGCharacter.Api.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Races_RaceId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_RaceId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "ArchetypeId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "RaceId",
                table: "Characters");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ArmorClass",
                table: "Stats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HitPoints",
                table: "Stats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Archetype",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Race",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Archetypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("60d2434d-74ad-42a3-9664-dbfe796a4c5b"), "barbarian" },
                    { new Guid("6a2c8fc7-3773-4569-9a3e-cf4d5b5a68f3"), "wizard" },
                    { new Guid("9b4dd00d-0622-40e5-8331-bd894f362119"), "rogue" }
                });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("65728c3a-78c6-4a46-a79e-393843c2c098"), "elf" },
                    { new Guid("6d549445-d419-4a35-9ecb-84567e4b03ff"), "dwarf" },
                    { new Guid("d17528a7-34d8-4abc-93b2-d01787e44fad"), "hobbit" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Archetypes",
                keyColumn: "Id",
                keyValue: new Guid("60d2434d-74ad-42a3-9664-dbfe796a4c5b"));

            migrationBuilder.DeleteData(
                table: "Archetypes",
                keyColumn: "Id",
                keyValue: new Guid("6a2c8fc7-3773-4569-9a3e-cf4d5b5a68f3"));

            migrationBuilder.DeleteData(
                table: "Archetypes",
                keyColumn: "Id",
                keyValue: new Guid("9b4dd00d-0622-40e5-8331-bd894f362119"));

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: new Guid("65728c3a-78c6-4a46-a79e-393843c2c098"));

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: new Guid("6d549445-d419-4a35-9ecb-84567e4b03ff"));

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: new Guid("d17528a7-34d8-4abc-93b2-d01787e44fad"));

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ArmorClass",
                table: "Stats");

            migrationBuilder.DropColumn(
                name: "HitPoints",
                table: "Stats");

            migrationBuilder.DropColumn(
                name: "Archetype",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Race",
                table: "Characters");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ArchetypeId",
                table: "Characters",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "RaceId",
                table: "Characters",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Characters_RaceId",
                table: "Characters",
                column: "RaceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Races_RaceId",
                table: "Characters",
                column: "RaceId",
                principalTable: "Races",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
