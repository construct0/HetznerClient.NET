using Newtonsoft.Json;

namespace HetznerClient.Model.Cloud.LoadBalancers;

/// <summary>
/// Service health check
/// </summary>
public class LoadBalancerServiceHealthCheck {
	/// <summary>
	/// Additional configuration for protocol http
	/// </summary>
	[JsonProperty("http")]
	public LoadBalancerServiceHealthCheckHttp Http { get; set; }

	/// <summary>
	/// Time interval in seconds health checks are performed
	/// </summary>
	[JsonProperty("interval")]
	public long Interval { get; set; }

	/// <summary>
	/// Port the health check will be performed on
	/// </summary>
	[JsonProperty("port")]
	public long Port { get; set; }

	/// <summary>
	/// Type of the health check
	/// </summary>
	[JsonProperty("protocol")]
	public LoadBalancerHealthCheckProtocol Protocol { get; set; }

	/// <summary>
	/// Unsuccessful retries needed until a target is considered unhealthy; an unhealthy target needs the same number of successful retries to become healthy again
	/// </summary>
	[JsonProperty("retries")]
	public long Retries { get; set; }

	/// <summary>
	/// Time in seconds after an attempt is considered a timeout
	/// </summary>
	[JsonProperty("timeout")]
	public long Timeout { get; set; }
}


