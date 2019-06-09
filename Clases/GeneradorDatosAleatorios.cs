using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics;

namespace LaboratorioIsssSimulacion.Clases
{
    class GeneradorDatosAleatorios
    {
        private Random rand = new Random();
        private double tellShape = 1.3;
        private double tellRate = 0.1317523057;
        private double tellC;
        private double tellA = 0.0;
        private double tellB = 45.0;

        private double[] pdfOpcion;
        private double[] cdfOpcion;

        private double[] mediaSer;
        private double[] desviacionserv;

        public void configTELL(double shape, double rate)
        {
            this.tellShape = shape;
            this.tellRate = rate;
            /************************************************
             *                   PASO 1:                    *
             *   SE PASA A CALCULAR EL MAXIMO DEL INTERVALO *
             *                                              *
             ************************************************/
            double max = 0.0;
            for (double i = this.tellA; i < this.tellB; i += 0.01)
            {
                double y = (Math.Pow(this.tellRate, this.tellShape) / SpecialFunctions.Gamma(this.tellShape)) * (Math.Pow(i, this.tellShape - 1.0)) * (Math.Exp(-this.tellRate * i));
                if (y > max)
                {
                    max = y;
                }
            }
            this.tellC = max;
            System.Console.WriteLine("El valor maximo que ha sido encontrado por el sistema de simulacion ha sido el siguiente: " + max.ToString());
        }
        public void configOpc(double[] p, int num_opciones)
        {
            this.pdfOpcion = new double[num_opciones];
            this.cdfOpcion = new double[num_opciones];

            for (int i = 0; i < num_opciones; i++)
            {
                this.pdfOpcion[i] = p[i];

                if (i == 0)
                {
                    this.cdfOpcion[i] = p[i];
                }
                else
                {
                    this.cdfOpcion[i] = this.cdfOpcion[i - 1] + p[i];
                }
            }
        }

        public void configTSERVMedia(double[] media, int num_opciones)
        {
            this.mediaSer = new double[num_opciones];

            for (int i = 0; i < num_opciones; i++)
            {
                this.mediaSer[i] = media[i];
            }
        }

        public void configTSERVDesviacion(double[] desviacion, int num_opciones)
        {
            this.desviacionserv = new double[num_opciones];

            for (int i = 0; i < num_opciones; i++)
            {
                this.desviacionserv[i] = desviacion[i];
            }
        }

        public double generarTELL()
        {
            double val = -1.0;
            while (val == -1.0)
            {
                double r1 = rand.NextDouble();
                double r2 = rand.NextDouble();
                double x = this.tellA + (this.tellB - this.tellA) * r1;

                if (r2 <= (1.0 / this.tellC) * ((Math.Pow(this.tellRate, this.tellShape) / SpecialFunctions.Gamma(this.tellShape)) * (Math.Pow(x, this.tellShape - 1.0)) * (Math.Exp(-this.tellRate * x))))
                {
                    val = x;
                }
            }
            return val;
        }

        public int generarOPC()
        {
            double r = rand.NextDouble();
            int val = -1;

            for (int i = this.pdfOpcion.Length - 1; i >= 0; i--)
            {
                if ((i - 1) == -1)
                {
                    val = (i + 1);
                }
                else if (r > this.cdfOpcion[i - 1] && r <= this.cdfOpcion[i])
                {
                    val = (i + 1);
                    break;
                }
            }

            System.Console.WriteLine("u = " + r.ToString() + " x = " + val.ToString());
            return val;
        }

        public double generarTSERV(int opcion)
        {
            double val = -1.0;

            int k = 30;
            double miu = this.mediaSer[opcion - 1];
            double sigma = this.desviacionserv[opcion - 1];
            double suma = 0.0;

            for (int i = 1; i <= k; i++)
            {
                suma += rand.NextDouble();
            }

            val = sigma * Math.Sqrt(12.0 / (k * 1.0)) * (suma - (k * 1.0) / 2.0) + miu;
            return val;
        }

        public Paciente generarPaciente() {
            Paciente paci = new Paciente();

            paci.opcElegida = this.generarOPC();
            paci.TEntreLlegadaMin = this.generarTELL();
            paci.TEntreLlegadaSec = (int)Math.Floor(paci.TEntreLlegadaMin * ((double)60.0));
            paci.TDeServicioMin = this.generarTSERV(paci.opcElegida);
            paci.TDeServicioSec = (int)Math.Floor(paci.TDeServicioMin * ((double)60.0));
            return paci;
        }

    }
}
