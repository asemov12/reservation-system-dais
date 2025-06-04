using Microsoft.Data.SqlClient;
using ReservationSystem.Models;
using ReservationSystem.Repository.Base;
using ReservationSystem.Repository.Helpers.WorkPlace;
using ReservationSystem.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Repository.Repos
{
    public class WorkPlaceRepository : BaseRepository<WorkPlace>, IWorkPlaceRepository
    {
        private const string idColumnName = "WorkPlaceId";
        protected override string[] GetColumns()
        {
            return new string[]
            {
                idColumnName,
                "Floor",
                "Zone",
                "HasMonitor",
                "HasDockingStation",
                "IsNearWindow",
                "IsNearPrinter"
            };
        }

        protected override string GetTableName()
        {
            return "WorkPlaces";
        }

        protected override WorkPlace MapEntity(SqlDataReader reader)
        {
            return new WorkPlace
            {
                WorkPlaceId = Convert.ToInt32(reader[idColumnName]),
                Floor = Convert.ToInt32(reader["Floor"]),
                Zone = Convert.ToString(reader["Zone"]),
                HasMonitor = Convert.ToBoolean(reader["HasMonitor"]),
                HasDockingStation = Convert.ToBoolean(reader["HasDockingStation"]),
                IsNearWindow = Convert.ToBoolean(reader["IsNearWindow"]),
                IsNearPrinter = Convert.ToBoolean(reader["IsNearPrinter"])
            };
        }
        public async Task<int> CreateAsync(WorkPlace entity)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteByIdAsync(int objectId)
        {
            throw new NotImplementedException();
        }

        public async Task<WorkPlace> RetrieveByIdAsync(int objectId)
        {
            throw new NotImplementedException();
        }

        public async IAsyncEnumerable<WorkPlace> RetrieveCollectionAsync(WorkPlaceFilter filter)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateByIdAsync(int objectId, WorkPlaceUpdate update)
        {
            throw new NotImplementedException();
        }

    }
}
