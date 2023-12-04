using Newtonsoft.Json;

namespace HetznerClient.Model.Cloud.LoadBalancers;

public class LoadBalancerAlgorithm {
	[JsonProperty("type")]
	public LoadBalancerAlgorithmType Type { get; set; }
}


