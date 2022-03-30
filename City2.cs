using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using NetTopologySuite.Geometries;

namespace Spatial
{
    public class City2
    {
        [Key]
        public int CityID { get; set; }

        public string CityName { get; set; }
        public Point Location { get; set; }
    }
}
