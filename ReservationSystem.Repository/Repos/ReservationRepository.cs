using Microsoft.Data.SqlClient;
using ReservationSystem.Models;
using ReservationSystem.Repository.Base;
using ReservationSystem.Repository.Helpers.Reservation;
using ReservationSystem.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Repository.Repos
{
    public class ReservationRepository : BaseRepository<Reservation>, IReservationRepository
    {
        private const string idColumnName = "ReservationId";

        protected override string[] GetColumns()
        {
            return new string[] 
            {
                idColumnName,
                "UserId",
                "WorkPlaceId",
                "ReservationDate",
                "CreatedAt"
            };
        }

        protected override string GetTableName()
        {
            return "Reservations";
        }

        protected override Reservation MapEntity(SqlDataReader reader)
        {
            return new Reservation
            {
                ReservationId = Convert.ToInt32(reader[idColumnName]),
                UserId = Convert.ToInt32(reader["UserId"]),
                WorkPlaceId = Convert.ToInt32(reader["WorkPlaceId"]),
                ReservationDate = DateOnly.FromDateTime(Convert.ToDateTime(reader["ReservationDate"])),
                CreatedAt = Convert.ToDateTime(reader["Createdat"])
            };
        }
        public async Task<int> CreateAsync(Reservation entity)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteByIdAsync(int objectId)
        {
            throw new NotImplementedException();
        }

        public async Task<Reservation> RetrieveByIdAsync(int objectId)
        {
            throw new NotImplementedException();
        }

        public async IAsyncEnumerable<Reservation> RetrieveCollectionAsync(ReservationFilter filter)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateByIdAsync(int objectId, ReservationUpdate update)
        {
            throw new NotImplementedException();
        }
    }
}
