using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*************************************************************
 *                  CLASE SERVIDOR                           * 
 *        Clase que servira para crear los servidores        *
 *        que en la simulacion estaran representando         * 
 *        a los especialistas que toman las muestras de      *
 *        sangre en el laboratorio clinico.                  *
 *************************************************************/
namespace LaboratorioIsssSimulacion.Clases
{
    class Servidor
    {
        public int TFinServicio = -1;
        public string TFinServicioStr = "000:00:00";
        public int OpcATendiendo = -1;
        public int NumServidor = -1;

        public string EstServidor = "LIBRE";

        public Paciente PacienteAtendido = null;

        public void atenderPaciente(Paciente p)
        {
            this.PacienteAtendido = p;
            this.EstServidor = "OCUPADO";
            this.TFinServicio = p.TFinServicio;
            this.TFinServicioStr = FormatoDeHora.obtenerHora(this.TFinServicio);
            this.OpcATendiendo = p.opcElegida;
        }

        public Paciente terminarServicio()
        {
            Paciente p = this.PacienteAtendido;
            this.EstServidor = "LIBRE";
            this.TFinServicio = -1;
            this.TFinServicioStr = "000:00:00";
            this.PacienteAtendido = null;
            this.OpcATendiendo = -1;
            return p;
        }
    }
}
