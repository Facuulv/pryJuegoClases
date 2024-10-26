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
    public partial class frmAccion : Form
    {
        private Personaje Jugador1 { get; }
        private Personaje Jugador2 { get; }       
        private ListBox lstBatalla { get; }
        private ProgressBar pbVida1 { get; }
        private ProgressBar pbVida2 { get; }
        private ProgressBar pbStamina1 { get; }
        private ProgressBar pbStamina2 { get; }
        private Label lblVidaPj1 { get; }
        private Label lblVidaPj2 { get; }
        private Label lblStaminaPj1 { get; }
        private Label lblStaminaPj2 { get; }
        private frmJugar formPrincipal { get; }
        private int turnoActual;
        public frmAccion(Personaje jugador1, Personaje jugador2, ListBox lst, ProgressBar pbJ1, ProgressBar pbJ2, ProgressBar pbSta1, ProgressBar pbSta2, Label lblVida1, Label lblVida2, Label lblSta1, Label lblSta2, frmJugar formJuego, int turno)
        {
            InitializeComponent();           

            Jugador1 = jugador1;
            Jugador2 = jugador2;
            lstBatalla = lst;
            pbVida1 = pbJ1;
            pbVida2 = pbJ2;
            pbStamina1 = pbSta1;
            pbStamina2 = pbSta2;
            lblVidaPj1 = lblVida1;
            lblVidaPj2 = lblVida2;
            lblStaminaPj1 = lblSta1;
            lblStaminaPj2 = lblSta2;
            formPrincipal = formJuego;
            turnoActual = turno;          
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
            formPrincipal.CambiarTurno();
            formPrincipal.ActualizarBarras();
            formPrincipal.Finalizar();
            this.Close();
        }
        private void CambiarTurno()
        {
            if (turnoActual == 1)
            {
                turnoActual = 2;
            }
            else
            {
                turnoActual = 1;
            }
        }

        private void btnAtEspecial_Click(object sender, EventArgs e)
        {
            int daño = 0;
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
            CambiarTurno();
            formPrincipal.CambiarTurno();
            formPrincipal.ActualizarBarras();          
            formPrincipal.Finalizar();
            this.Close();
        }

        private void btnRecup_Click(object sender, EventArgs e)
        {
            if (turnoActual == 1)
            {
                Jugador1.Descanso();            
                lstBatalla.Items.Add($"{Jugador1.Nombre} se ha tomado un descanso. Restauró {Jugador1.Vida - pbVida1.Value} puntos de vida");               
            }
            else if (turnoActual == 2)
            {
                Jugador2.Descanso();
                lstBatalla.Items.Add($"{Jugador2.Nombre} se ha tomado un descanso. Restauró {Jugador2.Vida - pbVida2.Value} puntos de vida");               
            }
            CambiarTurno();
            formPrincipal.CambiarTurno();
            formPrincipal.ActualizarBarras();           
            this.Close();
        }
       
    }
}
