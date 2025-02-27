﻿// <auto-generated />
using Mainproject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Mainproject.Migrations
{
    [DbContext(typeof(MainprojectContext))]
    [Migration("20250217060449_pat")]
    partial class pat
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Mainproject.Models.Doctor", b =>
                {
                    b.Property<int>("Doctor_Id")
                        .HasColumnType("int");

                    b.Property<string>("Doctor_Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Doctor_Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Doctor_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Doctor_Id");

                    b.ToTable("Doctor");
                });

            modelBuilder.Entity("Mainproject.Models.Patient", b =>
                {
                    b.Property<int>("Patient_Id")
                        .HasColumnType("int");

                    b.Property<string>("Patient_Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Patient_Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Patient_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Patient_Id");

                    b.ToTable("Patient");
                });
#pragma warning restore 612, 618
        }
    }
}
