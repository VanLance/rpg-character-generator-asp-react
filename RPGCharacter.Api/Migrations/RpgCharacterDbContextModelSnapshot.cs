﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RPGCharacter.Api.Data;

#nullable disable

namespace RPGCharacter.Api.Migrations
{
    [DbContext(typeof(RpgCharacterDbContext))]
    partial class RpgCharacterDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RPGCharacter.Api.Models.Domain.Archetype", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ArchetypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("HitDice")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Archetypes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("60d2434d-74ad-42a3-9664-dbfe796a4c5b"),
                            ArchetypeId = new Guid("00000000-0000-0000-0000-000000000000"),
                            HitDice = 10,
                            Name = "barbarian"
                        },
                        new
                        {
                            Id = new Guid("6a2c8fc7-3773-4569-9a3e-cf4d5b5a68f3"),
                            ArchetypeId = new Guid("00000000-0000-0000-0000-000000000000"),
                            HitDice = 8,
                            Name = "wizard"
                        },
                        new
                        {
                            Id = new Guid("9b4dd00d-0622-40e5-8331-bd894f362119"),
                            ArchetypeId = new Guid("00000000-0000-0000-0000-000000000000"),
                            HitDice = 10,
                            Name = "ranger"
                        });
                });

            modelBuilder.Entity("RPGCharacter.Api.Models.Domain.ArchetypeKeyStats", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ArchetypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("KeyStat1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KeyStat2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ArchetypeId")
                        .IsUnique();

                    b.ToTable("ArchetypeKeyStats");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d557739a-2903-4665-a2d1-000d9312ffb7"),
                            ArchetypeId = new Guid("60d2434d-74ad-42a3-9664-dbfe796a4c5b"),
                            KeyStat1 = "strength",
                            KeyStat2 = "dexterity"
                        },
                        new
                        {
                            Id = new Guid("8f8aaee5-a36f-4bc2-93d2-9758a376cd65"),
                            ArchetypeId = new Guid("6a2c8fc7-3773-4569-9a3e-cf4d5b5a68f3"),
                            KeyStat1 = "intelligence",
                            KeyStat2 = "wisdom"
                        },
                        new
                        {
                            Id = new Guid("50de78ff-fa9e-4024-980c-50ccead02e5c"),
                            ArchetypeId = new Guid("9b4dd00d-0622-40e5-8331-bd894f362119"),
                            KeyStat1 = "dexterity",
                            KeyStat2 = "constitution"
                        });
                });

            modelBuilder.Entity("RPGCharacter.Api.Models.Domain.Character", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ArchetypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RaceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("StatsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ArchetypeId");

                    b.HasIndex("RaceId");

                    b.HasIndex("StatsId");

                    b.HasIndex("UserId");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("RPGCharacter.Api.Models.Domain.Race", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Races");

                    b.HasData(
                        new
                        {
                            Id = new Guid("65728c3a-78c6-4a46-a79e-393843c2c098"),
                            Name = "elf"
                        },
                        new
                        {
                            Id = new Guid("6d549445-d419-4a35-9ecb-84567e4b03ff"),
                            Name = "dwarf"
                        },
                        new
                        {
                            Id = new Guid("d17528a7-34d8-4abc-93b2-d01787e44fad"),
                            Name = "hobbit"
                        });
                });

            modelBuilder.Entity("RPGCharacter.Api.Models.Domain.RaceStatBuff", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Buff")
                        .HasColumnType("int");

                    b.Property<Guid>("RaceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Stat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RaceId");

                    b.ToTable("RaceStatBuff");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6a379834-5bf8-4c85-8390-df01c9ea25b2"),
                            Buff = 2,
                            RaceId = new Guid("65728c3a-78c6-4a46-a79e-393843c2c098"),
                            Stat = "dexterity"
                        },
                        new
                        {
                            Id = new Guid("ffdb0de9-74a4-4a16-acf8-80abf10c7e14"),
                            Buff = 2,
                            RaceId = new Guid("d17528a7-34d8-4abc-93b2-d01787e44fad"),
                            Stat = "dexterity"
                        },
                        new
                        {
                            Id = new Guid("a6f9cb9f-38e3-4a7c-b505-000ac7462c1e"),
                            Buff = 2,
                            RaceId = new Guid("6d549445-d419-4a35-9ecb-84567e4b03ff"),
                            Stat = "strength"
                        });
                });

            modelBuilder.Entity("RPGCharacter.Api.Models.Domain.Stats", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ArmorClass")
                        .HasColumnType("int");

                    b.Property<int>("Charisma")
                        .HasColumnType("int");

                    b.Property<int>("Constitution")
                        .HasColumnType("int");

                    b.Property<int>("Dexterity")
                        .HasColumnType("int");

                    b.Property<int>("HitPoints")
                        .HasColumnType("int");

                    b.Property<int>("Intelligence")
                        .HasColumnType("int");

                    b.Property<int>("Strength")
                        .HasColumnType("int");

                    b.Property<int>("Wisdom")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Stats");
                });

            modelBuilder.Entity("RPGCharacter.Api.Models.Domain.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("RPGCharacter.Api.Models.Domain.ArchetypeKeyStats", b =>
                {
                    b.HasOne("RPGCharacter.Api.Models.Domain.Archetype", "Archetype")
                        .WithOne("KeyStats")
                        .HasForeignKey("RPGCharacter.Api.Models.Domain.ArchetypeKeyStats", "ArchetypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Archetype");
                });

            modelBuilder.Entity("RPGCharacter.Api.Models.Domain.Character", b =>
                {
                    b.HasOne("RPGCharacter.Api.Models.Domain.Archetype", "Archetype")
                        .WithMany()
                        .HasForeignKey("ArchetypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RPGCharacter.Api.Models.Domain.Race", "Race")
                        .WithMany()
                        .HasForeignKey("RaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RPGCharacter.Api.Models.Domain.Stats", "Stats")
                        .WithMany()
                        .HasForeignKey("StatsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RPGCharacter.Api.Models.Domain.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Archetype");

                    b.Navigation("Race");

                    b.Navigation("Stats");

                    b.Navigation("User");
                });

            modelBuilder.Entity("RPGCharacter.Api.Models.Domain.RaceStatBuff", b =>
                {
                    b.HasOne("RPGCharacter.Api.Models.Domain.Race", "Race")
                        .WithMany()
                        .HasForeignKey("RaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Race");
                });

            modelBuilder.Entity("RPGCharacter.Api.Models.Domain.Archetype", b =>
                {
                    b.Navigation("KeyStats")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
