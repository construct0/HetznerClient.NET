using Newtonsoft.Json;

namespace HetznerClient.Model.Cloud.Servers;

/// <summary>
/// IP address (v6) assignment and its reverse DNS entry
/// </summary>
public class ServerIPv6 {
	/// <summary>
	/// If the IP is blocked by our anti abuse dept
	/// </summary>
	[JsonProperty("blocked")]
	public bool Blocked { get; set; }

	/// <summary>
	/// Reverse DNS PTR entries for the IPv6 addresses of this Server, null by default
	/// </summary>
	[JsonProperty("dns_ptr")]
	public IEnumerable<ServerDNSPointer> DNSPointer { get; set; }

	/// <summary>
	/// ID of the Resource
	/// </summary>
	[JsonProperty("id")]
	public long Id { get; set; }

	/// <summary>
	/// IP address (v6) of this Server
	/// </summary>
	[JsonProperty("ip")]
	public string Ip { get; set; }
}


