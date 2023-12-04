using HetznerClient.Model.Attributes;

namespace HetznerClient.Model.Cloud.PrimaryIPs;

public enum PrimaryIPType {
	[EnumValue("ipv4")]
	IPv4 = 0,

	[EnumValue("ipv6")]
	IPv6 = 1
}