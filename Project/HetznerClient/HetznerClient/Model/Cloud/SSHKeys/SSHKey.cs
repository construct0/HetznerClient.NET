using Newtonsoft.Json;

namespace HetznerClient.Model.Cloud.SSHKeys;

/// <summary>
/// SSH keys are public keys you provide to the cloud system. They can be injected into Servers at creation time. We highly recommend that you use keys instead of passwords to manage your Servers.
/// </summary>
public class SSHKey {
	/// <summary>
	/// Point in time when the Resource was created (in ISO-8601 format)
	/// </summary>
	[JsonProperty("created")]
	public DateTime Created { get; set; }

	/// <summary>
	/// Fingerprint of public key
	/// </summary>
	[JsonProperty("fingerprint")]
	public string Fingerprint { get; set; }

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
	/// Name of the Resource. Must be unique per Project.
	/// </summary>
	[JsonProperty("name")]
	public string Name { get; set; }

	/// <summary>
	/// Public key
	/// </summary>
	[JsonProperty("public_key")]
	public string PublicKey { get; set; }
}
