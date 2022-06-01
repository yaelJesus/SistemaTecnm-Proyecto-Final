using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpreadsheetLight;

namespace SistemaTecnm_Proyecto_Final_
{
    public partial class FrmCalendario : Form
    {
        int month, year;
        public FrmCalendario()
        {
            InitializeComponent();
        }
        private string area;

        public string Area
        {
            get { return area; }
            set { area = value; }
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEvento_Click(object sender, EventArgs e)
        {
            Hide();

            FrmCrearEvento frm = new FrmCrearEvento();
            frm.Responsable = area;
            frm.Show();
        }

        private void btnVerificacion_Click(object sender, EventArgs e)
        {
            if (area == "Boss")
            {
                Hide();

                FrmVerificacion frm = new FrmVerificacion();
                frm.Departamento = area;
                frm.Show();
            }
            else
            {
                MessageBox.Show("No cuenta con los permisos necesarios", "TECNM", MessageBoxButtons.OK);
            }
        }

        private void FrmCalendario_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            displaDays();
        }

        private void displaDays()
        {
            var ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta += "\\Libro 1.xlsx";
            SLDocument sl = new SLDocument(ruta);
            int r = 2;
            if (month == 0)
            {
                month = 12;
                year--;
            }
            if (month == 13)
            {
                month = 1;
                year++;
            }
            DayContainer.Controls.Clear();
            String nombremes = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbmes.Text = nombremes + " "  + year;
            DateTime iniciodelmes = new DateTime(year, month, 1);
            int dias = DateTime.DaysInMonth(year, month);
            int diasdesemana = Convert.ToInt32(iniciodelmes.DayOfWeek.ToString("d")) + 1;
            for (int i = 1; i < diasdesemana; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                DayContainer.Controls.Add(ucblank);
            }
            for (int i = 1; i <= dias; i++)
            {
                UserControlDias ucdias = new UserControlDias();
                ucdias.dias(i);
                if (i == 15 || i == 30 || DateTime.IsLeapYear(year) && month == 2 && i == 29 || !DateTime.IsLeapYear(year) && month == 2 && i == 28)
                {
                    ucdias.BackColor = Color.LawnGreen;
                    ucdias.label1.Text = "NOMINA";
                }
                DateTime fecha = sl.GetCellValueAsDateTime(r, 2);
                if (i == fecha.Day && month == fecha.Month)
                {
                    if (sl.GetCellValueAsString(r, 9) == "1")
                    {
                        if (sl.GetCellValueAsString(r,6) == "Area Academica")
                        {
                            ucdias.BackColor = Color.IndianRed;
                            ucdias.label1.Text = sl.GetCellValueAsString(r, 1);
                        }
                        if (sl.GetCellValueAsString(r, 6) == "Area Financiera")
                        {
                            ucdias.BackColor = Color.LawnGreen;
                            ucdias.label1.Text = sl.GetCellValueAsString(r, 1);
                        }
                        if(sl.GetCellValueAsString(r, 6) == "Area de Planeacion")
                        {
                            ucdias.BackColor = Color.Indigo;
                            ucdias.label1.Text = sl.GetCellValueAsString(r, 1);
                        }
                        if (sl.GetCellValueAsString(r, 6) == "Directivo")
                        {
                            ucdias.BackColor = Color.DimGray;
                            ucdias.label1.Text = sl.GetCellValueAsString(r, 1);
                        }
                    }
                    r++;
                }
                DayContainer.Controls.Add(ucdias);
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            month--;
            displaDays();
        }

        private void btnCS_Click(object sender, EventArgs e)
        {
            Hide();

            INICIOSESION frm = new INICIOSESION();

            frm.Show();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            month++;
            displaDays();
        }
    }
}
