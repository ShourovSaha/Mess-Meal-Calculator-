using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MessMealCalcualtorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****** Bechelor House Meal Calculator ******\n\n");


            Console.WriteLine("How Many Person Live in  Bachelor House :");
            int totalPerson = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("\n");
            //Person person = new Person();
            List<Person> personList = new List<Person>();

            for(int i = 0; i < totalPerson; i++)
            {
                Console.WriteLine("Person " + (i + 1) + " :\n");
                Console.WriteLine("Enter Person's Name :");
                string name = Console.ReadLine();

                Console.WriteLine("Enter Person's Total Shoping Cost:");
                double shopingCost = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter Person's Total Meal :");
                double meal = Convert.ToDouble(Console.ReadLine());

                Person aPerson = new Person(name, shopingCost, meal);
                personList.Add(aPerson);

                Console.WriteLine("*************************");
            }

            //
            Console.WriteLine("*************************");
            Console.WriteLine("Total Shoping Cost :" + Person.totalShopingCost + " Taka" );
            Console.WriteLine("\nTotal Meal :" + Person.totalMeal);
            Console.WriteLine("\nMeal Rate :" + MealRate () + " Taka");

            Console.WriteLine("*************************");

            Console.WriteLine("---Show Detail Informations---\n\n");

            int seiralNo = 0;
            foreach (var value in personList)
            {
                Console.WriteLine("Person " + (++seiralNo) + " :\n");

                Console.WriteLine("Name : " + value.name + 
                    "\nTotal Shoping :" + value.shopingCost + 
                    "\nTotal Meal :" + value.meal +
                    "\nTotal Meal Cost :" +  PersonMealCost(value.meal) +
                    "\nDue :" + Due(value.meal, value.shopingCost)  +" taka");

                Console.WriteLine("\n\n&&&&&&&&&&&&&&&&&&&&\n\n");
            }

            //
            double PersonMealCost(double meal)
            {
                return meal * MealRate();
            }
            //
            double MealRate()
            {
                return Person.totalShopingCost / Person.totalMeal;
            }

            //
            double Due(double meal, double shopingCost)
            {
                return Math.Floor(shopingCost - PersonMealCost(meal));
               
            }

            //
            //string CheckingMealCalculationCorrectOrNot()
            //{
            //    if(Person.totalShopingCost * Person.totalMeal )
            //}

            Console.ReadKey();
        }
    }
}
