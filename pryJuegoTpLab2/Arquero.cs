using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryJuegoTpLab2
{
    public class Arquero : Personaje
    {
        public Arquero(string nombre) : base(nombre, 100, 15, 100, "Hábil en el uso del arco, capaz de atacar a distancia con precisión y velocidad.") { }

        public override int AtaqueBasico()
        {
            int costoStamina = 8; // Costo de stamina para el ataque básico
            return RealizarAtaque(costoStamina, Daño);
        }
        public override int UsarHabEspecial()
        {
            int costoStamina;
            int daño;
            if (HabilidadSeleccionada == "Flecha de fuego")
            {
                costoStamina = 30;
                daño = 35;
            }
            else if (HabilidadSeleccionada == "Tres flechas")
            {
                costoStamina = 25;
                daño = 28;
            }
            else
            {
                return 0;
            }
            return RealizarAtaque(costoStamina, daño);
        }
    }
}
