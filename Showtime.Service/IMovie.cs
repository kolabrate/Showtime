using System.Collections.Generic;
using Movie.Models;

namespace Movie.Service
{
    public interface IMovie
    {
       List<MovieInfo> GetShowTimesForaMovie(string movieName);
    }
}
