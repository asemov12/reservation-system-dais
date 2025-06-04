using Microsoft.Data.SqlClient;
using ReservationSystem.Models;
using ReservationSystem.Repository.Base;
using ReservationSystem.Repository.Helpers.Favorite;
using ReservationSystem.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Repository.Repos
{
    public class FavoriteRepository : BaseRepository<Favorite>, IFavoriteRepository
    {
        private const string idColumnName = "FavoriteId";

        protected override string[] GetColumns()
        {
            return new string[]
            {
                idColumnName,
                "UserId",
                "WorkPlaceId"
            };
        }

        protected override string GetTableName()
        {
            return "Favorites";
        }

        protected override Favorite MapEntity(SqlDataReader reader)
        {
            return new Favorite { 
                FavoriteId = Convert.ToInt32(reader[idColumnName]),
                UserId = Convert.ToInt32(reader["ÜserId"]),
                WorkPlaceId = Convert.ToInt32(reader["WorkPlaceId"])
            };

        }
        public async Task<int> CreateAsync(Favorite entity)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteByIdAsync(int objectId)
        {
            throw new NotImplementedException();
        }

        public async Task<Favorite> RetrieveByIdAsync(int objectId)
        {
            throw new NotImplementedException();
        }

        public async IAsyncEnumerable<Favorite> RetrieveCollectionAsync(FavoriteFilter filter)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateByIdAsync(int objectId, FavoriteUpdate update)
        {
            throw new NotImplementedException();
        }
    }
}
