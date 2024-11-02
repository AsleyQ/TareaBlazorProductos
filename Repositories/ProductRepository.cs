using BlazorPracticaClaseVirtual.Models;
using BlazorPracticaClaseVirtual.Repositories.Interfaces;

namespace BlazorPracticaClaseVirtual.Repositories
{
	public class ProductRepository : IProductRepository
	{
		public Product GetProduct(int id)
		{
			return new Product()
			{
				Id = id,
				Name = "Helado",
				Price= 1050,
				Description= "Caramelo con maní"
			};
		}
	}
}
