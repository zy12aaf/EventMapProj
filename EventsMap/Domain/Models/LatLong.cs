using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class LatLong
    {
        public double Latitude { get; set; }
        public double Longtitude { get; set; }

        public LatLong(double latitude, double longtitude)
        {
            Latitude = latitude;
            Longtitude = longtitude;
        }
    }
}
