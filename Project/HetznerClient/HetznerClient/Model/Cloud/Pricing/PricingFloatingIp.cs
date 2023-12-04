using Newtonsoft.Json;

namespace HetznerClient.Model.Cloud.Pricing;

public class PricingFloatingIP {
	[JsonProperty("price_monthly")]
	public Price PriceMonthly { get; set; }
}
