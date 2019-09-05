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
    public class GetMovieByIdHandler : IRequestHandler<GetMovieByIdRequest, GetMovieByIdResponse>
    {
        private readonly IKodiContext _context;
        private readonly IMapper _mapper;
        public GetMovieByIdHandler(IKodiContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<GetMovieByIdResponse> Handle(GetMovieByIdRequest request, CancellationToken cancellationToken)
        {
            var query = await _context.Movie.ProjectTo<MovieDto>(_mapper.ConfigurationProvider).SingleOrDefaultAsync(x => x.IdMovie == request.Id);

            var response = new GetMovieByIdResponse()
            {
                Movie = query
            };

            return response;
        }
    }
}
