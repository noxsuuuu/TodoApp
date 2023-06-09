﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TodoApp.Data;

#nullable disable

namespace TodoApp.Migrations
{
    [DbContext(typeof(TodoDbContext))]
    partial class TodoDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TodoApp.Models.Todo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Todos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "For Birthday",
                            DueDate = new DateTime(2023, 3, 17, 16, 26, 53, 275, DateTimeKind.Local).AddTicks(7694),
                            Status = false,
                            Title = "Shopping"
                        },
                        new
                        {
                            Id = 2,
                            Description = "In Jump Trainin",
                            DueDate = new DateTime(2023, 3, 18, 16, 26, 53, 275, DateTimeKind.Local).AddTicks(7710),
                            Status = false,
                            Title = "Learn C#"
                        },
                        new
                        {
                            Id = 3,
                            Description = "In Jump Trainin",
                            DueDate = new DateTime(2023, 3, 18, 16, 26, 53, 275, DateTimeKind.Local).AddTicks(7711),
                            Status = false,
                            Title = "Learn MSSQL"
                        });
                });

            modelBuilder.Entity("TodoApp.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("ntext")
                        .HasColumnName("First_Name");

                    b.HasKey("Id");

                    b.ToTable("People", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DOB = new DateTime(2003, 3, 16, 16, 26, 53, 275, DateTimeKind.Local).AddTicks(7573),
                            Name = "Administrator"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
