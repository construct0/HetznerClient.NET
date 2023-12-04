namespace HetznerClient.Model.Constants;

/// <summary>
/// The version of this nuget package uses <see href="https://semver.org/">semantic versioning</see> (in its simplest form).
/// </summary>
public static class Version {
	public const int Major = 0;
	public const int Minor = 0;
	public const int Patch = 0;

	public static string Number => $"{Major}.{Minor}.{Patch}";
}

public static class Application {
	public const string Name = "HetznerClient";
}

