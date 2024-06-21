using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Threading;
using System.Web.Http;

namespace Assignment2NarminGurbanli01712456.Controllers
{
    public class DiceGameController : ApiController
    {
        //Question 2: Adapted J2 - Roll the Dice
        /// <summary>
        /// Diana is playing a game with two dice. One dice has m sides labelled 1, 2, 3 ..., m
        /// The other dice has n sides labelled 1, 2, 3, …, n
        /// Write a program which determines how many ways she can roll the value of 10.
        /// </summary>
        /// <param name="m">the number of sides on first dice</param>
        /// <param name="n">the number of sides on second dice</param>
        /// <returns>
        /// "There are " + count + " total ways to get the sum 10."
        /// </returns>
        /// <example> 
        /// GET localhost:xx/api/DiceGame/6/8 -> There are 5 total ways to get the sum 10.
        /// GET localhost:xx/api/DiceGame/12/4 -> There are 4 total ways to get the sum 10.
        /// GET localhost:xx/api/DiceGame/3/3 -> There are 0 total ways to get the sum 10.
        /// GET localhost:xx/api/DiceGame/5/5 -> There is 1 total way to get the sum 10.
        /// </example>

        [HttpGet]
        [Route("api/DiceGame/{m}/{n}")]
        public string DiceGame(int m, int n)
        {

            if (m <= 0 || n <= 0)
            {
                return "Number of sides on both dice must be greater than zero.";
            } //we need this to prevent user input as less than 0 as sides of the dices cannot be 0

            int count = 0;

            for (int a = 1; a <= m; a++) //"a" here is value in dice "m"  
            {
                int b = 10 - a; //"b" is value on dice "n"
                if (b >= 1 && b <= n)
                {
                    count++;
                }
            }


            if (count == 1)
            {
                return "There is 1 way to get the sum 10."; //We need this for correct use of grammar
            }
            else
            {
                return "There are " + count + " total ways to get the sum 10.";
            }
        }
    }
}
