using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaTecnm_Proyecto_Final_
{
    public partial class INICIOSESION : Form
    {
        public INICIOSESION()
        {
            InitializeComponent();
        }

        private void txtContraseña_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string usuario, psw;
                usuario = txtUsuario.Text;
                psw = txtContraseña.Text;
                if (usuario == "Boss" && psw == "191102" || usuario == "Area Academica" && psw == "061202" || usuario == "Area Financiera" && psw == "210903" || usuario == "Area de Planeacion" && psw == "123456")
                {
                    MessageBox.Show("¡Inicio de Sesion Exitosa!", "TECNM", MessageBoxButtons.OK);
                    FrmCalendario Calendario = new FrmCalendario();
                    Calendario.Area = usuario;
                    Calendario.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Usuario y Contraseña Incorrecta");
                }
            }
        }

        private void FechaHora_Tick(object sender, EventArgs e)
        {
            lblFechaHora.Text = DateTime.Now.ToLongDateString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
