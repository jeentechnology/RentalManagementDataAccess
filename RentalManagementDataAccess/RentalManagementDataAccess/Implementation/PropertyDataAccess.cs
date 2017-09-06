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
            return await _dataStore.ReadAll();
        }

        public async Task<Property> GetById(int Id)
        {
            return await _dataStore.Read(Id);
        }

        public async Task<IQueryable<Property>> GetByQuery(Query<Property> query)
        {
            throw new NotImplementedException();
        }
    }
}
