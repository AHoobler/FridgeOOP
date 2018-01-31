using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridgeOOP
{
    public class Fridge // Make the class public
    {
        //fields (camelCase)

        private bool isClean; //no access
        private string dispenserType;
        private int foodAmount;
        private bool bulbsWork;


        //Properties(pascal). GET SET, get: allows us to see the private values,  set: assign value
        public bool IsClean
        {
            get { return this.isClean; }
            set { this.isClean = value; }
        }

        public string DispenserType
        {
            get { return this.dispenserType; }
            //set { this.dispenserType = value; } don't need, do not want any one to change. 
            //Can set with a string so that all will have tha same value and the user will not be able to change.
            
        }

        public int FoodAmount
        {
            get { return this.foodAmount; }
            set { this.foodAmount = value; }
        }

        public bool BulbsWork
        {
            get { return this.bulbsWork; }
            set { this.bulbsWork = value; }
        }

        //Constructors, allow us to create instance of the class(object) in another class

        // always need default constuctor
        public Fridge() // constructors are always public
        {
            this.dispenserType = "basic water dispencer";
        }

        public Fridge(string dispenserType)
        {
            this.dispenserType = dispenserType;
        }

        public Fridge(bool isClean, string dispenserType, bool bulbsWork, int foodAmount)
        {
            this.isClean = isClean;
            this.foodAmount = foodAmount;
            this.dispenserType = dispenserType;
            this.bulbsWork = bulbsWork;
        }


        //Methods()
        // Dispense water
        public void DispenseWater()
        {
            if (dispenserType == "basic water dispenser")
            {
                Console.WriteLine("Here's some lukewarm water");
            }
            else if (dispenserType == "deluxe water dispenser")
            {
                Console.WriteLine("Enjoy your perfect icewater");
            }
            else
            {
                Console.WriteLine("What's going to some out? It's a surprise!");
            }
        }


        //change bulbs
        public string ChangeBulbs()
        {
            if(bulbsWork == false)
            {
                bulbsWork = true;
                return "The bulbs have been changed";
            }
            else
            {
                return "The bulbs don't have to be changed";
            }

          
        }

        // remove food
        public void RemoveFood(int foodRemoved) // pass in an int
        {
            foodAmount -= foodRemoved; //decreasing the value of food amout by the value of food removed 

        }
        //Clean it
        public string Clean(bool isDirty) // pass in a bool
        {
            if  (isDirty)
            {
                isClean = true;
                return "I cleaned the fridge";
            }
            else
            {
                return "The fridge is already clean";
            }
        }



        //Check supplies
        public string CheckSupplies()
        {
            if (foodAmount >= 80)
            {
                return "fully stocked";
            }
            else if (foodAmount > 40)
            {
                return "getting low";
            }
            else 
            {
                return "time to grocery shop";
            }
        }
    }
}
