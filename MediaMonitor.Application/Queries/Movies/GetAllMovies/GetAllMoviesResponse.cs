using MediaMonitor.Application.DtoObjects;
using System.Collections.Generic;

namespace MediaMonitor.Application.Queries.Movies
{
    public class GetAllMoviesResponse
    {
        public List<MovieDto> Movies { get; set; }
    }
}