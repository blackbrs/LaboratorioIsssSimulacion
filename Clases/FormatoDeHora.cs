using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioIsssSimulacion.Clases
{
    class FormatoDeHora
    {
        public static string obtenerHora(int segundos)
        {
            string val = "";
            int hora = (int)Math.Floor(segundos / 3600.0);
            int minutos = (int)Math.Floor((segundos - hora * 3600) / 60.0);
            int seg = segundos - hora * 3600 - minutos * 60;

            if (hora <= 9)
            {
                val = "00" + hora.ToString();
            }
            else if (hora <= 99)
            {
                val = "0" + hora.ToString();
            }
            else
            {
                val = hora.ToString();
            }

            if (minutos <= 9)
            {
                val = val + ":0" + minutos.ToString();
            }
            else
            {
                val = val + ":" + minutos.ToString();
            }

            if (seg <= 9)
            {
                val = val + ":0" + seg.ToString();
            }
            else
            {
                val = val + ":" + seg.ToString();
            }

            return val;
        }
    }
}
