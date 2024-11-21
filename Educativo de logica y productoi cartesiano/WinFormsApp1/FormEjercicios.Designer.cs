namespace WinFormsApp1
{
    partial class FormEjercicios
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
            lblPregunta = new Label();
            rdbOpcion1 = new RadioButton();
            rdbOpcion2 = new RadioButton();
            rdbOpcion3 = new RadioButton();
            btnVerificar = new Button();
            SuspendLayout();
            // 
            // lblPregunta
            // 
            lblPregunta.AutoSize = true;
            lblPregunta.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPregunta.Location = new Point(70, 58);
            lblPregunta.Name = "lblPregunta";
            lblPregunta.Size = new Size(14, 21);
            lblPregunta.TabIndex = 0;
            lblPregunta.Text = ".";
            // 
            // rdbOpcion1
            // 
            rdbOpcion1.AutoSize = true;
            rdbOpcion1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdbOpcion1.Location = new Point(70, 191);
            rdbOpcion1.Name = "rdbOpcion1";
            rdbOpcion1.Size = new Size(129, 25);
            rdbOpcion1.TabIndex = 1;
            rdbOpcion1.TabStop = true;
            rdbOpcion1.Text = "radioButton1";
            rdbOpcion1.UseVisualStyleBackColor = true;
            // 
            // rdbOpcion2
            // 
            rdbOpcion2.AutoSize = true;
            rdbOpcion2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdbOpcion2.Location = new Point(70, 233);
            rdbOpcion2.Name = "rdbOpcion2";
            rdbOpcion2.Size = new Size(129, 25);
            rdbOpcion2.TabIndex = 2;
            rdbOpcion2.TabStop = true;
            rdbOpcion2.Text = "radioButton1";
            rdbOpcion2.UseVisualStyleBackColor = true;
            // 
            // rdbOpcion3
            // 
            rdbOpcion3.AutoSize = true;
            rdbOpcion3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdbOpcion3.Location = new Point(70, 273);
            rdbOpcion3.Name = "rdbOpcion3";
            rdbOpcion3.Size = new Size(129, 25);
            rdbOpcion3.TabIndex = 3;
            rdbOpcion3.TabStop = true;
            rdbOpcion3.Text = "radioButton1";
            rdbOpcion3.UseVisualStyleBackColor = true;
            // 
            // btnVerificar
            // 
            btnVerificar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerificar.Location = new Point(60, 333);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(177, 44);
            btnVerificar.TabIndex = 4;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // FormEjercicios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVerificar);
            Controls.Add(rdbOpcion3);
            Controls.Add(rdbOpcion2);
            Controls.Add(rdbOpcion1);
            Controls.Add(lblPregunta);
            Name = "FormEjercicios";
            Text = "FormEjercicios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPregunta;
        private RadioButton rdbOpcion1;
        private RadioButton rdbOpcion2;
        private RadioButton rdbOpcion3;
        private Button btnVerificar;
    }
}