using System;
using Xamarin.Forms;

namespace Actividad
{
    public partial class PrincipalPage : ContentPage
    {
        public PrincipalPage() => this.InitializeComponent();

        private void Operacion_OnClicked(object transmisor, EventArgs argumentos)
        {
            try
            {
                Button botonCliqueado = (Button)transmisor;

                if
                (
                    String.IsNullOrWhiteSpace(this.EntryValorUno.Text) ||
                    String.IsNullOrWhiteSpace(this.EntryValorDos.Text) ||
                    !Decimal.TryParse(this.EntryValorUno.Text, out decimal uno) ||
                    !Decimal.TryParse(this.EntryValorDos.Text, out decimal dos)
                )
                    return;

                this.LabelResultado.Text = botonCliqueado.Text switch
                {
                    "Sumar" => (uno + dos).ToString("N"),
                    "Restar" => (uno - dos).ToString("N"),
                    "Multiplicar" => (uno * dos).ToString("N"),
                    "Dividir" => (uno / dos).ToString("N"),
                    _ => "0.00"
                };
            }
            catch (Exception)
            {
                this.LabelResultado.Text = "0.00";
            }
        }
    }
}