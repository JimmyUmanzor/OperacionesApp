using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OperacionesApp
{
    public partial class RectangleAreaPage : ContentPage
    {
        public RectangleAreaPage()
        {
            InitializeComponent();
        }

        private void OnCalculateRectangleArea(object sender, EventArgs e)
        {
            if (double.TryParse(RectangleWidthEntry.Text, out double width) && width > 0 &&
                double.TryParse(RectangleHeightEntry.Text, out double height) && height > 0)
            {
                double area = width * height;
                RectangleAreaResult.Text = $"Área del Rectángulo: {area}";
            }
            else
            {
                DisplayAlert("Error", "Introduce valores válidos para el ancho y la altura del rectángulo.", "OK");
            }
        }

        private void OnClearRectangleFields(object sender, EventArgs e)
        {
            RectangleWidthEntry.Text = string.Empty;
            RectangleHeightEntry.Text = string.Empty;
            RectangleAreaResult.Text = string.Empty;
        }
    }
}