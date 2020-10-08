using System.Text.Json.Serialization;

namespace BankTransaction.API.Domain.Models
{
	public class Category
	{
		[JsonIgnore]
		public int Id { get; set; }

		public string Name { get; set; }
	}
}
