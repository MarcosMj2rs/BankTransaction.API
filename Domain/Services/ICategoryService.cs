using BankTransaction.API.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BankTransaction.API.Domain.Services
{
	public interface ICategoryService
	{
		Task<IEnumerable<Category>> ListAsync(List<Trade> portifolio);
	}
}
