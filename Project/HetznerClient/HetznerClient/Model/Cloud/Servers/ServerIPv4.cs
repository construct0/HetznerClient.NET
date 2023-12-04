using Newtonsoft.Json;

namespace HetznerClient.Model.Cloud.Servers;

/// <summary>
/// IP address (v4) assignment and its reverse DNS entry
/// </summary>
public class ServerIPv4 {
	/// <summary>
	/// If the IP is blocked by our anti abuse dept
	/// </summary>
	[JsonProperty("blocked")]
	public bool Blocked { get; set; }

	/// <summary>
	/// Reverse DNS PTR entry for the IPv4 addresses of this Server
	/// </summary>
	[JsonProperty("dns_ptr")]
	public string DNSPointer { get; set; }

	/// <summary>
	/// ID of the Resource
	/// </summary>
	[JsonProperty("id")]
	public long Id { get; set; }

	/// <summary>
	/// IP address (v4) of this Server
	/// </summary>
	[JsonProperty("ip")]
	public string Ip { get; set; }
}


