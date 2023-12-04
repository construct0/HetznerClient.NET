using Newtonsoft.Json;

namespace HetznerClient.Model.Cloud.Networks;

public class NetworkSubnet {
	/// <summary>
	/// Gateway for Servers attached to this subnet. For subnets of type Server this is always the first IP of the network IP range.
	/// </summary>
	[JsonProperty("gateway")]
	public string Gateway { get; set; }

	/// <summary>
	/// Range to allocate IPs from. Must be a Subnet of the ip_range of the parent network object and must not overlap with any other subnets or with any destinations in routes. Minimum Network size is /30. We suggest that you pick a bigger Network with a /24 netmask.
	/// </summary>
	[JsonProperty("ip_range")]
	public string IpRange { get; set; }

	/// <summary>
	/// Name of the Network zone. The Location object contains the network_zone property each Location belongs to.
	/// </summary>
	[JsonProperty("network_zone")]
	public string NetworkZone { get; set; }

	/// <summary>
	/// Type of Subnetwork
	/// </summary>
	[JsonProperty("type")]
	public string Type { get; set; }

	/// <summary>
	/// ID of the robot vSwitch if the subnet is of type vswitch.
	/// </summary>
	[JsonProperty("vswitch_id", Required=Required.AllowNull)]
	public long? VswitchId { get; set; }
}

