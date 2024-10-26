using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryJuegoTpLab2
{
    public class Guerrero : Personaje
    {
        public Guerrero(string nombre) : base(nombre, 100, 20, 100, "Maestro en el combate cuerpo a cuerpo, conocido por su fuerza y resistencia.") { }
        public override int AtaqueBasico()
        {
            int costoStamina = 10;
            return RealizarAtaque(costoStamina, Daño);
        }
        public override int UsarHabEspecial()
        {
            int costoStamina;
            int daño;
            if (HabilidadSeleccionada == "Golpes Giratorios")
            {
                costoStamina = 25;
                daño = 30;
            }
            else if (HabilidadSeleccionada == "Estocada")
            {
                costoStamina = 20;
                daño = 25;
            }
            else
            {
                return 0;
            }
            return RealizarAtaque(costoStamina, daño);
        }
    }
}
