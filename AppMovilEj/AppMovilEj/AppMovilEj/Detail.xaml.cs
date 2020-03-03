using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppMovilEj
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Detail : ContentPage
    {
        public Detail()
        {
            InitializeComponent();
            Iniciar();
        }
        private void Iniciar()
        {
            boton.Clicked += boton_Clicked_1;
        }


        private async void boton_Clicked_1(object sender, EventArgs e)
        {
            await DisplayAlert("Mensaje", "Bienvenido " + entry1.Text + " " + entry2.Text, "cancelar");
        }
    }
}