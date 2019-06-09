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
using System.IO;

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
        List<Paciente> Pacientes_en_cola = new List<Paciente>();

        Paciente siguiente_Paciente;
        GeneradorDatosAleatorios generadorAleatorio = new GeneradorDatosAleatorios();
        int MC = 0;
        int MENOR_MOMENTO_SIGUIENTE;
        int numero_servidores;
        int contador = 0;
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
            NumeroServidores.Text = "3";
            TellShape.Text        = "1.54785";
            TellRate.Text         = "0.1715263057";
            txtMedia.Text         = "5.3404";
            txtDesviacion.Text    = "1.0345";
        }

      


        private void Button1_Click(object sender, EventArgs e)
        {
            // Paso 1: Eliminar todos los datos de simulaciones pasadas
            this.t_entre_llegadas.Clear();
            this.t_servicio.Clear();
            this.servidores.Clear();
            this.Pacientes_en_cola.Clear();
            this.siguiente_Paciente = null;
            this.MC = 0;
            this.MENOR_MOMENTO_SIGUIENTE = 0;

            // Paso 2: Extraer el numero de servidores y reflejar en DataGrid
            gridServidoresDisponibles.Rows.Clear();
            this.numero_servidores = int.Parse(NumeroServidores.Text);
            for (int i = 0; i < this.numero_servidores; i++)
            {
                Servidor s = new Servidor();
                servidores.Add(s);
                s.NumServidor = i + 1;

                //SE INICIALIZA EL DATAGRID
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(gridServidoresDisponibles);
                row.Cells[0].Value = i + 1;
                row.Cells[1].Value = "-";
                row.Cells[2].Value = "LIBRE";
                gridServidoresDisponibles.Rows.Add(row);
            }

          for (int i = 0; i < 7; i++)
           {
             t_servicio.Add(new ArrayList());
           }

                /*************************************************
                *   SE INICIA LA CONFIGURACION DE LAS VARIABLES  *
                **************************************************/
                double shape = Double.Parse(TellShape.Text);
                double rate = Double.Parse(TellRate.Text);
                generadorAleatorio.configTELL(shape, rate);

                double[] probabilidades = { Double.Parse(TellRate.Text) };
                generadorAleatorio.configExtraccion(probabilidades, probabilidades.Length);

                double[] medias = { Double.Parse(txtMedia.Text)};
                generadorAleatorio.configTSERVMedia(medias, medias.Length);

                double[] desviaciones = { Double.Parse(txtDesviacion.Text)};
                generadorAleatorio.configTSERVDesviacion(desviaciones, desviaciones.Length);

            /***************************************************************************
             *      Para que la simulacion empiece su corrida
             *      Primero se tiene que generar al primer paciente
             *      que sera atendido, se agrega la informacion respectivaen que este 
             *      llegara y lo dejamos en nuevo paciente en espera
             ****************************************************************************/

            Paciente p = generadorAleatorio.generarPaciente();
            p.TDeLlegada = this.MC + p.TEntreLlegadaSec;
            this.siguiente_Paciente = p;

            //SE COLOCA LA INFO EN EL LABEL
            this.MENOR_MOMENTO_SIGUIENTE = p.TDeLlegada;
            lblSiguientePaciente.Text = FormatoDeHora.obtenerHora(p.TDeLlegada);
            timerStepSimulacion.Enabled = true;

        }


        private void registrarEvento(string texto)
        {
            this.txtEventos.Text = this.txtEventos.Text + texto;
        }

        private bool hayPacientesEnCola()
        {

            if (this.Pacientes_en_cola.Count > 0)
            {
                return true;
            }
            return false;
        }
        private bool hayServidoresDisponibles()
        {
            for (int i = 0; i < this.servidores.Count; i++)
            {
                if (this.servidores[i].EstServidor == "LIBRE")
                {
                    return true;
                }
            }
            return false;
        }

        private Servidor obtenerServidorDisponible()
        {
            Servidor s = null;
            for (int i = 0; i < this.servidores.Count; i++)
            {
                if (this.servidores[i].EstServidor == "LIBRE")
                {
                    s = this.servidores[i];
                    break;
                }
            }
            return s;
        }

        private void stepSimulacion() {

            NumeroServidores.Enabled = false;
            TellRate.Enabled = false;
            TellShape.Enabled = false;
            txtDesviacion.Enabled = false;
            txtMedia.Enabled = false;
            txtEventos.Enabled = false;
            
            
            
            // Paso 1: avanzar MC al menor momento, reflejar el cambio
            this.MC = this.MENOR_MOMENTO_SIGUIENTE;
            lblMC.Text = FormatoDeHora.obtenerHora(this.MC);
          
            // Paso 2: verificamos si un cliente ha llegado a la cola
            if (this.MC == siguiente_Paciente.TDeLlegada)
            {
                this.contador++;
                contPaciente.Text = this.contador.ToString();
                // De ser asi, agregamos el cliente a la cola, y le calculamos la hora 
                // En que este cliente ha llegado
                this.siguiente_Paciente.TLlegadaCola = this.MC;
                this.Pacientes_en_cola.Add(this.siguiente_Paciente);

                // Y generamos el nuevo cliente y le calculamos si tiempo de llegada
                Paciente c = generadorAleatorio.generarPaciente();
                c.TDeLlegada = this.MC + c.TEntreLlegadaSec;
                lblSiguientePaciente.Text = FormatoDeHora.obtenerHora(c.TDeLlegada);
                this.siguiente_Paciente = c;



                // Registramos evento
                
                this.registrarEvento("********************************************************************************************************************************************************************************************************************************\r\n");
                this.registrarEvento("MC = " + FormatoDeHora.obtenerHora(this.MC) + " Ha llegado un nuevo Paciente a la cola del laboratorio\r\n");
               
            }
            
            // Paso 3: Verificamos cuales son los servidores cuya fecha de fin de servicio es igual a MC
            // y ejecutamos passo respectivos
            for (int i = 0; i < this.servidores.Count; i++)
            {
                Servidor s = this.servidores[i];

                if (s.TFinServicio == this.MC)
                {
                    
                    Paciente c = s.terminarServicio();

                    // Empezamos a realizar calculos de tiempo en cola, tiempo en sistema
                    int tiempo_en_cola_seg = c.TLlegadaCola - c.TSalidaCola;
                    double tiempo_en_cola_min = tiempo_en_cola_seg / 60.0;

                    // Agregamos calculos
                    this.t_en_cola.Add(tiempo_en_cola_min);
                    this.t_en_sistema.Add(tiempo_en_cola_min + c.TDeServicioMin);
                    this.t_entre_llegadas.Add(c.TEntreLlegadaMin);
                    // this.t_servicio[c.OPCION_ELEGIDA - 1].Add(c.TIEMPO_DE_SERVICIO_MIN);
                 
                    this.registrarEvento("MC = " + FormatoDeHora.obtenerHora(this.MC) + " Especialista= " + s.NumServidor + " Ha terminado la extracion de sangre .\r\n");
                    this.registrarEvento("********************************************************************************************************************************************************************************************************************************\r\n");
                    
                }
                
            }

            // Paso 4: Si hay nuevos clientes y servidores disponibles, ejecutamos acciones respectivas
            while (this.hayPacientesEnCola() && this.hayServidoresDisponibles())
            {
                // Obtenemos el primer cliente, registramos su hora de salida de la cola
                // Su hora de inicio de servicio
                Paciente c = this.Pacientes_en_cola.First();
                c.TSalidaCola = this.MC;
                c.TInicioServicio = this.MC;
                c.TFinServicio = this.MC + c.TDeServicioSec;

                // Asignamos cliente a servidor, y registramos metadata a servidor
                Servidor s = this.obtenerServidorDisponible();
                s.atenderPaciente(c);

                // Eliminando cliente de la cola
                this.Pacientes_en_cola.RemoveAt(0);

                // Registrando accion respectiva
                this.registrarEvento("MC = " + FormatoDeHora.obtenerHora(this.MC) + "  El paciente ha salido de la cola y ha empezado a ser atendido por el especialista del laboratorio =" + s.NumServidor.ToString() + " Tiempo de fin de la toma de la muestra: " + FormatoDeHora.obtenerHora(c.TFinServicio)+ "\r\n");
               
            }

            // Paso 5; avanzamos MC al menor momento esperado
            // Supocicion: el tiempo entre llegada es el menor MC esperado
            int MENOR_MOMENTO = this.siguiente_Paciente.TDeLlegada;

            for (int i = 0; i < this.servidores.Count; i++)
            {
                Servidor s = this.servidores[i];
                if (s.EstServidor == "OCUPADO" && s.TFinServicio < MENOR_MOMENTO)
                {
                    MENOR_MOMENTO = s.TFinServicio;
                }
            }
            this.MENOR_MOMENTO_SIGUIENTE = MENOR_MOMENTO;

            // Paso 6: Reflejar todos los cambios de la simulacion en la GUI
            // Reflejar el estado de los servidores
            for (int i = 0; i < gridServidoresDisponibles.Rows.Count; i++)
            {
             
                gridServidoresDisponibles.Rows[i].Cells[1].Value = this.servidores[i].TFinServicioStr;
                gridServidoresDisponibles.Rows[i].Cells[2].Value = this.servidores[i].EstServidor;
              
            }
            
        }

        private void TimerStepSimulacion_Tick(object sender, EventArgs e)
        {
           this.stepSimulacion();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            timerStepSimulacion.Stop();
            gridServidoresDisponibles.Rows.Clear();
            NumeroServidores.Enabled = true;
            TellRate.Enabled = true;
            TellShape.Enabled = true;
            txtDesviacion.Enabled = true;
            txtMedia.Enabled = true;
            txtEventos.Enabled = true;
            

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.txtEventos.Clear();
            contPaciente.Text = "0";
            this.contador = 0;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            String numero = "";
            mensaje = this.txtEventos.Text;
            numero = this.contPaciente.Text;
            StreamWriter sw = new StreamWriter("Test.txt");
            sw.WriteLine(mensaje);
            sw.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            sw.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            sw.WriteLine("                                                        PACIENTES ATENDIDOS EN EL LABORATORIO CLINICO DURANTE LA SIMULACION                                             ");
            sw.WriteLine("                                                                                "+numero+"                                                                                ");
            sw.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            sw.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            sw.Close();
        }
    }
}
