using System;
using System.Collections.Generic;

namespace WinFormsApp1
{
    public class EjercicioLogica
    {
        public string Pregunta { get; set; }
        public List<string> Opciones { get; set; }
        public int RespuestaCorrecta { get; set; }

        public EjercicioLogica(string pregunta, List<string> opciones, int respuestaCorrecta)
        {
            Pregunta = pregunta;
            Opciones = opciones;
            RespuestaCorrecta = respuestaCorrecta;
        }

        public bool VerificarRespuesta(int respuestaUsuario)
        {
            return respuestaUsuario == RespuestaCorrecta;
        }
    }
}