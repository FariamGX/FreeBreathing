using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Vuz
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void TernButtonClicked(object sender, EventArgs e)
        {
           bool result = await DisplayAlert("Стан повітря у Тернівському районі","Добре","На карту","Вийти");
            if (result)
            {
                await Navigation.PushAsync(new Page1());

            }
        }
        private async void PokrButtonClicked(object sender, EventArgs e)
        {
            bool result = await DisplayAlert("Стан повітря у Покровському районі", "Добре", "На карту", "Вийти");
            if (result)
            {
                await Navigation.PushAsync(new Page1());

            }
        }
        private async void SaksagButtonClicked(object sender, EventArgs e)
        {
            bool result = await DisplayAlert("Стан повітря у Саксаганьському районі", "Добре", "На карту", "Вийти");
            if (result)
            {
                await Navigation.PushAsync(new Page1());

            }
        }
        private async void DovgButtonClicked(object sender, EventArgs e)
        {
            bool result = await DisplayAlert("Стан повітря у Довгинцевському районі", "Добре", "На карту", "Вийти");
            if (result)
            {
                await Navigation.PushAsync(new Page1());

            }
        }
        private async void CentrButtonClicked(object sender, EventArgs e)
        {
            bool result = await DisplayAlert("Стан повітря у Центрально-Міському районі", "Добре", "На карту", "Вийти");
            if (result)
            {
                await Navigation.PushAsync(new Page1());

            }
        }
        private async void MetalButtonClicked (object sender, EventArgs e)
        {
            bool result = await DisplayAlert("Стан повітря у Металургійному районі", "Добре", "На карту", "Вийти");
            if (result)
            {
                await Navigation.PushAsync(new Page1());

            }
        }
        private async void IngulButtonClicked(object sender, EventArgs e)
        {
            bool result = await DisplayAlert("Стан повітря у Інгулецькомуому районі", "Добре", "На карту", "Вийти");
            if (result)
            {
                await Navigation.PushAsync(new Page1());

            }
        }
    }
}
