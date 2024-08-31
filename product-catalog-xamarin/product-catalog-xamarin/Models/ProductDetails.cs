using System;
using System.Collections.Generic;
using System.Text;

namespace product_catalog_xamarin.Models
{
    public class ProductDetails
    {
        public string Name { get; set; }
        public List<string> Images { get; set; }
        public string Price { get; set; }
        public List<Platform> Platforms { get; set; }
        public enum Platform
        {
            Steam,
            PlayStation,
            Xbox,
            Nintendo,
            PC,
        }
        public string Company { get; set; }
        public string ReleaseDate { get; set; }

        public List<Gender> Genders { get; set; }
        public enum Gender
        {
            Action,
            Adventure,
            RPG,
            Strategy,
            Simulation,
            Sports,
        }
    }
}
