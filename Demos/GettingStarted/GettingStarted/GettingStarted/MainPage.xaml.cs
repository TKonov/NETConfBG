using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Net.Http;

namespace GettingStarted
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

           var images =  await GetImageListAsync();

            this.BindingContext = images;
        }

        async Task<ImageList> GetImageListAsync()
        {
            var requestUri = "https://docs.xamarin.com/demo/stock.json";
            using (var client = new HttpClient())
            {
                var result = await client.GetStringAsync(requestUri);
                return JsonConvert.DeserializeObject<ImageList>(result);
            }
        }
    }
}
