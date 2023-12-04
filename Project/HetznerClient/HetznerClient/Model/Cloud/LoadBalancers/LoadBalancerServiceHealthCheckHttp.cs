using Newtonsoft.Json;

namespace HetznerClient.Model.Cloud.LoadBalancers;

public class LoadBalancerServiceHealthCheckHttp {
	/// <summary>
	/// Host header to send in the HTTP request. May not contain spaces, percent or backslash symbols. Can be null, in that case no host header is sent.
	/// </summary>
	[JsonProperty("domain", Required = Required.AllowNull)]
	public string? Domain { get; set; }

	/// <summary>
	/// HTTP path to use for health checks. May not contain literal spaces, use percent-encoding instead.
	/// </summary>
	[JsonProperty("path")]
	public string Path { get; set; }

	/// <summary>
	/// String that must be contained in HTTP response in order to pass the health check
	/// </summary>
	[JsonProperty("response")]
	public string Response { get; set; }

	/// <summary>
	/// List of returned HTTP status codes in order to pass the health check. Supports the wildcards ? for exactly one character and * for multiple ones. The default is to pass the health check for any status code between 2?? and 3??.
	/// </summary>
	[JsonProperty("status_codes")]
	public IEnumerable<string> StatusCodes { get; set; }

	/// <summary>
	/// Use HTTPS for health check
	/// </summary>
	[JsonProperty("tls")]
	public bool Tls { get; set; }
}


