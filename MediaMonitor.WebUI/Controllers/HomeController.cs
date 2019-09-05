using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MediaMonitor.WebUI.Models;
using MediatR;
using MediaMonitor.Application.Queries.Movies;
using MediaMonitor.Application.DtoObjects;

namespace MediaMonitor.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMediator _mediator;

        public HomeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var query = await _mediator.Send(new GetAllMoviesRequest());
            if(query != null)
            {
                foreach (var movie in query.Movies)
                {
                    if(movie.Thumbnail != "" && movie.Thumbnail != null)
                    {
                        movie.Thumbnail = movie.Thumbnail.Split("aspect=\"poster\" preview=\"")[1].Substring(0,62);
                    }
                }

                return View(query);
            } else
            {
                return View();
            }
        }

        public async Task<IActionResult> Details(int id)
        {
            var query = await _mediator.Send(new GetMovieByIdRequest() { Id = id });

            if (query.Movie.Thumbnail != "" && query.Movie.Thumbnail != null)
            {
                query.Movie.Thumbnail = query.Movie.Thumbnail.Split("aspect=\"poster\" preview=\"")[1].Substring(0, 62);
            }

            return View(query.Movie);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
