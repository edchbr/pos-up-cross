using AppEdu.Model;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppEdu.Infra.Api
{
    [Headers("Content-Type: application/json")]
    public interface ITmdbApi
    {
        [Get("/3/tv/popular?api_key={apiKey}")]
        Task<SerieResponse> GetSerieResponseAsync(string apiKey);
    }
}
