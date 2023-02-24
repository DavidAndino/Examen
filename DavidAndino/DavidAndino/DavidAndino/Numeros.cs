using Syncfusion.WinForms.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DavidAndino
{
    public partial class Numeros : SfForm
    {
        public Numeros()
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

        private void mostrarNumButton_Click(object sender, EventArgs e)
        {

            string[] numeros = new string[100];//creando arreglo  unidimensional
            int aux = 0;//definiendo e inicializando variable  auxiliar

            for (int i = 0; i < 100; i++)
            {
                numeros[i] = Convert.ToString(i + 1);
                aux = Convert.ToInt16(numeros[i]);
                //sustituyendo elemento guardado en cada posicion del vector dependiendo del cumplimiento de cada una de estas condiciones:
                if (aux % 3 == 0)
                {
                    numeros[i] = "David";
                }
                else if (aux % 5 == 0)
                {
                    numeros[i] = "Andino";
                }
                if ((aux % 3 == 0) && (aux % 5 == 0))
                {
                    numeros[i] = "DavidAndino";
                }

                listBox1.Items.Add(numeros[i]);
            }
        }

        private void volverMenuButton_Click(object sender, EventArgs e)
        {
            MenuPrincipal volver = new MenuPrincipal();
            volver.Show();
            Hide();
        }
    }


}
