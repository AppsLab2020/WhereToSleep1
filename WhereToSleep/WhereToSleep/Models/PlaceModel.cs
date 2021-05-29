using System;
using System.Collections.Generic;
using System.Text;

namespace WhereToSleep.Models
{
    public class PlaceModel
    {
        public int id { get; set; }
        public string StallName { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public double longitute { get; set; }
        public double latitute { get; set; }
    }
}
