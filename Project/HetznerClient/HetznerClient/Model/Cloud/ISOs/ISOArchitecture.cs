using HetznerClient.Model.Attributes;

namespace HetznerClient.Model.Cloud.ISOs;

public enum ISOArchitecture {
	[EnumValue("x86")]
	X86 = 0,

	[EnumValue("arm")]
	Arm = 1
}
