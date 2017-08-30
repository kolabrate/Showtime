using System;
using System.Collections.Generic;
using Showtime.Models;
using Showtime.Models.models;


namespace Showtime.Service
{
    public interface IGetShowTime
    {
       List<ShowTime> GetShowTimesForaMovie(string movieName);
    }
}
