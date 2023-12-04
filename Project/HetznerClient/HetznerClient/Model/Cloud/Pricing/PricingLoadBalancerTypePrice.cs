using Newtonsoft.Json;

namespace HetznerClient.Model.Cloud.Pricing;

public class PricingLoadBalancerTypePrice {
	/// <summary>
	/// Name of the Location the price is for
	/// </summary>
	[JsonProperty("location")]
	public string Location { get; set; }

	/// <summary>
	/// Hourly costs for a Load Balancer type in this network zone
	/// </summary>
	[JsonProperty("price_hourly")]
	public Price PriceHourly { get; set; }

	/// <summary>
	/// Monthly costs for a Load Balancer type in this network zone
	/// </summary>
	[JsonProperty("price_monthly")]
	public Price PriceMonthly { get; set; }
}
