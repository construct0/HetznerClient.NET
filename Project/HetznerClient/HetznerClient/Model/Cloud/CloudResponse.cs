using HetznerClient.Model.Attributes;
using HetznerClient.Model.Cloud.Certificates;
using HetznerClient.Model.Cloud.Datacenters;
using HetznerClient.Model.Cloud.Firewalls;
using HetznerClient.Model.Cloud.FloatingIPs;
using HetznerClient.Model.Cloud.Images;
using HetznerClient.Model.Cloud.ISOs;
using HetznerClient.Model.Cloud.LoadBalancers;
using HetznerClient.Model.Cloud.Locations;
using HetznerClient.Model.Cloud.Networks;
using HetznerClient.Model.Cloud.PlacementGroups;
using HetznerClient.Model.Cloud.PrimaryIPs;
using HetznerClient.Model.Cloud.Servers;
using HetznerClient.Model.Cloud.SSHKeys;
using HetznerClient.Model.Cloud.Volumes;
using System.Text.Json.Serialization;

namespace HetznerClient.Model.Cloud;

#nullable enable
/// <summary>
/// An all-encompassing Cloud Response class which is instantiated and returned by <see cref="CloudClient"/> HTTP performances. Null values will not be included when (de)serialising as per the configuration @ <see cref="Logic.Converters.Json.Settings"/>. Error objects are by convention stored in the Hetzner encompassing <see cref="Response"/> class. Ideally this is not how it is done but per a request's response, it is however a great bridging technique until the functionalities have been developed, after which the response types can be narrowed down.
/// </summary>
[HetznerDomainResponse(nameof(CloudResponse))]
public partial class CloudResponse : Response {
	public Dictionary<string, string>? Labels { get; set; }
	public IEnumerable<CloudAction>? Actions { get; set; }
	public CloudAction? Action { get; set; }
	public CloudMeta? Meta { get; set; }
	[JsonPropertyName("next_actions")] public IEnumerable<CloudAction>? NextActions { get; set; }

	public IEnumerable<Server>? Servers { get; set; }
	public Server? Server { get; set; }

	public IEnumerable<Certificate>? Certificates { get; set; }
	public Certificate? Certificate { get; set; }

	public IEnumerable<Datacenter>? Datacenters { get; set; }
	public Datacenter? Datacenter { get; set; }

	public int? Recommendation { get; set; }

	public IEnumerable<Firewall>? Firewalls { get; set; }
	public Firewall? Firewall { get; set; }

	[JsonPropertyName("floating_ips")] public IEnumerable<FloatingIP>? FloatingIps { get; set; }

	[JsonPropertyName("floating_ip")] public FloatingIP? FloatingIp { get; set; }

	public IEnumerable<Image?> Images { get; set; }
	public Image? Image { get; set; }

	public IEnumerable<ISO>? Isos { get; set; }
	public ISO? Iso { get; set; }

	[JsonPropertyName("load_balancers")] public IEnumerable<LoadBalancer>? LoadBalancers { get; set; }
	[JsonPropertyName("load_balancer")] public LoadBalancer? LoadBalancer { get; set; }

	public Metrics? Metrics { get; set; }

	[JsonPropertyName("load_balancer_types")] public IEnumerable<LoadBalancerType>? LoadBalancerTypes { get; set; }
	[JsonPropertyName("load_balancer_type")] public LoadBalancerType? LoadBalancerType { get; set; }

	public IEnumerable<Location>? Locations { get; set; }
	public Location? Location { get; set; }

	public IEnumerable<Network>? Networks { get; set; }
	public Network? Network { get; set; }

	[JsonPropertyName("placement_groups")] public IEnumerable<PlacementGroup>? PlacementGroups { get; set; }
	[JsonPropertyName("placement_group")] public PlacementGroup? PlacementGroup { get; set; }

	public Pricing.Pricing? Pricing { get; set; }

	[JsonPropertyName("primary_ips")] public IEnumerable<PrimaryIP>? PrimaryIps { get; set; }
	[JsonPropertyName("primary_ip")] public PrimaryIP? PrimaryIp { get; set; }

	[JsonPropertyName("root_password")] public string? RootPassword { get; set; }
	public string? Password { get; set; }

	[JsonPropertyName("wss_url")] public string? WSSUrl { get; set; }
	[JsonPropertyName("server_type")] public string? ServerType { get; set; }

	[JsonPropertyName("ssh_keys")] public IEnumerable<SSHKey>? SSHKeys { get; set; }
	[JsonPropertyName("ssh_key")] public SSHKey? SSHKey { get; set; }

	public IEnumerable<Volume>? Volumes { get; set; }
	public Volume? Volume { get; set; }

	
}
