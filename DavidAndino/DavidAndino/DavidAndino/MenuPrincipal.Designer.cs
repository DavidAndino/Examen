namespace DavidAndino
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.numerosButton = new System.Windows.Forms.Button();
            this.descuentoButton = new System.Windows.Forms.Button();
            this.interesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numerosButton
            // 
            this.numerosButton.BackColor = System.Drawing.Color.Thistle;
            this.numerosButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numerosButton.Image = global::DavidAndino.Properties.Resources.maths;
            this.numerosButton.Location = new System.Drawing.Point(361, 57);
            this.numerosButton.Name = "numerosButton";
            this.numerosButton.Size = new System.Drawing.Size(121, 102);
            this.numerosButton.TabIndex = 2;
            this.numerosButton.Text = "Números 1 al 100";
            this.numerosButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.numerosButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.numerosButton.UseVisualStyleBackColor = false;
            this.numerosButton.Click += new System.EventHandler(this.numerosButton_Click);
            // 
            // descuentoButton
            // 
            this.descuentoButton.BackColor = System.Drawing.Color.Linen;
            this.descuentoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descuentoButton.Image = global::DavidAndino.Properties.Resources.descuento;
            this.descuentoButton.Location = new System.Drawing.Point(189, 57);
            this.descuentoButton.Name = "descuentoButton";
            this.descuentoButton.Size = new System.Drawing.Size(121, 102);
            this.descuentoButton.TabIndex = 1;
            this.descuentoButton.Text = "Descuento";
            this.descuentoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.descuentoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.descuentoButton.UseVisualStyleBackColor = false;
            this.descuentoButton.Click += new System.EventHandler(this.descuentoButton_Click);
            // 
            // interesButton
            // 
            this.interesButton.BackColor = System.Drawing.Color.LightBlue;
            this.interesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interesButton.Image = global::DavidAndino.Properties.Resources.calculadora;
            this.interesButton.Location = new System.Drawing.Point(27, 57);
            this.interesButton.Name = "interesButton";
            this.interesButton.Size = new System.Drawing.Size(112, 102);
            this.interesButton.TabIndex = 0;
            this.interesButton.Text = "Calculadora de Interés";
            this.interesButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.interesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.interesButton.UseVisualStyleBackColor = false;
            this.interesButton.Click += new System.EventHandler(this.interesButton_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(512, 197);
            this.Controls.Add(this.numerosButton);
            this.Controls.Add(this.descuentoButton);
            this.Controls.Add(this.interesButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MenuPrincipal";
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Text = "MenuPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button interesButton;
        private System.Windows.Forms.Button descuentoButton;
        private System.Windows.Forms.Button numerosButton;
    }
}