using Newtonsoft.Json;

namespace HetznerClient.Model.Cloud.Pricing;

public class PricingLoadBalancerType {
	/// <summary>
	/// ID of the Load Balancer type the price is for
	/// </summary>
	[JsonProperty("id")]
	public long Id { get; set; }

	/// <summary>
	/// Name of the Load Balancer type the price is for
	/// </summary>
	[JsonProperty("name")]
	public string Name { get; set; }

	/// <summary>
	/// Load Balancer type costs per Location
	/// </summary>
	[JsonProperty("prices")]
	public IEnumerable<PricingLoadBalancerTypePrice> Prices { get; set; }
}
