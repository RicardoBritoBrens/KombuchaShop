using Microsoft.EntityFrameworkCore.Migrations;

namespace KombuchaShop.Migrations
{
    public partial class AddSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 1, "Cool" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 2, "Nice" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 3, "Fresh" });

            migrationBuilder.InsertData(
                table: "Kombuchas",
                columns: new[] { "KombuchaId", "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "Name", "NutritiveInformation", "Price" },
                values: new object[,]
                {
                    { 1, 1, "Clarke loves Health-Ade kombucha, which comes in sixteen different organic flavors. The Ginger-Lemon flavor, which is made with a mix of black and green teas, plus fresh ginger and lemon juice, is a particularly popular pick.", "https://github.com/RicardoBritoBrens/KombuchaShop/blob/master/KombuchaShop/Resources/Images/Thumbnail/image1.png", "https://github.com/RicardoBritoBrens/KombuchaShop/blob/master/KombuchaShop/Resources/Images/Normal/image1.png", "Health-Ade Organic Kombucha", "Per 8-ounce serving: 35 calories, 0 g fat, 10 mg sodium, 7 g carbs, 5 g sugar, 0 g protein", 350m },
                    { 2, 1, "Brew Dr. is another of Clarke’s favorite kombucha brands. Try the Uplift Caffeinated flavor, which is made with a blend of yerba mate, green tea, and guayusa. With 130 milligrams of caffeine per bottle, it makes for the perfect a.m. pick-me-up.", "https://github.com/RicardoBritoBrens/KombuchaShop/blob/master/KombuchaShop/Resources/Images/Thumbnail/image2.png", "https://github.com/RicardoBritoBrens/KombuchaShop/blob/master/KombuchaShop/Resources/Images/Normal/image2.png", "Brew Dr. Organic Kombucha", "Per 7-ounce serving: 35 calories, 0 g fat, 0 mg sodium, 9 g carbs, 8 g sugars, 0 g protein", 375m },
                    { 3, 1, "This OG kombucha brand (it's been around for 20 years!) is another of Clarke’s top picks. GT's offers dozens of flavors, but the Multi-Green, which is made with a blend of blue-green algae, spirulina, and chlorella, is a long-time favorite. Take that, green smoothies.", "https://github.com/RicardoBritoBrens/KombuchaShop/blob/master/KombuchaShop/Resources/Images/Thumbnail/image3.png", "https://github.com/RicardoBritoBrens/KombuchaShop/blob/master/KombuchaShop/Resources/Images/Normal/image3.png", "GTs Enlightened Organic Raw Kombucha", "Per 8-ounce serving: 30 calories, 0 g fat, 5 mg sodium, 8 g carbs, 8 g sugar, 2 g protein", 385m },
                    { 4, 2, "Kombucha for happy hour? Sure! Wild Kombucha comes in beer-like bottles, and all kinds of fun flavors. Though still a pretty regional name (they’re based in Maryland), the brand is quickly growing. The Upbeet flavor pairs earthy grapefruit with bright apple, ginger, and lime.", "https://github.com/RicardoBritoBrens/KombuchaShop/blob/master/KombuchaShop/Resources/Images/Thumbnail/image4.png", "https://github.com/RicardoBritoBrens/KombuchaShop/blob/master/KombuchaShop/Resources/Images/Normal/image4.png", "Wild Kombucha", "Per 8-ounce serving: 25 calories, 0 g fat, 0 mg sodium, 6 g carbs, 4 g sugar, 0 g protein", 400m },
                    { 5, 2, "More and more kombucha brands are beginning to offer canned options for easier recycling and lighter transportation, Clarke says. Rowdy Mermaid’s canned kombucha varieties are brewed with functional ingredients for extra benefits. Their Lion's Root flavor contains lion's mane mushroom to support brain function, along with pineapple for flavor. ", "https://github.com/RicardoBritoBrens/KombuchaShop/blob/master/KombuchaShop/Resources/Images/Thumbnail/image5.png", "https://github.com/RicardoBritoBrens/KombuchaShop/blob/master/KombuchaShop/Resources/Images/Normal/image5.png", "Rowdy Mermaid Kombucha", "Per 12-ounce serving: 45 calories, 0 g fat, 0 mg sodium, 9 g carbs, 9 g sugar, 0 g protein", 395m },
                    { 6, 2, "Another tasty canned option, Forage kombucha comes in gorgeous, flower-printed cans that you’ll definitely want to drink in public. Try the Peach Kombucha (one of Forage's four flavors) for summer vibes all year long.", "https://github.com/RicardoBritoBrens/KombuchaShop/blob/master/KombuchaShop/Resources/Images/Thumbnail/image6.png", "https://github.com/RicardoBritoBrens/KombuchaShop/blob/master/KombuchaShop/Resources/Images/Normal/image6.png", "Forage Kombucha", "Per 12-ounce serving: 65 calories, 0 g fat, 6 mg sodium, 11 g carbs, 10 g sugar, 0 g protein", 395m },
                    { 7, 2, "Humm kombucha is always launching new flavors, and the lower-sugar Ginger Juniper is a great option. With just five grams of the sweet stuff per serving, it offers plenty of flavor from herbal juniper and spicy ginger.", "https://github.com/RicardoBritoBrens/KombuchaShop/blob/master/KombuchaShop/Resources/Images/Thumbnail/image7.png", "https://github.com/RicardoBritoBrens/KombuchaShop/blob/master/KombuchaShop/Resources/Images/Normal/image7.png", "Humm Kombucha", "Per 8-ounce serving: 22 calories, 0 g fat, 0 mg sodium, 6 g carbs, 5 g sugar, 0 g protein", 485m },
                    { 8, 3, "Made from a mix of oolong and green teas, Kosmic Kombucha's fun kombucha flavors run the gamut from Kiwi-Pineapple-Coconut to Cherry-Maple-Chocolate. The Sway Home Brew, flavored with an Asian-inspired mix of lemongrass, lime, and coconut water, is truly unique.", "https://github.com/RicardoBritoBrens/KombuchaShop/blob/master/KombuchaShop/Resources/Images/Thumbnail/image8.png", "https://github.com/RicardoBritoBrens/KombuchaShop/blob/master/KombuchaShop/Resources/Images/Normal/image8.png", "Kosmic Kombucha", "Per 9-ounce serving: 50 calories, 0 g fat, 15 mg sodium, 9 g carbs, 7 g sugars, 3 g protein", 450m },
                    { 9, 3, "In addition to their beautiful packaging, Holy Kombucha is known for their fun, fruity flavors. The bright Blood Orange, in particular, is low in sugar but packed with citrus flavor.", "https://github.com/RicardoBritoBrens/KombuchaShop/blob/master/KombuchaShop/Resources/Images/Thumbnail/image9.png", "https://github.com/RicardoBritoBrens/KombuchaShop/blob/master/KombuchaShop/Resources/Images/Normal/image9.png", "Holy Kombucha", "Per 8-ounce serving: 20 calories, 0 g fat, 0 mg sodium, 5 g carbs, 5 g sugar, 0 g protein", 475m },
                    { 10, 3, "Trader Joe’s organic kombuchas almost seem too good to be true with less sugar than any other brand on this list. An entire 16-ounce bottle of the Mango flavor contains just five grams of sugar.", "https://github.com/RicardoBritoBrens/KombuchaShop/blob/master/KombuchaShop/Resources/Images/Thumbnail/image10.png", "https://github.com/RicardoBritoBrens/KombuchaShop/blob/master/KombuchaShop/Resources/Images/Normal/image10.png", "Trader Joe's Organic Kombucha", "Per 16-ounce serving: 70 calories, 0 g fat, 0 mg sodium, 18 g carbs, 5 g sugar, 0 g protein", 475m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Kombuchas",
                keyColumn: "KombuchaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Kombuchas",
                keyColumn: "KombuchaId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Kombuchas",
                keyColumn: "KombuchaId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Kombuchas",
                keyColumn: "KombuchaId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Kombuchas",
                keyColumn: "KombuchaId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Kombuchas",
                keyColumn: "KombuchaId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Kombuchas",
                keyColumn: "KombuchaId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Kombuchas",
                keyColumn: "KombuchaId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Kombuchas",
                keyColumn: "KombuchaId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Kombuchas",
                keyColumn: "KombuchaId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);
        }
    }
}
