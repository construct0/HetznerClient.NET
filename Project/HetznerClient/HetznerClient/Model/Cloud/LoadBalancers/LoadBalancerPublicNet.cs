using Newtonsoft.Json;

namespace HetznerClient.Model.Cloud.LoadBalancers;

/// <summary>
/// Public network information
/// </summary>
public class LoadBalancerPublicNet {
	/// <summary>
	/// Public network information
	/// </summary>
	[JsonProperty("enabled")]
	public bool Enabled { get; set; }

	/// <summary>
	/// Ip address (ipv4)
	/// </summary>
	[JsonProperty("ipv4")]
	public LoadBalancerPublicNetIp Ipv4 { get; set; }

	/// <summary>
	/// Ip address (ipv6)
	/// </summary>
	[JsonProperty("ipv6")]
	public LoadBalancerPublicNetIp Ipv6 { get; set; }
}


