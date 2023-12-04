using HetznerClient.Model.Cloud.Locations;
using Newtonsoft.Json;

namespace HetznerClient.Model.Cloud.Volumes;

/// <summary>
/// <para>A Volume is a highly-available, scalable, and SSD-based block storage for Servers.</para>
/// <para>Pricing for Volumes depends on the Volume size and Location, not the actual used storage.</para>
/// <para>Please see <see href="https://docs.hetzner.cloud/">Hetzner Docs</see> for more details about Volumes.</para>
/// </summary>
public class Volume {
	/// <summary>
	/// Point in time when the Resource was created (in ISO-8601 format)
	/// </summary>
	[JsonProperty("created")]
	public DateTime Created { get; set; }

	/// <summary>
	/// Filesystem of the Volume if formatted on creation, null if not formatted on creation
	/// </summary>
	[JsonProperty("format", Required=Required.AllowNull)]
	public string? Format { get; set; }

	/// <summary>
	/// ID of the Resource
	/// </summary>
	[JsonProperty("id")]
	public long Id { get; set; }

	/// <summary>
	/// User-defined labels (key-value pairs)
	/// </summary>
	[JsonProperty("labels")]
	public IDictionary<string, string> Labels { get; set; }

	/// <summary>
	/// Device path on the file system for the Volume
	/// </summary>
	[JsonProperty("linux_device")]
	public string LinuxDevice { get; set; }

	/// <summary>
	/// Location of the Volume. Volume can only be attached to Servers in the same Location.
	/// </summary>
	[JsonProperty("location")]
	public Location Location { get; set; }

	/// <summary>
	/// Name of the Resource. Must be unique per Project.
	/// </summary>
	[JsonProperty("name")]
	public string Name { get; set; }

	/// <summary>
	/// Protection configuration for the Resource
	/// </summary>
	[JsonProperty("protection")]
	public VolumeProtection Protection { get; set; }

	/// <summary>
	/// ID of the Server the Volume is attached to, null if it is not attached at all
	/// </summary>
	[JsonProperty("server", Required=Required.AllowNull)]
	public long? Server { get; set; }

	/// <summary>
	/// Size in GB of the Volume
	/// </summary>
	[JsonProperty("size")]
	public long Size { get; set; }

	/// <summary>
	/// Current status of the Volume
	/// </summary>
	[JsonProperty("status")]
	public VolumeStatus Status { get; set; }
}
