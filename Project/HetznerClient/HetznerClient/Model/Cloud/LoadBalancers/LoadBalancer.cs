using Newtonsoft.Json;

namespace HetznerClient.Model.Cloud.LoadBalancers;

public class LoadBalancer {
	/// <summary>
	/// Algorithm of the Load Balancer
	/// </summary>
	[JsonProperty("algorithm")]
	public LoadBalancerAlgorithm Algorithm { get; set; }

	/// <summary>
	/// Point in time when the Resource was created (in ISO-8601 format)
	/// </summary>
	[JsonProperty("created")]
	public DateTime Created { get; set; }

	/// <summary>
	/// ID of the Resource
	/// </summary>
	[JsonProperty("id")]
	public long Id { get; set; }

	/// <summary>
	/// Free Traffic for the current billing period in bytes
	/// </summary>
	[JsonProperty("included_traffic")]
	public long IncludedTraffic { get; set; }

	/// <summary>
	/// Inbound Traffic for the current billing period in bytes
	/// </summary>
	[JsonProperty("ingoing_traffic", Required=Required.AllowNull)]
	public long? IngoingTraffic { get; set; }

	/// <summary>
	/// User-defined labels (key-value pairs)
	/// </summary>
	[JsonProperty("labels")]
	public Dictionary<string, string> Labels { get; set; }

	[JsonProperty("load_balancer_type")]
	public LoadBalancerType LoadBalancerType { get; set; }

	[JsonProperty("location")]
	public LoadBalancerLocation Location { get; set; }

	/// <summary>
	/// Name of the Resource. Must be unique per Project.
	/// </summary>
	[JsonProperty("name")]
	public string Name { get; set; }

	/// <summary>
	/// Outbound Traffic for the current billing period in bytes
	/// </summary>
	[JsonProperty("outgoing_traffic", Required=Required.AllowNull)]
	public long? OutgoingTraffic { get; set; }

	/// <summary>
	/// Private networks information
	/// </summary>
	[JsonProperty("private_net")]
	public IEnumerable<LoadBalancerPrivateNet> PrivateNet { get; set; }

	/// <summary>
	/// Protection configuration for the Resource
	/// </summary>
	[JsonProperty("protection")]
	public LoadBalancerProtection Protection { get; set; }

	/// <summary>
	/// Public network information
	/// </summary>
	[JsonProperty("public_net")]
	public LoadBalancerPublicNet PublicNet { get; set; }

	/// <summary>
	/// List of services that belong to this Load Balancer
	/// </summary>
	[JsonProperty("services")]
	public IEnumerable<LoadBalancerService> Services { get; set; }

	/// <summary>
	/// List of targets that belong to this Load Balancer
	/// </summary>
	[JsonProperty("targets")]
	public IEnumerable<LoadBalancerTarget> Targets { get; set; }
}


