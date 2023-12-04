using Newtonsoft.Json;

namespace HetznerClient.Model.Cloud.Networks;


/// <summary>
/// <para>Networks is a private networks feature. These Networks are optional and they coexist with the public network that every Server has by default.</para>
/// <para>They allow Servers to talk to each other over a dedicated network interface using private IP addresses not available publicly.</para>
/// <para>The IP addresses are allocated and managed via the API, they must conform to RFC1918 standard. IPs and network interfaces defined under Networks do not provide public internet connectivity, you will need to use the already existing public network interface for that.</para>
/// <para>Each network has a user selected ip_range which defines all available IP addresses which can be used for Subnets within the Network.</para>
/// <para>To assign individual IPs to Servers you will need to create Network Subnets. Currently Networks support IPv4 only.</para>
/// </summary>
public class Network {
	/// <summary>
	/// Point in time when the Network was created (in ISO-8601 format)
	/// </summary>
	[JsonProperty("created")]
	public DateTime Created { get; set; }

	/// <summary>
	/// Indicates if the routes from this network should be exposed to the vSwitch connection.
	/// </summary>
	[JsonProperty("expose_routes_to_vswitch")]
	public bool ExposeRoutesToVswitch { get; set; }

	/// <summary>
	/// ID of the Network
	/// </summary>
	[JsonProperty("id")]
	public long Id { get; set; }

	/// <summary>
	/// IPv4 prefix of the whole Network
	/// </summary>
	[JsonProperty("ip_range")]
	public string IpRange { get; set; }

	/// <summary>
	/// User-defined labels (key-value pairs)
	/// </summary>
	[JsonProperty("labels")]
	public IDictionary<string, string> Labels { get; set; }

	/// <summary>
	/// Array of IDs of Load Balancers attached to this Network
	/// </summary>
	[JsonProperty("load_balancers", Required = Required.AllowNull)]
	public IEnumerable<long>? LoadBalancers { get; set; }

	/// <summary>
	/// Name of the Network
	/// </summary>
	[JsonProperty("name")]
	public string Name { get; set; }

	/// <summary>
	/// Protection configuration for the Network
	/// </summary>
	[JsonProperty("protection")]
	public NetworkProtection Protection { get; set; }

	/// <summary>
	/// Array of routes set in this Network
	/// </summary>
	[JsonProperty("routes")]
	public IEnumerable<NetworkRoute> Routes { get; set; }

	/// <summary>
	/// Array of IDs of Servers attached to this Network
	/// </summary>
	[JsonProperty("servers")]
	public IEnumerable<long> Servers { get; set; }

	/// <summary>
	/// Array of subnets allocated in this Network
	/// </summary>
	[JsonProperty("subnets")]
	public IEnumerable<NetworkSubnet> Subnets { get; set; }
}

