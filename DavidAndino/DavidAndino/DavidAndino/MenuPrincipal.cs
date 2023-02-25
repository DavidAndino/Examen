using Syncfusion.WinForms.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DavidAndino
{
    public partial class MenuPrincipal : SfForm
    {
        public MenuPrincipal()
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

        private void interesButton_Click(object sender, EventArgs e)
        {
            //mostrando formulario de calculo de interes
            Interes mostrador = new Interes();
            mostrador.Show();
            Hide();

        }

        private void descuentoButton_Click(object sender, EventArgs e)
        {
            //mostrando formulario de descuento
            Descuento mostrador = new Descuento();
            mostrador.Show();
            Hide();
        }

        private void numerosButton_Click(object sender, EventArgs e)
        {
            //mostrando formulario de numeros 1 al 100
            Numeros mostrador = new Numeros();
            mostrador.Show();
            Hide();
        }
    }
}
