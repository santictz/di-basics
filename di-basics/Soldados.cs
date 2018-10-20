using System;

namespace di_soldiers
{
    public class SImplementation{
        
    }
    public class Revolver: IArma
    {
        public string Disparar(){
            return "Pum, pum...";
        }
    }

    public class Rifle: IArma
    {
        public string Disparar()
        {
            return "Pum, pum, pum pum...";
        }
    }

    public class Escopeta: IArma
    {
        public string Disparar()
        {
            return "Pum, chic, pum...";
        }
    }

    //Soldado implements neccesary methods to shoot
    public class Soldado
    {
        protected IArma arma;

        public Soldado(IArma _arma){
            this.arma = _arma;
        }

        /* Old Implementnation 
        public string DispararRevolver()
        {
            return new Revolver().Disparar();
        }

        public string DispararRifle()
        {
            return new Rifle().Disparar();
        }

        public string DispararEscopeta()
        {
            return new Escopeta().Disparar();
        }
        */

        //New Implementation
        public string Disparar()
        {
            return this.arma.Disparar(); //Our Soldado class now knows that it needs to shot, it is the constructor who is in charge of set the weapon
        }
    }

    //Problem: dependency must be implemented by the Soldier
    //Solution: create interface so the Soldier Constructor pass it as an argument

    //Weapons will implement this Interface
    public interface IArma
    {
        string Disparar();
    }
}