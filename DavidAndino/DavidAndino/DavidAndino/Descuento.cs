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
            this.BackColor = Color.CornflowerBlue;
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
            //validando todas las entradas del formulario
            if (string.IsNullOrEmpty(productoTextBox.Text))
            {
                errorProvider1.SetError(productoTextBox, "Ingrese una descripcion");
                productoTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(cantidadTextBox.Text))
            {
                errorProvider1.SetError(cantidadTextBox, "Ingrese una cantidad");
                cantidadTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(precioTextBox.Text))
            {
                errorProvider1.SetError(precioTextBox, "Ingrese un precio");
                precioTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(textBox3.Text))
            {
                errorProvider1.SetError(textBox3, "Ingrese una descripcion");
                textBox3.Focus();
                return;
            }
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(textBox2.Text))
            {
                errorProvider1.SetError(textBox2, "Ingrese una cantidad");
                textBox2.Focus();
                return;
            }
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Ingrese un precio");
                textBox1.Focus();
                return;
            }
            errorProvider1.Clear();

            //Definiendo e inicializando variables
            int cantidad = Convert.ToInt32(cantidadTextBox.Text), cantidad1 = Convert.ToInt32(textBox2.Text);
            double precio = Convert.ToDouble(precioTextBox.Text), precio1 = Convert.ToDouble(textBox1.Text), subTotal = 0;
            subTotal += (cantidad * precio) + (cantidad1 * precio1);

            //calculando total a pagar por medio de  la llamada del subtotal y la funcion que calcula el descuento
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

        private void productoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(productoTextBox, "Este campo no admite números");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void cantidadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                errorProvider1.SetError(cantidadTextBox, "Este campo solo admite números");
                e.Handled = true;
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void precioTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                errorProvider1.SetError(precioTextBox, "Este campo solo admite números");
                e.Handled = true;
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(textBox3, "Este campo no admite números");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                errorProvider1.SetError(textBox2, "Este campo solo admite números");
                e.Handled = true;
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                errorProvider1.SetError(textBox1, "Este campo solo admite números");
                e.Handled = true;
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
