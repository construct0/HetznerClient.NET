using HetznerClient.Model.Attributes;

namespace HetznerClient.Model.Cloud.PrimaryIPs;

/// <summary>
/// Resource type the <see cref="PrimaryIP"/> can be assigned to
/// </summary>
public enum PrimaryIPAssigneeType {
	[EnumValue("server")]
	Server = 0,
}
