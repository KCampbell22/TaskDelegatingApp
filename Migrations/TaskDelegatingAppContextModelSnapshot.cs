﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaskDelegatingApp.Data;

#nullable disable

namespace TaskDelegatingApp.Migrations
{
    [DbContext(typeof(TaskDelegatingAppContext))]
    partial class TaskDelegatingAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<int?>("DayId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TaskItemID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("DayId");

                    b.HasIndex("TaskItemID");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("TaskDelegatingApp.Models.TaskItem", b =>
                {
                    b.Property<int>("TaskItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TaskItemID"));

                    b.Property<int>("DayAssigned")
                        .HasColumnType("int");

                    b.Property<int>("DayId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<int?>("TimeofDay")
                        .HasColumnType("int");

                    b.HasKey("TaskItemID");

                    b.HasIndex("DayId");

                    b.ToTable("TaskItem");
                });

            modelBuilder.Entity("TaskDelegatingApp.Models.Person", b =>
                {
                    b.HasOne("TaskDelegatingApp.Models.Day", "Day")
                        .WithMany("Persons")
                        .HasForeignKey("DayId");

                    b.HasOne("TaskDelegatingApp.Models.TaskItem", "TaskItem")
                        .WithMany("Person")
                        .HasForeignKey("TaskItemID");

                    b.Navigation("Day");

                    b.Navigation("TaskItem");
                });

            modelBuilder.Entity("TaskDelegatingApp.Models.TaskItem", b =>
                {
                    b.HasOne("TaskDelegatingApp.Models.Day", "Day")
                        .WithMany("TaskItems")
                        .HasForeignKey("DayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Day");
                });

            modelBuilder.Entity("TaskDelegatingApp.Models.Day", b =>
                {
                    b.Navigation("Persons");

                    b.Navigation("TaskItems");
                });

            modelBuilder.Entity("TaskDelegatingApp.Models.TaskItem", b =>
                {
                    b.Navigation("Person");
                });
#pragma warning restore 612, 618
        }
    }
}
