using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class Centro : Persona
    {
        private String categoria;
        private String codigo;

        public string Categoria { get => categoria; set => categoria = value; }
        public string Codigo { get => codigo; set => codigo = value; }

        public void generarCodigo()
        {
            this.Codigo = "C" + this.Apellidos.Substring(0, 3) + "16";
        }
    }
}