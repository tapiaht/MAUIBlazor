using MAUIBlazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIBlazor.Services
{
    internal interface IRickyAndMortyServices
    {
        public Task<RickAndMorty> Get();

    }
}
