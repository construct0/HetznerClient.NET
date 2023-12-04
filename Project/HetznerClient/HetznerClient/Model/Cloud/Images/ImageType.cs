using HetznerClient.Model.Attributes;

namespace HetznerClient.Model.Cloud.Images;

public enum ImageType {
	[EnumValue("system")]
	System = 0,

	[EnumValue("app")]
	App = 1,

	[EnumValue("snapshot")]
	Snapshot = 2,

	[EnumValue("backup")]
	Backup = 3,

	[EnumValue("temporary")]
	Temporary = 4
}

