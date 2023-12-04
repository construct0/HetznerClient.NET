using Newtonsoft.Json;

namespace HetznerClient.Model.Cloud.Pricing;

public class PricingServerTypePrice {
	/// <summary>
	/// Name of the Location the prices are for
	/// </summary>
	[JsonProperty("location")]
	public string Location { get; set; }

	/// <summary>
	/// Hourly costs for one in this network zone
	/// </summary>
	[JsonProperty("price_hourly")]
	public Price PriceHourly { get; set; }

	/// <summary>
	/// Monthly costs for one in this network zone
	/// </summary>
	[JsonProperty("price_monthly")]
	public Price PriceMonthly { get; set; }
}