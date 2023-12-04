using Newtonsoft.Json;

namespace HetznerClient.Model.Cloud.LoadBalancers;

public class LoadBalancerTargetServer {
	[JsonProperty("id")]
	public long Id { get; set; }
}


