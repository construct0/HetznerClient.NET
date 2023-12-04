using Newtonsoft.Json;

namespace HetznerClient.Model.Cloud.PlacementGroups;

/// <summary>
/// <para>Placement groups are used to influence the location of interdependent virtual servers in Hetzner's data centers. The distribution of the different instances within a group is based on a pattern specified in the type. By enforcing certain rules on the placement of instances within our infrastructure, availability can be influenced in a way that fits your needs best.</para>
/// <para>In spread placement groups, all virtual servers will run on different physical servers.This decreases the probability that some instances might fail together.</para>
/// </summary>
public class PlacementGroup {
	/// <summary>
	/// Point in time when the Resource was created (in ISO-8601 format)
	/// </summary>
	[JsonProperty("created")]
	public DateTime Created { get; set; }

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
	/// Array of IDs of Servers that are part of this Placement Group
	/// </summary>
	[JsonProperty("servers")]
	public IEnumerable<long> Servers { get; set; }

	/// <summary>
	/// Type of the Placement Group
	/// </summary>
	[JsonProperty("type")]
	public PlacementGroupType Type { get; set; }
}

