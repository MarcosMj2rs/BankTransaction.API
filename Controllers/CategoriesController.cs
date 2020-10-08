using BankTransaction.API.Domain.Models;
using BankTransaction.API.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BankTransaction.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CategoriesController : Controller
	{
		private readonly ICategoryService _categoryService;

		public CategoriesController(ICategoryService categoryService)
		{
			_categoryService = categoryService;
		}

		[HttpPost]
		public async Task<IEnumerable<Category>> GetAllAsync(List<Trade> Portifolio)
		{
			var categories = await _categoryService.ListAsync(Portifolio);
			return categories;
		}

	}
}
