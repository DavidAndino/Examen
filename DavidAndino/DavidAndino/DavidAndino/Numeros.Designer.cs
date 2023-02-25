namespace DavidAndino
{
    partial class Numeros
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.mostrarNumButton = new System.Windows.Forms.Button();
            this.volverMenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listBox1.Location = new System.Drawing.Point(304, 17);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 589);
            this.listBox1.TabIndex = 1;
            // 
            // mostrarNumButton
            // 
            this.mostrarNumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostrarNumButton.Image = global::DavidAndino.Properties.Resources.actualizacion_del_sistema;
            this.mostrarNumButton.Location = new System.Drawing.Point(81, 61);
            this.mostrarNumButton.Name = "mostrarNumButton";
            this.mostrarNumButton.Size = new System.Drawing.Size(156, 79);
            this.mostrarNumButton.TabIndex = 0;
            this.mostrarNumButton.Text = "Mostrar Números del 1  al  100";
            this.mostrarNumButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.mostrarNumButton.UseVisualStyleBackColor = true;
            this.mostrarNumButton.Click += new System.EventHandler(this.mostrarNumButton_Click);
            // 
            // volverMenuButton
            // 
            this.volverMenuButton.BackColor = System.Drawing.Color.Transparent;
            this.volverMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.volverMenuButton.Image = global::DavidAndino.Properties.Resources.flecha_hacia_atras;
            this.volverMenuButton.Location = new System.Drawing.Point(5, 5);
            this.volverMenuButton.Name = "volverMenuButton";
            this.volverMenuButton.Size = new System.Drawing.Size(40, 27);
            this.volverMenuButton.TabIndex = 14;
            this.volverMenuButton.Text = "\r\n";
            this.volverMenuButton.UseVisualStyleBackColor = false;
            this.volverMenuButton.Click += new System.EventHandler(this.volverMenuButton_Click);
            // 
            // Numeros
            // 
            this.AcceptButton = this.mostrarNumButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(488, 624);
            this.Controls.Add(this.volverMenuButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.mostrarNumButton);
            this.Name = "Numeros";
            this.Style.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Text = "Numeros";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mostrarNumButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button volverMenuButton;
    }
}