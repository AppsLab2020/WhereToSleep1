using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WhereToSleep.Models;

namespace WhereToSleep.Services
{
    public interface IPlace
    {
        Task<List<PlaceModel>> getplaces();
    }
}
