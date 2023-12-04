using HetznerClient.Model.Attributes;

namespace HetznerClient.Model.Cloud.Images;

public enum ImageOsFlavor {
	[EnumValue("ubuntu")]
	Ubuntu = 0,

	[EnumValue("centos")]
	CentOS = 1,

	[EnumValue("debian")]
	Debian = 2,

	[EnumValue("fedora")]
	Fedora = 3,

	[EnumValue("rocky")]
	Rocky = 4,

	[EnumValue("alma")]
	Alma = 5,

	[EnumValue("unknown")]
	Unknown = 6
}

