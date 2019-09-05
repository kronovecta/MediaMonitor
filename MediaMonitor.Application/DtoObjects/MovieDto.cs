using System;
using System.Collections.Generic;
using System.Text;

namespace MediaMonitor.Application.DtoObjects
{
    public class MovieDto
    {
        public int IdMovie { get; set; }
        public int? IdFile { get; set; } // FK to files table
        public string LocalTitle { get; set; } // Local Title || C00
        public string DescriptionLong { get; set; } // Description || C01
        public string PlotOutline { get; set; } // Plot outline || C02
        public string DescriptionShort { get; set; } // Short description || C03
        public string C04 { get; set; } // Not used || C04
        public string FK_RatingTable { get; set; } // Link to rating table || C05
        public string Writer { get; set; } // Writer || C06
        public string C07 { get; set; } // Not used || C07
        public string Thumbnail { get; set; } // Thumbnail || C08
        public string IMDB_ID { get; set; } // IMDB ID || C09
        public string SortingTitle { get; set; } // Title formatted for sorting || C10
        public string RunTime { get; set; } // Runtime || C11
        public string Rating { get; set; } // Rating || C12
        public string IMDBtop250 { get; set; } // IMDB Top 250 Ranking || C13
        public string Genre { get; set; } // Genre || C14
        public string Director { get; set; } // Director || C15
        public string OriginalTitle { get; set; } // Original Movie Title  || C16
        public string C17 { get; set; } // Thumb URL Spoof / Empty || C17
        public string Studio { get; set; } // Studio || C18
        public string YouTubeTrailerId { get; set; } // Trailer YouTube ID || C19
        public string FanartUrl { get; set; } // Fanart URLs || C20
        public string Country { get; set; } // Country
        public string FilePath { get; set; } // Path to playable file
        public string FK_PathTable { get; set; } // Link to path table for source folder
        public int? IdSet { get; set; } // FK to sets table
        public int? Userrating { get; set; } // User applied rating
        public string Premiered { get; set; } // Premiere date

        public virtual List<string> ThumbnailList { get; set; } // Formatted thumbnail URLs

        public MovieDto()
        {
            ThumbnailList = new List<string>();
        }
    }
}
