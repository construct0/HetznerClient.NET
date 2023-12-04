using Newtonsoft.Json;
using System.Data;
using System.Reflection.Emit;

namespace HetznerClient.Model.Cloud.Firewalls;

public class Firewall {
	/// <summary>
	/// Firewall applications
	/// </summary>
	[JsonProperty("applied_to")]
	public List<FirewallApplication> Applications { get; set; }

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
	[JsonProperty("labels", Required = Required.AllowNull)]
	public IDictionary<string, string>? Labels { get; set; }

	/// <summary>
	/// Name of the Resource. Must be unique per Project.
	/// </summary>
	[JsonProperty("name")]
	public string Name { get; set; }

	/// <summary>
	/// Existing firewall rules
	/// </summary>
	[JsonProperty("rules")]
	public IEnumerable<FirewallRule> Rules { get; set; }
}



