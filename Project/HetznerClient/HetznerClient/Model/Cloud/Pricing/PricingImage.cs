using Newtonsoft.Json;

namespace HetznerClient.Model.Cloud.Pricing;

public class PricingImage {
	[JsonProperty("price_per_gb_month")]
	public Price PricePerGbMonth { get; set; }
}
