using Newtonsoft.Json;

namespace HetznerClient.Model.Cloud.LoadBalancers;

public class LoadBalancerTarget {
	/// <summary>
	/// List of health statuses of the services on this target. Only present for target types "server" and "ip".
	/// </summary>
	[JsonProperty("health_status")]
	public IEnumerable<LoadBalancerTargetHealthStatus> HealthStatus { get; set; }

	/// <summary>
	/// IP targets where the traffic should be routed to. It is only possible to use the (Public or vSwitch) IPs of Hetzner Online Root Servers belonging to the project owner. IPs belonging to other users are blocked. Additionally IPs belonging to services provided by Hetzner Cloud (Servers, Load Balancers, ...) are blocked as well. Only present for target type "ip".
	/// </summary>
	[JsonProperty("ip")]
	public LoadBalancerTargetIp Ip { get; set; }

	/// <summary>
	/// Label selector used to determine targets. Only present for target type "label_selector".
	/// </summary>
	[JsonProperty("label_selector")]
	public IDictionary<string, string> Labels { get; set; }

	/// <summary>
	/// Server where the traffic should be routed to. Only present for target type "server".
	/// </summary>
	[JsonProperty("server")]
	public LoadBalancerTargetServer Server { get; set; }

	/// <summary>
	/// List of resolved label selector target Servers. Only present for type "label_selector".
	/// </summary>
	[JsonProperty("targets")]
	public IEnumerable<LoadBalancerTargetLabelSelectorTarget> LabelSelectorTargets { get; set; }

	/// <summary>
	/// Type of the resource
	/// </summary>
	[JsonProperty("type")]
	public LoadBalancerTargetType Type { get; set; }

	/// <summary>
	/// Use the private network IP instead of the public IP. Default value is false. Only present for target types "server" and "label_selector"
	/// </summary>
	[JsonProperty("use_private_ip")]
	public bool UsePrivateIp { get; set; }
}


