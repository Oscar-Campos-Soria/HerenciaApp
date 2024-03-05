using System;
using System.Collections.Generic;
using System.Text;

namespace HerenciaApp
{
    class Perro: Animal
    {
        
        
            public Perro(string nombre, int edad) : base(nombre, edad)
            {
            }

            public override string EmitirSonido()
            {
                return "Guau guau";
            }
        }
    }
