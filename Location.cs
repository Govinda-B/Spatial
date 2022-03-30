using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetTopologySuite.Geometries;

namespace Spatial
{
    public class Location
    {
        public int CityID { get; set; }

        public string CityName { get; set; }

        public Point Coord { get; set; }
    }
}
