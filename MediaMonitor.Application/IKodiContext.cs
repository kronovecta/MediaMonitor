using MediaMonitor.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MediaMonitor.Application
{
    public interface IKodiContext
    {
        //DbSet<Actor> Actor { get; set; }
        //DbSet<Art> Art { get; set; }
        //DbSet<Bookmark> Bookmark { get; set; }
        //DbSet<Country> Country { get; set; }
        //DbSet<Episode> Episode { get; set; }
        //DbSet<Files> Files { get; set; }
        //DbSet<Genre> Genre { get; set; }
        DbSet<Movie> Movie { get; set; }
        //DbSet<Musicvideo> Musicvideo { get; set; }
        //DbSet<Path> Path { get; set; }
        //DbSet<Rating> Rating { get; set; }
        //DbSet<Seasons> Seasons { get; set; }
        //DbSet<Sets> Sets { get; set; }
        //DbSet<Studio> Studio { get; set; }
        //DbSet<Tag> Tag { get; set; }
        //DbSet<Tvshow> Tvshow { get; set; }
        //DbSet<Uniqueid> Uniqueid { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
        Task<int> SaveChangesAsync();

    }
}
