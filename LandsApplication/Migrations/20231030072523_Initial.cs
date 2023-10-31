using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LandsApplication.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AgreementLeases",
                columns: table => new
                {
                    LeaseNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PropertyDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Situate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lessor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lessee = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Municipality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ministry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertySize = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RentAmount = table.Column<double>(type: "float", nullable: false),
                    RentRevaluatuionPeriod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RentalPurpose = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgreementLeases", x => x.LeaseNumber);
                });

            migrationBuilder.CreateTable(
                name: "Application",
                columns: table => new
                {
                    ApplicationNo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Forenames = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SpouseName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PostalAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhysicalAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    Occupation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ECNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Salary = table.Column<double>(type: "float", nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CountryOfResidence = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StandAppliedFor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PurposeOfStand = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TypeOfBusiness = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RailSiding = table.Column<bool>(type: "bit", nullable: false),
                    OtherStandsOwned = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Insolvantion = table.Column<bool>(type: "bit", nullable: false),
                    FinanceSource = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Application", x => x.ApplicationNo);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseOptions",
                columns: table => new
                {
                    RegistrationNo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Township = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lessor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lessee = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnnexedPeriod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RentAmount = table.Column<double>(type: "float", nullable: false),
                    DateofRent = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SubsequentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BuildingClause = table.Column<double>(type: "float", nullable: false),
                    PurchasePrice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOptions", x => x.RegistrationNo);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AgreementLeases");

            migrationBuilder.DropTable(
                name: "Application");

            migrationBuilder.DropTable(
                name: "PurchaseOptions");
        }
    }
}
