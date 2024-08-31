using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using product_catalog_xamarin.Models;
using product_catalog_xamarin.Services;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace product_catalog_xamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductDetailPage : ContentPage
    {
        public ProductDetailPage(Product selectedProduct)
        {
            InitializeComponent();
            ProductDetails productDetails = ProductDetailsDataStore.Instance.GetProductDetails(selectedProduct.Name);
            BindingContext = productDetails;
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

        private async void BtnHome_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}