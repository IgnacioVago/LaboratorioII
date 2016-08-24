using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    public class Rueda
    {
        public string Marca;
        public float tamaño;
        /// <summary>
        /// Constructor por defecto, inicializa tamaño en 0 y a la marca en "sin marca".
        /// </summary>
        public Rueda() //constructor.
        {
            this.Marca = "sin marca";

        }
        /// <summary>
        /// Recibe una marca y la asigna.
        /// </summary>
        /// <param name="marca">Recibe la marca desde el main</param>
        public Rueda(string marca)
        {
            this.Marca = marca;
        }
        /// <summary>
        /// Constructor por defecto, recibe un tamaño y lo asigna.
        /// </summary>
        /// <param name="tamaño">recibe el tamaño desde el main</param>
        public Rueda(int tamaño):this()
        {
            this.tamaño = tamaño;
        }
        
        public void mostrarRueda()
        {
            Console.WriteLine("El tamaño es: " + tamaño);
        }
        /// <summary>
        /// Sobrecarga del constructor con 2 parametros.
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="tamaño"></param>
        public Rueda(int tamaño, string marca)
        {
            this.tamaño = tamaño;
            this.Marca = "sin marca";
        }
        public Rueda(string marca, int tamaño)
        {
            this.tamaño = tamaño;
            this.Marca = marca;
        }
        
        
    }
}
