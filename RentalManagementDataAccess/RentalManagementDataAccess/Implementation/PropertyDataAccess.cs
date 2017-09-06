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

        public PropertyDataAccess(IDataStore<Property> dataStore)
        {
            _dataStore = dataStore;
        }

        private readonly IDataStore<Property> _dataStore;


        public async Task<List<Property>> GetAll()
        {
            return _dataStore.ReadAll().Result;
        }

        public async Task<Property> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<IQueryable<Property>> GetByQuery(Query<Property> query)
        {
            throw new NotImplementedException();
        }
    }
}
