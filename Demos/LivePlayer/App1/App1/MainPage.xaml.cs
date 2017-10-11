using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();

            this.BindingContext = new List<string>
                {
                    "https://developer.xamarin.com/demo/IMG_0074.JPG",
                    "https://developer.xamarin.com/demo/IMG_0078.JPG",
                    "https://developer.xamarin.com/demo/IMG_0308.JPG",
                    "https://developer.xamarin.com/demo/IMG_0437.JPG"
                };
        }
    }
}
