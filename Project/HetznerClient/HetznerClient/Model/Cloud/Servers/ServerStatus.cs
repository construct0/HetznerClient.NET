using HetznerClient.Model.Attributes;

namespace HetznerClient.Model.Cloud.Servers;

public enum ServerStatus {
	[EnumValue("running")]
	Running = 0,

	[EnumValue("initializing")]
	Initializing = 1,

	[EnumValue("starting")]
	Starting = 2,

	[EnumValue("stopping")]
	Stopping = 3,

	[EnumValue("off")]
	Off = 4,

	[EnumValue("deleting")]
	Deleting = 5,

	[EnumValue("migrating")]
	Migrating = 6,

	[EnumValue("rebuilding")]
	Rebuilding = 7,

	[EnumValue("unknown")]
	Unknown = 8
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

