using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Login
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void ValidarCampos(object ob, EventArgs ar)
        {
            if (String.IsNullOrWhiteSpace(email.Text) || String.IsNullOrWhiteSpace(password.Text))
            {
                await DisplayAlert("Error", "No pueden quedar campos vacios", "Ok");
            }
            else if (!String.IsNullOrWhiteSpace(email.Text) || !String.IsNullOrWhiteSpace(password.Text))
            {
                string saludo = $"Hola {email.Text}";
                await DisplayAlert("Bienvenido", saludo, "Ok");
            }
            
        }
    }
}
