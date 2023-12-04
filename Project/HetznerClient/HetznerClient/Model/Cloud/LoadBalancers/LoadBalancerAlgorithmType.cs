using HetznerClient.Model.Attributes;

namespace HetznerClient.Model.Cloud.LoadBalancers;

public enum LoadBalancerAlgorithmType {
	[EnumValue("round_robin")]
	RoundRobin = 0,

	[EnumValue("least_connections")]
	LeastConnections = 1
}


