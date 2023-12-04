using Newtonsoft.Json;

namespace HetznerClient.Model.Cloud.Pricing;

public class PricingServerBackup {
	/// <summary>
	/// Percentage by how much the base price will increase
	/// </summary>
	[JsonProperty("percentage")]
	public double Percentage { get; set; }
}
