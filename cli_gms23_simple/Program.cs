using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace cli_gms23_simple
{
	class Program
	{
		class Options
		{
			public static Options Parse(string[] args)
			{
				var options = new Options();

				for(var i = 0; i < args.Length; ++i)
				{
					if(args[i] == "--prebuild")
					{
						options.PreBuildTasks = true;
					}
					else if (args[i] == "--postbuild")
					{
						options.PostBuildTasks = true;
					}
					else
					{
						options.SolutionDir = args[i];
					}
				}

				if(string.IsNullOrEmpty(options.SolutionDir))
				{
					throw new System.Exception("SolutionDir is mandatory");
				}
				else if (!Directory.Exists(options.SolutionDir)) {
					throw new System.Exception("SolutionDir must already exist");
				}

				return options;
			}

			public bool PreBuildTasks { get; private set; } = false;
			public bool PostBuildTasks { get; private set; } = false;
			public string SolutionDir { get; private set; } = "";
		}
		static async Task Main(string[] args)
		{
			var options = Options.Parse(args);

			if(options.PreBuildTasks)
			{
				await PreBuildTasks.Run(options.SolutionDir);
			}


			if(options.PostBuildTasks)
			{
				await PostBuildTasks.Run(options.SolutionDir);
			}
		}
	}
}
