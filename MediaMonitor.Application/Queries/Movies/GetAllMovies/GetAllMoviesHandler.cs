using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediaMonitor.Application.DtoObjects;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MediaMonitor.Application.Queries.Movies
{
    public class GetAllMoviesHandler : IRequestHandler<GetAllMoviesRequest, GetAllMoviesResponse>
    {
        private readonly IKodiContext _context;
        private readonly IMapper _mapper;

        public GetAllMoviesHandler(IKodiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<GetAllMoviesResponse> Handle(GetAllMoviesRequest request, CancellationToken cancellationToken)
        {
            var query = _context.Movie.OrderBy(x => x.IdFile);
            var response = new GetAllMoviesResponse()
            {
                Movies = await query.ProjectTo<MovieDto>(_mapper.ConfigurationProvider).ToListAsync()
            };

            return response;
        }
    }
}
