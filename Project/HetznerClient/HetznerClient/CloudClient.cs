using HetznerClient.Logic.Controllers;
using HetznerClient.Model;

namespace HetznerClient;

/// <summary>
/// <para>All requests, whether they are authenticated or not, are subject to rate limiting. If you have reached your limit, your requests will be handled with a 429 Too Many Requests error. Burst requests are allowed. Responses contain serveral headers which provide information about your current rate limit status.</para>
/// <para>The RateLimit-Limit header contains the total number of requests you can perform per hour.</para>
/// <para>The RateLimit-Remaining header contains the number of requests remaining in the current rate limit time frame.</para>
/// <para>The RateLimit-Reset header contains a UNIX timestamp of the point in time when your rate limit will have recovered and you will have the full number of requests available again.</para>
/// <para>The default limit is 3600 requests per hour and per Project. The number of remaining requests increases gradually.For example, when your limit is 3600 requests per hour, the number of remaining requests will increase by 1 every second.</para>
/// </summary>
public class CloudClient : AbstractClient {
	private CloudConfig CloudConfig { get; init; }

	public CloudClient(CloudConfig cloudConfig) : this(cloudConfig, new HttpClient()) { }

	public CloudClient(CloudConfig cloudConfig, IHttpClientFactory httpClientFactory) : this(cloudConfig, httpClientFactory.CreateClient()) { }

	public CloudClient(CloudConfig cloudConfig, HttpClient httpClient) : base(cloudConfig, httpClient) {
		CloudConfig = cloudConfig ?? throw new ArgumentNullException($"A valid {nameof(CloudConfig)} instance must be provided");
		_ = httpClient ?? throw new ArgumentNullException($"A valid {nameof(HttpClient)} instance must be provided");


		Certificate = new CertificateController(this);
		Datacenter = new DatacenterController(this);
		Firewall = new FirewallController(this);
		FloatingIp = new FloatingIpController(this);
		Image = new ImageController(this);
		ISO = new ISOController(this);
		LoadBalancer = new LoadBalancerController(this);
		LoadBalancerType = new LoadBalancerTypeController(this);
		Location = new LocationController(this);
		Network = new NetworkController(this);
		PlacementGroup = new PlacementGroupController(this);
		Pricing = new PricingController(this);
		PrimaryIp = new PrimaryIpController(this);
		Server = new ServerController(this);
		ServerType = new ServerTypeController(this);
		SSHKey = new SSHKeyController(this);
		Volume = new VolumeController(this);
	}

	public CertificateController Certificate { get; init; }
	public DatacenterController Datacenter { get; init; }
	public FirewallController Firewall { get; init; }
	public FloatingIpController FloatingIp { get; init; }
	public ImageController Image { get; init; }
	public ISOController ISO { get; init; }
	public LoadBalancerController LoadBalancer { get; init; }
	public LoadBalancerTypeController LoadBalancerType { get; init; }
	public LocationController Location { get; init; }
	public NetworkController Network { get; init; }
	public PlacementGroupController PlacementGroup { get; init; }
	public PricingController Pricing { get; init; }
	public PrimaryIpController PrimaryIp { get; init; }
	public ServerController Server { get; init; }
	public ServerTypeController ServerType { get; init; }
	public SSHKeyController SSHKey { get; init; }
	public VolumeController Volume { get; init; }
}



//internal class GetSpecificationQueryParameter {
//	public string Key { get; set; }
//	public string? Value { get; set; }
//}

//internal class GetSpecification {
//	public string Path { get; set; }
//	public Dictionary<string, string>? PathParameters { get; set; }
//	public List<GetSpecificationQueryParameter>? QueryParameters { get; set; }
//}



