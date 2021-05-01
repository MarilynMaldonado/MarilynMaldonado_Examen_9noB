using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MarilynMaldonado_Examen_9noB
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro(string usuario)
        {
             InitializeComponent();
             lbUsuario.Text = "Usuario: " + usuario;
        }

        private void btnIngresar_Clicked(object sender, EventArgs e)
        {
            double cuota = 1800 - Convert.ToDouble(txtPI.Text);
            double pc = (cuota / 3) + (1800 * (5 / 100));
            txtCuota.Text = pc.ToString();
        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Mensaje", "¡Datos Guardados con exito!", "OK");
            string nombre = txtNombre.Text;
            string PagoI = txtPI.Text;
            await Navigation.PushAsync(new MainPage(nombre, PagoI));
        }
    }
}