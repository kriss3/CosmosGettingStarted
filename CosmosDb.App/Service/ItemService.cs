using CosmosDb.App.Model;
using CosmosDb.App.MyCosmosClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmosDb.App.Service;

public interface IItemService
{
    Task<Item> AddAsync(Item item);
    Task<Item> UpdateAsync(Item item);
    Task<Item> DeleteAsync(string id);
    Task<Item> GetItemAsync(string id);
    Task<IEnumerable<Item>> GetAllAsync();
}

public class ItemService : IItemService
{
    private readonly ICosmosClient _cosmosClient;
    public ItemService(ICosmosClient cosmosClient)
    {
        _cosmosClient = cosmosClient;
    }

    public Task<Item> AddAsync(Item item)
    {
        return _cosmosClient.AddAsync(item);
    }

    public Task<Item> DeleteAsync(string id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Item>> GetAllAsync()
    {
        return _cosmosClient.GetAllAsync<Item>();
	}

    public Task<Item> GetItemAsync(string id)
    {
		return _cosmosClient.GetItemAsync<Item>(id);
	}

    public Task<Item> UpdateAsync(Item item)
    {
		return _cosmosClient.UpdateAsync(item);
	}
}
