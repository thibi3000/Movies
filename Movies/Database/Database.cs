using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Movies.Models;

namespace Movies.Database
{
    public class Database
    {
        //List of movies
        private List<Movie> Movies = new List<Movie>
        {
            new Movie {Id = 0, Title="dsfd", RunningTimeInMins=500, StudioId=0},
            new Movie {Id = 1, Title="slkie", RunningTimeInMins=560, StudioId=1}
        };

        private List<Studio> Studios = new List<Studio>
        {
            new Studio {Id = 0, Name="dgjdks", HQCity="Copenhagen", NoOfEmployees=50 },
            new Studio {Id = 1, Name="dskfjd", HQCity="Roskilde", NoOfEmployees=78 }
        };
    }
}
