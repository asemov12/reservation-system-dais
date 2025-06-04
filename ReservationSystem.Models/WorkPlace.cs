using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Models
{
    public class WorkPlace
    {
        public int WorkPlaceId { get; set; }
        public int Floor { get; set; }
        public string Zone { get; set; }
        public bool HasMonitor { get; set; }
        public bool HasDockingStation { get; set; }
        public bool IsNearWindow { get; set; }
        public bool IsNearPrinter { get; set; }
    }
}
