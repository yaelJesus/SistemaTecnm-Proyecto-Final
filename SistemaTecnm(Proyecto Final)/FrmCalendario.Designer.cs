namespace SistemaTecnm_Proyecto_Final_
{
    partial class FrmCalendario
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
            this.btnCS = new System.Windows.Forms.Button();
            this.btnVerificacion = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEvento = new System.Windows.Forms.Button();
            this.DayContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbmes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCS
            // 
            this.btnCS.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCS.Location = new System.Drawing.Point(580, 528);
            this.btnCS.Name = "btnCS";
            this.btnCS.Size = new System.Drawing.Size(131, 34);
            this.btnCS.TabIndex = 7;
            this.btnCS.Text = "Cerrar Sesion";
            this.btnCS.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCS.UseVisualStyleBackColor = true;
            this.btnCS.Click += new System.EventHandler(this.btnCS_Click);
            // 
            // btnVerificacion
            // 
            this.btnVerificacion.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificacion.Location = new System.Drawing.Point(156, 528);
            this.btnVerificacion.Name = "btnVerificacion";
            this.btnVerificacion.Size = new System.Drawing.Size(108, 34);
            this.btnVerificacion.TabIndex = 6;
            this.btnVerificacion.Text = "Verificacion";
            this.btnVerificacion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVerificacion.UseVisualStyleBackColor = true;
            this.btnVerificacion.Click += new System.EventHandler(this.btnVerificacion_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(730, 528);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(87, 34);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEvento
            // 
            this.btnEvento.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvento.Location = new System.Drawing.Point(18, 528);
            this.btnEvento.Name = "btnEvento";
            this.btnEvento.Size = new System.Drawing.Size(101, 34);
            this.btnEvento.TabIndex = 4;
            this.btnEvento.Text = "Evento";
            this.btnEvento.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEvento.UseVisualStyleBackColor = true;
            this.btnEvento.Click += new System.EventHandler(this.btnEvento_Click);
            // 
            // DayContainer
            // 
            this.DayContainer.Location = new System.Drawing.Point(12, 61);
            this.DayContainer.Name = "DayContainer";
            this.DayContainer.Size = new System.Drawing.Size(820, 461);
            this.DayContainer.TabIndex = 8;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(33, 5);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(22, 27);
            this.btnSiguiente.TabIndex = 10;
            this.btnSiguiente.Text = "🢂";
            this.btnSiguiente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.Location = new System.Drawing.Point(12, 5);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(22, 27);
            this.btnAnterior.TabIndex = 9;
            this.btnAnterior.Text = "🢀";
            this.btnAnterior.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "DOMINGO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(718, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "SABADO ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(608, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 26);
            this.label3.TabIndex = 13;
            this.label3.Text = "VIERNES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(493, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 26);
            this.label4.TabIndex = 14;
            this.label4.Text = "JUEVES";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(368, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 26);
            this.label5.TabIndex = 15;
            this.label5.Text = "MIERCOLES";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(258, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 26);
            this.label6.TabIndex = 16;
            this.label6.Text = "MARTES";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(154, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 26);
            this.label7.TabIndex = 17;
            this.label7.Text = "LUNES";
            // 
            // lbmes
            // 
            this.lbmes.AutoSize = true;
            this.lbmes.BackColor = System.Drawing.Color.Transparent;
            this.lbmes.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmes.Location = new System.Drawing.Point(368, 6);
            this.lbmes.Name = "lbmes";
            this.lbmes.Size = new System.Drawing.Size(125, 26);
            this.lbmes.TabIndex = 18;
            this.lbmes.Text = "MES DEL AÑO";
            // 
            // FrmCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 568);
            this.ControlBox = false;
            this.Controls.Add(this.lbmes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.DayContainer);
            this.Controls.Add(this.btnCS);
            this.Controls.Add(this.btnVerificacion);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEvento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmCalendario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CALENDARIO";
            this.Load += new System.EventHandler(this.FrmCalendario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCS;
        private System.Windows.Forms.Button btnVerificacion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEvento;
        private System.Windows.Forms.FlowLayoutPanel DayContainer;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbmes;
    }
}