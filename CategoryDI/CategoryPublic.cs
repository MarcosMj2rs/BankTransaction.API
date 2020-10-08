namespace BankTransaction.API.CategoryDI
{
	public class CategoryPublic : ICategoryDI
	{
		public string CategorizeRules(double value)
		{
			return value < 1000000 ? "LOWRISK" : "MEDIUMRISK";
		}
	}
}

