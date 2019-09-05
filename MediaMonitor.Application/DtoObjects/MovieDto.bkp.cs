using System;
using System.Collections.Generic;
using System.Text;

namespace MediaMonitor.Application.DtoObjects
{
    public class MovieDtoBkp
    {
        public int IdMovie { get; set; }
        public int? IdFile { get; set; } // FK to files table
        public string C00 { get; set; } // Local Title
        public string C01 { get; set; } // Description

        public string C02 { get; set; } // Plot outline
        public string C03 { get; set; } // Short description
        public string C04 { get; set; } // Not used
        public string C05 { get; set; } // Link to rating table
        public string C06 { get; set; } // Writer
        public string C07 { get; set; } // Not used
        public string C08 { get; set; } // Thumbnail
        public string C09 { get; set; } // IMDB ID

        public string C10 { get; set; } // Title formatted for sorting
        public string C11 { get; set; } // Runtime
        public string C12 { get; set; } // Rating
        public string C13 { get; set; } // IMDB Top 250 Ranking
        public string C14 { get; set; } // Genre
        public string C15 { get; set; } // Director
        public string C16 { get; set; } // Original Movie Title 

        public string C17 { get; set; } // Thumb URL Spoof / Empty
        public string C18 { get; set; } // Studio
        public string C19 { get; set; } // Trailer YouTube ID
        public string C20 { get; set; } // Fanart URLs
        public string C21 { get; set; } // Country
        public string C22 { get; set; } // Path to playable file
        public string C23 { get; set; } // Link to path table for source folder
        public int? IdSet { get; set; } // FK to sets table
        public int? Userrating { get; set; } // User applied rating
        public string Premiered { get; set; } // Premiere date
    }
}
