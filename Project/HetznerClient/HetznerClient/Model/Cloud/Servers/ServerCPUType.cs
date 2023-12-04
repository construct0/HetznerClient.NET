using HetznerClient.Model.Attributes;

namespace HetznerClient.Model.Cloud.Servers;

public enum ServerCPUType {
	[EnumValue("shared")]
	Shared = 0,

	[EnumValue("dedicated")]
	Dedicated = 1
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

