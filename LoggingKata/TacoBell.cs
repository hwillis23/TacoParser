﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LoggingKata
{
    public class TacoBell : ITrackable    //conform to Itrackable

    {

        public TacoBell()    //add constructor first 
        {

        }

        public string Name { get; set; }
        public Point Location { get; set; }

    }


}
