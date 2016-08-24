using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    public class Auto
    {
        private EFabricante fabricante;
        public Rueda ruedaDI;
        public Rueda ruedaDD;
        public Rueda ruedaTI;
        public Rueda ruedaTD;
        public static int contadorDeObjetos;
        int numero;
        private Random randomMarca = new Random();
        private int kilometrosRecorridos;
        private int tiempoDemorado;

        public void volverACero()
        {
            kilometrosRecorridos = 0;
            tiempoDemorado = 0;
        }

        public void volverACero()
        {
            kilometrosRecorridos = 0;
        }

        public void agregarKilometros(int kilometros)
        {
            kilometrosRecorridos = kilometrosRecorridos + kilometros;
        }

        public void mostrarAuto()
        {
            Console.WriteLine("El fabricante es: " + this.fabricante);
            Console.WriteLine("Kilometros recorridos: " + this.kilometrosRecorridos);
        }

        public static bool compararAutos(Auto autoUno, Auto autoDos)
        {
            if (autoUno.fabricante == autoDos.fabricante)
                return true;
            //no se pueden escribir this en metodos estaticos, solo en instancias.
            return false;
        }

        public Auto()
        {
            numero = randomMarca.Next(1,3);

            this.fabricante = (EFabricante)numero;
            this.ruedaDI = new Rueda();//esto se denomina instanciar
            this.ruedaDD = new Rueda();
            this.ruedaTI = new Rueda();
            this.ruedaTD = new Rueda();
            Auto.contadorDeObjetos++;
        }

        static Auto() //un constructor estatico no puede ser publico. No se lo puede sobrecargar.
        {
            Auto.contadorDeObjetos = 0;          
        }

        public int MinyMax()
        {
            return this.kilometrosRecorridos;
        }
    }
}
