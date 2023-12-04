using HetznerClient.Model.Attributes;

namespace HetznerClient.Model.Cloud.LoadBalancers;

public enum LoadBalancerTargetType {
	[EnumValue("server")]
	Server = 0,

	[EnumValue("label_selector")]
	LabelSelector = 1,

	[EnumValue("ip")]
	Ip = 2
}


