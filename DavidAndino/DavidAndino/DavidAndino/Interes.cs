﻿using Syncfusion.WinForms.Controls;
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
            this.Style.TitleBar.BackColor = Color.DarkGray;
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
            //definicion e iniciacion de variables locales con los datos que el usuario ingrese en cada caja de texto
            double capital = 200000;
            int meses = 12;

            //invocando funcion que calcula interes simple e imprimiendo de una vez en la caja de texto asignada para tal uso
            IGeneradoTextBox.Text = Convert.ToString(interes(capital, meses));
        }

        private double interes(double capital, int meses)
        {
            double interes = 0;//definiendo e incializnado variable que se retornara con un valor
            //proceso
            for (int i = 0; i < meses; i++)
            {
                interes = capital * tasa * meses;
                Math.Round(interes, 2);//redondeando el valor que salga  del calculo de interes para que solo muestres 2 decimales despues del punto
            }
            return interes;
        }

        private void volverMenuButton_Click(object sender, EventArgs e)
        {
            MenuPrincipal volver = new MenuPrincipal();
            volver.Show();
            Hide();
        }
    }
}
