using System.Collections.Generic;

namespace BankTransaction.API.CategoryDI
{
	public class ApplyRules
	{
		private readonly IEnumerable<ICategoryDI> _rules;

		public ApplyRules(IEnumerable<ICategoryDI> rules)
		{
			_rules = rules;
		}

		public string ExecuteRule(double value)
		{
			string result = string.Empty;

			foreach(var rule in _rules)
			{
				result = rule.CategorizeRules(value);
			}

			return result;
		}
	}
}
