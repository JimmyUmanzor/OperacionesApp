using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;

namespace OperacionesApp
{
    public partial class SquareAreaPage : ContentPage
    {
        public SquareAreaPage()
        {
            InitializeComponent();
        }

        private void OnCalculateSquareArea(object sender, EventArgs e)
        {
            if (double.TryParse(SquareSideEntry.Text, out double side) && side > 0)
            {
                double area = side * side;
                SquareAreaResult.Text = $"Área del Cuadrado: {area}";
            }
            else
            {
                DisplayAlert("Error:","Introduce un valor válido para el lado del cuadrado.", "OK");
            }
        }

        private void OnClearSquareFields(object sender, EventArgs e)
        {
            SquareSideEntry.Text = string.Empty;
            SquareAreaResult.Text = string.Empty;
        }
    }
}
