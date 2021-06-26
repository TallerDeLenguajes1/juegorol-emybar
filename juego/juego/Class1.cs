using System;
using System.Collections.Generic;
using System.Text;

namespace juego
{
  
   class Personaje
    {
        
        private string tipo;
        private string nombre;
      
        private DateTime fechadenacimiento;
        private int edad;
        private int salud;

        private int velocidad;
        private int destreza;
        private int fuerza;
        private int nivel;
        private int armadura;

        private int poderDisparo;
        private int poderDefensa;


        
        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime Fechadenacimiento { get => fechadenacimiento; set => fechadenacimiento = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Salud { get => salud; set => salud = value; }
        public int Velocidad { get => velocidad; set => velocidad = value; }
        public int Destreza { get => destreza; set => destreza = value; }
        public int Fuerza { get => fuerza; set => fuerza = value; }
        public int Nivel { get => nivel; set => nivel = value; }
        public int Armadura { get => armadura; set => armadura = value; }
        public int PoderDisparo { get => poderDisparo; set => poderDisparo = value; }
        public int PoderDefensa { get => poderDefensa; set => poderDefensa = value; }
        public string Tipo { get => tipo; set => tipo = value; }


        public int defensa()
        {
            return PoderDefensa = Armadura * Velocidad;
        }
        public int poderdDisparo()
        {
            return  Fuerza * Destreza * Velocidad;
        }
        public int ataque()
        {
            Random efectividadDisparo = new Random();
            return poderdDisparo() * efectividadDisparo.Next(1, 101);
        }

        public float valordanio()
        {
            Random rand = new Random();
            float vataque = ataque();
            float pdef = defensa();
            float danio = ((vataque - pdef) / 30000) * 100;
          
            return danio;
        }

        


  

        public enum TipodePersonaje
        {
            Dios = 0,
            Humano,
            Ovni,
            Mago,
        }
        public enum NombredePersonaje
        {
            Zeus,
            Hera,
            Dionisio,
            Apolo,
            Hermes,
            Atenea,
            Ares,
            Medusa,
        }

        public static Personaje crearpersonaje()
        {
            Random rand = new Random();
            Personaje nuevoper = new Personaje();
            nuevoper.Salud = 100;
            nuevoper.Edad = rand.Next(0, 300);
            nuevoper.Velocidad = rand.Next(1, 11);
            nuevoper.Destreza = rand.Next(1, 6);
            nuevoper.Fuerza = rand.Next(1, 11);
            nuevoper.Nivel = rand.Next(1, 11);
            nuevoper.Armadura = rand.Next(1, 11);
            nuevoper.Tipo = Enum.GetName(typeof(TipodePersonaje), rand.Next(1, Enum.GetNames(typeof(TipodePersonaje)).Length));
            nuevoper.Nombre = Enum.GetName(typeof(NombredePersonaje), rand.Next(1, Enum.GetNames(typeof(NombredePersonaje)).Length));


            return nuevoper;

        }



    }
}

      

 