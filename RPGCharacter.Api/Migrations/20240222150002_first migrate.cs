using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RPGCharacter.Api.Migrations
{
    /// <inheritdoc />
    public partial class firstmigrate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Archetypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HitDice = table.Column<int>(type: "int", nullable: false),
                    ArchetypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Archetypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Races",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Races", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stats",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HitPoints = table.Column<int>(type: "int", nullable: false),
                    ArmorClass = table.Column<int>(type: "int", nullable: false),
                    Strength = table.Column<int>(type: "int", nullable: false),
                    Dexterity = table.Column<int>(type: "int", nullable: false),
                    Constitution = table.Column<int>(type: "int", nullable: false),
                    Wisdom = table.Column<int>(type: "int", nullable: false),
                    Intelligence = table.Column<int>(type: "int", nullable: false),
                    Charisma = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArchetypeKeyStats",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArchetypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KeyStat1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KeyStat2 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArchetypeKeyStats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArchetypeKeyStats_Archetypes_ArchetypeId",
                        column: x => x.ArchetypeId,
                        principalTable: "Archetypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RaceStatBuff",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Stat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Buff = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RaceStatBuff", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RaceStatBuff_Races_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Races",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArchetypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StatsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Characters_Archetypes_ArchetypeId",
                        column: x => x.ArchetypeId,
                        principalTable: "Archetypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Characters_Races_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Races",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Characters_Stats_StatsId",
                        column: x => x.StatsId,
                        principalTable: "Stats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Characters_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Archetypes",
                columns: new[] { "Id", "ArchetypeId", "HitDice", "Name" },
                values: new object[,]
                {
                    { new Guid("60d2434d-74ad-42a3-9664-dbfe796a4c5b"), new Guid("00000000-0000-0000-0000-000000000000"), 10, "barbarian" },
                    { new Guid("6a2c8fc7-3773-4569-9a3e-cf4d5b5a68f3"), new Guid("00000000-0000-0000-0000-000000000000"), 8, "wizard" },
                    { new Guid("9b4dd00d-0622-40e5-8331-bd894f362119"), new Guid("00000000-0000-0000-0000-000000000000"), 10, "ranger" }
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

            migrationBuilder.InsertData(
                table: "ArchetypeKeyStats",
                columns: new[] { "Id", "ArchetypeId", "KeyStat1", "KeyStat2" },
                values: new object[,]
                {
                    { new Guid("50de78ff-fa9e-4024-980c-50ccead02e5c"), new Guid("9b4dd00d-0622-40e5-8331-bd894f362119"), "dexterity", "constitution" },
                    { new Guid("8f8aaee5-a36f-4bc2-93d2-9758a376cd65"), new Guid("6a2c8fc7-3773-4569-9a3e-cf4d5b5a68f3"), "intelligence", "wisdom" },
                    { new Guid("d557739a-2903-4665-a2d1-000d9312ffb7"), new Guid("60d2434d-74ad-42a3-9664-dbfe796a4c5b"), "strength", "dexterity" }
                });

            migrationBuilder.InsertData(
                table: "RaceStatBuff",
                columns: new[] { "Id", "Buff", "RaceId", "Stat" },
                values: new object[,]
                {
                    { new Guid("6a379834-5bf8-4c85-8390-df01c9ea25b2"), 2, new Guid("65728c3a-78c6-4a46-a79e-393843c2c098"), "dexterity" },
                    { new Guid("a6f9cb9f-38e3-4a7c-b505-000ac7462c1e"), 2, new Guid("6d549445-d419-4a35-9ecb-84567e4b03ff"), "strength" },
                    { new Guid("ffdb0de9-74a4-4a16-acf8-80abf10c7e14"), 2, new Guid("d17528a7-34d8-4abc-93b2-d01787e44fad"), "dexterity" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArchetypeKeyStats_ArchetypeId",
                table: "ArchetypeKeyStats",
                column: "ArchetypeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Characters_ArchetypeId",
                table: "Characters",
                column: "ArchetypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_RaceId",
                table: "Characters",
                column: "RaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_StatsId",
                table: "Characters",
                column: "StatsId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_UserId",
                table: "Characters",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RaceStatBuff_RaceId",
                table: "RaceStatBuff",
                column: "RaceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArchetypeKeyStats");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "RaceStatBuff");

            migrationBuilder.DropTable(
                name: "Archetypes");

            migrationBuilder.DropTable(
                name: "Stats");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Races");
        }
    }
}
