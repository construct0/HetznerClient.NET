using HetznerClient.Model.Attributes;

namespace HetznerClient.Model.Cloud.Certificates;

/// <summary>
/// Status of the issuance process of the <see cref="Certificate"/>
/// </summary>
public enum CertificateStatusIssuanceStatus {
	[EnumValue("pending")]
	Pending = 0,

	[EnumValue("completed")]
	Completed = 1,

	[EnumValue("failed")]
	Failed = 2
}