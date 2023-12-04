using Newtonsoft.Json;

namespace HetznerClient.Model.Cloud.Firewalls;

/// <summary>
/// Specifies a firewall application overview.
/// </summary>
public class FirewallApplication {
	/// <summary>
	/// Specifies which resources the firewall has been applied to.
	/// </summary>
	[JsonProperty("applied_to_resources")]
	public IEnumerable<FirewallApplicationResource>? AppliedToResources { get; set; }

	/// <summary>
	/// Relevant labels
	/// </summary>
	[JsonProperty("label_selector")]
	public IDictionary<string, string>? Labels { get; set; }

	/// <summary>
	/// Tailored version of the Server object, containing solely the id.
	/// </summary>
	[JsonProperty("server")]
	public FirewallApplicationServer? Server { get; set; }

	/// <summary>
	/// Firewall application type, not to be confused with <see cref="FirewallApplicationResourceType"/>
	/// </summary>
	[JsonProperty("type")]
	public FirewallApplicationType Type { get; set; }
}



