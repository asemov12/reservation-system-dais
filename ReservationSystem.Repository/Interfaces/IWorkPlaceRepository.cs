using ReservationSystem.Models;
using ReservationSystem.Repository.Base;
using ReservationSystem.Repository.Helpers.WorkPlace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Repository.Interfaces
{
    public interface IWorkPlaceRepository: IBaseRepository<WorkPlace, WorkPlaceFilter, WorkPlaceUpdate>
    {
    }
}
