using Newtonsoft.Json;

namespace HetznerClient.Model.Cloud.LoadBalancerTypes;

public class LoadBalancerTypePriceClass {
	/// <summary>
	/// Price with VAT added
	/// </summary>
	[JsonProperty("gross")]
	public string Gross { get; set; }

	/// <summary>
	/// Price without VAT
	/// </summary>
	[JsonProperty("net")]
	public string Net { get; set; }
}


