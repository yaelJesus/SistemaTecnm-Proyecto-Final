using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpreadsheetLight;
using System.Diagnostics;
using Excel = Microsoft.Office.Interop.Excel;

namespace SistemaTecnm_Proyecto_Final_
{
    public partial class FrmVerificacion : Form
    {
        public FrmVerificacion()
        {
            InitializeComponent();
        }
        string[][] x = new string[5][];
        private string departamento;
        public string Departamento
        {
            get { return departamento; }
            set { departamento = value; }
        }

        private void btnEvento2_Click(object sender, EventArgs e)
        {
            Hide();

            FrmCrearEvento frm = new FrmCrearEvento();
            frm.Responsable = departamento;
            frm.Show();
        }

        private void btnSalir3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalendario2_Click(object sender, EventArgs e)
        {
            Hide();

            FrmCalendario frm = new FrmCalendario();
            frm.Area = departamento;
            frm.Show();
        }

        private void btnCS3_Click(object sender, EventArgs e)
        {
            Hide();

            INICIOSESION frm = new INICIOSESION();

            frm.Show();
        }

        private void FrmVerificacion_Load(object sender, EventArgs e)
        {
            Lista();
        }

        public void Lista()
        {
            lvLista.Items.Clear();
            var ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta += "\\Libro 1.xlsx";
            SLDocument sl = new SLDocument(ruta);
            int r = 2;
            int n = 0;
            bool one = true;
            while (!string.IsNullOrEmpty(sl.GetCellValueAsString(r, 1)))
            {
                while (!string.IsNullOrEmpty(sl.GetCellValueAsString(r, 1)) && one)
                {
                    if (sl.GetCellValueAsString(r, 9) == "0")
                    {
                        n++;
                    }
                    r++;
                }
                if (one)
                {
                    x = new string[n][];
                    n = 0;
                    r = 2;
                    one = false;
                }
                if (sl.GetCellValueAsString(r, 9) == "0")
                {
                    string[] a = new string[8];
                    a[0] = sl.GetCellValueAsString(r, 1);
                    a[1] = sl.GetCellValueAsDateTime(r, 2).ToString("d");
                    a[2] = sl.GetCellValueAsDateTime(r, 3).ToString("t");
                    a[3] = sl.GetCellValueAsString(r, 4);
                    a[4] = sl.GetCellValueAsString(r, 5);
                    a[5] = sl.GetCellValueAsString(r, 6);
                    a[6] = sl.GetCellValueAsString(r, 7);
                    a[7] = sl.GetCellValueAsString(r, 10);
                    x[n] = a;
                    n++;
                }
                r++;
            }
            for (int i = 0; i < x.Length; i++)
            {
                ListViewItem item = new ListViewItem(x[i][0]);
                item.SubItems.Add(x[i][1]);
                item.SubItems.Add(x[i][2]);
                item.SubItems.Add(x[i][3]);
                item.SubItems.Add(x[i][4]);
                item.SubItems.Add(x[i][5]);
                item.SubItems.Add(x[i][6]);

                lvLista.Items.Add(item);
            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lvLista.Items.Count; i++)
            {
                if (x[i][0] == lvLista.FocusedItem.Text)
                {
                    string archivo = x[i][7];
                    Process.Start(archivo);
                }
            }
        }

        private void btnVerificación_Click(object sender, EventArgs e)
        {
            var ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta += "\\Libro 1.xlsx";
            SLDocument sl = new SLDocument(ruta);
            int r = 2;
            while (!string.IsNullOrEmpty(sl.GetCellValueAsString(r, 1)))
            {
                if (sl.GetCellValueAsString(r, 1) == lvLista.FocusedItem.Text)
                {
                    break;
                }
                r++;
            }

            Excel.Application ex = new Excel.Application();
            Excel.Workbook sheet = ex.Workbooks.Open(ruta);
            Excel.Worksheet x = ex.ActiveSheet as Excel.Worksheet;

            x.Cells[r, 9] = 1;

            sheet.Save();
            sheet.Close(true, Type.Missing, Type.Missing);
            ex.Quit();

            Lista();
        }
    }
}
