using HetznerClient.Model.Attributes;

namespace HetznerClient.Model.Cloud.LoadBalancers;

public enum LoadBalancerTargetHealthStatusType {
	[EnumValue("healthy")]
	Healthy = 0,

	[EnumValue("Unhealthy")]
	Unhealthy = 1,

	[EnumValue("unknown")]
	Unknown = 2
}


