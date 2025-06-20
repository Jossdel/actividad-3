namespace Actividad3._3
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
            btnConvertir = new Button();
            cmbEntrada = new ComboBox();
            cmbSalida = new ComboBox();
            txtValor = new TextBox();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(14, 94);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(176, 75);
            btnConvertir.TabIndex = 0;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // cmbEntrada
            // 
            cmbEntrada.FormattingEnabled = true;
            cmbEntrada.Location = new Point(12, 413);
            cmbEntrada.Name = "cmbEntrada";
            cmbEntrada.Size = new Size(269, 56);
            cmbEntrada.TabIndex = 1;
            // 
            // cmbSalida
            // 
            cmbSalida.FormattingEnabled = true;
            cmbSalida.Location = new Point(317, 413);
            cmbSalida.Name = "cmbSalida";
            cmbSalida.Size = new Size(352, 56);
            cmbSalida.TabIndex = 2;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(14, 188);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(355, 55);
            txtValor.TabIndex = 3;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(222, 107);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(176, 48);
            lblResultado.TabIndex = 4;
            lblResultado.Text = "Resultado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1497, 900);
            Controls.Add(lblResultado);
            Controls.Add(txtValor);
            Controls.Add(cmbSalida);
            Controls.Add(cmbEntrada);
            Controls.Add(btnConvertir);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConvertir;
        private ComboBox cmbEntrada;
        private ComboBox cmbSalida;
        private TextBox txtValor;
        private Label lblResultado;
    }
}
