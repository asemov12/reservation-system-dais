using ReservationSystem.Models;
using ReservationSystem.Repository.Helpers.Reservation;
using ReservationSystem.Repository.Helpers.WorkPlace;
using ReservationSystem.Repository.Interfaces;
using ReservationSystem.Services.DTOs.WorkPlace;
using ReservationSystem.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Services.Services
{
    public class WorkPlaceService : IWorkPlaceService
    {
        private readonly IWorkPlaceRepository _workPlaceRepo;
        private readonly IReservationRepository _reservationRepo;

        public WorkPlaceService(IWorkPlaceRepository workPlaceRepo, IReservationRepository reservationRepo)
        {
            _workPlaceRepo = workPlaceRepo;
            _reservationRepo = reservationRepo;
        }

        public async Task<WorkPlaceResponse> GetByIdAsync(int workplaceId)
        {
            var entity = await _workPlaceRepo.RetrieveByIdAsync(workplaceId);
            return MapToWorkplaceResponse(entity);
        }

        public async Task<GetAllWorkPlacesResponse> GetAllAsync()
        {
            var result = new List<WorkPlaceResponse>();
            await foreach (var entity in _workPlaceRepo.RetrieveCollectionAsync(new WorkPlaceFilter()))
            {
                result.Add(MapToWorkplaceResponse(entity));
            }

            return new GetAllWorkPlacesResponse
            {
                WorkPlaces = result,
                TotalCount = result.Count
            };
        }

        public async Task<GetAllWorkPlacesResponse> GetOnFloorAsync(int floor)
        {
            var result = new List<WorkPlaceResponse>();
            WorkPlaceFilter filter = new WorkPlaceFilter { Floor = new SqlInt32(floor) };
            await foreach (var entity in _workPlaceRepo.RetrieveCollectionAsync(filter))
            {
                result.Add(MapToWorkplaceResponse(entity));
            }

            return new GetAllWorkPlacesResponse
            {
                WorkPlaces = result,
                TotalCount = result.Count
            };
        }

        public async Task<GetAllWorkPlacesResponse> GetAvailableAsync(DateOnly date)
        {
            // Get all reservations for the given date
            var reservedWorkplaceIds = new HashSet<int>();
            await foreach (var res in 
                _reservationRepo.RetrieveCollectionAsync(
                    new ReservationFilter 
                        { 
                            ReservationDate = new SqlDateTime(date.ToDateTime(TimeOnly.MinValue))
                        }))
            {
                reservedWorkplaceIds.Add(res.WorkPlaceId);
            }

            // Fetch all workplaces
            var available = new List<WorkPlaceResponse>();
            await foreach (var workplace in _workPlaceRepo.RetrieveCollectionAsync(new WorkPlaceFilter()))
            {
                if (!reservedWorkplaceIds.Contains(workplace.WorkPlaceId))
                {
                    available.Add(MapToWorkplaceResponse(workplace));
                }
            }

            return new GetAllWorkPlacesResponse
            {
                WorkPlaces = available,
                TotalCount = available.Count
            };
        }

        private WorkPlaceResponse MapToWorkplaceResponse(WorkPlace wp)
        {
            return new WorkPlaceResponse
            {
                WorkPlaceId = wp.WorkPlaceId,
                Floor = wp.Floor,
                Zone = wp.Zone,
                HasMonitor = wp.HasMonitor,
                HasDockingStation = wp.HasDockingStation,
                IsNearWindow = wp.IsNearWindow,
                IsNearPrinter = wp.IsNearPrinter
            };
        }
    }
}
