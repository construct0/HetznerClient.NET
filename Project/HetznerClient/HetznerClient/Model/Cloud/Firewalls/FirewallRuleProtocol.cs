using HetznerClient.Model.Attributes;

namespace HetznerClient.Model.Cloud.Firewalls;

/// <summary>
/// Type of traffic to allow, one type per <see cref="FirewallRule"/>.
/// </summary>
public enum FirewallRuleProtocol {
	[EnumValue("tcp")]
	TCP = 0,

	[EnumValue("udp")]
	UDP = 1,

	[EnumValue("icmp")]
	ICMP = 2,

	[EnumValue("esp")]
	ESP = 3,

	[EnumValue("gre")]
	GRE = 4
}



