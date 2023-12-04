using Newtonsoft.Json;

namespace HetznerClient.Model.Cloud.LoadBalancers;

public class LoadBalancerTargetIp {
	/// <summary>
	/// IP of a server that belongs to the same customer (public IPv4/IPv6) or private IP in a Subnetwork type vswitch.
	/// </summary>
	[JsonProperty("ip")]
	public string Ip { get; set; }
}


