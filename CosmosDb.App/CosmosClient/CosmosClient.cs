using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Azure.Cosmos;
using Microsoft.Extension.Configuration;

namespace CosmosDb.App.CosmosClient;

public interface ICosmosClient
{
    Task<T> AddAsync<T>(T item);
    //Task<T> UpdateAsync<T>(T item);
    //Task<T> DeleteAsync<T>(string id);
    //Task<T> GetItemAsync<T>(string id);
    //Task<IEnumerable<T>> GetAllAsync<T>();
}

public class CosmosClient : ICosmosClient
{
    private CosmosClient _client;
    public CosmosClient()
    {
        _client = new CosmosClient("", "");
    }



}
