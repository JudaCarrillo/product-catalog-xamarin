using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using product_catalog_xamarin.Models;
using product_catalog_xamarin.Services;
using product_catalog_xamarin.Views;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace product_catalog_xamarin
{
    public partial class MainPage : ContentPage
    {
        bool isNavigating;
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            LoadData();
        }

        public void LoadData()
        {
            List<Product> allProducts = ProductDataStore.Instance.GetAllProducts();
            listViewProduct.ItemsSource = allProducts;

            List<Banner> allBanners = BannerDataStore.Instance.GetAllBanners();
            sliderCollectionBanners.ItemsSource = allBanners;
        }

        private async void BtnWhatsapp_Clicked(object sender, EventArgs e)
        {
            string whatsappUrl = "http://wa.me/+56950615332";
            await Launcher.OpenAsync(new Uri(whatsappUrl));
        }

        private async void BtnDiscord_Clicked(object sender, EventArgs e)
        {
            string discordUrl = "https://discord.gg/8xeF63tC";
            await Launcher.OpenAsync(new Uri(discordUrl));
        }

        private async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (isNavigating)
                return;

            isNavigating = true;

            Product selectedItem = e.CurrentSelection.FirstOrDefault() as Product;

            if (selectedItem != null)
            {
                ((CollectionView)sender).SelectedItem = null;
                await Navigation.PushAsync(new ProductDetailPage(selectedItem), false);
            }

            isNavigating = false;
        }
    }
}
