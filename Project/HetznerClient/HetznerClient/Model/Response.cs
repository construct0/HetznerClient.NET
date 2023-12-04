using HetznerClient.Model.Cloud;

namespace HetznerClient.Model;

/// <summary>
/// There may come a time when there's need for a toplevel (Hetzner encompassing) Response object, this contains toplevel domain error objects. Can be expanded to include an error object for, e.g. the DNS API. This class should not be attributed by a <see cref="Attributes.HetznerDomainResponseAttribute"/> attribute.
/// </summary>
public abstract class Response {
	public CloudError? Error { get; set; }
}
