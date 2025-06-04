using ReservationSystem.Models;
using ReservationSystem.Repository.Base;
using ReservationSystem.Repository.Helpers.Favorite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Repository.Interfaces
{
    public interface IFavoriteRepository : IBaseRepository<Favorite, FavoriteFilter, FavoriteUpdate>
    {
    }
}
