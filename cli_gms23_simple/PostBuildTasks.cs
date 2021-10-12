using System;
using System.IO;
using System.Threading.Tasks;

namespace cli_gms23_simple
{
	static class PostBuildTasks
	{
		private static Task CopyOverwriteFile(string from, string to)
		{
			var directory = Path.GetDirectoryName(to);
			if(!Directory.Exists(directory))
			{
				Directory.CreateDirectory(directory);
			}

			Console.WriteLine($"-> {to}");
			File.Copy(from, to, overwrite: true);

			return Task.FromResult(0);
		}

		public static async Task Run(string solutionDir)
		{
			await CopyOverwriteFile(Path.GetFullPath(Path.Combine(solutionDir, "ext_gms23_simple_html5", "bin", "ext_gms23_simple_html5.js")), Path.GetFullPath(Path.Combine(solutionDir, "gms", "extensions", "ext_gms23_simple", "ext_gms23_simple_html5.js")));
			await CopyOverwriteFile(Path.GetFullPath(Path.Combine(solutionDir, "ext_gms23_simple_macos64", "bin", "ext_gms23_simple_macos64.dylib")), Path.GetFullPath(Path.Combine(solutionDir, "gms", "extensions", "ext_gms23_simple", "ext_gms23_simple_macos64.dylib")));
			await CopyOverwriteFile(Path.GetFullPath(Path.Combine(solutionDir, "ext_gms23_simple_ubuntu64", "bin", "ext_gms23_simple_ubuntu64.so")), Path.GetFullPath(Path.Combine(solutionDir, "gms", "extensions", "ext_gms23_simple", "ext_gms23_simple_ubuntu64.so")));
			await CopyOverwriteFile(Path.GetFullPath(Path.Combine(solutionDir, "ext_gms23_simple_win32", "bin", "ext_gms23_simple_win32.dll")), Path.GetFullPath(Path.Combine(solutionDir, "gms", "extensions", "ext_gms23_simple", "ext_gms23_simple_win32.dll")));
			await CopyOverwriteFile(Path.GetFullPath(Path.Combine(solutionDir, "ext_gms23_simple_win64", "bin", "ext_gms23_simple_win64.dll")), Path.GetFullPath(Path.Combine(solutionDir, "gms", "extensions", "ext_gms23_simple", "ext_gms23_simple_win64.dll")));
			await CopyOverwriteFile(Path.GetFullPath(Path.Combine(solutionDir, "ext_gms23_simple_uwp64", "bin", "ext_gms23_simple_uwp64.dll")), Path.GetFullPath(Path.Combine(solutionDir, "gms", "extensions", "ext_gms23_simple", "ext_gms23_simple_uwp64.dll")));
			await CopyOverwriteFile(Path.GetFullPath(Path.Combine(solutionDir, "ext_gms23_simple_operagx", "bin", "ext_gms23_simple_operagx.js")), Path.GetFullPath(Path.Combine(solutionDir, "gms", "extensions", "ext_gms23_simple", "ext_gms23_simple_operagx.js")));
		}
	}
}
