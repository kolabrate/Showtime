using System;
using System.Collections.Generic;

namespace Movie.Models
{
    public class MovieInfo
    {
        public string Name { get; set; }
        public int Duration { get; set; }
        public List<ShowTime> ShowTimes { get; set; }

    }
    public class ShowTime
    {
        public DateTime Start { get; set; }
        public Location Location { get; set; }
    }

    //To be done - Location class needs more properties.
    public class Location 
    {
        public string Theater { get; set; }

    }


}
