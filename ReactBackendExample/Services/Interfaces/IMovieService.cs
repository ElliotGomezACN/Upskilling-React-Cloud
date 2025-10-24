using ReactBackendExample.Models.DTOs.Movie;

namespace ReactBackendExample.Services.Interfaces
{
    public interface IMovieService
    {
        Task<IEnumerable<MovieCatalogResponseDto>> GetMoviesCatalogWithMetadata();
        Task<MovieResponseDto> GetMovieWithMetadata(int movieId);
    }
}
