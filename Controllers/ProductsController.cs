using DeltaCore.Models;
using DeltaCore.Services;
using Microsoft.AspNetCore.Mvc;

namespace DeltaCore.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductsController : Controller
{
	
	private readonly ILogger<ProductsController> _logger;
	private readonly IProductsService _productsService;

	public ProductsController(ILogger<ProductsController> logger, IProductsService productsService)
	{
		_logger = logger;
		_productsService = productsService;
	}

	[HttpGet]
	public async Task<IEnumerable<ProductsModel>> GetProductsAsync()
	{
		var products = await _productsService.GetProductsAsync();
		return products;
	}
	
	[HttpGet("{id}")]
	public async Task<ActionResult<ProductsModel>> GetProductsAsync(int id)
	{
		var product = await _productsService.GetProductsAsync(id);
		return product;
	}

}