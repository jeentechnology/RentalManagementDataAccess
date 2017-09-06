using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using RentalManagementModels;

namespace RentalManagementDataAccess.Contracts
{
    internal interface IDataStore<T> where T : IModel
    {
        Task<T> Create(T item);

        Task<T> Update(T item);

        Task<bool> Delete(T item);

        Task<T> Read(int id);

        Task<List<T>> ReadMany(List<int> ids);

        Task<List<T>> ReadAll();
    }
}
