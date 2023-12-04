using Newtonsoft.Json;

namespace HetznerClient.Model.Cloud.Servers;

/// <summary>
/// Private network detailed information
/// </summary>
public class ServerPrivateNetwork {
	[JsonProperty("alias_ips")]
	public IEnumerable<string> AliasIps { get; set; }

	[JsonProperty("ip")]
	public string Ip { get; set; }

	[JsonProperty("mac_address")]
	public string MacAddress { get; set; }

	[JsonProperty("network")]
	public long NetworkId { get; set; }
}

