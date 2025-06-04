using ReservationSystem.Repository.Helpers.WorkPlace;
using ReservationSystem.Services.DTOs.WorkPlace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Services.Interfaces
{
    public interface IWorkPlaceService
    {
        Task<WorkPlaceResponse> GetByIdAsync(int workplaceId);
        Task<GetAllWorkPlacesResponse> GetAllAsync();
        Task<GetAllWorkPlacesResponse> GetOnFloorAsync(int floor);
        Task<GetAllWorkPlacesResponse> GetAvailableAsync(DateOnly date);
    }
}
