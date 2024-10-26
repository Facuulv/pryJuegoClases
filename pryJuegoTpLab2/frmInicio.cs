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
    public partial class frmInicio : Form
    {
        private conexionBD BD;
        private bool jugador1Seleccionado;
        private bool jugador2Seleccionado;
        public frmInicio()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;

            txtJugador2.Enabled = false;
            btnSeleccionarJ2.Enabled = false;
            btnSiguiente.Enabled = false;
            jugador1Seleccionado = false;

            BD = new conexionBD();
        }
        private void frmInicio_Load(object sender, EventArgs e)
        {
            rellenarCombos(cmbJugador1);
            rellenarCombos(cmbJugador2);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            string jugador1Nombre = txtJugador1.Text;
            string jugador2Nombre = txtJugador2.Text;
            string jugador1Combo = cmbJugador1.Text;
            string jugador2Combo = cmbJugador2.Text;

            frmSeleccion form2 = new frmSeleccion(jugador1Nombre, jugador2Nombre, jugador1Combo, jugador2Combo);
            this.Hide();
            form2.ShowDialog();
            this.Close();
        }

        private void btnSeleccionarJ1_Click(object sender, EventArgs e)
        {
            string jugador1 = txtJugador1.Text;
            string cmb1 = cmbJugador1.Text.ToString();
            if (jugador1 != "" || cmb1 != null)
            {
                if (!BD.verificarUsuario(jugador1))
                {
                    txtJugador1.Enabled = false;
                    btnSeleccionarJ1.Enabled = false;

                    txtJugador2.Enabled = true;
                    btnSeleccionarJ2.Enabled = true;
                    jugador1Seleccionado = true;
                    cmbJugador2.Items.Remove(cmb1);
                }
                else
                {
                    MessageBox.Show("El jugador ya se encuentra registrado. Elija otro nombre.", "Atención");
                    txtJugador1.Text = "";
                    return;
                }                
            }
            else
            {
                MessageBox.Show("Debe colocar nombre a su personaje", "Atencion");
            }
        }

        private void btnSeleccionarJ2_Click(object sender, EventArgs e)
        {
            string jugador2 = txtJugador2.Text;
            string cmb2 = cmbJugador2.Text.ToString();
            if (jugador2 != "" || cmb2 != "")
            {
                if (!BD.verificarUsuario(jugador2))
                {
                    txtJugador2.Enabled = false;
                    btnSeleccionarJ2.Enabled = false;
                    btnSiguiente.Enabled = true;
                }
                else
                {
                    MessageBox.Show("El jugador ya se encuentra registrado. Elija otro nombre.", "Atención");
                    return;
                }       
            }
            else
            {
                MessageBox.Show("Debe colocar nombre a su personaje", "Atencion");
            }
        }
        public void rellenarCombos(ComboBox cmb)
        {
            List<string> jugadores = BD.jugadoresExistentes();
            cmb.Items.Clear();
            cmb.Items.AddRange(jugadores.ToArray());
        }

        private void txtJugador1_TextChanged(object sender, EventArgs e)
        {           
            estadoControles(txtJugador1, cmbJugador1);
        }

        private void txtJugador2_TextChanged(object sender, EventArgs e)
        {
            estadoControles(txtJugador2, cmbJugador2);
        }

        private void cmbJugador1_SelectedIndexChanged(object sender, EventArgs e)
        {
            estadoControles(txtJugador1, cmbJugador1);
        }

        private void cmbJugador2_SelectedIndexChanged(object sender, EventArgs e)
        {
            estadoControles(txtJugador2, cmbJugador2);
        }
        public void estadoControles(TextBox txtJugador, ComboBox cmbJugador)
        {
            if (txtJugador.Text != "")
            {
                cmbJugador.Enabled = false;
            }
            else
            {
                cmbJugador.Enabled = true;
            }
            if (cmbJugador.Text != "")
            {
                txtJugador.Enabled = false;
            }else
            {
                txtJugador.Enabled = true;
            }
        }        
    }
}
