using LaboratorioIsssSimulacion.Clases;
using System;
using System.Collections;
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
    public partial class formularioSimulacion : Form
    {

        // Variables de almacenamiento de datos
        List<double> t_entre_llegadas = new List<double>();
        List<double> t_en_cola = new List<double>();
        List<double> t_en_sistema = new List<double>();
        List<ArrayList> t_servicio = new List<ArrayList>();

        List<Servidor> servidores = new List<Servidor>();
        List<Paciente> clientes_en_cola = new List<Paciente>();

        Paciente siguiente_Paciente;
        GeneradorDatosAleatorios generadorAleatorio = new GeneradorDatosAleatorios();
        int MC = 0;
        int MENOR_MOMENTO_SIGUIENTE;
        int numero_servidores;

        public formularioSimulacion()
        {
            InitializeComponent();

            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.HeaderText = "Servidor / Laboratorista ";
            gridServidoresDisponibles.Columns.Add(col);

            col = new DataGridViewTextBoxColumn();
            col.HeaderText = "Terminacion";
            gridServidoresDisponibles.Columns.Add(col);

            col = new DataGridViewTextBoxColumn();
            col.HeaderText = "Estado ";
            gridServidoresDisponibles.Columns.Add(col);
        }

        private void FormularioSimulacion_Load(object sender, EventArgs e)
        {

        }

      

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
