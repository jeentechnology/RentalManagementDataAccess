using System;
using System.Collections.Generic;
using System.Text;
using RentalManagementModels.Rentals;
using RentalManagementDataAccess.Contracts;
using RentalManagementDataAccess.QueryProviderUtility;
using System.Linq;
using System.Threading.Tasks;

namespace RentalManagementDataAccess.Implementation
{
    public class PropertyDataAccess : IRentalManagementDataAccess<Property>
    {
        public Task<List<Property>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Property> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Property>> GetByQuery(Query<Property> query)
        {
            throw new NotImplementedException();
        }
    }
}
