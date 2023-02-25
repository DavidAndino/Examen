using Syncfusion.WinForms.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DavidAndino
{
    public partial class Interes : SfForm
    {
        public Interes()
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
        //definiendo e inicializando constante global
        const double tasa = 0.015;

        private void calcularButton_Click(object sender, EventArgs e)
        {
            //invocando funcion que calcula interes simple e imprimiendo de una vez en la caja de texto asignada para tal uso
            IGeneradoTextBox.Text = Convert.ToString(interes(200000, 12));
        }

        private double interes(double capital, int meses)
        {
            double interesMensual = 0, interesTotal = 0;//definiendo e incializnado variable que se retornara con un valor

            double[] vector = new double[12];//creando vector que almacenara el valor de interes de cada mes
            //proceso
            for (int i = 0; i < meses; i++)
            {
                interesMensual = capital * tasa * 1;
                capital = capital + interesMensual;
                vector[i] = interesMensual;

                switch (i)
                {
                    case 0: //Intereses de enero
                        listBox1.Items.Add("Enero: " + vector[i]);
                        break;
                    case 1://Intereses de febrero
                        listBox1.Items.Add("Febrero: " + vector[i]);
                        break;
                    case 2: //Intereses de marzo
                        listBox1.Items.Add("Marzo: " + Math.Round(vector[i], 2));
                        break;
                    case 3://Intereses de abril
                        listBox1.Items.Add("Abril: " + Math.Round(vector[i], 2));
                        break;
                    case 4://Intereses de mayo
                        listBox1.Items.Add("Mayo: " + Math.Round(vector[i], 2));
                        break;
                    case 5://Intereses de enero
                        listBox1.Items.Add("Junio: " + Math.Round(vector[i], 2));
                        break;
                    case 6://Intereses de enero
                        listBox1.Items.Add("Julio: " + Math.Round(vector[i], 2));
                        break;
                    case 7://Intereses de enero
                        listBox1.Items.Add("Agosto: " + Math.Round(vector[i], 2));
                        break;
                    case 8://Intereses de enero
                        listBox1.Items.Add("Septiembre: " + Math.Round(vector[i], 2));
                        break;
                    case 9://Intereses de enero
                        listBox1.Items.Add("Octubre: " + Math.Round(vector[i], 2));
                        break;
                    case 10://Intereses de enero
                        listBox1.Items.Add("Noviembre: " + Math.Round(vector[i], 2));
                        break;
                    case 11://Intereses de enero
                        listBox1.Items.Add("Diciembre: " + Math.Round(vector[i], 2));
                        break;
                    default:
                        break;
                }//fin de decision multiple que asigna el nombre del mes y el valor de su interes
                interesTotal += interesMensual;
            }//fin de ciclo donde se calcula e imprime el interes de cada  mes

            return Math.Round(interesTotal, 2);
        }

        private void volverMenuButton_Click(object sender, EventArgs e)//creando metodo de boton que permite regresar al menu principal desde este formulario
        {
            MenuPrincipal volver = new MenuPrincipal();
            volver.Show();
            Hide();
        }
    }
}
