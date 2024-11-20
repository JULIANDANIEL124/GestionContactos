namespace GestionContactos
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
            txtNombre = new TextBox();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            txtDni = new TextBox();
            Nombre = new Label();
            Telefono = new Label();
            Correo = new Label();
            DNI = new Label();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            dataGridView_CellEndEdit = new DataGridView();
            TxtBuscar = new TextBox();
            label1 = new Label();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_CellEndEdit).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(85, 138);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(231, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(85, 176);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(231, 23);
            txtTelefono.TabIndex = 1;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(85, 265);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(231, 23);
            txtCorreo.TabIndex = 2;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(85, 224);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(231, 23);
            txtDni.TabIndex = 3;
            txtDni.TextChanged += txtDni_TextChanged;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Nombre.Location = new Point(2, 136);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(73, 21);
            Nombre.TabIndex = 4;
            Nombre.Text = "Nombre";
            // 
            // Telefono
            // 
            Telefono.AutoSize = true;
            Telefono.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Telefono.Location = new Point(2, 174);
            Telefono.Name = "Telefono";
            Telefono.Size = new Size(77, 21);
            Telefono.TabIndex = 5;
            Telefono.Text = "Telefono";
            // 
            // Correo
            // 
            Correo.AutoSize = true;
            Correo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Correo.Location = new Point(3, 265);
            Correo.Name = "Correo";
            Correo.Size = new Size(61, 21);
            Correo.TabIndex = 6;
            Correo.Text = "Correo";
            // 
            // DNI
            // 
            DNI.AutoSize = true;
            DNI.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DNI.Location = new Point(12, 222);
            DNI.Name = "DNI";
            DNI.Size = new Size(40, 21);
            DNI.TabIndex = 7;
            DNI.Text = "DNI";
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(12, 328);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(86, 39);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar\r\n ";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(120, 325);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(95, 39);
            btnEditar.TabIndex = 9;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(253, 328);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(83, 36);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dataGridView_CellEndEdit
            // 
            dataGridView_CellEndEdit.AllowUserToAddRows = false;
            dataGridView_CellEndEdit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_CellEndEdit.Location = new Point(351, 66);
            dataGridView_CellEndEdit.MultiSelect = false;
            dataGridView_CellEndEdit.Name = "dataGridView_CellEndEdit";
            dataGridView_CellEndEdit.ReadOnly = true;
            dataGridView_CellEndEdit.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_CellEndEdit.Size = new Size(437, 371);
            dataGridView_CellEndEdit.TabIndex = 12;
            dataGridView_CellEndEdit.CellContentClick += dataGridView_CellEndEdit_CellContentClick;
            // 
            // TxtBuscar
            // 
            TxtBuscar.Location = new Point(419, 37);
            TxtBuscar.Name = "TxtBuscar";
            TxtBuscar.Size = new Size(309, 23);
            TxtBuscar.TabIndex = 13;
            TxtBuscar.TextChanged += TxtBuscar_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(528, 9);
            label1.Name = "label1";
            label1.Size = new Size(80, 21);
            label1.TabIndex = 14;
            label1.Text = "Buscador";
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(85, 392);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(185, 45);
            btnGuardar.TabIndex = 15;
            btnGuardar.Text = "Guardar Cambios\r\n";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGuardar);
            Controls.Add(label1);
            Controls.Add(TxtBuscar);
            Controls.Add(dataGridView_CellEndEdit);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(DNI);
            Controls.Add(Correo);
            Controls.Add(Telefono);
            Controls.Add(Nombre);
            Controls.Add(txtDni);
            Controls.Add(txtCorreo);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_CellEndEdit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private TextBox txtDni;
        private Label Nombre;
        private Label Telefono;
        private Label Correo;
        private Label DNI;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
        private DataGridView dataGridView_CellEndEdit;
        private TextBox TxtBuscar;
        private Label label1;
        private Button btnGuardar;
    }
}
