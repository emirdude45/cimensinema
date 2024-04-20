using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CimenSinema.Models
{
    public class Seans
    {
        public int id { get; set; }
        public string tarih { get; set; }
        public string zaman { get; set; }


        public int filmId { get; set; }
        public int salonId { get; set; }
    }
}
