﻿// <auto-generated />
using System;
using LandsApplication.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LandsApplication.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231030072523_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LandsApplication.Models.AgreementLease", b =>
                {
                    b.Property<string>("LeaseNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Lessee")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lessor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ministry")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Municipality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PropertyDetails")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PropertySize")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("RentAmount")
                        .HasColumnType("float");

                    b.Property<string>("RentRevaluatuionPeriod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RentalPurpose")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Situate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LeaseNumber");

                    b.ToTable("AgreementLeases");
                });

            modelBuilder.Entity("LandsApplication.Models.Application", b =>
                {
                    b.Property<string>("ApplicationNo")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CountryOfResidence")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ECNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FinanceSource")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Forenames")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("Insolvantion")
                        .HasColumnType("bit");

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Occupation")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("OtherStandsOwned")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.Property<string>("PhysicalAddress")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PostalAddress")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PurposeOfStand")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("RailSiding")
                        .HasColumnType("bit");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.Property<string>("SpouseName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("StandAppliedFor")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TypeOfBusiness")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ApplicationNo");

                    b.ToTable("Application");
                });

            modelBuilder.Entity("LandsApplication.Models.PurchaseOption", b =>
                {
                    b.Property<string>("RegistrationNo")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AnnexedPeriod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("BuildingClause")
                        .HasColumnType("float");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateofRent")
                        .HasColumnType("datetime2");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lessee")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lessor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PropertyDetails")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PurchasePrice")
                        .HasColumnType("float");

                    b.Property<double>("RentAmount")
                        .HasColumnType("float");

                    b.Property<DateTime>("SubsequentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Township")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RegistrationNo");

                    b.ToTable("PurchaseOptions");
                });
#pragma warning restore 612, 618
        }
    }
}