using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FormEjercicios : Form
    {
        private List<EjercicioLogica> ejercicios;
        private int ejercicioActual;

        public FormEjercicios()
        {
            InitializeComponent();
            InicializarEjercicios();
            MostrarEjercicio();
        }

        private void InicializarEjercicios()
        {
            ejercicios = new List<EjercicioLogica>
            {
                new EjercicioLogica("¿Cuál es la negación de verdadero (V)?",
                    new List<string> { "Verdadero", "Falso" }, 1),
                new EjercicioLogica("¿Cuándo es verdadera la conjunción (A ∧ B)?",
                    new List<string> { "Siempre", "Cuando ambos son verdaderos", "Cuando al menos uno es verdadero" }, 1),
                new EjercicioLogica("¿Cuándo es falsa la condicionalidad (A → B)?",
                    new List<string> { "Siempre", "Cuando A es falso y B es verdadero", "Cuando A es verdadero y B es falso" }, 2)
            };

            ejercicioActual = 0;
        }

        private void MostrarEjercicio()
        {
            if (ejercicioActual < ejercicios.Count)
            {
                var ejercicio = ejercicios[ejercicioActual];
                lblPregunta.Text = ejercicio.Pregunta;
                rdbOpcion1.Text = ejercicio.Opciones[0];
                rdbOpcion2.Text = ejercicio.Opciones[1];
                rdbOpcion3.Text = ejercicio.Opciones.Count > 2 ? ejercicio.Opciones[2] : "";
                rdbOpcion3.Visible = ejercicio.Opciones.Count > 2;
            }
            else
            {
                lblPregunta.Text = "¡Has completado todos los ejercicios!";
                btnVerificar.Enabled = false;
            }
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            var ejercicio = ejercicios[ejercicioActual];
            int respuestaUsuario = rdbOpcion1.Checked ? 0 : rdbOpcion2.Checked ? 1 : 2;

            if (ejercicio.VerificarRespuesta(respuestaUsuario))
            {
                MessageBox.Show("¡Correcto!", "Resultado");
            }
            else
            {
                MessageBox.Show($"Incorrecto. La respuesta correcta es: {ejercicio.Opciones[ejercicio.RespuestaCorrecta]}", "Resultado");
            }

            ejercicioActual++;
            MostrarEjercicio();
        }
    }
}