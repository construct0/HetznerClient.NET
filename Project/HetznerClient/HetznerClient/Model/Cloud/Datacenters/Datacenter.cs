using Newtonsoft.Json;

namespace HetznerClient.Model.Cloud.Datacenters;

/// <summary>
/// Each Datacenter represents a virtual Datacenter which is made up of possible many physical Datacenters where Servers are hosted.
/// Datacenter names are composed from their Location and virtual Datacenter number, for example fsn1-dc14 means virtual Datacenter 14 in Location fsn1.
/// Right now there is only one Datacenter for each Location. The Datacenter numbers for fsn, nbg and hel are arbitrarily set to 14, 3 and 2 for historic reasons and do not represent real physical Hetzner datacenters.
/// </summary>
public class Datacenter {
	/// <summary>
	/// Description of the Datacenter
	/// </summary>
	[JsonProperty("description")]
	public string Description { get; set; }

	/// <summary>
	/// ID of the Resource
	/// </summary>
	[JsonProperty("id")]
	public long Id { get; set; }

	/// <summary>
	/// Location of the Datacenter
	/// </summary>
	[JsonProperty("location")]
	public DatacenterLocation Location { get; set; }

	/// <summary>
	/// Unique identifier of the Datacenter
	/// </summary>
	[JsonProperty("name")]
	public string Name { get; set; }

	/// <summary>
	/// The Server types the Datacenter can handle
	/// </summary>
	[JsonProperty("server_types")]
	public DatacenterServerTypes ServerTypes { get; set; }
}

