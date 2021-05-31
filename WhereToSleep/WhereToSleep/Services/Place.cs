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

            myData.Add(new PlaceModel { StallName = "Penzion Relish", Description = "Školská 25/38, 013 13 Rajecké Teplice", id = 0, latitute = 49.12727907146193, longitute = 18.682083338488145, ImageUrl = "https://www.relish.sk/media/com_twojtoolbox/D4S_0001.JPG" });
            myData.Add(new PlaceModel { StallName = "Aphrodite", Description = "Rajecká cesta,013 13 Rajecké Teplice", id = 1, latitute = 49.128930649748284, longitute = 18.682633917139224, ImageUrl = "https://kupele.rajecke-teplice.net/wp-content/uploads/sites/6/2019/12/k%C3%BApe%C4%BEn%C3%BD-hotel-Aphrodite.jpg" });
            myData.Add(new PlaceModel { StallName = "Penzion Mlynárka", Description = "64,013 13 Rajecké Teplice", id = 3, latitute = 49.130086886799546, longitute = 18.678490097364215, ImageUrl = "https://static.slevydnes.cz/merchants/penzion-mlynarka-slovensko-rajecke-teplice_1.jpg" });
            myData.Add(new PlaceModel { StallName = "Holiady Inn", Description = "Športová 2,010 10 Žilina", id = 3, latitute = 49.230467148682585, longitute = 18.742014024542488, ImageUrl = "https://imgcy.trivago.com/c_limit,d_dummy.jpeg,f_auto,h_1300,q_auto,w_2000/itemimages/56/47/5647680_v6.jpeg" });
            myData.Add(new PlaceModel { StallName = "Hotel Diplomat", Description = "1. mája 14,013 13 Rajecké Teplice", id = 4, latitute = 49.12831246275363, longitute = 18.689156687005894, ImageUrl = "https://cf.bstatic.com/images/hotel/max1024x768/805/80551387.jpg" });
            myData.Add(new PlaceModel { StallName = "Village Resort Hanuliak", Description = "Oslobodenia 1071/118,013 05 Belá", id = 5, latitute = 49.24287910033615, longitute = 18.953974121955724, ImageUrl = "https://www.travelguide.sk/userfiles/accommodations/village_resort_hanuliak_1528191310_02.jpg" });

        }
        public async Task<List<PlaceModel>> getplaces()
        {
            return await Task.FromResult(myData);
        }
    }
}