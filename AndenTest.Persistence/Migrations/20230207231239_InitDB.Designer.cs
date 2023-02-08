﻿// <auto-generated />
using System;
using AndenTest.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AndenTest.Persistence.Migrations
{
    [DbContext(typeof(AndenDBContext))]
    [Migration("20230207231239_InitDB")]
    partial class InitDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AndenTest.Common.Entity.Form", b =>
                {
                    b.Property<int>("FormID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FormID"));

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FormType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FormID");

                    b.ToTable("Forms", (string)null);

                    b.HasDiscriminator<string>("FormType").HasValue("Form");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("AndenTest.Common.Entity.FormA", b =>
                {
                    b.HasBaseType("AndenTest.Common.Entity.Form");

                    b.Property<int>("AmountA")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("A");
                });

            modelBuilder.Entity("AndenTest.Common.Entity.FormB", b =>
                {
                    b.HasBaseType("AndenTest.Common.Entity.Form");

                    b.Property<int>("AmountB1")
                        .HasColumnType("int");

                    b.Property<int>("AmountB2")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("B");
                });
#pragma warning restore 612, 618
        }
    }
}
