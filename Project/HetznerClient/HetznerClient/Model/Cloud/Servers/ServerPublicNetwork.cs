using Newtonsoft.Json;

namespace HetznerClient.Model.Cloud.Servers;

/// <summary>
/// Public network information
/// </summary>
public class ServerPublicNetwork {
	/// <summary>
	/// Firewalls applied to the public network interface of this Server
	/// </summary>
	[JsonProperty("firewalls")]
	public IEnumerable<ServerFirewall> Firewalls { get; set; }

	/// <summary>
	/// IDs of Floating IPs assigned to this Server
	/// </summary>
	[JsonProperty("floating_ips")]
	public IEnumerable<long> FloatingIPIds { get; set; }

	/// <summary>
	/// IP address (v4) and its reverse DNS entry of this Server
	/// </summary>
	[JsonProperty("ipv4", Required = Required.AllowNull)]
	public string? IPv4 { get; set; }

	/// <summary>
	/// IPv6 network assigned to this Server and its reverse DNS entry
	/// </summary>
	[JsonProperty("ipv6", Required = Required.AllowNull)]
	public string? IPv6 { get; set; }
}


