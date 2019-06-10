using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Clase paciente que representa
   los paciente a tomar muestras 
   de sangre y como constructor 
   de objetos.
 */
namespace LaboratorioIsssSimulacion.Clases
{
    class Paciente
    {
        /* Variables de uso*/
        public int opcElegida;

        public double TEntreLlegadaMin;//Tiempo  de llegada en minutos
        public int TEntreLlegadaSec;// tiempo entre llegadas segundos
        public int TDeLlegada;//Tiempo de llegada

        public double TDeServicioMin;//Tiempo de servicio (minutos)
        public int TDeServicioSec;//Tiempo de servicio (segundos)

        public int TLlegadaCola;
        public int TSalidaCola;

        public int TInicioServicio;
        public int TFinServicio;


    }
}
