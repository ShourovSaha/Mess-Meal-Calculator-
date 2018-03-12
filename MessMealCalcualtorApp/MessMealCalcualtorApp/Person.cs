using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessMealCalcualtorApp
{
    class  Person
    {
        public string name { get; set; }
        public double shopingCost { get; set; }
        public double meal { get; set; }

        public static double totalShopingCost = 0;
        public static double totalMeal = 0;


        //public Person()
        //{
        //    totalMeal += meal;
        //    totalShopingCost += shopingCost;
        //}


        public Person(string name, double shopingCost, double meal)
        {
            this.name = name;
            this.shopingCost = shopingCost;
            this.meal = meal;


            totalMeal += meal;
            totalShopingCost += shopingCost;
        }

        

        
    }
}
