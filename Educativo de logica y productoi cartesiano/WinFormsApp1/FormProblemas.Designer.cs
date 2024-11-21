namespace WinFormsApp1
{
    partial class FormProblemas
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
            lblInstruccion = new Label();
            lblProblema = new Label();
            txtRespuesta = new TextBox();
            btnVerificar = new Button();
            SuspendLayout();
            // 
            // lblInstruccion
            // 
            lblInstruccion.AutoSize = true;
            lblInstruccion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInstruccion.Location = new Point(19, 24);
            lblInstruccion.Name = "lblInstruccion";
            lblInstruccion.Size = new Size(0, 21);
            lblInstruccion.TabIndex = 0;
            lblInstruccion.Click += lblInstruccion_Click;
            // 
            // lblProblema
            // 
            lblProblema.AutoSize = true;
            lblProblema.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProblema.Location = new Point(19, 59);
            lblProblema.Name = "lblProblema";
            lblProblema.Size = new Size(0, 21);
            lblProblema.TabIndex = 1;
            lblProblema.Click += lblProblema_Click;
            // 
            // txtRespuesta
            // 
            txtRespuesta.Location = new Point(13, 155);
            txtRespuesta.Name = "txtRespuesta";
            txtRespuesta.Size = new Size(775, 23);
            txtRespuesta.TabIndex = 2;
            txtRespuesta.TextChanged += txtrRespuesta_TextChanged;
            // 
            // btnVerificar
            // 
            btnVerificar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerificar.Location = new Point(12, 283);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(116, 42);
            btnVerificar.TabIndex = 3;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += VerificarRespuesta_Click;
            // 
            // FormProblemas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVerificar);
            Controls.Add(txtRespuesta);
            Controls.Add(lblProblema);
            Controls.Add(lblInstruccion);
            Name = "FormProblemas";
            Text = "FormProblemas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInstruccion;
        private Label lblProblema;
        private TextBox txtRespuesta;
        private Button btnVerificar;
    }
}