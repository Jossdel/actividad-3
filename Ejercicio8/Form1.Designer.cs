namespace Activida3._8
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
            btnContar = new Button();
            lblResultado = new Label();
            txtOracion = new TextBox();
            SuspendLayout();
            // 
            // btnContar
            // 
            btnContar.Location = new Point(19, 105);
            btnContar.Name = "btnContar";
            btnContar.Size = new Size(194, 65);
            btnContar.TabIndex = 0;
            btnContar.Text = "Contar";
            btnContar.UseVisualStyleBackColor = true;
            btnContar.Click += btnContar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(264, 113);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(115, 48);
            lblResultado.TabIndex = 1;
            lblResultado.Text = "label1";
            // 
            // txtOracion
            // 
            txtOracion.Location = new Point(27, 205);
            txtOracion.Multiline = true;
            txtOracion.Name = "txtOracion";
            txtOracion.Size = new Size(504, 200);
            txtOracion.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtOracion);
            Controls.Add(lblResultado);
            Controls.Add(btnContar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnContar;
        private Label lblResultado;
        private TextBox txtOracion;
    }
}
