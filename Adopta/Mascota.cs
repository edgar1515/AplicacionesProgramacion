using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class Mascota : Persona
    {
        private String tipoAportar;
        private Double valor;

        public string TipoAportar { get => tipoAportar; set => tipoAportar = value; }
        public double Valor { get => valor; set => valor = value; }

        public void aportarAdoptar(Double aportacion)
        {
            if (this.TipoAportar == "Minima")
            {
                this.Valor = aportacion + 50;
            }
            else if (this.TipoAportar == "Maxima")
            {
                this.Valor = aportacion + 55;
            }
            else
            {
                this.Valor = 0;
            }
        }
    }
}