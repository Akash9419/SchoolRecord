﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchoolRecord.Data;

namespace SchoolRecord.Migrations
{
    [DbContext(typeof(SchoolRecordContext))]
    [Migration("20211010211249_third")]
    partial class third
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SchoolRecord.Models.Query", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("dTime")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.ToTable("Query");
                });

            modelBuilder.Entity("SchoolRecord.Models.schoolAdminssion", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fatherName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sClass")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("school_Classid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("school_Classid");

                    b.ToTable("schoolAdminssion");
                });

            modelBuilder.Entity("SchoolRecord.Models.schoolClass", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Fees")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("schoolTeacherID")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("schoolTeacherID");

                    b.ToTable("schoolClass");
                });

            modelBuilder.Entity("SchoolRecord.Models.schoolTeacher", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Experience")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("schoolTeacher");
                });

            modelBuilder.Entity("SchoolRecord.Models.schoolAdminssion", b =>
                {
                    b.HasOne("SchoolRecord.Models.schoolClass", "school_Class")
                        .WithMany()
                        .HasForeignKey("school_Classid");

                    b.Navigation("school_Class");
                });

            modelBuilder.Entity("SchoolRecord.Models.schoolClass", b =>
                {
                    b.HasOne("SchoolRecord.Models.schoolTeacher", "schoolTeacher")
                        .WithMany()
                        .HasForeignKey("schoolTeacherID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("schoolTeacher");
                });
#pragma warning restore 612, 618
        }
    }
}