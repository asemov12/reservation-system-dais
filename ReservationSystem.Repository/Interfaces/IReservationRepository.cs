using ReservationSystem.Models;
using ReservationSystem.Repository.Base;
using ReservationSystem.Repository.Helpers.Reservation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Repository.Interfaces
{
    public interface IReservationRepository : IBaseRepository<Reservation, ReservationFilter, ReservationUpdate>
    {
    }
}
