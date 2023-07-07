using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Conejo conejo = new Conejo();
            Aguila aguila = new Aguila();
            Pez pez = new Pez();

            conejo.Huir();
            aguila.Cazar();
            pez.Cazar();
            pez.Huir();
        }
    }

    interface IPreza
    {
        void Huir();
    }
    interface IPredador
    {
        void Cazar();
    }
    class Conejo : IPreza
    {
        public void Huir()
        {
            Console.WriteLine("La preza huye");
        }
    }
    class Aguila : IPredador
    {
        public void Cazar()
        {
            Console.WriteLine("El predador caza");
        }
    }
    class Pez : IPreza, IPredador
    {
        public void Huir()
        {
            Console.WriteLine("El Peza huye por que es preza");
        }

        public void Cazar()
        {
            Console.WriteLine("El Peza caza por que es predador");
        }
    }
}