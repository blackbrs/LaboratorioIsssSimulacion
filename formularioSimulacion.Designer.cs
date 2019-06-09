namespace LaboratorioIsssSimulacion
{
    partial class formularioSimulacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumeroServidores = new System.Windows.Forms.TextBox();
            this.gridServidoresDisponibles = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TellShape = new System.Windows.Forms.TextBox();
            this.TellRate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.txtDesviacion = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblMC = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblSiguientePaciente = new System.Windows.Forms.Label();
            this.timerStepSimulacion = new System.Windows.Forms.Timer(this.components);
            this.txtEventos = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.contPaciente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridServidoresDisponibles)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(174, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(700, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Simulación Del Laboratorio Clínico del Policlínico Zacamil";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Servidores (Laboratoristas Atendiendo):";
            // 
            // NumeroServidores
            // 
            this.NumeroServidores.Location = new System.Drawing.Point(245, 68);
            this.NumeroServidores.Name = "NumeroServidores";
            this.NumeroServidores.Size = new System.Drawing.Size(100, 20);
            this.NumeroServidores.TabIndex = 2;
            // 
            // gridServidoresDisponibles
            // 
            this.gridServidoresDisponibles.AllowUserToAddRows = false;
            this.gridServidoresDisponibles.AllowUserToDeleteRows = false;
            this.gridServidoresDisponibles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridServidoresDisponibles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.gridServidoresDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridServidoresDisponibles.Location = new System.Drawing.Point(384, 68);
            this.gridServidoresDisponibles.Name = "gridServidoresDisponibles";
            this.gridServidoresDisponibles.ReadOnly = true;
            this.gridServidoresDisponibles.Size = new System.Drawing.Size(585, 202);
            this.gridServidoresDisponibles.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 666);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Iniciar Simulacion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(335, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Opciones De Datos De La Simulacion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Forma :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Proporción:";
            // 
            // TellShape
            // 
            this.TellShape.Location = new System.Drawing.Point(59, 152);
            this.TellShape.Name = "TellShape";
            this.TellShape.Size = new System.Drawing.Size(100, 20);
            this.TellShape.TabIndex = 8;
            // 
            // TellRate
            // 
            this.TellRate.Location = new System.Drawing.Point(253, 152);
            this.TellRate.Name = "TellRate";
            this.TellRate.Size = new System.Drawing.Size(100, 20);
            this.TellRate.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(136, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tiempos De Llegada";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(42, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(303, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Tiempos De Servicio (Extraccion de Sangre) TSERV";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 225);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Media:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(177, 228);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Desviación:";
            // 
            // txtMedia
            // 
            this.txtMedia.Location = new System.Drawing.Point(58, 225);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(100, 20);
            this.txtMedia.TabIndex = 16;
            // 
            // txtDesviacion
            // 
            this.txtDesviacion.Location = new System.Drawing.Point(253, 225);
            this.txtDesviacion.Name = "txtDesviacion";
            this.txtDesviacion.Size = new System.Drawing.Size(100, 20);
            this.txtDesviacion.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(42, 271);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 18);
            this.label12.TabIndex = 18;
            this.label12.Text = "MC:";
            // 
            // lblMC
            // 
            this.lblMC.AutoSize = true;
            this.lblMC.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMC.Location = new System.Drawing.Point(12, 315);
            this.lblMC.Name = "lblMC";
            this.lblMC.Size = new System.Drawing.Size(100, 22);
            this.lblMC.TabIndex = 19;
            this.lblMC.Text = "000:00:00";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(145, 271);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(228, 15);
            this.label14.TabIndex = 20;
            this.label14.Text = "Siguiente Paciente A ser Atendido:";
            // 
            // lblSiguientePaciente
            // 
            this.lblSiguientePaciente.AutoSize = true;
            this.lblSiguientePaciente.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSiguientePaciente.Location = new System.Drawing.Point(206, 315);
            this.lblSiguientePaciente.Name = "lblSiguientePaciente";
            this.lblSiguientePaciente.Size = new System.Drawing.Size(100, 22);
            this.lblSiguientePaciente.TabIndex = 21;
            this.lblSiguientePaciente.Text = "000:00:00";
            // 
            // timerStepSimulacion
            // 
            this.timerStepSimulacion.Interval = 1000;
            this.timerStepSimulacion.Tick += new System.EventHandler(this.TimerStepSimulacion_Tick);
            // 
            // txtEventos
            // 
            this.txtEventos.Location = new System.Drawing.Point(26, 367);
            this.txtEventos.Multiline = true;
            this.txtEventos.Name = "txtEventos";
            this.txtEventos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEventos.Size = new System.Drawing.Size(924, 293);
            this.txtEventos.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(395, 338);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 16);
            this.label13.TabIndex = 23;
            this.label13.Text = "Diario De Eventos.";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(161, 666);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Terminar Simulacion";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(312, 666);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "Limpiar Diario De Eventos";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(11, 289);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 22);
            this.label15.TabIndex = 26;
            this.label15.Text = "*HH:MM:SS";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(206, 289);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 22);
            this.label16.TabIndex = 27;
            this.label16.Text = "*HH:MM:SS";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(486, 666);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(196, 23);
            this.button4.TabIndex = 28;
            this.button4.Text = "Guardar en un txt el diario de eventos";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(608, 273);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(145, 15);
            this.label17.TabIndex = 29;
            this.label17.Text = "Pacientes Atendidos :";
            // 
            // contPaciente
            // 
            this.contPaciente.AutoSize = true;
            this.contPaciente.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contPaciente.Location = new System.Drawing.Point(662, 315);
            this.contPaciente.Name = "contPaciente";
            this.contPaciente.Size = new System.Drawing.Size(20, 22);
            this.contPaciente.TabIndex = 30;
            this.contPaciente.Text = "0";
            // 
            // formularioSimulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 701);
            this.Controls.Add(this.contPaciente);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtEventos);
            this.Controls.Add(this.lblSiguientePaciente);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblMC);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtDesviacion);
            this.Controls.Add(this.txtMedia);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TellRate);
            this.Controls.Add(this.TellShape);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gridServidoresDisponibles);
            this.Controls.Add(this.NumeroServidores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formularioSimulacion";
            this.Text = "Simulacion Laboratorio Clinico";
            this.Load += new System.EventHandler(this.FormularioSimulacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridServidoresDisponibles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NumeroServidores;
        private System.Windows.Forms.DataGridView gridServidoresDisponibles;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TellShape;
        private System.Windows.Forms.TextBox TellRate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.TextBox txtDesviacion;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblMC;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblSiguientePaciente;
        private System.Windows.Forms.Timer timerStepSimulacion;
        private System.Windows.Forms.TextBox txtEventos;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label contPaciente;
    }
}