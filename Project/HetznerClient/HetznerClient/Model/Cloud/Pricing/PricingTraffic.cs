using Newtonsoft.Json;

namespace HetznerClient.Model.Cloud.Pricing;

public class PricingTraffic {
	[JsonProperty("price_per_tb")]
	public Price PricePerTb { get; set; }
}