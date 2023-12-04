using HetznerClient.Model.Attributes;

namespace HetznerClient.Model.Cloud.Firewalls;

/// <summary>
/// Firewall application resource type, not to be confused with <see cref="FirewallApplicationType"/>
/// </summary>
public enum FirewallApplicationResourceType {
	[EnumValue("server")]
	Server = 0
}



