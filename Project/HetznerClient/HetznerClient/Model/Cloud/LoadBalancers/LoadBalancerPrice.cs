using Newtonsoft.Json;

namespace HetznerClient.Model.Cloud.LoadBalancers;

public class LoadBalancerPrice {
	/// <summary>
	/// Name of the Location the price is for
	/// </summary>
	[JsonProperty("location")]
	public string Location { get; set; }

	/// <summary>
	/// Hourly costs for a Resource in this Location
	/// </summary>
	[JsonProperty("price_hourly")]
	public LoadBalancerPriceClass PriceHourly { get; set; }

	/// <summary>
	/// Monthly costs for a Resource in this Location
	/// </summary>
	[JsonProperty("price_monthly")]
	public LoadBalancerPriceClass PriceMonthly { get; set; }
}


