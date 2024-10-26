using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryJuegoTpLab2
{
    public class Escudero : Personaje
    {
        public Escudero(string nombre) : base(nombre, 100, 10, 100, "Guardián leal. Protege a sus compañeros con su escudo en alto siendo el bastion de la fortaleza en la batalla.") { }
        public override int AtaqueBasico()
        {
            int costoStamina = 10;
            return RealizarAtaque(costoStamina, Daño);
        }
        public override int UsarHabEspecial()
        {
            int costoStamina;
            int daño;
            if (HabilidadSeleccionada == "Bloqueo Total")
            {
                costoStamina = 25;
                Vida += 5;
                daño = 15;
            }
            else if (HabilidadSeleccionada == "Rebote")
            {
                costoStamina = 15;
                daño = 20;
            }
            else
            {
                return 0;
            }
            return RealizarAtaque(costoStamina, daño);
        }
    }
}
