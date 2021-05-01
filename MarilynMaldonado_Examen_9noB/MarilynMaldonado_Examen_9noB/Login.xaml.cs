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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
             try
                {
                    String usuario = Convert.ToString(txtusuario.Text);
                    String contraseña = Convert.ToString(txtcontraseña.Text);
                    if (usuario == "estudiante2021" && contraseña == "uisrael2021")
                    {
                        await Navigation.PushAsync(new Registro(usuario, contraseña));
                    }
                    else
                    {
                    await DisplayAlert("Alerta", "Inserte sus credenciales de forma correcta", "Gracias");
                    }
                }
                catch (Exception ex)
                {
                await DisplayAlert("Alerta", ex.Message, "Gracias");
                }


            }
        }
    }
