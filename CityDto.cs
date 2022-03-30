using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spatial
{
    public class CityDto
    {
        public int CityID { get; set; }
        public string CityName { get; set; }

        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
