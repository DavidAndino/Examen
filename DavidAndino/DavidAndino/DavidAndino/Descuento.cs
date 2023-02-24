using Syncfusion.WinForms.Controls;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DavidAndino
{
    public partial class Descuento : SfForm
    {
        public Descuento()
        {
            InitializeComponent();

            this.Style.TitleBar.Height = 26;
            this.Style.TitleBar.BackColor = Color.White;
            this.Style.TitleBar.IconBackColor = Color.FromArgb(15, 161, 212);
            this.BackColor = Color.White;
            this.Style.TitleBar.ForeColor = ColorTranslator.FromHtml("#343434");
            this.Style.TitleBar.CloseButtonForeColor = Color.DarkGray;
            this.Style.TitleBar.MaximizeButtonForeColor = Color.DarkGray;
            this.Style.TitleBar.MinimizeButtonForeColor = Color.DarkGray;
            this.Style.TitleBar.HelpButtonForeColor = Color.DarkGray;
            this.Style.TitleBar.IconHorizontalAlignment = HorizontalAlignment.Left;
            this.Style.TitleBar.Font = this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Style.TitleBar.TextHorizontalAlignment = HorizontalAlignment.Center;
            this.Style.TitleBar.TextVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
        }
        private async void calcularButton_Click(object sender, System.EventArgs e)
        {
            int cantidad = Convert.ToInt32(cantidadTextBox.Text);
            double precio = Convert.ToDouble(precioTextBox.Text), subTotal = 0;
            int cantidad2 = Convert.ToInt32(textBox2.Text);
            double precio2 = Convert.ToDouble(textBox1.Text);

            subTotal = (precio * cantidad) + (precio2 * cantidad2);

            MessageBox.Show("El total a pagar es: " + (subTotal - await calcularDesctoAsync(subTotal)));
        }

        private async Task<double> calcularDesctoAsync(double subtotal)
        {

            double descuento = await Task.Run(() =>
            {
                return subtotal * 0.15;
            });

            Math.Round(descuento, 2);
            return descuento;
        }

        private void volverMenuButton_Click(object sender, EventArgs e)
        {
            MenuPrincipal volver = new MenuPrincipal();
            volver.Show();
            Hide();
        }
    }
}
