using Newtonsoft.Json;

namespace HetznerClient.Model.Cloud.Datacenters;

/// <summary>
/// The Server types the Datacenter can handle
/// </summary>
public class DatacenterServerTypes {
	/// <summary>
	/// IDs of Server types that are supported and for which the Datacenter has enough resources left
	/// </summary>
	[JsonProperty("available")]
	public IEnumerable<int> Available { get; set; }

	/// <summary>
	/// IDs of Server types that are supported and for which the Datacenter has enough resources left
	/// </summary>
	[JsonProperty("available_for_migration")]
	public IEnumerable<int> AvailableForMigration { get; set; }

	/// <summary>
	/// IDs of Server types that are supported in the Datacenter
	/// </summary>
	[JsonProperty("supported")]
	public IEnumerable<int> Supported { get; set; }
}

