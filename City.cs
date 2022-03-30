using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using NetTopologySuite.Geometries;

namespace Spatial
{
    public class City
    {
        [Key]
        public int CityID { get; set; }

        public string CityName { get; set; }
        [Column(TypeName = "geography")]
        public Point Location { get; set; }
    }
}
