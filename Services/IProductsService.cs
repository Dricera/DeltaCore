using DeltaCore.Models;

namespace DeltaCore.Services;

public interface IProductsService
{
	Task<ProductsModel> GetProductsAsync(int id);
	Task<IEnumerable<ProductsModel>> GetProductsAsync();

}