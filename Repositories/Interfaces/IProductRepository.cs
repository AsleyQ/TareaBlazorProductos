using BlazorPracticaClaseVirtual.Models;

namespace BlazorPracticaClaseVirtual.Repositories.Interfaces
{
	public interface IProductRepository
	{
		Product GetProduct(int id);
	}
}
