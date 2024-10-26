using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryJuegoTpLab2
{
    public class Personaje
    {
        // Atributos principales del personaje
        public string Nombre { get; set; }
        public int Vida { get; set; }
        public int Daño { get; set; }
        public int Stamina { get; set; }
        public string Descripcion { get; set; }
        public string HabilidadSeleccionada { get; set; }

        // Constructor del personaje. Va a recibir el nombre, el resto de los parametros son datos duros.
        public Personaje(string nombre, int vida, int daño, int stamina, string descripcion)
        {
            Nombre = nombre;
            Vida = vida;
            Daño = daño;
            Stamina = stamina;
            Descripcion = descripcion;
        }
        public int RealizarAtaque(int costoStamina, int daño)
        {
            if (Stamina >= costoStamina)
            {
                Stamina -= costoStamina;
                return daño;
            }
            else
            {
                return 0;
            }
        }
        public virtual int UsarHabEspecial()
        {
            return 0;
        }
        public virtual int AtaqueBasico()
        {
            return 0;
        }
        public int numRandom(int valor1, int valor2)
        {
            // Funcion para devolver un numero random entre 2 numeros que se pasan como parametro.
            // Se llama numRandom(1, 10) por ejemplo. El primero es inicial y el segundo es el limite
            Random random = new Random();
            return random.Next(valor1, valor2);
        }

        public void RecibirAtaque(int daño)
        {
            // Recibe como parametro daño y se le resta a la vida. Tambien se resta 5 a Armadura
            Vida -= daño;
        }        
        public void Descanso()
        {
            int costoStam = 10;
            int cantRecuperacion = 20;
            if (Stamina >= costoStam)
            {
                if ((cantRecuperacion + Vida) >= 100)
                {
                    Vida = 100;
                }else
                {
                    Vida = Vida + cantRecuperacion;
                }                
                Stamina -= costoStam;
            }
        }
    }
}
