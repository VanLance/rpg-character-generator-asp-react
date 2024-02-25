using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RPGCharacter.Api.Migrations
{
    /// <inheritdoc />
    public partial class fixcasing : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ArchetypeKeyStats",
                keyColumn: "Id",
                keyValue: new Guid("50de78ff-fa9e-4024-980c-50ccead02e5c"),
                columns: new[] { "KeyStat1", "KeyStat2" },
                values: new object[] { "Dexterity", "Constitution" });

            migrationBuilder.UpdateData(
                table: "ArchetypeKeyStats",
                keyColumn: "Id",
                keyValue: new Guid("8f8aaee5-a36f-4bc2-93d2-9758a376cd65"),
                columns: new[] { "KeyStat1", "KeyStat2" },
                values: new object[] { "Intelligence", "Wisdom" });

            migrationBuilder.UpdateData(
                table: "ArchetypeKeyStats",
                keyColumn: "Id",
                keyValue: new Guid("d557739a-2903-4665-a2d1-000d9312ffb7"),
                columns: new[] { "KeyStat1", "KeyStat2" },
                values: new object[] { "Strength", "Dexterity" });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: new Guid("65728c3a-78c6-4a46-a79e-393843c2c098"),
                column: "Name",
                value: "Elf");

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: new Guid("6d549445-d419-4a35-9ecb-84567e4b03ff"),
                column: "Name",
                value: "Dwarf");

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: new Guid("d17528a7-34d8-4abc-93b2-d01787e44fad"),
                column: "Name",
                value: "Hobbit");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ArchetypeKeyStats",
                keyColumn: "Id",
                keyValue: new Guid("50de78ff-fa9e-4024-980c-50ccead02e5c"),
                columns: new[] { "KeyStat1", "KeyStat2" },
                values: new object[] { "dexterity", "constitution" });

            migrationBuilder.UpdateData(
                table: "ArchetypeKeyStats",
                keyColumn: "Id",
                keyValue: new Guid("8f8aaee5-a36f-4bc2-93d2-9758a376cd65"),
                columns: new[] { "KeyStat1", "KeyStat2" },
                values: new object[] { "intelligence", "wisdom" });

            migrationBuilder.UpdateData(
                table: "ArchetypeKeyStats",
                keyColumn: "Id",
                keyValue: new Guid("d557739a-2903-4665-a2d1-000d9312ffb7"),
                columns: new[] { "KeyStat1", "KeyStat2" },
                values: new object[] { "strength", "dexterity" });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: new Guid("65728c3a-78c6-4a46-a79e-393843c2c098"),
                column: "Name",
                value: "elf");

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: new Guid("6d549445-d419-4a35-9ecb-84567e4b03ff"),
                column: "Name",
                value: "dwarf");

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: new Guid("d17528a7-34d8-4abc-93b2-d01787e44fad"),
                column: "Name",
                value: "hobbit");
        }
    }
}
