namespace Activida3
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
            btnMostrar = new Button();
            label1 = new Label();
            txtNumero = new TextBox();
            lstTabla = new CheckedListBox();
            SuspendLayout();
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(35, 298);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(241, 63);
            btnMostrar.TabIndex = 0;
            btnMostrar.Text = "Mostrar tabla";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(395, 215);
            label1.Name = "label1";
            label1.Size = new Size(321, 48);
            label1.TabIndex = 1;
            label1.Text = "Ingrese un numero";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(307, 319);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(450, 55);
            txtNumero.TabIndex = 2;
            // 
            // lstTabla
            // 
            lstTabla.FormattingEnabled = true;
            lstTabla.Location = new Point(287, 426);
            lstTabla.Name = "lstTabla";
            lstTabla.Size = new Size(550, 436);
            lstTabla.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1235, 937);
            Controls.Add(lstTabla);
            Controls.Add(txtNumero);
            Controls.Add(label1);
            Controls.Add(btnMostrar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMostrar;
        private Label label1;
        private TextBox txtNumero;
        private CheckedListBox lstTabla;
    }
}
