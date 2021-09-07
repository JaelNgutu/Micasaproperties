﻿// <auto-generated />
using MicasaProperties.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MicasaProperties.Migrations
{
    [DbContext(typeof(MicasaContext))]
    [Migration("20210821161819_initialTenants")]
    partial class initialTenants
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MicasaProperties.Models.Building", b =>
                {
                    b.Property<int>("buildingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("buildingName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("costPerUnit")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("unitsAvailable")
                        .HasColumnType("int");

                    b.HasKey("buildingID");

                    b.ToTable("Buildings");
                });

            modelBuilder.Entity("MicasaProperties.Models.Tenant", b =>
                {
                    b.Property<int>("tenantID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Occupying")
                        .HasColumnType("bit");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("tenantID");

                    b.ToTable("Tenants");
                });
#pragma warning restore 612, 618
        }
    }
}