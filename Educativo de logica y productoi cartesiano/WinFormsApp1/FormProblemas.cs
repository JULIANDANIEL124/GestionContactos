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
    public partial class FormProblemas : Form
    {
        private List<string> ejercicios;
        private List<HashSet<string>> soluciones; // Usaremos un HashSet para comparar conjuntos sin importar el orden.
        private int indiceActual;

        public FormProblemas()
        {
            InitializeComponent();
            InitializeComponent();
            InicializarEjercicios();
            MostrarEjercicioActual();
        }

        private void InicializarEjercicios()
        {
            // Lista de ejercicios y sus soluciones como conjuntos de pares.
            ejercicios = new List<string>
        {
            "Dado A = {1, 2} y B = {x, y}, ¿cuál es el producto cartesiano A × B?",
            "Dado A = {3, 4} y B = {a, b}, ¿cuál es el producto cartesiano A × B?",
            "Dado A = {p, q} y B = {r, s}, ¿cuál es el producto cartesiano A × B?"
        };

            soluciones = new List<HashSet<string>>
        {
            new HashSet<string> { "(1,x)", "(1,y)", "(2,x)", "(2,y)" },
            new HashSet<string> { "(3,a)", "(3,b)", "(4,a)", "(4,b)" },
            new HashSet<string> { "(p,r)", "(p,s)", "(q,r)", "(q,s)" }
        };

            indiceActual = 0; // Comenzamos con el primer ejercicio.
        }

        private void MostrarEjercicioActual()
        {
            if (indiceActual < ejercicios.Count)
            {
                lblProblema.Text = ejercicios[indiceActual];
                txtRespuesta.Clear(); // Limpia el campo de respuesta.
            }
            else
            {
                MessageBox.Show("¡Has completado todos los ejercicios! 🎉", "Fin");
                this.Close(); // Cierra el formulario si ya no hay más ejercicios.
            }
        }

        private void lblProblema_Click(object sender, EventArgs e)
        {

        }

        private void lblInstruccion_Click(object sender, EventArgs e)
        {

        }

        private void txtrRespuesta_TextChanged(object sender, EventArgs e)
        {

        }
        private void VerificarRespuesta_Click(object sender, EventArgs e)
        {
            string respuestaUsuario = txtRespuesta.Text.Trim();

            if (EsRespuestaCorrecta(respuestaUsuario))
            {
                MessageBox.Show("Respuesta incorrecta. Intenta nuevamente.", "Resultado");
            }
            else
            {
               
                MessageBox.Show("¡Correcto! 😊", "Resultado");
                indiceActual++; // Avanza al siguiente ejercicio.
                MostrarEjercicioActual();
            }
        }

        private bool EsRespuestaCorrecta(string respuestaUsuario)
        {
            // Normaliza la respuesta del usuario.
            HashSet<string> respuestaNormalizada = NormalizarRespuesta(respuestaUsuario);
            HashSet<string> solucionCorrecta = soluciones[indiceActual];

            // Depuración: mostrar los valores que se comparan.
            Console.WriteLine("Respuesta Usuario: " + string.Join(", ", respuestaNormalizada));
            Console.WriteLine("Solución Correcta: " + string.Join(", ", solucionCorrecta));

            // Compara los conjuntos.
            return respuestaNormalizada.SetEquals(solucionCorrecta);
        }

        private HashSet<string> NormalizarRespuesta(string respuesta)
        {
            // Limpia la respuesta del usuario y convierte a un conjunto de pares.
            var elementos = respuesta
                .Replace(" ", "")           // Elimina espacios en blanco.
                .Replace("{", "")           // Elimina llaves de apertura.
                .Replace("}", "")           // Elimina llaves de cierre.
                .Split(new[] { ")," }, StringSplitOptions.RemoveEmptyEntries) // Divide por cierre de par.
                .Select(p => p.Trim('(', ')') + ")") // Asegura formato "(a,b)".
                .ToHashSet();               // Convierte a HashSet para comparación.

            return elementos;
        }
    }

}
    


