using Newtonsoft.Json;

namespace HetznerClient.Model.Cloud.Images;

public class ImageCreatedFrom {
	/// <summary>
	/// ID of the Server the Image was created from
	/// </summary>
	[JsonProperty("id")]
	public long Id { get; set; }

	/// <summary>
	/// Server name at the time the Image was created
	/// </summary>
	[JsonProperty("name")]
	public string Name { get; set; }
}

