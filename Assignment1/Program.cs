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
     * Date last Modified: 10/06/2016 6.30 pm
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

            //create a new istance of the SuperHero classg
            SuperHero blitzkrieg = new SuperHero("Blitzkrieg");
            blitzkrieg.Show();
            Console.WriteLine();
            blitzkrieg.ShowPowers();
            Console.WriteLine();
            blitzkrieg.Fight();

   

        }
    }
}
