using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Azure.Cosmos;
using Microsoft.Extensions.Configuration;

namespace CosmosDb.App.MyCosmosClient;

public interface ICosmosClient
{
    Task<T> AddAsync<T>(T item);
    //Task<T> UpdateAsync<T>(T item);
    //Task<T> DeleteAsync<T>(string id);
    Task<T> GetItemAsync<T>(string id);
    //Task<IEnumerable<T>> GetAllAsync<T>();
}

public class MyCosmosClient : ICosmosClient
{
	private readonly CosmosClient _client;
	private readonly IConfigurationBuilder _config;

	public MyCosmosClient(IConfigurationBuilder config)
	{
		_config = config;
		_client = new CosmosClient(
			_config.Build().GetValue<string>("CosmosDb:Endpoint"), 
			_config.Build().GetValue<string>("CosmosDb:Key"));
	}

	public async Task<T> AddAsync<T>(T item)
	{
		var container = _client.GetContainer("database", "container");
		var response = await container.CreateItemAsync(item);
		return response.Resource;
	}

	public Task<T> GetItemAsync<T>(string id)
	{
		throw new NotImplementedException();
	}
}
