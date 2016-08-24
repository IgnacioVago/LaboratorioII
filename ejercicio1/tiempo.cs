using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    public class tiempo
    {
        public int tiempo;

        public tiempo(int tiempo)
        {
            this.tiempo = tiempo;
        }

        public static sumar(tiempo tiempoaux, int valor)// Este es el metodo.
        {
          tiempo aux;
          tiempoaux.cantidad = tiempoaux.cantidad + valor;
          return aux;
        }

        public static tiempo operator +(tiempo tiempoaux, int valor)// Este es el operador.
        {

        }
    
   
    }
}
