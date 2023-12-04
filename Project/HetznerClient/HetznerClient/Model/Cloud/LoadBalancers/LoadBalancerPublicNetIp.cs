using Newtonsoft.Json;

namespace HetznerClient.Model.Cloud.LoadBalancers;

/// <summary>
/// Provides detail about a network ip address (can be ipv4 or ipv6)
/// </summary>
public class LoadBalancerPublicNetIp {
	/// <summary>
	/// Reverse DNS PTR entry for the IPv4 address of this Load Balancer
	/// </summary>
	[JsonProperty("dns_ptr")]
	public string DnsPtr { get; set; }

	/// <summary>
	/// Ip address of this Load Balancer
	/// </summary>
	[JsonProperty("ip")]
	public string Ip { get; set; }
}


