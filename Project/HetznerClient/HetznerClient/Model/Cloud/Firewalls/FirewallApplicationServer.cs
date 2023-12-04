using Newtonsoft.Json;

namespace HetznerClient.Model.Cloud.Firewalls;

// todo revisit this to add see-ref to the fullblown server object, or swap it out if deemed necessary
/// <summary>
/// Tailored version of the Server object, containing solely the id.
/// </summary>
public class FirewallApplicationServer {
	[JsonProperty("id")]
	public long Id { get; set; }
}



