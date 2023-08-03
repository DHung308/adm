﻿// <auto-generated />
using Adm1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Adm1.Migrations
{
    [DbContext(typeof(Adm1Context))]
    [Migration("20230803071713_Create_Table_Cat")]
    partial class Create_Table_Cat
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.9");

            modelBuilder.Entity("Adm1.Models.Dongvat", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("TEXT");

                    b.Property<string>("ChungLoai")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("XuatXu")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Dongvat");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Dongvat");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Adm1.Models.Student", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("Adm1.Models.Cat", b =>
                {
                    b.HasBaseType("Adm1.Models.Dongvat");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasDiscriminator().HasValue("Cat");
                });
#pragma warning restore 612, 618
        }
    }
}
