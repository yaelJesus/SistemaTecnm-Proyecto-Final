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
    public partial class UserControlDias : UserControl
    {
        public UserControlDias()
        {
            InitializeComponent();
        }

        private void UserControlDias_Load(object sender, EventArgs e)
        {

        }
        public void dias(int numdias)
        {
            lbDias.Text = numdias+"";
        }
    }
}
