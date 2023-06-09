﻿// <auto-generated />
using System;
using Gardens.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Gardens.Data.Migrations
{
    [DbContext(typeof(GardenDbContext))]
    partial class GardenDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Gardens.Entitiy.Garden", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Detail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GardenType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Gardens");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GardenType = "Flower Garden",
                            Name = "My Garden"
                        });
                });

            modelBuilder.Entity("Gardens.Entitiy.GardenNote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("GardenId")
                        .HasColumnType("int");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GardenId");

                    b.ToTable("GardenNotes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GardenId = 1,
                            Note = "My beautiful flowers in May."
                        });
                });

            modelBuilder.Entity("Gardens.Entitiy.GardenOwner", b =>
                {
                    b.Property<int>("GardenId")
                        .HasColumnType("int");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GardenId", "OwnerId");

                    b.HasIndex("OwnerId");

                    b.ToTable("GardenOwner");

                    b.HasData(
                        new
                        {
                            GardenId = 1,
                            OwnerId = 1,
                            Role = "Admin"
                        });
                });

            modelBuilder.Entity("Gardens.Entitiy.Owner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Owners");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "John",
                            LastName = "Doe"
                        });
                });

            modelBuilder.Entity("Gardens.Entitiy.GardenNote", b =>
                {
                    b.HasOne("Gardens.Entitiy.Garden", "Garden")
                        .WithMany("GardenNotes")
                        .HasForeignKey("GardenId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Garden");
                });

            modelBuilder.Entity("Gardens.Entitiy.GardenOwner", b =>
                {
                    b.HasOne("Gardens.Entitiy.Garden", "Garden")
                        .WithMany("Owners")
                        .HasForeignKey("GardenId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Gardens.Entitiy.Owner", "Owner")
                        .WithMany("Gardens")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Garden");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("Gardens.Entitiy.Garden", b =>
                {
                    b.Navigation("GardenNotes");

                    b.Navigation("Owners");
                });

            modelBuilder.Entity("Gardens.Entitiy.Owner", b =>
                {
                    b.Navigation("Gardens");
                });
#pragma warning restore 612, 618
        }
    }
}
