
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RiderBackEnd.Models
{
    public class GeoPoint
    {
        public string type { get; set; }
        public List<double> coordinates { get; set; }
    }
}