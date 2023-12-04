using HetznerClient.Logic.Extensions;
using System.Net;

namespace HetznerClient.Model.Cloud;

/// <summary>
/// Error message for [the operation], if error occurred, otherwise null
/// </summary>
public class CloudError {
	/// <summary>
	/// Fixed machine readable code
	/// </summary>
	public CloudErrorCode Code { get; init; }

	/// <summary>
	/// Humanized error message
	/// </summary>
	public string Message { get; init; }

    /// <summary>
    /// The schema of the error details object depends on the error code. Cast to a different type using the <see cref="CloudErrorCode">HetznerErrorCode</see> when necessary.
    /// </summary>
    public dynamic? Details { get; init; }

    public CloudError(CloudErrorCode? hetznerErrorCode, string message, dynamic details) {
        Message = message;
        Details = details;
        Code = hetznerErrorCode ?? CloudErrorCode.Unknown;
    }

    public CloudError(string hetznerErrorCode, string message, dynamic details) {
        Message = message;
        Details = details;

        try {
            Code = hetznerErrorCode.Convert<CloudErrorCode>();
        }
        catch (ArgumentException e) {
            // todo logging
            Code = CloudErrorCode.Unknown;
        }
    }
}



