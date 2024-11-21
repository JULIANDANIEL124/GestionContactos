namespace WinFormsApp1
{
    partial class FormProductoCartesiano
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
            lblExplicacion = new Label();
            lblEjemplo = new Label();
            btnProblemas = new Button();
            lblAplicaciones = new Label();
            SuspendLayout();
            // 
            // lblExplicacion
            // 
            lblExplicacion.AutoSize = true;
            lblExplicacion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExplicacion.Location = new Point(12, 31);
            lblExplicacion.Name = "lblExplicacion";
            lblExplicacion.Size = new Size(14, 21);
            lblExplicacion.TabIndex = 0;
            lblExplicacion.Text = ".";
            lblExplicacion.Click += lblExplicacion_Click;
            // 
            // lblEjemplo
            // 
            lblEjemplo.AutoSize = true;
            lblEjemplo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEjemplo.Location = new Point(12, 135);
            lblEjemplo.Name = "lblEjemplo";
            lblEjemplo.Size = new Size(14, 21);
            lblEjemplo.TabIndex = 1;
            lblEjemplo.Text = ".";
            lblEjemplo.Click += lblEjemplo_Click;
            // 
            // btnProblemas
            // 
            btnProblemas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProblemas.Location = new Point(646, 380);
            btnProblemas.Name = "btnProblemas";
            btnProblemas.Size = new Size(142, 58);
            btnProblemas.TabIndex = 2;
            btnProblemas.Text = "Problema";
            btnProblemas.UseVisualStyleBackColor = true;
            btnProblemas.Click += btnProblemas_Click;
            // 
            // lblAplicaciones
            // 
            lblAplicaciones.AutoSize = true;
            lblAplicaciones.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAplicaciones.Location = new Point(12, 242);
            lblAplicaciones.Name = "lblAplicaciones";
            lblAplicaciones.Size = new Size(14, 21);
            lblAplicaciones.TabIndex = 3;
            lblAplicaciones.Text = ".";
            // 
            // FormProductoCartesiano
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblAplicaciones);
            Controls.Add(btnProblemas);
            Controls.Add(lblEjemplo);
            Controls.Add(lblExplicacion);
            Name = "FormProductoCartesiano";
            Text = "FormProductoCartesiano";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblExplicacion;
        private Label lblEjemplo;
        private Button btnProblemas;
        private Label lblAplicaciones;
    }
}