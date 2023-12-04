using Newtonsoft.Json;

namespace HetznerClient.Model.Cloud;

public abstract class CloudIPDnsPointer {
	/// <summary>
	/// DNS pointer for the specific IP address
	/// </summary>
	[JsonProperty("dns_ptr")]
	public string DnsPointer { get; set; }

	// todo substitute with native IpAddress after conversion ? 
	/// <summary>
	/// Single IPv4 or IPv6 address
	/// </summary>
	[JsonProperty("ip")]
	public string Ip { get; set; }
}
