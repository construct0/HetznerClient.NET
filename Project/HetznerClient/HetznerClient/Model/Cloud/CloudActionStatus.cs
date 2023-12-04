using HetznerClient.Model.Attributes;

namespace HetznerClient.Model.Cloud;

/// <summary>
/// Status of the Action
/// </summary>
public enum CloudActionStatus {
	[EnumValue("success")]
	Success = 1,

	[EnumValue("running")]
    Running = 0,

    [EnumValue("error")]
    Error = 2
}
