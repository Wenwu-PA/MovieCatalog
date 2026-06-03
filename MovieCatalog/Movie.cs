using System;

namespace VideoLibrary
{
    public class Movie
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public string Genre { get; set; }
        public string Year { get; set; }
        public string Status { get; set; }      // "Хочу посмотреть" или "Просмотрено"
        public string Rating { get; set; }      // Оценка от 1 до 10 (только для просмотренных)

        public Movie() { }

        public Movie(string title, string director, string genre, string year, string status, string rating)
        {
            Title = title;
            Director = director;
            Genre = genre;
            Year = year;
            Status = status;
            Rating = rating;
        }

        public override string ToString()
        {
            return $"{Title} ({Year}) — {Director}";
        }
    }
}