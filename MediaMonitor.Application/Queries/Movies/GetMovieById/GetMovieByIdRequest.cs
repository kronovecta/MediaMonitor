using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediaMonitor.Application.Queries.Movies
{
    public class GetMovieByIdRequest : IRequest<GetMovieByIdResponse>
    {
        public int Id { get; set; }
    }
}
