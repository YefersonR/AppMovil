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
    public partial class Secundaria : ContentPage
    {
        public Secundaria()
        {
            InitializeComponent();
        }

        
        private async void segunda_Clicked(object sender, EventArgs e)
        {
            App.MasterD.IsPresented = false;
            await App.MasterD.Detail.Navigation.PushAsync(new Page1());

        }

        private async void Tercera_Clicked(object sender, EventArgs e)
        {
            App.MasterD.IsPresented = false;
            await App.MasterD.Detail.Navigation.PushAsync(new Page2());
        }
    }
}