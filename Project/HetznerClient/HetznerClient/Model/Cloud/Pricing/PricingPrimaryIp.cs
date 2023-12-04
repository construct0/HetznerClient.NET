using Newtonsoft.Json;

namespace HetznerClient.Model.Cloud.Pricing;

public class PricingPrimaryIP {
	/// <summary>
	/// Primary IP type costs per Location
	/// </summary>
	[JsonProperty("prices")]
	public IEnumerable<PricingLoadBalancerTypePrice> Prices { get; set; }

	[JsonProperty("type")]
	public string Type { get; set; }
}
