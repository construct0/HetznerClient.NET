using Newtonsoft.Json;

namespace HetznerClient.Model.Cloud.FloatingIPs;

/// <summary>
/// Protection configuration for the Resource
/// </summary>
public class FloatingIPProtection {
	/// <summary>
	/// If true, prevents the Resource from being deleted
	/// </summary>
	[JsonProperty("delete")]
	public bool Delete { get; set; } = true;
}

