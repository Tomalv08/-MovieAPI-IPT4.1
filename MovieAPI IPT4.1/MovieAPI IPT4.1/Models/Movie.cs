﻿    namespace MovieAPI_IPT4_1.Models
    {
    public class Movie
    {
        public string? Title { get; set; }
        public string? Year { get; set; }
        public string? imdbID { get; set; }
        public string? Type { get; set; }
        public string? Poster { get; set; }
        public string? Genre { get; set; }
        public string? Director { get; set; }
        public string? Writer { get; set; }
        public string? Actors { get; set; }
        public string? Runtime { get; set; }
        public string? Plot { get; set; }
        public string? Rated { get; set; }
        public string? Released { get; set; }
        public string? Language { get; set; }
        public string? Country { get; set; }
        public string? Awards { get; set; }
        public string? imdbRating { get; set; }
        public string? Metascore { get; set; }
        public string? imdbVotes { get; set; }  
        public List<Rating> Ratings { get; set; }
        // Weitere Felder entsprechend der JSON-Struktur hinzufügen
    }

    public class Rating
    {
        public string? Source { get; set; }
        public string? Value { get; set; }
    }


}
