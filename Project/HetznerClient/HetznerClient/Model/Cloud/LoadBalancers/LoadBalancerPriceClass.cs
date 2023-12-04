using Newtonsoft.Json;

namespace HetznerClient.Model.Cloud.LoadBalancers;

/// <summary>
/// Price for a network zone
/// </summary>
public class LoadBalancerPriceClass {
	[JsonProperty("gross")]
	public string Gross { get; set; }

	[JsonProperty("net")]
	public string Net { get; set; }
}


