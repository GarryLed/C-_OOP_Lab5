using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    public abstract class  Game
    {
        // properties 
        #region Properties 

        private readonly string _name; // can only be assigned in the constructor 
        public string Name
        {
            get 
            {
                return _name; 
            }
        }

        protected decimal Price { get; set; } // visible outside of the class to only child classes 
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

        public Game(string name, decimal price) : this(name, price, DateTime.Now) { } // I need a better understanding of this line of code 

        public Game() : this("", 0) { } // I need a better understanding of this line of code 



        #endregion Constructors 


        // to string method 
        public override string ToString() 
        {
            return $"{Name, -10}{Price, -10}{ReleaseDate, -10}";
        }

        // UpdatePrice method 
        public virtual void UpdatePrice(decimal percentageIncrease)
        {
            Price *= (1 + percentageIncrease);
        }
    }
}
