using System.ComponentModel.DataAnnotations;

namespace BlazorPracticaClaseVirtual.Models
{
	public class Product
	{
		public int Id { get; set; }

		[Required(ErrorMessage ="El nombre es un campo obligatorio")]
		public string Name { get; set; }

		[Range(1,int.MaxValue, ErrorMessage ="El precio debe ser mayor que 0")]
		public int Price { get; set; }

		public string Description { get; set; }
	}
}
