﻿// <auto-generated />
using System;
using EFCore.WebAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCore.WebAPI.Migrations
{
    [DbContext(typeof(HeroContext))]
    partial class HeroContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFCore.WebAPI.Models.Battle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataFim");

                    b.Property<DateTime>("DataInicio");

                    b.Property<string>("Descricao");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Battles");
                });

            modelBuilder.Entity("EFCore.WebAPI.Models.Hero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Heroes");
                });

            modelBuilder.Entity("EFCore.WebAPI.Models.HeroBattle", b =>
                {
                    b.Property<int>("BatalhaId");

                    b.Property<int>("HeroId");

                    b.Property<int?>("BattleId");

                    b.HasKey("BatalhaId", "HeroId");

                    b.HasIndex("BattleId");

                    b.HasIndex("HeroId");

                    b.ToTable("HeroBattles");
                });

            modelBuilder.Entity("EFCore.WebAPI.Models.SecretIdentity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HeroId");

                    b.Property<int>("Nomereal");

                    b.HasKey("Id");

                    b.HasIndex("HeroId")
                        .IsUnique();

                    b.ToTable("SecretIdentities");
                });

            modelBuilder.Entity("EFCore.WebAPI.Models.Weapon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HeroiId");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.HasIndex("HeroiId");

                    b.ToTable("Weapons");
                });

            modelBuilder.Entity("EFCore.WebAPI.Models.HeroBattle", b =>
                {
                    b.HasOne("EFCore.WebAPI.Models.Battle", "Battle")
                        .WithMany("HeroesBattles")
                        .HasForeignKey("BattleId");

                    b.HasOne("EFCore.WebAPI.Models.Hero", "Hero")
                        .WithMany("HeroesBattles")
                        .HasForeignKey("HeroId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EFCore.WebAPI.Models.SecretIdentity", b =>
                {
                    b.HasOne("EFCore.WebAPI.Models.Hero", "Hero")
                        .WithOne("SecretIdentity")
                        .HasForeignKey("EFCore.WebAPI.Models.SecretIdentity", "HeroId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EFCore.WebAPI.Models.Weapon", b =>
                {
                    b.HasOne("EFCore.WebAPI.Models.Hero", "Heroi")
                        .WithMany("Weapons")
                        .HasForeignKey("HeroiId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}