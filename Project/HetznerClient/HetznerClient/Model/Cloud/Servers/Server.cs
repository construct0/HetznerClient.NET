using HetznerClient.Model.Cloud.Datacenters;
using HetznerClient.Model.Cloud.Images;
using HetznerClient.Model.Cloud.ISOs;
using HetznerClient.Model.Cloud.PlacementGroups;
using HetznerClient.Model.Cloud.ServerTypes;
using Newtonsoft.Json;

namespace HetznerClient.Model.Cloud.Servers;

public class Server {
	// todo check what the value is of this, perhaps a datetime related type suits it better
	/// <summary>
	/// Time window (UTC) in which the backup will run, or null if the backups are not enabled
	/// </summary>
	[JsonProperty("backup_window", Required=Required.AllowNull)]
	public string? BackupWindow { get; set; }

	/// <summary>
	/// Point in time when the Resource was created (in ISO-8601 format)
	/// </summary>
	[JsonProperty("created")]
	public DateTime Created { get; set; }

	/// <summary>
	/// Datacenter this Resource is located at
	/// </summary>
	[JsonProperty("datacenter")]
	public Datacenter Datacenter { get; set; }

	/// <summary>
	/// ID of the Resource
	/// </summary>
	[JsonProperty("id")]
	public long Id { get; set; }

	/// <summary>
	/// Describes the image of the Server
	/// </summary>
	[JsonProperty("image", Required=Required.AllowNull)]
	public Image? Image { get; set; }

	/// <summary>
	/// Free Traffic for the current billing period in bytes
	/// </summary>
	[JsonProperty("included_traffic", Required=Required.AllowNull)]
	public double? IncludedTraffic { get; set; }

	/// <summary>
	/// Inbound Traffic for the current billing period in bytes
	/// </summary>
	[JsonProperty("ingoing_traffic", Required=Required.AllowNull)]
	public double? IngoingTraffic { get; set; }

	/// <summary>
	/// ISO Image that is attached to this Server. Null if no ISO is attached.
	/// </summary>
	[JsonProperty("iso", Required = Required.AllowNull)]
	public ISO? Iso { get; set; }

	/// <summary>
	/// User-defined labels (key-value pairs)
	/// </summary>
	[JsonProperty("labels")]
	public IDictionary<string, string> Labels { get; set; }

	/// <summary>
	/// Load balancers associated with this Server
	/// </summary>
	[JsonProperty("load_balancers")]
	public IEnumerable<long> LoadBalancers { get; set; }

	/// <summary>
	/// True if Server has been locked and is not available to user
	/// </summary>
	[JsonProperty("locked")]
	public bool Locked { get; set; }

	/// <summary>
	/// Name of the Server (must be unique per Project and a valid hostname as per RFC 1123)
	/// </summary>
	[JsonProperty("name")]
	public string Name { get; set; }

	/// <summary>
	/// Outbound Traffic for the current billing period in bytes
	/// </summary>
	[JsonProperty("outgoing_traffic")]
	public double? OutgoingTraffic { get; set; }

	/// <summary>
	/// Placement group of the Server
	/// </summary>
	[JsonProperty("placement_group", Required = Required.AllowNull)]
	public PlacementGroup? PlacementGroup { get; set; }

	/// <summary>
	/// Size of the primary Disk
	/// </summary>
	[JsonProperty("primary_disk_size")]
	public double PrimaryDiskSize { get; set; }

	/// <summary>
	/// Private networks information
	/// </summary>
	[JsonProperty("private_net")]
	public IEnumerable<ServerPrivateNetwork> PrivateNetworks { get; set; }

	/// <summary>
	/// Protection configuration for the Server
	/// </summary>
	[JsonProperty("protection")]
	public ServerProtection Protection { get; set; }

	/// <summary>
	/// Public network information.
	/// </summary>
	[JsonProperty("public_net")]
	public ServerPublicNetwork PublicNetwork { get; set; }

	/// <summary>
	/// True if rescue mode is enabled. Server will then boot into rescue system on next reboot
	/// </summary>
	[JsonProperty("rescue_enabled")]
	public bool RescueEnabled { get; set; }

	/// <summary>
	/// Type of Server - determines how much ram, disk and cpu a Server has
	/// </summary>
	[JsonProperty("server_type")]
	public ServerType ServerType { get; set; }

	/// <summary>
	/// Status of the Server
	/// </summary>
	[JsonProperty("status")]
	public ServerStatus Status { get; set; }

	/// <summary>
	/// IDs of Volumes assigned to this Server
	/// </summary>
	[JsonProperty("volumes")]
	public IEnumerable<long> Volumes { get; set; }
}


