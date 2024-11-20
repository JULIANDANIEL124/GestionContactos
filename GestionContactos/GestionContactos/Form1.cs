using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace GestionContactos
{
    public partial class Form1 : Form
    {
        private List<Contacto> contactos = new List<Contacto>();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("contactos.json"))
            {
                string json = File.ReadAllText("contactos.json");
                contactos = JsonConvert.DeserializeObject<List<Contacto>>(json) ?? new List<Contacto>();

                // Actualizar el DataGridView con los datos cargados
                ActualizarDataGridView();
                // Limpia el Tag cuando el formulario se cierre
                dataGridView_CellEndEdit.Tag = null;
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            txtDni.Text = "";
        }
        private void InicializarDataGridView()
        {
            // Limpiar las columnas si ya existen
            dataGridView_CellEndEdit.Columns.Clear();

            // Definir las columnas del DataGridView
            dataGridView_CellEndEdit.Columns.Add("Nombre", "Nombre");
            dataGridView_CellEndEdit.Columns.Add("Telefono", "Teléfono");
            dataGridView_CellEndEdit.Columns.Add("Correo", "Correo");
            dataGridView_CellEndEdit.Columns.Add("DNI", "DNI");
        }

        private void ActualizarDataGridView()
        {

            // Asegúrate de que las columnas estén inicializadas
            if (dataGridView_CellEndEdit.Columns.Count == 0)
            {
                InicializarDataGridView();
            }

            // Limpia las filas antes de agregar los nuevos datos
            dataGridView_CellEndEdit.Rows.Clear();

            // Agregar cada contacto a las filas del DataGridView
            foreach (var contacto in contactos)
            {
                dataGridView_CellEndEdit.Rows.Add(contacto.Nombre, contacto.Telefono, contacto.Correo, contacto.DNI);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Verifica que se haya seleccionado al menos una fila
            if (dataGridView_CellEndEdit.SelectedRows.Count > 0)
            {
                // Obtiene el índice de la fila seleccionada
                int index = dataGridView_CellEndEdit.SelectedRows[0].Index;

                // Guarda el índice de la fila seleccionada en el Tag
                dataGridView_CellEndEdit.Tag = index;

                // Depuración: Verifica que el índice está correcto
                Console.WriteLine($"Índice seleccionado: {index}");

                // Carga los datos del contacto seleccionado en los campos de texto
                var contacto = contactos[index];
                txtNombre.Text = contacto.Nombre;
                txtTelefono.Text = contacto.Telefono;
                txtCorreo.Text = contacto.Correo;
                txtDni.Text = contacto.DNI;
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un contacto para editar.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verifica si se ha seleccionado una fila
            if (dataGridView_CellEndEdit.SelectedRows.Count > 0)
            {
                // Obtiene el índice de la fila seleccionada
                int index = dataGridView_CellEndEdit.SelectedRows[0].Index;

                // Verifica si el índice es válido
                if (index >= 0 && index < contactos.Count)
                {
                    // Elimina el contacto de la lista
                    contactos.RemoveAt(index);

                    // Llama a ActualizarDataGridView para reflejar el cambio
                    ActualizarDataGridView();
                }
                else
                {
                    MessageBox.Show("Índice inválido para eliminar.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un contacto para eliminar.");
            }
        }


        private void GuardarContactosEnJson()
        {
            // Serializar la lista de contactos a formato JSON
            string json = JsonConvert.SerializeObject(contactos, Formatting.Indented);

            // Guardar el JSON en un archivo llamado "contactos.json"
            File.WriteAllText("contactos.json", json);
        }


        private void dataGridView_CellEndEdit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si la celda editada está vacía
            if (string.IsNullOrWhiteSpace(dataGridView_CellEndEdit.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()))
            {
                MessageBox.Show("No puedes dejar este campo vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Restaura el valor anterior (o establece un valor predeterminado si lo prefieres)
                dataGridView_CellEndEdit.CancelEdit();
            }
            // Obtén el índice de la fila editada
            int rowIndex = e.RowIndex;

            // Actualiza el objeto en la lista
            contactos[rowIndex].Nombre = dataGridView_CellEndEdit.Rows[rowIndex].Cells["Nombre"].Value.ToString();
            contactos[rowIndex].Telefono = dataGridView_CellEndEdit.Rows[rowIndex].Cells["Telefono"].Value.ToString();
            contactos[rowIndex].Correo = dataGridView_CellEndEdit.Rows[rowIndex].Cells["Correo"].Value.ToString();
            contactos[rowIndex].DNI = dataGridView_CellEndEdit.Rows[rowIndex].Cells["DNI"].Value.ToString();
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            if (!long.TryParse(txtDni.Text, out _))
            {
                txtDni.BackColor = Color.LightCoral;  // Cambia el color a rojo si no es numérico
            }
            else
            {
                txtDni.BackColor = Color.White;  // Restaura el color cuando es válido
            }
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            if (!long.TryParse(txtTelefono.Text, out _))
            {
                txtTelefono.BackColor = Color.LightCoral;  // Cambia el color a rojo si no es numérico
            }
            else
            {
                txtTelefono.BackColor = Color.White;  // Restaura el color cuando es válido
            }
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {

            string terminoBusqueda = TxtBuscar.Text.ToLower();

            // Filtrar los contactos que contienen el término de búsqueda en el nombre, teléfono, correo o DNI
            var contactosFiltrados = contactos.Where(c =>
                c.Nombre.ToLower().Contains(terminoBusqueda) ||    // Buscar por nombre
                c.Telefono.ToLower().Contains(terminoBusqueda) ||  // Buscar por teléfono
                c.Correo.ToLower().Contains(terminoBusqueda) ||    // Buscar por correo
                c.DNI.ToLower().Contains(terminoBusqueda)          // Buscar por DNI
            ).ToList();

            // Actualizar el DataGridView con los resultados filtrados
            ActualizarDataGridView(contactosFiltrados);
        }

        // Método para actualizar el DataGridView con los contactos filtrados
        private void ActualizarDataGridView(List<Contacto> contactosParaMostrar)
        {
            // Limpiar las filas existentes en el DataGridView
            dataGridView_CellEndEdit.Rows.Clear();

            // Agregar las filas de los contactos filtrados
            foreach (var contacto in contactosParaMostrar)
            {
                dataGridView_CellEndEdit.Rows.Add(contacto.Nombre, contacto.Telefono, contacto.Correo, contacto.DNI);
            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            // Guardar la lista de contactos en el archivo JSON
            GuardarContactosEnJson();

            // Mostrar un mensaje de confirmación
            MessageBox.Show("Los cambios se han guardado correctamente.");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Verificar que el teléfono sea numérico
            if (!long.TryParse(txtTelefono.Text, out long telefono))
            {
                MessageBox.Show("El número de teléfono debe ser numérico.");
                return;
            }

            // Verificar que el DNI sea numérico
            if (!long.TryParse(txtDni.Text, out long dni))
            {
                MessageBox.Show("El DNI debe ser numérico.");
                return;
            }

            // Validación de longitud del teléfono (Ejemplo: 10 dígitos)
            if (txtTelefono.Text.Length != 10)
            {
                MessageBox.Show("El número de teléfono debe tener exactamente 10 dígitos.");
                return;
            }

            // Validación de longitud del DNI (Ejemplo: 8 dígitos)
            if (txtDni.Text.Length != 8)
            {
                MessageBox.Show("El DNI debe tener exactamente 8 dígitos.");
                return;
            }

            // Validar si los campos están vacíos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                string.IsNullOrWhiteSpace(txtDni.Text))
            {
                MessageBox.Show("Todos los campos deben ser completos.");
                return;
            }

            // Crear un nuevo contacto con los datos ingresados
            Contacto nuevoContacto = new Contacto
            {
                Nombre = txtNombre.Text,
                Telefono = txtTelefono.Text,
                Correo = txtCorreo.Text,
                DNI = txtDni.Text
            };

            // Verificar que el teléfono y el DNI sean válidos antes de agregar el contacto
            bool telefonoValido = long.TryParse(nuevoContacto.Telefono, out telefono) && nuevoContacto.Telefono.Length == 10;
            bool dniValido = long.TryParse(nuevoContacto.DNI, out dni) && nuevoContacto.DNI.Length == 8;

            if (!telefonoValido && !dniValido)
            {
                MessageBox.Show("El número de teléfono y el DNI son inválidos. No se puede agregar el contacto.");
                return;
            }

            if (!telefonoValido)
            {
                MessageBox.Show("El número de teléfono es inválido. Asegúrese de que tenga 10 dígitos.");
                return;
            }

            if (!dniValido)
            {
                MessageBox.Show("El DNI es inválido. Asegúrese de que tenga 8 dígitos.");
                return;
            }

            // Si pasa todas las validaciones, agregar el nuevo contacto a la lista interna (sin guardar en el archivo JSON)
            contactos.Add(nuevoContacto);

            // Actualizar el DataGridView
            ActualizarDataGridView();

            // Mostrar mensaje de confirmación
            MessageBox.Show("El contacto se ha agregado correctamente.");

            // Limpiar los campos de texto
            LimpiarCampos();

        }
    }
    }

