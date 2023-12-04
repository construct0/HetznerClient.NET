using HetznerClient.Model.Cloud.Firewalls;
using Newtonsoft.Json;

namespace HetznerClient.Model.Cloud.Servers;

/// <summary>
/// Tailored version of <see cref="Firewall"/> (minified)
/// </summary>
public class ServerFirewall {
	[JsonProperty("id")]
	public long Id { get; set; }

	[JsonProperty("status")]
	public ServerFirewallStatus Status { get; set; }
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

