﻿// <auto-generated />
using KombuchaShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KombuchaShop.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220406022732_IsKombuchaOfTheWeek")]
    partial class IsKombuchaOfTheWeek
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KombuchaShop.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Cool"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Nice"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Fresh"
                        });
                });

            modelBuilder.Entity("KombuchaShop.Models.Kombucha", b =>
                {
                    b.Property<int>("KombuchaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsKombuchaOfTheWeek")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NutritiveInformation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("KombuchaId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Kombuchas");

                    b.HasData(
                        new
                        {
                            KombuchaId = 1,
                            CategoryId = 1,
                            Description = "Clarke loves Health-Ade kombucha, which comes in sixteen different organic flavors. The Ginger-Lemon flavor, which is made with a mix of black and green teas, plus fresh ginger and lemon juice, is a particularly popular pick.",
                            ImageThumbnailUrl = "https://github.com/RicardoBritoBrens/KombuchaShop/blob/master/KombuchaShop/Resources/Images/Thumbnail/image1.png",
                            ImageUrl = "https://github.com/RicardoBritoBrens/KombuchaShop/blob/master/KombuchaShop/Resources/Images/Normal/image1.png",
                            IsKombuchaOfTheWeek = true,
                            Name = "Health-Ade Organic Kombucha",
                            NutritiveInformation = "Per 8-ounce serving: 35 calories, 0 g fat, 10 mg sodium, 7 g carbs, 5 g sugar, 0 g protein",
                            Price = 350m
                        },
                        new
                        {
                            KombuchaId = 2,
                            CategoryId = 1,
                            Description = "Brew Dr. is another of Clarke’s favorite kombucha brands. Try the Uplift Caffeinated flavor, which is made with a blend of yerba mate, green tea, and guayusa. With 130 milligrams of caffeine per bottle, it makes for the perfect a.m. pick-me-up.",
                            ImageThumbnailUrl = "https://github.com/RicardoBritoBrens/KombuchaShop/blob/master/KombuchaShop/Resources/Images/Thumbnail/image2.png",
                            ImageUrl = "https://github.com/RicardoBritoBrens/KombuchaShop/blob/master/KombuchaShop/Resources/Images/Normal/image2.png",
                            IsKombuchaOfTheWeek = true,
                            Name = "Brew Dr. Organic Kombucha",
                            NutritiveInformation = "Per 7-ounce serving: 35 calories, 0 g fat, 0 mg sodium, 9 g carbs, 8 g sugars, 0 g protein",
                            Price = 375m
                        },
                        new
                        {
                            KombuchaId = 3,
                            CategoryId = 1,
                            Description = "This OG kombucha brand (it's been around for 20 years!) is another of Clarke’s top picks. GT's offers dozens of flavors, but the Multi-Green, which is made with a blend of blue-green algae, spirulina, and chlorella, is a long-time favorite. Take that, green smoothies.",
                            ImageThumbnailUrl = "https://github.com/RicardoBritoBrens/KombuchaShop/blob/master/KombuchaShop/Resources/Images/Thumbnail/image3.png",
                            ImageUrl = "https://github.com/RicardoBritoBrens/KombuchaShop/blob/master/KombuchaShop/Resources/Images/Normal/image3.png",
                            IsKombuchaOfTheWeek = true,
                            Name = "GTs Enlightened Organic Raw Kombucha",
                            NutritiveInformation = "Per 8-ounce serving: 30 calories, 0 g fat, 5 mg sodium, 8 g carbs, 8 g sugar, 2 g protein",
                            Price = 385m
                        },
                        new
                        {
                            KombuchaId = 4,
                            CategoryId = 2,
                            Description = "Kombucha for happy hour? Sure! Wild Kombucha comes in beer-like bottles, and all kinds of fun flavors. Though still a pretty regional name (they’re based in Maryland), the brand is quickly growing. The Upbeet flavor pairs earthy grapefruit with bright apple, ginger, and lime.",
                            ImageThumbnailUrl = "https://github.com/RicardoBritoBrens/KombuchaShop/blob/master/KombuchaShop/Resources/Images/Thumbnail/image4.png",
                            ImageUrl = "https://github.com/RicardoBritoBrens/KombuchaShop/blob/master/KombuchaShop/Resources/Images/Normal/image4.png",
                            IsKombuchaOfTheWeek = true,
                            Name = "Wild Kombucha",
                            NutritiveInformation = "Per 8-ounce serving: 25 calories, 0 g fat, 0 mg sodium, 6 g carbs, 4 g sugar, 0 g protein",
                            Price = 400m
                        },
                        new
                        {
                            KombuchaId = 5,
                            CategoryId = 2,
                            Description = "More and more kombucha brands are beginning to offer canned options for easier recycling and lighter transportation, Clarke says. Rowdy Mermaid’s canned kombucha varieties are brewed with functional ingredients for extra benefits. Their Lion's Root flavor contains lion's mane mushroom to support brain function, along with pineapple for flavor. ",
                            ImageThumbnailUrl = "https://github.com/RicardoBritoBrens/KombuchaShop/blob/master/KombuchaShop/Resources/Images/Thumbnail/image5.png",
                            ImageUrl = "https://github.com/RicardoBritoBrens/KombuchaShop/blob/master/KombuchaShop/Resources/Images/Normal/image5.png",
                            IsKombuchaOfTheWeek = true,
                            Name = "Rowdy Mermaid Kombucha",
                            NutritiveInformation = "Per 12-ounce serving: 45 calories, 0 g fat, 0 mg sodium, 9 g carbs, 9 g sugar, 0 g protein",
                            Price = 395m
                        },
                        new
                        {
                            KombuchaId = 6,
                            CategoryId = 2,
                            Description = "Another tasty canned option, Forage kombucha comes in gorgeous, flower-printed cans that you’ll definitely want to drink in public. Try the Peach Kombucha (one of Forage's four flavors) for summer vibes all year long.",
                            ImageThumbnailUrl = "https://github.com/RicardoBritoBrens/KombuchaShop/blob/master/KombuchaShop/Resources/Images/Thumbnail/image6.png",
                            ImageUrl = "https://github.com/RicardoBritoBrens/KombuchaShop/blob/master/KombuchaShop/Resources/Images/Normal/image6.png",
                            IsKombuchaOfTheWeek = true,
                            Name = "Forage Kombucha",
                            NutritiveInformation = "Per 12-ounce serving: 65 calories, 0 g fat, 6 mg sodium, 11 g carbs, 10 g sugar, 0 g protein",
                            Price = 395m
                        },
                        new
                        {
                            KombuchaId = 7,
                            CategoryId = 2,
                            Description = "Humm kombucha is always launching new flavors, and the lower-sugar Ginger Juniper is a great option. With just five grams of the sweet stuff per serving, it offers plenty of flavor from herbal juniper and spicy ginger.",
                            ImageThumbnailUrl = "https://github.com/RicardoBritoBrens/KombuchaShop/blob/master/KombuchaShop/Resources/Images/Thumbnail/image7.png",
                            ImageUrl = "https://github.com/RicardoBritoBrens/KombuchaShop/blob/master/KombuchaShop/Resources/Images/Normal/image7.png",
                            IsKombuchaOfTheWeek = false,
                            Name = "Humm Kombucha",
                            NutritiveInformation = "Per 8-ounce serving: 22 calories, 0 g fat, 0 mg sodium, 6 g carbs, 5 g sugar, 0 g protein",
                            Price = 485m
                        },
                        new
                        {
                            KombuchaId = 8,
                            CategoryId = 3,
                            Description = "Made from a mix of oolong and green teas, Kosmic Kombucha's fun kombucha flavors run the gamut from Kiwi-Pineapple-Coconut to Cherry-Maple-Chocolate. The Sway Home Brew, flavored with an Asian-inspired mix of lemongrass, lime, and coconut water, is truly unique.",
                            ImageThumbnailUrl = "https://github.com/RicardoBritoBrens/KombuchaShop/blob/master/KombuchaShop/Resources/Images/Thumbnail/image8.png",
                            ImageUrl = "https://github.com/RicardoBritoBrens/KombuchaShop/blob/master/KombuchaShop/Resources/Images/Normal/image8.png",
                            IsKombuchaOfTheWeek = false,
                            Name = "Kosmic Kombucha",
                            NutritiveInformation = "Per 9-ounce serving: 50 calories, 0 g fat, 15 mg sodium, 9 g carbs, 7 g sugars, 3 g protein",
                            Price = 450m
                        },
                        new
                        {
                            KombuchaId = 9,
                            CategoryId = 3,
                            Description = "In addition to their beautiful packaging, Holy Kombucha is known for their fun, fruity flavors. The bright Blood Orange, in particular, is low in sugar but packed with citrus flavor.",
                            ImageThumbnailUrl = "https://github.com/RicardoBritoBrens/KombuchaShop/blob/master/KombuchaShop/Resources/Images/Thumbnail/image9.png",
                            ImageUrl = "https://github.com/RicardoBritoBrens/KombuchaShop/blob/master/KombuchaShop/Resources/Images/Normal/image9.png",
                            IsKombuchaOfTheWeek = false,
                            Name = "Holy Kombucha",
                            NutritiveInformation = "Per 8-ounce serving: 20 calories, 0 g fat, 0 mg sodium, 5 g carbs, 5 g sugar, 0 g protein",
                            Price = 475m
                        },
                        new
                        {
                            KombuchaId = 10,
                            CategoryId = 3,
                            Description = "Trader Joe’s organic kombuchas almost seem too good to be true with less sugar than any other brand on this list. An entire 16-ounce bottle of the Mango flavor contains just five grams of sugar.",
                            ImageThumbnailUrl = "https://github.com/RicardoBritoBrens/KombuchaShop/blob/master/KombuchaShop/Resources/Images/Thumbnail/image10.png",
                            ImageUrl = "https://github.com/RicardoBritoBrens/KombuchaShop/blob/master/KombuchaShop/Resources/Images/Normal/image10.png",
                            IsKombuchaOfTheWeek = false,
                            Name = "Trader Joe's Organic Kombucha",
                            NutritiveInformation = "Per 16-ounce serving: 70 calories, 0 g fat, 0 mg sodium, 18 g carbs, 5 g sugar, 0 g protein",
                            Price = 475m
                        });
                });

            modelBuilder.Entity("KombuchaShop.Models.Kombucha", b =>
                {
                    b.HasOne("KombuchaShop.Models.Category", "Category")
                        .WithMany("Kombuchas")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("KombuchaShop.Models.Category", b =>
                {
                    b.Navigation("Kombuchas");
                });
#pragma warning restore 612, 618
        }
    }
}
