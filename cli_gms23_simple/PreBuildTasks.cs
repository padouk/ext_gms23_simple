using cli_gms23_simple.Services;
using System.IO;
using System.Threading.Tasks;

namespace cli_gms23_simple
{
	static class PreBuildTasks
	{
		public static async Task Run(string solutionDir)
		{
			using (var externFunctionParserService = new ExternFunctionParserService(solutionDir))
			using (var embeddedHandlerbarService = new EmbeddedHandlerbarService(solutionDir))
			{
				var externFunctions = await externFunctionParserService.Parse(Path.Combine("Shared", "GMSBinding.cpp"));

				var context = new {
					ExtensionName = "gms23_simple",
					ExternFunctions = externFunctions
				};

				await embeddedHandlerbarService.RunFor(Path.Combine("gms", "extensions", "ext_gms23_simple", "ext_gms23_simple.yy"), context);
				await embeddedHandlerbarService.RunFor(Path.Combine("gms", "scripts", "scr_gms23_simple_api", "scr_gms23_simple_api.gml"), context);
				await embeddedHandlerbarService.RunFor(Path.Combine("ext_gms23_simple_html5", "GMSBinding.js"), context);
			};
		}
	}
}
