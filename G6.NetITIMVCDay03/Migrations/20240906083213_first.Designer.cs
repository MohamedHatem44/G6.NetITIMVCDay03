﻿// <auto-generated />
using G6.NetITIMVCDay03.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace G6.NetITIMVCDay03.Migrations
{
    [DbContext(typeof(CompanyContext))]
    [Migration("20240906083213_first")]
    partial class first
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("G6.NetITIMVCDay03.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DeptName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DeptName = "HR"
                        },
                        new
                        {
                            Id = 2,
                            DeptName = "PR"
                        },
                        new
                        {
                            Id = 3,
                            DeptName = "Social Media"
                        },
                        new
                        {
                            Id = 4,
                            DeptName = "Finance"
                        },
                        new
                        {
                            Id = 5,
                            DeptName = "SD"
                        });
                });

            modelBuilder.Entity("G6.NetITIMVCDay03.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(8,2)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 20,
                            DepartmentId = 1,
                            Name = "Ramy",
                            Salary = 1234m
                        },
                        new
                        {
                            Id = 2,
                            Age = 25,
                            DepartmentId = 2,
                            Name = "Ali",
                            Salary = 2234m
                        },
                        new
                        {
                            Id = 3,
                            Age = 30,
                            DepartmentId = 3,
                            Name = "Mohamed",
                            Salary = 3234m
                        },
                        new
                        {
                            Id = 4,
                            Age = 35,
                            DepartmentId = 4,
                            Name = "Ahmed",
                            Salary = 4234m
                        },
                        new
                        {
                            Id = 5,
                            Age = 40,
                            DepartmentId = 5,
                            Name = "Hala",
                            Salary = 5234m
                        },
                        new
                        {
                            Id = 6,
                            Age = 45,
                            DepartmentId = 1,
                            Name = "Mai",
                            Salary = 6234m
                        },
                        new
                        {
                            Id = 7,
                            Age = 50,
                            DepartmentId = 2,
                            Name = "Omar",
                            Salary = 7234m
                        },
                        new
                        {
                            Id = 8,
                            Age = 55,
                            DepartmentId = 3,
                            Name = "Sara",
                            Salary = 8234m
                        },
                        new
                        {
                            Id = 9,
                            Age = 30,
                            DepartmentId = 4,
                            Name = "Mostafa",
                            Salary = 9234m
                        },
                        new
                        {
                            Id = 10,
                            Age = 40,
                            DepartmentId = 5,
                            Name = "Nour",
                            Salary = 10234m
                        });
                });

            modelBuilder.Entity("G6.NetITIMVCDay03.Models.Employee", b =>
                {
                    b.HasOne("G6.NetITIMVCDay03.Models.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("G6.NetITIMVCDay03.Models.Department", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
