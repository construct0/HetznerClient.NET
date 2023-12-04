using HetznerClient.Model;

namespace HetznerClient;

public class CloudConfig : AbstractConfig {
	public CloudConfig(string bearerToken, string baseAddress = "https://api.hetzner.cloud/v1/") : base(bearerToken, baseAddress) {
	}
}
