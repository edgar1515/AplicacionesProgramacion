using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class Persona
    {
        private String nombre;
        private String apellidos;
        private String registro;
        private String tipo;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Registro { get => registro; set => registro = value; }
        public string Tipo { get => tipo; set => tipo = value; }
    }
}
