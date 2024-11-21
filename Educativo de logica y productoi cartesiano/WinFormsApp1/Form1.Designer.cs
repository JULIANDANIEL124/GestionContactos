namespace WinFormsApp1
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
            btnNegacion = new Button();
            btnConjuncion = new Button();
            btnDisyuncion = new Button();
            btnCondicionalidad = new Button();
            btnBicondicionalidad = new Button();
            lblTabla = new Label();
            lblExplicacion = new Label();
            btnEjercicios = new Button();
            btnProductoCartesiano = new Button();
            SuspendLayout();
            // 
            // btnNegacion
            // 
            btnNegacion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNegacion.Location = new Point(36, 256);
            btnNegacion.Name = "btnNegacion";
            btnNegacion.Size = new Size(152, 44);
            btnNegacion.TabIndex = 0;
            btnNegacion.Text = "Negacion";
            btnNegacion.UseVisualStyleBackColor = true;
            btnNegacion.Click += btnNegacion_Click;
            // 
            // btnConjuncion
            // 
            btnConjuncion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConjuncion.Location = new Point(36, 306);
            btnConjuncion.Name = "btnConjuncion";
            btnConjuncion.Size = new Size(152, 58);
            btnConjuncion.TabIndex = 1;
            btnConjuncion.Text = "Conjuncion";
            btnConjuncion.UseVisualStyleBackColor = true;
            btnConjuncion.Click += btnConjuncion_Click;
            // 
            // btnDisyuncion
            // 
            btnDisyuncion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDisyuncion.Location = new Point(36, 370);
            btnDisyuncion.Name = "btnDisyuncion";
            btnDisyuncion.Size = new Size(152, 54);
            btnDisyuncion.TabIndex = 2;
            btnDisyuncion.Text = "Disyuncion";
            btnDisyuncion.UseVisualStyleBackColor = true;
            btnDisyuncion.Click += btnDisyuncion_Click;
            // 
            // btnCondicionalidad
            // 
            btnCondicionalidad.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCondicionalidad.Location = new Point(194, 256);
            btnCondicionalidad.Name = "btnCondicionalidad";
            btnCondicionalidad.Size = new Size(158, 44);
            btnCondicionalidad.TabIndex = 3;
            btnCondicionalidad.Text = "condicionalidad";
            btnCondicionalidad.UseVisualStyleBackColor = true;
            btnCondicionalidad.Click += btnCondicionalidad_Click;
            // 
            // btnBicondicionalidad
            // 
            btnBicondicionalidad.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBicondicionalidad.Location = new Point(194, 306);
            btnBicondicionalidad.Name = "btnBicondicionalidad";
            btnBicondicionalidad.Size = new Size(158, 58);
            btnBicondicionalidad.TabIndex = 4;
            btnBicondicionalidad.Text = "Bicondicionalidad";
            btnBicondicionalidad.UseVisualStyleBackColor = true;
            btnBicondicionalidad.Click += btnBicondicionalidad_Click;
            // 
            // lblTabla
            // 
            lblTabla.AutoSize = true;
            lblTabla.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTabla.Location = new Point(12, 51);
            lblTabla.Name = "lblTabla";
            lblTabla.Size = new Size(19, 30);
            lblTabla.TabIndex = 5;
            lblTabla.Text = ".";
            // 
            // lblExplicacion
            // 
            lblExplicacion.AutoSize = true;
            lblExplicacion.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExplicacion.Location = new Point(11, 21);
            lblExplicacion.Name = "lblExplicacion";
            lblExplicacion.Size = new Size(19, 30);
            lblExplicacion.TabIndex = 6;
            lblExplicacion.Text = ".";
            // 
            // btnEjercicios
            // 
            btnEjercicios.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEjercicios.Location = new Point(194, 370);
            btnEjercicios.Name = "btnEjercicios";
            btnEjercicios.Size = new Size(158, 54);
            btnEjercicios.TabIndex = 7;
            btnEjercicios.Text = "Ejercicios";
            btnEjercicios.UseVisualStyleBackColor = true;
            btnEjercicios.Click += btnEjercicios_Click;
            // 
            // btnProductoCartesiano
            // 
            btnProductoCartesiano.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProductoCartesiano.ForeColor = SystemColors.ControlText;
            btnProductoCartesiano.Location = new Point(554, 306);
            btnProductoCartesiano.Name = "btnProductoCartesiano";
            btnProductoCartesiano.Size = new Size(155, 58);
            btnProductoCartesiano.TabIndex = 8;
            btnProductoCartesiano.Text = "Producto Cartesiano";
            btnProductoCartesiano.UseVisualStyleBackColor = true;
            btnProductoCartesiano.Click += btnProductoCartesiano_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnProductoCartesiano);
            Controls.Add(btnEjercicios);
            Controls.Add(lblExplicacion);
            Controls.Add(lblTabla);
            Controls.Add(btnBicondicionalidad);
            Controls.Add(btnCondicionalidad);
            Controls.Add(btnDisyuncion);
            Controls.Add(btnConjuncion);
            Controls.Add(btnNegacion);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNegacion;
        private Button btnConjuncion;
        private Button btnDisyuncion;
        private Button btnCondicionalidad;
        private Button btnBicondicionalidad;
        private Label lblTabla;
        private Label lblExplicacion;
        private Button btnEjercicios;
        private Button btnProductoCartesiano;
    }
}
