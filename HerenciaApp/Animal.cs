using System;
using System.Collections.Generic;
using System.Text;

namespace HerenciaApp
{
    class Animal
    {
        
        
            public string Nombre { get; set; }
            public int Edad { get; set; }

            public Animal(string nombre, int edad)
            {
                Nombre = nombre;
                Edad = edad;
            }

            public virtual string EmitirSonido()
            {
                return "Sonido genérico de animal";
            }
        }
    }

