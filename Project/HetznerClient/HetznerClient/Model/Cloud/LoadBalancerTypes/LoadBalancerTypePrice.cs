using Newtonsoft.Json;

namespace HetznerClient.Model.Cloud.LoadBalancerTypes;

public class LoadBalancerTypePrice {
	/// <summary>
	/// Name of the Location the price is for
	/// </summary>
	[JsonProperty("location")]
	public string Location { get; set; }

	/// <summary>
	/// Hourly costs for a Resource in this Location
	/// </summary>
	[JsonProperty("price_hourly")]
	public LoadBalancerTypePriceClass PriceHourly { get; set; }

	/// <summary>
	/// Monthly costs for a Resource in this Location
	/// </summary>
	[JsonProperty("price_monthly")]
	public LoadBalancerTypePriceClass PriceMonthly { get; set; }
}


