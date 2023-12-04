using Newtonsoft.Json;

namespace HetznerClient.Model.Cloud.LoadBalancers;

public class LoadBalancerProtection {
	/// <summary>
	/// If true, prevents the Resource from being deleted
	/// </summary>
	[JsonProperty("delete")]
	public bool Delete { get; set; } = true;
}


