namespace WinFormsIMC
{
    partial class FrmImc
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmImc));
            lbPeso = new Label();
            txtPeso = new TextBox();
            txtAltura = new TextBox();
            lbAltura = new Label();
            pbLogo = new PictureBox();
            btnImc = new Button();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // lbPeso
            // 
            lbPeso.AutoSize = true;
            lbPeso.Location = new Point(110, 20);
            lbPeso.Name = "lbPeso";
            lbPeso.Size = new Size(42, 20);
            lbPeso.TabIndex = 0;
            lbPeso.Text = "Peso:";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(182, 17);
            txtPeso.Name = "txtPeso";
            txtPeso.PlaceholderText = "Informe seu peso";
            txtPeso.Size = new Size(155, 27);
            txtPeso.TabIndex = 1;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(182, 64);
            txtAltura.Name = "txtAltura";
            txtAltura.PlaceholderText = "Informe sua altura";
            txtAltura.Size = new Size(155, 27);
            txtAltura.TabIndex = 3;
            // 
            // lbAltura
            // 
            lbAltura.AutoSize = true;
            lbAltura.Location = new Point(110, 67);
            lbAltura.Name = "lbAltura";
            lbAltura.Size = new Size(52, 20);
            lbAltura.TabIndex = 2;
            lbAltura.Text = "Altura:";
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.exercise_icon_208576;
            pbLogo.Location = new Point(12, 17);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(74, 74);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 4;
            pbLogo.TabStop = false;
            // 
            // btnImc
            // 
            btnImc.Location = new Point(182, 112);
            btnImc.Name = "btnImc";
            btnImc.Size = new Size(155, 28);
            btnImc.TabIndex = 5;
            btnImc.Text = "Gerar";
            btnImc.UseVisualStyleBackColor = true;
            btnImc.Click += btnImc_Click;
            // 
            // FrmImc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 160);
            Controls.Add(btnImc);
            Controls.Add(pbLogo);
            Controls.Add(txtAltura);
            Controls.Add(lbAltura);
            Controls.Add(txtPeso);
            Controls.Add(lbPeso);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmImc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IMC";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbPeso;
        private TextBox txtPeso;
        private TextBox txtAltura;
        private Label lbAltura;
        private PictureBox pbLogo;
        private Button btnImc;
    }
}
