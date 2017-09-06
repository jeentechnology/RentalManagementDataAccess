using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Newtonsoft.Json;
using RentalManagementDataAccess.Contracts;
using RentalManagementModels;

namespace RentalManagementDataAccess.Providers
{
    public class CosmosProvider<T> : IDataStore<T> where T : IModel
    {
        
        #region IDataStore Implementation

        public async Task<T> Create(T item)
        {
            throw new NotImplementedException();
        }

        public async Task<T> Update(T item)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Delete(T item)
        {
            throw new NotImplementedException();
        }

        public async Task<T> Read(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<T>> ReadMany(List<int> ids)
        {
            throw new NotImplementedException();
        }

        public async Task<List<T>> ReadAll()
        {
            throw new NotImplementedException();
        }

        #endregion // IData Store Implementation
    }
}
