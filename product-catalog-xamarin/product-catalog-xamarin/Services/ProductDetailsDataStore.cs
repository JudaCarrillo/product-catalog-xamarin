using System;
using System.Collections.Generic;
using System.Text;
using product_catalog_xamarin.Models;
using static product_catalog_xamarin.Models.ProductDetails;

namespace product_catalog_xamarin.Services
{
    public class ProductDetailsDataStore
    {
        private static readonly Lazy<ProductDetailsDataStore> instance = new Lazy<ProductDetailsDataStore>(() => new ProductDetailsDataStore());

        public static ProductDetailsDataStore Instance => instance.Value;

        public List<ProductDetails> ProductDetails { get; private set; }

        private ProductDetailsDataStore()
        {
            ProductDetails = new List<ProductDetails> {
                new ProductDetails
                {
                    Name = "LEFT 4 DEAD 2 (PC)",
                    Price = "S/. 5",
                    Company = "Valve Corporation",
                    ReleaseDate = "November 17, 2009",
                    Platforms = new List<Platform> { Platform.Steam, Platform.PC },
                    Genders = new List<Gender> { Gender.Action, Gender.Adventure },
                    Images = new List<string> { "left_fondo.png", "left1.png", "left2.png", "left3.png", "left4.png" }
                },

                new ProductDetails
                {
                    Name = "MINECRAFT J & B (PC)",
                    Price = "S/. 42",
                    Company = "Mojang Studios",
                    ReleaseDate = "November 18, 2011",
                    Platforms = new List<Platform> { Platform.PC, Platform.Steam },
                    Genders = new List<Gender> { Gender.Simulation, Gender.Adventure },
                    Images = new List<string> { "main_fondo.png", "main1.png", "main2.png", "main3.png", "main4.png" }
                },

                new ProductDetails
                {
                    Name = "FC 25 (PC)",
                    Price = "S/. 160",
                    Company = "EA Sports",
                    ReleaseDate = "September 29, 2023",
                    Platforms = new List<Platform> { Platform.PC, Platform.Steam },
                    Genders = new List<Gender> { Gender.Sports },
                    Images = new List < string > { "fc25_fondo.png", "fc25_1.png", "fc25_2.png", "fc25_3.png", "fc25_4.png" }
                },

                new ProductDetails
                {
                    Name = "FC 24 (PC)",
                    Price = "S/. 140",
                    Company = "EA Sports",
                    ReleaseDate = "September 30, 2022",
                    Platforms = new List<Platform> { Platform.PC, Platform.Steam },
                    Genders = new List<Gender> { Gender.Sports },
                    Images = new List < string > { "fc24_fondo.png", "fc24_1.png", "fc24_2.png", "fc24_3.png", "fc24_4.png" }
                },

                new ProductDetails
                {
                    Name = "DESTINY (PC)",
                    Price = "S/. 45",
                    Company = "Bungie",
                    ReleaseDate = "September 9, 2014",
                    Platforms = new List<Platform> { Platform.Steam, Platform.PC, Platform.PlayStation, Platform.Xbox },
                    Genders = new List<Gender> { Gender.Action, Gender.RPG },
                    Images = new List < string > { "destini_fondo.png", "destini1.png", "destini2.png", "destini3.png", "destini4.png" }
                },

                new ProductDetails
                {
                    Name = "CALL OF DUTY BACK OPS 6 (PC)",
                    Price = "S/. 250",
                    Company = "Activision",
                    ReleaseDate = "November 13, 2020",
                    Platforms = new List<Platform> { Platform.PC, Platform.Steam, Platform.PlayStation, Platform.Xbox },
                    Genders = new List<Gender> { Gender.Action, Gender.Adventure },
                    Images = new List<string> {"cod_fondo.png", "cod1.png", "cod2.png", "cod3.png", "cod4.png" }
                },

                new ProductDetails
                {
                    Name = "DIABLO IV (PC)",
                    Price = "S/. 100",
                    Company = "Blizzard Entertainment",
                    ReleaseDate = "June 6, 2023",
                    Platforms = new List<Platform> { Platform.PC, Platform.Steam },
                    Genders = new List<Gender> { Gender.RPG, Gender.Action },
                    Images = new List<string> { "diablo_fondo.png", "diablo1.png", "diablo2.png", "diablo3.png", "diablo4.png" }
                },

                new ProductDetails
                {
                    Name = "DEAD ISLAND (PC)",
                    Price = "S/. 145",
                    Company = "Deep Silver",
                    ReleaseDate = "September 6, 2011",
                    Platforms = new List<Platform> { Platform.PC, Platform.Steam, Platform.PlayStation, Platform.Xbox },
                    Genders = new List<Gender> { Gender.Action, Gender.Adventure },
                    Images = new List<string> {"dead_island_fondo.png", "dead_island1.png", "dead_island2.png", "dead_island3.png", "dead_island4.png" }
                },

                new ProductDetails
                {
                    Name = "IT TAKES TWO (PC)",
                    Price = "S/. 70",
                    Company = "Hazelight Studios",
                    ReleaseDate = "March 26, 2021",
                    Platforms = new List<Platform> { Platform.PC, Platform.Steam, Platform.PlayStation, Platform.Xbox },
                    Genders = new List<Gender> { Gender.Action, Gender.Adventure },
                    Images = new List<string> { "takes_two_fondo.png", "takes_two1.png", "takes_two2.png", "takes_two3.png", "takes_two4.png" }
                },

                new ProductDetails
                {
                    Name = "PROJECT ZOMBOID (PC)",
                    Price = "S/. 100",
                    Company = "The Indie Stone",
                    ReleaseDate = "November 8, 2013",
                    Platforms = new List<Platform> { Platform.PC, Platform.Steam },
                    Genders = new List<Gender> { Gender.Simulation, Gender.RPG },
                    Images = new List<string> { "zomboid_fondp.png", "zomboid1.png", "zomboid2.png", "zomboid3.png", "zomboid4.png" }
                },

                new ProductDetails
                {
                    Name = "THE LAST OF US PART II (PC)",
                    Price = "S/. 150",
                    Company = "Naughty Dog",
                    ReleaseDate = "June 19, 2020",
                    Platforms = new List<Platform> { Platform.PC, Platform.Steam },
                    Genders = new List<Gender> { Gender.Action, Gender.Adventure },
                    Images = new List<string> { "the_last_fondo.png", "the_last1.png", "the_last2.png", "the_last3.png", "the_last4.png" }
                },

                new ProductDetails
                {
                    Name = "SPECS ON THE LINE (PC)",
                    Price = "S/. 25",
                    Company = "Yager Development",
                    ReleaseDate = "June 26, 2012",
                    Platforms = new List<Platform> { Platform.PC, Platform.Steam, Platform.PlayStation, Platform.Xbox },
                    Genders = new List<Gender> { Gender.Action, Gender.Adventure },
                    Images = new List<string> { "the_line_fondo.png", "the_line1.png", "the_line2.png", "the_line3.png", "the_line4.png" }
                },

                new ProductDetails
                {
                    Name = "RED DEAD REDEMPTION II (PC)",
                    Price = "S/. 135",
                    Company = "Rockstar Games",
                    ReleaseDate = "October 26, 2018",
                    Platforms = new List<Platform> { Platform.PC, Platform.Steam, Platform.PlayStation, Platform.Xbox },
                    Genders = new List<Gender> { Gender.Action, Gender.Adventure },
                    Images= new List<string> { "rrd2_fondo.png", "rrd2_1.png", "rrd2_2.png", "rrd2_3.png", "rrd2_4.png" }
                },
            };
        }

        public void AddProductDetails(ProductDetails banner)
        {
            ProductDetails.Add(banner);
        }

        public ProductDetails GetProductDetails(string name)
        {
            return ProductDetails.Find(p => p.Name == name);
        }
    }
}
