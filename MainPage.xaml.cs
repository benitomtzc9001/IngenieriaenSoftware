using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio_Clave_RFC_Primer_Parcial
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnCalc_Clicked(object sender, EventArgs e)
        {
            string apepat = txtapepat.Text;
            string apemat = txtapemat.Text;
            string nombres = txtnom.Text;

            DateTime FechaNacimiento = datFecha.Date;
            string año = FechaNacimiento.Year.ToString();
            string mes = FechaNacimiento.Month.ToString("D2");
            string dia = FechaNacimiento.Day.ToString("D2");

            string codigo = "";
            string clave = "";
            char[] vocales = { 'a', 'e', 'i', 'o', 'u' };
            string prvocal = "";

            foreach (char letra in apepat.Substring(1))
            {
                if (vocales.Contains(letra))
                {
                    prvocal = letra.ToString();
                    break;
                }
            }
            clave = clave + apepat.Substring(0, 1) + prvocal.Substring(0, 0);
            codigo = codigo + apemat.Substring(0, 1) + nombres.Substring(0, 1) + año.Substring(2, 2) + mes + dia;
            
            txtRFC.Text = clave + prvocal + codigo;
        }
    }
}