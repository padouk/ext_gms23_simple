using System.IO;
using System.Threading.Tasks;

namespace cli_gms23_simple
{
	static class PostBuildTasks
	{
		public static async Task Run(string solutionDir)
		{
			File.Copy(Path.Combine(solutionDir, "ext_gms23_simple_html5", "bin", "ext_gms23_simple_html5.js"), Path.Combine(solutionDir, "gms", "extensions", "ext_gms23_simple", "ext_gms23_simple_html5.js"), overwrite:true);
			File.Copy(Path.Combine(solutionDir, "ext_gms23_simple_html5", "bin", "ext_gms23_simple_html5.wasm"), Path.Combine(solutionDir, "gms", "datafiles", "ext_gms23_simple_html5.wasm"), overwrite: true);
			File.Copy(Path.Combine(solutionDir, "ext_gms23_simple_macos64", "bin", "ext_gms23_simple_macos64.dylib"), Path.Combine(solutionDir, "gms", "extensions", "ext_gms23_simple", "ext_gms23_simple_macos64.dylib"), overwrite: true);
			File.Copy(Path.Combine(solutionDir, "ext_gms23_simple_ubuntu64", "bin", "ext_gms23_simple_ubuntu64.so"), Path.Combine(solutionDir, "gms", "extensions", "ext_gms23_simple", "ext_gms23_simple_ubuntu64.so"), overwrite: true);
			File.Copy(Path.Combine(solutionDir, "ext_gms23_simple_win32", "bin", "ext_gms23_simple_win32.dll"), Path.Combine(solutionDir, "gms", "extensions", "ext_gms23_simple", "ext_gms23_simple_win32.dll"), overwrite: true);
			File.Copy(Path.Combine(solutionDir, "ext_gms23_simple_win64", "bin", "ext_gms23_simple_win64.dll"), Path.Combine(solutionDir, "gms", "extensions", "ext_gms23_simple", "ext_gms23_simple_win64.dll"), overwrite: true);

			await Task.Yield();
		}
	}
}
