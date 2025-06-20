namespace Actividad3._2
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
            components = new System.ComponentModel.Container();
            btniniciar = new Button();
            btndetener = new Button();
            btnreiniciar = new Button();
            lblmostrado = new Label();
            ttemporizador = new System.Windows.Forms.Timer(components);
            txtMinutos = new TextBox();
            SuspendLayout();
            // 
            // btniniciar
            // 
            btniniciar.Location = new Point(117, 572);
            btniniciar.Name = "btniniciar";
            btniniciar.Size = new Size(218, 99);
            btniniciar.TabIndex = 0;
            btniniciar.Text = "Iniciar";
            btniniciar.UseVisualStyleBackColor = true;
            btniniciar.Click += btniniciar_Click;
            // 
            // btndetener
            // 
            btndetener.Location = new Point(410, 572);
            btndetener.Name = "btndetener";
            btndetener.Size = new Size(225, 99);
            btndetener.TabIndex = 1;
            btndetener.Text = "Detener";
            btndetener.UseVisualStyleBackColor = true;
            btndetener.Click += btndetener_Click;
            // 
            // btnreiniciar
            // 
            btnreiniciar.Location = new Point(714, 572);
            btnreiniciar.Name = "btnreiniciar";
            btnreiniciar.Size = new Size(265, 99);
            btnreiniciar.TabIndex = 2;
            btnreiniciar.Text = "Reiniciar";
            btnreiniciar.UseVisualStyleBackColor = true;
            btnreiniciar.Click += btnreiniciar_Click;
            // 
            // lblmostrado
            // 
            lblmostrado.AutoSize = true;
            lblmostrado.Location = new Point(141, 187);
            lblmostrado.Name = "lblmostrado";
            lblmostrado.Size = new Size(115, 48);
            lblmostrado.TabIndex = 3;
            lblmostrado.Text = "label1";
            // 
            // ttemporizador
            // 
            ttemporizador.Tick += ttemporizador_Tick;
            // 
            // txtMinutos
            // 
            txtMinutos.Location = new Point(152, 283);
            txtMinutos.Name = "txtMinutos";
            txtMinutos.Size = new Size(552, 55);
            txtMinutos.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 760);
            Controls.Add(txtMinutos);
            Controls.Add(lblmostrado);
            Controls.Add(btnreiniciar);
            Controls.Add(btndetener);
            Controls.Add(btniniciar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btniniciar;
        private Button btndetener;
        private Button btnreiniciar;
        private Label lblmostrado;
        private System.Windows.Forms.Timer ttemporizador;
        private TextBox txtMinutos;
    }
}
