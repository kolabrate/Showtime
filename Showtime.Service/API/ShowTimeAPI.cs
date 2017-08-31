using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using Movie.Models;


namespace Movie.Service
{
    public class ShowTimeApi : IMovie
    {
        private static string _baseUrl = "https://api.cinepass.de/v4/";
        private static string _accessToken = "NwVEh1oFCmR3x7WugzqxCRhAj5JcDvs0";
        private static readonly HttpClient _client;
        
        static ShowTimeApi()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(_baseUrl);
            _client.DefaultRequestHeaders.Add("X-API-Key", _accessToken);
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public List<MovieInfo> GetShowTimesForaMovie(string movieName)
        {
            throw new NotImplementedException();
        }
        
    }
}
