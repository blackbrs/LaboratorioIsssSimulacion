using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratorioIsssSimulacion
{
    public partial class formularioPrincipal : Form
    {
        public formularioPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BotonMostrarPantallaSimulacion(object sender, EventArgs e)
        {
            formularioSimulacion simulacion = new formularioSimulacion();
            simulacion.Show();
            
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }
    }
}
