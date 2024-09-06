namespace AreasYPerimetros
{
    partial class Form1
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
            MenuDeFormas = new ComboBox();
            lblValor1 = new Label();
            lblValor2 = new Label();
            lblValor3 = new Label();
            txtValor2 = new TextBox();
            txtValor1 = new TextBox();
            txtValor3 = new TextBox();
            Calcular = new Button();
            Resultado = new Label();
            TituloDelForm = new Label();
            ImagenDeFiguras = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ImagenDeFiguras).BeginInit();
            SuspendLayout();
            // 
            // MenuDeFormas
            // 
            MenuDeFormas.FormattingEnabled = true;
            MenuDeFormas.Location = new Point(51, 73);
            MenuDeFormas.Name = "MenuDeFormas";
            MenuDeFormas.Size = new Size(121, 23);
            MenuDeFormas.TabIndex = 0;
            MenuDeFormas.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lblValor1
            // 
            lblValor1.AutoSize = true;
            lblValor1.Location = new Point(51, 126);
            lblValor1.Name = "lblValor1";
            lblValor1.Size = new Size(42, 15);
            lblValor1.TabIndex = 1;
            lblValor1.Text = "Valor 1";
            // 
            // lblValor2
            // 
            lblValor2.AutoSize = true;
            lblValor2.Location = new Point(51, 157);
            lblValor2.Name = "lblValor2";
            lblValor2.Size = new Size(42, 15);
            lblValor2.TabIndex = 2;
            lblValor2.Text = "Valor 2";
            // 
            // lblValor3
            // 
            lblValor3.AutoSize = true;
            lblValor3.Location = new Point(51, 190);
            lblValor3.Name = "lblValor3";
            lblValor3.Size = new Size(42, 15);
            lblValor3.TabIndex = 3;
            lblValor3.Text = "Valor 3";
            // 
            // txtValor2
            // 
            txtValor2.Location = new Point(149, 149);
            txtValor2.Name = "txtValor2";
            txtValor2.Size = new Size(100, 23);
            txtValor2.TabIndex = 4;
            // 
            // txtValor1
            // 
            txtValor1.Location = new Point(149, 118);
            txtValor1.Name = "txtValor1";
            txtValor1.Size = new Size(100, 23);
            txtValor1.TabIndex = 5;
            // 
            // txtValor3
            // 
            txtValor3.Location = new Point(149, 187);
            txtValor3.Name = "txtValor3";
            txtValor3.Size = new Size(100, 23);
            txtValor3.TabIndex = 6;
            // 
            // Calcular
            // 
            Calcular.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Calcular.ForeColor = SystemColors.MenuText;
            Calcular.Location = new Point(91, 232);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(139, 44);
            Calcular.TabIndex = 7;
            Calcular.Text = "Calcular";
            Calcular.UseVisualStyleBackColor = true;
            Calcular.Click += Calcular_Click;
            // 
            // Resultado
            // 
            Resultado.AutoSize = true;
            Resultado.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Resultado.Location = new Point(91, 295);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(100, 25);
            Resultado.TabIndex = 8;
            Resultado.Text = "Resultado";
            Resultado.Visible = false;
            // 
            // TituloDelForm
            // 
            TituloDelForm.AutoSize = true;
            TituloDelForm.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TituloDelForm.Location = new Point(45, 24);
            TituloDelForm.Name = "TituloDelForm";
            TituloDelForm.Size = new Size(297, 37);
            TituloDelForm.TabIndex = 9;
            TituloDelForm.Text = "Selecciona una figura:";
            // 
            // ImagenDeFiguras
            // 
            ImagenDeFiguras.Image = Properties.Resources._8e5d89958b67620d6a23975a45f6cdd3;
            ImagenDeFiguras.Location = new Point(412, 34);
            ImagenDeFiguras.Name = "ImagenDeFiguras";
            ImagenDeFiguras.Size = new Size(357, 286);
            ImagenDeFiguras.SizeMode = PictureBoxSizeMode.StretchImage;
            ImagenDeFiguras.TabIndex = 10;
            ImagenDeFiguras.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 429);
            Controls.Add(ImagenDeFiguras);
            Controls.Add(TituloDelForm);
            Controls.Add(Resultado);
            Controls.Add(Calcular);
            Controls.Add(txtValor3);
            Controls.Add(txtValor1);
            Controls.Add(txtValor2);
            Controls.Add(lblValor3);
            Controls.Add(lblValor2);
            Controls.Add(lblValor1);
            Controls.Add(MenuDeFormas);
            Name = "Form1";
            Text = "Cálculo de Áreas y Perímetros";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)ImagenDeFiguras).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox MenuDeFormas;
        private System.Windows.Forms.Label lblValor1;
        private System.Windows.Forms.Label lblValor2;
        private System.Windows.Forms.Label lblValor3;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtValor3;
        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.Label Resultado; // Añadido para mostrar resultados
        private Label TituloDelForm;
        private PictureBox ImagenDeFiguras;
    }
}
