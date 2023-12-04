using Newtonsoft.Json;

namespace HetznerClient.Model.Cloud.Certificates;

public class CertificateStatus {
	/// <summary>
	/// Error message for [the operation], if error occurred, otherwise null
	/// </summary>
	[JsonProperty("error")]
	public CloudError? Error { get; set; }

	/// <summary>
	/// Status of the issuance process of the <see cref="Certificate"/>
	/// </summary>
	[JsonProperty("issuance")]
	public CertificateStatusIssuanceStatus Issuance { get; set; }

	/// <summary>
	/// Status of the renewal process of the <see cref="Certificate"/>
	/// </summary>
	[JsonProperty("renewal")]
	public CertificateStatusRenewalStatus RenewalStatus { get; set; }
}
