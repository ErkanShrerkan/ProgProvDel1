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
            Dictionary<string, SetSkillLevel> options = new Dictionary<string, SetSkillLevel>();
            options["1"] = Strength;
            options["2"] = Speed;
            options["3"] = Intelligence;

            Console.WriteLine("What is your name");
            string name = Console.ReadLine();
            Console.WriteLine("So, {0}, what is your super power?", name);
            string superPower = Console.ReadLine();
            Console.WriteLine("And what attribute of yours is the most super?");
            Console.WriteLine("1) Strength \n2) Speed \n3) Intelligence");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int option))
                {
                    if (option > 0 && option < 4)
                    {
                        options[option.ToString()](); // tar input som index
                    }
                }
                else
                {
                    Console.WriteLine("Enter a number (1-3)");
                }
                
            }
        }
    }
}
