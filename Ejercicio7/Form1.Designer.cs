namespace Actividad3._7
{
    partial class Form1
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
            Generar = new Button();
            lstPrimos = new ListBox();
            txtIniciar = new TextBox();
            txtFin = new TextBox();
            SuspendLayout();
            // 
            // Generar
            // 
            Generar.Location = new Point(10, 281);
            Generar.Name = "Generar";
            Generar.Size = new Size(188, 80);
            Generar.TabIndex = 0;
            Generar.Text = "button1";
            Generar.UseVisualStyleBackColor = true;
            Generar.Click += Generar_Click;
            // 
            // lstPrimos
            // 
            lstPrimos.FormattingEnabled = true;
            lstPrimos.Location = new Point(246, 270);
            lstPrimos.Name = "lstPrimos";
            lstPrimos.Size = new Size(429, 532);
            lstPrimos.TabIndex = 1;
            // 
            // txtIniciar
            // 
            txtIniciar.Location = new Point(23, 114);
            txtIniciar.Name = "txtIniciar";
            txtIniciar.Size = new Size(315, 55);
            txtIniciar.TabIndex = 2;
            // 
            // txtFin
            // 
            txtFin.Location = new Point(378, 114);
            txtFin.Name = "txtFin";
            txtFin.Size = new Size(395, 55);
            txtFin.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 965);
            Controls.Add(txtFin);
            Controls.Add(txtIniciar);
            Controls.Add(lstPrimos);
            Controls.Add(Generar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Generar;
        private ListBox lstPrimos;
        private TextBox txtIniciar;
        private TextBox txtFin;
    }
}
