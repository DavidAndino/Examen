namespace DavidAndino
{
    partial class Interes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interes));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.capitalTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tiempoTextBox = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.calcularButton = new System.Windows.Forms.Button();
            this.IGeneradoTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.volverMenuButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(61, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Capital:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(81, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Calculadora de  Interés";
            // 
            // capitalTextBox
            // 
            this.capitalTextBox.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.capitalTextBox.Enabled = false;
            this.capitalTextBox.Location = new System.Drawing.Point(149, 68);
            this.capitalTextBox.Name = "capitalTextBox";
            this.capitalTextBox.ReadOnly = true;
            this.capitalTextBox.Size = new System.Drawing.Size(143, 26);
            this.capitalTextBox.TabIndex = 3;
            this.capitalTextBox.Text = "200,000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(61, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Meses:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(61, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tasa:";
            // 
            // tiempoTextBox
            // 
            this.tiempoTextBox.Enabled = false;
            this.tiempoTextBox.Location = new System.Drawing.Point(149, 113);
            this.tiempoTextBox.Name = "tiempoTextBox";
            this.tiempoTextBox.Size = new System.Drawing.Size(41, 26);
            this.tiempoTextBox.TabIndex = 6;
            this.tiempoTextBox.Text = "12";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(149, 157);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(41, 26);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "1.5%";
            // 
            // calcularButton
            // 
            this.calcularButton.BackColor = System.Drawing.Color.Transparent;
            this.calcularButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcularButton.Image = global::DavidAndino.Properties.Resources.work_process;
            this.calcularButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.calcularButton.Location = new System.Drawing.Point(149, 207);
            this.calcularButton.Name = "calcularButton";
            this.calcularButton.Size = new System.Drawing.Size(105, 37);
            this.calcularButton.TabIndex = 8;
            this.calcularButton.Text = "Calcular";
            this.calcularButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.calcularButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.calcularButton.UseVisualStyleBackColor = false;
            this.calcularButton.Click += new System.EventHandler(this.calcularButton_Click);
            // 
            // IGeneradoTextBox
            // 
            this.IGeneradoTextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.IGeneradoTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IGeneradoTextBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.IGeneradoTextBox.Location = new System.Drawing.Point(149, 568);
            this.IGeneradoTextBox.Name = "IGeneradoTextBox";
            this.IGeneradoTextBox.ReadOnly = true;
            this.IGeneradoTextBox.Size = new System.Drawing.Size(96, 26);
            this.IGeneradoTextBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(10, 568);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Interés Total:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "Mes     Interés"});
            this.listBox1.Location = new System.Drawing.Point(149, 263);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(143, 284);
            this.listBox1.TabIndex = 11;
            // 
            // volverMenuButton
            // 
            this.volverMenuButton.BackColor = System.Drawing.Color.Transparent;
            this.volverMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.volverMenuButton.Image = global::DavidAndino.Properties.Resources.flecha_hacia_atras;
            this.volverMenuButton.Location = new System.Drawing.Point(5, 5);
            this.volverMenuButton.Name = "volverMenuButton";
            this.volverMenuButton.Size = new System.Drawing.Size(40, 27);
            this.volverMenuButton.TabIndex = 12;
            this.volverMenuButton.Text = "\r\n";
            this.volverMenuButton.UseVisualStyleBackColor = false;
            this.volverMenuButton.Click += new System.EventHandler(this.volverMenuButton_Click);
            // 
            // Interes
            // 
            this.AcceptButton = this.calcularButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DavidAndino.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(403, 610);
            this.Controls.Add(this.volverMenuButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.IGeneradoTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.calcularButton);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.tiempoTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.capitalTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Interes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Text = "Interes";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox capitalTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tiempoTextBox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button calcularButton;
        private System.Windows.Forms.TextBox IGeneradoTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button volverMenuButton;
    }
}