using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StarChart.Models
{
    public class CelestialObject
    {
        public int id;

        [Required]
        public string Name;

        public int? OrbitedObjectId;

        [NotMapped]
        public List<CelestialObject> Satellites;

        public TimeSpan OrbitalPeriod;
    }
}
