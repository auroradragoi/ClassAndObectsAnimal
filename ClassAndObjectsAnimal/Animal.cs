using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAndObjectsAnimal
{
    public class Animal
    {
        public string tipAnimal { get; set; }
        public string culoare { get; set; }
        public int varsta { get; set; }

        public Animal()
        {
            tipAnimal = "";
            culoare = "";
            varsta = 0;
        }
        public Animal(string rasa)
        {
            this.tipAnimal = rasa;
            this.culoare = "";
            this.varsta = 0;

        }
        public Animal(string type, string color, int age)
        {
            this.tipAnimal = type;
            this.culoare = color;
            this.varsta = age;

        }

    }
}
