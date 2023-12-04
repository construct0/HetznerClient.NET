using HetznerClient.Model.Attributes;

namespace HetznerClient.Model.Cloud.FloatingIPs;

/// <summary>
/// Type of the Floating IP
/// </summary>
public enum FloatingIPType {
	[EnumValue("ipv4")]
	Ipv4 = 0,
	
	[EnumValue("ipv6")]
	Ipv6 = 1
}

