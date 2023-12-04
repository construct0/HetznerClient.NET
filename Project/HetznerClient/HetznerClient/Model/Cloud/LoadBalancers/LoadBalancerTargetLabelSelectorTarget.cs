using Newtonsoft.Json;

namespace HetznerClient.Model.Cloud.LoadBalancers;

public class LoadBalancerTargetLabelSelectorTarget {
	/// <summary>
	/// List of health statuses of the services on this target. Only present for target types "server" and "ip"
	/// </summary>
	[JsonProperty("health_status")]
	public IEnumerable<LoadBalancerTargetHealthStatus> HealthStatus { get; set; }

	/// <summary>
	/// Server where the traffic should be routed to. Only present for target type "server".
	/// </summary>
	[JsonProperty("server")]
	public LoadBalancerTargetServer Server { get; set; }

	/// <summary>
	/// Type of the resource. Here always "server".
	/// </summary>
	[JsonProperty("type")]
	public string Type { get; set; }

	/// <summary>
	/// Use the private network IP instead of the public IP. Default value is false. Only present for target types "server" and "label_selector".
	/// </summary>
	[JsonProperty("use_private_ip")]
	public bool UsePrivateIp { get; set; }
}


