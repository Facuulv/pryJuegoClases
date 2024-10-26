using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryJuegoTpLab2
{
    public partial class frmHistorial : Form
    {
        private conexionBD BD;
        public frmHistorial()
        {
            InitializeComponent();
            BD = new conexionBD();
        }
        private void frmHistorial_Load(object sender, EventArgs e)
        {
            conexionBD BD = new conexionBD();
            BD.imprimirUsuarios(dgvHistorial);
        }
    }
}
