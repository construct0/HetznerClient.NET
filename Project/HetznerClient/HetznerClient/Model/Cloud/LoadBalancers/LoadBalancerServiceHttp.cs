using Newtonsoft.Json;

namespace HetznerClient.Model.Cloud.LoadBalancers;

public class LoadBalancerServiceHttp {
	/// <summary>
	/// IDs of the Certificates to use for TLS/SSL termination by the Load Balancer; empty for TLS/SSL passthrough or if protocol is "http"
	/// </summary>
	[JsonProperty("certificates")]
	public IEnumerable<long> Certificates { get; set; }

	/// <summary>
	/// Lifetime of the cookie used for sticky sessions (in seconds)
	/// </summary>
	[JsonProperty("cookie_lifetime")]
	public long CookieLifetime { get; set; }

	/// <summary>
	/// Name of the cookie used for sticky sessions
	/// </summary>
	[JsonProperty("cookie_name")]
	public string CookieName { get; set; }

	/// <summary>
	/// Redirect HTTP requests to HTTPS. Only available if protocol is "https". Default = false
	/// </summary>
	[JsonProperty("redirect_http")]
	public bool RedirectHttp { get; set; }

	/// <summary>
	/// Use sticky sessions. Only available if protocol is "http" or "https". Default = false
	/// </summary>
	[JsonProperty("sticky_sessions")]
	public bool StickySessions { get; set; }
}


