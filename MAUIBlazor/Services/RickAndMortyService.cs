using MAUIBlazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MAUIBlazor.Services
{
    internal class RickAndMortyService: IRickyAndMortyServices
    {
        const string URL = "https://rickandmortyapi.com/api/character";
        public async Task<RickAndMorty> Get()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(URL);
            var content = await response.Content.ReadAsStringAsync();
            var rickAdnMorty = JsonSerializer.Deserialize<RickAndMorty>(content);
            return rickAdnMorty;
        }
    }
}
