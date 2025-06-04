using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Services.DTOs.WorkPlace
{
    public class GetAllWorkPlacesResponse
    {
        public List<WorkPlaceResponse> WorkPlaces { get; set; }
        public int TotalCount { get; set; }
    }
}
