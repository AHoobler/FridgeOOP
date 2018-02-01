using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridgeOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // create an interactive console window
            // prompt usr what to do with th fridge
            // call methods on bridge object to do what the user wants

            int userChoice;
            Fridge userFridge = new Fridge(false, "deluxe dispnser", 70, true);
            do
            {
                Console.WriteLine("Hello, welcome to the fridge app");
                Console.WriteLine("What would you like to do with your fridge?");
                Console.WriteLine("To dispense water, type, 1");
                Console.WriteLine("To change lightbulb, type 2");
                Console.WriteLine("To clean, type 3");
                Console.WriteLine("To take food type 4");
                Console.WriteLine("To check food supplies, type 5");
                Console.WriteLine("To see all fridge details, type 6");
                //Console.WriteLine("To restart, type 7");
                Console.WriteLine("To quit, type 8");

                // give user the change to change the constructor, these are hard coded
                userChoice = int.Parse(Console.ReadLine());
               

                switch(userChoice)
                {
                    case 1:
                        userFridge.DispenseWater();
                        break;

                    case 2:
                        Console.WriteLine(userFridge.ChangeBulbs());
                        break;

                    case 3:
                        Console.WriteLine(userFridge.Clean());
                        break;

                    case 4:
                        Console.WriteLine("How many units of food do you want to eat?");
                        int foodEaten = int.Parse(Console.ReadLine());
                        userFridge.RemoveFood(foodEaten);
                        //Console.WriteLine(userFridge.RemoveFood);
                        break;

                    case 5:
                        Console.WriteLine(userFridge.CheckSupplies());
                        break;

                    case 6:
                        Console.WriteLine("The fridge is clean " + userFridge.IsClean + ", the bulb is working, " + userFridge.BulbsWork + ", The food amount is " +  userFridge.FoodAmount + ", The dispenser type is " + userFridge.DispenserType);
                        break;

                }



                

            } while (userChoice != 8);
        }
    }
}
