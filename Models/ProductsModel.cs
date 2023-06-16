using System.ComponentModel.DataAnnotations;

namespace DeltaCore.Models;

public class ProductsModel
{
	[Key,Required,MinLength(1),MaxLength(4)]
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
