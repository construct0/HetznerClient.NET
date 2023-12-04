using Newtonsoft.Json;

namespace HetznerClient.Model.Cloud.LoadBalancers;

public class LoadBalancerTargetHealthStatus {
	[JsonProperty("listen_port")]
	public long ListenPort { get; set; }

	[JsonProperty("status")]
	public LoadBalancerTargetHealthStatusType Status { get; set; }
}


