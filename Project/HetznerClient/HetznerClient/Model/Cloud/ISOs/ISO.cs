using Newtonsoft.Json;

namespace HetznerClient.Model.Cloud.ISOs;

/// <summary>
/// <para>ISOs are read-only Images of DVDs. While Hetzner recommends using their Image functionality to install your Servers they also provide some stock ISOs so you can install more exotic operating systems by yourself.</para>
/// <para>On request Hetzner's support uploads a private ISO just for you. These are marked with type private and only visible in your Project.</para>
/// <para>To attach an ISO to your Server use POST /servers/{id}/actions/attach_iso</para>
/// </summary>
public class ISO {
	/// <summary>
	/// Type of cpu architecture this iso is compatible with. Null indicates no restriction on the architecture (wildcard).
	/// </summary>
	[JsonProperty("architecture", Required=Required.AllowNull)]
	public ISOArchitecture? Architecture { get; set; }

	/// <summary>
	/// ISO 8601 timestamp of deprecation, null if ISO is still available. After the deprecation time it will no longer be possible to attach the ISO to Servers.
	/// </summary>
	[JsonProperty("deprecated", Required=Required.AllowNull)]
	public DateTime? Deprecated { get; set; }

	/// <summary>
	/// Describes if, when & how the resources was deprecated. If this field is set to null the resource is not deprecated. If it has a value, it is considered deprecated.
	/// </summary>
	[JsonProperty("deprecation", Required = Required.AllowNull)]
	public ISODeprecation? Deprecation { get; set; }

	/// <summary>
	/// Description of the ISO
	/// </summary>
	[JsonProperty("description")]
	public string Description { get; set; }

	/// <summary>
	/// ID of the Resource
	/// </summary>
	[JsonProperty("id")]
	public long Id { get; set; }

	/// <summary>
	/// Unique identifier of the ISO. Only set for public ISOs
	/// </summary>
	[JsonProperty("name", Required = Required.AllowNull)]
	public string? Name { get; set; }

	/// <summary>
	/// Type of the ISO
	/// </summary>
	[JsonProperty("type", Required = Required.AllowNull)]
	public ISOType? Type { get; set; }
}
