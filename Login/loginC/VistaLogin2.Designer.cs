namespace loginC
{
    partial class VistaLogin2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaLogin2));
            TituloLabel = new Label();
            pictureBoxCerrarVista = new PictureBox();
            pictureBoxAtras = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCerrarVista).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAtras).BeginInit();
            SuspendLayout();
            // 
            // TituloLabel
            // 
            TituloLabel.AutoSize = true;
            TituloLabel.BackColor = Color.Transparent;
            TituloLabel.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            TituloLabel.ForeColor = Color.White;
            TituloLabel.Location = new Point(103, 177);
            TituloLabel.Name = "TituloLabel";
            TituloLabel.Size = new Size(566, 65);
            TituloLabel.TabIndex = 0;
            TituloLabel.Text = "HOLA USUARIO NUEVO";
            // 
            // pictureBoxCerrarVista
            // 
            pictureBoxCerrarVista.BackgroundImageLayout = ImageLayout.None;
            pictureBoxCerrarVista.Image = (Image)resources.GetObject("pictureBoxCerrarVista.Image");
            pictureBoxCerrarVista.Location = new Point(743, 12);
            pictureBoxCerrarVista.Name = "pictureBoxCerrarVista";
            pictureBoxCerrarVista.Size = new Size(45, 42);
            pictureBoxCerrarVista.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCerrarVista.TabIndex = 1;
            pictureBoxCerrarVista.TabStop = false;
            pictureBoxCerrarVista.Click += pictureBoxCerrarVista_Click;
            // 
            // pictureBoxAtras
            // 
            pictureBoxAtras.BackgroundImageLayout = ImageLayout.None;
            pictureBoxAtras.Image = (Image)resources.GetObject("pictureBoxAtras.Image");
            pictureBoxAtras.Location = new Point(694, 12);
            pictureBoxAtras.Name = "pictureBoxAtras";
            pictureBoxAtras.Size = new Size(45, 42);
            pictureBoxAtras.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAtras.TabIndex = 2;
            pictureBoxAtras.TabStop = false;
            pictureBoxAtras.Click += pictureBoxAtras_Click;
            // 
            // VistaLogin2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBoxAtras);
            Controls.Add(pictureBoxCerrarVista);
            Controls.Add(TituloLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VistaLogin2";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VistaLogin2";
            ((System.ComponentModel.ISupportInitialize)pictureBoxCerrarVista).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAtras).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TituloLabel;
        private PictureBox pictureBoxCerrarVista;
        private PictureBox pictureBoxAtras;
    }
}