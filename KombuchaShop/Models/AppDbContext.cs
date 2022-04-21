using KombuchaShop.Models.Pocos;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace KombuchaShop.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Kombucha> Kombuchas { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(new Category() { CategoryId = 1, CategoryName = "Cool" });
            modelBuilder.Entity<Category>().HasData(new Category() { CategoryId = 2, CategoryName = "Nice" });
            modelBuilder.Entity<Category>().HasData(new Category() { CategoryId = 3, CategoryName = "Fresh" });

            modelBuilder.Entity<Kombucha>().HasData(new
                List<Kombucha>()
        {
            new Kombucha()
        {
            KombuchaId = 1,
                CategoryId = 1,
                Name = "Health-Ade Organic Kombucha",
                Description = "Clarke loves Health-Ade kombucha, which comes in sixteen different organic flavors. The Ginger-Lemon flavor, which is made with a mix of black and green teas, plus fresh ginger and lemon juice, is a particularly popular pick.",
                NutritiveInformation = "Per 8-ounce serving: 35 calories, 0 g fat, 10 mg sodium, 7 g carbs, 5 g sugar, 0 g protein",
                ImageUrl = "https://github.com/RicardoBritoBrens/KombuchaShop/blob/master/KombuchaShop/Resources/Images/Normal/image1.png",
                ImageThumbnailUrl = "https://github.com/RicardoBritoBrens/KombuchaShop/blob/master/KombuchaShop/Resources/Images/Thumbnail/image1.png",
                IsKombuchaOfTheWeek = true,
                Price = 350M
            },
            new Kombucha()
        {
            KombuchaId = 2,
                CategoryId = 1,
                Name = "Brew Dr. Organic Kombucha",
                Description = "Brew Dr. is another of Clarke’s favorite kombucha brands. Try the Uplift Caffeinated flavor, which is made with a blend of yerba mate, green tea, and guayusa. With 130 milligrams of caffeine per bottle, it makes for the perfect a.m. pick-me-up.",
                NutritiveInformation = "Per 7-ounce serving: 35 calories, 0 g fat, 0 mg sodium, 9 g carbs, 8 g sugars, 0 g protein",
                ImageUrl = "https://github.com/RicardoBritoBrens/KombuchaShop/blob/master/KombuchaShop/Resources/Images/Normal/image2.png",
                ImageThumbnailUrl = "https://github.com/RicardoBritoBrens/KombuchaShop/blob/master/KombuchaShop/Resources/Images/Thumbnail/image2.png",
                IsKombuchaOfTheWeek = true,
                Price = 375M
            },
            new Kombucha()
        {
            KombuchaId = 3,
                CategoryId = 1,
                Name = "GTs Enlightened Organic Raw Kombucha",
                Description = "This OG kombucha brand (it's been around for 20 years!) is another of Clarke’s top picks. GT's offers dozens of flavors, but the Multi-Green, which is made with a blend of blue-green algae, spirulina, and chlorella, is a long-time favorite. Take that, green smoothies.",
                NutritiveInformation = "Per 8-ounce serving: 30 calories, 0 g fat, 5 mg sodium, 8 g carbs, 8 g sugar, 2 g protein",
                ImageUrl = "https://github.com/RicardoBritoBrens/KombuchaShop/blob/master/KombuchaShop/Resources/Images/Normal/image3.png",
                ImageThumbnailUrl = "https://github.com/RicardoBritoBrens/KombuchaShop/blob/master/KombuchaShop/Resources/Images/Thumbnail/image3.png",
                IsKombuchaOfTheWeek = true,
                Price = 385M
            },
            new Kombucha()
        {
            KombuchaId = 4,
                CategoryId = 2,
                Name = "Wild Kombucha",
                Description = "Kombucha for happy hour? Sure! Wild Kombucha comes in beer-like bottles, and all kinds of fun flavors. Though still a pretty regional name (they’re based in Maryland), the brand is quickly growing. The Upbeet flavor pairs earthy grapefruit with bright apple, ginger, and lime.",
                NutritiveInformation = "Per 8-ounce serving: 25 calories, 0 g fat, 0 mg sodium, 6 g carbs, 4 g sugar, 0 g protein",
                ImageUrl = "https://github.com/RicardoBritoBrens/KombuchaShop/blob/master/KombuchaShop/Resources/Images/Normal/image4.png",
                ImageThumbnailUrl = "https://github.com/RicardoBritoBrens/KombuchaShop/blob/master/KombuchaShop/Resources/Images/Thumbnail/image4.png",
                IsKombuchaOfTheWeek = true,
                Price = 400M
            },
            new Kombucha()
        {
            KombuchaId = 5,
                CategoryId = 2,
                Name = "Rowdy Mermaid Kombucha",
                Description = "More and more kombucha brands are beginning to offer canned options for easier recycling and lighter transportation, Clarke says. Rowdy Mermaid’s canned kombucha varieties are brewed with functional ingredients for extra benefits. Their Lion's Root flavor contains lion's mane mushroom to support brain function, along with pineapple for flavor. ",
                NutritiveInformation = "Per 12-ounce serving: 45 calories, 0 g fat, 0 mg sodium, 9 g carbs, 9 g sugar, 0 g protein",
                ImageUrl = "https://github.com/RicardoBritoBrens/KombuchaShop/blob/master/KombuchaShop/Resources/Images/Normal/image5.png",
                ImageThumbnailUrl = "https://github.com/RicardoBritoBrens/KombuchaShop/blob/master/KombuchaShop/Resources/Images/Thumbnail/image5.png",
                IsKombuchaOfTheWeek = true,
                Price = 395M
            },
            new Kombucha()
        {
            KombuchaId = 6,
                CategoryId = 2,
                Name = "Forage Kombucha",
                Description = "Another tasty canned option, Forage kombucha comes in gorgeous, flower-printed cans that you’ll definitely want to drink in public. Try the Peach Kombucha (one of Forage's four flavors) for summer vibes all year long.",
                NutritiveInformation = "Per 12-ounce serving: 65 calories, 0 g fat, 6 mg sodium, 11 g carbs, 10 g sugar, 0 g protein",
                ImageUrl = "https://github.com/RicardoBritoBrens/KombuchaShop/blob/master/KombuchaShop/Resources/Images/Normal/image6.png",
                ImageThumbnailUrl = "https://github.com/RicardoBritoBrens/KombuchaShop/blob/master/KombuchaShop/Resources/Images/Thumbnail/image6.png",
                IsKombuchaOfTheWeek = true,
                Price = 395M
            },
            new Kombucha()
        {
            KombuchaId = 7,
                CategoryId = 2,
                Name = "Humm Kombucha",
                Description = "Humm kombucha is always launching new flavors, and the lower-sugar Ginger Juniper is a great option. With just five grams of the sweet stuff per serving, it offers plenty of flavor from herbal juniper and spicy ginger.",
                NutritiveInformation = "Per 8-ounce serving: 22 calories, 0 g fat, 0 mg sodium, 6 g carbs, 5 g sugar, 0 g protein",
                ImageUrl = "https://github.com/RicardoBritoBrens/KombuchaShop/blob/master/KombuchaShop/Resources/Images/Normal/image7.png",
                ImageThumbnailUrl = "https://github.com/RicardoBritoBrens/KombuchaShop/blob/master/KombuchaShop/Resources/Images/Thumbnail/image7.png",
                IsKombuchaOfTheWeek = false,
                Price = 485M
            },
            new Kombucha()
        {
            KombuchaId = 8,
                CategoryId = 3,
                Name = "Kosmic Kombucha",
                Description = "Made from a mix of oolong and green teas, Kosmic Kombucha's fun kombucha flavors run the gamut from Kiwi-Pineapple-Coconut to Cherry-Maple-Chocolate. The Sway Home Brew, flavored with an Asian-inspired mix of lemongrass, lime, and coconut water, is truly unique.",
                NutritiveInformation = "Per 9-ounce serving: 50 calories, 0 g fat, 15 mg sodium, 9 g carbs, 7 g sugars, 3 g protein",
                ImageUrl = "https://github.com/RicardoBritoBrens/KombuchaShop/blob/master/KombuchaShop/Resources/Images/Normal/image8.png",
                ImageThumbnailUrl = "https://github.com/RicardoBritoBrens/KombuchaShop/blob/master/KombuchaShop/Resources/Images/Thumbnail/image8.png",
                IsKombuchaOfTheWeek = false,
                Price = 450M
            },
            new Kombucha()
        {
            KombuchaId = 9,
                CategoryId = 3,
                Name = "Holy Kombucha",
                Description = "In addition to their beautiful packaging, Holy Kombucha is known for their fun, fruity flavors. The bright Blood Orange, in particular, is low in sugar but packed with citrus flavor.",
                NutritiveInformation = "Per 8-ounce serving: 20 calories, 0 g fat, 0 mg sodium, 5 g carbs, 5 g sugar, 0 g protein",
                ImageUrl = "https://github.com/RicardoBritoBrens/KombuchaShop/blob/master/KombuchaShop/Resources/Images/Normal/image9.png",
                ImageThumbnailUrl = "https://github.com/RicardoBritoBrens/KombuchaShop/blob/master/KombuchaShop/Resources/Images/Thumbnail/image9.png",
                IsKombuchaOfTheWeek = false,
                Price = 475M
            },
            new Kombucha()
        {
            KombuchaId = 10,
                CategoryId = 3,
                Name = "Trader Joe's Organic Kombucha",
                Description = "Trader Joe’s organic kombuchas almost seem too good to be true with less sugar than any other brand on this list. An entire 16-ounce bottle of the Mango flavor contains just five grams of sugar.",
                NutritiveInformation = "Per 16-ounce serving: 70 calories, 0 g fat, 0 mg sodium, 18 g carbs, 5 g sugar, 0 g protein",
                ImageUrl = "https://github.com/RicardoBritoBrens/KombuchaShop/blob/master/KombuchaShop/Resources/Images/Normal/image10.png",
                ImageThumbnailUrl = "https://github.com/RicardoBritoBrens/KombuchaShop/blob/master/KombuchaShop/Resources/Images/Thumbnail/image10.png",
                IsKombuchaOfTheWeek = false,
                Price = 475M
            }
    });
        }
    }
}