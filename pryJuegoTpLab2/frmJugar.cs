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
    public partial class frmJugar : Form
    {
        public Personaje Jugador1 { get; }
        public Personaje Jugador2 { get; }
        private conexionBD BD;
        private int turnoActual;

        public frmJugar(Personaje jugador1, Personaje jugador2, string clase1, string clase2)
        {
            InitializeComponent();
            BD = new conexionBD();
            this.BackgroundImageLayout = ImageLayout.Stretch;
            btnHistorial.Enabled = false;

            turnoActual = 1;
            MostrarTurnoActual();

            Jugador1 = jugador1;
            Jugador2 = jugador2;
            prgVidaPJ1.Maximum = Jugador1.Vida;
            prgVidaPJ2.Maximum = Jugador2.Vida;
            lblClase1.Text = clase1;
            lblClase2.Text = clase2;
         
            rellenarInfo(Jugador1, lblNom1, lblHab1);
            rellenarInfo(Jugador2, lblNom2, lblHab2);

            ActualizarBarras();
            lstBatalla.Items.Add($"En el fragor del combate, {Jugador1.Nombre} y {Jugador2.Nombre} se enfrentan en una batalla épica que quedará grabada en la historia.");

            Finalizar();
        }
        public void rellenarInfo(Personaje jugador, Label nombre, Label habilidad)
        {
            nombre.Text = jugador.Nombre;
            habilidad.Text = jugador.HabilidadSeleccionada.ToString();
        }
        private void MostrarTurnoActual()
        {
            if (turnoActual == 1)
            {
                lblTurno.Text = $"TURNO DEL JUGADOR 1";               
            }
            else
            {
                lblTurno.Text = $"TURNO DEL JUGADOR 2";               
            }
        }
        public void CambiarTurno()
        {
            if (turnoActual == 1)
            {
                turnoActual = 2;
            }
            else
            {
                turnoActual = 1;
            }
            MostrarTurnoActual();
        }
        public void ActualizarBarras()
        {
           
            if (Jugador1.Vida <= 0)
            {
                Jugador1.Vida = 0;

            }
            if (Jugador2.Vida <= 0)
            {
                Jugador2.Vida = 0;
            }

            prgVidaPJ1.Value = Jugador1.Vida;
            lblVidaPj1.Text = Jugador1.Vida.ToString();

            prgVidaPJ2.Value = Jugador2.Vida;
            lblVidaPj2.Text = Jugador2.Vida.ToString();

            pbStaminaPj1.Value = Jugador1.Stamina;
            lblStaminaPj1.Text = Jugador1.Stamina.ToString();

            pbStaminaPj2.Value = Jugador2.Stamina;
            lblStaminaPj2.Text = Jugador2.Stamina.ToString();    
                       
        }
        public void Finalizar()
        {
            if (Jugador1.Vida <= 0)
            {
                lstBatalla.Items.Add($"Con valentía y determinación, {Jugador2.Nombre} se alza como un verdadero héroe derrotando a {Jugador1.Nombre} en una batalla que resonará por toda la eternidad");
                MessageBox.Show($"¡Felicitaciones {Jugador2.Nombre}! Sumaste 10 puntos para el historial de batallas", "Atencion");
                verificacionFinal(Jugador2.Nombre);
            }
            else if (Jugador2.Vida <= 0)
            {
                lstBatalla.Items.Add($"Con valentía y determinación, {Jugador1.Nombre} se alza como un verdadero héroe derrotando a {Jugador2.Nombre} en una batalla que resonará por toda la eternidad");
                MessageBox.Show($"¡Felicitaciones {Jugador1.Nombre}! Sumaste 10 puntos para el historial de batallas", "Atencion");
                verificacionFinal(Jugador1.Nombre);
            }           
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            frmHistorial form4 = new frmHistorial();
            form4.ShowDialog();
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            frmJugar formJugar = this;
            frmAccion formAccion = new frmAccion(Jugador1, Jugador2, lstBatalla, prgVidaPJ1, prgVidaPJ2, pbStaminaPj1, pbStaminaPj2, lblVidaPj1, lblVidaPj2, lblStaminaPj1, lblStaminaPj2, formJugar, turnoActual);
            formAccion.ShowDialog();
        }

        private void frmJugar_Load(object sender, EventArgs e)
        {

        }

        private void btnAtBasico_Click(object sender, EventArgs e)
        {
            int daño = 0;
            if (turnoActual == 1)
            {
                daño = Jugador1.AtaqueBasico();
                Jugador2.RecibirAtaque(daño);
                lstBatalla.Items.Add($"{Jugador1.Nombre} realizó un ataque básico y causó {daño} de daño a {Jugador2.Nombre}.");
            }
            else if (turnoActual == 2)
            {
                daño = Jugador2.AtaqueBasico();
                Jugador1.RecibirAtaque(daño);
                lstBatalla.Items.Add($"{Jugador2.Nombre} realizó un ataque básico y causó {daño} de daño a {Jugador1.Nombre}");
            }
            CambiarTurno();
            ActualizarBarras();
            Finalizar();
        }

        private void btnAtEspecial_Click(object sender, EventArgs e)
        {
            int daño = 0;
            try
            {
                if (turnoActual == 1)
                {
                    daño = Jugador1.UsarHabEspecial();
                    Jugador2.RecibirAtaque(daño);
                    lstBatalla.Items.Add($"{Jugador1.Nombre} ha realizado el ataque especial {Jugador1.HabilidadSeleccionada} causando {daño} de daño a {Jugador2.Nombre}");
                }
                else if (turnoActual == 2)
                {
                    daño = Jugador2.UsarHabEspecial();
                    Jugador1.RecibirAtaque(daño);
                    lstBatalla.Items.Add($"{Jugador2.Nombre} ha realizado el ataque especial {Jugador2.HabilidadSeleccionada} causando {daño} de daño a {Jugador1.Nombre}");
                }
            }catch
            {
                if (turnoActual == 1 && daño == 0)
                {
                    daño = 10;
                    Jugador2.RecibirAtaque(daño);
                    lstBatalla.Items.Add($"HOLA1");
                }
                else if (turnoActual == 2 && daño == 0)
                {
                    daño = 10;
                    Jugador1.RecibirAtaque(daño);
                    lstBatalla.Items.Add($"HOLA2");
                }
            }
            /*if (turnoActual == 1)
            {
                daño = Jugador1.UsarHabEspecial();
                Jugador2.RecibirAtaque(daño);
                lstBatalla.Items.Add($"{Jugador1.Nombre} ha realizado el ataque especial {Jugador1.HabilidadSeleccionada} causando {daño} de daño a {Jugador2.Nombre}");
            }
            else if (turnoActual == 2)
            {
                daño = Jugador2.UsarHabEspecial();
                Jugador1.RecibirAtaque(daño);
                lstBatalla.Items.Add($"{Jugador2.Nombre} ha realizado el ataque especial {Jugador2.HabilidadSeleccionada} causando {daño} de daño a {Jugador1.Nombre}");
            }*/
            CambiarTurno();
            ActualizarBarras();
            Finalizar();

        }

        private void btnRecup_Click(object sender, EventArgs e)
        {
            if (turnoActual == 1)
            {
                Jugador1.Descanso();
                lstBatalla.Items.Add($"{Jugador1.Nombre} se ha tomado un descanso. Restauró {Jugador1.Vida + prgVidaPJ1.Value} puntos de vida");
            }
            else if (turnoActual == 2)
            {
                Jugador2.Descanso();
                lstBatalla.Items.Add($"{Jugador2.Nombre} se ha tomado un descanso. Restauró {Jugador2.Vida + prgVidaPJ2.Value} puntos de vida");
            }
            CambiarTurno();
            ActualizarBarras();
        }
        public void verificacionFinal(string jugador)
        {
            conexionBD BD = new conexionBD();
            if (BD.verificarUsuario(jugador))
            {
                BD.actualizarUsuario(jugador, 50);
            } else if (!BD.verificarUsuario(jugador))
            {
                BD.agregarUsuario(jugador, 50);
            }
            btnHistorial.Enabled = true;
        }
    }
}
