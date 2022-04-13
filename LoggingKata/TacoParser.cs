namespace LoggingKata
{
    /// <summary>
    /// Parses a POI file to locate all the Taco Bells
    /// </summary>
    public class TacoParser
    {
        //readonly ILog logger = new TacoLogger();// (DONT NEED) 
        
        public ITrackable Parse(string line)
        {
           // logger.LogInfo("Begin parsing");// (DONT NEED) 

            // Take your line and use line.Split(',') to split it up into an array of strings, separated by the char ','
            var cells = line.Split(',');

            // If your array.Length is less than 3, something went wrong
            if (cells.Length < 3)
            {
                // Log that and return null -- Do not do ************
                // Do not fail if one record parsing fails, return null
                return null; // TODO Implement
            }

            // grab the latitude from your array at index 0    ------start here; lat and long are found in .CSV file ---------------
            var latitude = double.Parse(cells[0]);
            // grab the longitude from your array at index 1
            var longitude = double.Parse(cells[1]);
            // grab the name from your array at index 2
            var name = cells[2];
            // You're going to need to parse your string as a `double` -DONE
            // which is similar to parsing a string as an `int`

            // You'll need to create a TacoBell class (add a class box) -DONE
            // that conforms to ITrackable   
            //Do not forget to add a constructor first before transfering Itrackable info -DONE

            // Then, you'll need an instance (var x = new x ();) of the TacoBell class (add a instance in the tacobell parser class aka in the class right now)
            // With the name and point set correctly (assigning the value) 
            var point = new Point 
            { 
                Latitude = latitude, Longitude = longitude             //this adds value to the new Point 
            };
            var tacoBell = new TacoBell();
            tacoBell.Location = point;
            tacoBell.Name = name;


            // Then, return the instance of your TacoBell class (instance) _DONE
            // Since it conforms to ITrackable

            return tacoBell;
        }
    }
}