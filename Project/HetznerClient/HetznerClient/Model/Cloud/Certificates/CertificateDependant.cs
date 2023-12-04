using Newtonsoft.Json;

namespace HetznerClient.Model.Cloud.Certificates;

public class CertificateDependant {
	[JsonProperty("id")]
	public long Id { get; set; }

	[JsonProperty("type")]
	public string Type { get; set; }
}
