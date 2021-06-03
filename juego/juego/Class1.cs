﻿using System;
using System.Collections.Generic;
using System.Text;

namespace juego
{
  
   class Personaje
    {
        public enum TipodePersonaje
        {
            Ogro,
            Humano,
            hobbit,
        }

        private TipodePersonaje tipo;
        private string nombre;
        private string apodo;
        private DateTime fechadenacimiento;
        private int edad;
        private int salud;

        private int velocidad;
        private int destreza;
        private int fuerza;
        private int nivel;
        private int armadura;

        internal TipodePersonaje Tipo { get => tipo; set => tipo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apodo { get => apodo; set => apodo = value; }
        public DateTime Fechadenacimiento { get => fechadenacimiento; set => fechadenacimiento = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Salud { get => salud; set => salud = value; }
        public int Velocidad { get => velocidad; set => velocidad = value; }
        public int Destreza { get => destreza; set => destreza = value; }
        public int Fuerza { get => fuerza; set => fuerza = value; }
        public int Nivel { get => nivel; set => nivel = value; }
        public int Armadura { get => armadura; set => armadura = value; }
        
    }
    }
}