using HetznerClient.Model.Attributes;

namespace HetznerClient.Model.Cloud.LoadBalancers;

public enum LoadBalancerHealthCheckProtocol {
	[EnumValue("tcp")]
	TCP = 0,

	[EnumValue("http")]
	HTTP = 1
}


