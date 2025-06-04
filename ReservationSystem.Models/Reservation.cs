using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Models
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public int UserId { get; set; }
        public int WorkPlaceId { get; set; }
        public DateOnly ReservationDate { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
