using HetznerClient.Model.Attributes;

namespace HetznerClient.Model.Cloud.ISOs;

public enum ISOType {
	[EnumValue("public")]
	Public = 0,

	[EnumValue("private")]
	Private = 1
}
