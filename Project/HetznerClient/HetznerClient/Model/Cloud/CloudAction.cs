using HetznerClient.Logic.Extensions;
using Newtonsoft.Json;

namespace HetznerClient.Model.Cloud;

/// <summary>
/// Actions show the results and progress of asynchronous requests to the API.
/// </summary>
public partial class CloudAction {
    /// <summary>
    /// Command executed in the Action
    /// </summary>
    [JsonProperty("command")]
	public string Command { get; set; }

    /// <summary>
    /// Error message for the Action if error occurred, otherwise null
    /// </summary>
    [JsonProperty("error")]
	public CloudError? Error { get; set; }

	/// <summary>
	/// Point in time when the Action was finished (in ISO-8601 format). Only set if the Action is finished otherwise null
	/// </summary>
	public DateTime Finished { get; set; }

    /// <summary>
    /// ID of the Resource
    /// </summary>
    public long Id { get; set; }

	/// <summary>
	/// Progress of Action in percent
	/// </summary>
	public double Progress { get; set; }

    // todo may need to be refactored to use a better type (smt shared between slices? tbd)
    /// <summary>
    /// Resources the Action relates to
    /// </summary>
    public List<CloudActionResource> Resources { get; set; }

	/// <summary>
	/// Point in time when the Action was started (in ISO-8601 format)
	/// </summary>
	public DateTime Started { get; set; }

    /// <summary>
    /// Status of the Action
    /// </summary>
	public CloudActionStatus Status { get; set; }

	public CloudAction(string command, CloudError? error, DateTime started, DateTime finished, string status, int id, int progress, List<CloudActionResource> resources) : this(command, error, started, finished, status.Convert<CloudActionStatus>(), id, progress, resources) { }

    public CloudAction(string command, CloudError? error, DateTime started, DateTime finished, CloudActionStatus status, int id, int progress, List<CloudActionResource> resources)
    {
        Command = command ?? throw new ArgumentNullException(nameof(command));
        Error = error;
        Started = started;
        Finished = finished;
        Status = status;
        Id = id;
        Progress = progress;
        Resources = resources ?? throw new ArgumentNullException(nameof(resources));
    }
}
