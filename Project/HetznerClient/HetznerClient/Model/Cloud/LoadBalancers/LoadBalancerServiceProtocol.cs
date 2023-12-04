using HetznerClient.Model.Attributes;

namespace HetznerClient.Model.Cloud.LoadBalancers;

public enum LoadBalancerServiceProtocol {
	[EnumValue("tcp")]
	TCP = 0,

	[EnumValue("http")]
	HTTP = 1,

	[EnumValue("https")]
	HTTPS = 2
}


