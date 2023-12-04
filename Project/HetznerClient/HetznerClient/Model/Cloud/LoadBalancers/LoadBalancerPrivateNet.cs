using Newtonsoft.Json;

namespace HetznerClient.Model.Cloud.LoadBalancers;

public class LoadBalancerPrivateNet {
	/// <summary>
	/// IP address (v4) of this Load Balancer in this Network
	/// </summary>
	[JsonProperty("ip")]
	public string Ip { get; set; }

	/// <summary>
	/// ID of the Network
	/// </summary>
	[JsonProperty("network")]
	public long NetworkId { get; set; }
}


