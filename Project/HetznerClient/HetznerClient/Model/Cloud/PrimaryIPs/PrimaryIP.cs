using HetznerClient.Model.Cloud.Datacenters;
using Newtonsoft.Json;

namespace HetznerClient.Model.Cloud.PrimaryIPs;

/// <summary>
/// <para>Primary IPs help you to create more flexible networking setups. You can assign at most one Primary IP of type ipv4 and one of type ipv6 per Server. This Server then uses these IPs.</para>
/// <para>You can only unassign a Primary IP from a Server when it's powered off. This Primary IP can then be assigned to a different powered off Server, or you can keep it around for later use.</para>
/// <para>Primary IPs are bound to a specific Datacenter.You can not assign a Primary IP from one Datacenter to a Server in a different Datacenter. If you need this capability use Floating IPs instead.</para>
/// <para>If your Server's operating system supports cloud-init there is no further configuration needed to make Primary IPs work.</para>
/// <para>Primary IPs of type ipv4 use a single IPv4 address as their ip property.Primary IPs of type ipv6 use a /64 network such as fc00::/64 as their ip property.Any IP address within that network can be used on your host.</para>
/// </summary>
public class PrimaryIP {
	/// <summary>
	/// ID of the resource the Primary IP is assigned to, null if it is not assigned at all
	/// </summary>
	[JsonProperty("assignee_id", Required=Required.AllowNull)]
	public long? AssigneeId { get; set; }

	/// <summary>
	/// Resource type the Primary IP can be assigned to
	/// </summary>
	[JsonProperty("assignee_type")]
	public string AssigneeType { get; set; }

	/// <summary>
	/// Delete this Primary IP when the resource it is assigned to is deleted
	/// </summary>
	[JsonProperty("auto_delete")]
	public bool AutoDelete { get; set; }

	/// <summary>
	/// Whether the IP is blocked
	/// </summary>
	[JsonProperty("blocked")]
	public bool Blocked { get; set; }

	/// <summary>
	/// Point in time when the Resource was created (in ISO-8601 format)
	/// </summary>
	[JsonProperty("created")]
	public DateTime Created { get; set; }

	/// <summary>
	/// Datacenter this Primary IP is located at
	/// </summary>
	[JsonProperty("datacenter")]
	public Datacenter Datacenter { get; set; }

	/// <summary>
	/// Array of reverse DNS entries
	/// </summary>
	[JsonProperty("dns_ptr")]
	public List<PrimaryIPDNSPointer> DNSPointer { get; set; }

	/// <summary>
	/// ID of the Resource
	/// </summary>
	[JsonProperty("id")]
	public long Id { get; set; }

	/// <summary>
	/// IP address
	/// </summary>
	[JsonProperty("ip")]
	public string IP { get; set; }

	/// <summary>
	/// User-defined labels (key-value pairs)
	/// </summary>
	[JsonProperty("labels")]
	public IDictionary<string, string> Labels { get; set; }

	/// <summary>
	/// Name of the Resource. Must be unique per Project.
	/// </summary>
	[JsonProperty("name")]
	public string Name { get; set; }

	/// <summary>
	/// Protection configuration for the Resource
	/// </summary>
	[JsonProperty("protection")]
	public PrimaryIPProtection Protection { get; set; }

	/// <summary>
	/// Type of the Primary IP
	/// </summary>
	[JsonProperty("type")]
	public PrimaryIPType Type { get; set; }
}
