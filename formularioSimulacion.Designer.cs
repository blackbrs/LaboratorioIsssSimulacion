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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumeroServidores = new System.Windows.Forms.TextBox();
            this.gridServidoresDisponibles = new System.Windows.Forms.DataGridView();
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
            this.label1.Text = "Simulacion Del Laboratorio Clinico del Policlinico Zacamil";
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
            this.label2.Click += new System.EventHandler(this.Label2_Click);
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
            this.gridServidoresDisponibles.Size = new System.Drawing.Size(490, 150);
            this.gridServidoresDisponibles.TabIndex = 3;
            // 
            // formularioSimulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 498);
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
    }
}