using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediaMonitor.Application.DtoObjects;
using MediaMonitor.Application.Queries.Movies;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MediaMonitor.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MovieController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MovieDto>>> GetAsync()
        {
            var query = await _mediator.Send(new GetAllMoviesRequest());
            if(query != null)
            {
                return Ok(query);
            } else
            {
                return NotFound();
            }
        }
    }
}