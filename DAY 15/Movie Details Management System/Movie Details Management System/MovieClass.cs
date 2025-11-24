using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Details_Management_System
{
    internal class MovieClass
    {
        string movieName, movieId, director, emailId, productionCompany;
        int review;

        public MovieClass(string movieName, string movieId, string director, string emailId, string productionCompany, int review)
        {
            this.movieName = movieName;
            this.movieId = movieId;
            this.director = director;
            this.emailId = emailId;
            this.productionCompany = productionCompany;
            this.review = review;
        }

        public string displayDetails()
        {
            string details = $"Movie Name: {movieName}\n"
                + $"Movie ID: {movieId}\n"
                + $"Review: {review}\n"
                + $"Director: {director}\n"
                + $"Email ID: {emailId}\n"
                + $"Production Company: {productionCompany}\n";

            return details;
        }
    }
}
