using Newtonsoft.Json;

namespace HetznerClient.Model.Cloud.Servers;

public partial class ServerProtection {
	/// <summary>
	/// If true, prevents the Server from being deleted
	/// </summary>
	[JsonProperty("delete")]
	public bool Delete { get; set; } = true;

	/// <summary>
	/// If true, prevents the Server from being rebuilt
	/// </summary>
	[JsonProperty("rebuild")]
	public bool Rebuild { get; set; } = true;
}

//public partial class Price {
//	[JsonProperty("location")]
//	public string Location { get; set; }

//	[JsonProperty("price_hourly")]
//	public PriceHourlyClass PriceHourly { get; set; }

//	[JsonProperty("price_monthly")]
//	public PriceHourlyClass PriceMonthly { get; set; }
//}

//public partial class PriceHourlyClass {
//	[JsonProperty("gross")]
//	public string Gross { get; set; }

//	[JsonProperty("net")]
//	public string Net { get; set; }
//}

