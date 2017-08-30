using System;
using System.Collections.Generic;
using System.Text;
using RentalManagementModels;
using System.Threading.Tasks;
using System.Linq;
using RentalManagementDataAccess.QueryProviderUtility;

namespace RentalManagementDataAccess.Contracts
{
    public interface IRentalManagementDataAccess<T> where T : IModel
    {
        /// <summary>
        /// Get a resource by the id associated to it.
        /// </summary>
        Task<T> GetById(int Id);


        /// <summary>
        /// Get all resources available for this data access implementation
        /// </summary>
        Task<List<T>> GetAll();


        /// <summary>
        /// Uses a query object to try and limit data.
        /// </summary>
        Task<IQueryable<T>> GetByQuery(Query<T> query);
    }
}
