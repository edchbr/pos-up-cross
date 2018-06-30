using AppEdu.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppEdu.Service
{
    public interface ISerieService
    {
        Task<SerieResponse> GetSeriesAsync();
    }
}
