using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;

namespace Adopta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnRegistro_Click(object sender, EventArgs e)
        {
            Mascota mascota1 = new Mascota();
            mascota1.Apellidos = txtApellido.Text;
            mascota1.Nombre = txtNombre.Text;
            mascota1.Tipo = cboTipo.Text;
            mascota1.Registro = txtRegistro.Text;
            mascota1.TipoAportar = cboTipoAportar.Text;

            mascota1.aportarAdoptar(30);

            dgtDatos.Rows.Insert(0,mascota1.Tipo,mascota1.Apellidos,mascota1.Nombre,mascota1.Registro,mascota1.Valor);
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }
    }
}
