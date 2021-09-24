using Persona.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Persona
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        async void btnEnviar_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombres.Text) & !string.IsNullOrEmpty(txtApellidos.Text) & !string.IsNullOrEmpty(txtCorreo.Text))
            {
                Personas pe = new Personas();

                pe.Nombre = txtNombres.Text;
                pe.Apellido = txtApellidos.Text;
                pe.Edad = Convert.ToInt32(numEdad.Text);
                pe.Correo = txtCorreo.Text;

                var resultado = new SegundaPagina();
                resultado.BindingContext = pe;
                await Navigation.PushAsync(resultado);
            }
        }
    }
}