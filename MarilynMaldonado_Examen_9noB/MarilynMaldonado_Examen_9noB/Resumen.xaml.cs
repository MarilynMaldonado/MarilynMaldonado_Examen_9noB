using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MarilynMaldonado_Examen_9noB
{
    public partial class MainPage : ContentPage
    {
        public MainPage(string nom, string Pag)
        {
            InitializeComponent();
            lbNombre.Text = nom;
            lbPI.Text = Pag;
        }
    }
}
