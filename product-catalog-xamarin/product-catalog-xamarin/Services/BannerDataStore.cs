using System;
using System.Collections.Generic;
using System.Text;
using product_catalog_xamarin.Models;

namespace product_catalog_xamarin.Services
{
    public class BannerDataStore
    {
        private static readonly Lazy<BannerDataStore> instance = new Lazy<BannerDataStore>(() => new BannerDataStore());

        public static BannerDataStore Instance => instance.Value;

        public List<Banner> Banners { get; private set; }

        private BannerDataStore()
        {
            Banners = new List<Banner> {
                new Banner { Name = "The Last of Us Part II", Image = "slider_1.png", Price = "S/. 150" },
                new Banner { Name = "God Of War", Image = "slider_2.png", Price = "S/. 150" },
                new Banner { Name = "Forza Horizon", Image = "slider_3.png", Price = "S/. 150" }
            };
        }

        public void AddBanner(Banner banner)
        {
            Banners.Add(banner);
        }

        public List<Banner> GetAllBanners()
        {
            return Banners;
        }
    }
}
