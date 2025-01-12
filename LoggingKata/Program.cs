﻿using System;
using System.Linq;
using System.IO;
using GeoCoordinatePortable;

namespace LoggingKata
{
    class Program
    {
        static readonly ILog logger = new TacoLogger();
        const string csvPath = "TacoBell-US-AL.csv";

        static void Main(string[] args)
        {
            // TODO:  Find the two Taco Bells that are the furthest from one another.
            // HINT:  You'll need two nested forloops ---------------------------

            //logger.LogInfo("Log initialized");//  DON'T NEED

            // use File.ReadAllLines(path) to grab all the lines from your csv file
            // Log and error if you get 0 lines and a warning if you get 1 line
            var lines = File.ReadAllLines(csvPath);

           // logger.LogInfo($"Lines: {lines[0]}");//   DONT NEED 

            // Create a new instance of your TacoParser class
            var parser = new TacoParser();

            // Grab an IEnumerable of locations using the Select command: var locations = lines.Select(parser.Parse);
            var locations = lines.Select(parser.Parse).ToArray();

            // DON'T FORGET TO LOG YOUR STEPS - dont worry about this part -DONE

            // Now that your Parse method is completed, START BELOW ----------****************

            // TODO: Create two `ITrackable` variables with initial values of `null`. These will be used to store your two taco bells that are the farthest from each other.
            // Create a `double` variable to store the distance  -DONE   (these are holding variables which i why they = null)
            ITrackable location1 = null;
            ITrackable location2 = null;
            double distance = 0;

            // Include the Geolocation toolbox in the loops below, so you can compare locations: `using GeoCoordinatePortable;` ---this is a using directive ( it's a USING statement at the very top) 

            //HINT NESTED LOOPS SECTION---------------------
            // Do a loop for your locations to grab each location as the origin (perhaps: `locA`) 
            foreach (var locationA in locations)
            {
                var cordinA = new GeoCoordinate(locationA.Location.Latitude, locationA.Location.Longitude);

                foreach (var locationB in locations)
                {
                    var cordinB = new GeoCoordinate(locationB.Location.Latitude, locationB.Location.Longitude);

                    var compareDistance =cordinA.GetDistanceTo(cordinB);

                    if(compareDistance > distance)
                    {
                        distance = compareDistance;
                        location1 = locationA;
                        location2 = locationB;
                    }


                }

            }

            Console.WriteLine($" {location2.Name} is furtherest away from {location1.Name}. The distance is {distance} meters.");

            // Create a new corA Coordinate with your locA's lat and long - DONE

            // Now, do another loop on the locations with the scope of your first loop, so you can grab the "destination" location (perhaps: `locB`)

            // Create a new Coordinate with your locB's lat and long -DONE

            // Now, compare the two using `.GetDistanceTo()`, which returns a doubleCor -DONE
            // If the distance is greater than the currently saved distance, update the distance and the two `ITrackable` variables you set above (to give it a value instead of null)

            // Once you've looped through everything, you've found the two Taco Bells farthest away from each other.-DONE 



    //distance 


            
        }
    }
}
