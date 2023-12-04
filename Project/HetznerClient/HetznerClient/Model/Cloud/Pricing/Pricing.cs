using Newtonsoft.Json;

namespace HetznerClient.Model.Cloud.Pricing;

public class Pricing {
	/// <summary>
	/// Currency the returned prices are expressed in, coded according to ISO 4217
	/// </summary>
	[JsonProperty("currency")]
	public string Currency { get; set; }

	/// <summary>
	/// The cost of one Floating IP per month
	/// </summary>
	[JsonProperty("floating_ip")]
	public PricingFloatingIP FloatingIp { get; set; }

	/// <summary>
	/// Costs of Floating IPs types per Location and type
	/// </summary>
	[JsonProperty("floating_ips")]
	public IEnumerable<PricingFloatingIPElement> FloatingIps { get; set; }

	/// <summary>
	/// The cost of Image per GB/month
	/// </summary>
	[JsonProperty("image")]
	public PricingImage Image { get; set; }

	/// <summary>
	/// Costs of Load Balancer types per Location and type
	/// </summary>
	[JsonProperty("load_balancer_types")]
	public IEnumerable<PricingLoadBalancerType> LoadBalancerTypes { get; set; }

	/// <summary>
	/// Costs of Primary IPs types per Location
	/// </summary>
	[JsonProperty("primary_ips")]
	public IEnumerable<PricingPrimaryIP> PrimaryIps { get; set; }

	/// <summary>
	/// Will increase base Server costs by specific percentage
	/// </summary>
	[JsonProperty("server_backup")]
	public PricingServerBackup ServerBackup { get; set; }

	/// <summary>
	/// Costs of Server types per Location and type
	/// </summary>
	[JsonProperty("server_types")]
	public IEnumerable<PricingServerType> ServerTypes { get; set; }

	/// <summary>
	/// The cost of additional traffic per TB
	/// </summary>
	[JsonProperty("traffic")]
	public PricingTraffic Traffic { get; set; }

	/// <summary>
	/// The VAT rate used for calculating prices with VAT
	/// </summary>
	[JsonProperty("vat_rate")]
	public string VatRate { get; set; }

	/// <summary>
	/// The cost of Volume per GB/month
	/// </summary>
	[JsonProperty("volume")]
	public PricingImage Volume { get; set; }
}
