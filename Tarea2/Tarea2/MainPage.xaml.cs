using Tarea2.Models;
using Tarea2.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Tarea2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var informacion = new Models.Informacion
            {
                nombres = nombres.Text,
                apellidos = apellidos.Text,
                edad = edad.Text,
                correo = correo.Text,

            };

            var pagina = new Views.PageTwo();
            pagina.BindingContext = informacion;
            await Navigation.PushAsync(pagina);

        }
    }
}



