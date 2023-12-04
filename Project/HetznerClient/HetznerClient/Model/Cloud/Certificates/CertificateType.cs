using HetznerClient.Model.Attributes;

namespace HetznerClient.Model.Cloud.Certificates;

public enum CertificateType {
	[EnumValue("uploaded")]
	Uploaded = 0,

	[EnumValue("managed")]
	Managed = 1
}