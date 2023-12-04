using Newtonsoft.Json;

namespace HetznerClient.Model.Cloud.Pricing;

public class PricingFloatingIPPrice {
	/// <summary>
	/// Name of the Location the price is for
	/// </summary>
	[JsonProperty("location")]
	public string Location { get; set; }

	/// <summary>
	/// Monthly costs for a Floating IP type in this Location
	/// </summary>
	[JsonProperty("price_monthly")]
	public Price PriceMonthly { get; set; }
}
