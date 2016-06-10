using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    /**
     * <summary>
     * This class defines a Hero
     * </summary>
     * @class Hero
     * @field {int} _strength 
     * @field {int} _speed 
     * @field {int} _health 
     * @field {string} _name
     * 
     */
    public class Hero
    {
        //PRIVATE INSTANCE VARIABLES +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private int _strength;
        private int _speed;
        private int _health;
        private string _name;
        private readonly object set;

        //PUBLIC PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
         * <summary>
         * This is a public property for _name field
         * </summary>
         * 
         * @property {string} Name
         */

        public string Name
        {
            get
            {
                return this._name;
            }

            set
            {
                this._name = value;
            }
        }
        public int Strength
        {
            get
            {
                return this._strength;
            }

            set
            {
                Random abilities = new Random();
                this._strength = abilities.Next(1, 100);
            }
        }


        //CONSTRUCTORS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


        /**<summary>
         * This is the constructor that takes name as a parameter and passes it to the _name private instance variable 
         * </summary>
         * 
         * @constructor Hero
         * @param {string} name
         * 
         */
        public Hero(string name)
        {
            this.Name = name;
        }
         

        //PRIVATE METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This method randomly generates the ability numbers for the strength, speed and health properties.
         * </summary>
         * 
         * @method _generateAbilities()
         * @return {void}
         */
        private void _generateAbilities()
        {
            Random abilities = new Random();
            _strength = abilities.Next(1, 100);
            _speed = abilities.Next(1, 100);
            _health = abilities.Next(1, 100);
        }

        /**
         * <summary>
         * This method randomly determine if the Hero hits (this should be only 20%  of the time) otherwise it will return false. 
         * </summary>
         * 
         * @method _ghitAttempt()
         * @return {bool}
         */
        private bool _hitAttempt()
        {
            Random hit = new Random();
            int prob = hit.Next(100);
            if (prob < 20)
                return true;
            else
                return false;
        }
        /**
         * <summary>
         * This method calculates the damage the Hero causes to the targeton a hit
         * </summary>
         * 
         * @method _hitDamage()
         * @return {int}
         */
        private int _hitDamage()
        {
            Random hitdamage = new Random();
            int damage;
            damage = _strength * hitdamage.Next(1,6);
            return (damage);
        }

        //PUBLIC METHODS+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
         * <summary>
         * This method calls the private hitAttempt method. If hitAttempt returns true, then it will call the private hitDamage method.
         * </summary>
         * 
         * @method Fight
         * @return {void}
         */

        public void Fight()
        {
            bool hit = _hitAttempt();
            if (hit == true) 
            {
                Console.WriteLine(_hitDamage());
            }
            else
            {
                Console.WriteLine("You failed ^_^");
            } 

        }
        /**
         * <summary>
         * This method shows the name of the hero and randomly choose the abilities of the hero. 
         * </summary>
         * 
         * @method Show
         * @return {void}
         */
        public void Show()
        {
            Console.WriteLine("***************************");
            Console.WriteLine("         "   + this.Name);
            Console.WriteLine("***************************");
            Console.WriteLine("");
            _generateAbilities();
            Console.WriteLine("Strength of the hero: " + _strength);
            Console.WriteLine("Speed of the hero: " +_speed);
            Console.WriteLine("Health of the hero: "+_health); 
        }
    }
}
