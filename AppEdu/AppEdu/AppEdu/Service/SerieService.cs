using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AppEdu.Infra;
using AppEdu.Infra.Api;
using AppEdu.Model;

namespace AppEdu.Service
{
    public class SerieService : ISerieService
    {
        readonly ITmdbApi _api;

        public SerieService(ITmdbApi api)
        {
            _api = api;
        }

        public async Task<SerieResponse> GetSeriesAsync()
        {
            return await _api.GetSerieResponseAsync(AppSetting.ApiKey);
        }
    }

}
