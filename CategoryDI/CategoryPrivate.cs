namespace BankTransaction.API.CategoryDI
{
	public class CategoryPrivate : ICategoryDI
	{
		public string CategorizeRules(double value)
		{
			string categoryValue = null;

			if(value > 1000000)
			{
				categoryValue = "HIGHRISK";
			}
			return categoryValue;
		}
	}
}
