using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Repository.Helpers.Reservation
{
    public class ReservationFilter
    {
        public SqlInt32 UserId { get; set; }
        public SqlInt32 WorkPlace { get; set; }
        public SqlDateTime? ReservationDate { get; set; }
    }
}
