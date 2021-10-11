using HandlebarsDotNet;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace cli_gms23_simple.Services
{
	internal class EmbeddedHandlerbarService : IDisposable
	{
		public string SolutionDir { get; }

		public EmbeddedHandlerbarService(string solutionDir)
		{
			SolutionDir = solutionDir;
		}
		public void Dispose()
		{
		}

		public async Task<HandlebarsTemplate<object, object>> Compile(string templateName)
		{
			using (var input = new StreamReader(GetType().Assembly.GetManifestResourceStream($"cli_gms23_simple.App_Data.Templates.{templateName}")))
			{
				var template = await input.ReadToEndAsync();
				return Handlebars.Compile(template);
			}
			throw new Exception("Unknown template");
		}

		public async Task RunFor(string dstRelativePath, object handlebarsContext)
		{
			var templateName = string.Join('.', dstRelativePath.Split(new char[] { '\\', '/' }));
			var dstPath = Path.GetFullPath(Path.Join(SolutionDir, dstRelativePath));
			var template = await Compile(templateName);
			var dstContent = template(handlebarsContext);

			Console.WriteLine($"-> {dstPath}");
			await File.WriteAllTextAsync(dstPath, dstContent);
		}
	}
}
