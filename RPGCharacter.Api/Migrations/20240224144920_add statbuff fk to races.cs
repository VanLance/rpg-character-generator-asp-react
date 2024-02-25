using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RPGCharacter.Api.Migrations
{
    /// <inheritdoc />
    public partial class addstatbufffktoraces : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RaceStatBuff_Races_RaceId",
                table: "RaceStatBuff");

            migrationBuilder.DropIndex(
                name: "IX_RaceStatBuff_RaceId",
                table: "RaceStatBuff");

            migrationBuilder.DropColumn(
                name: "RaceId",
                table: "RaceStatBuff");

            migrationBuilder.DropColumn(
                name: "ArchetypeId",
                table: "Archetypes");

            migrationBuilder.AddColumn<Guid>(
                name: "RaceStatBuffId",
                table: "Races",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: new Guid("65728c3a-78c6-4a46-a79e-393843c2c098"),
                column: "RaceStatBuffId",
                value: new Guid("6a379834-5bf8-4c85-8390-df01c9ea25b2"));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: new Guid("6d549445-d419-4a35-9ecb-84567e4b03ff"),
                column: "RaceStatBuffId",
                value: new Guid("ffdb0de9-74a4-4a16-acf8-80abf10c7e14"));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: new Guid("d17528a7-34d8-4abc-93b2-d01787e44fad"),
                column: "RaceStatBuffId",
                value: new Guid("a6f9cb9f-38e3-4a7c-b505-000ac7462c1e"));

            migrationBuilder.CreateIndex(
                name: "IX_Races_RaceStatBuffId",
                table: "Races",
                column: "RaceStatBuffId");

            migrationBuilder.AddForeignKey(
                name: "FK_Races_RaceStatBuff_RaceStatBuffId",
                table: "Races",
                column: "RaceStatBuffId",
                principalTable: "RaceStatBuff",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Races_RaceStatBuff_RaceStatBuffId",
                table: "Races");

            migrationBuilder.DropIndex(
                name: "IX_Races_RaceStatBuffId",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "RaceStatBuffId",
                table: "Races");

            migrationBuilder.AddColumn<Guid>(
                name: "RaceId",
                table: "RaceStatBuff",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ArchetypeId",
                table: "Archetypes",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Archetypes",
                keyColumn: "Id",
                keyValue: new Guid("60d2434d-74ad-42a3-9664-dbfe796a4c5b"),
                column: "ArchetypeId",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Archetypes",
                keyColumn: "Id",
                keyValue: new Guid("6a2c8fc7-3773-4569-9a3e-cf4d5b5a68f3"),
                column: "ArchetypeId",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Archetypes",
                keyColumn: "Id",
                keyValue: new Guid("9b4dd00d-0622-40e5-8331-bd894f362119"),
                column: "ArchetypeId",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "RaceStatBuff",
                keyColumn: "Id",
                keyValue: new Guid("6a379834-5bf8-4c85-8390-df01c9ea25b2"),
                column: "RaceId",
                value: new Guid("65728c3a-78c6-4a46-a79e-393843c2c098"));

            migrationBuilder.UpdateData(
                table: "RaceStatBuff",
                keyColumn: "Id",
                keyValue: new Guid("a6f9cb9f-38e3-4a7c-b505-000ac7462c1e"),
                column: "RaceId",
                value: new Guid("6d549445-d419-4a35-9ecb-84567e4b03ff"));

            migrationBuilder.UpdateData(
                table: "RaceStatBuff",
                keyColumn: "Id",
                keyValue: new Guid("ffdb0de9-74a4-4a16-acf8-80abf10c7e14"),
                column: "RaceId",
                value: new Guid("d17528a7-34d8-4abc-93b2-d01787e44fad"));

            migrationBuilder.CreateIndex(
                name: "IX_RaceStatBuff_RaceId",
                table: "RaceStatBuff",
                column: "RaceId");

            migrationBuilder.AddForeignKey(
                name: "FK_RaceStatBuff_Races_RaceId",
                table: "RaceStatBuff",
                column: "RaceId",
                principalTable: "Races",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
