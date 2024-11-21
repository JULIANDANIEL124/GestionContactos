using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FormProductoCartesiano : Form
    {
        public FormProductoCartesiano()
        {
            InitializeComponent();
            CargarExplicacion();
        }
        private void CargarExplicacion()
        {
            lblExplicacion.Text = "Producto Cartesiano: Es el conjunto de todos los pares ordenados posibles entre dos conjuntos A y B.\n" +
                          "Por ejemplo, si A = {1, 2} y B = {x, y}, el producto cartesiano A × B = {(1, x), (1, y), (2, x), (2, y)}.\n" +
                          "Sirve para modelar relaciones entre elementos de dos conjuntos, definir puntos en un plano cartesiano, matrices y funciones.\n" +
                          "Propiedades principales:\n" +
                          "- Distributividad respecto a la unión: (A ∪ B) × C = (A × C) ∪ (B × C)\n" +
                          "- Asociatividad: (A × B) × C es equivalente a A × (B × C).\n";

            lblEjemplo.Text = "Ejemplos:\n" +
                              "1. A = {1, 2, 3}, B = {a, b}\n" +
                              "   A × B = {(1, a), (1, b), (2, a), (2, b), (3, a), (3, b)}\n\n" +
                              "2. Con números enteros:\n" +
                              "   Z × Z = {(0,0), (0,1), (0,-1), (1,0), (-1,0), ...}";

            lblAplicaciones.Text = "Aplicaciones:\n" +
                                   "- Representación de puntos en el plano cartesiano.\n" +
                                   "- Creación de tablas de verdad en lógica matemática.\n" +
                                   "- Definición de funciones en matemáticas.\n" +
                                   "- Representación de relaciones entre conjuntos.\n" +
                                   "- Construcción de matrices para cálculos en álgebra lineal.";
        
    }
        private void btnProblemas_Click(object sender, EventArgs e)
        {
            FormProblemas formProblemas = new FormProblemas();
            formProblemas.ShowDialog(); // Abre el formulario de Problemas.
        }

        private void lblExplicacion_Click(object sender, EventArgs e)
        {

        }

        private void lblEjemplo_Click(object sender, EventArgs e)
        {

        }
    }
   
}
 

