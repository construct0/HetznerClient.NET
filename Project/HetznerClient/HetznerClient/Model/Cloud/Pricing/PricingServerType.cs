using Newtonsoft.Json;

namespace HetznerClient.Model.Cloud.Pricing;

public class PricingServerType {
	/// <summary>
	/// ID of the server type the price is for
	/// </summary>
	[JsonProperty("id")]
	public long Id { get; set; }

	/// <summary>
	/// Name of the server type the price is for
	/// </summary>
	[JsonProperty("name")]
	public string Name { get; set; }

	/// <summary>
	/// Server costs per Location
	/// </summary>
	[JsonProperty("prices")]
	public IEnumerable<PricingServerTypePrice> Prices { get; set; }
}