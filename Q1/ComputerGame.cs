using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class ComputerGame : Game
    {
        public string PEGI_Rating {  get; set; }  


        #region Constructor 
        public ComputerGame(string name, decimal price, DateTime date, string pegi) : base(name, price, date)
        {
            PEGI_Rating = pegi;
        }

        #endregion

        public override string ToString()
        {
            return base.ToString() + $"{PEGI_Rating}";
        }

        public decimal GetDiscountPrice()
        {
            return Price * .9m; 
        }

        // UpdatePrice method 
        public override void UpdatePrice(decimal percentageIncrease) 
        {
            base.UpdatePrice(percentageIncrease);
            Console.WriteLine("updating price from the ComputerGame class");
        }
    }
}
