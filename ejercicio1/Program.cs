using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            EFabricante fabricante;
            fabricante = EFabricante.Honda;
            Carrera race=new Carrera();
            Rueda otraRueda = new Rueda("pirelli");
            Console.WriteLine(fabricante);

            fabricante = (EFabricante)1;

            Console.WriteLine(fabricante);

            Rueda nuevaRueda = new Rueda();
            Auto nuevoAuto = new Auto();
            Auto otroAuto = new Auto();
            Auto masAuto = new Auto();
            Auto unNuevoAuto = new Auto();

            Console.WriteLine(Auto.contadorDeObjetos);
            Console.ReadKey();

            race.mostrarCarrera();
            Console.ReadKey();
        }
    }
}
//this esta en los metodos de instancia y constructores, escribis this. y aparecen las instancias, this.nombre=nombre, 