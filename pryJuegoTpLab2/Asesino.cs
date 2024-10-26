using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryJuegoTpLab2
{
    public class Asesino : Personaje
    {
        public Asesino(string nombre) : base(nombre, 100, 25, 100, "Experto en ataques rápidos y letales, sigiloso en las sombras esperando su próximo contrincante.") { }
        public override int AtaqueBasico()
        {
            int costoStamina = 12;
            return RealizarAtaque(costoStamina, Daño);
        }
        public override int UsarHabEspecial()
        {
            int costoStamina;
            int daño;
            if (HabilidadSeleccionada == "Golpes Rápidos")
            {
                costoStamina = 25;
                daño = 30;
            }
            else if (HabilidadSeleccionada == "Cuchillo Envenenado")
            {
                costoStamina = 30;
                daño = 35;
            }
            else
            {
                return 0;
            }
            return RealizarAtaque(costoStamina, daño);
        }
    }
}
