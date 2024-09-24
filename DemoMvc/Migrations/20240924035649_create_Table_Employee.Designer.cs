﻿// <auto-generated />
using DemoMvc.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DemoMvc.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240924035649_create_Table_Employee")]
    partial class create_Table_Employee
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("DemoMVC.Models.Employee", b =>
                {
                    b.Property<string>("EmployeeID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Fullname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("EmployeeID");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("DemoMVC.Models.Student", b =>
                {
                    b.Property<string>("FullName")
                        .HasColumnType("TEXT");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("FullName");

                    b.ToTable("Student");
                });
#pragma warning restore 612, 618
        }
    }
}
