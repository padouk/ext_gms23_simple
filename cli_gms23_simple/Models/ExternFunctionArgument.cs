namespace cli_gms23_simple.Models
{
	internal class ExternFunctionArgument
	{
		public ExternFunctionArgument(string typeCpp, string name, string defaultValue)
		{
			TypeCpp = typeCpp.Replace(" ", "");
			Name = name;
			DefaultValue = defaultValue;
		}

		public string TypeCpp { get; }
		public string Name { get; }
		public string DefaultValue { get; }

		public bool IsTypeNumber => TypeCpp == "double";
		public bool IsTypeBuffer => TypeCpp == "void*";
	}
}
