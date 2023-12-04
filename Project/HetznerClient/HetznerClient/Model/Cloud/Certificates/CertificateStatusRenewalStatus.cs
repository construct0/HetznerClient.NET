using HetznerClient.Model.Attributes;

namespace HetznerClient.Model.Cloud.Certificates;

/// <summary>
/// Status of the renewal process of the <see cref="Certificate"/>
/// </summary>
public enum CertificateStatusRenewalStatus {
	[EnumValue("scheduled")]
	Scheduled = 0,

	[EnumValue("pending")]
	Pending = 1,

	[EnumValue("failed")]
	Failed = 2,

	[EnumValue("unavailable")]
	Unavailable = 3
}