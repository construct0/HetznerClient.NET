using HetznerClient.Model.Attributes;

namespace HetznerClient.Model.Cloud.Volumes;

/// <summary>
/// Current status of a <see cref="Volume"/>
/// </summary>
public enum VolumeStatus {
	[EnumValue("creating")]
	Creating = 0,

	[EnumValue("available")]
	Available = 1
}
