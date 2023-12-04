using Newtonsoft.Json;

namespace HetznerClient.Model.Cloud.LoadBalancers;

public class LoadBalancerService {
	/// <summary>
	/// Port the Load Balancer will balance to
	/// </summary>
	[JsonProperty("destination_port")]
	public long DestinationPort { get; set; }

	/// <summary>
	/// Service health check
	/// </summary>
	[JsonProperty("health_check")]
	public LoadBalancerServiceHealthCheck HealthCheck { get; set; }

	/// <summary>
	/// Configuration option for protocols http and https
	/// </summary>
	[JsonProperty("http")]
	public LoadBalancerServiceHttp Http { get; set; }

	/// <summary>
	/// Port the Load Balancer listens on
	/// </summary>
	[JsonProperty("listen_port")]
	public long ListenPort { get; set; }

	/// <summary>
	/// Protocol of the Load Balancer
	/// </summary>
	[JsonProperty("protocol")]
	public LoadBalancerServiceProtocol Protocol { get; set; }

	/// <summary>
	/// Is Proxyprotocol enabled or not
	/// </summary>
	[JsonProperty("proxyprotocol")]
	public bool Proxyprotocol { get; set; }
}


