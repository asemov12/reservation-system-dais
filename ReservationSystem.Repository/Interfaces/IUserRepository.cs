using ReservationSystem.Models;
using ReservationSystem.Repository.Base;
using ReservationSystem.Repository.Helpers.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Repository.Interfaces
{
    public interface IUserRepository : IBaseRepository<User, UserFilter, UserUpdate>
    {
    }
}
