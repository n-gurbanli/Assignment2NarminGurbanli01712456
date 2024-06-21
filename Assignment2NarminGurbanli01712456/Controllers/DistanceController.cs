using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Web.Http;

namespace Assignment2NarminGurbanli01712456.Controllers
{
    public class DistanceController : ApiController
    {
        /// <summary>
        /// You would like to calculate a distance table that indicates the distance between any two of the cities you have encountered.
        /// </summary>
        /// <param name="d1">Distance between city 1 and city 2</param>
        /// <param name="d2">Distance between city 2 and city 3</param>
        /// <param name="d3">Distance between city 3 and city 4</param>
        /// <param name="d4">Distance between city 4 and city 5</param>
        /// <returns>
        /// The output should be 5 lines, with the ith line (1  i  5) containing the distance from city i to cities 1, 2, ... 5 in order, separated by one space.
        /// </returns>
        /// <example>
        /// GET localhost:xx/api/Distance/3/10/12/5 -> 0 3 13 25 30
        ///                                            3 0 10 22 27
        ///                                            13 10 0 12 17
        ///                                            25 22 12 0 5
        ///                                            30 27 17 5 0
        /// </example>

        //I added the J3 pdf file to repository 
        //So I tried to calculate the distance between cities by putting the int in array and then outputing it, but something is not correct, I don't think I have enough knowledge to solve this 
        [HttpGet]
        [Route("api/Distance/{d1}/{d2}/{d3}/{d4}")]
        public string Distance(int d1, int d2, int d3, int d4) //this is the 4 distances between 4 cities
        {

            // Calculate cumulative distances for each city pair
            int[] distances = { 0, d1, d1 + d2, d1 + d2 + d3, d1 + d2 + d3 + d4 };
            string[] outputLines = new string[5]; //Prepare an array to hold the output lines
            for (int i = 0; i < 5; i++) // Loop through each city to generate the distance table
            {
                outputLines[i] = distances[i] + " " + distances[i + 1] + " " + distances[i + 2] + " " + distances[i + 3] + " " + distances[i + 4];
            }

            //I dont know how to output this :( I tried returning outpuLines but they are not srings and it gives me an error

        }

    }
}
