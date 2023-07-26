using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class Pump
    {
        public Guid PumpId { get; set; }
        public String PumpName { get; set; }
        public DateTime PumpDate { get; set; }
        public String PumpType { get; set; }
        public bool PumpStatus { get; set; }
    }
}