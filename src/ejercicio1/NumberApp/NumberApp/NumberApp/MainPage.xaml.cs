using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NumberApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Random random = new Random();
           int numero = random.Next();

            if (numero > 10)
            {
                System.Diagnostics.Debug.WriteLine("Número es mayor de 10...");
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Número no es mayor de 10...");
            }
        }
    }
}
