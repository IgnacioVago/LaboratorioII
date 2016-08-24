using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    public class Carrera
    {
        public Auto autoUno;
        public Auto autoDos;
        public Auto autoTres;
        public Auto autoCuatro;
        public Auto autoCinco;
        public Auto autoSeis;
        Random randomKilometros = new Random();

        public Carrera()
        {
            this.autoUno = new Auto();
            this.autoDos = new Auto();
            this.autoTres = new Auto();
            this.autoCuatro = new Auto();
            this.autoCinco = new Auto();
            this.autoSeis = new Auto();
        }

        public void mostrarCarrera()
        {
            PorTiempo(10);
            this.autoUno.mostrarAuto();
            this.autoDos.mostrarAuto();
            this.autoTres.mostrarAuto();
            this.autoCuatro.mostrarAuto();
            this.autoCinco.mostrarAuto();
            this.autoSeis.mostrarAuto();
        }

        public void PorTiempo(int Minutos)
        {
            int contador;
            int minimo = 0;
            int maximo = 0;

            for (contador = 0; contador < Minutos; contador++)
            {
                this.autoUno.agregarKilometros(randomKilometros.Next(10, 100));
                this.autoDos.agregarKilometros(randomKilometros.Next(10, 100));
                this.autoTres.agregarKilometros(randomKilometros.Next(10, 100));
                this.autoCuatro.agregarKilometros(randomKilometros.Next(10, 100));
                this.autoCinco.agregarKilometros(randomKilometros.Next(10, 100));
                this.autoSeis.agregarKilometros(randomKilometros.Next(10, 100));
            }

            maximo = autoUno.MinyMax();
            if (maximo < autoDos.MinyMax())
                maximo = autoDos.MinyMax();
            if (maximo < autoTres.MinyMax())
                maximo = autoTres.MinyMax();
            if (maximo < autoCuatro.MinyMax())
                maximo = autoCuatro.MinyMax();
            if (maximo < autoCinco.MinyMax())
                maximo = autoCinco.MinyMax();
            if (maximo < autoSeis.MinyMax())
                maximo = autoSeis.MinyMax();

            minimo = autoUno.MinyMax();
            if (minimo > autoDos.MinyMax())
                minimo = autoDos.MinyMax();
            if (minimo > autoTres.MinyMax())
                minimo = autoTres.MinyMax();
            if (minimo > autoCuatro.MinyMax())
                minimo = autoCuatro.MinyMax();
            if (minimo > autoCinco.MinyMax())
                minimo = autoCinco.MinyMax();
            if (minimo > autoSeis.MinyMax())
                minimo = autoSeis.MinyMax();

            Console.WriteLine("El minimo de kilometros recorridos: " + minimo);
            Console.WriteLine("El maximo de kilometros recorridos: " + maximo);
        }

        
        public void correrCarrera(tiempo tiempo)
        {
            
        }

        public void correrCarrera(kilometro kilometro)
        {
 
        }
        
    }
}
