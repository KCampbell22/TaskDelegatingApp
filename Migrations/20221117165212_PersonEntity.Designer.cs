﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaskDelegatingApp.Data;

#nullable disable

namespace TaskDelegatingApp.Migrations
{
    [DbContext(typeof(TaskDelegatingAppContext))]
    [Migration("20221117165212_PersonEntity")]
    partial class PersonEntity
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TaskDelegatingApp.Models.Day", b =>
                {
                    b.Property<int>("DayId")
                        .HasColumnType("int");

                    b.Property<string>("DayName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DayId");

                    b.ToTable("Day");
                });

            modelBuilder.Entity("TaskDelegatingApp.Models.Person", b =>
                {
                    b.Property<int>("ID")
                        .HasColumnType("int");

                    b.Property<bool>("AvailableFriday")
                        .HasColumnType("bit");

                    b.Property<bool>("AvailableMonday")
                        .HasColumnType("bit");

                    b.Property<bool>("AvailableSaturday")
                        .HasColumnType("bit");

                    b.Property<bool>("AvailableSunday")
                        .HasColumnType("bit");

                    b.Property<bool>("AvailableThursday")
                        .HasColumnType("bit");

                    b.Property<bool>("AvailableTuesday")
                        .HasColumnType("bit");

                    b.Property<bool>("AvailableWednsday")
                        .HasColumnType("bit");

                    b.Property<int>("DayId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("DayId");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("TaskDelegatingApp.Models.TaskItem", b =>
                {
                    b.Property<int>("TaskItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TaskItemID"));

                    b.Property<int>("DayId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PersonID")
                        .HasColumnType("int");

                    b.Property<int>("TimeofDay")
                        .HasColumnType("int");

                    b.HasKey("TaskItemID");

                    b.HasIndex("DayId");

                    b.HasIndex("PersonID");

                    b.ToTable("TaskItem");
                });

            modelBuilder.Entity("TaskDelegatingApp.Models.Person", b =>
                {
                    b.HasOne("TaskDelegatingApp.Models.Day", "Day")
                        .WithMany("People")
                        .HasForeignKey("DayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Day");
                });

            modelBuilder.Entity("TaskDelegatingApp.Models.TaskItem", b =>
                {
                    b.HasOne("TaskDelegatingApp.Models.Day", "Day")
                        .WithMany("TaskItems")
                        .HasForeignKey("DayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TaskDelegatingApp.Models.Person", "Person")
                        .WithMany("TaskItems")
                        .HasForeignKey("PersonID");

                    b.Navigation("Day");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("TaskDelegatingApp.Models.Day", b =>
                {
                    b.Navigation("People");

                    b.Navigation("TaskItems");
                });

            modelBuilder.Entity("TaskDelegatingApp.Models.Person", b =>
                {
                    b.Navigation("TaskItems");
                });
#pragma warning restore 612, 618
        }
    }
}
