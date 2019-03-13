namespace Repro2442.Console
{
	using System;
	using Microsoft.Build.Evaluation;

	public class Program
	{
		private static void Main(string[] args)
		{
			Environment.SetEnvironmentVariable(MSBuildFinder.MSBuildEnvironmentVariableName, MSBuildFinder.Find());

			ProjectCollection projectCollection = new ProjectCollection();
			Project project = projectCollection.LoadProject("..\\..\\..\\Repro2442.Console.csproj");
		}
	}
}