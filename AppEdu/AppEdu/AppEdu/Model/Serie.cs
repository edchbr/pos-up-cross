using System;
using AppEdu.Infra;
using Newtonsoft.Json;

namespace AppEdu.Model
{
    public class Serie
    {
        [JsonProperty("original_name")]
        public string OriginalName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("first_air_date")]
        public DateTimeOffset FirstAirDate { get; set; }

        [JsonProperty("backdrop_path")]
        public string BackdropPath { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("vote_average")]
        public double VoteAverage { get; set; }

        [JsonProperty("overview")]
        public string Overview { get; set; }

        [JsonProperty("poster_path")]
        public string PosterPath { get; set; }

        [JsonIgnore]
        public string Poster
        {
            get { return $"{AppSetting.ApiImageBaseUrl}{ PosterPath}"; }
        }
        [JsonIgnore]
        public string Backdrop
        {
            get { return $"{AppSetting.ApiImageBaseUrl}{ BackdropPath}"; }
        }

        [JsonIgnore]
        public string ReleaseDate
        {
            get
            {
                return $"{FirstAirDate:dd/MM/yy}";
            }
        }
    }
}