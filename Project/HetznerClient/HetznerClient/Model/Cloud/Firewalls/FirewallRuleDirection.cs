using HetznerClient.Model.Attributes;

namespace HetznerClient.Model.Cloud.Firewalls;

/// <summary>
/// Select traffic direction on which rule should be applied. Use <see cref="FirewallRule.SourceIps"/> for direction in and <see cref="FirewallRule.DestinationIps"/> for direction out.
/// </summary>
public enum FirewallRuleDirection {
	[EnumValue("in")]
	In = 0,

	[EnumValue("out")]
	Out = 1
}



