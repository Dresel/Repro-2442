namespace Repro2442.Console
{
	using System.Linq;
	using Microsoft.Build.Evaluation;
	using Microsoft.Build.Locator;

	public class Program
	{
		private static void Main(string[] args)
		{
			RegisterMSBuild();
			LoadProjectCollection();
		}

		private static void LoadProjectCollection()
		{
			ProjectCollection projectCollection = new ProjectCollection();
			Project project = projectCollection.LoadProject("..\\..\\..\\Repro2442.Console.csproj");
		}

		private static void RegisterMSBuild()
		{
			MSBuildLocator.RegisterInstance(MSBuildLocator.QueryVisualStudioInstances(
				new VisualStudioInstanceQueryOptions()
				{
					DiscoveryTypes = DiscoveryType.DotNetSdk
				}).SingleOrDefault());
		}
	}
}