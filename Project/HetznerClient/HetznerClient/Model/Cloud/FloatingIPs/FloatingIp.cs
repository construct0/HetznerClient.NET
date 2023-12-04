using Newtonsoft.Json;

namespace HetznerClient.Model.Cloud.FloatingIPs;

/// <summary>
/// <para>Floating IPs help you to create highly available setups. You can assign a Floating IP to any Server. The Server can then use this IP. You can reassign it to a different Server at any time, or you can choose to unassign the IP from Servers all together.</para>
/// <para>Floating IPs can be used globally.This means you can assign a Floating IP to a Server in one Location and later reassign it to a Server in a different Location.For optimal routing and latency Floating IPs should be used in the Location they were created in.</para>
/// <para>For Floating IPs to work with your Server, you must configure them inside your operation system.</para>
/// <para>Floating IPs of type ipv4 use a single IPv4 address as their ip property.Floating IPs of type ipv6 use a /64 network such as fc00::/64 as their ip property.Any IP address within that network can be used on your host.</para>
/// </summary>
public class FloatingIP {
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
	/// Description of the Resource
	/// </summary>
	[JsonProperty("description", Required=Required.AllowNull)]
	public string? Description { get; set; }

	// todo assert if the "floatingip" prepend to the type is wise; may occur in other resp as well
	/// <summary>
	/// Array of reverse DNS entries
	/// </summary>
	[JsonProperty("dns_ptr")]
	public IEnumerable<FloatingIPDnsPointer> DnsPointers { get; set; }

	/// <summary>
	/// Location the Floating IP was created in. Routing is optimized for this Location.
	/// </summary>
	[JsonProperty("home_location")]
	public FloatingIPHomeLocation HomeLocation { get; set; }

	/// <summary>
	/// ID of the Resource
	/// </summary>
	[JsonProperty("id")]
	public long Id { get; set; }

	// todo could perhaps use the native IpAddress type baked into c#
	/// <summary>
	/// IP address
	/// </summary>
	[JsonProperty("ip")]
	public string Ip { get; set; }

	// BVR: Not strictly required although the docs say it is so
	/// <summary>
	/// User-defined labels (key-value pairs)
	/// </summary>
	[JsonProperty("labels", Required = Required.AllowNull)]
	public IDictionary<string, string>? Labels { get; set; }

	/// <summary>
	/// Name of the Resource. Must be unique per Project.
	/// </summary>
	[JsonProperty("name")]
	public string Name { get; set; }

	/// <summary>
	/// Protection configuration for the Resource
	/// </summary>
	[JsonProperty("protection")]
	public FloatingIPProtection Protection { get; set; }

	/// <summary>
	/// ID of the Server the Floating IP is assigned to, null if it is not assigned at all
	/// </summary>
	[JsonProperty("server", Required=Required.AllowNull)]
	public long? Server { get; set; }

	/// <summary>
	/// Type of the Floating IP
	/// </summary>
	[JsonProperty("type")]
	public FloatingIPType Type { get; set; }
}

