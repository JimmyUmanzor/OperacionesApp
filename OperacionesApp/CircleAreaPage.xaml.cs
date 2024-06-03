using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;

namespace OperacionesApp
{
    public partial class CircleAreaPage : ContentPage
    {
        public CircleAreaPage()
        {
            InitializeComponent();
        }

        private void OnCalculateCircleArea(object sender, EventArgs e)
        {
            if (double.TryParse(CircleRadiusEntry.Text, out double radius) && radius > 0)
            {
                double area = Math.PI * radius * radius;
                CircleAreaResult.Text = $"Área del Círculo: {area:F2}";
            }
            else
            {
                DisplayAlert("Error", "Introduce un valor válido para el radio del círculo.", "OK");
            }
        }

        private void OnClearCircleFields(object sender, EventArgs e)
        {
            CircleRadiusEntry.Text = string.Empty;
            CircleAreaResult.Text = string.Empty;
        }
    }
}