/*



*//*

Certificates
- GetAll
- Get
- Create
- Update
- Delete
- GetActions (cert id argument)
- GetAction - cert id + action id argument
- RetryIssuanceOrRenewal - action - cert id

*//*

- GetAllDatacenters
- GetDatacenter - id argument

*//*

Firewalls
- GetAll
- Get
- Create
- Update
- Delete
- GetActions (firewall id argument)
- GetAction - firewall id argument + action id argument
- ApplyToResource(s) = action
- RemoveFromResource(s) = action
- SetRules = action

*//*

FloatingIps
- GetAll
- Get
- Create
- Update
- Delete
- GetActions (floatingip id argument)
- GetAction - floatingip id argument + action id argument
- AssignToServer = action
- ChangeReverseDNS = action
- ChangeProtection = action
- Unassign(FromResource) = action

*//*

Images *no create*
- GetAll
- Get
- Update
- Delete
- GetActions (image id argument)
- GetAction - image id argument + action id argument
- ChangeProtection = action

*//*

ISOs
- GetAll
- Get 

*//*

LoadBalancer
- GetAll
- Get
- GetMetrics
- Create
- Update
- Delete
- GetActions (loadbalancer id argument)
- GetAction (loadbalancer id argument + action argument)
- AddTarget = action
- AttachToNetwork = action
- ChangeAlgorithm = action
- ChangeReverseDNSEntry = action
- ChangeProtection = action
- ChangeType = action
- DeleteService = action
- DetachFromNetwork = action
- DisablePublicInterface = action
- EnablePublicInterface = action
- RemoveTarget = action
- UpdateService = action

*//*

LoadBalancerTypes
- GetAll
- Get

*//*

Locations
- GetAll
- Get

*//*

Networks
- GetAll
- Get
- Create
- Update
- Delete
- GetActions (network id argument)
- GetAction (network id argument + action id argument)
- AddRoute = action
- AddSubnet = action
- ChangeIPRange = action
- ChangeProtection = action
- DeleteRoute = action
- DeleteSubnet = action

*//*

PlacementGroups
- GetAll
- Get
- Create
- Update
- Delete

*//*

Pricing
- GetAll

*//*

PrimaryIPs
- GetAll
- Get
- Create
- Update
- Delete
- AssignToResource/Server  = action
- ChangeReverseDNS = action
- ChangeProtection = action
- Unassign(FromResource) = action
- GetActions (no argument)
- GetAction (primaryip argument)

*//*

Servers
- GetAll
- Get
- Create
- Update
- Delete
- GetMetrics
- GetActions (server id argument)
- GetAction (server id argument + action id argument)
- AddToPlacementGroup = action
- AttachISO = action
- AttachToNetwork = action
- ChangeAliasIPs = action
- ChangeReverseDNS = action
- ChangeProtection = action
- ChangeType = action
- CreateImage = action
- DetachFromNetwork = action
- DetachISO = action
- DisableBackups = action
- DisableRescueMode = action
- EnableBackups = action
- EnableRescueMode = action
- PowerOff = action
- PowerOn = action
- PerformSoftReboot = action
- RebuildFromImage = action
- RemoveFromPlacementGroup = action
- RequestConsole = action
- PerformHardReboot = action
- ResetRootPassword = action
- PerformShutdown = action

*//*

ServerTypes
- GetAll
- Get

*//*

SSHKeys
- GetAll
- Get
- Create
- Update
- Delete

*//*

Volumes
- GetAll
- Get
- Create
- Update
- Delete
- GetActions
- GetAction
- AttachToResource/Server
- ChangeProtection
- DetachFromResource/Server



	Actions (general + domain constrained)
- GetAllActions
- GetAction
- GetCertificateActions (cert id argument)
- GetCertificateAction - cert id + action id argument
- GetFirewallActions (firewall id argument)
- GetFirewallAction - firewall id argument + action id argument
- GetFloatingIpActions (floatingip id argument)
- GetFloatingIpAction - floatingip id argument + action id argument
- GetImageActions (image id argument)
- GetImageAction - image id argument + action id argument
- GetLoadBalancerActions (loadbalancer id argument)
- GetLoadBalancerAction (loadbalancer id argument + action argument)
- GetNetworkActions (network id argument)
- GetNetworkAction (network id argument + action id argument)
- GetPrimaryIpActions (no argument)
- GetPrimaryIpAction (primaryip argument)
- GetServerActions (server id argument)
- GetServerAction (server id argument + action id argument)
- GetVolumeActions
- GetVolumeAction



*/

