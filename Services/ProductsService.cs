namespace DeltaCore.Services;

using DeltaCore.Models;
using Microsoft.Extensions.Logging;

public class ProductsService : IProductsService
{
	private readonly ILogger<ProductsService> _logger;
	
	// In-Memory Data as we're not using a database. For state consistency this service will be a singleton.
	private readonly List<ProductsModel> products = new(){
		new ProductsModel(1001,"Tools Gears","Gear tools production specification"),
		new ProductsModel(2001,"Panels","Switch Gear Panels"),
		new ProductsModel(2008,"DocTonar","Document Solar Objects")

	};

	public ProductsService(ILogger<ProductsService> logger)
	{
		_logger = logger;
	}

	public async Task<ProductsModel> GetProductsAsync(int id)
	{
		var product = products.FirstOrDefault(p => p.Id == id);
		if (product == null)
		{
			throw new Exception($"Product with id: {id} does not exist");
		}
		return await Task.FromResult(product);
	}

	public async Task<IEnumerable<ProductsModel>> GetProductsAsync()
	{
		_logger.LogInformation($"Returned {products.Count} products");

		return await Task.FromResult(products);
	}

}