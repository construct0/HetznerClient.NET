using Newtonsoft.Json;

namespace HetznerClient.Model.Cloud.Networks;

public class NetworkProtection {
	/// <summary>
	/// If true, prevents the <see cref="Network"/> from being deleted
	/// </summary>
	[JsonProperty("delete")]
	public bool Delete { get; set; } = true;
}

