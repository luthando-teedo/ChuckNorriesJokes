using ChucksNorriesLibrary;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChucknorrisJokeApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CategoryPage : ContentPage
    {
        public string[] Categories { get; set; }
        public CategoryPage()
        {
            InitializeComponent();
        }


        protected async override void OnAppearing()
        {
            base.OnAppearing();

            var jokeGen = new JokeGernarator();
            Categories = await jokeGen.GetCatagories();
            BindingContext = this;
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            string Categories = (sender as Label).Text; 
            HttpClient Client = new HttpClient();
            var Category = await Client.GetStringAsync("https://api.chucknorris.io/jokes/random?category=" + Categories);
            var CategoryConvert = JsonConvert.DeserializeObject<Joke>(Category);
            var realJoke = CategoryConvert.value;
            await DisplayAlert(Categories, realJoke, "ok");
        }
    }
}