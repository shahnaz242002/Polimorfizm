using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    public class Valyer
    { 
      {
       public string Animal { get; set; }
       public string Name { get; set; }
       public string Biom { get; set; }
       public string Area { get; set; }

      }

    public Valyer(string animal, string name, string biom, string area)
        {
            Animal = animal;
            Name = name;
            Biom = biom;
            Area = area;
            _type;
        }
       public void Consist (string new animal)
        {
         Console.WriteLine($"Name:{Name} {_type}");
        }
       public void Settle (string new animal)
        {
          
        }
      public void Remove (string animal)
        {
          for (int i = 0; i < animal.Length; i++) 
             {
               if (animal.Equals(animal[i]))
                   {
                    animal.Remove(i)
                    break;
                   }
             }
        }
   }
}
