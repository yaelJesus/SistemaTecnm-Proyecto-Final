namespace SistemaTecnm_Proyecto_Final_
{
    partial class FrmVerificacion
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
            this.btnCS3 = new System.Windows.Forms.Button();
            this.btnCalendario2 = new System.Windows.Forms.Button();
            this.btnSalir3 = new System.Windows.Forms.Button();
            this.btnEvento2 = new System.Windows.Forms.Button();
            this.lvLista = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnVerificación = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCS3
            // 
            this.btnCS3.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCS3.Location = new System.Drawing.Point(595, 442);
            this.btnCS3.Name = "btnCS3";
            this.btnCS3.Size = new System.Drawing.Size(126, 32);
            this.btnCS3.TabIndex = 7;
            this.btnCS3.Text = "Cerrar Sesion";
            this.btnCS3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCS3.UseVisualStyleBackColor = true;
            this.btnCS3.Click += new System.EventHandler(this.btnCS3_Click);
            // 
            // btnCalendario2
            // 
            this.btnCalendario2.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendario2.Location = new System.Drawing.Point(179, 442);
            this.btnCalendario2.Name = "btnCalendario2";
            this.btnCalendario2.Size = new System.Drawing.Size(108, 36);
            this.btnCalendario2.TabIndex = 6;
            this.btnCalendario2.Text = "Calendario";
            this.btnCalendario2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCalendario2.UseVisualStyleBackColor = true;
            this.btnCalendario2.Click += new System.EventHandler(this.btnCalendario2_Click);
            // 
            // btnSalir3
            // 
            this.btnSalir3.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir3.Location = new System.Drawing.Point(745, 442);
            this.btnSalir3.Name = "btnSalir3";
            this.btnSalir3.Size = new System.Drawing.Size(87, 34);
            this.btnSalir3.TabIndex = 5;
            this.btnSalir3.Text = "Salir";
            this.btnSalir3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir3.UseVisualStyleBackColor = true;
            this.btnSalir3.Click += new System.EventHandler(this.btnSalir3_Click);
            // 
            // btnEvento2
            // 
            this.btnEvento2.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvento2.Location = new System.Drawing.Point(43, 442);
            this.btnEvento2.Name = "btnEvento2";
            this.btnEvento2.Size = new System.Drawing.Size(102, 36);
            this.btnEvento2.TabIndex = 4;
            this.btnEvento2.Text = "Evento";
            this.btnEvento2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEvento2.UseVisualStyleBackColor = true;
            this.btnEvento2.Click += new System.EventHandler(this.btnEvento2_Click);
            // 
            // lvLista
            // 
            this.lvLista.BackColor = System.Drawing.SystemColors.Control;
            this.lvLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvLista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvLista.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvLista.FullRowSelect = true;
            this.lvLista.HideSelection = false;
            this.lvLista.Location = new System.Drawing.Point(12, 12);
            this.lvLista.Name = "lvLista";
            this.lvLista.Size = new System.Drawing.Size(820, 350);
            this.lvLista.TabIndex = 8;
            this.lvLista.UseCompatibleStateImageBehavior = false;
            this.lvLista.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Evento";
            this.columnHeader1.Width = 215;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Fecha";
            this.columnHeader2.Width = 82;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Hora";
            this.columnHeader3.Width = 67;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Lugar";
            this.columnHeader4.Width = 142;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Cant. Part.";
            this.columnHeader5.Width = 75;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Responsable";
            this.columnHeader6.Width = 121;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Encargado";
            this.columnHeader7.Width = 115;
            // 
            // btnAbrir
            // 
            this.btnAbrir.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrir.Location = new System.Drawing.Point(92, 368);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(124, 36);
            this.btnAbrir.TabIndex = 9;
            this.btnAbrir.Text = "Abrir Archivo";
            this.btnAbrir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnVerificación
            // 
            this.btnVerificación.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificación.Location = new System.Drawing.Point(222, 368);
            this.btnVerificación.Name = "btnVerificación";
            this.btnVerificación.Size = new System.Drawing.Size(108, 36);
            this.btnVerificación.TabIndex = 10;
            this.btnVerificación.Text = "Verificar";
            this.btnVerificación.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVerificación.UseVisualStyleBackColor = true;
            this.btnVerificación.Click += new System.EventHandler(this.btnVerificación_Click);
            // 
            // FrmVerificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 488);
            this.ControlBox = false;
            this.Controls.Add(this.btnVerificación);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.lvLista);
            this.Controls.Add(this.btnCS3);
            this.Controls.Add(this.btnCalendario2);
            this.Controls.Add(this.btnSalir3);
            this.Controls.Add(this.btnEvento2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmVerificacion";
            this.Text = "VERIFICACION";
            this.Load += new System.EventHandler(this.FrmVerificacion_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCS3;
        private System.Windows.Forms.Button btnCalendario2;
        private System.Windows.Forms.Button btnSalir3;
        private System.Windows.Forms.Button btnEvento2;
        private System.Windows.Forms.ListView lvLista;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnVerificación;
    }
}