using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WhereToSleep.Models;

namespace WhereToSleep.Services
{
    public class Place : IPlace
    {
        List<PlaceModel> myData;
        public Place()
        {
            myData = new List<PlaceModel>();

            myData.Add(new PlaceModel { StallName = "Macov Dom", Description = "Best MacoHouse Ever", id = 0, latitute = 49.13263045099855, longitute = 18.707620000970536, ImageUrl = "https://cdn.pixabay.com/photo/2017/09/22/22/33/tomato-2777351_960_720.jpg" });
            myData.Add(new PlaceModel { StallName = "Macov Byt", Description = "Best MacoByt Ever", id = 1, latitute = 49.13295184657695, longitute = 18.704512050880084, ImageUrl = "https://cdn.pixabay.com/photo/2017/09/22/22/33/tomato-2777351_960_720.jpg" });
        }
        public async Task<List<PlaceModel>> getplaces()
        {
            return await Task.FromResult(myData);
        }
    }
}