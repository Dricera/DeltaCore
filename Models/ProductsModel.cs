using System.ComponentModel.DataAnnotations;

namespace DeltaCore.Models;

public class ProductsModel
{
	[Key,Required]
	[RegularExpression(@"^\d{4}$", ErrorMessage = "The ID must be a 4-digit number.")]
    [Range(0, 9999, ErrorMessage = "The ID must be between 0000 and 9999.")]
	public int Id { get; set; }

	[Required, MaxLength(100)]
	public string Name { get; set; }

	[Required, MaxLength(1000)]
	public string Description { get; set; }

	public ProductsModel(int id, string name, string description)
	{
		Id = id;
		Name = name;
		Description = description;
	}
	public ProductsModel()
	{
		Id = 0000;
		Name = "Default Name";
		Description = "Default Description";
	}

}
