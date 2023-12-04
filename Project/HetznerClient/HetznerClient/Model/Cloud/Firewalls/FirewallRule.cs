using Newtonsoft.Json;

namespace HetznerClient.Model.Cloud.Firewalls;

/// <summary>
/// A single <see cref="Firewall"/> rule
/// </summary>
public class FirewallRule {
	/// <summary>
	/// Description of the Rule
	/// </summary>
	[JsonProperty("description", Required = Required.AllowNull)]
	public string? Description { get; set; }

	/// <summary>
	/// List of permitted IPv4/IPv6 addresses in CIDR notation. Use 0.0.0.0/0 to allow all IPv4 addresses and ::/0 to allow all IPv6 addresses. You can specify 100 CIDRs at most.
	/// </summary>
	[JsonProperty("destination_ips", Required = Required.AllowNull)]
	public IEnumerable<string>? DestinationIps { get; set; }

	/// <summary>
	/// Select traffic direction on which rule should be applied. Use <see cref="FirewallRule.SourceIps"/> for direction in and <see cref="FirewallRule.DestinationIps"/> for direction out.
	/// </summary>
	[JsonProperty("direction")]
	public FirewallRuleDirection Direction { get; set; }

	/// <summary>
	/// Port or port range to which traffic will be allowed, only applicable for protocols TCP and UDP. A port range can be specified by separating two ports with a dash, e.g 1024-5000.
	/// </summary>
	[JsonProperty("port", Required = Required.AllowNull)]
	public string? Port { get; set; }

	/// <summary>
	/// Type of traffic to allow, one type per rule.
	/// </summary>
	[JsonProperty("protocol")]
	public FirewallRuleProtocol Protocol { get; set; }

	/// <summary>
	/// List of permitted IPv4/IPv6 addresses in CIDR notation. Use 0.0.0.0/0 to allow all IPv4 addresses and ::/0 to allow all IPv6 addresses. You can specify 100 CIDRs at most.
	/// </summary>
	[JsonProperty("source_ips", Required = Required.AllowNull)]
	public IEnumerable<string>? SourceIps { get; set; }
}



