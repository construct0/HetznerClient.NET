using Newtonsoft.Json;

namespace HetznerClient.Model.Cloud.Images;

/// <summary>
/// Images are blueprints for your VM disks. They can be of different types.
/// </summary>
public class Image {
	/// <summary>
	/// Type of cpu architecture this image is compatible with.
	/// </summary>
	[JsonProperty("architecture")]
	public ImageArchitecture Architecture { get; set; }

	/// <summary>
	/// ID of Server the Image is bound to. Only set for Images of type <see cref="ImageType.Backup"/>
	/// </summary>
	[JsonProperty("bound_to", Required = Required.AllowNull)]
	public long? BoundTo { get; set; }

	/// <summary>
	/// Point in time when the Resource was created (in ISO-8601 format)
	/// </summary>
	[JsonProperty("created")]
	public DateTime Created { get; set; }

	/// <summary>
	/// Information about the Server the Image was created from
	/// </summary>
	[JsonProperty("created_from", Required = Required.AllowNull)]
	public ImageCreatedFrom? CreatedFrom { get; set; }

	/// <summary>
	/// Point in time where the Image was deleted (in ISO-8601 format)
	/// </summary>
	[JsonProperty("deleted", Required = Required.AllowNull)]
	public string? Deleted { get; set; }

	/// <summary>
	/// Point in time when the Image is considered to be deprecated (in ISO-8601 format)
	/// </summary>
	[JsonProperty("deprecated", Required=Required.AllowNull)]
	public DateTime? Deprecated { get; set; }

	/// <summary>
	/// Description of the Image
	/// </summary>
	[JsonProperty("description")]
	public string Description { get; set; }

	/// <summary>
	/// Size of the disk contained in the Image in GB
	/// </summary>
	[JsonProperty("disk_size")]
	public long DiskSize { get; set; }

	/// <summary>
	/// ID of the Resource
	/// </summary>
	[JsonProperty("id")]
	public long Id { get; set; }

	/// <summary>
	/// Size of the Image file in our storage in GB. For snapshot Images this is the value relevant for calculating costs for the Image.
	/// </summary>
	[JsonProperty("image_size", Required=Required.AllowNull)]
	public double? ImageSize { get; set; }

	/// <summary>
	/// User-defined labels (key-value pairs)
	/// </summary>
	[JsonProperty("labels")]
	public IDictionary<string, string> Labels { get; set; }

	/// <summary>
	/// Unique identifier of the Image. This value is only set for system Images.
	/// </summary>
	[JsonProperty("name", Required = Required.AllowNull)]
	public string? Name { get; set; }

	/// <summary>
	/// Flavor of operating system contained in the Image
	/// </summary>
	[JsonProperty("os_flavor")]
	public ImageOsFlavor OSFlavor { get; set; }

	/// <summary>
	/// Operating system version
	/// </summary>
	[JsonProperty("os_version", Required = Required.AllowNull)]
	public string? OSVersion { get; set; }

	/// <summary>
	/// Protection configuration for the Resource
	/// </summary>
	[JsonProperty("protection")]
	public ImageProtection Protection { get; set; }

	/// <summary>
	/// Indicates that rapid deploy of the Image is available
	/// </summary>
	[JsonProperty("rapid_deploy")]
	public bool RapidDeploy { get; set; }

	/// <summary>
	/// Whether the Image can be used or if it's still being created or unavailable
	/// </summary>
	[JsonProperty("status")]
	public ImageStatus Status { get; set; }

	/// <summary>
	/// Type of the Image
	/// </summary>
	[JsonProperty("type")]
	public ImageType Type { get; set; }
}



