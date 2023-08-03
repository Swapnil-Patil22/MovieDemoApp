using System;
using System.Collections.Generic;

namespace AssigmentDemoApp.Models
{
    /// <summary>
    /// Details of movie
    /// </summary>
    public class Movie
    {
        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public int Id { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string Title { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("overview")]
        public string Overview { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("release_date")]
        public string ReleaseDate { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("poster_path")]
        public string PosterPath { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("vote_average")]
        public double VoteAverage { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("vote_count")]
        public double VoteCount { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("genre_ids")]
        public List<int> GenreIds { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("popularity")]
        public double Popularity { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("original_language")]
        public string OriginalLanguage { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("original_title")]
        public string OriginalTitle { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("backdrop_path")]
        public string BackdropPath { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("adult")]
        public bool IsAdult { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("video")]
        public bool HasVideo { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("runtime")]
        public int? Runtime { get; set; }

        // Add more properties as needed
    }

    public class TmdbApiResponse
    {
        [System.Text.Json.Serialization.JsonPropertyName("results")]
        public List<Movie> Results { get; set; }
        // Add more properties as needed to match the API response
    }
}

