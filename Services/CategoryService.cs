using BankTransaction.API.CategoryDI;
using BankTransaction.API.Domain.Models;
using BankTransaction.API.Domain.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BankTransaction.API.Services
{
	public class CategoryService : ICategoryService
	{
		public Task<IEnumerable<Category>> ListAsync(List<Trade> portifolio)
		{
			ICategoryDI categoryDIPrivate = new CategoryPrivate();
			ICategoryDI categoryDIPublic = new CategoryPublic();
			List<Category> lstCategory = new List<Category>();
			Category category = null;

			foreach(var item in portifolio)
			{
				category = new Category();

				if(string.Compare(item.ClientSector, "Public", true) == 0)
					category = new Category { Name = categoryDIPublic.CategorizeRules(item.Value) };
				else
					category = new Category { Name = categoryDIPrivate.CategorizeRules(item.Value) };

				lstCategory.Add(category);
			}

			return Task.FromResult<IEnumerable<Category>>(lstCategory);
		}
	}
}
