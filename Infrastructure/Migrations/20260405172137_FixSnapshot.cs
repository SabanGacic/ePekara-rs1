using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixSnapshot : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Description", "Name", "PictureUrl", "Price", "QuantityInStock", "Type" },
                values: new object[,]
                {
                    { 1, "Country Kitchen", "Accusamus facilis quae rem modi voluptatibus omnis rem molestiae.", "Sausages", "images/products/1.png", 182.57m, 24, "Meat" },
                    { 2, "Farmhouse", "Non laborum suscipit consequuntur facilis animi. Autem quibusdam.", "Bacon", "images/products/2.png", 852.67m, 15, "Meat" },
                    { 3, "Country Kitchen", "Nemo est mollitia eos nam. Et aut quis fugit quo. Sunt quasi tempora.", "Beef Steak", "images/products/3.png", 320.00m, 10, "Meat" },
                    { 4, "Farmhouse", "Velit ut et sint animi voluptate. Aut rerum velit.", "Chicken Breast", "images/products/4.png", 150.49m, 30, "Poultry" },
                    { 5, "Ocean Fresh", "Et autem dolorem commodi. Mollitia amet qui nulla.", "Salmon Fillet", "images/products/5.png", 435.20m, 8, "Seafood" },
                    { 6, "Ocean Fresh", "Rerum eaque repellendus necessitatibus consectetur voluptatum.", "Tuna Steak", "images/products/6.png", 275.99m, 12, "Seafood" },
                    { 7, "Green Farm", "Assumenda sit aut sint dolore ut ut enim molestias.", "Broccoli", "images/products/7.png", 39.99m, 50, "Vegetable" },
                    { 8, "Green Farm", "Dicta qui ipsam dolorem ipsam perspiciatis distinctio.", "Tomatoes", "images/products/8.png", 25.99m, 60, "Vegetable" },
                    { 9, "Dairy Dream", "Ut sint corrupti eos voluptatem vel. Dolore pariatur consequuntur.", "Cheddar Cheese", "images/products/9.png", 199.99m, 20, "Dairy" },
                    { 10, "Dairy Dream", "Qui sed reiciendis non quis eligendi iste ipsum dolores.", "Whole Milk", "images/products/10.png", 55.00m, 40, "Dairy" }
                });
        }
    }
}
