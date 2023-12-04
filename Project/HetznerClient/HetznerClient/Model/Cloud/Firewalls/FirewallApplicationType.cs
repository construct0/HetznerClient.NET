using HetznerClient.Model.Attributes;

namespace HetznerClient.Model.Cloud.Firewalls;

/// <summary>
/// Firewall application type, not to be confused with <see cref="FirewallApplicationResourceType"/>
/// </summary>
public enum FirewallApplicationType {
	[EnumValue("server")]
	Server = 0,

	[EnumValue("label_selector")]
	LabelSelector = 1
}



