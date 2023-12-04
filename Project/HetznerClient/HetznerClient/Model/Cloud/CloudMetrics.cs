using Newtonsoft.Json;

namespace HetznerClient.Model.Cloud;

public class CloudMetrics {
	[JsonProperty("end")]
	public DateTime End { get; set; }

	[JsonProperty("start")]
	public DateTime Start { get; set; }

	[JsonProperty("step")]
	public long Step { get; set; }

	[JsonProperty("time_series")]
	public dynamic TimeSeries { get; set; }
}
