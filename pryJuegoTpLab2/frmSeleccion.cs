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
    public partial class frmSeleccion : Form
    {
        private string jugador1Nombre;
        private string jugador2Nombre;
        private Personaje jugador1Personaje;
        private Personaje jugador2Personaje;  
        public string claseSelec1;
        public string claseSelec2;

        List<string> clases = new List<string>() { "Guerrero", "Arquero", "Asesino", "Escudero" };
        public frmSeleccion(string j1Nombre, string j2Nombre, string j1Combo, string j2Combo)
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;

            cmbClasePJ2.Enabled = false;
            btnElegirPJ2.Enabled = false;
            btnJugar.Enabled = false;

            if(j1Nombre != "")
            {
                jugador1Nombre = j1Nombre;
            } else if (j1Combo != "")
            {
                jugador1Nombre = j1Combo;
            }
            if (j2Nombre != "")
            {
                jugador2Nombre = j2Nombre;
            } else if (j2Combo != "")
            {
                jugador2Nombre= j2Combo;
            }

            clases.ForEach(c =>
            {
                cmbClasePJ1.Items.Add(c);
                cmbClasePJ2.Items.Add(c);
            });

            // Estas lineas registran cuando un usuario selecciona una clase del comboBox.
            // En cada evento de los 2 combos se crea al personaje llamando a funcion CrearPersonaje
            cmbClasePJ1.SelectedIndexChanged += cmbClasePJ1_SelectedIndexChanged;
            cmbClasePJ2.SelectedIndexChanged += cmbClasePJ2_SelectedIndexChanged;
        }

        private void cmbClasePJ1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbHabPJ1.Enabled = true;
            cmbHabPJ1.Items.Clear();
            string claseSelec = cmbClasePJ1.SelectedItem.ToString();
            claseSelec1 = claseSelec;
            jugador1Personaje = CrearPersonaje(claseSelec, jugador1Nombre);
            MostrarInfoPersonaje(jugador1Personaje);
            SeleccHabilidad(claseSelec, cmbHabPJ1);
            // Muestra la imagen de la clase elegida
            string imagePath = $"./{claseSelec}.png";
            picImagen.Image = Image.FromFile(imagePath);
        }

        private void cmbClasePJ2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbHabPJ2.Enabled = true;
            cmbHabPJ2.Items.Clear();
            string claseSelec = cmbClasePJ2.SelectedItem.ToString();
            claseSelec2 = claseSelec;
            jugador2Personaje = CrearPersonaje(claseSelec, jugador2Nombre);
            MostrarInfoPersonaje(jugador2Personaje);
            SeleccHabilidad(claseSelec, cmbHabPJ2);
            // Muestra la imagen de la clase elegida
            string imagePath = $"./{claseSelec}.png";
            picImagen.Image = Image.FromFile(imagePath);
        }
        private Personaje CrearPersonaje(string clase, string nombre)
        {
            switch (clase)
            {
                case "Guerrero":
                    return new Guerrero(nombre);
                case "Arquero":
                    return new Arquero(nombre);
                case "Asesino":
                    return new Asesino(nombre);
                case "Escudero":
                    return new Escudero(nombre);
                default:
                    return null;
            }
        }
        private void MostrarInfoPersonaje(Personaje personaje)
        {
            lstCaracteristicas.Items.Clear();
            lstCaracteristicas.Items.Add($"Nombre: {personaje.Nombre}");
            lstCaracteristicas.Items.Add($"Vida: {personaje.Vida}");
            lstCaracteristicas.Items.Add($"Daño: {personaje.Daño}");
            //lstCaracteristicas.Items.Add($"Armadura: {personaje.Armadura}");
            lstCaracteristicas.Items.Add("Descripción:");
            lstCaracteristicas.Items.Add($"{personaje.Descripcion}");
        }
        public void SeleccHabilidad(string claseSelec, ComboBox hab)
        {
            switch (claseSelec)
            {
                case "Guerrero":
                    hab.Items.Add("Golpes Giratorios");
                    hab.Items.Add("Estocada");
                    break;
                case "Arquero":
                    hab.Items.Add("Flecha de fuego");
                    hab.Items.Add("Tres flechas");
                    break;
                case "Asesino":
                    hab.Items.Add("Golpes Rapidos");
                    hab.Items.Add("Cuchillo Envenenado");
                    break;
                case "Escudero":
                    hab.Items.Add("Bloque total");
                    hab.Items.Add("Rebote");
                    break;
            }
        }

        private void btnElegirPJ1_Click(object sender, EventArgs e)
        {
            if (cmbClasePJ1.SelectedItem != null && cmbHabPJ1.SelectedItem != null)
            {
                string clase = cmbClasePJ1.SelectedItem.ToString();
                cmbClasePJ1.Enabled = false;
                cmbHabPJ1.Enabled = false;
                btnElegirPJ1.Enabled = false;
                lstCaracteristicas.Items.Clear();
                MessageBox.Show($"Se ha creado el {clase} {jugador1Nombre} correctamente. May the force be with you", "Exito");
                cmbClasePJ2.Enabled = true;
                btnElegirPJ2.Enabled = true;
                // Eliminar la posibilidad de que el segundo jugador seleccione la misma clase que el primero.
                cmbClasePJ2.Items.Remove(clase);
            }
            else
            {
                MessageBox.Show("Debe seleccionar una clase y habilidad", "Atencion");
            }
        }

        private void btnElegirPJ2_Click(object sender, EventArgs e)
        {
            if (cmbClasePJ2.SelectedItem != null && cmbHabPJ2.SelectedItem != null)
            {
                string clase = cmbClasePJ2.SelectedItem.ToString();
                cmbClasePJ2.Enabled = false;
                cmbHabPJ2.Enabled = false;
                btnElegirPJ2.Enabled = false;
                lstCaracteristicas.Items.Clear();
                MessageBox.Show($"Se ha creado el {clase} {jugador2Nombre} correctamente. May the force be with you", "Exito");
                btnJugar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una clase y habilidad", "Atencion");
            }
        }

        private void cmbHabPJ1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (jugador1Personaje != null)
            {
                jugador1Personaje.HabilidadSeleccionada = cmbHabPJ1.SelectedItem.ToString();
            }
        }

        private void cmbHabPJ2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (jugador2Personaje != null)
            {
                jugador2Personaje.HabilidadSeleccionada = cmbHabPJ2.SelectedItem.ToString();
            }
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            frmJugar form3 = new frmJugar(jugador1Personaje, jugador2Personaje, claseSelec1, claseSelec2);
            this.Hide();
            form3.ShowDialog();
            this.Close();
        }
    }
}
