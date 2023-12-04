using Newtonsoft.Json;

namespace HetznerClient.Model.Cloud.LoadBalancers;

public class LoadBalancerType {
	/// <summary>
	/// Point in time when the Load Balancer type is deprecated (in ISO-8601 format)
	/// </summary>
	[JsonProperty("deprecated", Required=Required.AllowNull)]
	public DateTime? Deprecated { get; set; }

	/// <summary>
	/// Description of the Load Balancer type
	/// </summary>
	[JsonProperty("description")]
	public string Description { get; set; }

	/// <summary>
	/// ID of the Load Balancer type
	/// </summary>
	[JsonProperty("id")]
	public long Id { get; set; }

	/// <summary>
	/// Number of SSL Certificates that can be assigned to a single Load Balancer
	/// </summary>
	[JsonProperty("max_assigned_certificates")]
	public long MaxAssignedCertificates { get; set; }

	/// <summary>
	/// Number of maximum simultaneous open connections
	/// </summary>
	[JsonProperty("max_connections")]
	public long MaxConnections { get; set; }

	/// <summary>
	/// Number of services a Load Balancer of this type can have
	/// </summary>
	[JsonProperty("max_services")]
	public long MaxServices { get; set; }

	/// <summary>
	/// Number of targets a single Load Balancer can have
	/// </summary>
	[JsonProperty("max_targets")]
	public long MaxTargets { get; set; }

	/// <summary>
	/// Unique identifier of the Load Balancer type
	/// </summary>
	[JsonProperty("name")]
	public string Name { get; set; }

	/// <summary>
	/// Prices in different network zones
	/// </summary>
	[JsonProperty("prices")]
	public IEnumerable<LoadBalancerPrice> Prices { get; set; }
}


