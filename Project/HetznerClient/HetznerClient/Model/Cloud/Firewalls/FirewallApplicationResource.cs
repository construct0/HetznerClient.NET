using Newtonsoft.Json;

namespace HetznerClient.Model.Cloud.Firewalls;

public class FirewallApplicationResource {
	// todo need to assert if it can be reduced by a converter to just the id; as is the case with FloatingIp
	[JsonProperty("server")]
	public FirewallApplicationServer? Server { get; set; }

	[JsonProperty("type")]
	public FirewallApplicationResourceType Type { get; set; }
}



