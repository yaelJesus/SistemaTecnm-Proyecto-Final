using System;
using System.Drawing;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace SistemaTecnm_Proyecto_Final_
{
    public partial class FrmCrearEvento : Form
    {
        public FrmCrearEvento()
        {
            InitializeComponent();
        }
        string oficio = "";
        private string responsable;

        public string Responsable
        {
            get { return responsable; }
            set { responsable = value; }
        }


        private void FrmCrearEvento_Load(object sender, EventArgs e)
        {
            switch (responsable)
            {
                case "Area Academica":
                    comboxResp.Text = responsable;
                    break;
                case "Area Financiera":
                    comboxResp.Text = responsable; comboAcademia.Visible = false; label9.Visible = false;
                    break;
                case "Area de Planeacion":
                    comboxResp.Text = responsable; comboAcademia.Visible = false; label9.Visible = false;
                    break;
                case "Boss":
                    comboxResp.Text = "Directivo"; comboAcademia.Visible = false; label9.Visible = false;
                    break;
            }
        }

        private void btnCalendario_Click(object sender, EventArgs e)
        {
            Hide();

            FrmCalendario frm = new FrmCalendario();
            frm.Area = responsable;
            frm.Show();
        }

        private void btnVerificacion2_Click(object sender, EventArgs e)
        {
            if (responsable == "Boss")
            {
                Hide();

                FrmVerificacion frm = new FrmVerificacion();
                frm.Departamento = responsable;
                frm.Show();
            }
            else
            {
                MessageBox.Show("No cuenta con los permisos necesarios", "TECNM", MessageBoxButtons.OK);
            }
        }

        private void btnSalir2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCS2_Click(object sender, EventArgs e)
        {
            Hide();

            INICIOSESION frm = new INICIOSESION();

            frm.Show();
        }

        private void btnGuardarInfo_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || mtxtHora.Text == "" || txtLugar.Text == "" || txtCantPart.Text == "" || txtNombreDoP.Text == "" || comboAcademia.Text == "" && comboxResp.Text == "Area Académico" || oficio == "" || picboxFoto.Image == null)
            {
                MessageBox.Show("Campos faltantes por llenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                ruta += "\\Libro 1.xlsx";
                Excel.Application ex = new Excel.Application();
                Excel.Workbook sheet = ex.Workbooks.Open(ruta);
                Excel.Worksheet x = ex.ActiveSheet as Excel.Worksheet;

                Excel.Range rango = x.UsedRange;
                int registros = rango.Rows.Count;
                int add = registros + 1;

                ex.Sheets[1].cells(add, 1).value = txtNombre.Text;
                ex.Sheets[1].cells(add, 2).value = dtpFecha.Value;
                ex.Sheets[1].cells(add, 3).value = mtxtHora.Text;
                ex.Sheets[1].cells(add, 4).value = txtLugar.Text; ;
                ex.Sheets[1].cells(add, 5).value = txtCantPart.Text;
                ex.Sheets[1].cells(add, 6).value = comboxResp.Text;
                ex.Sheets[1].cells(add, 7).value = txtNombreDoP.Text;
                if (comboxResp.Text != "Area Académico")
                {
                    ex.Sheets[1].cells(add, 8).value = "N/A";
                }
                else
                {
                    ex.Sheets[1].cells(add, 8).value = comboAcademia.Text;
                }
                ex.Sheets[1].cells(add, 9).value = "0";
                ex.Sheets[1].cells(add, 10).value = oficio;

                sheet.Save();
                sheet.Close(true, Type.Missing, Type.Missing);
                ex.Quit();

                MessageBox.Show("El evento fue registrado exitosamente", "TECNM", MessageBoxButtons.OK);

                txtNombre.Text = "";
                dtpFecha.Value = DateTime.Now;
                mtxtHora.Text = "";
                txtLugar.Text = "";
                txtCantPart.Text = "";
                txtNombreDoP.Text = "";
                if (responsable == "Boss")
                {
                    comboxResp.Text = "Directivo";
                }
                else
                {
                    comboxResp.Text = responsable;
                }
                comboAcademia.Text = "";
                if (responsable == "Area Academica")
                {
                
                    comboAcademia.Visible = true;
                    label9.Visible = true;
                }
                else
                {
                    comboAcademia.Visible = false;
                    label9.Visible = false;
                }
                oficio = "";
                picboxFoto.Image = null;
            }
        }   

        private void comboxResp_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboxResp.Text)
            {
                case "Area Academica": comboAcademia.Visible = true; label9.Visible = true;
                    break;
                case "Area Financiera": comboAcademia.Visible = false; label9.Visible = false;
                    break;
                case "Area de Planeacion": comboAcademia.Visible = false; label9.Visible = false;
                    break;
                case "Boss": comboAcademia.Visible = false; label9.Visible = false;
                    break;
            }
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "PDF (*.pdf)|*.pdf|All Files (*.*)|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                oficio = open.FileName;
            }
        }

        private void btnAdjuntarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                picboxFoto.Image = Image.FromFile(open.FileName);
            }
        }
    }
}
