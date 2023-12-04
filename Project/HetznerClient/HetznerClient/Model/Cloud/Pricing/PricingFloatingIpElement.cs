using HetznerClient.Model.Cloud.FloatingIPs;
using Newtonsoft.Json;

namespace HetznerClient.Model.Cloud.Pricing;

public class PricingFloatingIPElement {
	/// <summary>
	/// Floating IP type costs per Location
	/// </summary>
	[JsonProperty("prices")]
	public IEnumerable<PricingFloatingIPPrice> Prices { get; set; }

	/// <summary>
	/// The type of the Floating IP
	/// </summary>
	[JsonProperty("type")]
	public FloatingIPType Type { get; set; }
}
