using System.Collections.Generic;
using System.Linq;

namespace cli_gms23_simple.Models
{
	internal class ExternFunction
	{
		public ExternFunction(string returnTypeCpp, string name, IEnumerable<ExternFunctionArgument> arguments)
		{
			ReturnTypeCpp = returnTypeCpp;
			Name = name;
			Arguments = arguments.ToArray();
		}

		public string ReturnTypeCpp { get; }
		public string Name { get; }
		public IList<ExternFunctionArgument> Arguments { get; }


		public bool IsReturnTypeNumber => ReturnTypeCpp == "double";
	}
}
