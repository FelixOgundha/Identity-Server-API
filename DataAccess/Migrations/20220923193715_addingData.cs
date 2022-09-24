using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class addingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($"INSERT INTO CoffeeShops (Name,OpeningHours,Address) " +
                $"VALUES ('Felix Coffee', '9-5 Mon-Sat','Buffalo Street')");

            migrationBuilder.Sql($"INSERT INTO CoffeeShops (Name,OpeningHours,Address) " +
                $"VALUES ('Winnie Coffee', '9-5 Mon-Sat','Buffalo Street')"); 
            
            migrationBuilder.Sql($"INSERT INTO CoffeeShops (Name,OpeningHours,Address) " +
                $"VALUES ('Derrik Coffee', '9-5 Mon-Sat','Buffalo Street')"); 
            
            migrationBuilder.Sql($"INSERT INTO CoffeeShops (Name,OpeningHours,Address) " +
                $"VALUES ('Akinyi Coffee', '9-5 Mon-Sat','Buffalo Street')"); 
            
            migrationBuilder.Sql($"INSERT INTO CoffeeShops (Name,OpeningHours,Address) " +
                $"VALUES ('Lenny Coffee', '9-5 Mon-Sat','Buffalo Street')"); 
            
            migrationBuilder.Sql($"INSERT INTO CoffeeShops (Name,OpeningHours,Address) " +
                $"VALUES ('Max Coffee', '9-5 Mon-Sat','Buffalo Street')"); 
            
            migrationBuilder.Sql($"INSERT INTO CoffeeShops (Name,OpeningHours,Address) " +
                $"VALUES ('Owino Coffee', '9-5 Mon-Sat','Buffalo Street')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
