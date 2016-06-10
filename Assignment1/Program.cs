using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    /**
     * Author name: Tetiana Reznychenko
     * Student number: 300870231
     * Date last Modified: 03/06/2016 8.20 pm
     * Program description: Using MS Visual Studio, Build and Implement a Hero Class
     * 
     * @class Program 
     */
    class Program
    {
        /**
         * The main method for driver class Program 
         * 
         * @method Main 
         * @param {string[]} args
         */

        static void Main(string[] args)
        {
            //create a new istance of the Hero class
            Hero blitzkrieg = new Hero("Blitzkrieg");
            blitzkrieg.Show();
            Console.WriteLine("***************************");
            Console.WriteLine("");
            blitzkrieg.Fight();

            Random powers = new Random();

            string[] _superPowers = new string[] { "Super Speed", "Super Strength", "Body Armour", "Flight", "Fire Generation", "Weather Control" };
            int n = _superPowers.Length;
            for (int i = 0; i < n; i++)
            {
                int r = i + (int)(powers.NextDouble() * (n - i));
                string t = _superPowers[r];
                _superPowers[r] = _superPowers[i];
                _superPowers[i] = t;




              
            }
            string first = _superPowers[0];
            string second = _superPowers[1];
            string third = _superPowers[2];
            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(third);



        }
    }
}
