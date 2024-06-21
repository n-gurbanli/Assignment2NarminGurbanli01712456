using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2NarminGurbanli01712456.Controllers
{
    public class MenuController : ApiController
    {   //Question 1: Adapted J1 - The New CCC (Canadian Calorie Counting)
        /// <summary>
        /// At Chip’s Fast Food emporium there's a very simple menu. Each food item is selected by  entering a digit choice.
        /// By enetering digits the output has to count how many calories there are in the chosen menu
        /// </summary>
        /// <param name="burger">Input number that chooses burger</param>
        /// <param name="drink">Input number that chooses drink</param>
        /// <param name="side">Input number that chooses side</param>
        /// <param name="dessert">Input number that chooses dessert</param>
        /// <returns>
        /// "Your total calorie count is" + totalCalories (burger calories + drinks calories + side calories + dessert calories)
        /// </returns>
        /// <example>
        /// GET localhost:xx/api/Menu/4/4/4/4 -> "Your total calorie count is 0"
        /// GET localhost:xx/api/Menu/1/2/3/4 -> "Your total calorie count is 691"
        /// </example>

        //This I did at first but then after working on problem J3, I came to another solution. I didn't delete the first one because it still worked, it was just a bit to long

        /*[HttpGet]
        [Route("api/Menu/{burger}/{drink}/{side}/{dessert}")]
        public string Menu(int burger, int drink, int side, int dessert)
        {

            //burger choices {burger}

            int burgerCalorie = 0;

            if (burger == 1) //1 - Cheeseburger (461 Calories)
            {
                burgerCalorie = 461;
            }
            else if (burger == 2) //2 - Fish Burger (431 Calories)
            {
                burgerCalorie = 431;
            }
            else if (burger == 3) //3 - Veggie Burger (420 Calories)
            {
                burgerCalorie = 420;
            }
            else if (burger == 4) //4 - no burger
            {
                burgerCalorie = 0;
            }
            else
            {
                return "Invalid burger choice.";
            }

            //drink choices {drink}

            int drinkCalorie = 0;

            if (drink == 1) //1 - Soft Drink (130 Calories)
            {
                drinkCalorie = 130;
            }
            else if (drink == 2) //2 - Orange Juice (160 Calories)
            {
                drinkCalorie = 160;
            }
            else if (drink == 3) //3 - Milk (118 Calories)
            {
                drinkCalorie = 118;
            }
            else if (drink == 4) //4 - no drink
            {
                drinkCalorie = 0;
            }
            else
            {
                return "Invalid drink choice.";
            }

            //side choices {side}

            int sideCalorie = 0;

            if (side == 1) //1 - Fries (100 Calories)
            {
                sideCalorie = 100;
            }
            else if (side == 2) //2 - Baked Potato (57 Calories)
            {
                sideCalorie = 57;
            }
            else if (side == 3) //3 - Chef Salad (70 Calories)
            {
                sideCalorie = 70;
            }
            else if (side == 4) //4 - no side
            {
                sideCalorie = 0;
            }
            else
            {
                return "Invalid side choice.";
            }

            //dessert choices {dessert}

            int dessertCalorie = 0;

            if (dessert == 1) //1 - Apple Pie (167 Calories)
            {
                dessertCalorie = 167;
            }
            else if (dessert == 2) //2 - Sundae (266 Calories)
            {
                dessertCalorie = 266;
            }
            else if (dessert == 3) //3 - Fruit Cup (75 Calories)
            {
                dessertCalorie = 75;
            }
            else if (dessert == 4) //4 - no dessert
            {
                dessertCalorie = 0;
            }
            else
            {
                return "Invalid dessert choice.";
            }


            //Calculating total calories
            int totalCalories = burgerCalorie + drinkCalorie + sideCalorie + dessertCalorie;
            return "Your total calorie count is " + totalCalories;
        }*/

        //This is the second solution that is much shorter and easier 

        [HttpGet]
        [Route("api/Menu/{burger}/{drink}/{side}/{dessert}")]
        public string Menu(int burger, int drink, int side, int dessert)
        {

            int[] burgerCalories = { 0, 461, 431, 420, 0 }; //This is for burger menu, first 0 is used for the program to start counting from 1
            int[] drinkCalories = { 0, 130, 160, 118, 0 }; //This is for drink menu
            int[] sideCalories = { 0, 100, 57, 70, 0 }; //This is for side menu
            int[] dessertCalories = { 0, 167, 266, 75, 0 }; //This is for dessert menu


            if (burger < 1 || burger > 4) return "Invalid burger choice."; //input should be only from 1 to 4
            if (drink < 1 || drink > 4) return "Invalid drink choice.";
            if (side < 1 || side > 4) return "Invalid side choice.";
            if (dessert < 1 || dessert > 4) return "Invalid dessert choice.";

            int totalCalories = burgerCalories[burger] + drinkCalories[drink] + sideCalories[side] + dessertCalories[dessert];

            return "Your total calorie count is " + totalCalories;
        }

    }
}
