using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgProvDel1
{
    class Program
    {
        delegate void SetSkillLevel();

        static void Strength()
        {
            // bonus till strength
        }

        static void Speed()
        {
            // bonus till speed osv
        }

        static void Intelligence()
        {

        }

        static void Main(string[] args)
        {
            List<SuperHero> superHeroes = new List<SuperHero>(); // lista för superhjältar
            Dictionary<string, SetSkillLevel> options = new Dictionary<string, SetSkillLevel>(); // dictionary med attributmodifierinsmetoderna
            options["1"] = Strength;
            options["2"] = Speed;
            options["3"] = Intelligence;

            // här börjar character creation
            Console.WriteLine("What is your name");
            string name = Console.ReadLine(); 
            Console.WriteLine("So, {0}, what is your super power?", name);
            string superPower = Console.ReadLine(); // har ingen riktig betydelse för sin bonus attribut väljs senare
            Console.WriteLine("And what attribute of yours is the most super?");
            Console.WriteLine("1) Strength \n2) Speed \n3) Intelligence");
            // i denna loop ska karaktären skapas med hjälp av de variabler som gavs innan samt i loopen
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int option)) // input är en siffra
                {
                    if (option > 0 && option < 4) // siffran är giltig
                    {
                        options[option.ToString()](); // tar input som index
                    }
                    // siffran är inte giltig och while loopen körs igen
                }
                else 
                {
                    // input är inte en siffra
                    Console.WriteLine("Enter a number (1-3)");
                }
                
            }
        }
    }
}
