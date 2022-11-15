﻿// <auto-generated />
using System;
using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Entities.Migrations
{
    [DbContext(typeof(ManageContext))]
    [Migration("20221110181049_abc")]
    partial class abc
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Entities.Discipline", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<long?>("IDEmployee")
                        .HasColumnType("bigint");

                    b.Property<long>("Money")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("IDEmployee");

                    b.ToTable("Disciplines");
                });

            modelBuilder.Entity("Entities.Entities.Employee", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)");

                    b.Property<DateTime>("BirthDay")
                        .HasColumnType("datetime2");

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(1024)
                        .HasColumnType("varchar(1024)");

                    b.Property<string>("Name")
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)");

                    b.Property<string>("Phone")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<bool>("Sex")
                        .HasColumnType("bit");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CreatedBy");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Entities.Entities.EmployeeSalary", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<long?>("IDEmployee")
                        .HasColumnType("bigint");

                    b.Property<long>("Salary")
                        .HasColumnType("bigint");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("IDEmployee");

                    b.ToTable("EmployeeSalary");
                });

            modelBuilder.Entity("Entities.Entities.Reward", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("IDEmployee")
                        .HasColumnType("bigint");

                    b.Property<long>("Money")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("IDEmployee");

                    b.ToTable("Rewards");
                });

            modelBuilder.Entity("Entities.Entities.User", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)");

                    b.Property<DateTime>("BirthDay")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(1024)
                        .HasColumnType("varchar(1024)");

                    b.Property<string>("Name")
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)");

                    b.Property<string>("Password")
                        .HasMaxLength(1024)
                        .HasColumnType("varchar(1024)");

                    b.Property<string>("Phone")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<bool>("Sex")
                        .HasColumnType("bit");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<short?>("UserType")
                        .HasColumnType("smallint");

                    b.Property<string>("Username")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("ID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            ID = 1L,
                            Address = "a",
                            BirthDay = new DateTime(2022, 11, 11, 1, 10, 48, 121, DateTimeKind.Local).AddTicks(7428),
                            CreatedDate = new DateTime(2022, 11, 11, 1, 10, 48, 120, DateTimeKind.Local).AddTicks(6854),
                            Email = "abc",
                            Name = "Dương",
                            Password = "1",
                            Phone = "123",
                            Sex = true,
                            Status = true,
                            UserType = (short)1,
                            Username = "admin"
                        });
                });

            modelBuilder.Entity("Entities.Entities.Discipline", b =>
                {
                    b.HasOne("Entities.Entities.User", "User")
                        .WithMany("Disciplines")
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Entities.Entities.Employee", "Employee")
                        .WithMany("Disciplines")
                        .HasForeignKey("IDEmployee")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Employee");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.Entities.Employee", b =>
                {
                    b.HasOne("Entities.Entities.User", "User")
                        .WithMany("Employees")
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.Entities.EmployeeSalary", b =>
                {
                    b.HasOne("Entities.Entities.User", "User")
                        .WithMany("EmployeeSalaries")
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Entities.Entities.Employee", "Employee")
                        .WithMany("EmployeeSalaries")
                        .HasForeignKey("IDEmployee")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Employee");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.Entities.Reward", b =>
                {
                    b.HasOne("Entities.Entities.User", "User")
                        .WithMany("Rewards")
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Entities.Entities.Employee", "Employee")
                        .WithMany("Rewards")
                        .HasForeignKey("IDEmployee")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.Entities.Employee", b =>
                {
                    b.Navigation("Disciplines");

                    b.Navigation("EmployeeSalaries");

                    b.Navigation("Rewards");
                });

            modelBuilder.Entity("Entities.Entities.User", b =>
                {
                    b.Navigation("Disciplines");

                    b.Navigation("Employees");

                    b.Navigation("EmployeeSalaries");

                    b.Navigation("Rewards");
                });
#pragma warning restore 612, 618
        }
    }
}