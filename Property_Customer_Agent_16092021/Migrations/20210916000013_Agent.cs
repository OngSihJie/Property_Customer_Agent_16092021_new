using Microsoft.EntityFrameworkCore.Migrations;

namespace Property_Customer_Agent_16092021.Migrations
{
    public partial class Agent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agent",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Agent_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Agent_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Agent_Mobile = table.Column<int>(type: "int", nullable: false),
                    Office_Location = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agent", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Cust_Username = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Cust_FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cust_LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cust_Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cust_Mobile = table.Column<int>(type: "int", nullable: false),
                    Cust_Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Cust_Username);
                });

            migrationBuilder.CreateTable(
                name: "Property",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Property_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Property_WeeklyRent = table.Column<int>(type: "int", nullable: false),
                    Property_Number_of_Bedrooms = table.Column<int>(type: "int", nullable: false),
                    Property_Number_of_Bathrooms = table.Column<int>(type: "int", nullable: false),
                    Property_Location = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Property", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agent");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Property");
        }
    }
}
