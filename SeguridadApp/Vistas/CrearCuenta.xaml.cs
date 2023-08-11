using SeguridadApp.VistasModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SeguridadApp.Vistas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CrearCuenta : ContentPage
	{
		public CrearCuenta ()
		{
			InitializeComponent ();
		}

        private void btnCrearcuenta_Clicked(object sender, EventArgs e)
        {
			Crearcuenta();
        }
		private void Crearcuenta()
		{
			var funcion = new VMcrearcuenta();
			funcion.CrearCuenta(txtcorreo.Text,txtcontraseña.Text);
		}
    }
}