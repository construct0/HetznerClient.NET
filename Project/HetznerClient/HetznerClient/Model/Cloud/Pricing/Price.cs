using Newtonsoft.Json;

namespace HetznerClient.Model.Cloud.Pricing;

public class Price {
	/// <summary>
	/// Price with VAT added
	/// </summary>
	[JsonProperty("gross")]
	public double Gross { get; set; }

	/// <summary>
	/// Price without VAT
	/// </summary>
	[JsonProperty("net")]
	public double Net { get; set; }
}
