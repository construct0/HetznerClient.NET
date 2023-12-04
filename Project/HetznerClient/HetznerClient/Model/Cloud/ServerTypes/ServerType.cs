using HetznerClient.Model.Cloud.Pricing;
using HetznerClient.Model.Cloud.Servers;
using Newtonsoft.Json;

namespace HetznerClient.Model.Cloud.ServerTypes;

/// <summary>
/// Describes the type of Server - displays how much ram, disk and cpu a <see cref="Server"/> has
/// </summary>
public partial class ServerType {
    /// <summary>
    /// Number of cpu cores a Server of this type will have
    /// </summary>
    [JsonProperty("cores")]
    public long Cores { get; set; }

    /// <summary>
    /// Type of CPU
    /// </summary>
    [JsonProperty("cpu_type")]
    public ServerCPUType CPUType { get; set; }

    /// <summary>
    /// True if Server type is deprecated
    /// </summary>
    [JsonProperty("deprecated")]
    public bool Deprecated { get; set; }

    /// <summary>
    /// Provides more information about a purported deprecation, when this object is available (not always), refer to the <see cref="Deprecated"/> bool for more accurate alignment.
    /// </summary>
    [JsonProperty("deprecation", Required = Required.AllowNull)]
    public DeprecationInsight? Deprecation { get; set; } = null;

    /// <summary>
    /// Description of the Server type
    /// </summary>
    [JsonProperty("description")]
    public string Description { get; set; }

    /// <summary>
    /// Disk size a Server of this type will have in GB
    /// </summary>
    [JsonProperty("disk")]
    public double Disk { get; set; }

    /// <summary>
    /// ID of the Server type
    /// </summary>
    [JsonProperty("id")]
    public long Id { get; set; }

    /// <summary>
    /// Memory a Server of this type will have in GB
    /// </summary>
    [JsonProperty("memory")]
    public double Memory { get; set; }

    /// <summary>
    /// Unique identifier of the Server type
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; set; }

    /// <summary>
    /// Prices in different Locations
    /// </summary>
    [JsonProperty("prices")]
    public List<PricingServerTypePrice> Prices { get; set; }

    /// <summary>
    /// Type of Server boot drive. Local has higher speed. Network has better availability.
    /// </summary>
    [JsonProperty("storage_type")]
    public ServerStorageType StorageType { get; set; }
}
