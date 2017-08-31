using System;
using System.Collections.Generic;

namespace Movie.Models
{
    public class MovieInfo
    {
        public string Name { get; set; }
        public List<ShowTime> ShowTimes { get; set; }

    }

    public class ShowTime
    {
        public DateTime Start { get; set; }

    }


}
