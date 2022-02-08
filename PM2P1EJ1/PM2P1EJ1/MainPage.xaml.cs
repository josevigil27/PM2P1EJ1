using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PM2P1EJ1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        private async void btnsuma_Clicked(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(Num1.Text) && !string.IsNullOrEmpty(Num2.Text))
            {
                var num1 = Convert.ToDecimal(Num1.Text);
                var num2 = Convert.ToDecimal(Num2.Text);
                var resultado = num1 + num2;

                await Navigation.PushAsync(new SecondPage(Convert.ToDecimal(resultado)));
            }
            else
                DisplayAlert("Error", "No se han introducido los datos", "Ok");
        }

        private async void btnresta_Clicked(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(Num1.Text) && !string.IsNullOrEmpty(Num2.Text))
            {
                var num1 = Convert.ToDecimal(Num1.Text);
                var num2 = Convert.ToDecimal(Num2.Text);
                var resultado = num1 - num2;

                await Navigation.PushAsync(new SecondPage(Convert.ToDecimal(resultado)));
            }
            else
                DisplayAlert("Error", "No se han introducido los datos", "Ok");
        }

        private async void btnmultiplicacion_Clicked(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(Num1.Text) && !string.IsNullOrEmpty(Num2.Text))
            {
                var num1 = Convert.ToDecimal(Num1.Text);
                var num2 = Convert.ToDecimal(Num2.Text);
                var resultado = num1 * num2;

                await Navigation.PushAsync(new SecondPage(Convert.ToDecimal(resultado)));
            }
            else
                DisplayAlert("Error", "No se han introducido los datos", "Ok");
        }

        private async void btndivision_Clicked(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(Num1.Text) && !string.IsNullOrEmpty(Num2.Text))
            {
                var num1 = Convert.ToDecimal(Num1.Text);
                var num2 = Convert.ToDecimal(Num2.Text);
                var resultado = num1 / num2;

                await Navigation.PushAsync(new SecondPage(Convert.ToDecimal(resultado)));
            }
            else
                DisplayAlert("Error", "No se han introducido los datos", "Ok");
        }
    }
}
