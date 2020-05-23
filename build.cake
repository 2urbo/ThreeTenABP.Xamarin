var target = Argument ("target", "Default");

var AAR_VERSION = "1.2.3";
var JAR_VERSION = "1.4.2";

var NUGET_VERSION = AAR_VERSION;

var AAR_URL = $"https://search.maven.org/remotecontent?filepath=com/jakewharton/threetenabp/threetenabp/{AAR_VERSION}/threetenabp-{AAR_VERSION}.aar";
var JAR_URL = $"https://search.maven.org/remotecontent?filepath=org/threeten/threetenbp/{JAR_VERSION}/threetenbp-{JAR_VERSION}-no-tzdb.jar";

Task ("Externals")
	.WithCriteria (!FileExists ("./externals/threetenabp.aar"))
	.Does (() =>
{
	EnsureDirectoryExists ("./externals");

	DownloadFile (AAR_URL, "./externals/threetenabp.aar");
	DownloadFile (JAR_URL, "./externals/threetenbp-no-tzdb.jar");

	XmlPoke("./ThreeTenABP/ThreeTenABP.csproj", "/Project/PropertyGroup/PackageVersion", NUGET_VERSION);
});


Task("Libs")
	.IsDependentOn("Externals")
	.Does(() =>
{
	MSBuild("./ThreeTenABP/ThreeTenABP.csproj", c => {
		c.Configuration = "Release";
		c.Restore = true;
		c.MaxCpuCount = 0;
		c.Properties.Add("DesignTimeBuild", new [] { "false" });
	});
});

Task("Nuget")
	.IsDependentOn("Libs")
	.Does(() =>
{
	MSBuild ("./ThreeTenABP/ThreeTenABP.csproj", c => {
		c.Configuration = "Release";
		c.MaxCpuCount = 0;
		c.Targets.Clear();
		c.Targets.Add("Pack");
		c.Properties.Add("PackageOutputPath", new [] { MakeAbsolute(new FilePath("./output")).FullPath });
		c.Properties.Add("PackageRequireLicenseAcceptance", new [] { "true" });
		c.Properties.Add("DesignTimeBuild", new [] { "false" });
	});
});

Task ("Clean")
	.Does (() =>
{
	if (DirectoryExists ("./externals/"))
		DeleteDirectory ("./externals", new DeleteDirectorySettings {
			Recursive = true,
			Force = true
		});
});

Task ("Default")
    // .IsDependentOn("Clean")
    // .IsDependentOn("Nuget")
    .IsDependentOn("Nuget")
    .Does(() => {});

RunTarget (target);