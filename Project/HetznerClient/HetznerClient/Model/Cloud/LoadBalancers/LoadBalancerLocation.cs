using Newtonsoft.Json;

namespace HetznerClient.Model.Cloud.LoadBalancers;

/// <summary>
/// Location the load balancer resides in.
/// todo assert if Location classes can be merged at modelling end
/// </summary>
public class LoadBalancerLocation {
	/// <summary>
	/// City the Location is closest to
	/// </summary>
	[JsonProperty("city")]
	public string City { get; set; }

	/// <summary>
	/// ISO 3166-1 alpha-2 code of the country the Location resides in
	/// </summary>
	[JsonProperty("country")]
	public string Country { get; set; }

	/// <summary>
	/// Description of the Location
	/// </summary>
	[JsonProperty("description")]
	public string Description { get; set; }

	/// <summary>
	/// ID of the Location
	/// </summary>
	[JsonProperty("id")]
	public long Id { get; set; }

	/// <summary>
	/// Latitude of the city closest to the Location
	/// </summary>
	[JsonProperty("latitude")]
	public double Latitude { get; set; }

	/// <summary>
	/// Longitude of the city closest to the Location
	/// </summary>
	[JsonProperty("longitude")]
	public double Longitude { get; set; }

	/// <summary>
	/// Unique identifier of the Location
	/// </summary>
	[JsonProperty("name")]
	public string Name { get; set; }

	/// <summary>
	/// Name of network zone this Location resides in
	/// </summary>
	[JsonProperty("network_zone")]
	public string NetworkZone { get; set; }
}


