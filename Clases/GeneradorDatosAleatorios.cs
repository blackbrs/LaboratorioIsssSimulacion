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
        private double tellB= 45.0;

        private double[] pdfOpcion;
        private double[] cdfOpcion;

        private double[] mediaSer;
        private double[] desviacionserv;

        public void configTELL(double shape, double rate)
        {
            this.tellShape  = shape;
            this.tellRate   = rate;
            /************************************************
             *                   PASO 1:                    *
             *   SE PASA A CALCULAR EL MAXIMO DEL INTERVALO *
             *                                              *
             ************************************************/
            double max = 0.0;
            for (double i = this.tellA; i < this.tellB; i +=0.01)
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
    }
}
