﻿// <auto-generated />
using System;
using DuoLingQCombiner.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DuoLingQCombiner.Migrations
{
    [DbContext(typeof(WordDataContext))]
    [Migration("20200201063028_Third-Migration23")]
    partial class ThirdMigration23
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DuoLingQCombiner.Models.Word", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ForeignLanguage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NativeLanguage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TypeOfSpeech")
                        .HasColumnType("int");

                    b.Property<int>("WordListId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WordListId");

                    b.ToTable("Words");
                });

            modelBuilder.Entity("DuoLingQCombiner.Models.WordList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("WordLists");
                });

            modelBuilder.Entity("DuoLingQCombiner.Models.Word", b =>
                {
                    b.HasOne("DuoLingQCombiner.Models.WordList", null)
                        .WithMany("Words")
                        .HasForeignKey("WordListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
