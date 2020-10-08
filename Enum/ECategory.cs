using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace BankTransaction.API.Enum
{
	public enum ECategory : byte
	{
		/// <summary>
		/// LOWRISK: Negócios com valor inferior a 1.000.000 e cliente do Setor Público
		/// </summary>
		[Description("LOWRISK")]
		Lowrisk = 1,

		/// <summary>
		/// MEDIUMRISK: Negócios com valor superior a 1.000.000 e cliente do Setor Público
		/// </summary>
		[Description("MEDIUMRISK")]
		MemiumRisk = 2,

		/// <summary>
		/// HIGHRISK: Negócios com valor superior a 1.000.000 e cliente do Setor Privado
		/// </summary>
		[Description("HIGHRISK")]
		HighRisk = 3
	}
}
