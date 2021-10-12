using cli_gms23_simple.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace cli_gms23_simple.Services
{
	internal class ExternFunctionParserService : IDisposable
	{
		public string SolutionDir { get; }

		public ExternFunctionParserService(string solutionDir)
		{
			SolutionDir = solutionDir;
		}
		public void Dispose()
		{
		}

		public async Task<IList<ExternFunction>> Parse(string cppFile)
		{
			var result = new List<ExternFunction>();
			var cppContent = await File.ReadAllTextAsync(Path.Combine(SolutionDir, cppFile));

			var externFunctionRegex = new Regex(@"EXTERN\s+(?<return>double|const\s+char\s*\*|void\s*\*)\s*\b(?<name>[a-zA-Z0-9_]+)\s*\((?<arguments>[^\)]*)\)", RegexOptions.IgnoreCase | RegexOptions.Multiline | RegexOptions.CultureInvariant | RegexOptions.IgnorePatternWhitespace | RegexOptions.Compiled);
			var externFunctionArgumentRegex = new Regex(@"(?<type>double|const\s+char\s*\*|void\s*\*)\s*\b(?<name>[a-zA-Z0-9_]+)(?:\s*=\s*(?<default>[a-zA-Z0-9_:\""]+))?", RegexOptions.IgnoreCase | RegexOptions.Multiline | RegexOptions.CultureInvariant | RegexOptions.IgnorePatternWhitespace | RegexOptions.Compiled);
			foreach (Match match in externFunctionRegex.Matches(cppContent))
			{
				var arguments = externFunctionArgumentRegex.Matches(match.Groups["arguments"].Value).Select(m => new ExternFunctionArgument(m.Groups["type"].Value, m.Groups["name"].Value, m.Groups["default"].Value));
				result.Add(new ExternFunction(match.Groups["return"].Value, match.Groups["name"].Value, arguments));
			}
			return result;
		}

	}
}
