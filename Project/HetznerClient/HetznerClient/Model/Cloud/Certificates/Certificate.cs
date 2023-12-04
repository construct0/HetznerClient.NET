using Newtonsoft.Json;

namespace HetznerClient.Model.Cloud.Certificates;

/// <summary>
/// TLS/SSL Certificates prove the identity of a Server and are used to encrypt client traffic.
/// </summary>
public class Certificate {
	/// <summary>
	/// Certificate and chain in PEM format, in order so that each record directly certifies the one preceding
	/// </summary>
	[JsonProperty("certificate", Required=Required.AllowNull)]
	public string? Content { get; set; }

	/// <summary>
	/// Point in time when the Resource was created (in ISO-8601 format)
	/// </summary>
	[JsonProperty("created")]
	public DateTime Created { get; set; }

	/// <summary>
	/// Domains and subdomains covered by the Certificate
	/// </summary>
	[JsonProperty("domain_names")]
	public IEnumerable<string> DomainNames { get; set; }

	/// <summary>
	/// SHA256 fingerprint of the Certificate
	/// </summary>
	[JsonProperty("fingerprint")]
	public string Fingerprint { get; set; }

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
	/// Point in time when the Certificate stops being valid (in ISO-8601 format)
	/// </summary>
	[JsonProperty("not_valid_after", Required = Required.AllowNull)]
	public DateTime? NotValidAfter { get; set; }

	/// <summary>
	/// Point in time when the Certificate becomes valid (in ISO-8601 format)
	/// </summary>
	[JsonProperty("not_valid_before", Required = Required.AllowNull)]
	public DateTime? NotValidBefore { get; set; }

	/// <summary>
	/// Current status of a type [managed] Certificate, always [null] for type uploaded Certificates
	/// </summary>
	[JsonProperty("status")]
	public CertificateStatus? Status { get; set; }

	/// <summary>
	/// Type of the certificate
	/// </summary>
	[JsonProperty("type")]
	public CertificateType Type { get; set; }

	/// <summary>
	/// Resources currently using the Certificate
	/// </summary>
	[JsonProperty("used_by")]
	public List<CertificateDependant> Dependants { get; set; }
}
