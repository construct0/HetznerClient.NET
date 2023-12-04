using HetznerClient.Model.Attributes;

namespace HetznerClient.Model.Cloud.Images;

public enum ImageStatus {
	[EnumValue("available")]
	Available = 0,

	[EnumValue("creating")]
	Creating = 1,

	[EnumValue("unavailable")]
	Unavailable = 2
}

