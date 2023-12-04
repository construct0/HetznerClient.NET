using HetznerClient.Model.Attributes;

namespace HetznerClient.Model.Cloud.Images;

public enum ImageArchitecture {
	[EnumValue("x86")]
	X86 = 0,

	[EnumValue("arm")]
	Arm = 1
}

