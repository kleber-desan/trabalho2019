using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xfw.Models;
using Xfw.Repositories;

namespace Xfw.Models.Services
{
    public interface IMovieService
    {
        Task<(string erro, List<Movie>)> GetUpcoming();
    }

    public sealed class MovieService : IMovieService
    {
        private readonly IMovieRepository movieRepository;
        public MovieService()
        {
            movieRepository = new MovieRepository();
        }

        public Task<(string erro, List<Movie>)> GetUpcoming()
            => movieRepository.GetUpcoming();
    }


}
