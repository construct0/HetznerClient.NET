using System.Net;
using System.Runtime;

namespace HetznerClient.Model;

// todo look into ways to completely hydrate this object at once, e.g. the priv net yaml is not included when GETing /metadata
// todo check if any person can perform this action or only the server itself locally, if only locally then this can be removed
/// <summary>
/// Your server can discover metadata about itself by doing a HTTP request to specific URLs.
/// </summary>
public class HetznerServerMetadata {
	public string HostName { get; init; }
	public int InstanceId { get; init; }
	public string PublicIpv4 { get; init; }
	public string PrivateNetworksYaml { get; init; }
	public string AvailabilityZone { get; init; }
	public string Region { get; init; }

	public HetznerServerMetadata(string hostName, int instanceId, string publicIpv4, string privateNetworksYaml, string availabilityZone, string region) {
		HostName = hostName;
		InstanceId = instanceId;
		PublicIpv4 = publicIpv4;
		PrivateNetworksYaml = privateNetworksYaml;
		AvailabilityZone = availabilityZone;
		Region = region;
	}
}
