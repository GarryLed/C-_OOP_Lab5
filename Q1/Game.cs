using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    public abstract class  Game // abstract class 
    {
        // properties 
        #region Properties 

        private readonly string _name; // can only be set in the constructor 
        public string Name { get { return _name; } }

        protected decimal Price { get; set; } // visible outside of the class but only child classes 
        public DateTime ReleaseDate { get; set; }

        #endregion Properties


        // constructor linking / initializers 
        #region Constructors 
        public Game(string name, decimal price, DateTime releasedate)
        {
        
            _name = name;
            Price = price;
            ReleaseDate = releasedate;
            
        }

        public Game(string name, decimal price) : this(name, price, DateTime.Now) { } // ": this" refers to the main constructor above  

        public Game() : this("", 0) { } // : this will look for a constructor with a string element and a number (I don't understand why this is necessary) CIRCLE BACK AND REVIEW 


        #endregion Constructors 


        // to string method 
        public override string ToString() 
        {
            return $"{Name, -10}{Price:c} {ReleaseDate, -10}";
        }

        // UpdatePrice abstract method that can be used in child classes  (method declaration which has no implementation) 
        public abstract void UpdatePrice(decimal percentageIncrease);
    }
}
