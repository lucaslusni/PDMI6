using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP03
{
    public class Package
    {
        public int TrackingNumber { get; set; }
        public string Status { get; set; }
        public DateTime SendDate { get; set; }
        public DateTime ExpectedDeliveryDate { get; set; }
        public string Events { get; set; }
    }
}
