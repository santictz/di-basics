using System;

namespace di_basics
{
    
    //Define Interfaces
    public interface IAlimento
    {
        string Nombre{get;}

        void Consumir();
    }

    //Define classes that implement the Intefaces (services)
    public class Pizza: IAlimento{
        
        public string Nombre{get; private set;}

        public Pizza(string ingredientes){
            Nombre = "Pizza de" + ingredientes;
        }

        public void Consumir(){
            //Implementation
            System.Console.WriteLine("Consumir Pizza");
        }
    }

    public class Hamburguesa: IAlimento{
        public string Tipo { get; set; }

        public string Nombre{
            get {return "Hamburguesa " + Tipo; }
        }

        public void Consumir(){
            System.Console.WriteLine("Consumir Hamburguesa");
        }
    }

    //Create clients that will consume the services
    public class Persona{
        IAlimento _alimento;

        public Persona(IAlimento alimento){
            _alimento = alimento;
        }

        public void Comer(){
            _alimento.Consumir();
            System.Console.WriteLine("Comiendo " + _alimento.Nombre);
        }
    }
}