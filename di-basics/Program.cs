using System;
using di_soldiers;

namespace di_basics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Injector

            IAlimento alimento = null;
            alimento = new Pizza("Lechuga");
            /* 
            alimento = new Hamburguesa (){
                Tipo = "Sencilla
            }
            */ 

            //Inject dependency through constructor
            var persona = new Persona(alimento);
            // Person uses
            persona.Comer();

//------------------------------------------------------------------------

            //Soldado
            //If we want to shoot the Revolver
            var soldado = new Soldado(new Revolver());
            soldado.Disparar();
            //If we want to shoot the Rifle
            var soldadoR = new Soldado(new Rifle());
            soldadoR.Disparar();



        }
    }


}

