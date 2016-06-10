using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    /**
     * Assignment 2
     * Author name: Tetiana Reznychenko
     * Student number: 300870231
     * Date last Modified: 10/06/2016 3.20 pm
     * Program description: Using MS Visual Studio, Build and Implement a SuperHero Class, 
     * SuperHero class is a subclass of the Hero superclass from Assignment 1
     */

    /**
     * <summary>
     * This is the SuperHero class. It is derived from Hero class 
     * </summary>
     * 
     * @class SuperHero 
     * @extends Hero 
     */
    class SuperHero : Hero
    {
        //PRIVATE INSTANCE VARIABLES +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        private string[] _superPowers;

        //PUBLIC PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
          * <summary>
          * This is a public property for _superPowers field
          * </summary>
          * 
          * @property {string[]} SuperPowers
          */

        public string[] SuperPowers
        {
            get
            {
                return _superPowers;
            }
            set
            {
                this._superPowers = value;
            }
        }
        //CONSTRUCTORS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
         * <summary>
         * This constructor takes for the SuperHero class name parameter
         * </summary>
         * 
         * @constructor SuperHero
         * @extends Hero
         * @param {string} name
         */
        public SuperHero(string name)
            :base(name)
        {
            _generateRandomPowers();
        }

        //PRIVATE METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
         * <summary>
         * This method randomly generates three random superpowers from the list of 6 powers.
         * </summary>
         * 
         * @method _generateRandomPowers()
         * @return {void}
         */

        private void _generateRandomPowers()
        {
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

        }

        //PUBLIC METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
         * <summary>
         * This method displays the Hero’s super powers to the console.
         * </summary>
         * 
         * @method ShowPowers
         * @return {void}
         */
        public void ShowPowers()
        {
            _generateRandomPowers();

            string first = _superPowers[0];
            string second = _superPowers[1];
            string third = _superPowers[2];

            Console.WriteLine("***************************");
            Console.WriteLine("         " + this.Name);
            Console.WriteLine("MAXIUM POWER!");
            Console.WriteLine("Your new abilities:");
            Console.WriteLine("1. " + first);
            Console.WriteLine("2. " + second);
            Console.WriteLine("3. " + third);
            Console.WriteLine("***************************");
            Console.WriteLine("But remember: With great power comes great responsibility (c)");
            Console.WriteLine("Good Luck!");

            //foreach (string value in _superPowers)
            //{
            //Console.WriteLine(value);
            //}
        }




        }

    }
